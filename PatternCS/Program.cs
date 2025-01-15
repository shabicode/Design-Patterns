using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using PatternCS.Observer;

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


Console.WriteLine("**** Observer Pattern Demostration **** \n");
User userOne = new User();
userOne.FullName = "User One";

User userTwo = new User();
userOne.FullName = "User Two";

User userThree = new User();
userOne.FullName = "User Three";

Blog blog = new Blog();
blog.Attach(userOne);
blog.Attach(userTwo);
blog.Attach(userThree);

Post post = new Post();
post.Title = "New Post";
post.Description = "New post description";
post.PublicationTime = DateTime.Now;

blog.AddPost(post);
Console.Read();