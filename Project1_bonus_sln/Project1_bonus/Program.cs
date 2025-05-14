using System;
using System.Xml.Serialization;

namespace Project1_bonus
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
        }
        static void PrintMatrix(int[,] arr)
        {
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //Array based functions
        static void ShiftArrRight(int[] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                        break;
                    if (arr[i] == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
            }
        }
        static void MergeRight(int[] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                        break;
                    if (arr[i] == arr[i - 1])
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[i - 1];
                        //arr[i - 1] = temp;
                        arr[i] += arr[i];
                        arr[i - 1] = 0;
                        ShiftArrRight(arr);
                    }
                }
            }
        }
        static void ShiftArrLeft(int[] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                        break;
                    if (arr[i] == 0)
                    {
                        arr[i] = arr[i + 1];
                        arr[i + 1] = 0;
                    }
                }
            }
        }
        static void MergeLeft(int[] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                        break;
                    if (arr[i] == arr[i + 1])
                    {
                        arr[i] += arr[i + 1];
                        arr[i + 1] = 0;
                        ShiftArrLeft(arr);
                    }
                }
            }
        }
        //Matrix based functions
        static void ShiftMatrixRight(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int i = arr.GetLength(1) - 1; i >= 0; i--)
                    {
                        if (i == 0)
                            break;
                        if (arr[j,i] == 0)
                        {
                            //int temp = arr[i,j];
                            arr[j,i] = arr[j , i-1];
                            arr[j , i-1] = 0;
                        }
                    }
                }
            }
        }
        static void MergeMatrixRight(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int i = arr.GetLength(1) - 1; i >= 0; i--)
                    {
                        if (i == 0)
                            break;
                        if (arr[j, i] == arr[j, i-1])
                        {
                            //int temp = arr[i,j];
                            arr[j, i] += arr[j, i - 1];
                            arr[j, i - 1] = 0;
                            i--;
                            //ShiftMatrixRight(arr);
                        }
                    }
                }
            }
        }
        static void ShiftMatrixLeft(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        if (i == arr.GetLength(1) - 1)
                            break;
                        if (arr[j, i] == 0)
                        {
                            arr[j, i] = arr[j, i + 1];
                            arr[j, i + 1] = 0;
                        }
                    }
                }

            }
        }
        static void MergeMatrixLeft(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        if (i == arr.GetLength(1) - 1)
                            break;
                        if (arr[j, i] == arr[j, i + 1])
                        {
                            arr[j, i] += arr[j, i + 1];
                            arr[j, i + 1] = 0;
                            i++;
                            //ShiftMatrixLeft(arr);
                        }
                    }
                }

            }
        }
        static void ShiftMatrixUp(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        if (j == arr.GetLength(0) - 1)
                            break;
                        if (arr[j, i] == 0)
                        {
                            arr[j, i] = arr[j + 1, i];
                            arr[j + 1, i] = 0;
                        }
                    }
                }
            }
        }
        static void MergeUp(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        if (j == arr.GetLength(0) - 1)
                            break;
                        if (arr[j, i] == arr[j + 1, i])
                        {
                            arr[j, i] += arr[j + 1, i];
                            arr[j + 1, i] = 0;
                            j++;
                            //ShiftMatrixUp(arr);
                        }
                    }
                }
            }
        }
        static void ShiftMatrixDown(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = arr.GetLength(0) - 1; j > 0; j--)
                    {
                        if (j == 0)
                            break;
                        if (arr[j, i] == 0)
                        {
                            arr[j, i] = arr[j - 1, i];
                            arr[j - 1, i] = 0;
                        }
                    }
                }
            }
        }
        static void MergeDown(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = arr.GetLength(0) - 1; j > 0; j--)
                    {
                        if (j == 0)
                            break;
                        if (arr[j, i] == arr[j - 1, i])
                        {
                            arr[j, i] += arr[j - 1, i];
                            arr[j - 1, i] = 0;
                            j--;
                            //ShiftMatrixDown(arr);
                        }
                    }
                }
            }
        }

        //Full Move functions
        static void MoveRight(int[,] arr)
        {
            ShiftMatrixRight(arr);
            MergeMatrixRight(arr);
            ShiftMatrixRight(arr);
        }
        static void MoveLeft(int[,] arr)
        {
            ShiftMatrixLeft(arr);
            MergeMatrixLeft(arr);
            ShiftMatrixLeft(arr);
        }
        static void MoveUp(int[,] arr)
        {
            ShiftMatrixUp(arr);
            MergeUp(arr);
            ShiftMatrixUp(arr);
        }
        static void MoveDown(int[,] arr)
        {
            ShiftMatrixDown(arr);
            MergeDown(arr);
            ShiftMatrixDown(arr);
        }
        static void NoMove(int[,] arr)
        {
            //nothing 
        }
        static bool IsFull(int[,] arr)
        {
            int flag = 0;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        flag = 1; 
                        break;
                    }
                }
            }
            if (flag == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Check if the position is empty
        static bool IsEmptyPosition(int[,] arr, int row, int column)
        {
            if (arr[row,column] != 0)
                return false;
            else return true;
        }
        static void SpawnNum2(int[,] arr)
        {
            Random random = new Random();
            int x = random.Next(0, 15);
            int row = (x - (x % 4)) / 4;
            int col = x % 4;

            if (IsEmptyPosition(arr, row, col))
            {
                arr[row,col] = 2;
            }
            else
            {
                if (!IsFull(arr))
                {
                    SpawnNum2(arr);
                }
            }
        }
        //Check win
        static bool CheckWin(int[,] arr)
        {
            
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] == 2048)
                    {
                        Console.WriteLine("Congrats! You win...");
                        return true;
                    }
                }
            }
            return false;
        }
        delegate void Move(int[,] arr);
        static void Main(string[] args)
        {
            
            int[,] arr2D = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0} };
            SpawnNum2(arr2D);
            
            PrintMatrix(arr2D);
            Move MoveGame;
            while (true)
            {
                Console.Clear();  // Clears the console screen
                PrintMatrix(arr2D);
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: MoveGame = MoveUp; break;

                    case ConsoleKey.DownArrow: MoveGame = MoveDown; break;

                    case ConsoleKey.LeftArrow: MoveGame = MoveLeft; break;

                    case ConsoleKey.RightArrow: MoveGame = MoveRight; break;

                    case ConsoleKey.Escape:
                        MoveGame = NoMove;
                        break;  // Exit the switch

                    default:
                        MoveGame = NoMove;
                        break;

                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Exiting Game...");
                    break;
                }
                MoveGame(arr2D);
                SpawnNum2(arr2D);
                PrintMatrix(arr2D);
                if(CheckWin(arr2D))
                    break;
            }
            

            //Console.WriteLine("Random num: "+ x);
        }
    }
}
