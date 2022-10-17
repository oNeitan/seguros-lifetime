USE Teste

IF OBJECT_ID('Pessoa', 'U') IS NOT NULL  
DROP TABLE Pessoa; 
GO

CREATE TABLE Pessoa (
ID int PRIMARY KEY IDENTITY NOT NULL,
Nome varchar(100) NOT NULL,
CPF varchar(11)NOT NULL,
Email varchar(100) NOT NULL,
Telefone varchar(100) NOT NULL,
Senha varchar(20) NOT NULL );
