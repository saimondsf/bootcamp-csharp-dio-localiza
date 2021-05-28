using System;

namespace BootcampLocaliza
{
	class Program
	{
		static void Main(string[] args)
		{
      var n = Console.ReadLine();
            
      char[] arr = n.ToCharArray();
      Array.Reverse(arr);

      Console.WriteLine(arr);
    }
  }
}