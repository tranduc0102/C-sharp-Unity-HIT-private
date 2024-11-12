﻿using System;
using System.Text;
 
namespace Bai3
{
    class Program
    {
        static bool Has1100At(char[] chars, int start)
        {
            return start >= 0 && start + 3 < chars.Length &&
                   chars[start] == '1' && chars[start + 1] == '1' &&
                   chars[start + 2] == '0' && chars[start + 3] == '0';
        }
 
        static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            StringBuilder output = new StringBuilder();
 
            while (t-- > 0)
            {
                string s = Console.ReadLine();
                int q = Convert.ToInt32(Console.ReadLine());
                char[] chars = s.ToCharArray();
                
                
                int count1100 = 0;
                for (int i = 0; i <= chars.Length - 4; i++)
                {
                    if (Has1100At(chars, i))
                        count1100++;
                }
                
                for (int i = 0; i < q; i++)
                {
                    string[] listString = Console.ReadLine().Split(' ');
                    int pos = Convert.ToInt32(listString[0]) - 1;
                    char newChar = Convert.ToChar(listString[1]);
                    
                    if (chars[pos] != newChar)
                    {
                        for (int j = pos - 3; j <= pos; j++)
                        {
                            if (Has1100At(chars, j))
                                count1100--;
                        }
                        
                        chars[pos] = newChar;
                        
                        for (int j = pos - 3; j <= pos; j++)
                        {
                            if (Has1100At(chars, j))
                                count1100++;
                        }
                    }
                    
                    output.AppendLine(count1100 > 0 ? "YES" : "NO");
                }
            }
 
            Console.Write(output.ToString());
        }
    }
}