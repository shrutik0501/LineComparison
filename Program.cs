namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Coordinates of the First Line
            double x1 = 0;
            double y1 = 0;
            double x2 = 5;
            double y2 = 5;

            //Coordinates of the Second line
            double x3 = 0;
            double y3 = 0;
            double x4 = 10;
            double y4 = 10;

            //Calculating the lenghts of the two lines
            double lenght1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lenght2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if (lenght1 == lenght2)
            {
                Console.WriteLine("The Two Lines Are Equal");
            }
            else if (lenght1 > lenght2)
            {
                Console.WriteLine("The First Line is greter than Second line");
            }
            else
            {
                Console.WriteLine("The Second Line is Greater than the first line");
            }
            
        }
    }
}