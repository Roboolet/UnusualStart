using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnusualStart.Content
{
    // Making an item like Life Fruit (That goes above 500) involves a lot of code, as there are many things to consider. (An alternate that approaches 500 can simply follow vanilla code, however.):
    //    You can't make player.statLifeMax more than 500 (it won't save), so you'll have to maintain your extra life within your mod.
    //    Within your ModPlayer, you need to save/load a count of usages. You also need to sync the data to other players. 
    class RandomPot : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Random Item Potion");
            Tooltip.SetDefault("Puts a random vanilla item in each inventory slot\nDrops all your items\nHas some side effects");
        }

        public override void SetDefaults()
        {
            item.consumable = true;
            item.value = 100000000;
            item.height = 25;
            item.UseSound = SoundID.Item3;
            item.rare = 2;
            item.CloneDefaults(ItemID.BattlePotion);
        }

        public override bool UseItem(Player player)
        {
            player.DropItems();

            player.PutItemInInventory(Main.rand.Next(1, 3929),1);

            player.AddBuff(BuffID.OnFire, 640);
            player.AddBuff(BuffID.CursedInferno, 640);
            player.AddBuff(BuffID.Ichor, 640);
            player.AddBuff(BuffID.Frostburn, 640);
            player.AddBuff(BuffID.BrokenArmor, 640);
            player.AddBuff(BuffID.Chilled, 640);
            player.AddBuff(BuffID.Slow, 640);
            player.AddBuff(BuffID.Cursed, 640);
            player.AddBuff(BuffID.Electrified, 640);
            player.AddBuff(BuffID.Poisoned, 640);
            player.AddBuff(BuffID.Burning, 640);
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Daybloom, 15);
            recipe.AddIngredient(ItemID.Fireblossom, 15);
            recipe.AddIngredient(ItemID.Waterleaf, 15);
            recipe.AddIngredient(ItemID.Deathweed, 15);
            recipe.AddIngredient(ItemID.Blinkroot, 15);
            recipe.AddIngredient(ItemID.Shiverthorn, 15);
            recipe.AddIngredient(ItemID.GoldChest);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddTile(TileID.Bottles);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}