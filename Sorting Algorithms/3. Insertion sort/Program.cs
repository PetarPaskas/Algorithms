// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] arr = [8, 2, 4, 1, 3,3];

InsertionSort(arr);

foreach(var item in arr)
    Console.WriteLine(item);

void InsertionSort(int[] items)
{
    for(int i = 0; i < items.Length; i++)
    {
        SortOrderedSection(items, i);
    }
}

void SortOrderedSection(int[] items, int currentIndex)
{
    for (int i = currentIndex; i >=1;i--) 
    {
        if (items[i] < items[i - 1])
        {
            int bucket = items[i - 1];
            items[i - 1] = items[i];
            items[i] = bucket;
        }
    }
}
