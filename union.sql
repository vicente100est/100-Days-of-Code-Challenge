select nombre,correo from vendedor
union --all (Si quiero traer todos aun que este repetidos)
select nombre,correo from cliente