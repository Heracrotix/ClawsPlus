using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawsPlus.Items
{
	public class MeatGrinder : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meat Grinder");
			Tooltip.SetDefault("Goes great with pasta!");
		}
		public override void SetDefaults()
		{
			item.damage = 59;
			item.melee = true;
			item.width = 45;
			item.height = 55;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 250000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		
	class MyGlobalNPC : GlobalNPC
{
	public override void NPCLoot(NPC npc)
	{
		if(npc.type == NPCID.WallofFlesh)
		{
			if (Main.rand.Next(4) < 1)
	        Item.NewItem(npc.getRect(), mod.ItemType("MeatGrinder"), 1);
		}
		
	}
}
	}
}
