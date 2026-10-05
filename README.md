# Laboratorio: Repaso del CRUD y Temas Varios
Fecha: 05/10/2026

## Contenido del Repositorio
Este laboratorio abarca el análisis y la implementación de prácticas clave en C# (.NET) y bases de datos, incluyendo la evaluación de vulnerabilidades SQL (inyección SQL), construcción dinámica de consultas seguras con diccionarios, Programación Orientada a Objetos mediante métodos sobrecargados, algoritmos recursivos para el cálculo de factoriales y análisis de frecuencias.

## Tecnologías Utilizadas
* **Lenguaje / Framework:** C# (.NET Framework / .NET Core)
* **Tipo de Aplicación:** Aplicación de Consola / Pruebas SQL
* **Herramientas:** Visual Studio Insiders, SQL Server / MySQL, GitHub

## Capturas de Pantalla y Problemas

### Ejercicio 1: Consultas SQL e Inyección SQL (SQLi)
Análisis y pruebas de comportamiento ante vulnerabilidades de inyección SQL, evaluando técnicas de bypass de condiciones mediante tautologías (`OR '1'='1'`), retardos temporales basados en tiempo (`SLEEP`) y anulación de sintaxis utilizando comentarios SQL (`--`).

### Evidencia de Ejecución
- ![Consulta 1](./imagenes%20lab%20variado/problema1_tau.png)
- ![Consulta 2](./imagenes%20lab%20variado/problema1_sleep.png)
- ![Consulta 3](./imagenes%20lab%20variado/problema1_comment.png)

### Ejercicio 2: Cadenas y Consultas Parametrizadas (Insert / Update)
Implementación en C# para la construcción dinámica y estructurada de consultas SQL (`INSERT` y cláusulas `SET` para `UPDATE`) utilizando diccionarios (`Dictionary<string, object>`), facilitando la asignación de parámetros y previniendo la inyección de código malicioso.

### Evidencia de Ejecución
- ![Ejecución Problema 2](./imagenes%20lab%20variado/problema2_ejecucion.png)

### Ejercicio 3: Métodos Sobrecargados
Demostración del principio de sobrecarga de métodos (*Method Overloading*), implementando múltiples funciones con el mismo nombre (`Cuadrado`) que aceptan diferentes tipos de datos de entrada (`int` y `double`) y resuelven la llamada adecuada según el argumento.

### Evidencia de Ejecución
- ![Ejecución Problema 3](./imagenes%20lab%20variado/problema3_ejecucion.png)

### Ejercicio 4: Recursividad (Factorial)
Implementación de un algoritmo recursivo en C# para calcular de forma eficiente el factorial de un número desde 0 hasta 10, definiendo claramente un caso base de control (`numero <= 1`) y el paso recursivo correspondiente.

### Evidencia de Ejecución
- ![Ejecución Problema 4](./imagenes%20lab%20variado/problema4_ejecucion.png)

### Ejercicio 5: Análisis de Frecuencias
Desarrollo de lógica para el conteo y análisis de frecuencias de datos dentro de estructuras en memoria, procesando colecciones para determinar la ocurrencia de elementos.

### Evidencia de Ejecución
- ![Ejecución Problema 5](./imagenes%20lab%20variado/problema5_ejecucion.png)

## Estructura de Carpetas o Directorios

```plaintext
laboratorio-temas-varios/
├── ConsultaSQL/            # Scripts y pruebas de inyección SQL
│   └── queries.sql         # Consultas evaluadas (Tautología, Sleep, Comentarios)
├── EjemploListas/          # Proyecto C#: Construcción dinámica de INSERT y SET
│   └── Program.cs          # Lógica con Dictionary<string, object>
├── SobreCargaMetodos/      # Proyecto C#: Demostración de métodos sobrecargados
│   ├── Program.cs          # Clase principal de ejecución
│   └── SobreCarga.cs       # Definición de métodos Cuadrado (int y double)
├── Factorial/              # Proyecto C#: Algoritmo recursivo de factoriales
│   └── Program.cs          # Bucle del 0 al 10 y función recursiva
├── Frecuencia/             # Proyecto C#: Análisis de frecuencias
│   └── Program.cs          # Lógica de conteo de ocurrencias
├── imagenes lab variado/   # Carpeta de capturas de ejecución
│   ├── problema1_tau.png
│   ├── problema1_sleep.png
│   ├── problema1_comment.png
│   ├── problema2_ejecucion.png
│   ├── problema3_ejecucion.png
│   ├── problema4_ejecucion.png
│   └── problema5_ejecucion.png
└── README.md               # Documentación del proyecto
└── README.md               # Documentación del proyecto
```
## Instrucciones de Ejecución / Uso
**1. Clonar el repositorio**: 
```bash
git clone [https://github.com/tu-usuario/laboratorio-3-csharp.git](https://github.com/tu-usuario/laboratorio-3-csharp.git)
```
**2. Configurar el entorno local:**
​Abrir la solución .sln en Visual Studio o la carpeta principal en Visual Studio Code

**3. Ejecutar el código:**

Consola: Navegar al directorio del proyecto deseado (ej. Factorial o EjemploListas) y ejecutar dotnet run.

Consultas SQL: Ejecutar los scripts en el gestor de base de datos de preferencia para verificar el comportamiento de las consultas evaluadas.


## Autor
**​Nombre:** Alisson Lacayo  

**​Asignatura:** Herramientas de la Programación Aplicada III (.NET)

**​Grupo:** 1IL133

**​Carrera:** Licenciatura en Ingeniería en Sistemas y Computación 

​**Institución:** Universidad Tecnológica de Panamá (UTP)  

## Referencias 
​Material didáctico del curso Herramientas de la Programación Aplicada III (UTP).
​Directrices del Resumen del Repositorio (UTP - FISC).  

