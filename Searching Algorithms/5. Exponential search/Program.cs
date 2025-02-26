// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] items = [2, 4, 6, 7, 8, 9];
Console.WriteLine(ExponentialSerach(items, 9));

int ExponentialSerach(int[] items, int target)
{
    int right = findRange(items, target, 2);

    return BinarySearch(items, target, 0, right);

}

int findRange(int[] items, int target, int currentIndex)
{
    if (currentIndex > items.Length - 1)
        return items.Length - 1;

    if (items[currentIndex] > target)
        return currentIndex;

    return findRange(items, target, (int)Math.Pow(currentIndex, 2));
}


int BinarySearch(int[] items, int target, int left, int right)
{
    if (left > right)
        return -1;

    int middle = (left + right) / 2;

    if (items[middle] == target)
        return middle;

    if (items[middle] > target)
        return BinarySearch(items, target, left, middle - 1);

    return BinarySearch(items, target, middle + 1, right);
}