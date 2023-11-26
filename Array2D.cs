using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
    internal class Array2D
    {
        public bool error = false; // властивість помилки
        int x_length = 5; // розмірність 1
        int y_length = 5; // розмірність 2
        private int[,] a; // масив
        // властивості для розмірностей
        public int X_length
        {
            get { return x_length; }
            set { x_length = value; }
        }
        public int Y_length
        {
            get { return y_length; }
            set { y_length = value; }
        }
        // індексатор
        public int this[int i, int j]
        {
            get
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length)
                {
                    return a[i, j];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length && value >= -10 && value <= 10)
                {
                    a[i, j] = value;
                }
                else
                {
                    error = true;
                }
            }
        }

        void generate(int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = rand.Next(-10, 10);
        }
        // конструктори
        public Array2D(int a_length, int b_length)
        {
            X_length = a_length;
            Y_length = b_length;

            a = new int[X_length, Y_length];

            generate(a_length, b_length);
        }

        public Array2D()
        {
            a = new int[x_length, y_length];

            generate(x_length, y_length);
        }
        // обчислення суми та добутку
        public int DobutokElementiv
        {
            get
            {
                int dobutok = 1;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (j < i)
                        {
                            dobutok *= a[i, j];
                        }
                    }
                }

                return dobutok;
            }
        }
    }
}
