using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Silen:Hero
    {
        public override Species Species
        {
            get
            {
                return Entidades.Species.Silen;
            }
        }
        public override int Haste => base.Haste;
        public override int Vitality => base.Vitality + 3;
        public override int VitalRecovery => base.VitalRecovery;
        public override int Mana => base.Mana + 6;
        public override int ManaRecovery => base.ManaRecovery+1;//necesario??
        public Silen()
        {
        }
        public Silen(string fullName, Archetype archetype,
            int body, int agility, int dexterity, int strength, int constitution,
            int mind, int perception, int charisma, int will, int knowledge)
            : base(fullName, archetype, body, agility, dexterity, strength,
                  constitution, mind, perception, charisma, will, knowledge)
        {
        }
    }
}
