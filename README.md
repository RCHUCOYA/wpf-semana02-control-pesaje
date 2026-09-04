# WPF_SEMANA02 — Sistema de Control de Pesaje

Aplicación académica de escritorio creada exclusivamente con **C# y WPF**. No emplea base de datos, Entity Framework, APIs ni persistencia: los registros viven en memoria mientras la aplicación está abierta.

## Requisitos

- Visual Studio 2022 con la carga de trabajo **Desarrollo de escritorio de .NET**.
- .NET 8 SDK.

## Ejecutar

1. Abrir `WPF_SEMANA02.csproj` en Visual Studio.
2. Seleccionar el proyecto como inicio y presionar **F5**.
3. Presionar **Ingresar**; el login es demostrativo y no valida credenciales.

## Flujo para la demostración

1. Presionar **Ingresar** en el login demostrativo.
2. En Inicio, seleccionar uno de los tres módulos: Operaciones, Mantenimientos o Reportes.
3. Abrir **Operaciones → Salidas**, registrar una salida y guardar.
4. Abrir **Reportes → Salidas**: la salida aparece en el `DataGrid`.
5. Buscar `Lima`, comprobar coincidencia parcial sin distinguir mayúsculas y usar **Limpiar** para restaurar el listado.

Incluye registros de prueba para el reporte de salidas y mantenimientos de camiones, transportistas y productos en memoria.
