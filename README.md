#           DeltaUML
herramienta que permite realizar modelos UML mediante lectores de pantalla.
la idea es que cada uno de los diagramas se integren en forma de plugins (dlls) los que tengrán que tener: 
1. la clase diagrama, por ejemplo: ClassDiagram. La clase contendrá todas las propiedades del diagrama.
Esta clase debe heredar de la clase Diagram, Ubicada en el proyecto DeltaUMLSdk.
2. estrategia de creación: por ejemplo: ClassDiagramCreationStrategy.
Las estrategias definen como deben crearse los diagramas, es decir, si se crean desde 0 (nuevos), o si se leen desde una fuente externa, es decir, que tienen datos.
Las estrategias deben implementar la interfaz IDiagramCreationStrategi, ubicada  en la DLL DeltaUMLSdk
3. clase de persistencia.
Esta clase debe definir como se guardan los diagramas y debe implementar la interfaz IDiagramDao, o heredar de la clase DiagramDao,  Ubicadas en el proyecto DeltaUMLSdk.
En el caso de heredar de la clase DiagramDao, esta implementación serializa los diagramas en un formato xml.
4. Clase de presentación. Será la encargada de mostrar el diagrama.
Debe heredar de la clase FRMCommonEvents, ubicada en el proyecto DeltaUMLSdk.

