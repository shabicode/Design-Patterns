public sealed class WeddingCake
{
    private static readonly WeddingCake Instance;
    private static int TotalInstances;

     /*
         * Private constructor is used to prevent
         * creation of instances with the 'new' keyword
         * outside this class.
    */
    private WeddingCake() {
        Console.WriteLine("--Private constructor is calleeeed!!!!");
        Console.WriteLine("--Geeeeeet out!!!!");
    }
  

    /*
         * A static constructor is used for the following purposes:
         * 1. To initialize any static data
         * 2. To perform a specific action only once
         *
         * The static constructor will be called automatically before:
         * i. You create the first instance; or
         * ii.You refer to any static members in your code.
         *
         */
    
    static WeddingCake() {
        //Printing some messsssages before you create the instance;
        Console.WriteLine("Staaaatic constructor is callleeeeeed!!!!");
        Instance = new WeddingCake();
        TotalInstances++;
        Console.WriteLine($"-Singleton instance is created.Number of instances:{ TotalInstances}");       
        Console.WriteLine("Exiiiiiit from static constructor omg!!! goo goo!");
    }
    
    public static WeddingCake GetInstance => Instance;
  
    public static int MyInt = 25;

}