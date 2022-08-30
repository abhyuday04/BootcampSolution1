using System.Diagnostics;

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


    }
}