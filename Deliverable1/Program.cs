Console.WriteLine("Restock Tool");
int sodaStock = 100;
int chipStock = 40;
int candyStock = 60;
int sodaRestock = 40;
int chipRestock = 20;
int candyRestock = 40;
int userInput = 0;


Console.WriteLine($"How Many Sodas have been sold today? {sodaStock} are in stock.");
userInput = int.Parse(Console.ReadLine());
if (userInput > sodaStock)
{
  Console.WriteLine("That Value is too high. Stock not adjusted");
}
else
{
  sodaStock -= userInput;
  Console.WriteLine($"There are {sodaStock} sodas left.");
}
if (sodaStock <= sodaRestock)
{
  Console.WriteLine("Soda needs to be restocked");
}



Console.WriteLine($"How Many Chips have been sold today? {chipStock} are in stock.");
userInput = int.Parse(Console.ReadLine());
if (userInput > chipStock)
{
  Console.WriteLine("That Value is too high. Stock not adjusted");
}
else
{
  chipStock -= userInput;
  Console.WriteLine($"There are {chipStock} chips left.");
}

if (chipStock <= chipRestock)
{
  Console.WriteLine("Chips need to be restocked");
}


Console.WriteLine($"How Many Candy have been sold today? {candyStock} are in stock.");
userInput = int.Parse(Console.ReadLine());
if (userInput > candyStock)
{
  Console.WriteLine("That Value is too high. Stock not adjusted");
}
else
{
  candyStock -= userInput;
  Console.WriteLine($"There are {candyStock} Candies left.");
}
if (candyStock <= candyRestock)
{
  Console.WriteLine("Candy needs to be restocked");
}