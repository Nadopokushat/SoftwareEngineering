#region Task1
using System.Text;

string word = "aligorthm";
word = word.Remove(2, 1);
word = word.Insert(5, "i");
#endregion

#region Task2
Random random = new Random();
string sentence = "";
for (int i = 0, l = random.Next(20, 100); i < l; i++)
{
    sentence += (char)random.Next(33, 127);
}
char symbol = (char)random.Next(33, 127);

int counter = 0;
foreach (char c in sentence)
{
    if (c == symbol)
    {
        counter++;
    }
}
#endregion

#region Task3
Dictionary<char, int> characters= new Dictionary<char, int>();
foreach (char c in sentence)
{
    if (characters.ContainsKey(c))
    {
        characters[c]++;
    }
    else
    {
        characters[c] = 0;
    }
}
Console.Write("Symbols: ");
foreach (KeyValuePair<char, int> s in characters)
{
    if (s.Value == 1)
    {
        Console.Write($"{s.Key} ");
    }
}
#endregion

#region Task4
// string palindromeSentence = "Pull up, Eva! we’re here! Wave! Pull up!";

bool IsPalindrome(string sentence)
{
    if (sentence.Length == 0)
    {
        throw new ArgumentNullException("String length must not be less than 0.");
    }

    for (int i = sentence.Length - 1; i >= 0; i--)
    {
        if (!Char.IsLetter(sentence[i]))
        {
            sentence = sentence.Remove(i, 1);
        }
    }

    sentence = sentence.ToLower();

    for (int i = 0, l = sentence.Length / 2; i <= l; i++)
    {
        if (sentence[i] != sentence[sentence.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}
#endregion

#region Task5
// Only for russian languge

// Console.OutputEncoding = Encoding.UTF8;

sentence = "животное, лыжы, коржи, жызнь, ужин, малышы, карандаши, машына, тишина, шырокий";
int mistakesNumber = 0;
for (int i = 0, l = sentence.Length; i < l; i++)
{
    if (sentence[i] == 'ж' || sentence[i] == 'ш')
    {
        if (i + 1 < l && sentence[i + 1] == 'ы')
        {
            mistakesNumber++;
            sentence = sentence.Remove(i + 1, 1);
            sentence = sentence.Insert(i + 1, "и");
        }
    }
}
Console.WriteLine();
#endregion