/*
int numberA = new Random().Next(1,10);
int numberB = new Random().Next(1,10);

System.Console.WriteLine(numberA);
System.Console.WriteLine(numberB);
*/

System.Console.Write("write sasha with any registr on any symbols: ");
string username = Console.ReadLine();

if(username.ToLower() == "sasha")
{
    Console.Write("it works!");
}
else
{
    System.Console.WriteLine("smth goes wrong(((");
}