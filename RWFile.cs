using System.IO;

namespace RWFile{
    public class RWFileClass{
        public static void RWFileOperation(){
            try
            {
                StreamReader streamReader = new("Input.txt");
                //StreamWriter streamWriter = new StreamWriter("Output.txt");
                String? allFileContent = streamReader.ReadToEnd();
                File.WriteAllText("Output.txt",allFileContent.ToUpper()) ;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Exception was :"+e.Message);
                throw;
            }
        }
    }
}