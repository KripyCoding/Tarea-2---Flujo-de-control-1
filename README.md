## Resumen

Este proyecto consiste en una aplicación de consola desarrollada en **C#** que permite calcular el **Impuesto Sobre la Renta (ISR)** de un empleado en la República Dominicana para el año 2026.

El programa solicita el sueldo mensual bruto, calcula el sueldo anual y aplica la escala correspondiente del ISR. Cuando el sueldo anual no supera el monto exento establecido, el programa muestra **N/A**. También valida que el usuario introduzca un valor numérico mayor que cero.

Para comprobar su funcionamiento se realizaron diferentes escenarios con sueldos mensuales de **RD$30,000**, **RD$45,000**, **RD$60,000** y **RD$100,000**.

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

El programa muestra un mensaje de error cuando el usuario introduce letras, un sueldo igual a cero o un sueldo negativo.

