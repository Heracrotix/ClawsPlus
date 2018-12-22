using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawsPlus.Items
{
	public class Osore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Osore");
			Tooltip.SetDefault("Fear not the dead, but the fast!");
		}
		public override void SetDefaults()
		{
			item.damage = 99;
			item.melee = true;
			item.width = 45;
			item.height = 55;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 500000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
        
	
	
	    class MyGlobalNPC : GlobalNPC
{
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == NPCID.SkeletronPrime)
		{
			if (Main.rand.Next(1) < 1)
	        Item.NewItem(npc.getRect(), mod.ItemType("Osore"), 1);
		}
		
		
	}
    }
	}
    }
