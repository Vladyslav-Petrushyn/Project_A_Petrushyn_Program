using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_A_Petrushyn_Program;
namespace Project_A_Petrushyn_Program
{

	[TestClass]
	public class MineTests
	{
		[TestMethod]
		public void MineResources_ShouldReturnResourcesArray()
		{
			Mine mine = new Mine();

			Resources[] result = mine.MineResources();

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void DigTunnel_ShouldChangeTunnelState()
		{
			Mine mine = new Mine();
			Tunnel tunnel = new Tunnel();

			mine.DigTunnel(10);

			Assert.AreEqual("NewState", tunnel.State);
		}
	}
}