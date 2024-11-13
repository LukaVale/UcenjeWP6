use master;
go -- dajemo mu vremena da se prebaci 

-- brišem postojeæu bazu ako postoji
drop database if exists edunovawp6;
go
-- kreiram novu bazu
create database edunovawp6;
go
-- pozicioniram se na bazu
use edunovawp6;
go
-- kreiram tablice

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
IBAN varchar(50) not null
);

create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(30) not null,
maks_broj int not null,
mjesto varchar(30) not null
);

create table datum(
sifra int not null primary key identity(1,1),
d_rodenja datetime,
d_dolaska datetime,
d_smrti datetime
);

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int references djelatnik(sifra),
prostorija int references prostorija(sifra),
datum int references datum(sifra)
)