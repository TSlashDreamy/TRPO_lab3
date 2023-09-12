namespace lab3;

public class Matrix<T> where T : IComparable<T>, new()
{
    private T[,] matrix;

    public Matrix(int rows, int columns)
    {
        matrix = new T[rows, columns];
    }

    public T this[int row, int column]
    {
        get { return matrix[row, column]; }
        set { matrix[row, column] = value; }
    }

    public int Rows
    {
        get { return matrix.GetLength(0); }
    }

    public int Columns
    {
        get { return matrix.GetLength(1); }
    }

    public void Display()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public List<int> FindMatchingRowsAndColumns()
    {
        List<int> matchingIndices = new List<int>();

        for (int k = 0; k < Rows; k++)
        {
            bool isMatching = true;            

            for (int i = 0; i < Columns; i++)
            {
                if (!matrix[k, k].Equals(k + 1))
                {
                    isMatching = false;
                    break;
                }
            }

            if (isMatching)
            {
                matchingIndices.Add(k);
            }
        }

        return matchingIndices;
    }


    public T SumOfElementsInNegativeRows()
    {
        dynamic sum = default(T);

        for (int i = 0; i < Rows; i++)
        {
            bool hasNegativeElement = false;

            for (int j = 0; j < Columns; j++)
            {
                if (matrix[i, j].CompareTo(default(T)) < 0)
                {
                    hasNegativeElement = true;
                    break;
                }
            }

            if (hasNegativeElement)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sum += matrix[i, j];
                }
            }
        }

        return sum;
    }

}

