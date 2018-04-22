using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items
{
	public class ChickenBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chicken Gun");
			Tooltip.SetDefault("What's the best chickn? Dead chickens.");
		}
		public override void SetDefaults()
		{
            item.damage = 21;  //gun damage
            item.magic = true;   //its a gun so set this to true
            item.width = 16;     //gun image width
            item.height = 42;   //gun image  height
            item.useTime = 18;  //how fast 
            item.useAnimation = 18;
            item.useStyle = 5;    
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 0;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("Chicken"); 
            item.shootSpeed = 7;
			item.mana = 22;
			

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChickenBar", 31);

			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
