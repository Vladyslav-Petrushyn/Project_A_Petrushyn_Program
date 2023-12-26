using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A_Petrushyn_Program
{
	[TestClass]
	public class ResourcesTests
	{
		[TestMethod]
		public void MineResource_ShouldChangeResourceState()
		{
			Resources resource = new Resources();

			resource.MineResource();

			Assert.AreEqual("NewState", resource.State);
		}

		[TestMethod]
		public void GetResourceQuantity_ShouldReturnQuantity()
		{
			Resources resource = new Resources();
			resource.Quantity = 42;

			int result = resource.GetResourceQuantity();

			Assert.AreEqual(42, result);
		}
	}
}