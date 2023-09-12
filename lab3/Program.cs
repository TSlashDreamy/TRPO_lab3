using lab3;

Matrix<int> intMatrix = new Matrix<int>(3, 3);
intMatrix[0, 0] = 1;
intMatrix[1, 1] = 2;
intMatrix[2, 2] = 3;
intMatrix[0, 1] = 4;
intMatrix[1, 0] = 4;
intMatrix[2, 1] = -5;
intMatrix[1, 2] = -6;

Console.WriteLine("Matrix:");
intMatrix.Display();

List<int> matchingIndices = intMatrix.FindMatchingRowsAndColumns();
Console.WriteLine("Matching Rows and Columns:");
foreach (var index in matchingIndices)
{
    Console.WriteLine(index);
}

int sum = intMatrix.SumOfElementsInNegativeRows();
Console.WriteLine("Sum of elements in rows with at least one negative element: " + sum);
