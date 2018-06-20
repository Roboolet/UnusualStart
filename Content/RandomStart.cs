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

            int pickRandomIndex = Main.rand.Next(1, 36);
            switch (pickRandomIndex)
            {
                default:
                    pickRandom = 1;
                    break;

                case 1:
                    pickRandom = 1;
                    break;
                case 2:
                    pickRandom = 103;
                    break;
                case 3:
                    pickRandom = 122;
                    break;
                case 4:
                    pickRandom = 776;
                    break;
                case 5:
                    pickRandom = 777;
                    break;
                case 6:
                    pickRandom = 778;
                    break;
                case 7:
                    pickRandom = 798;
                    break;
                case 8:
                    pickRandom = 882;
                    break;
                case 9:
                    pickRandom = 990;
                    break;
                case 10:
                    pickRandom = 1188;
                    break;
                case 11:
                    pickRandom = 1195;
                    break;
                case 12:
                    pickRandom = 1202;
                    break;
                case 13:
                    pickRandom = 1230;
                    break;
                case 14:
                    pickRandom = 1294;
                    break;
                case 15:
                    pickRandom = 1320;
                    break;
                case 16:
                    pickRandom = 1506;
                    break;
                case 17:
                    pickRandom = 1917;
                    break;
                case 18:
                    pickRandom = 2776;
                    break;
                case 19:
                    pickRandom = 2781;
                    break;
                case 20:
                    pickRandom = 2786;
                    break;
                case 21:
                    pickRandom = 3466;
                    break;
                case 22:
                    pickRandom = 3485;
                    break;
                case 23:
                    pickRandom = 3491;
                    break;
                case 24:
                    pickRandom = 3497;
                    break;
                case 25:
                    pickRandom = 3503;
                    break;
                case 26:
                    pickRandom = 3509;
                    break;
                case 27:
                    pickRandom = 3515;
                    break;
                case 28:
                    pickRandom = 3521;
                    break;
                case 29:
                    pickRandom = 385;
                    break;
                case 30:
                    pickRandom = 386;
                    break;
                case 31:
                    pickRandom = 388;
                    break;
                case 32:
                    pickRandom = 1189;
                    break;
                case 33:
                    pickRandom = 1196;
                    break;
                case 34:
                    pickRandom = 1203;
                    break;
                case 35:
                    pickRandom = 1231;
                    break;
                case 36:
                    pickRandom = 2774;
                    break;
            }
            int axeRandomIndex = Main.rand.Next(1, 37);
            switch (axeRandomIndex)
            {
                default:
                    axeRandom = 10;
                    break;

                case 1:
                    axeRandom = 10;
                    break;
                case 2:
                    axeRandom = 204;
                    break;
                case 3:
                    axeRandom = 217;
                    break;
                case 4:
                    axeRandom = 990;
                    break;
                case 5:
                    axeRandom = 991;
                    break;
                case 6:
                    axeRandom = 992;
                    break;
                case 7:
                    axeRandom = 993;
                    break;
                case 8:
                    axeRandom = 1222;
                    break;
                case 9:
                    axeRandom = 1223;
                    break;
                case 10:
                    axeRandom = 1224;
                    break;
                case 11:
                    axeRandom = 1233;
                    break;
                case 12:
                    axeRandom = 1305;
                    break;
                case 13:
                    axeRandom = 1507;
                    break;
                case 14:
                    axeRandom = 2772;
                    break;
                case 15:
                    axeRandom = 3482;
                    break;
                case 16:
                    axeRandom = 3488;
                    break;
                case 17:
                    axeRandom = 3494;
                    break;
                case 18:
                    axeRandom = 3500;
                    break;
                case 19:
                    axeRandom = 3506;
                    break;
                case 20:
                    axeRandom = 3512;
                    break;
                case 21:
                    axeRandom = 3518;
                    break;
                case 22:
                    axeRandom = 3522;
                    break;
                case 23:
                    axeRandom = 3523;
                    break;
                case 24:
                    axeRandom = 3524;
                    break;
                case 25:
                    axeRandom = 3525;
                    break;
                case 26:
                    axeRandom = 383;
                    break;
                case 27:
                    axeRandom = 384;
                    break;
                case 28:
                    axeRandom = 387;
                    break;
                case 29:
                    axeRandom = 1190;
                    break;
                case 30:
                    axeRandom = 1197;
                    break;
                case 31:
                    axeRandom = 1204;
                    break;
                case 32:
                    axeRandom = 1232;
                    break;
                case 33:
                    axeRandom = 1294;
                    break;
                case 34:
                    axeRandom = 2342;
                    break;
                case 35:
                    axeRandom = 2773;
                    break;
                case 36:
                    axeRandom = 3098;
                    break;
            }


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
