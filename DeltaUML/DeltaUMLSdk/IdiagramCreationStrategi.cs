namespace DeltaUMLSdk
{
    public interface  IdiagramCreationStrategi
    {
       Diagram CreateDiagram(string path);
        Diagram CreateDiagram(string path, string name);
    }
}
