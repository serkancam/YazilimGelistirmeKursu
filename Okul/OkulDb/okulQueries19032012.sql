use okul
go
--her ��rencinin girdi�i ders say�s�
select ogr.ogrenciAdi+' '+ogr.ogrenciSoyadi AS adi,p.derssay�s� from ogrenci as ogr inner join
(select o.ogrenciTc,count(d.dersAdi)as derssay�s� from ogrenci as o inner join siniflar  as s
on o.sinif=s.sinifId inner join sinifDersleri as sd
on s.sinifId=sd.sinifId inner join dersler as d
on sd.dersId=d.dersId
group by o.ogrenciTc)as p on p.ogrenciTc=ogr.ogrenciTc


