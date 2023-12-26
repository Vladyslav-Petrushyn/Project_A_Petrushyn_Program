using System;
using System.Resources;
namespace Project_A_Petrushyn_Program
{
	public class Program
	{
		static void Main()
		{
			Mine mine = new Mine();
			Miner miner = new Miner();
			Crew crew = new Crew();
			Equipment equipment = new Equipment();
			Resources resources = new Resources();
			Tunnel tunnel = new Tunnel();

			Resources[] minedResources = mine.MineResources();
			foreach (var resource in minedResources)
			{
				miner.ObtainResource(resource);
			}

			crew.SendToTunnel(miner, tunnel);
		}
	}
}
