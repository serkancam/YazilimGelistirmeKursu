use okul
go
-- 11-B s�n�f�ndaki ��rencilerin listersi
--select o.ogrenciAdi+' '+o.ogrenciSoyadi as ad�,
--CAST(s.sinif as varchar)+'-'+s.sube as s�n�f�
--from ogrenci as o inner join siniflar as s
--on o.sinif=s.sinifId
--where s.sinif=11 and s.sube='B'
--order by s.sinifId ASC 

-- 11-B s�n�f�ndaki ��rencilerin say�s�
--select count(*) as adet
--from ogrenci as o inner join siniflar as s
--on o.sinif=s.sinifId
--where s.sinif=11 and s.sube='B'
--group by o.sinif

--s�n�flar�n ��renci say�lar�
-- 11-B s�n�f�ndaki ��rencilerin say�s�
select o.sinif,count(*) as adet
from ogrenci as o inner join siniflar as s
on o.sinif=s.sinifId
group by o.sinif