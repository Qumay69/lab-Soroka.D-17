namespace lab
{
    public class Class1
    {
        public static long treper(int[,] nazvanie)
        {
            long reper = 1;

            for (int t = 0; t < 6; t++)
            {
                for (int r = 0; r < 6; r++)
                {
                    if (t == r)
                    {
                        reper *= nazvanie[t, r];
                    }
                }
            }
            return reper;
        }
    }
}