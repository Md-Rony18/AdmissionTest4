using Task1;
WordCounter wordCounter = new WordCounter();
string text=Console.ReadLine();
int ans=wordCounter.Count(text);
Console.WriteLine(ans);
