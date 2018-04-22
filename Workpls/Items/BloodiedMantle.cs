using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;

using Terraria.ModLoader;

namespace Workpls.Items
{
	public class BloodiedMantle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodied Mantle");
			Tooltip.SetDefault("Grants random health regeneration\nAlso grants immunity to Blood Tapped and Bleeding");
		}
		public override void SetDefaults()
		{
      
            item.width = 22;     
            item.height = 34;   
            item.value = 75000;
            item.rare = 5;
			item.expert = true;
			item.accessory = true;

		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[mod.BuffType("BloodTapped")] = true;
			
			int choise = Main.rand.Next(25);
			if(choise == 0)
			{
				player.statLife += 1;
				
			}
			

		}
		
	}
}
