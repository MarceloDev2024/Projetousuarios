create table Configura_Faixas
(
    id_sequencial int primary key,
	faixa varchar(100),
	vistos varchar(10),
    aprovacoes varchar(10)
)

Create unique index ix_id on id_sequencial (id_sequencial)

--drop table Configura_Faixas