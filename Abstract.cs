using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon[] weapons = new Weapon[2];
            weapons[0] = new Missle();
            weapons[1] = new MachineGun();

            for (int i=0;i<weapons.Length;i++)
            {
                weapons[i].Fire();
            }
        }
    }

    public abstract class Weapon
    {
        protected int DamagePower;

        public abstract void Fire();

    }

    public class Missle :Weapon
    {
       public Missle()
        {
            DamagePower = 200;       
        }

        public override void Fire()
        {
            Console.WriteLine("Missle was filed with damage power : {0}", DamagePower);
        }
    }

    public class MachineGun :Weapon

    {
        public MachineGun()
        {
            DamagePower = 200;
        }

        public override void Fire()
        {
            Console.WriteLine("MachineGun was filed with damage power : {0}", DamagePower);
        }

    }    
}
