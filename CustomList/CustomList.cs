using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList
    {
        const int arraySize = 4;
        public int[] numbers { get; set; }
        public int Count { get; set; }
        
        public int this[int index]
        {
            get
            {
                CheckValidIndex(index);
                
                return numbers[index];
            }
        }

        public MyList()
        {
            numbers = new int[arraySize];
            Count = 0;
        }
        public void Add(int number)
        {
            if (numbers.Length == Count)
            {
                Resize();
            }
            numbers[Count] = number;
            Count++;
        }
       public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(numbers[i]);
            }
        }
        public bool Contains(int number)
        {

            for (int i = 0; i < Count - 1; i++)
            {
                if (numbers[i] == number)
                {
                    return true;
                }
            }
            return false;
        }
        public void RemoveAt(int index)
        {
            CheckValidIndex(index);
            numbers[index] = 0;
            ShiftLeft(index);
            Count--;
            if (Count <= numbers.Length / 4)
            {
                Shrink();
            }
        }
        public void Swap(int index1, int index2)
        {
            CheckValidIndex(index1);
            CheckValidIndex(index2);
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count-1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
        }
        private bool CheckValidIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
                
            }
            return true;
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
        private void Shrink()
        {
            int newSize = numbers.Length / 2;
            int[] newArray = new int[newSize];
            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i];
            }
            numbers = newArray;

        }

    }
}
