using System;

namespace Task1
{
    class DynamicArray<T> where T: new()
    {
        private T[] array;
        public int Length { get; private set; }
        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public DynamicArray():this(8)
        {

        }

        public DynamicArray(int size)
        {
            array = new T[size];
        }

        public DynamicArray(T[] inputArray)
        {
            Array.Copy(inputArray, array, inputArray.Length);
            Length = inputArray.Length;
        }

        public void Add(T item)
        {
            Insert(item, Length);
        }

        public void AddRange(T[] inputArray)
        {
            if (inputArray.Length > Capacity-Length)
            {
                int newSize = array.Length;
                do
                {
                    newSize *= 2;
                } while (inputArray.Length > newSize - Length);

                Array.Resize(ref array, newSize);
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Add(inputArray[i]);
            }
        }

        public bool Remove(T item)
        {

            var itemIndex = Array.IndexOf(array, item);
            if (itemIndex != -1)
            {
                Array.Copy(array, itemIndex + 1, array, itemIndex, Length - itemIndex);
                Length--;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Insert(T item, int index)
        {
            if (index <= Length && index>=0)
            {
                if (Capacity <= Length)
                {
                    Array.Resize(ref array, Capacity * 2);
                }
                Array.Copy(array, index, array, index+1, Length - index);
                array[index] = item;
                Length++;
                return true;
            }
            else
            {

                throw new ArgumentOutOfRangeException();

            }
        }


        public T this[int index]
        {

            get
            {
                if (index >= Length || index<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else return array[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else array[index] = value;
            }
        }
    }
}