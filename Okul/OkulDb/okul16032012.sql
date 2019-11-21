use okul
go
--select s.sinifId,CAST(s.sinif as varchar)+'-'+s.sube as sinif
--from siniflar as s

--select sd.dersId,d.dersAdi
--from sinifDersleri as sd inner join dersler as d
--on sd.dersId=d.dersId
--where sd.sinifId=32

--select d.donemId,d.yili+' ' +CAST(d.donem as varchar)+'. Dönem' as donem 
--from donemler as d

--select  o.ogrenciNo,o.ogrenciAdi+' '+o.ogrenciSoyadi as adi,n.puani,nt.notAdi
--from ogrenci as o left outer join notlar as n
--on o.ogrenciTc=n.ogrenci left outer join notTurleri as nt 
--on n.turId=nt.notId
select p.*
from
(
select o.ogrenciAdi,o.ogrenciSoyadi,n.* from notlar as n inner join ogrenci as o
on n.ogrenci=o.ogrenciTc
)piv
pivot
(
max(puani)
for turId in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])

) as p
where dersId=6 AND donem=5 AND ogrenci in(select o.ogrenciTc from ogrenci as o where o.sinif=32)


