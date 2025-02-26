

using static System.Net.Mime.MediaTypeNames;

Console.WriteLine(JumpSearch([3, 4, 6, 7, 9, 10, 11, 12, 13, 20], 13));

int JumpSearch(int[] items, int target)
{
    int optimalBuckets = (int)Math.Sqrt((double)items.Length);
    int currentBucket = 1;
    int itemsPerBucket = items.Length / optimalBuckets;
    int max = -1;

    while(currentBucket <= optimalBuckets)
    {
        int maxIndex = currentBucket * itemsPerBucket-1;
        if (items[maxIndex] >= target)
        {
            max = maxIndex;
            break;
        }
        currentBucket++;
    }

    int left = -1;
    int right = -1;

    if (max == -1)
    {
        right = items.Length - 1;
        left = itemsPerBucket * optimalBuckets;
    }
    else
    {
        right = max;
        left = max - itemsPerBucket+1;
    }
    return FindInRange(items, target, left, right);
}


int FindInRange(int[] items, int target, int left, int right)
{
    int next = left;
    while (next <= right)
    {
        if (items[next] == target)
            return next;
        next++;
    }
    return -1;
}
