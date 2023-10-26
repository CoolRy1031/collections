// See https://aka.ms/new-console-template for more information
// namespace Demo
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       List<int> ar = new List<int>();
//       ar.Add(10);
//       ar.Add(15);
//       ar.Add(23);
//       Console.WriteLine("the first number of the list is " +ar[0]);
//       Console.WriteLine("the second number of the list is " +ar[1]);
//       Console.WriteLine("the third number of the list is " +ar[2]);
//     }
//   }
// }
// namespace Demo
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       List<string> ar = new List<string>();
//       ar.Add("Hi");
//       ar.Add("There");
//       ar.Add("Baby");
//       ar.Clear();
//       Console.WriteLine("the third number of the list is " +ar.Count);
//     }
//   }
// }

// namespace Demo
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       List<string> ar = new List<string>();
//       ar.Add("Hi");
//       ar.Add("There");
//       ar.Add("Baby");
//       ar.Insert(2, "How are you?");
//       Console.WriteLine("Does the list contain the string hello?" +ar.Contains("Hello"));
//       Console.WriteLine("This is the postion of the string There" +ar.IndexOf("There"));
//       Console.WriteLine("This is the postion of the string " +ar.IndexOf("How are you?"));
//     }
//   }
// }

// namespace Demo
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Stack<int> ar = new Stack<int>();
//       ar.Push(11);
//       ar.Push(22);
//       ar.Push(33);
//       ar.Push(45);

//       var ar1 = ar.ToArray();
//       Console.WriteLine("1st " + ar1[0].ToString());
//       Console.WriteLine("2nd " + ar1[1].ToString());
//       Console.WriteLine("3rd " + ar1[2].ToString());
//       Console.WriteLine("4th " + ar1[3].ToString());
//       Console.WriteLine("The element at the top of the stack is " + ar.Peek());
//       // Console.WriteLine("The number of elements in the stack are " + ar.Count);
//       // Console.WriteLine("The element at the top of the stack is " + ar.Peek());
//     }
//   }
// }

// namespace Demo
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Queue<string> ar = new Queue<string>();
//       ar.Enqueue("apples");
//       ar.Enqueue("bananas");
//       ar.Enqueue("beans");


//       Console.WriteLine("1st  element out is " + ar.Dequeue());
//       Console.WriteLine("2nd  element out is " + ar.Dequeue());
//       Console.WriteLine("3rd element out is " + ar.Dequeue());
//     }
//   }
// }

namespace Demo
{
  class Program
  {
    static void Main(string[] args)
    {
      SortedList<int,string> ar = new SortedList<int, string>();
      ar.Add(111, "apples");
      ar.Add(222,"bananas");
      ar.Add(333,"beans");


      Console.WriteLine("1st  element value is " + ar[111].ToString());
      Console.WriteLine("2nd  element value is " + ar[222].ToString());
      Console.WriteLine("3rd element value is " + ar[333].ToString());
      Console.WriteLine("True of False does this list contain the key 999?" + ar.ContainsKey(999));
      Console.WriteLine("True of False does this list contain the value beans?" + ar.ContainsValue("beans"));
    }
  }
}