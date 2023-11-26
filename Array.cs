using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Array
    {
        public bool error = false; // відкрите поле помилки
        int[] a; // закритий масив
        // закрита довжина масиву
        int length = 5;
        // властивість розмірність
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        // індексатор
        public int this[int i]
        {
            get
            {
                if (0 <= i && i < length)
                {
                    return a[i];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < length && value >= 100 && value <= 200)
                {
                    a[i] = value;
                }
                else
                {
                    error = true;
                }
            }
        }
        // конструктори
        public Array()
        {
            a = new int[length];
        }
        public Array(int[] mas)
        {
            a = mas;
        }
        public Array(int size)
        {
            Length = size;
            a = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = rand.Next(100, 200);
            }
        }
        // властивість для обрахунку сум
        public int SumOfEven
        {
            get
            {
                int sum = 0;
                foreach (int i in a)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
    }
}
