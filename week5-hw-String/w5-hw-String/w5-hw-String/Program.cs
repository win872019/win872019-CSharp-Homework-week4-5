namespace w5_hw_String
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //字串題目


            //1.
            //Console.Write("輸入姓名： ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi ~ {name}");
            //Console.ReadKey();



            //2.
            //string sentence = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //Console.Write("輸入任何一個字 (判斷是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡)： ");
            //string word = Console.ReadLine();

            //if(sentence.Contains(word))
            //{
            //    Console.WriteLine($"'{word}' 有出現在此字串中");
            //}else
            //{
            //    Console.WriteLine($"'{word}' 沒有出現在此字串中");
            //}
            //Console.ReadKey();



            //3.  *
            //Console.Write("輸入一字串：");
            //string str1 = Console.ReadLine();
            //string str2="";

            //for (int i = 1; i <= 2*(str1.Length)-3; i+=2)
            //{
            //    if (i == 1)
            //    {
            //        str2 = str1.Insert(i, "-");
            //    }
            //    else
            //    {
            //        str2=str2.Insert(i, "-");
            //    }                
            //}
            //Console.WriteLine(str2);
            //Console.ReadKey();

            //好懂版
            //Console.Write("輸入一字串：");
            //string str1 = Console.ReadLine();
            //Char[] str2 = str1.ToCharArray();
            //Char[]result  = new Char[str2.Length+ str2.Length-1];
            //int j = 0;
            //for(int i=0;i< result.Length; i ++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        result[i] = '-';
            //    }
            //    else
            //    {
            //        result[i] = str2[j];
            //        j++;
            //    }
            //}
            //string ans = new String(result);
            //Console.WriteLine(ans);

            //4. 
            //Console.Write("輸入一個檔名，輸出副檔名 (例：輸入apple.jpg，輸出jpg)：");
            //string str1 = Console.ReadLine();
            //string [] str2 = str1.Split('.');
            //Console.WriteLine($"副檔名： {str2[1]}");
            //Console.ReadKey();



            //5.
            //Console.Write("輸入一個大於五個字的單字： ");
            //string a=Console.ReadLine();

            //if (a.Length < 5)
            //{
            //    Console.WriteLine("長度不夠");
            //}else if (a.Length > 5)
            //{
            //    Console.WriteLine(a.Substring(0, 3));
            //}else
            //{
            //    Console.WriteLine("長度等於 5");
            //}

            //Console.ReadKey();



            //6.
            //Console.WriteLine("輸入一段字，把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。");
            //Console.Write("輸入一段字： ");
            //string a = Console.ReadLine();
            //Console.WriteLine(a.Replace("我", "小明"));
            //Console.ReadKey();



            //7.
            //Console.Write("輸入一段字，顯示輸入幾個字： ");
            //string a = Console.ReadLine();
            //Console.WriteLine($"輸入 {a.Length} 個字");
            //Console.ReadKey();







            //字串補充練習題


            //1. 
            //string[] arr = new string[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"輸入第{i + 1}組字串： ");
            //    arr[i] = Console.ReadLine();


            //    if (i > 0 && Array.IndexOf(arr, arr[i], 0, i) >= 0)  // Method: IndexOf(Array, Object, startIndex, count)
            //    {
            //        Console.WriteLine("輸入過");
            //    }
            //    else
            //    {
            //        Console.WriteLine("沒出現過");
            //    }
            //}
            //Console.ReadKey();












            //2.  **  有bug: 重複的字會一起變更

            //Console.Write("輸入一英文字串： ");
            //string a = Console.ReadLine();
            //string b;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    b = a.Replace(a[i], Char.ToUpper(a[i]));
            //    //Console.WriteLine($"a={a}");
            //    //Console.WriteLine($"i={i}");
            //    //Console.WriteLine($"a[i]={a[i]}");
            //    //Console.WriteLine($"a[i+1]={a[i + 1]}");
            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();


            // 2. Observation
            //Console.Write("輸入一英文字串： ");
            //string a = Console.ReadLine();
            //Char[] b = a.ToCharArray();

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"a={a}");
            //    Console.WriteLine($"i={i}");
            //    Console.WriteLine($"a[i]={a[i]}");
            //    Console.WriteLine($"{{Char.ToUpper(a[i])={Char.ToUpper(a[i])}");
            //    Console.WriteLine($"a={a}");
            //    Console.WriteLine($"b[i]={b[i]}");

            //    Console.WriteLine($"Char.ToUpper(b[i])={Char.ToUpper(b[i])}");
            //    Console.WriteLine($"b[i+1]={b[i + 1]}");
            //    Console.WriteLine($"b[i+2]={b[i + 2]}");

            //    Console.WriteLine("---------------------------------------");
            //    //Console.WriteLine(b);
            //}

            //Console.ReadKey();



            //2. Remove & Insert - Observation
            //Console.Write("輸入一英文字串： ");
            //string a = Console.ReadLine();
            //string b;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    b = a.Remove(i,1);
            //    b = b.Insert(i, Convert.ToString(Char.ToUpper(a[i])));
            //    Console.WriteLine($"a={a}");
            //    Console.WriteLine($"i={i}");
            //    Console.WriteLine($"a[i]={a[i]}");
            //    //Console.WriteLine($"a[i+1]={a[i + 1]}");
            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();



            //2. Remove & Insert 方法 
            //Console.Write("輸入一英文字串： ");
            //string a = Console.ReadLine();
            //string b;
            //a = a.ToLower();

            //for (int i = 0; i < a.Length; i++)
            //{
            //    // index 0 開始， 每個字母， Remove 後 Insert大寫
            //    b = a.Remove(i, 1).Insert(i, Convert.ToString(Char.ToUpper(a[i])));              

            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();



            //2. ToCharArray & new string  - 別人的寫法
            //Console.Write("輸入一英文字串： ");
            //string a = Console.ReadLine();

            //for (int i = 0; i < a.Length; i++)
            //{

            //    char[] b = a.ToLower().ToCharArray();
            //    b[i] = Char.ToUpper(b[i]);
            //    a=new string(b);
            //    Console.WriteLine(b);
            //}
            //Console.ReadKey();










            //3.
            //Console.Write("輸入時間，格式範例: 11:30   ：");
            //string a=Console.ReadLine();
            //a =a.Replace(":", "點");
            //a = a.Insert(a.Length, "分");
            //Console.WriteLine(a);




            //4.
            //Console.Write("輸入幾個字串，以英文逗號隔開： ");
            //string str=Console.ReadLine();
            //string[] list= str.Split(",");

            //for(int i=0;i<list.Length;i++)
            //{
            //    list[i] = list[i].Insert(0, "<li>");
            //    list[i] = list[i].Insert(list[i].Length, "</li>");
            //}
            //Console.WriteLine("<ul>");
            //for(int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine($"\t{list[i]}");
            //}
            //Console.WriteLine("</ul>");






            //5.
            //Console.Write("輸入5個數字，用空白隔開，輸出總和： ");
            //string a = Console.ReadLine();
            //string[] list = a.Split(" ");
            //double sum = 0;
            //foreach (string s in list)
            //{
            //    sum += Convert.ToDouble(s);
            //}

            //Console.WriteLine($"輸入數字之總和為 {sum}");
            //Console.ReadKey();



            //6.倒著印字串 *
            //Console.Write("輸入一字串： ");

            //string a = Console.ReadLine();
            //string b = "";

            //// 從string 最後一個 index 開始
            //for (int i = (a.Length) - 1; i >= 0; i--)
            //{
            //    b += Convert.ToString(a[i]);
            //}
            //Console.WriteLine(b);
            //Console.ReadKey();



            // 別人的寫法
            //Console.WriteLine("輸入一串文字，倒著輸出");
            //string input = Console.ReadLine();

            //char[] output = input.ToCharArray();
            //Array.Reverse(output);

            //Console.WriteLine(output);               // 會印出一串字
            //Console.WriteLine(output.GetType());     // 因為沒經過 new string，仍是 char[] 型別
            //Console.ReadKey();












        }
    }
}