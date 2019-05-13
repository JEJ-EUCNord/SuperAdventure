namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int StrengthWeapon { get; set; }

        public int IntellectWeapon { get; set; }
        public int AgilityWeapon { get; set; }

        public int DefenseWeapon { get; set; }
        public int CriticalStrikeWeapon { get; set; }

        public string WeaponType { get; set; }

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int strengthWeapon, int intellectWeapon, int agilityWeapon,int defenseWeapon, int criticalStrikeWeapon ,  int price, string weaponType) : base(id,name, namePlural, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;

            StrengthWeapon = strengthWeapon;
            IntellectWeapon = intellectWeapon;
            AgilityWeapon = agilityWeapon;
            DefenseWeapon = defenseWeapon;
            CriticalStrikeWeapon = criticalStrikeWeapon;
            WeaponType = weaponType;
        }
    }
}
