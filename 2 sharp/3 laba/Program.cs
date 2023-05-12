using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3_laba
{
    public class Matrix
    {

        private int Rows;
        private int Col;
        private int Result;
        private int[,] Mat;
        
        public Matrix(int Rows,int Col)
        {
            
            this.Rows = Rows;
            this.Col = Col;
        }
   

        public int DiagonalnaSuma()
        {
            Result = 0;
            for (int i = 0, j = 0; i < Mat.GetLength(0) && j < Mat.GetLength(1); j++, i++)
            {
                Result += Mat[i, j];
            }
            return (Result);
        }

        public void OutMat()
        {
            
            Mat = new int[Rows, Col];
            Random num = new Random();
            for (int i = 0; i < Rows; i++)
            {

                for (int j = 0; j < Col; j++)
                {
                    System.Threading.Thread.Sleep(5);
                    Mat[i, j] = num.Next(0,51);
                    Console.Write(Mat[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сума дiагональних елементiв " + DiagonalnaSuma());

            
        }

    }





    class Program
    {
        static void Main(string[] args)
        {

            Student o = new Student(18);
            o.Print(18);

        }
    }
}

