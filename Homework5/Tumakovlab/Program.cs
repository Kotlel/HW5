using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tumakovlab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task6_1(args);
            //Task6_2();
        }
        static void Task6_1counter(char[] filet)
        {
            char[] vowelsChar = new char[] { 'ё', 'е', 'ы', 'а', 'о', 'э', 'я', 'ю', 'у', 'и', 'Ё', 'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю' };
            char[] consonantsChar = new char[] { 'й', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б', 'Й', 'Ц', 'К', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Х', 'Ф', 'В', 'П', 'Р', 'Л', 'Д', 'Ж', 'Ч', 'С', 'М', 'Т', 'Б' };
            int vowels = 0;
            int consonants = 0;
            foreach (char letter in filet)
            {
                if (vowelsChar.Contains(letter))
                {
                    vowels++;
                }
                else if (consonantsChar.Contains(letter))
                {
                    consonants++;
                }
            }
            Console.WriteLine($"vowels {vowels}, consonants {consonants}");
        }
        static void Task6_1(string[] args)
        {
            string[] text = File.ReadAllLines(@"C:\Users\Kotlel\Documents\file123.txt");
            char[] filet = string.Concat(text).ToCharArray();
            Task6_1counter(filet);
        }
        static void Task6_2()
        {
            int[,] matArray = new int[3, 2];
            int[,] matArray2 = new int[2, 3];
            Random random = new Random();
            for (int i = 0; i < matArray.GetLength(0); i++)
            {
                for (int j = 0; j < matArray.GetLength(1); j++)
                {
                    matArray[i, j] = random.Next(50);
                }
            }
            for (int y = 0; y < matArray2.GetLength(0); y++)
            {
                for (int x = 0; x < matArray2.GetLength(1); x++)
                {
                    matArray2[y, x] = random.Next(50);
                }
            }
            ShowMatrix(MultMat(matArray, matArray2));

        }
        static int[,] MultMat(int[,] matAr1, int[,] matAr2)
        {
            int row1 = matAr1.GetLength(0);
            int col1 = matAr1.GetLength(1);
            int row2 = matAr2.GetLength(0);
            int[,] resultMatrix = new int[row1, row2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < row2; j++)
                {
                    for (int p = 0; p < col1; p++)
                    {
                        resultMatrix[i, j] += matAr1[i, p] * matAr2[j, p];
                    }
                }
            }
            return resultMatrix;
        }
        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
