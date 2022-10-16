string text = Console.ReadLine();
string[] array = text.Split(new char[]{' ',',',';'}, StringSplitOptions.RemoveEmptyEntries);

var result = from word in array
    where word.Length <= 3
    select word;
if (result.Count() == 0) Console.WriteLine("[]");
else 
{
    foreach (string word in result) 
    Console.Write(word + "; ");
}