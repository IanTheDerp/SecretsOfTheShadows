using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class BloodiedSeal: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodied Seal");
			Tooltip.SetDefault("You can feel blood flowing down you skin...");
		}
		public override void SetDefaults()
		{

			item.width = 40;
			item.height = 54;
			item.value = 0;
			item.rare = 5;
			item.maxStack = 99;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
			
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodPlatform, 150);
			recipe.AddIngredient(ItemID.Obsidian, 50);
			recipe.AddIngredient(ItemID.HellstoneBar, 12);
			recipe.AddIngredient(ItemID.Bone, 24);
			recipe.AddIngredient(null, "ObsidianScale", 16);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool CanUseItem(Player player)
		{
		return !NPC.AnyNPCs(mod.NPCType("LordOfBlood"));
	
		}
		public override bool UseItem(Player player)
		{
					Main.NewText("Lord of Blood has awoken!", 255,25, 25);
				 NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, mod.NPCType("LordOfBlood"));			
		Main.PlaySound(0, (int)player.position.X, (int)player.position.Y, 0);
		
		/*
            Vector2 position = player.Center;
            Main.PlaySound(SoundID.Item14, (int)position.X, (int)position.Y);
            int radius = 22;     //this is the explosion radius, the highter is the value the bigger is the explosion
 
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + position.X / 16.0f);
                    int yPosition = (int)(y + position.Y / 16.0f);
 
                    if (Math.Sqrt(x * x + y * y) <= radius + 0.5)   //this make so the explosion radius is a circle
                    {
						WorldGen.PlaceTile(xPosition, yPosition, 19);
                    }
                }
            }
			
            int radius2 = 24;     //this is the explosion radius, the highter is the value the bigger is the explosion
 
            for (int x = -radius2; x <= radius2; x++)
            {
                for (int y = -radius2; y <= radius2; y++)
                {
                    int xPosition2 = (int)(x + position.X / 16.0f);
                    int yPosition2 = (int)(y + position.Y / 16.0f);
 
                    if (Math.Sqrt(x * x + y * y) <= radius2 + 0.5)   //this make so the explosion radius is a circle
                    {
						WorldGen.PlaceTile(xPosition2, yPosition2, 56);
                    }
                }
            }
			
			 int radius3 = 7;     //this is the explosion radius, the highter is the value the bigger is the explosion
 
			*/
			
		return true;
		
		}
	}
}