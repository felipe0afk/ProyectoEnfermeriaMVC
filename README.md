# ProyectoEnfermeriaMVC
a website dedicated to motherhood 
# 🩺 Proyecto Enfermería MVC

Este es un proyecto desarrollado en **ASP.NET Core MVC** con **Entity Framework Core** que tiene como objetivo ofrecer un portal informativo sobre **lactancia materna**, **método canguro** y otros cuidados neonatales.  
El sistema permite gestionar testimonios de usuarios, acceder a recursos y mantener una interfaz visual amigable con colores pasteles.

---

## ✨ Características principales

- ✅ **ASP.NET Core MVC 9.0** con patrón MVC (Model-View-Controller).  
- ✅ **Entity Framework Core** para la persistencia de datos.  
- ✅ **Base de datos MySQL** con migraciones automáticas.  
- ✅ CRUD completo de **Testimonios**.  
- ✅ Páginas informativas: Inicio, Lactancia, Canguro, Recursos, Contacto.  
- ✅ **Frontend personalizado** con Bootstrap + CSS con estilo pastel (rosados, lilas y azules).  
- ✅ Footer con enlaces útiles y diseño responsive.  
- ✅ Navbar con indicador activo según la página actual.  

---

## 📂 Estructura del proyecto

ProyectoEnfermeriaMVC/
│
├── Controllers/                         # Lógica del lado del servidor
│   └── TestimoniosController.cs         # CRUD de testimonios
│
├── Data/                                # Configuración de base de datos
│   └── ApplicationDbContext.cs          # DbContext con DbSet<Testimonio>
│
├── Migrations/                          # Migraciones generadas por EF Core
│   └── ...                              # Archivos automáticos
│
├── Models/                              # Clases de dominio
│   └── Testimonio.cs                    # Modelo de testimonios
│
├── Pages/                               # Vistas Razor
│   ├── Shared/                          # Layout y componentes compartidos
│   │   ├── _Layout.cshtml               # Layout general (navbar, footer)
│   │   └── _ValidationScriptsPartial.cshtml
│   │
│   ├── Index.cshtml                     # Página de inicio
│   ├── Lactancia.cshtml                 # Información sobre lactancia
│   ├── Canguro.cshtml                   # Información sobre método canguro
│   ├── Recursos.cshtml                  # Recursos (PDF, Videos, Artículos)
│   ├── Contacto.cshtml                  # Página de contacto
│   │
│   └── Testimonios/                     # CRUD de testimonios
│       ├── Index.cshtml                 # Lista de testimonios
│       ├── Create.cshtml                # Formulario para agregar testimonio
│       ├── Edit.cshtml                  # Formulario para editar testimonio
│       ├── Delete.cshtml                # Confirmar eliminación
│       └── Details.cshtml               # Ver detalle de un testimonio
│
├── Properties/
│   └── launchSettings.json              # Configuración de ejecución local
│
├── wwwroot/                             # Archivos estáticos
│   ├── css/
│   │   └── site.css                     # Estilos personalizados (pasteles)
│   ├── js/
│   │   └── site.js                      # JS propio (si necesitas)
│   └── lib/                             # Librerías (Bootstrap, jQuery, etc.)
│
├── appsettings.json                     # Configuración (DB, logging, etc.)
├── Program.cs                           # Configuración inicial del proyecto
├── ProyectoEnfermeriaMVC.csproj         # Archivo de proyecto .NET
└── README.md                            # Documentación del proyecto

