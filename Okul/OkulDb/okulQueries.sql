use okul
go
--select * from ogrenci
--insert into ogrenci(ogrenciTc,ogrenciNo,ogrenciAdi,ogrenciSoyadi,sinif)
--values ('30721475298','25','serkan','�am',5)
--select * from ogrenci
--update ogrenci
--set ogrenciAdi='Hasan', ogrenciSoyadi='KABZE'
--where ogrenciTc='30721475292'
--update ogrenci
--set sinif=25
--where ogrenciAdi='serkan'

--select * from ogrenci

--delete from ogrenci
--where ogrenciTc='30721475298'
--delete from ogrenci
--where ogrenciAdi='veli'

--select * from ogrenci

--insert into ogrenci(ogrenciTc,ogrenciNo,ogrenciAdi,ogrenciSoyadi,sinif)
--values ('30721475300','25','serkan','�am',5)
--select * from ogrenci

--select ogrenciAdi, ogrenciSoyadi from ogrenci

--select ogrenciAdi + ' '+ ogrenciSoyadi as ogrenci,ogrenciNo 
--from ogrenci

--select ogrenciAdi + ' '+ ogrenciSoyadi+'--'+ogrenciNo 
--as ogrenci
--from ogrenci

--select ogrenciAdi as ad�, ogrenciSoyadi as soyad� 
--from ogrenci order by ogrenciNo asc

--select sinifId,sinif,sube from siniflar

--select sinifId, cast(sinif as varchar)+'-'+sube as s�n�f 
--from siniflar 
--order by sube asc
----1 kartezyen �arp�m
--select s.sinif,o.ogrenciAdi +' '+ o.ogrenciSoyadi+'-'+o.ogrenciNo as o�renci
--from siniflar as s ,ogrenci as o

----2 iki tabloyu birle�tirme (natural birle�tirme)
--select s.sinifId,o.ogrenciAdi+ ' '+o.ogrenciSoyadi,
--o.ogrenciTc
--from siniflar as s,ogrenci as o
--where s.sinifId=o.sinif

----3 iki tabloyu birle�tirme (join ile birle�tirme)
--select s.sinifId,o.ogrenciAdi+ ' '+o.ogrenciSoyadi as O�renci_Ad�,
--o.ogrenciTc
--from siniflar as s inner join ogrenci as o
--on s.sinifId=o.sinif
--order by s.sinif asc

select * from ogrenci
where ogrenciSoyadi like '_[A-H]%'



