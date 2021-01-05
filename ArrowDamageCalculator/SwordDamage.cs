using System;
using System.Diagnostics;
namespace ArrowDamageCalculator
{
    public class SwordDamage
    {
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        public int Damage { get; private set; }

        private int roll;

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;


        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;

        }

        private bool magic;

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }


        private bool flaming;

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

    }
}