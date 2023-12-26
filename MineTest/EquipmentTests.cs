using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project_A_Petrushyn_Program
{
	[TestClass]
	public class EquipmentTests
	{
		[TestMethod]
		public void MiningEquipmentInitialization_ShouldSetTypeAndState()
		{
			Equipment equipment = new Equipment();

			Assert.AreEqual("ExpectedType", equipment.Type); 
			Assert.AreEqual("ExpectedState", equipment.State); 
		}
	}
}
