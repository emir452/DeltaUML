
namespace SequenceDiagramService.Persistence
{
    public class UtilitiManager
    {
        public static UtilitiManager instance { get; set; }
        public IFileManager fm { get; }
        public IDirectoryManager dm { get; }
        public static UtilitiManager GetInstance()
        {
            if (instance == null)
            {
                instance = new UtilitiManager();
            }
            return instance;
        }
        private UtilitiManager()
        {
            fm = (IFileManager) new FileManager();
            dm = new DirectoryManager();
        }
        public string ConbinePaths(string path, string name)
        {
            return path + @"\" + name;

        }
    }
}
