namespace core.diagrams.diagramCreators
{
    public interface IdiagramCreationStrategi
    {
        Diagram CreateDiagram(string path);
        Diagram CreateDiagram(string path, string name);
    }
}
