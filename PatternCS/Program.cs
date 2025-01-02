Console.WriteLine("**** Singleton Pattern Demostration **** \n");
Console.WriteLine(Singleton.Instance.msg);
Console.WriteLine(WeddingCake.MyInt);

Console.WriteLine("Trying to get a Singleton instance, calledfirstInstance.");
WeddingCake firstInstance = WeddingCake.GetInstance;
Console.WriteLine("Trying to get another Singleton instance,called secondInstance.");
WeddingCake secondInstance = WeddingCake.GetInstance;
if (firstInstance.Equals(secondInstance)){
     Console.WriteLine("The firstInstance and secondInstance are the same");
} else  {
    Console.WriteLine("Different instances exist.");
}
 Console.Read();
           