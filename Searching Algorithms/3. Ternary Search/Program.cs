



int[] items = [3, 5, 6, 9, 11, 18, 20, 21, 24, 30];
int target = 30;

Console.WriteLine(PublicTernarySearch(items, target));

int PublicTernarySearch(int[] items, int target)
{
    return TernarySearch(items, target, 0, items.Length-1);
}

int TernarySearch(int[] items, int target, int left, int right)
{
    if (left > right)
        return -1;

    int partitionSize = (right - left) / 3;

    int mid1 = left + partitionSize;
    int mid2 = right - partitionSize;

    if (items[mid1] == target)
        return mid1;
    if (items[mid2] == target)
        return mid2;

    if (target < items[mid1])
        return TernarySearch(items, target, left, mid1 - 1);

    if (target > items[mid2])
        return TernarySearch(items, target, mid2+1, right);

    return TernarySearch(items, target, mid1 + 1, mid2 - 1);
}