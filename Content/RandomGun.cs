using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnusualStart.Content
{
    public class RandomGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Irregulator");
            Tooltip.SetDefault("Fires a cluster of arbitrary projectiles");
        }

        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = -12;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("RandomSoul"), 25);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            int type1 = ProjectileID.Bullet;
            int type2 = ProjectileID.Bullet;
            int type3 = ProjectileID.Bullet;
            int type4 = ProjectileID.Bullet;
            int type5 = ProjectileID.Bullet;

            int typeRandom = Main.rand.Next(1,7);
            switch (typeRandom)
            {
                case 1:
                    type1 = ProjectileID.Bullet;
                    type2 = ProjectileID.BulletHighVelocity;
                    type3 = ProjectileID.ChlorophyteBullet;
                    type4 = ProjectileID.ExplosiveBullet;
                    type5 = ProjectileID.GoldenBullet;
                    break;
                case 2:
                    type1 = ProjectileID.PartyBullet;
                    type2 = ProjectileID.VenomBullet;
                    type3 = ProjectileID.IchorBullet;
                    type4 = ProjectileID.NanoBullet;
                    type5 = ProjectileID.SniperBullet;
                    break;
                case 3:
                    type1 = ProjectileID.WoodenArrowFriendly;
                    type2 = ProjectileID.BeeArrow;
                    type3 = ProjectileID.BoneArrow;
                    type4 = ProjectileID.CursedArrow;
                    type5 = ProjectileID.FireArrow;
                    break;
                case 4:
                    type1 = ProjectileID.FrostburnArrow;
                    type2 = ProjectileID.HolyArrow;
                    type3 = ProjectileID.JestersArrow;
                    type4 = ProjectileID.HellfireArrow;
                    type5 = ProjectileID.VenomArrow;
                    break;
                case 5:
                    type1 = ProjectileID.ShadowFlameArrow;
                    type2 = ProjectileID.ChlorophyteArrow;
                    type3 = ProjectileID.UnholyArrow;
                    type4 = ProjectileID.DD2BetsyArrow;
                    type5 = ProjectileID.FrostArrow;
                    break;
                case 6:
                    type1 = ProjectileID.Beenade;
                    type2 = ProjectileID.Grenade;
                    type3 = ProjectileID.StickyGrenade;
                    type4 = ProjectileID.BouncyGrenade;
                    type5 = ProjectileID.PartyGirlGrenade;
                    break;
                case 7:
                    type1 = ProjectileID.DeathSickle;
                    type2 = ProjectileID.IceSickle;
                    type3 = ProjectileID.Sharknado;
                    type4 = ProjectileID.Typhoon;
                    type5 = ProjectileID.DD2PhoenixBowShot;
                    break;

            }

            // Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type1, 12, 10, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type2, 12, 10, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type3, 12, 10, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type4, 12, 10, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type5, 12, 10, player.whoAmI);
            // By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
            return true;
        }
        public override bool ConsumeAmmo(Player player)
        {
            // Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
            // We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
            return !(player.itemAnimation < item.useAnimation +5);
        }
    }
}

