using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class MaximumPopulationYear
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Nhap so nguoi: ");
        //    int n = int.Parse(Console.ReadLine());
        //    int[][] logs = new int[n][];

        //    logs = new int[][]
        //    {
        //        new int[] { 1950, 1961 },
        //        new int[] { 1960, 1971 },
        //        new int[] { 1970, 1981 }
        //    };

        //    //for (int i=0; i<n; i++)
        //    //{
        //    //    logs[i] = new int[2];
        //    //    Console.WriteLine($"Birth Day num{i+1}: ");
        //    //    logs[i][0] = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine($"Death num{i + 1}: ");
        //    //    logs[i][1] = int.Parse(Console.ReadLine());
        //    //    while (logs[i][1] < logs[i][0])
        //    //    {
        //    //        Console.WriteLine($"Nhap lai Death num{i + 1}: ");
        //    //        logs[i][1] = int.Parse(Console.ReadLine());
        //    //    }  
        //    //}

        //    int result = MaximumPopulation(logs);
        //    Console.WriteLine("Ket qua: " + result);
        //}

        static public int  MaximumPopulation(int[][] logs)
        {
            SortedDictionary<int, int> population = new SortedDictionary<int, int>();
            for(int i=0; i < logs.Length; i++)
            {
                var person = logs[i];
                for (int birth = person[0]; birth < person[1]; birth++)
                {
                    if (population.ContainsKey(birth))
                    {
                        population[birth]++;
                    }
                    else
                    {
                        population.Add(birth, 1);
                    }
                }
            }

            int maxValue = population.Max(x => x.Value);
            var result = population.OrderBy(x=> x.Key).FirstOrDefault(x => x.Value == maxValue).Key;
            return result;
        }
    }
}
