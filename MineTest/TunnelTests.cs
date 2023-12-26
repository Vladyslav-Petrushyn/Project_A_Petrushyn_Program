using Project_A_Petrushyn_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A_Petrushyn_Program
{
	[TestClass]
	public class TunnelTests
	{
		[TestMethod]
		public void TunnelInitialization_ShouldSetLengthAndState()
		{
			Tunnel tunnel = new Tunnel();

			Assert.AreEqual(10, tunnel.Length); 
			Assert.AreEqual("NewState", tunnel.State); 
		}
	}
}
