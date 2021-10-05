using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib;

namespace TestProject
{
	[TestClass]
	public class UnitTest1
	{
		private FootballPlayer fp;

		[TestInitialize]
		public void BeforeTest()
		{
			fp = new FootballPlayer(5, "Rudolf", 500, 44);
		}

		[TestMethod]
		public void TestId()
		{		 
			Assert.AreEqual(5, fp.Id);
		}

		[TestMethod]
		public void TestName()
		{
			Assert.AreEqual("Rudolf", fp.Name);
			fp.Name = "Lauf";
			Assert.AreEqual("Lauf", fp.Name);
			try
			{
				fp.Name = "Dre";
				Assert.Fail();
			}
			catch (Exception e)
			{
				Assert.AreEqual("The name has to be at least 4 characters long", e.Message);
			}
		}

		[TestMethod]
		public void TestPrice()
		{
			Assert.AreEqual(500, fp.Price, 0.000001);
			fp.Price = 1;
			Assert.AreEqual(1, fp.Price, 0.000001);
		}

		[TestMethod]
		public void TestShirtNumber()
		{
			Assert.AreEqual(44, fp.ShirtNumber);
			fp.ShirtNumber = 1;
			Assert.AreEqual(1, fp.ShirtNumber);
			fp.ShirtNumber = 100;
			Assert.AreEqual(100, fp.ShirtNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void TestNullNameException()
		{
			fp.Name = null;
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void TestPriceException()
		{
			fp.Price = 0;
		}
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void TestNegativePriceException()
		{
			fp.Price = -1;
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void TestShirtNumberException()
		{
			fp.ShirtNumber = 0;
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void TestShirtNumberException2()
		{
			fp.ShirtNumber = 101;
		}
	}
}
