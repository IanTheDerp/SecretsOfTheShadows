using System;
using Terraria;
using Terraria.ModLoader;
 
namespace Workpls.Buffs
{
    public class Phantasmal : ModBuff
    {
        public override void SetDefaults()
        {
           DisplayName.SetDefault("Blooded");
			Description.SetDefault("A Vampire Probe will serve you");   
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
 
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("DVP")] > 0)
            {
                modPlayer.Phankin = true;
            }
            if (!modPlayer.Phankin)
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