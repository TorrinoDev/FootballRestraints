using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
	public class FootballPlayer
	{
		private int id;
		private string name;
		private double price;
		private int shirtNumber;
		public int Id 
		{
			get { return id; }
			set { id = value; }
		}
		
		public string Name
		{
			get { return name;}
			set{
				if (value.Length >= 4)
				{
					name = value;
				} else throw new Exception("The name has to be at least 4 characters long");
			}
		}
		public double Price
		{
			get { return price;}
			set {
				if (value > 0)
				{
					price = value;
				} else throw new Exception("The price has to be more than zero");
			}
		}
		public int ShirtNumber
		{
			get { return shirtNumber;}
			set
			{
				if (value >= 1 && value <= 100)
				{
					shirtNumber = value;
				}
				else throw new Exception("The shirt number has to be between 1 and 100");
			}
		}

		public FootballPlayer(int id, string name, double price, int shirtNumber)
		{
			try
			{
				Id = id;
				Name = name;
				Price = price;
				ShirtNumber = shirtNumber;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			
		}
	}
}
