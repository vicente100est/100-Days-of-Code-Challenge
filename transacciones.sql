begin transaction

update concepto set descripcion = 'gato' where id = 1
update concepto set descripcion = 'gato2' where id = 1

delete venta

if @@ERROR <> 0
	begin
		print 'Hay un error'
		rollback
	end

commit