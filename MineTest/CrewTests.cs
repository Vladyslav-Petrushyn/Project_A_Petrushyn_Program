using Project_A_Petrushyn_Program;
namespace Project_A_Petrushyn_Program
{

	[TestClass]
	public class CrewTests
	{
		[TestMethod]
		public void SendToTunnel_ShouldChangeMinerState()
		{
			Crew crew = new Crew();
			Miner miner = new Miner();
			Tunnel tunnel = new Tunnel();

			crew.SendToTunnel(miner, tunnel);

			Assert.AreEqual("NewState", miner.State);
		}
	}
}
