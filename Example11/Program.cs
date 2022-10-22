// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы 'к' заменить большими 'К', а маление буквы 'с'
// заменить большими 'С'. 

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
             + "ежели бы вас послали вместо нашего милого Винцегороде,"
             + "вы бы взяли приступом согласие прусского короля."
             + "Вы так красноречивы. Вы дадите мне чаю?";
//String s = "qwerty";
//            0123    
//s[3] // r
  
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();
