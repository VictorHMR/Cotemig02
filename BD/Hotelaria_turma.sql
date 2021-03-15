create database Hotelaria_turma;
use Hotelaria_turma;
create table Cliente(
cod int unsigned auto_increment not null,
Nome varchar(80) not null,
CPF int unsigned not null,
Tipo_convenio varchar(40) not null,
primary key(cod)
)engine=innodb;

create table servico_copa(
cod int unsigned auto_increment not null,
registro varchar(100) not null,
tipo_servico varchar(40),
primary key(cod)
)engine=InnoDB;

create table Reserva(
cod int unsigned auto_increment not null,
DataInicio date not null,
DataFim date not null,
quarto int unsigned not null,
Valor double(9,2) not null,
Cliente_cod int unsigned not null,
primary key(cod),
foreign key(Cliente_cod) references Cliente(cod)
)engine=InnoDB;

create table Hospede(
cod int unsigned auto_increment not null,
nome varchar(80) not null,
Telefone char(15) not null,
Email Varchar(60) not null,
Reserva_cod int unsigned not null,
primary key(cod),
foreign key(Reserva_cod) references Reserva(cod)
)engine=InnoDB;

create table Quarto(
cod int unsigned auto_increment not null,
numero int unsigned not null,
andar int unsigned not null,
classificacao varchar(40) not null,
Hospede_cod int unsigned not null,
primary key(cod),
foreign key(Hospede_cod) references Hospede(cod)
)engine=InnoDB;

create table servicos(
cod int unsigned auto_increment not null,
itens varchar(50) not null,
tipo varchar(50) not null,
observacao varchar(100),
Quarto_cod int unsigned not null,
servico_copa_cod int unsigned not null,
primary key(cod),
foreign key(Quarto_cod)references Quarto(cod),
foreign key(servico_copa_cod)references servico_copa(cod)
)engine=InnoDB;

insert into Cliente(cod, Nome, CPF, Tipo_convenio) values(null, "Jotaro", 8646554, "Premium");
insert into Cliente(cod, Nome, CPF, Tipo_convenio) values(null, "Joseph", 6666554, "comum");
insert into Cliente(cod, Nome, CPF, Tipo_convenio) values(null, "Josuke", 3336554, "Premium");

select cod from servico_copa;

insert into Reserva(cod, DataInicio, DataFim, quarto, Valor, Cliente_cod) values(null, 24/05/2004, 29/05/2004, 05, 94.50, 4);
insert into Reserva(cod, DataInicio, DataFim, quarto, Valor, Cliente_cod) values(null, 25/05/2004, 27/05/2004, 09, 94.50, 2);
insert into Reserva(cod, DataInicio, DataFim, quarto, Valor, Cliente_cod) values(null, 21/05/2004, 22/05/2004, 01, 94.50, 1);

insert into Hospede(cod, nome, Telefone, Email, Reserva_cod) values(null, "Jotaro", "30197394", "Jotaro@jotaro.com", 4 );
insert into Hospede(cod, nome, Telefone, Email, Reserva_cod) values(null, "Joseph", "30707394", "Josepho@joseph.com", 2 );
insert into Hospede(cod, nome, Telefone, Email, Reserva_cod) values(null, "Jotaro", "30907394", "Josuke@josuke.com", 1 );

insert into Quarto(cod, numero, andar, classificacao, Hospede_cod) values(null, 05, 02, "Premium", 3);
insert into Quarto(cod, numero, andar, classificacao, Hospede_cod) values(null, 09, 02, "comum", 2);
insert into Quarto(cod, numero, andar, classificacao, Hospede_cod) values(null, 01, 02, "Premium", 1);

insert into servico_copa(cod, registro, tipo_servico) values(null, "janta", "Comida");
insert into servico_copa(cod, registro, tipo_servico) values(null, "almoço", "Comida");
insert into servico_copa(cod, registro, tipo_servico) values(null, "janta", "Comida");

insert into servicos(cod, itens, tipo, observacao, Quarto_cod, servico_copa_cod) values(null, "1", "comida", "Sem molho", 4, 1 );
insert into servicos(cod, itens, tipo, observacao, Quarto_cod, servico_copa_cod) values(null, "1", "comida", "Sem molho", 3, 2);
insert into servicos(cod, itens, tipo, observacao, Quarto_cod, servico_copa_cod) values(null, "1", "comida", "Sem molho", 2, 3);
insert into servicos(cod, itens, tipo, observacao, Quarto_cod, servico_copa_cod) values(null, "1", "comida", "Sem molho", 2, 3);

delete from Reserva where valor > 100;
delete from hospede;
update Reserva set valor = 100 where DataInicio = 19/08/2020;
select Reserva where  DataInicio > 01/05/20018 and DataInicio < 31/06/2018;
select count(cod) FROM cliente;



select nome, DataInicio, DataFim from Cliente  join reserva on  Cliente_cod = reserva.Cliente_cod;

select count(nome) from Cliente join reserva on  Cliente_cod = reserva.Cliente_cod where quarto = 2;

select nome from Cliente join reserva on  Cliente_cod = reserva.Cliente_cod where quarto = 3;

select  valor, quarto from reserva where DataInicio = 2020/08/08;

select count(*) Clientes_cod from reserva where Cliente_cod >= 1 && Cliente_cod <= 3;

select sum(Valor) from reserva where Cliente_cod >= 1 && Cliente_cod <= 2;

select avg(Valor) from reserva where Cliente_cod >=4;

select nome, telefone, numero, andar from hospede join quarto on  Hospede_cod = Hospede_cod;

select nome from hospede join quarto on Hospede_cod = Hospede_cod where numero = 2;

select count(*) from hospede join quarto on Hospede_cod = Hospede_cod where andar =3;

select classificacao from quarto join hospede on Hospede_cod= Hospede_cod where nome = "carlos"; 

select count(*) from servicos join quarto where Quarto_cod = Quarto.cod;

select count(*) from servicos join quarto on Hospede_cod = 3 where numero = 2;

select tipo_servico, itens from servicos join servico_copa on Quarto_cod >=8;

select numero, itens from servicos join quarto on Quarto_cod = Quarto.cod where tipo = "limpeza";


