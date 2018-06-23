using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnusualStart.Content
{
    public class RandomSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of the Gambler");
            Tooltip.SetDefault("This item is different every time it is observed");
            // ticksperframe, frameCount
            Main.RegisterItemAnimation(item.type, new Terraria.DataStructures.DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofSight);
            item.width = refItem.width;
            item.height = refItem.height;
            item.rare = -12;
            item.value = 50000000;
            item.maxStack = 99;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.Pink.ToVector3() * 0.55f * Main.essScale);
        }
    }
    public class SoulGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu && Main.expertMode)
            {
                if (Main.rand.Next(100) < 25) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1,2));
                }
            }
            if (npc.type == NPCID.KingSlime && Main.expertMode)
            {
                if (Main.rand.Next(100) < 15) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 3));
                }
            }
            if (npc.type == NPCID.QueenBee && Main.expertMode)
            {
                if (Main.rand.Next(100) < 25) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 3));
                }
            }
            if (npc.type == NPCID.EaterofWorldsHead && Main.expertMode)
            {
                if (Main.rand.Next(100) < 15) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"));
                }
            }
            if (npc.type == NPCID.BrainofCthulhu && Main.expertMode)
            {
                if (Main.rand.Next(100) < 15) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"));
                }
            }
            if (npc.type == NPCID.SkeletronHead && Main.expertMode)
            {
                if (Main.rand.Next(100) < 30) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.EyeofCthulhu && Main.expertMode)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 3));
            }
            if (npc.type == NPCID.Retinazer && Main.expertMode)
            {
                if (Main.rand.Next(100) < 20) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.Spazmatism && Main.expertMode)
            {
                if (Main.rand.Next(100) < 20) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.TheDestroyer && Main.expertMode)
            {
                if (Main.rand.Next(100) < 30) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 3));
                }
            }
            if (npc.type == NPCID.SkeletronPrime && Main.expertMode)
            {
                if (Main.rand.Next(100) < 35) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 4));
                }
            }
            if (npc.type == NPCID.Plantera && Main.expertMode)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 4));
            }
            if (npc.type == NPCID.Golem && Main.expertMode)
            {
                if (Main.rand.Next(100) < 30) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 3));
                }
            }
            if (npc.type == NPCID.DukeFishron && Main.expertMode)
            {
                if (Main.rand.Next(100) < 50) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 5));
                }
            }
            if (npc.type == NPCID.CultistBoss && Main.expertMode)
            {
                if (Main.rand.Next(100) < 50) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 7));
                }
            }
            if (npc.type == NPCID.MoonLordHead && Main.expertMode)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(2,7));
            }
            if (npc.type == NPCID.MartianSaucer && Main.expertMode)
            {
                if (Main.rand.Next(100) < 10) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 4));
                }
            }
            if (npc.type == NPCID.PirateShip && Main.expertMode)
            {
                if (Main.rand.Next(100) < 10) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 2));
                }
            }
            if (npc.type == NPCID.DD2Betsy && Main.expertMode)
            {
                if (Main.rand.Next(100) < 50) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RandomSoul"), Main.rand.Next(1, 4));
                }
            }
        }
    }
}