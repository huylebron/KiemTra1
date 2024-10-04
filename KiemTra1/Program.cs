namespace KiemTra1
{
    internal class Program
    {
        static void Main()
        {
            int[] Arr = nhapArr();
            Dictionary<int, int> dic = demSo(Arr);
            Show(dic);
        }

        static int[] nhapArr()
        {
            Console.WriteLine("nhap cac so cach nhau  = dau cach ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("khong dc null or emty.");
                return new int[0];
            }

            string[] StrArr = input.Split(' ');

            int[] Arr = new int[StrArr.Length];

            for (int i = 0; i < StrArr.Length; i++)
            {
                if (int.TryParse(StrArr[i], out int n))
                {
                    Arr[i] = n;
                }
            }

            return Arr;
        }

        static Dictionary<int, int> demSo(int[] Arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in Arr)
            {
                if (dic.TryGetValue(i, out int n))
                {
                    dic[i] = n + 1;
                }
                else
                {
                    dic[i] = 1;
                }
            }

            return dic;
        }

        static void Show(Dictionary<int, int> dic)
        {
            Console.WriteLine("\n result:");
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} xuat hien {item.Value} lan");
            }
        }
    }
}