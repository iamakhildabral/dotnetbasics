using System.IO;

namespace RWFile{
    public class RWFileClass{
        public static void RWFileOperation(){
            try
            {
                StreamReader streamReader = new("Input.txt");
                //StreamWriter streamWriter = new StreamWriter("Output.txt");
                String? allFileContent = streamReader.ReadToEnd();
                /*
                Here we are checking whether we can really 
                found out about the string exisitence
                in the file read all the once in just one line
                well i am quite impresses with the C# performance within 1 seconds to find
                the substring from such a large file. Although the python was 
                way superior to its performance not just in Read and write but also 
                in string search 
                */
                // if(allFileContent.Contains("boyfriendKedarnath"))
                // {
                //     System.Console.WriteLine("File contains the string ");
                // }else{
                //     System.Console.WriteLine("Not found");
                // }
               // File.WriteAllText("Output.txt",allFileContent.ToUpper()) ;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Exception was :"+e.Message);
                throw;
            }
        }
    }
}