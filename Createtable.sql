create table Historico_Aprovacao
(
    id_sequencial int primary key,
    usuario varchar(30),
    data datetime,
	senha varchar(30),
	operacao varchar(50)
)

Create unique index ix_id on id_sequencial (id_sequencial)


---drop table Historico_Aprovacao
