# 🍽️ Restaurante El Rincón Del Jugador

Sistema de gestión administrativa para restaurante desarrollado con **Windows Forms (.NET Framework 4.7.2)** y **SQL Server**.

## Tecnologías

- **.NET Framework 4.7.2** — Windows Forms
- **SQL Server** — Base de datos relacional
- **Stored Procedures** — Toda la lógica de acceso a datos
- **Arquitectura en 4 capas:** Entidad → Datos → Lógica → Presentación

## Arquitectura

```
CapaEntidad      → Modelos de datos (POCOs)
CapaDatos        → Acceso a BD con stored procedures y transacciones
CapaLogica       → Validaciones y reglas de negocio
CapaPresentación → Interfaz WinForms
```

- Patrón **Singleton** en capas Datos y Lógica
- Clase `Result<T>` para respuestas consistentes (éxito/error)
- **Transacciones SQL** en operaciones críticas (órdenes, detalles)
- Validaciones de negocio (DNI, RUC, email) en capa Lógica

## Funcionalidades

- **Órdenes** — Registro de pedidos con detalle de platos y cantidades
- **Compras** — Gestión de compras de insumos y requerimientos
- **Mantenedores** — CRUD completo de meseros, clientes, platos, bebidas, proveedores, insumos, tipos
- **Comprobantes de venta** — Generación de comprobantes por pedido

## Requisitos

- Visual Studio 2022 o superior
- SQL Server (local o remoto)
- .NET Framework 4.7.2 SDK

## Instalación

1. Clonar el repositorio
2. Ejecutar `DDL_MOANSO.sql` en SQL Server para crear la base de datos
3. Verificar/adjustar la cadena de conexión en `MOANSO_PF\App.config`
4. Abrir `MOANSO_PF.sln` y compilar (Rebuild)
5. Ejecutar

## Capturas

*(Agrega aquí capturas del menú principal y ventanas CRUD)*

## Estado

Proyecto funcional para entorno local/monousuario.
