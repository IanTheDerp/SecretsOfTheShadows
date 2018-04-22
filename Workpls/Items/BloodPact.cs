using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;

using Terraria.ModLoader;

namespace Workpls.Items
{
	public class BloodPact : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BloodPact");
			Tooltip.SetDefault("Crazy Healing");
		}
		public override void SetDefaults()
		{
      
            item.width = 32;     
            item.height = 32;   
            item.value = 100000;
            item.rare = 10;
			item.expert = true;
			item.accessory = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TheHardCore", 1);
			recipe.AddIngredient(null, "ZHornPlenty", 1);
			recipe.AddIngredient(ItemID.Leather,150);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			
			int choise = Main.rand.Next(6);
			if(choise == 0)
			{
				player.statLife += 1;
				
			}
			

		}
		
	}
}
