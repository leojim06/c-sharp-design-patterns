# PRINCIPIOS SOLID

## ¿Qué son los principios SOLID?
Los principios SOLID son una serie de recomendaciones para que puedas escribir un mejor código que te ayuda a implementar una alta cohesión y bajo acoplamiento.

Robert C. Martin estableció cinco directrices o principios para facilitarnos a los desarrolladores la labor de crear programas legibles y mantenibles.

Estos principios se llamaron S.O.L.I.D. por sus siglas en inglés:

* **S: Single responsibility principle** o Principio de responsabilidad única
* **O: Open/closed principle** o Principio de abierto/cerrado
* **L: Liskov substitution principle** o Principio de sustitución de Liskov
* **I: Interface segregation principle** o Principio de segregación de la interfaz
* **D: Dependency inversion principle** o Principio de inversión de dependencia

Aplicar estos principios facilitará mucho el trabajo, tanto propio como ajeno (es muy probable que tu código lo acabe leyendo muchos otros desarrolladores a lo largo de su ciclo de vida). Algunas de las ventajas de aplicarlo son:

* Mantenimiento del código más fácil y rápido
* Permite añadir nuevas funcionalidades de forma más sencilla
* Favorece una mayor reusabilidad y calidad del código, así como la encapsulación

Vamos a ver en detalle cada uno de estos principios, junto a ejemplos básicos, que, a pesar de no ser aplicables en el mundo real, espero que aporten la suficiente claridad para que seas capaz de entender y aplicar estos principios en tus desarrollos.

## S: Single responsibility principle (SRP)

Cada modulo de software o clase debe tener solo una razón para cambiar. Lo que quiere decir que cada modulo o clase debe tener solo una única responsabilidad

## O: Open/closed principle (OCP)

Componentes de software como modulos, clases, funciones, etc. deben estar abiertas para la extension, pero cerradas para la modificacion

## L: Liskov substitution principle (LSP)

Este principio indica que, si S es un subtipo de T, entonces objetos de tipo T deben ser reemplacables por objetos de tipo S.

En simples palabras, cuando tenemos relacion entre una clase base y subclases hijas, por ejemplo una relacion de herencia, entonces, si podemos reemplazar de forma exitosa un objeto o instancia de la clase padre con un objeto o instancia de una de sus clases hijas, sin afectar el comportamiento de la instancia de la clase base, entonces podemos decir que cumple el principio de sustitucion de Liskov.

Ejemplo de la vida real. Si un padre de familia es profesor mientras que su hijo es un doctor. En este caso, el hijo no puede reemplazar la funcion de su padre incluso cuando son de la misma familia.

## I: Interface segregation principle (ISP)

Los clientes no deben ser forzados a implementar ningun metodo que ellos no usen. En lugar de una interfaz muy grande, muchas interfaces pequeñas son mejores, basadas en grupos de metodos para que cada interface sirva a un submodulo

## D: Dependency inversion principle

Este principio indica que modulos o clases de alto nivel no deben depender de modulos o clases de bajo nivel. Ambos deben depender de abstracciones. En segundo lugar, las abstracciones no deben depender de los detalles. Los detalles deben depender de las abstracciones.