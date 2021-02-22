namespace DeltaUMLSdk
{
    public interface IDiagramDao
    {
        T ReadDiagram<T>(string path);
        void WriteDiagram<T>(T diagram, string path);

    }
}
