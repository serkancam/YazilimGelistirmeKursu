use okul
go
--her öðrencinin girdiði ders sayýsý
select ogr.ogrenciAdi+' '+ogr.ogrenciSoyadi AS adi,p.derssayýsý from ogrenci as ogr inner join
(select o.ogrenciTc,count(d.dersAdi)as derssayýsý from ogrenci as o inner join siniflar  as s
on o.sinif=s.sinifId inner join sinifDersleri as sd
on s.sinifId=sd.sinifId inner join dersler as d
on sd.dersId=d.dersId
group by o.ogrenciTc)as p on p.ogrenciTc=ogr.ogrenciTc


