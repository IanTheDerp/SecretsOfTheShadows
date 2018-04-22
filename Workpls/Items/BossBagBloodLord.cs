using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class BossBagBloodLord : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Right click to open");
		}
		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 32;
			item.value = 0;
			item.rare = 8;
			item.expert = true;
			item.maxStack = 99;
			item.consumable = true;
			bossBagNPC = mod.NPCType("LordOfBlood");
		}
		public override bool CanRightClick()
		{
			return true;
		}
		public override void OpenBossBag(Player player)
		{

			player.QuickSpawnItem(mod.ItemType("BloodiedMantle"), 1);
			player.QuickSpawnItem(ItemID.LifeCrystal,Main.rand.Next(0, 4));
			int reward = Main.rand.Next(4);
			
			if(reward == 0)
			{
			player.QuickSpawnItem(ItemID.DemonWings, 1);
			}
			if(reward == 1)
			{
			player.QuickSpawnItem(mod.ItemType("VampireStaff"), 1);
			}
			if(reward == 2)
			{
			player.QuickSpawnItem(mod.ItemType("Scaffolder"), 1);
			}
			if(reward == 3)
			{
			player.QuickSpawnItem(mod.ItemType("Sulfur"), 1);
			}
			
			
				
		}
	}
}