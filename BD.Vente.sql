create database Vente

use vente

create table Client
(
	codecl varchar(6) primary key,
	nom varchar(40),
	ville varchar(40)
)
create table article 
(
   codeart varchar (6) primary key ,
   desi varchar (40) ,
   Pu money ,
   Qdipo int 
)
 create table commande 
(
  NumCom varchar (6) primary key ,
  dateCom datetime default getdate (),
  codecl varchar(6) FOREIGN KEY REFERENCES Client (codecl)

)
create table detail 
(
   NumCom varchar (6) foreign key references commande (NumCom),
   codeart varchar (6) foreign key references article (codeart),
   Qte int 
   constraint PK_detail
   primary key (NumCom,codeart)
 )
--Remlisssage des tables :
--1/Remplissage de la table Client :
INSERT INTO Client VALUES ('Cl01','Mouad','Fes')
INSERT INTO Client VALUES ('Cl02','Zaki','Rabat')
INSERT INTO Client VALUES ('Cl03','Yassin','Tanger')
INSERT INTO Client VALUES ('Cl04','Hamza','Mekness')
INSERT INTO Client VALUES ('Cl05','Idriss','Oujda')
INSERT INTO Client VALUES ('Cl06','Karima','Fes')
INSERT INTO Client VALUES ('Cl07','Fatima Zahrae','Tanger')
INSERT INTO Client VALUES ('Cl08','Mohsin','Rabat')
--Affichage de la table Client :
SELECT * FROM Client
 
--2/Remplissage de la table Article :
INSERT INTO Article VALUES ('Art01','Souris',100,1000)
INSERT INTO Article VALUES ('Art02','Carte Mere',200,2000)
INSERT INTO Article VALUES ('Art03','Carte Grafique',300,3000) 
INSERT INTO Article VALUES ('Art04','Imprimante',400,4000)
INSERT INTO Article VALUES ('Art05','Clavier',500,5000)
INSERT INTO Article VALUES ('Art06','Tablette',600,6000)
INSERT INTO Article VALUES ('Art07','Disque Dur',700,7000)
INSERT INTO Article VALUES ('Art08','USB',800,8000)

--Affichage de la table Article :
 SELECT * FROM Article

 --3/Remplissage de la table Commande :
INSERT INTO Commande VALUES ('Cm01','2013/03/03','cl04')
INSERT INTO Commande VALUES ('Cm02','2013/11/11','cl06')
INSERT INTO Commande VALUES ('Cm03','2013/10/10','cl08')
INSERT INTO Commande VALUES ('Cm04','2013/09/09','cl01')
INSERT INTO Commande VALUES ('Cm05','2013/08/08','cl05')
--affichage de la table Commande :
 SELECT * FROM Commande
 
--4/Remplissage de la table detail :
INSERT INTO Detail VALUES ('Cm01','Art01',100)
INSERT INTO Detail VALUES ('Cm05','Art07',500)
INSERT INTO Detail VALUES ('Cm02','Art05',300)
INSERT INTO Detail VALUES ('Cm04','Art03',400)
INSERT INTO Detail VALUES ('Cm01','Art01',100)

--Affichage de la table detail:
 SELECT * FROM Detail

 SELECT * FROM Client 
--1/ - Séléctionner les client de la ville de fes :
SELECT *
FROM Client 
where ville = 'fes'
--2/ - Séléctionner les client dont les nom commancent par 'HA' :
select *
from client 
where nom like 'Ha%'
--3/ - Afficher les client par order alphabétique selon le nom :
select *
from client 
order by nom
--4/ - Sélectionner les commandes d'un client donné dont on connait le nom :
select NumCom , datecom
from commande a
join client b on a.codecl=b.codecl
where nom = 'idriss'   
--5/ - Séléctionner les commandes d'un client de la ville de fes :
select NumCom , datecom
from commande a
join client b on a.codecl=b.codecl
where ville ='fes'
--6/ - Calculer le nombre de commande d'un client donnée on connait le nom :
SELECT Ville, count(NumCom) As NbCommande
FROM Commande a
JOIN Client b ON a.CodeCl = b.codecl
Group by Ville
--7/ - Calculer le nombre de commande par ville :
SELECT Ville, count(NumCom) As NbCommande
FROM Commande a
JOIN Client b ON a.CodeCl = b.codecl
Group by nom ,Ville
--8/ - Séléctionner les commandes d'un passée entre deux dates :
SELECT * 
FROM Commande
WHERE DateCom BETWEEN '2013/03/03' AND '2013/10/10'
--9/ - Calculer le mantant des lignes d'une commande :
SELECT PU * Qte AS Mantant 
FROM Article a
JOIN Detail b ON a.CodeArt = b.CodeArt
WHERE NumCom = 'Cm02'

--10/ -Calculer le total d'une Commande :
SELECT sum(PU * Qte) AS  Totalss
FROM Article a
JOIN Detail b ON a.CodeArt = b.CodeArt
where NumCom = 'Cm01' 

--11/ -Calculer le total des totaux de des commandes d'un client (Chiffre d'affaire d'un client) :
select sum (PU * Qte) as chiffredaffaire
from Article a 
join Detail b on a.CodeArt = b.CodeArt
join Commande c on b.NumCom = c.NumCom

-- PS
--1
create proc nbreCmd
	@Code  Varchar(20),
	@NbCmd  int  output
As
	Select @NbCmd = Count(NumCom) 
	From Commande
	Where codecl = @Code  
			  
Declare @NbCom int
Exec   nbreCmd  'Cl01' , @NbCom output
Select  'Le nombre de commandes est : ' , @NbCom

--2
create proc nbreCmdVille
	@ville varchar(20),
	@nbrCmd int output
as
	set @nbrCmd=(select COUNT(NumCom) 
				from commande c join Client cl on c.codecl=cl.codecl
				where ville=@ville)
				
declare @nbrCom int
exec nbreCmdVille 'fes' ,@nbrCom output
Select  'Le nombre de commandes est : ' , @nbrCom

--3
Create proc nbrCmdVilleDate
	 @ville varchar(20),
	 @date datetime ,
	 @nbCmd int output 
 as
	select 
	
--PS
create proc ps_insert
	@codecl varchar(6),
	@nom varchar(40),
	@ville varchar(40)
as
	insert into Client values(@codecl,@nom,@ville)
	
	exec ps_insert 'cl007','younes','fes'
	
CREATE PROCEDURE PS_Update

	@codecl varchar(5),
	@nom varchar(50),
	@ville varchar(50)
	
AS
Update Client Set nom=@nom,ville=@ville Where codecl=@codecl

create proc ps_select
	@codecl varchar(6),
	@nom varchar(40) output,
	@ville varchar(40) output
as
	select @nom=nom,@ville=ville from Client where codecl=@codecl
	
create proc ps_delete
	@codecl varchar(6)
as
	delete Client where codecl=@codecl

 
--index
create index PiIndex
on client(nom,ville)
