using System;

namespace CheckPoint1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Somme d'un tableau

            Console.WriteLine("Please type the number of entry you want on the array :");
            int j;
            j = int.Parse(Console.ReadLine());
            int[] tableauEntier = new int[j];
            Console.WriteLine("Then type in order the number of each cell of the array :");

            
            for (int i = 0; i < j; i++)
            {
                tableauEntier[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(tableauEntier[i]);
            }
            Console.WriteLine();

            //Moyenne d'un tableau

            int k; 
            Random rdmGenerator = new Random();
            k = rdmGenerator.Next(1, 10);
            int sum = 0;
            
            int[] tableauEntierASommer = new int[k];

            for (int i = 0; i < k; i++)
            {
                tableauEntierASommer[i] = rdmGenerator.Next(1, 10);
                Console.Write(tableauEntierASommer[i] + " ");
                sum = tableauEntierASommer[i] + sum;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of array's integers : " + sum);


            float mean = sum / k;
            Console.WriteLine("Mean of the array's integers : " + mean);

        
            //Trier un tableau

            int l;
            Random rdmGenerator2 = new Random();
            l = rdmGenerator2.Next(1, 10);
            int[] tableauATrier = new int[l];


            for (int i = 0; i < l; i++)
            {
                tableauATrier[i] = rdmGenerator2.Next(1, 100);
                Console.Write(tableauATrier[i] + " ");
               
            }
            Console.WriteLine();


                                                // Recherche du minimum
            int min = 100;
            for (int i = 0; i < l; i ++)
            {
                if (min> tableauATrier[i])
                {
                    min = tableauATrier[i];
                }

            }
            Console.WriteLine("The minimum value of the array is : " + min);

                                                // Recherche du maximum
            int max = 0;
            for (int i = 0; i < l; i++)
            {
                if (max < tableauATrier[i])
                {
                    max = tableauATrier[i];
                }

            }
            Console.WriteLine("The maximum value of the array is : " + max);

                                                // Triage du tableau
            int temp;
            for (int i = 0; i < l - 1; i++)
            {
                for (int m = 0; m < l-1; m++)
                {
                    if (tableauATrier[m] > tableauATrier[m+1])
                    {
                        temp = tableauATrier[m + 1];
                        tableauATrier[m + 1] = tableauATrier[m];
                        tableauATrier[m] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array from min to max : ");

            for (int i = 0; i < l; i++)
            {
                Console.Write(tableauATrier[i] + " ");
            }
        }
    }
}
