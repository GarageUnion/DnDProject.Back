namespace DnDProject.Data.Items
{
    public class Armor : Item
    {
        public string ArmorType { get; set; }
        public int AC { get; set; } // ArmorClass (КД)
        public int MaxDexModifier { get; set; }
        public int MinStr { get; set; }
        public bool StealthDisadvantage { get; set; }

    }
}
