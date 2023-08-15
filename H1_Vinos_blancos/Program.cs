namespace H1_Vinos_blancos
{
    internal class Program
    {

        // CODE DOES NOT WORK AS INTENDED


        static void Main()
        {
            // Calls the controller
            Controller();
        }

        static void View()
        {
            // Prints out an asterisk
            Console.Write("*");
        }

        static void Controller()
        {
            // Creates a new array, which gets the data from the Model() method
            int[,] data = Model();

            int[] sales = new int[11];
            int[] backup = new int[11];

            for (int i = 0; i < data.Length / 2; i++)
            {
                int is2014 = (int)data.GetValue(i, 0);

                if (is2014 == 2014)
                {
                    data[i, 1] = data[i, 1] + 35432;
                }

                sales[i] = (int)data.GetValue(i, 1);
                backup[i] = sales[i];
            }

            Array.Sort(sales);

            for (int i = 0; i < data.Length; i++)
            {

                int position = Array.IndexOf(sales, data[i, 1]);

                bool contains = sales.Contains(data[position, 1]);

                if (contains)
                {
                    sales[i] = data[i, 1];

                    for (int j = 0; j < data.Length; j++)
                    {
                        int dataCheck = data[j, 1];
                        int modelCheck = Model()[i, 1];
                        if (data[j, 1] == Model()[i, 1])
                        {
                            data[j, 0] = Model()[i, 0];
                        }
                        else
                        {
                            data[j, 0] = 2014;
                        }
                    }
                }

                //Console.WriteLine(sales.Contains(data[position, 1]));
                Console.WriteLine(sales[i]);
                Console.WriteLine(data[position, 1]);
            }



            // Sets a const value of max and maxStars
            const int max = 175388;
            const byte maxStars = 100;

            // 
            for (int i = 0; i < data.Length / 2; i++)
            {

                int star = maxStars * data[i, 1] / max;

                //Console.Write($"{data[i, 0]}: ");

                for (int j = 0; j < star; j++)
                {
                    // View();
                }

                Console.WriteLine();
            }
        }

        static int[,] Model()
        {
            // Has a 2 dimensional array, containing the year and sale of wine
            int[,] data =
            {
                { 2009, 175134 },
                { 2010, 175388 },
                { 2011, 172818 },
                { 2012, 142709 },
                { 2013, 151437 },
                { 2014, 152620 },
                { 2015, 150979 },
                { 2016, 152210 },
                { 2017, 149450 },
                { 2018, 154398 },
                { 2019, 150160 }
            };

            return data;
        }
    }
}