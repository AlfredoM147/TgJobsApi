# Test TG (.NET Core)

### Requisitos Principales
* El proyecto se presenta con una arquitectura por defecto como lo genera el propio .Net. Se requiere de un **cambio de arquitectura usando el patrón que más suelas usar**.
* Se tendrá especial consideración en como se presente el código y **buenas prácticas** aplicadas.
* Se pide generar un **documento de texto** que acompañe a la solución donde se **explique el porqué de la toma de decisiones y prácticas aplicadas**.

### Modelos
#### Customer
Representa al cliente y está compuesto por CustomerID, Name, EmailAddress.

#### Product
Representa al producto y está compuesto por ProductID, Name, Color, Price y Weight. 

#### SalesOrderHeader y SalesOrderDetail
Representa a una venta. A su vez, tiene un listado de SalesOrderDetail que se corresponde con cada uno de los productos que se han comprado en esa venta.

### Descripción
Para poder realizar estos ejercicios, será necesario tener conocimientos de programación orientada a objetos.
El proyecto consiste en una API Rest creada con el framework .Net Core. Cada método que nos encontramos en el archivo ValuesController se corresponde con un endpoint que podemos consumir mediante Postman o desde el propio navegador web.

Tenemos tres arrays, uno para los clientes, uno para los productos y otro para las ventas. Los clientes están relacionados con sus compras a través del campo CustomerID en la clase SalesOrderHeader. Cada venta tiene un array de líneas que a su vez están compuestas por productos relacionados a través del campo ProductID.

**La idea es resolver estos ejercicios mediante el uso de LINQ tanto como sea posible**.

### Ejercicio 1
Se pide completar el método GetTopProduct para obtener el producto más vendido.

El resultado de este ejercicio debe ser un objeto tipo Product.

### Ejercicio 2
Se pide completar el método GetCustomerProducts para obtener un listado de los clientes con los productos que han comprado.

El resultado de este ejercicio debe ser un objeto Customer con un listado de Product.

### Ejercicio 3
Se pide completar el método GetWeightestSale para obtener la venta más pesada (la que la suma de los pesos de sus producto sea mayor).

El resultado de este ejercicio debe ser un objeto de tipo SalesOrderHeader.

### Ejercicio 4
Se propone realizar una modificación en el código para rellenar la propiedad Total de la clase SalesOrderHeader, sin que exista la necesidad de inicializar esa variable en el constructor, y que se rellena automaticamente. Se valorará la originalidad a la hora de utilizar soluciones propias de C#.

### Ejercicio 5
Se pide completar el método GetCustomerAsync para obtener un customer por su Id. 

En este método se debe usar getCustomerFromApiAsync() de la clase CustomerService que simula obtener un listado de customer desde una api externa. CustomerService está disponible en el controlador a través de inyección de dependencias. Se debe usar la notación async/await de c# para resolver este ejercicio.

El resultado de este ejercicio debe ser un objeto Customer filtrado por su Id.