using DnDProject.Data.DnDClasses;
namespace DnDProject.Data.Spells
{
    public class Spell
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public string School { get; set; }
        public List<DnDClass> DndClasses {get;set;}
        public string CastingTime { get; set; }
        public double Range { get; set; }
        public int Components { get; set; }
        public bool Concentration { get; set; }
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public string SavingTrow { get; set; }


    }
}
