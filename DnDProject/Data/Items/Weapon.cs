using DnDProject.Data.Basic;
namespace DnDProject.Data.Items
{
    public class Weapon
    {
        public string WeaponType {get;set;}
        public int Bonus { get;set;} //у маг. предметов есть бонус к атаке и урону 
        public  List<Damage> DamageDices { get;set;}  
        public float Range { get;set;} 
        public List<WProp> WeaponProperties { get;set;}

    }
    public class WProp // есть вариант засунуть сюда все возможные свойства оружия в виде буля
    {
        public string Name { get;set;}
        public string Description { get;set;}
    }
    

}
