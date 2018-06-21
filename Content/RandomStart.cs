using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnusualStart.Content
{
    public class RandomStart : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
            items.RemoveAt(2);         
            items.RemoveAt(1);
            items.RemoveAt(0);

            //pickaxes and axes mechanic here
            int pickRandom = 469; //pickaxe statue
            int axeRandom = 465; //axe statue

            int[] pickRandomIndex = new int[] {1,103,122,776,777,778,798,882,990,1188,1195,1202,1230,1294,1320,1506,1917,2776,2781,2786
                ,3466,3485,3491,3497,3503,3509,3515,3521,2341,2176,385,386,388,1189,1196,1203,1231,2774,579,2798,2779,2784,3464};
            pickRandom = pickRandomIndex [Main.rand.Next(0, pickRandomIndex.Length)];

            int[] axeRandomIndex = new int[] {10,45,204,217,990,991,992,993,1222,1223,1224,1233,1305,1507,2772,3482,3488,3494,3500,3506,
                3512,3518,3522,3523,3524,3525,799,2176,383,384,387,1190,1197,1204,1232,1294,2342,2773,3098,579,2798};
            axeRandom = axeRandomIndex[Main.rand.Next(0, axeRandomIndex.Length)];


            Item item = new Item();
            item.SetDefaults(pickRandom);       
            items.Add(item);

            Item item1 = new Item();
            item1.SetDefaults(axeRandom);       //this is an example of how to add a vanilla terraria item    //and the stack of the item
            items.Add(item1);

            Item item2 = new Item();
            item2.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item2);

            Item item3 = new Item();
            item3.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item3);

            Item item4 = new Item();
            item4.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item4);

            Item item5 = new Item();
            item5.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item5);

            Item item6 = new Item();
            item6.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item6);

            Item item7 = new Item();
            item7.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item7);

            Item item8 = new Item();
            item8.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item8);

            Item item9 = new Item();
            item9.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item9);

            Item item10 = new Item();
            item10.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item           //and the stack of the item
            items.Add(item10);

            Item item11 = new Item();
            item11.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item11);

            Item item12 = new Item();
            item12.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item12);

            Item item13 = new Item();
            item13.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item13);

            Item item14 = new Item();
            item14.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item          //and the stack of the item
            items.Add(item14);

            Item item15 = new Item();
            item15.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item15);

            Item item16 = new Item();
            item16.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item           //and the stack of the item
            items.Add(item16);

            Item item17 = new Item();
            item17.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item17);

            Item item18 = new Item();
            item18.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item18);

            Item item19 = new Item();
            item19.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item19);

            Item item20 = new Item();
            item20.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item20);

            Item item21 = new Item();
            item21.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item      //and the stack of the item
            items.Add(item21);

            Item item22 = new Item();
            item22.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item22);

            Item item23 = new Item();
            item23.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item23);

            Item item24 = new Item();
            item24.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item24);

            Item item25 = new Item();
            item25.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item           //and the stack of the item
            items.Add(item25);

            Item item26 = new Item();
            item26.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item26);

            Item item27 = new Item();
            item27.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item27);

            Item item28 = new Item();
            item28.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item28);

            Item item29 = new Item();
            item29.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item3);

            Item item30 = new Item();
            item30.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item30);

            Item item31 = new Item();
            item31.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item31);

            Item item32 = new Item();
            item32.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item32);

            Item item33 = new Item();
            item33.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item33);

            Item item34 = new Item();
            item34.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item34);

            Item item35 = new Item();
            item35.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item           //and the stack of the item
            items.Add(item35);

            Item item36 = new Item();
            item36.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item36);

            Item item37 = new Item();
            item37.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item37);

            Item item38 = new Item();
            item38.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item38);

            Item item39 = new Item();
            item39.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item39);

            Item item40 = new Item();
            item40.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item40);

            Item item41 = new Item();
            item41.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item41);

            Item item42 = new Item();
            item42.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item42);

            Item item43 = new Item();
            item43.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item43);

            Item item44 = new Item();
            item44.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item         //and the stack of the item
            items.Add(item44);

            Item item45 = new Item();
            item45.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item45);

            Item item46 = new Item();
            item46.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item        //and the stack of the item
            items.Add(item46);

            Item item47 = new Item();
            item47.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item          //and the stack of the item
            items.Add(item47);

            Item item48 = new Item();
            item48.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item48);

            Item item49 = new Item();
            item49.SetDefaults(Main.rand.Next(1, 3929));       //this is an example of how to add a vanilla terraria item       //and the stack of the item
            items.Add(item49);
        }
    }
}
