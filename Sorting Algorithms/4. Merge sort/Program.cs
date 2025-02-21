


using System.Runtime.CompilerServices;

int[] input = [ 8,2,4,1,3];
TestMergeSort(input);

foreach (var item in input)
    Console.WriteLine(item);



void MergeSort(int[] input)
{
    if (input.Length == 1)
        return;

    var middle = input.Length / 2;
    var left = GetChunk(input, 0, middle);
    var right = GetChunk(input, middle, input.Length);


    MergeSort(left);
    MergeSort(right);

    Merge(left, right, input);
}



int[] GetChunk(int[] input, int start, int end)
{
    int arrLen = end - start;
    int[] arr = new int[arrLen];
    int j = 0;
    for(int i = start; i < end; i++)
    {
        arr[j] = input[i];
        j++;
    }

    return arr;
}
void Merge(int[] left, int[] right, int[] result)
{
    int i = 0;
    int j = 0;
    int k = 0;

    while(i < left.Length && j < right.Length)
    {
        if (left[i] < right[j])
        {
            result[k] = left[i];
            i++;
        }
        else
        {
            result[k] = right[j];
            j++;
        }
        k++;
    }

    while(i < left.Length)
    {
        result[k++] = left[i++];
    }

    while(j < right.Length)
    {
        result[k++] = right[j++];
    }

}







//Ponavljanje

void TestMergeSort(int[] items)
{
    if (items.Length == 1)
        return;

    int middle = items.Length / 2;
    int[] leftPart = SelectChunk(items, 0, middle);
    int[] rightPart = SelectChunk(items, middle, items.Length);
    //[2,1,4,3] => [2,1] [4,3]
    TestMergeSort(leftPart);
    TestMergeSort(rightPart);

    TestMerge(leftPart, rightPart, items);
}


int[] SelectChunk(int[] items, int start, int end)
{
    int[] arr = new int[end - start];
    int j = 0;
    for (int i = start; i < end; i++)
        arr[j++] = items[i];

    return arr;
}

void TestMerge(int[] left, int[] right, int[] result)
{
    int i = 0;
    int j = 0;
    int k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] < right[j])
            result[k++] = left[i++];
        else result[k++] = right[j++];
    }

    while (i < left.Length)
        result[k++] = left[i++];
    while(j < right.Length)
        result[k++] = right[j++];

}