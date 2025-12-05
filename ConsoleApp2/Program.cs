// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//①
int num1 = 7;
int num2 = 3;
Console.WriteLine(num1 + num2);
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 * num2);
Console.WriteLine($"{num1 / num2} 余り{num1 % num2}");

//②
int IntTest = 1;
string StringTest = "01";
string num3 = Convert.ToString(IntTest);
Console.WriteLine($"String {num3}");
int num4 = Convert.ToInt32(StringTest);
Console.WriteLine(++num4);

//③
double price = 123.45;
Console.WriteLine($"価格: {price}");

//④
DateTime today = DateTime.Today;
Console.WriteLine($"今日の日付: {today}");