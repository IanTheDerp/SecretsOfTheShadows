using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class ChickenLeg : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chichen Leg");
			Tooltip.SetDefault("Chicken");
		}
		public override void SetDefaults()
		{

			item.damage = 16;
			item.thrown = true;
			item.width = 24;
			item.height = 24;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;            
			item.shoot = mod.ProjectileType("FeatherShot"); 
            item.shootSpeed = 12;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChickenBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}