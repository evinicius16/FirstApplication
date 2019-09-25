drop database bd_venda_alunos;
create database bd_venda_alunos;
use bd_venda_alunos;

create table Empresa(
codigo int auto_increment not null primary key,
nome varchar(60),
endereco varchar(45),
cidade varchar(45),
email varchar(60),
telefone char(15),
site varchar(60)
);

create table Produto(
codigo int auto_increment not null primary key,
descricao varchar(60),
quantidade int,
valor double,
empresa int,
foreign key(empresa) references empresa(codigo) 
);

create table clientes(
codigo int auto_increment not null primary key,
nome varchar(60),
endereco varchar(45),
cidade varchar(45),
estado char(2),
telefone char(15)
);

create table funcionarios(
cpf char(14) not null primary key,
nome varchar(60),
endereco varchar(45),
cidade varchar(45),
estado char(2),
telefone char(15),
datanascimento date,
email varchar(60),
login varchar(45),
senha char(6)
);

create table vendas(
codigo int auto_increment not null primary key,
descricao varchar(60),
data_venda date,
total double,
observacao varchar(80),
cliente int,
funcionario char(14),
foreign key(cliente) references clientes(codigo),
foreign key(funcionario) references funcionarios(cpf)
);

create table itens_vendas(
codigo int auto_increment not null primary key,
valor_unit double,
quantidade int,
total double,
vendas int,
produtos int,
foreign key(vendas) references vendas(codigo),
foreign key(produtos) references produto(codigo)
);










