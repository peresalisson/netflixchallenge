using System;

class Program
{
    static char FirstUniqChar(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            bool isUnique = true;

            for (int j = 0; j < s.Length; j++)
            {
                if (i != j && currentChar == s[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                return currentChar;
            }
        }
        return '_';
    }

    static void Main()
    {
        string s = "abacabad";
        //string u = "aabbccddeeffgghh";
        char result = FirstUniqChar(s);
        Console.WriteLine($"FirstUniqChar(s) = '{result}'");
    }
}
