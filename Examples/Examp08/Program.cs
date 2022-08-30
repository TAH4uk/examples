// void Method1()
// {
//     Console.WriteLine("Text");
// }

// // Method1();

// void Method2(string text)
// {
//     Console.WriteLine(text);
// }

// Method2("Text message");

// void Method21(string text, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(text);
//         i++;
//     }
// }

// Method21("Text message", 10);

// int Method3()
// {
//     return DateTime.Now.Day;
// }

// int year = Method3();
// Console.WriteLine(year);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "8 ");
// Console.WriteLine(res);

// for(int i = 2; i <= 10; i++)
//     {
//         for (int j = 2; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} * {j} = {i *j}");
//         }
//     Console.WriteLine("");
//     }

string text = "Привет коллега ты знаешь что ты дурачок";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) 
        {
            result = result + $"{newValue}";
        }
        else 
        {
            result = result + $"{oldValue}";                
        }
    }
return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);