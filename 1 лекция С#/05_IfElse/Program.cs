Console.WriteLine("Please Enter your name");
string username = Console.ReadLine();

if (username.ToLower() == "alex")
{
    Console.Write("Meow-meow-purr, " + username + " <3");
}
else 
{
    Console.WriteLine("Hi, " + username);
}