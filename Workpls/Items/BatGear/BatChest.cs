using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Workpls.Items.BatGear
{
	[AutoloadEquip(EquipType.Body)]
	public class BatChest : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 20;

			item.value = 200000;
			item.rare = 5;
			item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bat Chestplate");
			Tooltip.SetDefault("Gives more max minions");
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("BatHat") && legs.type == mod.ItemType("BatBoots");
        }

		public override void UpdateEquip(Player player)
		{
		
			player.maxMinions += 2;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelBar", 20);
			recipe.AddIngredient(ItemID.Leather, 16);
			recipe.AddIngredient(null, "GoblinRockBar", 48);
			recipe.AddIngredient(ItemID.Bone, 60);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}

	}
}