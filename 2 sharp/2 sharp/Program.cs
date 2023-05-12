using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2_sharp
{
    public class sMatrix
    {
        private char accep;
        private int[,] def;
        private int rows;
        private int[,] mat;
        private int result;
        public sMatrix()
        {
            def = new int[3, 3] { { 3, 3, 5 }, { 2, 6, 4 }, { 5, 3, 1 } };
        }

        private int DiagonalnaSuma(int[,] c)
        { 
            for (int i = 0, j = 0; i < c.GetLength(0) && j < c.GetLength(1);j++, i++)
            {
                result += c[i, j];
            }
            return (result);
        }

        private char Error()
        {
            Console.WriteLine("Ви ввели неправильнi даннi, подивiться уважно");
            Environment.Exit(0);
            return (')');

        }
        
        public void InitializaciaDefMatruci()
        {
            Console.WriteLine("Our matrix is:");
            for (int i = 0; i < def.GetLength(0); i++)
            {

                for (int j = 0; j < def.GetLength(1); j++)
                {

                    Console.Write(def[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the summary of diagonal elements is " + DiagonalnaSuma(def));
        }

        public void InitializaciaMatruci()
        {
            Console.WriteLine("Type the amount of rows:");
            try { rows = Convert.ToInt32(Console.ReadLine()); }
            catch(Exception)
            {
                Error();
            }

            mat = new int[rows, rows];

            Console.WriteLine("Type your matrix numbers:");
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < rows; j++)
                {
                    try
                    {
                        Console.Write("| " + i + " | " + j + "| ");
                        mat[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Error();
                        return;
                    }

                }

            }
            Console.WriteLine("Our matrix is:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the summary of diagonal elements is " + DiagonalnaSuma(mat));
        }

        
        public char acception()
        {
            Console.WriteLine("Do you want to use done square Matrix or not (y/n)");
            try { accep = Convert.ToChar(Console.ReadLine());
                return (accep);
            }
            catch (Exception)
            {
                return (Error());
                 
            }
            //return (accep);
        }
       
    }





    class Program
    {
        static void Main(string[] args)
        {
            sMatrix matr = new sMatrix();
          
            if (matr.acception() == 'y')
            {
                matr.InitializaciaDefMatruci();
       
            }
            else 
            {
                matr.InitializaciaMatruci();
            }
                
        }
    }
}
