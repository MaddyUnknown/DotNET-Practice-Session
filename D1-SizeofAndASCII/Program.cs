// Using top level statement (introduced in C# 10)

Console.WriteLine("Size of interger: " + sizeof(int) + " bytes");
Console.WriteLine("Size of byte: " + sizeof(byte) + " bytes");
Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
Console.WriteLine("Size of decimal: " + sizeof(decimal) + " bytes");
Console.WriteLine("Size of char: " + sizeof(char) + " bytes");


char charVal;
Console.WriteLine("Enter a character: ");
try
{
    charVal = Convert.ToChar(Console.ReadLine());
}
catch(Exception exp)
{
    Console.WriteLine(exp.Message);
    return;
}

Console.WriteLine((int)charVal);

for (int i = 0; i < 128; i++)
{
    Console.WriteLine($"{i} -> {(char)i}");
}