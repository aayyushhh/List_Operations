public class Program
{
    static void Main(string[] args)
    {
        List<string> myList = new List<string>();

        
        myList.Add("Apple");
        myList.Add("Banana");
        myList.Add("Cherry");

        
        Console.WriteLine("Initial List:");
        foreach (string fruit in myList)
        {
            Console.WriteLine(fruit);
        }

        
        myList[1] = "berry";  

        
        Console.WriteLine("\nList After Update:");
        foreach (string fruit in myList)
        {
            Console.WriteLine(fruit);
        }

        
        myList.Remove("Cherry");

        
        Console.WriteLine("\nList After Deletion:");
        foreach (string fruit in myList)
        {
            Console.WriteLine(fruit);
        }


    }
}