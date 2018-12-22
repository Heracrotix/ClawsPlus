using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawsPlus.Items
{
	public class Blitz : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blitz");
			Tooltip.SetDefault("Blazing speed!");
		}
		public override void SetDefaults()
		{
			item.damage = 141;
			item.melee = true;
			item.width = 50;
			item.height = 60;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 1000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
        
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 22);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
		}
	
	  
    }
	}
	
