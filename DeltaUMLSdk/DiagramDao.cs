using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace DeltaUMLSdk
{
     public class DiagramDao : IDiagramDao
    {
        public T ReadDiagram<T>(string path)
        {
            XmlSerializer reader = new XmlSerializer(typeof(T));
            StreamReader fs = new StreamReader(path);
            T result = (T)reader.Deserialize(fs);
            fs.Close();
            return result;
        }
        public void WriteDiagram<T>(T diagram, string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(T));
            StreamWriter fs = new StreamWriter(path);
            writer.Serialize(fs, diagram);
            fs.Flush();
            fs.Close();
        }
    }
}
