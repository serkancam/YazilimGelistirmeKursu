use okul
go
--select d.donemId,d.yili+' ' +CAST(d.donem as varchar)+'. Dönem' as donem from donemler as d

--select sd.dersId,d.dersAdi 
--from sinifDersleri as sd inner join dersler as d on sd.dersId=d.dersId where sd.sinifId=30

--select sd.dersId,d.dersAdi from sinifDersleri as sd inner join dersler as d on d.dersId=sd.dersId
--where sinifId=30

select ogrenciNo,ogrenciAdi +' '+ogrenciSoyadi as adi,ogrenciTc
from ogrenci
where sinif=32