using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Khraldar : Hero
    {
        public override Species Species
        {
            get
            {
                return Entidades.Species.Khraldar;
            }
        }
        public override int Haste => base.Haste - 3;
        public override int Vitality => base.Vitality + 6;
        public override int VitalRecovery => base.VitalRecovery + 1;
        public override int Mana => base.Mana + 4;
        public override int ManaRecovery => base.ManaRecovery + 2;
        public Khraldar()
        {
        }
        public Khraldar(string fullName, Archetype archetype,
            int body, int agility, int dexterity, int strength, int constitution,
            int mind, int perception, int charisma, int will, int knowledge)
            : base(fullName, archetype, body, agility, dexterity, strength,
                  constitution, mind, perception, charisma, will, knowledge)
        {
        }
    }
}
