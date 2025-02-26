

int[] items = [15, 6, 13,3, 1, 22, 10, 13];
QuickSort(items);

foreach(var item in items)
    Console.WriteLine(item);


void QuickSort(int[] items)
{
    PutPivotIntoPlace(items, -1, items.Length-1);
}

void PutPivotIntoPlace(int[] items, int boundry, int pivot)  //n^logn
{
    if (pivot <= boundry)
        return;

    int pivotIndex = pivot;

    int b = boundry;
    
    for(int i = boundry+1; i < pivotIndex; i++)
    {
        if (items[i] < items[pivotIndex]) //pomera se samo ukoliko su itemi manji
        {                                 //ukoliko je item manji onda se taj item pomera na mesto boundrya
            b++;                          //to znaci da veci item ide ispred boundrya
            Swap(items, b, i);            // i pri poslednjem swapu
        }
    }

    b++;
    Swap(items, b, pivotIndex);         //ce se pivot zameniti sa boundry+1 tj prvim vecim itemom

    PutPivotIntoPlace(items, -1, b - 1);
    PutPivotIntoPlace(items, b, pivot);
}

void Swap(int[] items, int i1, int i2)
{
    int bucket = items[i1];
    items[i1] = items[i2];
    items[i2] = bucket;
} 