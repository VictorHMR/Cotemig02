create database Projeto_Mesadinha;
use Projeto_Mesadinha;

create table usuarios(
codigo int unsigned auto_increment not null primary key,
nome varchar(80) not null,
endereco varchar(80) not null,
telefone char(15) not null,
email varchar(100) not null,
senha varchar(150) not null
)engine=innodb;


create table categoria(
codigo int unsigned auto_increment not null primary key,
nome varchar(80) not null ,
usuarios_codigo int unsigned not null,
foreign key (usuarios_codigo) references usuarios(codigo)
)engine=innodb;

create table contas(
codigo int unsigned auto_increment not null primary key,
nome varchar(80) not null,
tipo varchar(80) not null,
categoria_codigo int unsigned not null,
usuarios_codigo int unsigned not null,
foreign key (categoria_codigo) references categoria(codigo),
foreign key (usuarios_codigo) references usuarios(codigo)
)engine=innodb;

create table movimentacao(
codigo int unsigned auto_increment not null primary key,
valor varchar(20) not null,
dt date,
contas_codigo int unsigned not null,
foreign key (contas_codigo) references contas(codigo)
)engine=innodb;