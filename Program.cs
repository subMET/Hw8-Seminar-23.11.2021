// 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] CreateRandomMatrix(int n, int m, int min, int max)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] A_m = CreateRandomMatrix(4, 7, 1, 3);
PrintMatrix(A_m);
System.Console.WriteLine();

// 49. Показать двумерный массив размером m×n заполненный вещественными числами
double[,] CreateRandomDoubleMatrix(int n, int m, int min, int max)
{
    double[,] matrix = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(min, max + 1)) * new Random().NextDouble();
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matrix, int signs)
{
    string buffer = String.Empty;
    int L = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            buffer = $"{matrix[i, j]}";
            L = buffer.Length;
            if (L > signs)
            {
                for (int l = 0; l < signs; l++)
                {
                    System.Console.Write($"{buffer[l]}");
                }
            }
            else
            {
                for (int k = 0; k < signs; k++)
                {
                    if (k < signs - L) { System.Console.Write(" "); }
                    else { System.Console.Write(buffer[L - signs + k]); }
                }
            }
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}

double[,] B_m = CreateRandomDoubleMatrix(4, 5, 1, 100);
PrintDoubleMatrix(B_m, 7);
System.Console.WriteLine();

// 50. В двумерном массиве n×k заменить четные элементы на противоположные
int[,] SwitchEvenElements(int[,] matrix)
{
    int[,] new_matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0) new_matrix[i, j] = -matrix[i, j];
            else new_matrix[i, j] = matrix[i, j];
        }
    }
    return new_matrix;
}

int[,] C_m = SwitchEvenElements(A_m);
PrintMatrix(C_m);
System.Console.WriteLine();

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
int[,] SumOfIndexArray(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

int[,] D_m = SumOfIndexArray(5, 8);
PrintMatrix(D_m);
System.Console.WriteLine();

// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] SwitchDoubleEvenSquare(int[,] matrix)
{
    int[,] new_matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j % 2 == 0 && i % 2 == 0) new_matrix[i, j] = matrix[i, j] * matrix[i, j];
            else new_matrix[i, j] = matrix[i, j];
        }
    }
    return new_matrix;
}

int[,] E_m = SwitchDoubleEvenSquare(A_m);
PrintMatrix(E_m);
System.Console.WriteLine();

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int[,] SearchInMatrix(int[,] matrix, int value)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == value) count++;
        }
    }
    int[,] new_matrix = new int[2,count];
    count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == value) 
            {
                new_matrix[0,count] = i;
                new_matrix[1,count] = j;
                count++;
            }
        }
    }
    return new_matrix;
}

int[,] F_m = SearchInMatrix(A_m, 3);
PrintMatrix(F_m);
System.Console.WriteLine();