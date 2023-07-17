public static class StringArrays
{
        public static void StringActions(){
            Console.WriteLine("Testing out the arrays:");
            String str = "My name is Anthony Gomsalves";
            if (str.StartsWith("My"))
            {
                System.Console.WriteLine("String is correct");
            }else
               System.Console.WriteLine("Failed String");
            // int[] preDefined = { 1, 2,3,4,5,6,7};

            // Console.WriteLine(preDefined);
            //printing the array name will show the array type

            // foreach (int value in preDefined){
            //     Console.WriteLine("Value is " + value);
            // }
            // string[] names = { "Akhil", "Prateek","Lakshmi","Vishal","Devki","Parmanand"};

            /* using for each loop to iterate over the 
            names array*/

            // foreach (var item in names)
            // {
            //     System.Console.WriteLine(item);
            // }

            //now declaring two dimensional string array and printing it 
            // string?[,] allNames = new string[2,2]{
            //     {"Akhil","Dabral"},
            //     {"Prateek","Dabral"}
            // };

            // System.Console.WriteLine(allNames.GetLength(0));
            // for (int i = 0; i < allNames.GetLength(0); i++)
            // {
            //     for(int j = 0;j<allNames.GetLength(0);j++)
            //         System.Console.Write("{0}",allNames[i,j]+" ");
            //     System.Console.WriteLine("");
            // }

            //now printing 2D string array
            // for (int i = 0; i < allNames.GetLength(0); i++)
            // {
            //     for (int j = 0;j< allNames.GetLength(0);i++){
            //         Console.WriteLine(allNames[i,j]);   
            //     }
            //     System.Console.WriteLine("\n");
            // }
        }
}
