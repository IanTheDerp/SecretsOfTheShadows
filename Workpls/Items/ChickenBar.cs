using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class ChickenBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Feather Light Bar");
			Tooltip.SetDefault("A light feather infused steel alloy.");
		}
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.value = 2500;
			item.rare = 3;
			item.maxStack = 99;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 16);
			recipe.AddIngredient(null, "TurkeyFeather", 16);
			recipe.AddIngredient(null, "SteelBar", 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}