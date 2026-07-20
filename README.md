## Resumen

El presente proyecto consiste en una aplicación de consola (Console App) desarrollada en C#, la cual permite calcular el Impuesto Sobre la Renta (ISR) de un empleado en la República Dominicana en el presente año 2026.

Este programa solicita el sueldo mensual bruto, luego calcula el sueldo anual, y aplica la escala correspondiente del Impuesto Sobre la Renta. En caso de que el sueldo anual no supere el monto exento establecido, el programa muesta "N/A". A parte de esto, el programa tambien valida que el usuario introduzca un valor numérico mayor que 0.

Para comprobar el funcionamiento del programa, se realizaron diferentes escenarios con sueldos mensuales de **RD$30,000**, **RD$45,000**, **RD$60,000** y **RD$100,000**.

## Escenarios de prueba

### Escenario 1: empleado exento

**Sueldo mensual introducido:** RD$30,000.00  
**Resultado:** No aplica ISR.

![Escenario con sueldo de RD$30,000](capturas/escenario_1_exento.png)

### Escenario 2: primer tramo gravado

**Sueldo mensual introducido:** RD$45,000.00  
**ISR mensual calculado:** RD$1,547.25  
**ISR anual calculado:** RD$18,567.00

![Escenario con sueldo de RD$45,000](capturas/escenario_2_45.png)

### Escenario 3: segundo tramo gravado

**Sueldo mensual introducido:** RD$60,000.00  
**ISR mensual calculado:** RD$4,195.85  
**ISR anual calculado:** RD$50,350.20

![Escenario con sueldo de RD$60,000](capturas/escenario_2_60.png)

### Escenario 4: tramo superior

**Sueldo mensual introducido:** RD$100,000.00  
**ISR mensual calculado:** RD$13,582.94  
**ISR anual calculado:** RD$162,995.25

![Escenario con sueldo de RD$100,000](capturas/escenario_2_100.png)

## Validación de entrada

El programa nos muestra un mensaje de error cuando el usuario introduce letras, sueldos iguales a 0 o algún sueldo negativo.
