using System.ComponentModel;

namespace CSDS
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> adalar = new List<string>();
			Console.WriteLine(adalar.Count);
			adalar.Add("Sakız");
		}


	}
	class MyList<T>
	{
		T[] array;

		public MyList()
		{
			array = new T[1];
		}

		public void Add(T item)
		{

		}

		public int Count
		{
			get { return array.Length; }
		}
	}
}