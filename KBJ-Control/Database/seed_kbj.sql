USE kbj_control;
INSERT INTO usuarios (nome_usuario, senha_hash) 
VALUES ('joao_silva', '$2a$12$/yPIJZlHpZacbMwtTkflqe7CrDRJC1hwDvHV7LF5WotT4ogMEvQjm');

INSERT INTO usuarios (nome_usuario, senha_hash) 
VALUES ('bgn', '$2a$12$/yPIJZlHpZacbMwtTkflqe7CrDRJC1hwDvHV7LF5WotT4ogMEvQjm');

SELECT usuario_id, nome_usuario
FROM usuarios
WHERE status_ativo = 'ATIVA';

SET @usuario_id = 2;
SET @agora = NOW();

START TRANSACTION;

-- 1. Visitante presente, com empresa de origem.
INSERT INTO visitantes (
    nome, sobrenome, telefone, email,
    tipo_documento, codigo_legal, pais_emissor,
    data_nascimento, data_registro
)
VALUES (
    'Rafael', 'Martins', NULL, 'rafael@example.com',
    'RG', 'TESTE-RG-001', 'Brasil',
    '1992-05-14', @agora
);

SET @rafael_id = LAST_INSERT_ID();

INSERT INTO visitas (
    visitante_id, empresa_origem, destino,
    usuario_entrada_id, usuario_saida_id,
    data_entrada, data_saida,
    motivo_visita, observacoes, status_visita
)
VALUES (
    @rafael_id, 'Expresso Norte', 'Almoxarifado',
    @usuario_id, NULL,
    @agora, NULL,
    'FORNECEDORES', 'Entrega de materiais — teste.',
    'EM ANDAMENTO'
);


-- 2. Visitante presente, sem empresa de origem.
INSERT INTO visitantes (
    nome, sobrenome, telefone, email,
    tipo_documento, codigo_legal, pais_emissor,
    data_nascimento, data_registro
)
VALUES (
    'Beatriz', 'Oliveira', NULL, 'beatriz@example.com',
    'RG', 'TESTE-RG-002', 'Brasil',
    '1998-09-22', @agora
);

SET @beatriz_id = LAST_INSERT_ID();

INSERT INTO visitas (
    visitante_id, empresa_origem, destino,
    usuario_entrada_id, usuario_saida_id,
    data_entrada, data_saida,
    motivo_visita, observacoes, status_visita
)
VALUES (
    @beatriz_id, NULL, 'Camila Melo / Marketing',
    @usuario_id, NULL,
    @agora, NULL,
    'CLIENTES', 'Atendimento comercial — teste.',
    'EM ANDAMENTO'
);


-- 3. Visita encerrada hoje.
-- Meia-noite e horário atual evitam gerar horários futuros.
INSERT INTO visitantes (
    nome, sobrenome, telefone, email,
    tipo_documento, codigo_legal, pais_emissor,
    data_nascimento, data_registro
)
VALUES (
    'João Pedro', 'Santos', NULL, 'joao@example.com',
    'RG', 'TESTE-RG-003', 'Brasil',
    '1987-03-08', @agora
);

SET @joao_id = LAST_INSERT_ID();

INSERT INTO visitas (
    visitante_id, empresa_origem, destino,
    usuario_entrada_id, usuario_saida_id,
    data_entrada, data_saida,
    motivo_visita, observacoes, status_visita
)
VALUES (
    @joao_id, 'Vértice Engenharia', 'Paulo Nunes / Engenharia',
    @usuario_id, @usuario_id,
    TIMESTAMP(CURRENT_DATE()), @agora,
    'PRESTADOR DE SERVIÇO', 'Manutenção concluída — teste.',
    'ENCERRADA'
);


-- 4. Visita encerrada ontem, para testar o Histórico.
INSERT INTO visitantes (
    nome, sobrenome, telefone, email,
    tipo_documento, codigo_legal, pais_emissor,
    data_nascimento, data_registro
)
VALUES (
    'Ana Paula', 'Ribeiro', NULL, 'ana@example.com',
    'RG', 'TESTE-RG-004', 'Brasil',
    '1995-11-30',
    TIMESTAMP(CURRENT_DATE() - INTERVAL 1 DAY, '08:00:00')
);

SET @ana_id = LAST_INSERT_ID();

INSERT INTO visitas (
    visitante_id, empresa_origem, destino,
    usuario_entrada_id, usuario_saida_id,
    data_entrada, data_saida,
    motivo_visita, observacoes, status_visita
)
VALUES (
    @ana_id, 'Prisma Tecnologia', 'Fernanda Rocha / TI',
    @usuario_id, @usuario_id,
    TIMESTAMP(CURRENT_DATE() - INTERVAL 1 DAY, '09:00:00'),
    TIMESTAMP(CURRENT_DATE() - INTERVAL 1 DAY, '10:30:00'),
    'PRESTADOR DE SERVIÇO', 'Suporte técnico concluído — teste.',
    'ENCERRADA'
);

COMMIT;