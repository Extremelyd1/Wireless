
using Terraria;
using Terraria.ModLoader;

namespace Wireless.Items
{
	public class WirelessReceiver : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.WirelessReceiver>();
			Item.value = Item.buyPrice(0, 2);
			Item.rare = 4;
			Item.mech = true;
		}
	}
}
