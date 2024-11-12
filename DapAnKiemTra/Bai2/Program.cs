namespace Bai2
{
    class Program
    {
        static int Ans(int n, int k)
        {
            // Tạo mảng `listNumber` với các giá trị ban đầu là 0
            int[] listNumber = new int[k+1];

            for (int i = 0; i < k; i++)
            {
                string[]? listStringA = Console.ReadLine()?.Split(' ');
                int index = Convert.ToInt32(listStringA?[0]);
                int value = Convert.ToInt32(listStringA?[1]);
                
                if (index >= 0 && index <= k)
                {
                    listNumber[index] += value;
                }
            }
            
            var sortedList = listNumber.ToList();
            sortedList.Sort();
            int sum = 0, dem = n;
            for (int i = sortedList.Count-1; i > 0; i--)
            {
                if (dem > 0)
                {
                    sum += sortedList[i];
                    dem--;
                }
                else
                {
                    break;
                }
            }

            return sum;
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n>0)
            {
                string[]? listStringA = Console.ReadLine()?.Split(' ');
                int a = Convert.ToInt32(listStringA?[0]);
                int b = Convert.ToInt32(listStringA?[1]);
                Console.WriteLine(Ans(a, b));
                n--;
            }
        }
    }
}