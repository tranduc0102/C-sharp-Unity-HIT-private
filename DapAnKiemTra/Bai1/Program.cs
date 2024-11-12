namespace Bai1;

class Program
{
    static void Input()
    {
        int t = Convert.ToInt32(Console.ReadLine());
        string[]?mangString = Console.ReadLine()?.Split(' ');
        
        List<int> mangInt = new List<int>(t);
        for (int i = 0; i < t; i++)
        {
            mangInt.Add(Convert.ToInt32(mangString?[i]));
        }
        if (FindAns(mangInt))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
    static bool FindAns(List<int> list)
    {
        bool ans = true;
        for (int j = 1; j < list.Count; j++)
        {
            if (Math.Abs(list[j] - list[j - 1]) != 5 && Math.Abs(list[j] - list[j-1]) != 7)
            {
                ans = false;
                break;
            }
        }

        return ans;
    }
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 0)
        {
            Input();
            n--;
        }
    }
}