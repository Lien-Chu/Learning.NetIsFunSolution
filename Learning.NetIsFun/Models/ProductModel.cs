using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Learning.NetIsFun.Models
{
	public class ProductModel
	{
		public int Id { get; set; }
		public string Name { get; set; }	
		public string Description { get; set; }

		[DataType(DataType.Currency)]
		public decimal Price { get; set; }

		public string Category { get; set; }

		public string ImageUrl { get; set; }
	}
}
