using System;
using Terraria;
using Terraria.ModLoader;
 
namespace Workpls.Buffs
{
    public class Starfire : ModBuff
    {
        public override void SetDefaults()
        {
           DisplayName.SetDefault("Starfire");
			Description.SetDefault("A Lava Star will serve you");   
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
 
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("LavaStar")] > 0)
            {
                modPlayer.LavaStar = true;
            }
            if (!modPlayer.LavaStar)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}