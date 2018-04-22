using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class ChickenScimatar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Turkey Slicer");
		}
		public override void SetDefaults()
		{
            item.damage = 38;  //gun damage
            item.melee = true;   //its a gun so set this to true
            item.width = 44;     //gun image width
            item.height = 48;   //gun image  height
            item.useTime = 24;  //how fast 
            item.useAnimation = 24;
            item.useStyle = 1;    
			item.reuseDelay = 8;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			item.shoot = mod.ProjectileType("PikeProj");


		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChickenBar", 24);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
