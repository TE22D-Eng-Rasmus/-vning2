
using System.Linq.Expressions;

string[] leksaker = ["Buzz Lightyear", "Woody", "Mr. Potatohead", "Mrs. Potatohead", "Godzilla"];
string[] klasskamrater = ["Adam", "Wiggo", "Elias", "Simon", "Julius"];
int[] betyg = [1, 3, 10, 4, 8];


if (leksaker.Length == klasskamrater.Length && klasskamrater.Length == betyg.Length)
{

  for (int i = 0; i < leksaker.Length; i++)
  {
    Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {betyg[i]}.");
  }
}

List<string> cities = new List<string>();

bool Loop = true;
while (Loop == true)
{

  Console.WriteLine("Skriv in en stad (eller skriv 'exit' för att avsluta):");
  string input = Console.ReadLine();

  if (input.ToLower() == "exit")
  {

    Loop = false;
  }
  else cities.Add(input);
}
foreach (string city in cities)
{
  Console.WriteLine(city);
}


