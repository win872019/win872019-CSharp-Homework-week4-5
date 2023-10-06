namespace week5_hw_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. 建立字元陣列 & 賦值給字串變數(成為字串)
            //char[] a = new char [3]{ 'a', 'p', 'p' };
            //string b= new string (a);
            //Console.WriteLine (a.GetType());
            //Console.WriteLine(b.GetType());



            // 2. 賦值的 observation
            //string a = "happy";
            //string b = a;

            //Console.WriteLine($"a1={a}");
            //Console.WriteLine($"b1={b}");

            //a = "happy2";
            //Console.WriteLine($"a2={a}");
            //Console.WriteLine($"b2={b}");


            ////////////////////////////////////////////////

            // C

            //Method -  string.Clone() - 複製字串的參考 (?)
            //string a = "It's a good day.";
            //string b = "It's a sunny day.";
            //string c = (string)a.Clone();
            //Console.WriteLine(a);
            //Console.WriteLine(c);
            //a = "Hello";
            //Console.WriteLine(a);
            //Console.WriteLine(c);
            //Console.WriteLine(a.GetType());
            //Console.WriteLine(c.GetType());



            // Method - string.CompareTo(str) - 比較兩字串值大小(?)
            //- 輸出結果 1(string > str) or 0(string == str) or -1(string < str) (?)
            //string a = "aa";
            //string b = "ab";
            //int st = a.CompareTo(b);
            //Console.WriteLine(st);



            // Method - string.Contains(str) - 檢查是否包含
            //string a = "It's a beautiful sunny day.";
            //string b = "good";
            //string c = "sunny";
            //Console.WriteLine(a.Contains(b));
            //Console.WriteLine(a.Contains(c));
            //Console.WriteLine(a.Contains("ea"));



            // E

            // Method - string.EndsWith(ch) - 結尾字元 或 字串的檢查

            // e.g.1.
            //string[] arr = { "apple", "bee", "candy", "egg" };
            //char e = 'e';
            //foreach(string str in arr)
            //{
            //    if (str.EndsWith(e))
            //    {
            //        Console.WriteLine("{0} EndsWith {1} ? {2}",str,e, str.EndsWith(e));
            //    }else
            //    {
            //        Console.WriteLine("{0} EndsWith {1} ? {2}", str, e, str.EndsWith(e));
            //    }
            //}

            // e.g.2.
            //string a = "Holly Wood";
            //string b = "Wood";
            //char c = 'd';
            //char d = 'y';
            //Console.WriteLine(a.EndsWith(c));
            //Console.WriteLine(a.EndsWith(b));
            //Console.WriteLine(a.EndsWith('d'));
            //Console.WriteLine(a.EndsWith("Wood"));
            //Console.WriteLine(a.EndsWith(d));



            // Method - string.Equals(str) & Equals( str1, str2 )- 比較兩字串值是否相等
            //string a = "apple tree";
            //string b = "apple tree";
            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.Equals("apple"));
            //Console.WriteLine(Equals(a,b));





            // G

            // Method - string.GetTypeCode() - 返回System.String類的Stystem.TypeCode
            //string a = "abc";
            //string b = "123";
            //int c = 223;
            //double d = 960.971;
            //Console.WriteLine(a.GetTypeCode());
            //Console.WriteLine(b.GetTypeCode());
            //Console.WriteLine(c.GetTypeCode());
            //Console.WriteLine(d.GetTypeCode());


            // Method - string.GetHashCode() - 取得字符串的HashValue
            //string a = "abc";
            //char b = 'h';
            //string c = "abc";
            //string d = a;
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(c.GetHashCode());
            //Console.WriteLine(d.GetHashCode());








            // I

            // Method - string.Insert(Int32, String) - 在指定index位置插入字串
            //string a = "A box";
            //Console.WriteLine(a.Insert(2, "blue "));
            //Console.WriteLine($"a.Length = {a.Length}");
            //Console.WriteLine(a.Insert(4, "aaa"));
            //Console.WriteLine(a.Insert(5, "aaa"));

            //Console.WriteLine(a.Insert(5, null));     // Unhandled exception
            //Console.WriteLine(a.Insert(-1, "aaa"));   // Unhandled exception
            //Console.WriteLine(a);



            // Method - string.IsNormalized() - 檢查是否為 Unicode 形式
            //string a = "U+0021";
            //Console.WriteLine(a.IsNormalized());





            // Method - string.IndexOf() - 搜尋第一次出現位置 **
            //string.IndexOf(compareStr, startIndex, searchLength)

            //string a = "abcabcabc";
            //string b = "deffff";
            //Console.WriteLine(b.IndexOf('d'));
            //Console.WriteLine((a.IndexOf(a)).GetType());
            //Console.WriteLine(a.IndexOf('b'));
            //Console.WriteLine((a.IndexOf('b')).GetType());
            //Console.WriteLine(a.IndexOf('c'));
            //Console.WriteLine(a.IndexOf('c', 3, 2));
            //Console.WriteLine(a.IndexOf('c', 3, 3));





            // L

            // Method - string.LastIndexOf() 搜尋最後一次出現位置**
            //string.LastIndexOf(compareStr)
            //string.LastIndexOf(compareStr, startIndex)
            //- ↑由 startIndex 往字串index0 位置回推
            //string.LastIndexOf(compareStr, startIndex, searchLength)

            //string a = "abcabcabc";
            //string b = "deffff";
            //Console.WriteLine(a.LastIndexOf("c"));
            //Console.WriteLine(a.LastIndexOf("c",7,2));
            //Console.WriteLine(a.LastIndexOf("c", 7, 3));



            // R

            //Method - string.Replace("origin","replacement")

            //string a = "It's a cloudy day.";
            //Console.WriteLine(a);
            //string b = a.Replace("cloudy", "sunny");
            //Console.WriteLine(a);
            ////Console.WriteLine(b);
            //string c = a.Replace(' ', '-');
            //Console.WriteLine(c);



            //Method - string.Remove(startIndex) -
            //傳回新字串，其中已刪除目前執行個體中的所有字元 (從指定位置開始到最後一個位置為止)。

            // string.Remove(startIndex, count) -
            // startIndex: 要開始刪除字元之以零為起始的位置。
            // count: 要刪除的字元數。

            //string a = "aaabbbccc";
            //Console.WriteLine(a.Remove(3));
            //Console.WriteLine(a.Remove(3, 3));
            /*Console.WriteLine(a.Remove(-2));*/      // Unhandled exception

            // Comparison
            //Console.WriteLine(a.Remove(8));
            //Console.WriteLine(a.Remove(9));
            /*Console.WriteLine(a.Remove(10)); */         // Unhandled exception





            // S

            // Method - string.Split() - 分割

            // e.g.1.
            //string a = "She has a bike";
            //string[] b = a.Split();
            //Console.WriteLine(b.GetType());
            //Console.WriteLine($"b.Length = {b.Length}");
            //Console.WriteLine($"b[0] = { b[0]}");
            //Console.WriteLine($"b[1] = {b[1]}");
            //Console.WriteLine($"b[2] = {b[2]}");
            //Console.WriteLine($"b[3] = {b[3]}");

            // e.g.2. - from Microsoft DOC **
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //string text = "one\ttwo three:four,five six seven";

            //string[] lines = text.Split(delimiterChars);

            //Console.WriteLine(lines.Length);

            //for(int i=0; i<=lines.GetUpperBound(0);i++)
            //{
            //    Console.WriteLine($"lines[{i}] = {lines[i]}");
            //}




            // Method - string.StartsWith() - 判斷字串執行個體的開頭是否符合指定的字串 or 字元。
            //string a = "aaabbbccc";
            //string b = "aa";
            //Console.WriteLine(a.StartsWith(b));
            //Console.WriteLine(a.StartsWith('a'));




            // Method - string.Substring(startIndex) -
            // 從這個執行個體擷取子字串。 子字串會在指定的字元位置開始並繼續到字串的結尾。

            // - string.Substring(startIndex, length) - 
            // 從這個執行個體擷取子字串。 子字串起始於指定的字元位置，並且具有指定的長度。

            //string a = "aaabbbccc";
            //Console.WriteLine(a.Substring(3));
            //Console.WriteLine(a.Substring(3,3));



            // T

            // Method - string.ToCharArray()
            //string a = "abctttdef";
            //char[] b = a.ToCharArray(0, 3);

            //Console.WriteLine($"length of b array = {b.Length}");            

            //foreach(char c in b)
            //{
            //    Console.WriteLine(c);
            //}

            //char[] c = a.ToCharArray();
            //Console.WriteLine($"length of c array = {c.Length}");

            //foreach (char element in c)
            //{
            //    Console.WriteLine(element);
            //}




            // Method - string.ToLower() - 轉換小寫
            //string a = "HAPPY biRthDAY";
            //Console.WriteLine(a.ToLower());

            //string.ToUpper() - 轉換大寫
            //string a = "happY nEw year";
            //Console.WriteLine(a.ToUpper());
            //a.ToUpper();
            //Console.WriteLine(a);



            ////Method - string.Trim() - 刪除開頭&結尾的空白字元
            //string a = "           It's a beautiful box.          ";
            //Console.WriteLine($"a1=<{ a}>");

            //string b =a.Trim();
            //Console.WriteLine($"a2=<{a}>");
            //Console.WriteLine($"b=<{b}>");

            ////string.TrimStart() - 刪除開頭的空白字元
            //string c =a.TrimStart();
            //Console.WriteLine($"c=<{c}>");

            ////string.TrimEnd() - 刪除結尾的空白字元
            //string d = a.TrimEnd();
            //Console.WriteLine($"d=<{d}>");






            //////////////////////////////////////////////////////////////




            // Property - string.Length - 取得目前 String 物件中字元的數目
            //string a = "abcde";
            //Console.WriteLine(a.Length);
            //Console.WriteLine("hi".Length);
            //Console.WriteLine((234.ToString()).Length);


            //////////////////////////////////////////////////////

            

            //DateTime now = DateTime.Now;
            //int Year=now.Year;
            //int Month=now.Month;
            //int Day=now.Day;


            //時間可以計算
            //TimeSpan

        }
    }
}
