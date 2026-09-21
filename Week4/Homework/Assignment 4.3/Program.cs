using System.Runtime.InteropServices;

namespace Assignment_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 Electricity Bill
            Console.WriteLine("Enter Customer ID:");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter Unit:");
            int unit = int.Parse(Console.ReadLine());
            double amountPaid = CalculateElectricityBill(unit, out double rate, out double amountCharges, out double surchargeAmount);

            Console.WriteLine(
                $"Customer IDNO :{customerId}\n" +
                $"Customer Name :{customerName}\n" +
                $"unit Consumed :{unit}\n" +
                $"Amount Charges @$ {rate:F2} per unit: {amountCharges:F2}\n" +
                $"Surcharge Amount: {surchargeAmount:F2}\n" +
                $"Net Amount Paid By the Customer :{amountPaid:F2}");

            //Q2 count the frequency of each element of an array
            Console.WriteLine("");
            Console.WriteLine("Input the number of elements to be stored in the array :");
            int numberOfElements = int.Parse(Console.ReadLine());
            int [] array = new int[numberOfElements];
            Console.WriteLine($"Input {numberOfElements} elements in the array:");
            for(int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"element - {i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Frequency of all elements of array :");
            CountFrequency(array);

            //Q3 print all unique elements in an array
            Console.WriteLine("");
            Console.WriteLine("Input the number of elements to be stored in the array :");
            int numberOfElements2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[numberOfElements2];
            Console.WriteLine($"Input {numberOfElements2} elements in the array:");
            for (int i = 0; i < numberOfElements2; i++)
            {
                Console.WriteLine($"element - {i}:");
                array2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The unique elements found in the array are :");
            PrintAllUniqueElements(array2);
        }

        static double CalculateElectricityBill(int unit,out double rate,out double amountCharges,out double surchargeAmount)
        {
            //<=199 @1.20
            //200<= unit < 400 @1.50
            //400<= unit < 600 @1.80
            //600<= unit @2.00
            
            double amountPaid;

            if (unit >= 0 && unit <= 199)
            {
                rate = 1.20;
                amountCharges = (rate * unit);
            }
            else if (unit >=200 && unit < 400)
            {
                rate = 1.50;
                amountCharges = (rate * unit);
            }
            else if (unit >=400 && unit < 600)
            {
                rate = 1.80;
                amountCharges = (rate * unit);
            }
            else if (unit >= 600)
            {
                rate = 2.00;
                amountCharges = rate * unit;
            }
            else
            {
                rate = 0;
                Console.WriteLine("Please enter a valid number");
                amountCharges = 0;
            }

            if (amountCharges > 400)
            {
                surchargeAmount = 0.15 * amountCharges;
                amountPaid = amountCharges + surchargeAmount;
            }
            else
            {
                surchargeAmount = 0;
                amountPaid = amountCharges;
            }

            return amountPaid;


        }


        static void CountFrequency(int[] array)
        {
            
            for(int i =0; i < array.Length; i++)
            {
                int count = 0;
                bool alreadyCounted = false;

                for (int k = 0; k < i; k++)
                {
                    if (array[i] == array[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }
                if (alreadyCounted)
                {
                    continue;
                }
                for (int j = 0; j < array.Length; j++)
                {
                    if ( array[i] == array[j]) { count++; }
                }
                Console.WriteLine($"{array[i]} occurs {count} times");

            }
            
        }

        static void PrintAllUniqueElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
               
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j]) { count++; }
                }

                if(count == 1)
                {
                    Console.WriteLine($"{array[i]}");
                }

            }

        }
    }
}
