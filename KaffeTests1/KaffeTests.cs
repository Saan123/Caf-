using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe.Tests
{
	[TestClass()]
	public class KaffeTests
	{
		private string styrke;
		private int Pris;

		[TestMethod()]
		public void PrisTestKaffe()
		{
			//Arrange
			var kaffe = new Kaffe();

			//Act
			int pris = kaffe.pris();
		
			//Assert
			Assert.AreEqual(20, pris);
		}

		[TestMethod()]
		public void StyrkeTestKaffe()
		{
			//Arrange
			var kaffe = new Kaffe();

			//Act
			string styrke = kaffe.styrke();

			//Assert
			Assert.AreEqual("Stærk", styrke);
		}
	}
}