using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonEight
    {
        public static void Lesson8()
        {
            MinHeap minHeap = new MinHeap();

            minHeap.Insert(10);
            minHeap.Insert(20);
            minHeap.Insert(5);
            minHeap.Insert(15);

            Console.WriteLine("Heap after insertions:");
            minHeap.DisplayHeap();

            Console.WriteLine("Extracted Min: " + minHeap.ExtractMin());
            Console.WriteLine("Heap after extracting min:");
            minHeap.DisplayHeap();
        }
    }
    public class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Insert(int value)
        {
            heap.Add(value);
            int index = heap.Count - 1;

            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index] >= heap[parentIndex]) break;

                int temp = heap[index];
                heap[index] = heap[parentIndex];
                heap[parentIndex] = temp;
                index = parentIndex;
            }
        }

        public int ExtractMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty.");

            int minValue = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            int index = 0;
            while (true)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int smallest = index;

                if (leftChild < heap.Count && heap[leftChild] < heap[smallest])
                    smallest = leftChild;

                if (rightChild < heap.Count && heap[rightChild] < heap[smallest])
                    smallest = rightChild;

                if (smallest == index) break;

                int temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                index = smallest;
            }

            return minValue;
        }
        public void DisplayHeap()
        {
            Console.WriteLine(string.Join(", ", heap));
        }
    }
}
