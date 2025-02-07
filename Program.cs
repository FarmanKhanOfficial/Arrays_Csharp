using System;
class Arrays_In_Csharp
{
    static void Main()
    {
        Arrays_initilize_values();
        Arrays_initilize_Size();
    }
    static void Arrays_initilize_values()
    {
        Console.WriteLine("This Is Arrays_initilize_By_Value() Method"); 
        string[] UserNames = { "Farman", "Ehsan", "Ali", "Tahir" };
        Console.WriteLine("\nWe are Using A for Loop Here");
        for (int i = 0; i < UserNames.Length; i++)
        {
            Console.Write($@"""{UserNames[i]}""");
        }
        Console.WriteLine("\n");
        Console.WriteLine(@$"Names in arrays = ""{UserNames[0]}"", ""{UserNames[1]}"", ""{UserNames[2]}"", ""{UserNames[3]}""");
    }
    static void Arrays_initilize_Size()
    {
        Console.WriteLine("\n\n\nThis Is Arrays_initilize_By_Size() Method");
        int[] oddNumber = new int[4];
        oddNumber[0] = 1;
        oddNumber[1] = 3;
        oddNumber[2] = 5;
        oddNumber[3] = 7;
        //oddNumber[4] = 8; Exception will be given Out of Index size 
        Console.WriteLine($"\nOdd Numbers in Array = {oddNumber[0]},{oddNumber[1]},{oddNumber[2]},{oddNumber[3]}");
        Console.WriteLine("\nAfter Reversing the Array");
        Array.Reverse(oddNumber);
        foreach (int i in oddNumber)
        {
            Console.Write($"{i},");
        }

    }

}
