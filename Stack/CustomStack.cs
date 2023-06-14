using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack
    {
        const int capacity = 4;
       
        public int[] numbers { get; set; }
        public int Count { get; set; }
        public CustomStack()
        {
            numbers = new int[capacity];
            Count = 0;
        }
        public void Push(int number)
        {
            if (numbers.Length == Count)
            {
                Resize();
            }
            numbers[Count] = number;
            Count++;
        }
        public int Pop()
        {
            if (numbers.Length == Count)
            {
                Resize();
            }
            int number = numbers[Count-1];
            numbers[Count] = 0;
            Count--;
            return number;
        }
        public int Peek()
        {
            int number = numbers[Count];
            return number;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(numbers[i]);
            }
        }
      
        private void Resize()
        {
            int newSize = numbers.Length * 2;
            int[] newArray = new int[newSize];
            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i];
            }
            numbers = newArray;
        }
    }
}
