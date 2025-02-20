// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] items = [8,2,4,1,3,3];
BubbleSort(items);
foreach(var item in items)
    Console.WriteLine(item);
void BubbleSort(int[] items)
{
    for(int i = 0; i< items.Length-1; i++)
    {
        for(int j = i+1; j < items.Length; j++)
        {
            if (items[j] < items[i])
            {
                int bucket = items[i];
                items[i] = items[j];
                items[j] = bucket;
            }
        }
    }
}