//matrix rank
//gaussian elimination
//Mahdi Amini Kahrizsangi
//مهدی امینی کهریزسنگی
//mahdiamini@aut.ac.ir
using System;
namespace MatrixRankCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
		int size = 5;
		var A = new double[size, size];
			
		//fill matix with random numbers :
            	var rand = new Random();
            	for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    A[i, j] = rand.NextDouble();

            

            // Operation :
            for (int j = 0; j<size; j++)
            {
                for(int i = j+1; i<size; i++)
                {
                    if(A[i,j] !=0)
                    {
                        if (A[j, j] == 0)
                        {
                            //swap Row i , Row j
                            for (int k = 0; k < size; k++)
                            {
                                var temp = A[i, k];
                                A[i, k] = A[j, k];
                                A[j, k] = temp;
                            }
                        }
                        double scale = A[i, j] / A[j, j];
                        for (int k = 0; k < size; k++)
                            A[i, k] -= scale * A[j, k];
                    }
                }

            }


            //rank:
            int rank = size;
            for (int i = 0; i < size; i++)
                if (A[i, i] == 0)
                    rank--;
            
         
            //print rank:
            Console.WriteLine();
            Console.WriteLine($"rank is {rank}");
            Console.ReadKey();
            

        }

       
    }
}
