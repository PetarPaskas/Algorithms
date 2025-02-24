

int[] items = [2, 5, 4, 3, 6, 7];


BucketSort(items, 3);

foreach(var item in items)
    Console.WriteLine(item);


void BucketSort(int[] items, int buckets){
    List<int>[] b = new List<int>[buckets];

    for(int i = 0; i<b.Length; i++)
        b[i] = new List<int>();

    for(int i = 0; i<items.Length; i++)
        b[items[i] / buckets].Add(items[i]);  //podelis iteme po bucketu; item/numOfBuckets : bucketTheItemGoesTo; bitno da je LL

    for (int i = 0; i < b.Length; i++)
        b[i].Sort();    //sort each bucket by a custom sorting algorithm 

    int srcIndex = 0;
    for (int i = 0; i < b.Length; i++)
    {
        var sorted = b[i];
        for(int j = 0; j< sorted.Count; j++)
            items[srcIndex++] = sorted[j]; //upisujes ih redom od 1. bucketa do poslednjeg
    }

}