use okul
go
-- 11-B sýnýfýndaki öðrencilerin listersi
--select o.ogrenciAdi+' '+o.ogrenciSoyadi as adý,
--CAST(s.sinif as varchar)+'-'+s.sube as sýnýfý
--from ogrenci as o inner join siniflar as s
--on o.sinif=s.sinifId
--where s.sinif=11 and s.sube='B'
--order by s.sinifId ASC 

-- 11-B sýnýfýndaki öðrencilerin sayýsý
--select count(*) as adet
--from ogrenci as o inner join siniflar as s
--on o.sinif=s.sinifId
--where s.sinif=11 and s.sube='B'
--group by o.sinif

--sýnýflarýn öðrenci sayýlarý
-- 11-B sýnýfýndaki öðrencilerin sayýsý
select o.sinif,count(*) as adet
from ogrenci as o inner join siniflar as s
on o.sinif=s.sinifId
group by o.sinif