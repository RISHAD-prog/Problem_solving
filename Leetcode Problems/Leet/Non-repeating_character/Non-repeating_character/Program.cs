public class Solution
{
    public int FirstUniqChar(string s)
    {
        Queue<char> queue = new Queue<char>();
        Queue<char> tempQueue = new Queue<char>();
        foreach (var item in s)
        {
            if (queue.Contains(item) == true)
            {
                while (queue.Count > 0)
                {
                    char currentItem = queue.Dequeue();
                    if (!currentItem.Equals(item))
                    {
                        tempQueue.Enqueue(currentItem);
                    }
                }
                
                while (tempQueue.Count > 0)
                {
                    queue.Enqueue(tempQueue.Dequeue());
                }
            }
            queue.Enqueue(item);
     
        }
        var check = queue.Peek();
        if (s.Contains(check))
        {
            return s.IndexOf(check);
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        string str = "aabb";
        var ans = s.FirstUniqChar(str);
        Console.WriteLine(ans);
    }
}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Queue<int> myQueue = new Queue<int>();
//        myQueue.Enqueue(1);
//        myQueue.Enqueue(2);
//        myQueue.Enqueue(3);
//        myQueue.Enqueue(4);

//        Console.WriteLine("Original Queue:");
//        PrintQueue(myQueue);

//        int valueToRemove = 3;
//        RemoveValueFromQueue(myQueue, valueToRemove);

//        Console.WriteLine($"\nQueue after removing {valueToRemove}:");
//        PrintQueue(myQueue);
//    }

//    static void RemoveValueFromQueue<T>(Queue<T> queue, T value)
//    {
//        Queue<T> tempQueue = new Queue<T>();

//        while (queue.Count > 0)
//        {
//            T currentItem = queue.Dequeue();
//            if (!currentItem.Equals(value))
//            {
//                tempQueue.Enqueue(currentItem);
//            }
//        }

//        while (tempQueue.Count > 0)
//        {
//            queue.Enqueue(tempQueue.Dequeue());
//        }
//    }

//    static void PrintQueue<T>(Queue<T> queue)
//    {
//        foreach (T item in queue)
//        {
//            Console.Write($"{item} ");
//        }
//        Console.WriteLine();
//    }
//}