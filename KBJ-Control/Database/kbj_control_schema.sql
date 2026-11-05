-- Schema para criação de uma base nova. Não migra tabelas existentes.
-- MySQL 8.0.16+ para aplicação das constraints CHECK.
CREATE DATABASE IF NOT EXISTS kbj_control
    CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;

USE kbj_control;

CREATE TABLE IF NOT EXISTS visitantes (
	visitante_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(30) NOT NULL,
    sobrenome VARCHAR(30) NOT NULL,
    telefone VARCHAR(20) NULL,
    email VARCHAR(150),
    tipo_documento ENUM(
		'RG', 'CPF', 'PASSAPORTE'
	) NOT NULL,
    codigo_legal VARCHAR(20) NOT NULL,
    pais_emissor VARCHAR(30) NOT NULL,
    data_nascimento DATE NULL,
    data_registro DATETIME DEFAULT(CURRENT_TIMESTAMP()) NOT NULL,
    
    CONSTRAINT uq_visitantes_documento
        UNIQUE (tipo_documento, codigo_legal, pais_emissor),
    CONSTRAINT chk_visitantes_email
		CHECK(
			email REGEXP('^[^[:space:]@]+@[^[:space:]@]+[.][^[:space:]@]+$')
		)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS funcionarios (
	funcionario_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(30) NOT NULL,
    sobrenome VARCHAR(30) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    email VARCHAR(150) NOT NULL,
    cpf VARCHAR(11) NOT NULL,
    data_nascimento DATE NOT NULL,
    data_registro DATETIME DEFAULT(CURRENT_TIMESTAMP()) NOT NULL,
    
    CONSTRAINT uq_funcionarios_cpf UNIQUE (cpf),
    CONSTRAINT chk_funcionarios_email
		CHECK(
			email REGEXP('^[^[:space:]@]+@[^[:space:]@]+[.][^[:space:]@]+$')
		),
	CONSTRAINT chk_funcionarios_cpf
		CHECK(
			cpf REGEXP '^[0-9]{11}$'
		)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS usuarios (
	usuario_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    funcionario_id INT UNSIGNED NULL,
    nome_usuario VARCHAR(100) NOT NULL,
    senha_hash VARCHAR(255) NOT NULL,
    status_ativo ENUM(
		'ATIVA', 'PAUSADA', 'ENCERRADA'
	) DEFAULT('ATIVA') NOT NULL,
    data_registro DATETIME DEFAULT(CURRENT_TIMESTAMP()) NOT NULL,
    CONSTRAINT uq_usuarios_nome UNIQUE (nome_usuario),
    CONSTRAINT uq_usuarios_funcionario UNIQUE (funcionario_id),
    CONSTRAINT fk_usuarios_funcionarios FOREIGN KEY (funcionario_id)
        REFERENCES funcionarios (funcionario_id)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS visitas (
	visita_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    visitante_id INT UNSIGNED NOT NULL,
    empresa_origem VARCHAR(150) NULL,
    destino VARCHAR(150) NOT NULL,
    usuario_entrada_id INT UNSIGNED NOT NULL,
    usuario_saida_id INT UNSIGNED NULL,
    -- Impede duas visitas abertas simultâneas para o mesmo visitante.
    visitante_em_andamento_id INT UNSIGNED GENERATED ALWAYS AS
        (CASE WHEN data_saida IS NULL THEN visitante_id ELSE NULL END) STORED,
    data_entrada DATETIME DEFAULT(CURRENT_TIMESTAMP()) NOT NULL,
    data_saida DATETIME,
    motivo_visita ENUM(
		'CLIENTES', 'FORNECEDORES', 'PRESTADOR DE SERVIÇO', 'OUTROS'
	) NOT NULL,
    observacoes VARCHAR(255),
    status_visita ENUM(
		'EM ANDAMENTO', 'ENCERRADA'
	) DEFAULT ('EM ANDAMENTO') NOT NULL,

    CONSTRAINT fk_visitas_visitantes FOREIGN KEY (visitante_id)
        REFERENCES visitantes (visitante_id),
    CONSTRAINT fk_visitas_usuario_entrada FOREIGN KEY (usuario_entrada_id)
        REFERENCES usuarios (usuario_id),
    CONSTRAINT fk_visitas_usuario_saida FOREIGN KEY (usuario_saida_id)
        REFERENCES usuarios (usuario_id),
    CONSTRAINT uq_visitas_abertas UNIQUE (visitante_em_andamento_id),
    INDEX idx_visitas_entrada (data_entrada),
    INDEX idx_visitas_saida (data_saida),
    CONSTRAINT chk_visitas_estado CHECK (
        (status_visita = 'EM ANDAMENTO' AND data_saida IS NULL AND usuario_saida_id IS NULL)
        OR
        (status_visita = 'ENCERRADA' AND data_saida IS NOT NULL AND usuario_saida_id IS NOT NULL)
    ),
    CONSTRAINT chk_visitas_data_saida
		CHECK(
			data_saida >= data_entrada
        )
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS logs_auditoria (
	log_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    usuario_id INT UNSIGNED NOT NULL,
    acao VARCHAR(80) NOT NULL,
    recurso VARCHAR(120),
    endereco_ip VARCHAR(45),
    data_registro DATETIME DEFAULT(CURRENT_TIMESTAMP()) NOT NULL,
    
    CONSTRAINT fk_logs_auditoria_usuarios
		FOREIGN KEY (usuario_id) REFERENCES usuarios (usuario_id)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS funcoes (
	funcao_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao VARCHAR(255)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS permissoes (
	permissao_id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(100) NOT NULL,
    descricao VARCHAR(255)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS usuarios_funcoes (
	usuario_id INT UNSIGNED NOT NULL,
    funcao_id INT UNSIGNED NOT NULL,
    
    PRIMARY KEY (usuario_id, funcao_id),
    CONSTRAINT fk_usuarios_funcoes_usuarios
		FOREIGN KEY (usuario_id) REFERENCES usuarios(usuario_id),
	CONSTRAINT fk_usuarios_funcoes_funcoes
		FOREIGN KEY (funcao_id) REFERENCES funcoes(funcao_id)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS permissoes_funcoes (
	permissao_id INT UNSIGNED NOT NULL,
    funcao_id INT UNSIGNED NOT NULL,
    
    PRIMARY KEY (permissao_id, funcao_id),
    CONSTRAINT fk_permissoes_funcoes_permissoes
		FOREIGN KEY (permissao_id) REFERENCES permissoes(permissao_id),
	CONSTRAINT fk_permissoes_funcoes_funcoes
		FOREIGN KEY (funcao_id) REFERENCES funcoes(funcao_id)
)ENGINE = InnoDB;