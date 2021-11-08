using System;
using System.Collections.Generic;
using System.Linq;

namespace TP2
{
    public abstract class Spaceship : IEquatable<Spaceship>
    {
        public Guid Id { get; } = new Guid();
        public string Name { get; set; }
        public double currentStructure { get; set; }
        public double Structure { get; set; }
        public double currentShield { get; set; }
        public double Shield { get; set; }
        public double Damage { get; set; }
        public bool IsDestroyed { get; private set; } = false;
        public int MaxWeapons { get; } = 3;
        public List<Weapon> Weapons { get; } = new List<Weapon>();
        public double AverageDamages => (Weapons.Sum(x => x.MinDamage) + Weapons.Sum(x => x.MaxDamage)) / 2;

        public Spaceship(){ }

        public void AddWeapon(Weapon weapon)
        {
            // test si l'arme provien bien de l'armurerie mais c'est quasiment impossible avec les visibilités utilisées
            if (!Armory.IsWeaponFromArmory(weapon)) { throw new ArmoryException(); }
            // évite de dépasser le nombre maximum d'arme sur le vaisseau
            if (Weapons.Count < MaxWeapons) { Weapons.Add(weapon); }
            else { throw new Exception(Name + " : Max Weapons on ship"); }
        }
        public void RemoveWeapon(Weapon oWeapon)
        {
            if (Weapons.Contains(oWeapon)) { Weapons.Remove(oWeapon); }
        }
        public void ClearWeapons()
        {
            Weapons.Clear();
        }

        public void ViewShip()
        {
            Console.WriteLine("===== INFOS VAISSEAU =====");
            Console.WriteLine("Nom : " + Name);
            Console.WriteLine("Points de vie : " + Structure);
            Console.WriteLine("Bouclier : " + Shield);
            ViewWeapons();
            Console.WriteLine("Dommages moyens: " + AverageDamages );
            Console.WriteLine();
        }
        public void ViewWeapons()
        {
            foreach (var item in Weapons)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Spaceship DefaultSpaceship()
        {
            Random rnd = new Random();
            Spaceship ship = new(Spaceship) { Name = "Viper MKII", Structure = 10, Shield = 10 };
            while (ship.Weapons.Count < ship.MaxWeapons)
            {
                try
                {
                    ship.AddWeapon(Armory.CreatWeapon(Armory.Blueprints[rnd.Next(0, Armory.Blueprints.Count)]));
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            try
            {
                ship.AddWeapon(Armory.CreatWeapon(Armory.Blueprints[rnd.Next(0, Armory.Blueprints.Count)]));
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return ship;
        }

        //public double DamageShoot()
        //{
        //    if (Weapon.Shoot = true)
        //    {
        //        if (Shield !=0)
        //        {
        //            currentShield = Shield - Damage;
        //            return currentShield;
        //        }
        //        else if (Structure != 0)
        //        {
        //            currentStructure = Structure - Damage;
        //            return currentStructure;
        //        }
        //    }
        //    else
        //        return 0;

        //}

        public override bool Equals(object obj)
        {
            return Equals(obj as Spaceship);
        }

        public bool Equals(Spaceship other)
        {
            return other != null &&
                   Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
