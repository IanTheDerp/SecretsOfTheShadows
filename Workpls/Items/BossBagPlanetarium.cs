using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class BossBagPlanetarium : ModItem
	{
		
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;

			item.rare = 9;
			item.expert = true;
			bossBagNPC = mod.NPCType("SkyGaurdian");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
}
		public override bool CanRightClick()
		{
			return true;
		}
		public override void OpenBossBag(Player player)
		{

			player.QuickSpawnItem(mod.ItemType("EtherealPickaxe"), 1);
			player.QuickSpawnItem(ItemID.LifeCrystal,Main.rand.Next(0, 4));
			int reward = Main.rand.Next(4);
			
			if(reward == 0)
			{
			player.QuickSpawnItem(ItemID.AngelWings, 1);
			}
			if(reward == 1)
			{
			player.QuickSpawnItem(mod.ItemType("DiamondSpacer"), 1);
			}
			if(reward == 2)
			{
			player.QuickSpawnItem(mod.ItemType("DiamondCrest"), 1);
			}
			if(reward == 3)
			{
			player.QuickSpawnItem(mod.ItemType("DiamondBoots"), 1);
			}
			
			if(reward == 4)
			{
			player.QuickSpawnItem(ItemID.AngelHalo, 1);
			}
			
				
		}
	}
}