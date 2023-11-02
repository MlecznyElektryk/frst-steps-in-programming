namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] toSort = { 3, 2, 5, 1, 1, 2, 3, 4, 5, 6 };
            int[] bubbleSorted = bubbleSort(toSort);

            Array.Sort(toSort);

            if ( toSort == bubbleSorted)
            {
                Console.WriteLine("It's the same");
            }
           
        }
        static int[] bubbleSort(int[] tab)
        {
            int temp = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                    if (tab[j-1] > tab[j] )
                    {
                        temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }

            return tab;
        }
    }
}