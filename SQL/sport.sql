use master;
go -- dajemo mu vremena da se prebaci 

-- brišem postojeæu bazu ako postoji
drop database if exists klub;
go
-- kreiram novu bazu
create database klub;
go
-- pozicioniram se na bazu
use klub;
go
-- kreiram tablice

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan datetime not null,
stadion varchar(30) not null,
predsjednik varchar(30),
drzava varchar(50) not null, 
liga varchar(50)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datum_rodenja datetime not null,
pozicija varchar(10), 
broj_dresa int not null,
klub int references klub(sifra)
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null, 
vrijeme time not null,
lokacija varchar(30),
stadion varchar(50),
domaci_klub int references klub(sifra),
gostujuci_klub int references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
klub int references klub(sifra),
nacionalnost varchar(50),
iskustvo varchar(10)
);

