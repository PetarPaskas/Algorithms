

int[] items = [5, 3, 2, 5, 4, 4, 5];

CountingSort(items);

foreach(var item in items)
    Console.WriteLine(item);

void CountingSort(int[] items)
{
    var countingArray = GetCountingArray(items);
    CountTheCountingArray(items,countingArray);

    SortBasedOnCountingArray(items, countingArray);
}

void SortBasedOnCountingArray(int[] items, int[] countingArray)
{
    int itemsIndex = 0;
    for (int i = 0; i<countingArray.Length; i++)
    {
        if (countingArray[i] == 0)
            continue;

        for (int x = 0; x < countingArray[i]; x++)
            items[itemsIndex++] = i;
    }
}

void CountTheCountingArray(int[] items, int[] countingArray)
{

    for (int i = 0; i < items.Length; i++)
    {
        int countingArrayIndex = items[i];
        countingArray[countingArrayIndex]++;
    }
}
int[] GetCountingArray(int[] items)
{
    int max = items[0];

    for(int i = 0; i< items.Length;i++)
        if (items[i] > max)
            max = items[i];

    return new int[max + 1];
}