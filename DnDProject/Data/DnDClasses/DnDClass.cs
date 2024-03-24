namespace DnDProject.Data.DnDClasses
{
    public abstract class DnDClass
    {
        public int Level { get; set; }
        public virtual int HitDice { get; set; }  //цифра указывает на количество граней кубика
        //Владение
        public List<string> ArmorProficiency { get; set; }
        public List<string> WeaponsProfifciency { get; set; }
        public List<string> ToolsProficiency { get; set; }
        public List<string> STProficiency { get; set; }
        //Навыки
        public string AvailableSkills { get; set; }
        //Особые умения
        public List<string> Features { get; set; }

    }
}
