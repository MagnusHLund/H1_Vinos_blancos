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
            int[] data = Model();

            // Creates a bool which should only run once
            bool doOnce = false;

            // Sets a const value of max and maxStars
            const int max = 175388;
            const byte maxStars = 100;

            // Runs a for loop, as many times as there is ints in data
            for (int i = 0; i < data.Length; i++)
            {
                // Do this once
                if (!doOnce)
                {
                    // Changes the 5th int (2014), by adding 35432 to the value and changes the 
                    data[5] = data[5] + 35432;
                    doOnce = !doOnce;
                }

                // Sorts the data, by highest and lowest value
                Array.Sort(data);

                // Calculates how many stars should be outputted
                int star = maxStars * data[i] / max;

                // Calls the View() method, until j is as big as star
                for (int j = 0; j < star; j++)
                {
                    View();
                }

                // Goes to the next line
                Console.WriteLine();
            }
        }

        static int[] Model()
        {
            // Creates an array, containing the sale of wine
            int[] data =
            {
                175134, // 2009
                175388, // 2010
                172818, // 2011
                142709, // 2012
                151437, // 2013
                152620, // 2014
                150979, // 2015
                152210, // 2016
                149450, // 2017
                154398, // 2018
                150160 // 2019
            };

            // Sends the array to wherever the method is being called from
            return data;
        }
    }
}