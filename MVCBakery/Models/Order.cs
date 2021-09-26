using System.Collections.Generic;

namespace MVCBakery.Models {
	public class Order {
		public string Title {get;set;}
		public string Description {get;set;}
		public int Price {get;set;}
		public string Date {get;set;}
		public string Type {get;set;}
		public int Id {get;}
		private static List < Order > _instances = new List < Order > {};

		public Order(string title, string description, int price, string date, string type) {
			Title = title;
			Description = description;
			Price = price;
			Date = date;
			Type = type;
			Id = _instances.Count;
			_instances.Add(this);
		}

		public static List < Order > GetAll() {
			return _instances;
		}

		public static Order Find(int searchId) {
			return _instances[searchId - 1];
		}

		public static void ClearAll() {
			_instances.Clear();
		}
	}
}