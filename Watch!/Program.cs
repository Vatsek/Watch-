int[] MultOfPairsArray(int[] array)
{
	int length = array.Length;
	int resultArrayLength = length % 2 == 0 ? length / 2 : length / 2 + 1;
	int[] resultArray = new int[resultArrayLength];
	for (int i = 0, j = length - 1; i < resultArrayLength; i++, j--)
	{
		if (i == j)
		{
			resultArray[i] = array[i];
			break;
		}
		resultArray[i] = array[i] * array[j];
	}
	return resultArray;
}

// это к задаче 38!!!! посмотреть как работает

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int[] multiplies;

// FillArrayRandomNumbers(numbers);
// WriteArray(numbers);

// if(numbers.Length % 2 == 0)
// {
//     multiplies = new int[numbers.Length / 2];
// }
// else
// {
//     multiplies = new int[numbers.Length / 2 + 1];
//     multiplies[multiplies.Length - 1] = numbers[numbers.Length / 2];
// }

// for (int i = 0; i < numbers.Length / 2; i++)
// {
//     multiplies[i] = numbers[i] * numbers[numbers.Length - 1 - i];
// }

// WriteArray(multiplies);