


int[] items = [8, 2, 4, 1, 3];

SelectionSort(items);

foreach (var item in items)
    Console.WriteLine(item);

void SelectionSort(int[] items)
{
    for(int i = 0; i < items.Length-1; i++)
    {
        int indexAtNewSmallest = i;

        for(int j = i+1; j < items.Length; j++)
        {
            if (items[j] < items[indexAtNewSmallest])
                indexAtNewSmallest = j;
        }

        int bucket = items[i];
        items[i] = items[indexAtNewSmallest];
        items[indexAtNewSmallest] = bucket;
    }
}