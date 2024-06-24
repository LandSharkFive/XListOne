
namespace XListOne
{
    public static class Util
    {
        public static bool IsSorted(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i-1] > list[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Print(List<int> list)
        {
            foreach (var x in list)
            {
                Console.Write(x);
                Console.Write(" ");
            }
        }
    }
}
