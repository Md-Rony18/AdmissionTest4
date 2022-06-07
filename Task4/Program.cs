using Task4;

FormatChecker formatChecker = new FormatChecker();
string s=Console.ReadLine();
if (formatChecker.IsValid(s))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


