using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//宣告一個 List<Product> 變數, 存放多筆購買商品
			List<Product> products = new List<Product>
			{ new Product {Clothes = 1 ,Pants = 2, Hat = 2},
			  new Product {Clothes = 4 ,Pants = 1, Shoes = 1},
			  new Product {Clothes = 2 ,Pants = 1, Hat = 1, Shoes =1},
			};
		}
	}
	class Product 
	{
		public int Clothes { get; set; }
		public int Shoes { get; set; }
		public int Hat { get; set; }
		public int Pants { get; set; }

	}
}
