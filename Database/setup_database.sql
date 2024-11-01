-- Tabela de pessoas
CREATE TABLE "Pessoas" (
    "Id" SERIAL PRIMARY KEY,
    "NomeCompleto" VARCHAR(255) NOT NULL,
    "DataNascimento" DATE NOT NULL,
    "CPF" VARCHAR(14) NOT NULL UNIQUE,
    "Rua" VARCHAR(255),
    "Numero" INTEGER,
    "Logradouro" VARCHAR(20)
    "Cidade" VARCHAR(100),
    "Estado" VARCHAR(2),
    "CEP" VARCHAR(10),
    "Telefone" VARCHAR(15),
    "Email" VARCHAR(255)
);
