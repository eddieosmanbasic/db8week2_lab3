using System.Collections;


Console.Write("Please enter a word you would like to reverse: ");
string entry = Console.ReadLine();
string reversedString = ReverseString(entry);
Console.WriteLine($"Your word in reverse is: {reversedString}");

static string ReverseString(string entry)
{
    Stack<char> stackedString = new Stack<char>();
    for (int i = 0; i < entry.Count(); i++)
    {
        stackedString.Push(entry[i]);
        
    }
    string reversed = String.Join("", stackedString);
    return reversed;
}