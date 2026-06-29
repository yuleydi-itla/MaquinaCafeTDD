# ☕ Máquina de Café — Práctica TDD (ITLA)

## Descripción

En este proyecto apliqué la metodología **Test-Driven Development (TDD)** para desarrollar una simulación sencilla de una máquina expendedora de café. Mi objetivo fue implementar cada funcionalidad siguiendo el ciclo de TDD, asegurándome de que el código estuviera respaldado por pruebas unitarias desde el inicio.

La aplicación permite insertar monedas, seleccionar una bebida, obtener el cambio, devolver el dinero y validar diferentes situaciones, como saldo insuficiente, bebidas inexistentes o falta de stock.

## ¿Qué es TDD?

**Test-Driven Development (TDD)** es una metodología de desarrollo en la que primero se escriben las pruebas y después se implementa el código necesario para que esas pruebas pasen correctamente.

Este proceso se basa en tres etapas:

* **RED:** Escribí una prueba que describía el comportamiento esperado. Como la funcionalidad aún no existía, la prueba fallaba.
* **GREEN:** Implementé el código mínimo necesario para que la prueba pasara.
* **REFACTOR:** Mejoré la organización y el diseño del código sin modificar su funcionamiento y verificando que todas las pruebas siguieran pasando.

## ¿Cómo apliqué TDD en este proyecto?

Durante el desarrollo seguí el ciclo completo de TDD.

Primero escribí los ocho casos de prueba (`TC-01` a `TC-08`) antes de implementar la lógica de la máquina de café. Al ejecutarlos por primera vez, todos fallaban, lo cual era el resultado esperado.

Después desarrollé la clase `MaquinaCafe.cs` implementando únicamente el código necesario para que cada prueba fuera pasando.

Finalmente realicé una refactorización para mejorar la estructura del proyecto. Creé el record `Bebida(Nombre, Precio, Stock)` para agrupar la información de cada bebida y extraje el método `ObtenerBebidaOLanzar`, evitando repetir código y haciendo que la implementación fuera más limpia y fácil de mantener. Después de estos cambios, verifiqué que las ocho pruebas continuaran ejecutándose correctamente.

## Casos de prueba implementados

| ID    | Caso de prueba                                                                            |
| ----- | ----------------------------------------------------------------------------------------- |
| TC-01 | Verifiqué que al insertar una moneda el saldo se acumula correctamente.                   |
| TC-02 | Comprobé que una bebida puede seleccionarse cuando el saldo es suficiente.                |
| TC-03 | Verifiqué que no se dispense una bebida cuando el saldo es insuficiente.                  |
| TC-04 | Comprobé que `ObtenerCambio()` devuelve el cambio correcto después de una compra.         |
| TC-05 | Verifiqué que al seleccionar una bebida inexistente se genere una `ArgumentException`.    |
| TC-06 | Comprobé que el menú devuelve correctamente las tres bebidas disponibles con sus precios. |
| TC-07 | Verifiqué que `DevolverMonedas()` reinicia el saldo a cero.                               |
| TC-08 | Comprobé que una bebida sin stock no puede ser dispensada.                                |

## Cómo ejecutar el proyecto

1. Abrir la solución `MaquinaCafeTDD.sln` en Visual Studio 2022.
2. Establecer el proyecto **MaquinaCafe** como proyecto de inicio y presionar **F5** para ejecutar la aplicación.
3. Para ejecutar las pruebas unitarias, abrir **Test → Test Explorer** y seleccionar **Run All Tests**, o utilizar el atajo **Ctrl + R, A**.

## Resultado

Al finalizar el proyecto, logré que los ocho casos de prueba se ejecutaran correctamente. Esto me permitió comprobar que cada funcionalidad cumple con el comportamiento esperado y que las mejoras realizadas durante la refactorización no afectaron el funcionamiento de la aplicación.
