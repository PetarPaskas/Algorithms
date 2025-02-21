

int[] items = [15, 6, 13,3, 1, 22, 10, 13];
QuickSort(items);

foreach(var item in items)
    Console.WriteLine(item);


void QuickSort(int[] items)
{
    PutPivotIntoPlace(items, -1, items.Length-1);
}

void PutPivotIntoPlace(int[] items, int boundry, int pivot)
{
    if (pivot <= boundry)
        return;

    int pivotIndex = pivot;

    int b = boundry;
    
    for(int i = boundry+1; i < pivotIndex; i++)
    {
        if (items[i] < items[pivotIndex])
        {
            b++;
            Swap(items, b, i);
        }
    }

    b++;
    Swap(items, b, pivotIndex);

    PutPivotIntoPlace(items, -1, b - 1);
    PutPivotIntoPlace(items, b, pivot);
}

void Swap(int[] items, int i1, int i2)
{
    int bucket = items[i1];
    items[i1] = items[i2];
    items[i2] = bucket;
} 