using System.Globalization;

namespace Week4_hw_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //p.176-177
            //double[] A=new double[10];
            //int i;

            //for ( i = 0; i < 10; i++)
            //{
            //    Console.Write($"輸入tmp{i + 1}: ");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //double x = 0;

            //for (i = 0; i < 10; i++)
            //{
            //    x += A[i];
            //}

            //x /= 10;

            //Console.WriteLine(x);
            //Console.ReadKey();



            //p.178-179
            //int[] A = new int[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字： ");
            //    A[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //int Max = Int32.MinValue;
            //foreach (int num in A)
            //{
            //    if (num > Max)
            //    {
            //        Max = num;
            //    }
            //}
            //Console.WriteLine($"最大值為{Max}");
            //Console.ReadKey();





            //p.180-181 
            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字： ");

            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("輸入x，判斷x是否存在於A陣列中");
            //int tmp = Convert.ToInt32(Console.ReadLine());
            //string position = "";
            //for (int j = 0; j < a.Length; j++)
            //{
            //    if (a[j] == tmp)
            //    {
            //        position += "[" + j + "] ";

            //    }

            //}
            //Console.WriteLine($"數字{tmp}位於陣列的index有{position}");
            //Console.ReadKey();



            //p.180-181- Array.IndexOf()
            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字： ");

            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("輸入x，判斷x是否存在於A陣列中");
            //int tmp = Convert.ToInt32(Console.ReadLine());

            //if (Array.IndexOf(a, tmp) != -1)
            //{
            //    Console.WriteLine($"數字{tmp}位於陣列的index為{Array.IndexOf(a, tmp)}");
            //}
            //else
            //{
            //    Console.WriteLine($"數字{tmp}不存在於此陣列");
            //}


            //Console.ReadKey();





            //p.183-185 二維陣列 - 相加
            //int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            //int[,] b = new int[,] { { 7, 8, 9 }, { 10, 11, 12 } };
            //int[,] c = new int[2, 3];
            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < c.GetLength(1); j++)
            //    {
            //        c[i, j] = a[i, j] + b[i, j];
            //        

            //    }
            //}

            //Console.WriteLine($"c[,]{{ {{ {c[0, 0]},{c[0, 1]},{c[0, 2]} }}, {{ {c[1, 0]},{c[1, 1]},{c[1, 2]} }} }}");
            //Console.Readkey();





            //p.186-187  矩陣相乘 - 陣列B & 陣列C一維寫法
            //  ** 二維寫法：若 陣列b、陣列，二維裡其中一維只有1個元素，
            //  寫法似乎還是不需多一個迴圈，because 只須加上該維度之index，
            // 而該維度index全部都一樣是0

            //int[,] a = new int[2, 3];
            //int[] b = new int[3];
            //int[] c = new int[2];

            //// 讀入A[,]
            //for (int i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++)
            //    {
            //        Console.Write($"輸入 A陣列 index[{i}, {j}]的值： ");
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// 讀入B[]
            //for (int k = 0; k <= b.GetUpperBound(0); k++)
            //{
            //    Console.Write($"輸入 B陣列 index[{k}]的值： ");
            //    b[k] = Convert.ToInt32(Console.ReadLine());
            //}

            //// 運算 & 賦值 C[]
            //for (int i = 0; i <= c.GetUpperBound(0); i++)
            //{
            //    c[i] = a[i, 0] * b[0] + a[i, 1] * b[1] + a[i, 2] * b[2];
            //}

            //Console.WriteLine($"C[{c[0]}, {c[1]}]");
            //Console.ReadKey();




            // for TEST - Method of Array
            //Console.WriteLine($"第一維長度{a.GetLength(0)}");
            //Console.WriteLine($"第二維長度{a.GetLength(1)}");
            //Console.WriteLine($"第一維長度--{a.GetUpperBound(0)}");
            //Console.WriteLine($"第二維長度{a.GetUpperBound(1)}");





            //p.188-190 (5-1)
            //int[] a = new int[10];
            //for(int i = 0; i < a.Length; i++) 
            //{
            //    Console.Write($"輸入第{i+1}個數字： ");
            //    a[i]=Convert.ToInt32(Console.ReadLine());
            //}

            //for(int j=0; j < a.Length; j++)
            //{
            //    if (a[j]>5)
            //    {
            //        a[j] -= 5;
            //    }else
            //    {
            //        a[j] += 5;
            //    }
            //}

            //for (int k = 0; k < a.Length; k++)
            //{
            //    Console.WriteLine($"a[{k}]={a[k]}");
            //}
            //Console.ReadKey();



            //p.188,191-193 (5-2)
            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"輸入第{i+1}個數字： ");
            //    a[i] = (Convert.ToInt32(Console.ReadLine())) + i;
            //}
            //for (int k = 0; k < a.Length; k++)
            //{
            //    Console.WriteLine($"a[{k}]={a[k]}");
            //}
            //Console.ReadKey();




            //p.188,194-195 (5-3)
            //int[] a = new int[10];
            //int[] b = new int[10];
            //int i;

            //for (i = 0; i <= a.GetUpperBound(0); i++)           //運算 & 賦值
            //{
            //    Console.Write($"輸入a[{i}]的值： ");
            //    a[i] = Convert.ToInt32(Console.ReadLine());

            //    if (a[i] == 0)
            //    {
            //        b[i] = 1;
            //    }
            //    else
            //    {
            //        b[i] = 0;
            //    }
            //}

            //Console.WriteLine("");

            //Console.Write("A{ ");                    //印出 A陣列
            //for (i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    if (i < a.GetUpperBound(0))
            //    {
            //        Console.Write($"{a[i]}, ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a[i]} }}\n");

            //    }

            //}

            //Console.Write("B{ ");                    //印出 B陣列
            //for (i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    if (i < b.GetUpperBound(0))
            //    {
            //        Console.Write($"{b[i]}, ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b[i]} }}");
            //    }

            //}
            //Console.ReadKey();




            //p.188,196-197 (5-4) ***important(搭配ppt表格說明)
            //int[,] a = new int[3 + 1, 5 + 1];            // +1 ：存放各行、列sum的值
            //int i, j;

            //for (i = 0; i < a.GetUpperBound(0); i++)
            //{
            //    for (j = 0; j < a.GetUpperBound(1); j++)
            //    {

            //        Console.Write($"輸入陣列A[{i},{j}]的值： ");


            //        //// 無各別賦值，直接加總的寫法
            //        //a[i, a.GetUpperBound(1)] = Convert.ToInt32(Console.ReadLine());  //處理sum of row
            //        //a[a.GetUpperBound(0), j] += a[i, j];                             //處理sum of column


            //        // 賦值至各index &加總 的寫法
            //        a[i, j] = Convert.ToInt32(Console.ReadLine());
            //        a[i, a.GetUpperBound(1)] += a[i, j];
            //        a[a.GetUpperBound(0), j] += a[i, j];

            //    }
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("-----印出各index值&各行列加總-----");
            //Console.WriteLine("(最後一行 & 最後一列為各行、列加總)\n");

            //for (i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (j = 0; j <= a.GetUpperBound(1); j++)
            //    {
            //        if (j < a.GetUpperBound(1) && i < a.GetUpperBound(0))
            //        {
            //            Console.Write($"{a[i, j]}\t");
            //        }
            //        else if (j == a.GetUpperBound(1) && i < a.GetUpperBound(0))
            //        {
            //            Console.WriteLine($"{a[i, j]}");
            //        }
            //        else
            //        {
            //            if (j < a.GetUpperBound(1))
            //            {
            //                Console.Write($"{a[i, j]}\t");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{a[i, j]}");
            //            }

            //        }
            //    }

            //}
            //Console.ReadKey();




            //p.188,199-200 (5-5) ***important
            //int[,] a = new int[3 + 1, 5 + 1];            // +1 ：存放各行、列最小值
            //int i, j;

            //for (i = 0; i <= a.GetUpperBound(0); i++)  //每列最後賦值最小值
            //{
            //    a[i, a.GetUpperBound(1)] = int.MaxValue;
            //}

            //for (j = 0; j <= a.GetUpperBound(1); j++)   //每行最後賦值最小值
            //{
            //    a[ a.GetUpperBound(0),j] = int.MaxValue;
            //}

            ////賦值
            //for (i = 0; i < a.GetUpperBound(0); i++)
            //{
            //    for (j = 0; j < a.GetUpperBound(1); j++)
            //    {

            //        Console.Write($"輸入陣列A[{i},{j}]的值： ");

            //        a[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}

            //a[3, 5] = 0; //

            //for (i = 0; i < a.GetUpperBound(0); i++)            //每列最小值
            //{
            //    for (j = 0; j < a.GetUpperBound(1); j++)
            //    {
            //        if(a[i, j] < a[i, a.GetUpperBound(1)])
            //        {
            //            a[i, a.GetUpperBound(1)] = a[i, j];
            //        }

            //    }
            //}

            //for (j = 0; j < a.GetUpperBound(1); j++)            //每行最小值
            //{
            //    for (i = 0; i < a.GetUpperBound(0 ); i++)
            //    {
            //        if (a[i, j] < a[ a.GetUpperBound(0),j])
            //        {
            //            a[a.GetUpperBound(0), j] = a[i, j];
            //        }

            //    }
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("-----印出各index值&各行列最小值-----");
            //Console.WriteLine("(最後一行 & 最後一列為各行、列最小值)\n");


            //for (i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (j = 0; j <= a.GetUpperBound(1); j++)
            //    {
            //        if (j < a.GetUpperBound(1) && i < a.GetUpperBound(0))
            //        {
            //            Console.Write($"{a[i, j]}\t");
            //        }
            //        else if (j == a.GetUpperBound(1) && i < a.GetUpperBound(0))
            //        {
            //            Console.WriteLine($"{a[i, j]}");
            //        }
            //        else
            //        {
            //            if (j < a.GetUpperBound(1))
            //            {
            //                Console.Write($"{a[i, j]}\t");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{a[i, j]}");
            //            }

            //        }
            //    }

            //}

            //Console.ReadKey();




            //p.198,201-202 (5-6)
            //int[]a=new int [5];
            //int[] b = new int[5];
            //int[]x = new int[5];
            //int i;
            //for(i=0; i<5;i++)
            //{
            //    Console.Write($"輸入a{i+1}： ");
            //    a[i]= Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"輸入b{i+1}： ");
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //    x[i] = a[i] + b[i];
            //}
            //Console.WriteLine("");
            //Console.WriteLine("求ai+bi，i=1到i=5：\n");
            //for(i = 0; i < 5; i++)
            //{
            //    Console.Write($"{x[i]}\t");
            //}
            //Console.ReadKey();





            //p.198,203-204 (5-7)
            //int x = int.MinValue;
            //int[] a = new int[10];

            //int i;
            //for (i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    Console.Write($"輸入a陣列第{i + 1}個值： ");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //    if (a[i] > x)
            //    {
            //        x = a[i];
            //    }
            //}

            //int y = int.MinValue;
            //int[] b = new int[10];
            //for (i = 0; i <= b.GetUpperBound(0); i++)
            //{
            //    Console.Write($"輸入b陣列第{i + 1}個值： ");
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //    if (b[i] > y)
            //    {
            //        y = b[i];
            //    }
            //}

            //Console.WriteLine($"a陣列最大值為{x}");
            //Console.WriteLine($"b陣列最大值為{y}");

            //if (x < y)
            //{
            //    Console.WriteLine($"x<y，{x}<{y}");
            //}
            //else if (y < x)
            //{
            //    Console.WriteLine($"y<x，{y}<{x}");
            //}
            //else
            //{
            //    Console.WriteLine($"x=y，{x}={y}");
            //}

            //Console.ReadKey();






        }
    }
}