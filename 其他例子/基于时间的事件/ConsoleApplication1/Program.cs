using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using System.Timers;

namespace ConsoleApplication1
{

    class Program
    {
        #region test
        /*struct customerName
        {
            public string firstName, lastName;
            public string Name()
            {
                return firstName + " " + lastName;
            }
        }*/

        /*delegate double processDelegate(double param1, double param2);
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }*/

        /*static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maxium value search started.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine("Maximum value initialized to " + maxVal + "， at element index 0.");
            for (int i = 1; i < integers.Length; i++)
            {
                Debug.WriteLine("Now looking at element at index " + i + ".");
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine("New maximum found. New value is " + maxVal + ", at element index " + i + ".");
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine("Duplicate maximum found at element index " + i + ".");
                    }
                }
            }
            Trace.WriteLine("Maximum value " + maxVal + " found, with " + count + " occurrences.");
            Debug.WriteLine("Maximum value search comleted.");
            return maxVal;
        }*/

        /*public static IEnumerable SimpleList()
        {
	        yield return "string 1";
	        yield return "string 2"; 
	        yield return "string 3";
        }*/
        #endregion
        static string displayString = "This string will appear one letter at a time.";
        static int counter = 0;
        static void WriteChar(object source, ElapsedEventArgs e)
        {
            Console.Write(displayString[counter++ % displayString.Length]);
        }

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            myTimer.Start();
            #region test
            /*foreach (string item in SimpleList())
		        Console.WriteLine(item);
	        Console.ReadKey();*/

            /*int[] testArray = {4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9};
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);
            Console.WriteLine("Maxium value {0} found at element indices:", maxVal);
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }*/

            /*processDelegate process;
            Console.WriteLine("Enter 2 number separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divide");
            input = Console.ReadLine();
            if (input == "M")
                process = new processDelegate(Multiply);
            else
                process = new processDelegate(Divide);
            Console.WriteLine("Result: {0}", process(param1, param2));*/

            /*customerName myCustomer;
            myCustomer.firstName = "John";
            myCustomer.lastName = "Frankin";
            Console.WriteLine(myCustomer.Name());*/

            /*double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
            {
                for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp) - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }*/

            /*string[] friendNames = {"Robert Barwell", "Mike Parry", "Jeremy Beacock"};
            Console.WriteLine("Here are {0} of my friends:", friendNames.Length);
            foreach (string name in friendNames)
            {
                Console.WriteLine(name);
            }*/

            /*string myString = "This is a test.";
            char[] separator = {'s'};
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }*/

            /*Console.WriteLine("{0} command line arguments were specified:", args.Length);
            foreach (string arg in args)
                Console.WriteLine(arg);*/
            #endregion
            Console.ReadKey();
        }
    }
}
