using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T> where T: IComparable<T>, new()
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
            if (Capacity <= Length)
            {
                Array.Resize(ref array, Capacity * 2);
            }

            array[Length] = item;
            Length++;
        }

        public void AddRange(T[] inputArray)
        {
            if (inputArray.Length > Capacity-Length)
            {
                int range = array.Length;
                do
                {
                    range *= 2;
                } while (inputArray.Length > range - Length);

                Array.Resize(ref array, range);
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Add(inputArray[i]);
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].CompareTo(item)==0)
                {
                    for (int j = i; j < Length-1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[Length-1] = default(T);
                    Length--;
                    break;
                }
            }
            return true;
        }

        public bool Insert(T item, int id)
        {
            if (id <= Length)
            {
                if (Capacity <= Length)
                {
                    Array.Resize(ref array, Capacity * 2);
                }
                for (int i = Length; i > id; i--)
                {
                    array[i] = array[i - 1];
                }
                array[id] = item;
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
                if (index >= Capacity)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else return array[index];
            }
            set
            {
                if (index >= Capacity)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else array[index] = value;
            }
        }
    }
}