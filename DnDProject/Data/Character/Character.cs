using DnDProject.Data.DnDClasses;
using DnDProject.Data.Races;
using DnDProject.Data.Items;
using DnDProject.Data.Spells;
using DnDProject.Data.Basic;
namespace DnDProject.Data.Character
{
    public class Character
    {
        //Верхняя часть чарлиста
        public string Name { get; set; }
        public List<DnDClass> CharacterClasses { get; set; }  //Потом надо будет подумать как реализовать мультикласс
        public int Level { get; set; }
        public Race Race{ get; set; }
        public string Alignment { get; set; }  // Мировозррение
        public string Background { get; set; } // Предыстория
        public int XP { get; set; }

        // Характеристики
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        // Модификаторы характеристик
        // P.S. Реализация не соответсвует принципу DRY
        public int StrMod
        {
            get
            {
                return GetAbilityMod(Str);
            }
        }
        public int DexMod
        {
            get
            {
                return GetAbilityMod(Dex);
            }
        }
        public int ConMod
        {
            get
            {
                return GetAbilityMod(Con);
            }
        }
        public int IntMod
        {
            get
            {
                return GetAbilityMod(Int);
            }
        }
        public int WisMod
        {
            get
            {
                return GetAbilityMod(Wis);
            }
        }
        public int ChaMod
        {
            get
            {
                return GetAbilityMod(Cha);
            }
        }

        // Спасброски
        public bool STStr { get; set; }
        public bool STDex { get; set; }
        public bool STCon { get; set; }
        public bool STInt { get; set; }
        public bool STWis { get; set; }
        public bool STCha { get; set; }
        //Модификаторы Спасбросков
        // P.S. Реализация не соответсвует принципу DRY
        public int STStrMod
        {
            get
            {
                return GetSkillMod(StrMod, STStr, ProficiencyBonus);
            }
        }
        public int STDexMod
        {
            get
            {
                return GetSkillMod(DexMod, STDex, ProficiencyBonus);
            }
        }
        public int STConMod
        {
            get
            {
                return GetSkillMod(ConMod, STCon, ProficiencyBonus);
            }
        }
        public int STIntMod
        {
            get
            {
                return GetSkillMod(IntMod, STInt, ProficiencyBonus);
            }
        }
        public int STWisMod
        {
            get
            {
                return GetSkillMod(WisMod, STWis, ProficiencyBonus);
            }
        }
        public int STChaMod
        {
            get
            {
                return GetSkillMod(ChaMod, STCha, ProficiencyBonus);
            }
        }

        //Навыки
        public bool Acrobatics { get; set; }       //Акробатика        (Лов)
        public bool AnimalHandling { get; set; }   //Уход за Животными (Мдр)
        public bool Arcana { get; set; }           //Магия             (Инт)
        public bool Athletics { get; set; }        //Атлетика          (Сил)
        public bool Deception { get; set; }        //Обман             (Хар)
        public bool History { get; set; }          //История           (Инт)
        public bool Insight { get; set; }          //Проницательность  (Мдр)
        public bool Intimidation { get; set; }     //Запугивание       (Хар)
        public bool Investigation { get; set; }    //Расследование     (Инт)
        public bool Medicine { get; set; }         //Медицина          (Мдр)
        public bool Nature { get; set; }           //Природа           (Инт)
        public bool Perception { get; set; }       //Внимательность    (Мдр)
        public bool Performance { get; set; }      //Исполнение        (Хар)
        public bool Persuasion { get; set; }       //Убеждение         (Хар)
        public bool Religion { get; set; }         //Религия           (Инт)
        public bool SleightOfHand { get; set; }    //Ловкость рук      (Лов)
        public bool Stealth { get; set; }          //Скрытность        (Лов)
        public bool Survival { get; set; }         //Выживание         (Мдр)
        //Модификаторы навыков
        public int AcrobaticsMod
        {
            get
            {
                return GetSkillMod(StrMod,Acrobatics,ProficiencyBonus);
            }
        }
        public int AnimalHandlingMod
        {
            get
            {
                return GetSkillMod(WisMod, AnimalHandling, ProficiencyBonus);
            }
        }
        public int ArcanaMod
        {
            get
            {
                return GetSkillMod(IntMod, Arcana, ProficiencyBonus);
            }
        }
        public int AthleticsMod
        {
            get
            {
                return GetSkillMod(StrMod, Athletics, ProficiencyBonus);
            }
        }
        public int DeceptionMod
        {
            get
            {
                return GetSkillMod(ChaMod, Deception, ProficiencyBonus);
            }
        }
        public int HistoryMod
        {
            get
            {
                return GetSkillMod(IntMod, History, ProficiencyBonus);
            }
        }
        public int InsightMod
        {
            get
            {
                return GetSkillMod(WisMod, Insight, ProficiencyBonus);
            }
        }
        public int IntimidationMod
        {
            get
            {
                return GetSkillMod(ChaMod, Intimidation, ProficiencyBonus);
            }
        }
        public int InvestigationMod
        {
            get
            {
                return GetSkillMod(IntMod, Investigation, ProficiencyBonus);
            }
        }
        public int MedicineMod
        {
            get
            {
                return GetSkillMod(WisMod, Medicine, ProficiencyBonus);
            }
        }
        public int NatureMod
        {
            get
            {
                return GetSkillMod(IntMod, Nature, ProficiencyBonus);
            }
        }
        public int PerceptionMod
        {
            get
            {
                return GetSkillMod(WisMod, Perception, ProficiencyBonus);
            }
        }
        public int PerformanceMod
        {
            get
            {
                return GetSkillMod(ChaMod, Performance, ProficiencyBonus);
            }
        }
        public int PersuasionMod
        {
            get
            {
                return GetSkillMod(WisMod, Persuasion, ProficiencyBonus);
            }
        }
        public int ReligionMod
        {
            get
            {
                return GetSkillMod(IntMod, Religion, ProficiencyBonus);
            }
        }
        public int SleightOfHandMod
        {
            get
            {
                return GetSkillMod(DexMod, SleightOfHand, ProficiencyBonus);
            }
        }
        public int StealthMod
        {
            get
            {
                return GetSkillMod(DexMod, Stealth, ProficiencyBonus);
            }
        }
        public int SurvivalMod
        {
            get
            {
                return GetSkillMod(WisMod, Survival, ProficiencyBonus);
            }
        }

        // Разное
        public bool Inspiration { get; set; }
        public int ProficiencyBonus 
        { 
            get 
            {
                if (Level <= 4)
                    return 2;
                else if (Level <= 8)
                    return 3;
                else if (Level <= 12)
                    return 4;
                else if (Level <= 16)
                    return 5;
                else
                    return 6;
            } 
        }
        public int PassiveWisdom 
        {
            get 
            {
                return 10 + WisMod;
            }
        }
        //Боевка
        public int ArmorClass
        {
            get
            {
                return 10 + DexMod; //в будущем нужно доработать, так как есть еще доспехи, щиты, заклинания, классовые и расовые пасивки 
            }
        }
        public int Initiative
        {
            get 
            { 
                return DexMod; 
            } 
        }
        public int Speed
        {
            get { return Race.Speed; }      
        }
        public int HPMax { get; set; }   // Сделать только после реализации игровых классов 
        public int HPCurrent { get; set; }
        public int HPTemporary { get; set; }

        public CharactersEffects Effects { get; set; };
        // Спасброски от смерти
        public int Success { get; set; }
        public int Failures { get; set; }

        //В будущем добавить список Экипировку и заклинания
        public List<string> ArmorProficiency { get; set; }
        public List<string> WeaponsProfifciency { get; set; }
        public List<string> ToolsProficiency { get; set; }
        public List<string> STProficiency { get; set; }

        //Инвентарь
        public List<Item> Inventory { get; set; }
        public double Weight { get;}
        public Coins Money { get; set; }
        //Заклинания
        public List<Spell> Spells { get; set; }

        //
        private int GetAbilityMod (int Ability)
        {
            return Ability / 2 - 5;
        }

        private int GetSkillMod (int Mod, bool Skill, int ProficiencyBonus)
        {
            int result = Mod;
            if (Skill == true)
                result += ProficiencyBonus;
            return result;
        }





    }
}
