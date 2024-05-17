using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class ShellSortExperiment
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("ShellSort.csv"))
        {
            writer.WriteLine("Array Size,Average Time (ms),Total Sort Time (ms)");

            int start = 10000;
            int step = 10000;
            int arraySize = 50;
            long totalSortTime = 0;
            int[] sizes = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                sizes[i] = start + i * step;
            }
            int repetitions = 1;

            Console.WriteLine("Wykonuję sortowanie Shella dla różnych rozmiarów danych losowych...");
            Console.WriteLine("Rozmiar danych\t| Średni czas (ms)\t| Łącznie sortowany czas (ms)");

            foreach (int size in sizes)
            {
                Random random = new Random();
                long totalTime = 0;
                for (int rep = 0; rep < repetitions; rep++)
                {
                    int[] array = GenerateRandomArray(size, random);
                    totalTime += MeasureSortTime(array);
                }
                long averageTime = totalTime / repetitions;
                totalSortTime += averageTime;
                writer.WriteLine($"{size},{averageTime}, {totalSortTime}");
                Console.WriteLine($"{size}\t\t| {averageTime}\t\t\t| {totalSortTime}");
            }
        }
    }


    static long MeasureSortTime(int[] array)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        ShellSort(array);
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }


    // SHELLSORT SHELL SEQUENCE



    //static void ShellSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    List<int> gaps = GenerateCustomSequence(n);

    //    foreach (int gap in gaps)
    //    {
    //        for (int i = gap; i < n; i++)
    //        {
    //            int temp = arr[i];
    //            int j;
    //            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
    //            {
    //                arr[j] = arr[j - gap];
    //            }
    //            arr[j] = temp;
    //        }
    //    }
    //}

    //static List<int> GenerateCustomSequence(int size)
    //{
    //    List<int> gaps = new List<int>();
    //    int k = 1;
    //    int gap = size / 2;
    //    while (gap > 0)
    //    {
    //        gaps.Add(gap);
    //        gap = size / (int)Math.Pow(2, k);
    //        k++;
    //    }
    //    return gaps;
    //}





    // HIBBARD SEQUENCE A000225




    //static void ShellSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    // Generating Hibbard sequence
    //    List<int> gaps = GenerateHibbardSequence(n);

    //    // Sorting using Hibbard sequence
    //    foreach (int gap in gaps)
    //    {
    //        for (int i = gap; i < n; i++)
    //        {
    //            int temp = arr[i];
    //            int j;
    //            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
    //            {
    //                arr[j] = arr[j - gap];
    //            }
    //            arr[j] = temp;
    //        }
    //    }
    //}

    //static List<int> GenerateHibbardSequence(int size)
    //{
    //    List<int> gaps = new List<int>();
    //    int k = 1;
    //    int gap = 1;
    //    while (gap < size)
    //    {
    //        gaps.Add(gap);
    //        k++;
    //        gap = (int)(Math.Pow(2, k) - 1);
    //    }
    //    gaps.Reverse(); // Reverse the sequence to start with the largest gap
    //    return gaps;
    //}




    // SEDGEWICK SEQUENCE A036562




    //static void ShellSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    // Generating custom sequence
    //    List<int> gaps = GenerateCustomSequence(n);

    //    // Sorting using custom sequence
    //    foreach (int gap in gaps)
    //    {
    //        for (int i = gap; i < n; i++)
    //        {
    //            int temp = arr[i];
    //            int j;
    //            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
    //            {
    //                arr[j] = arr[j - gap];
    //            }
    //            arr[j] = temp;
    //        }
    //    }
    //}

    //static List<int> GenerateCustomSequence(int size)
    //{
    //    List<int> gaps = new List<int>();
    //    int k = 0;
    //    int gap = 0;
    //    while (gap < size)
    //    {
    //        gap = (int)(Math.Pow(4, k) + 3 * Math.Pow(2, k - 1) + 1);
    //        if (gap < size)
    //            gaps.Add(gap);
    //        k++;
    //    }
    //    gaps.Reverse(); // Reverse the sequence to start with the largest gap
    //    return gaps;
    //}



    // MARCIN CIURA SEQUENCE A102549

    //static void ShellSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    // Generating Ciura sequence
    //    List<int> gaps = new List<int> { 701, 301, 132, 57, 23, 10, 4, 1 };

    //    // Sorting using Ciura sequence
    //    foreach (int gap in gaps)
    //    {
    //        for (int i = gap; i < n; i++)
    //        {
    //            int temp = arr[i];
    //            int j;
    //            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
    //            {
    //                arr[j] = arr[j - gap];
    //            }
    //            arr[j] = temp;
    //        }
    //    }
    //}



    // 3-SMOOTH NUMBER SEQUENCE 



    //static void ShellSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    // Generating 3-smooth sequence
    //    List<int> gaps = GenerateSmoothSequence(n);

    //    // Sorting using 3-smooth sequence
    //    foreach (int gap in gaps)
    //    {
    //        for (int i = gap; i < n; i++)
    //        {
    //            int temp = arr[i];
    //            int j;
    //            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
    //            {
    //                arr[j] = arr[j - gap];
    //            }
    //            arr[j] = temp;
    //        }
    //    }
    //}

    //static List<int> GenerateSmoothSequence(int size)
    //{
    //    List<int> gaps = new List<int>();
    //    int maxP = (int)Math.Log(size, 2);
    //    int maxQ = (int)Math.Log(size, 3);
    //    for (int p = 0; p <= maxP; p++)
    //    {
    //        for (int q = 0; q <= maxQ; q++)
    //        {
    //            int gap = (int)(Math.Pow(2, p) * Math.Pow(3, q));
    //            if (gap < size && gap > 0)
    //                gaps.Add(gap);
    //        }
    //    }
    //    gaps.Sort();
    //    gaps.Reverse(); // Reverse the sequence to start with the largest gap
    //    return gaps;
    //}


    //static int[] GenerateRandomArray(int size, Random random)
    //{

    //    int[] array = new int[size];
    //    for (int i = 0; i < size; i++)
    //    {
    //        array[i] = random.Next();
    //    }
    //    return array;
    //}


    // OWN-SEQUENCE

    static void ShellSort(int[] arr)
    {
        int n = arr.Length;

        // Generating 3-smooth sequence
        List<int> gaps = GenerateOwnSequence(n);

        // Sorting using 3-smooth sequence
        foreach (int gap in gaps)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }

    static List<int> GenerateOwnSequence(int size)
    {
        List<int> gaps = new List<int>();
        for (int p = size / 10; p > 0; p /= 10)
        {
            gaps.Add(p);
        }
        return gaps;
    }


    static int[] GenerateRandomArray(int size, Random random)
    {

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next();
        }
        return array;
    }
}