select * from smjerovi
--1
insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('web programiranje', 1225.48, '2024-11-06 17:00', 1);

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values
--2
('Java programiranje',null ,null ,null ),
--3
('Serviser', 800, '2020-01-01', 0);

create table clanovi(
grupa int not null references grupe(sifra),
polaznik int not null references polaznici(sifra)
);

insert into grupe(naziv,velicinagrupe,smjer)
values
--1
('wp6', 30, 1),
--2
('wp5', 27,1),
--3
('wp7', 27,1),
--4
('jp17',11,3);

INSERT INTO polaznici (ime, prezime, email) VALUES 
('Marko', 'Rado�', 'rados.marko05@gmail.com'),
('Tena', 'Vuli�', 'tena.vulic@gmail.com'),
('Karlo', 'Bili�', 'karlo.bilic2003@gmail.com'),
('Tin', 'Pintari�', 'tin.pinta@gmail.com'),
('Zoran', 'Pokupi�', 'zoran.pokupic@gmail.com'),
('Matija', 'Pokupi�', 'matija.pokupic0712@gmail.com'),
('Marta', 'Do�en', 'martagranat18@gmail.com'),
('Luka', 'Valenti�', 'lukavalentic.lv@gmail.com'),
('Adam', '�olti�', 'soltic@gmail.com'),
('Robert', 'Matea�i�', 'robert.mateasic@gmail.com'),
('Tanja', 'Janus', 'janustanja@gmail.com'),
('Andrej', 'Mjeda', 'andrej.mjeda@gmail.com'),
('Marina (Josip)', 'Turalija', 'marinamiochr@gmail.com'),
('Bernarda', 'Lusch', 'bernarda.lusch@gmail.com'),
('Boris', 'Horvat', 'bhorv4t@gmail.com'),
('Robert', 'Koki�', 'kokic2001@gmail.com'),
('Ivan', 'Grevinger', 'grevinger.ivan@gmail.com'),
('Marko', 'Grgi�', 'marko.grg97@gmail.com'),
('Pamela', 'Mandi�', 'pamelamandic46@gmail.com'),
('Darko', 'Azinovi�', 'darko.azinovic@gmail.com'),
('Dino', 'Dizdarevi�', 'dinodizdarevic2001@gmail.com'),
('Luka', 'Kordi�', 'kordic234@gmail.com'),
('Ivan', 'Re�an', 'forexivanrezan@gmail.com'),
('Antonio', 'Simpf', 'antonijosimpf@gmail.com');
