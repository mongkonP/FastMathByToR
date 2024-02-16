namespace LogUtility
{
    public class Logger
    {
        string fileLog;
        public Logger(string f) { 
        fileLog = f;
        }
        void SetLog(string log) {
            using (StreamWriter writer = new StreamWriter(fileLog))
                writer.WriteLine($"{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss fffff")}|{log}");
        }
        string GetLogAll {
            get {
                string s = "";
                if (File.Exists(fileLog)) {
                    using (StreamReader reader = new StreamReader(fileLog))
                     s =   reader.ReadToEnd();
                }
                
                return s;
            }
            
        }

    }
}
