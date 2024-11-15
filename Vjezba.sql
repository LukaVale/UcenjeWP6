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
('Marko', 'Radoš', 'rados.marko05@gmail.com'),
('Tena', 'Vuliæ', 'tena.vulic@gmail.com'),
('Karlo', 'Biliæ', 'karlo.bilic2003@gmail.com'),
('Tin', 'Pintariæ', 'tin.pinta@gmail.com'),
('Zoran', 'Pokupiæ', 'zoran.pokupic@gmail.com'),
('Matija', 'Pokupiæ', 'matija.pokupic0712@gmail.com'),
('Marta', 'Došen', 'martagranat18@gmail.com'),
('Luka', 'Valentiæ', 'lukavalentic.lv@gmail.com'),
('Adam', 'Šoltiæ', 'soltic@gmail.com'),
('Robert', 'Mateašiæ', 'robert.mateasic@gmail.com'),
('Tanja', 'Janus', 'janustanja@gmail.com'),
('Andrej', 'Mjeda', 'andrej.mjeda@gmail.com'),
('Marina (Josip)', 'Turalija', 'marinamiochr@gmail.com'),
('Bernarda', 'Lusch', 'bernarda.lusch@gmail.com'),
('Boris', 'Horvat', 'bhorv4t@gmail.com'),
('Robert', 'Kokiæ', 'kokic2001@gmail.com'),
('Ivan', 'Grevinger', 'grevinger.ivan@gmail.com'),
('Marko', 'Grgiæ', 'marko.grg97@gmail.com'),
('Pamela', 'Mandiæ', 'pamelamandic46@gmail.com'),
('Darko', 'Azinoviæ', 'darko.azinovic@gmail.com'),
('Dino', 'Dizdareviæ', 'dinodizdarevic2001@gmail.com'),
('Luka', 'Kordiæ', 'kordic234@gmail.com'),
('Ivan', 'Režan', 'forexivanrezan@gmail.com'),
('Antonio', 'Simpf', 'antonijosimpf@gmail.com');
