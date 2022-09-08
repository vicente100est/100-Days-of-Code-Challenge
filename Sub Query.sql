select *,(
	select count(id) from venta
	where cliente.id = venta.idCliente
	) as total
from cliente