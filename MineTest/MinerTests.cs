using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using Project_A_Petrushyn_Program;

namespace Project_A_Petrushyn_Program
{

	[TestClass]
	public class MinerTests
	{
		[TestMethod]
		public void ObtainResource_ShouldChangeResourceQuantity()
		{
			Miner miner = new Miner();
			Resources resource = new Resources();

			miner.ObtainResource(resource);

			Assert.AreEqual(42, resource.GetResourceQuantity()); 
		}
	}
}
