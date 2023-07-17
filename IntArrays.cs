public static class IntArrays
{
    public static void IntOperations(){
        int[] funNos= {1,7,23,34,654,132,676};
        Array.Sort(funNos);
        System.Console.WriteLine("Array after sorting is ");
        foreach(int n in funNos){
            Console.Write(n+" ");
        }
        Array.Reverse(funNos);
        System.Console.WriteLine("\nArray after reverse is :");
        foreach(int n in funNos){
            Console.Write(n+" ");
        }

    }
}
