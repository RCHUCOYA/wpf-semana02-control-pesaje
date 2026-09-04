# WPF_SEMANA02 — Registro de Salidas

Proyecto académico simple hecho con **C# y WPF**.

## Flujo de pantallas

```text
Login (demostrativo, sin validación)
            ↓
Formulario de Registro de Salidas
            ↓
Listado temporal en DataGrid
```

## Funcionalidad

- El botón **Ingresar** abre directamente el formulario de salidas.
- Permite registrar tipo y número de documento, pesos, vehículo, transportista, fecha y hora.
- Valida que se completen los campos y que los pesos sean números.
- Muestra las salidas registradas en un `DataGrid` mientras el programa está abierto.
- No usa base de datos, APIs ni Entity Framework.

## Ejecutar en Windows

1. Instalar Visual Studio Community con **Desarrollo de escritorio de .NET**.
2. Abrir `WPF_SEMANA02.csproj`.
3. Presionar **F5**.

Para visualizar el diseño XAML: abrir una ventana `.xaml` y presionar **Shift + F7** en Visual Studio.
