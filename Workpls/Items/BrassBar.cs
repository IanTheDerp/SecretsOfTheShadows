using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class BrassBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brass Bar");
			Tooltip.SetDefault("Where's the zinc?");
		}
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.value = 125;
			item.rare = 3;
			item.maxStack = 99;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 24);
			recipe.AddIngredient(ItemID.CopperBar, 3);
			recipe.AddIngredient(ItemID.SilverBar, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}