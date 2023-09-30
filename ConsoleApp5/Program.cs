namespace ConsoleApp5
{
    internal class Program
    {
        static void DivNum(int num)
        {
            int[] array_of_div = new int[num];
            int div_num = 1;
            int counter = 0;
            while (div_num <= num)
            {
                if (num % div_num == 0)
                {
                    array_of_div[counter] = div_num;
                    counter++;
                }
                div_num++;
            }
            
            for (int i = 0; i < counter; i++)
            {
                Console.Write(array_of_div[i] + "    ");
            }
            Console.WriteLine();
        }
        static void MulTable()
        {
            int[,] matrix = new int[9, 9];
            int k = 1;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    matrix[i, j] = (j + 1) * k;
                k++;
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write(matrix[j, i] + "      ");
                Console.WriteLine();
            }
        }
        static void GuessTheNumber()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 101);
            Console.WriteLine("input number 0-100");
            int num = int.Parse(Console.ReadLine());
            while (num != value)
            {
                if (num > value)
                {
                    Console.WriteLine("remove");
                    num = int.Parse(Console.ReadLine());
                }
                else if (num < value)
                {
                    Console.WriteLine("add");
                    num = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("you win!");
            return;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("please, input number of game \n" +
                             "1. guess the number \n" +
                             "2. multiplication table \n" +
                             "3. output of number divisors \n" +
                             "4. quit \n");

                int answer = 0;

                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("wrong input");
                    break;
                }

                switch (answer)
                {
                    case 1:
                        GuessTheNumber();
                        break;
                    case 2:
                        MulTable();
                        break;
                    case 3:
                        Console.WriteLine("input number: ");
                        int some_number = int.Parse(Console.ReadLine());
                        DivNum(some_number);
                        break;
                    case 4:
                        return;         
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            }
        }  
    }
}