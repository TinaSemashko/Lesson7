using System;

bool Compare(string str1, string str2)
{
    return str1.Equals(str2);
}

bool Compare1(string str1, string str2)
{
    return str1==str2;
}

Console.WriteLine(Compare("Test_25%", "Test_25%"));
Console.WriteLine(Compare1("Test_25%", "Test_25%"));

string Analyse(string str)
{
    int digit = 0;
    int letters = 0;
    int simbols = 0;
   
    for (int i=0; i<str.Length; i++)
    {
        if (char.IsDigit(str[i])) digit++;
        else if (char.IsLetter(str[i])) letters++;
        else if (char.IsAscii(str[i])) simbols++;
    }

   return "in string: " + digit + " digit, " + letters + " letters and " + simbols + " simbols ";
}
Console.WriteLine(Analyse("Test_25%Asd6789&&"));

string SortStr(string str) {

    bool wasChanges = false;
    char[] arr;
    arr = str.ToCharArray(0, str.Length);
    do
    {
        wasChanges = false;
        for (int i = 0; i < str.Length - 1; i++)
        {

            if (str[i] > str[i + 1])
            {
                arr[i] = str[i + 1];
                arr[i+1] = str[i];
                str = new(arr);
                wasChanges = true;
            }
            else
            {
                arr[i] = str[i];
            }
        }
       
    } while (wasChanges);
   
    return str;
}
Console.WriteLine(SortStr("hellocba"));

string SortStr1(string str)
{
    char[] arr = str.ToCharArray(0, str.Length);     
    Array.Sort(arr);
    str = new(arr);

    return str;
}
Console.WriteLine(SortStr1("hellocba"));

string Duplicate(string str)
{    
    string res = "";
    int k = 0;
    str = str.ToLower();
    for (int i = 0; i < str.Length - 1; i++)
    {
        if (str[i] == ' ') continue;
        string temp = str[i].ToString();
        int indStart = str.IndexOf(temp);
        int indEnd = str.LastIndexOf(temp);
        if (indStart != indEnd && !res.Contains(temp))
        {
            res=res.Insert(k, temp);
            k++;
        }
    }

    return res;
}
Console.WriteLine(Duplicate("Hello and hi"));
//checked
