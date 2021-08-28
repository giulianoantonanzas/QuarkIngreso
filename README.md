# QuarkIngreso

<h3>Programa de ingreso para QuarkAcademy.</h3>

Este reto me motivo mucho. Estuve durante una semana creando el programa para tratar de hacerlo lo mejor posible.
Lo cierto es que uno nunca deja de querer agregarle cosas o mejorarlo.

Hoy entrego un trabajo que creo que es más de lo que en un principio se pidió, pero la motivación me pudo.

Algo a aclarar, no utilice ningún nada en especial, puro c#, así que no habría problema con que se clone el repositorio y es ejecute. En todo caso use la carpeta bin para ejecutar el archivo .exe .

<b>Este programa puede:</b>
<ul>
  <li> Almacenar datos en archivos de TXT.
  <li> Generar Vendedores y que estos se mantengan.
  <li> Generar Tiendas y que estos se mantengan.
  <li> Generar Cotización de manera efectiva con todas las restricciones planteadas.
  <li> Listar las cotizaciones
</ul>

Como lo pensé?

Al comienzo, pensé que lo mejor era guardar los datos y que se mantenga. Asi que cree el modelado de clases y luego cree la lógica para que estos se guarden y se obtengan de un archivo de texto. Toda esa logica esta dividida en entre la carpeta Controller , DB , Constants y Helpers.

Luego de hacer la lógica datos,<b> hice las vistas de:</b>
<ul>
  <li> ventana principal
  <li> lista de vendedores
  <li> lista de tiendas 
  <li> lista de cotizaciones
  <li> nuevo vendedor
  <li> nueva tienda
  <li> generar cotización
</ul>

Genere unos archivos estáticos que me sirvieron para calcular las los faltantes de las prendas cotizadas. Ósea, si yo compre 100 camisas y el máximo es de 1000; este se actualice a 900.
Luego termine de realizar la lógica para que se pueda cotizar correctamente si es que se cumplen todas las condiciones.

Y guala... El programa está hecho. Espero que les guste. Saludos!
