# 🎵 TP03 - Catálogo de Discos Musicales  
**Materia:** Taller de Programación 2  
**Escuela:** ORT sede Almagro  
**Año:** 4to Informática  
**Estudiante:** Theo Trosman  

---

## 💿 Descripción del Proyecto

Este trabajo práctico consiste en el desarrollo de una aplicación web que simula el sitio oficial de una tienda musical, **MusicStore**, donde los usuarios pueden explorar un **catálogo de discos musicales**, conocer detalles de cada álbum y disfrutar de una experiencia visual alineada con la identidad del sitio.

El proyecto fue desarrollado con **ASP.NET Core** siguiendo el patrón **MVC (Model-View-Controller)** y utilizando almacenamiento en memoria (sin base de datos).

---

## 🧩 Funcionalidades implementadas

- ✅ Página principal con listado de discos musicales precargados.
- ✅ Visualización de la información completa de un disco al hacer clic.
- ✅ Cada disco incluye:
  - Título
  - Artista
  - Productor
  - Género musical
  - Imagen del álbum
  - Lista de temas
- ❌ No se permite registrar discos con títulos duplicados (validación aplicada).

---

## 📦 Estructura del Proyecto (MVC)

- `Models/Disco.cs`: modelo principal con propiedades del álbum.
- `Models/Artista.cs`, `Productor.cs`, `Genero.cs`, `Tema.cs`: modelos relacionados.
- `Controllers/MusicStoreController.cs`: gestiona la lógica entre vistas y datos.
- `Views/MusicStore/Index.cshtml`: muestra el catálogo general.
- `Views/MusicStore/Detalle.cshtml`: muestra la información detallada de un álbum.

---

## 🧠 Detalles técnicos

- 🧱 Framework: **ASP.NET Core MVC**
- 🧠 Programación orientada a objetos
- 💾 Almacenamiento en memoria con una **clase estática**
- 🧹 Validaciones aplicadas en los controladores
- 💡 Separación clara de responsabilidades
- 📸 Imágenes de álbumes reales incluidas

---

## 🎨 Interfaz y diseño visual

Se priorizó una **interfaz clara, moderna y responsive**, que permita al usuario navegar cómodamente el catálogo, identificar artistas y acceder rápidamente a los detalles de cada disco.  
Cada vista fue trabajada respetando una misma identidad visual: fondo, tipografía, botones y layout.

---

## 🎧 Contenido del catálogo

El catálogo incluye 10 discos reales seleccionados por su variedad de género y estética
Cada uno con su respectiva lista de temas.

---

## ✅ Criterios de Evaluación cumplidos

- [x] Separación correcta de modelos, controladores y vistas
- [x] Validaciones funcionales (títulos únicos)
- [x] Código limpio, reutilizable y organizado
- [x] Estética y presentación visual clara y coherente
- [x] Navegación fluida entre vistas
- [x] Creatividad en la elección del contenido musical

---

## 📌 Notas finales

> El objetivo de este trabajo no fue solo desarrollar un catálogo estático, sino aprender a estructurar una aplicación completa que respete buenas prácticas de desarrollo web, MVC y diseño visual.

---

## 👨‍💻 Autor

**Theo Trosman**  
Estudiante de Informática - Escuela ORT Almagro  
_"Una buena interfaz no solo muestra discos, también los hace sonar en la cabeza del usuario."_

