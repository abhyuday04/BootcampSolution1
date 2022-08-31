using System.Diagnostics;
using System.Text;

namespace BootcampClassLibrary1
{
    public class SimpleDataClass
    {
        string S1 { get; set; }
        string S2 { get; set; } 
        string S3 { get; set; }

    }
    public class MyAmazingClass
    {
       // public static string[] SomeString = { "Hello", "How", "Are", "You", "?" };

        /*public static void DoSomethingAmazing(int i)
        {
            string s = "Yellow";
            if(i>=0 && i < SomeString.Length)
            {
                s = SomeString[i];
            }

            DoSomethingElse(s);

            int[] myIntList=Enumerable.Range(50, 5000).ToArray();

            foreach(int myInt in myIntList)
            {
                Debug.Write($"{myInt},");
            }
        }
        private static void DoSomethingElse(String s)
        {
            Debug.WriteLine(s);
        }
            */

        //Video 5
        /*
        public static void DoSomething()
        {

        }

        public DateTime ReturnAValue()
        {
            return DateTime.Now;

        }
        public void AcceptSomeInputs(int i,string s)
        {
            Console.WriteLine(s);
        }
        public void AcceptSomeInputs(int i)
        {
            Console.WriteLine(i);
        }
        public void ProvideDefaults(int i = 0,string s = "Hello")
        {

        }

        public void FunctionWithOutParams(int i,out string s,out DateTime d)
        {
            s = string.Empty;
            d = DateTime.MinValue;
        }
        public (int,string,DateTime) ReturnATuple()
        {
            return (100, "Abhyuday", DateTime.Now);
        }

        public void ClassAsInput(SimpleDataClass sdc)
        {

        }
        public SimpleDataClass ReturnAClass()
        {
            return new SimpleDataClass();

        }
        */

        //Video 6
        /*
        public void SubmitReview(DateTime reviewDate,string reviewer,int rating)
        {
            double myDouble = 1.7d;

            float myFloat = 2.6f;

            decimal myDecimal = 1.5m;

            decimal x = decimal.Add(1.5m, 2.5m);

        }

        public void SubmitReview2(DateTime reviewDate, string reviewer = "Abhyuday", int rating = 0)
        {
            //do something
        }
        
        */
        //Video 7

        /*
        public void DoSomethingAmazingWithString()
        {
            //string? s = "Lisandro Martinez";
            const string STRING1 = "Hello";
            const string STRING2 = "How Are";
            const string STRING3 = "You?";

            string s=STRING1+STRING2+STRING3;

            s = string.Concat(STRING1, STRING2, STRING3);

            s = string.Join(' ',new string[] {STRING1,STRING2,STRING3});

            string[] stringArr=s.Split(' ');

            int i = 100;
            decimal d = 10.55555555m;
            DateTime today=DateTime.Now;

            s = $"The integer is {i}. THE DECIMAL IS {d}. The date is {today}";

            StringBuilder sb = new();

            sb.Append(STRING1);
            sb.Append("This is some really long text that we are going to splice.");
            sb.AppendLine();
            sb.AppendLine($"The integer is {i}. THE DECIMAL IS {d}. The date is {today}");
            sb.AppendLine(STRING3);

            s=sb.ToString();
       */

        //Video 8

        public void DoSomethingAmazingWithLists()
        {
            int[] myArr = { 1, 6, 10, 2, 45, 26, 67 };

            List<int> myIntList = new();

            myIntList.Add(10);
            myIntList.Add(20);
            myIntList.Add(30);

            myIntList=new List<int>(myArr);

            myIntList.Sort();
            myIntList.Remove(2);

            int[] myOtherArr=myIntList.ToArray();

            bool b=myIntList.Contains(2);

            int? i = myIntList.Find(x => x==67);

            i = myIntList.Find(x => x == 99);

            Dictionary<int, string> myDict = new();

            myDict.Add(10, "Ten");
            myDict.Add(11, "Eleven");
            myDict.Add(12, "Twelve");

            myDict.Clear();

            myDict = new Dictionary<int, string> { { 10, "Das" }, { 11, "Gyara" }, { 12,"Twelve"} };

            string s = myDict[11];

            b = myDict.ContainsKey(11);
            b = myDict.ContainsValue("Hello");

            foreach(KeyValuePair<int,string> kvp in myDict)
            {
                Debug.WriteLine($"Key={kvp.Key}. Value={kvp.Value}");
            }

        }
        
    }
}