
int[] arr = { 1, 8, -25, 85,- 45, 76, 48 ,0};
int number__positive = 0;
int number__negative = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 0)
    {
        number__positive++;

    }
    else number__negative++;

}


Console.WriteLine("The number of negative elements:" + number__negative);
Console.WriteLine("The number of positive elements:" + number__positive);
