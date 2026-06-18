\# Máquina de Café — Práctica TDD (ITLA)



\## ¿Qué es TDD?



Test-Driven Development (TDD) es una metodología en la que las pruebas

automatizadas se escriben antes del código de producción. El desarrollo

avanza en ciclos cortos repetidos:



1\. \*\*RED\*\* — Se escribe una prueba que describe el comportamiento

&#x20;  deseado. La prueba debe fallar, porque el código aún no existe.

2\. \*\*GREEN\*\* — Se escribe el código mínimo necesario para que la

&#x20;  prueba pase.

3\. \*\*REFACTOR\*\* — Se mejora el diseño sin romper ninguna prueba

&#x20;  existente.



\## Ciclo aplicado en este proyecto



\- \*\*RED\*\*: se escribieron los 8 casos de prueba (TC-01 a TC-08) en

&#x20; `MaquinaCafe.Test/MaquinaCafeTests.cs` antes de implementar

&#x20; `MaquinaCafe.cs`. Al ejecutarlos por primera vez, todos fallaban.

\- \*\*GREEN\*\*: se implementó `MaquinaCafe.cs` con la lógica mínima

&#x20; (diccionarios simples para precio y stock) para hacer pasar los 8 tests.

\- \*\*REFACTOR\*\*: se introdujo el record `Bebida(Nombre, Precio, Stock)`

&#x20; para unificar precio y stock en un solo modelo, y se extrajo el método

&#x20; `ObtenerBebidaOLanzar` para evitar duplicar la validación de existencia.

&#x20; Los 8 tests se mantuvieron en verde después del cambio.



\## Casos de prueba cubiertos



| ID    | Escenario                                                    |

|-------|---------------------------------------------------------------|

| TC-01 | Insertar moneda acumula el saldo                              |

| TC-02 | Seleccionar bebida con saldo suficiente devuelve true          |

| TC-03 | Seleccionar bebida con saldo insuficiente devuelve false       |

| TC-04 | ObtenerCambio() devuelve el cambio correcto tras dispensar     |

| TC-05 | Seleccionar una bebida inexistente lanza ArgumentException     |

| TC-06 | El menú devuelve 3 bebidas con sus precios                     |

| TC-07 | DevolverMonedas() reinicia el saldo a cero                     |

| TC-08 | Sin stock, SeleccionarBebida devuelve false                    |



\## Cómo ejecutar el proyecto



Abrir `MaquinaCafeTDD.sln` en Visual Studio 2022.



Para correr la aplicación de consola: clic derecho en el proyecto

`MaquinaCafe` → Establecer como proyecto de inicio → F5.



Para correr las pruebas: `Test → Test Explorer → Run All Tests`

(o `Ctrl+R, A`).

