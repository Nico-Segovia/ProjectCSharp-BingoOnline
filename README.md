# ProjectBingoOnline
Trabajo final del curso 'Introducción a Net 6.0' - Polo Tecnológico de Mina Clavero e IncluIT

## Sobre el Proyecto:
Proyecto realizado con C#, en ASP.NET y Bootstrap (Responsive)
Microsoft SQL Server. 

### Funcionamiento:
Se visualizarán 4 cartones de Bingo distintos, con sus respectivos números generados aleatoreamente.
La aplicación tendrá un único botón llamado “Lanzar Bolilla” que generará automáticamente un número
del 1 al 90 y lo mostrará en el texto “Bolilla” de la pantalla. A su vez, luego de cada lanzamiento se
verificará si el nuevo número existe en algunos de los cartones, en el caso de existir, se pintará ese
número en el cartón en color Rojo. 
El juego continuará mientras no se complete ningún cartón esperando a que el usuario siga presionando 
el botón “Lanzar Bolilla”. En el momento que uno o más cartones lleguen al estado “Cartón Lleno”, 
es decir, que todos los números del cartón estén en Rojo, se finalizara el juego y se mostrará el cartón 
o los cartones que hayan ganado en el texto “Cartón Ganador”.

### Regla para la generación de cartones del Bingo:
1) Cartón de 3 filas por 9 columnas
2) Los cartones se generan con 15 números y 12 espacios en blanco
3) Cada fila debe tendrá 5 números
4) Cada columna tendrá 1 o 2 números
5) Ningún número se repetirá
6) La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29,
así sucesivamente hasta la última columna la cual contiene del 80 al 90

### Guardado de historial en base de datos (SQL Server):
Por cada numero que se genere, se guardarán los datos en una tabla llamada HistorialBolillero.
Esta tabla deberá tener dos campos: Un campo con fecha y hora y otro campo con el número de bolilla
Además, por cada cartón ganador, se guardará el número de Cartón o Cartones ganadores en una tabla
llamada HistorialCartones.
Esta tabla contiene con 5 campos: Uno con fecha y hora, y luego 4 campos (Carton1, Carton2, Carton3 y
Carton4) que admitan null donde se guarde el o los cartones ganadores. Ejemplo: Si resultaron
ganadores los cartones 3 y 1, se guardarán datos en el campo Fecha y hora con la hora actual y el
número 3 en el campo Carton1 y el número 1 en el campo Carton2.