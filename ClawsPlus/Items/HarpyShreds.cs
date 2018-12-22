using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawsPlus.Items
{
	public class HarpyShreds : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Harpy Shreds");
			Tooltip.SetDefault("Swaying feathers of fury!");
		}
		public override void SetDefaults()
		{
			item.damage = 27;
			item.melee = true;
			item.width = 45;
			item.height = 55;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 135000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		
	class MyGlobalNPC : GlobalNPC
{
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == NPCID.Harpy)
		{
			if (Main.rand.Next(12) < 1)
	        Item.NewItem(npc.getRect(), mod.ItemType("HarpyShreds"), 1);
		}
		
	}
}
	}
}
