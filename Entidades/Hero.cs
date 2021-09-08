using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Species
    {
        Human,
        Draesirian,
        Elf,
        Faerya,
        Dwarf,
        Khraldar,
        Wolvem,
        Silen,
    }
    public enum Archetype
    {
        belligerent,
        occultist,
        tracker,
        enlightened,
        normal,
    }
    public abstract class Hero
    {
        //--------------------------
        //Clase abstracta, de esta heredara los atributos, metodos y propiedades el resto.
        //cada raza sobreescribira metodos/propiedades segun sus caracteristicas especificas.
        //Ademas, hay ciertos rasgos que se definen segun el "arquetipo".
        //Tanto estos ultimos, como las razas, estan listados en Enumerados (Species/Archetypes)
        protected string fullName;
        public string FullName
        {
            get
            {
                return this.fullName;
            }
        }
        public abstract Species Species
        {
            get;
        }
        protected Archetype archetype;
        public Archetype Archetype
        {
            get
            {
                return this.archetype;
            }
        }
        //--------------------------
        //body members
        protected int body;
        public int Body
        {
            get
            {
                return this.body;
            }
            set
            {
                this.perception = value;
            }
        }
        //
        protected int agility;
        public int Agility
        {
            get
            {
                return this.agility;
            }
            set
            {
                this.agility = value;
            }
        }
        protected int dexterity;
        public int Dexterity
        {
            get
            {
                return this.dexterity;
            }
            set
            {
                this.dexterity = value;
            }
        }
        protected int strength;
        public int Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                this.strength = value;
            }
        }
        protected int constitution;
        public int Constitution
        {
            get
            {
                return this.constitution;
            }
            set
            {
                this.constitution = value;
            }
        }
        //mind members
        protected int mind;
        public int Mind
        {
            get
            {
                return this.mind;
            }
            set
            {
                this.mind = value;
            }
        }
        //
        protected int perception;
        public int Perception
        {
            get
            {
                return this.perception;
            }
            set
            {
                this.perception = value;
            }
        }
        protected int charisma;
        public int Charisma
        {
            get
            {
                return this.charisma;
            }
            set
            {
                this.charisma = value;
            }
        }
        protected int will;
        public int Will
        {
            get
            {
                return this.will;
            }
            set
            {
                this.will = value;
            }
        }
        protected int knowledge;
        public int Knowledge
        {
            get
            {
                return this.knowledge;
            }
            set
            {
                this.knowledge = value;
            }
        }
        //---------------------------
        //in-game abilities
        //lecture-only properties
        //---------------------------
        public int Movement
        {
            get
            {
                return this.agility;
            }
        }
        public decimal Jump
        {
            get
            {
                return ((decimal)this.agility) / 2;
            }
        }
        public int Load(int loadType)
        {
            //van a haber 3 variantes
            //1=carga liviana
            //2=carga media
            //3=carga pesada
            switch (loadType)
            {
                case 1:
                    return this.strength * 5;
                case 2:
                    return this.strength * 10;
                case 3:
                    return this.strength * 40;
                default:
                    return -1;
            }
        }
        virtual public int Haste
        {
            get
            {
                int haste = this.agility + this.dexterity;
                if (this.Archetype == Archetype.belligerent)
                {
                    return haste + 4;
                }
                else if (this.Archetype == Archetype.occultist)
                {
                    return haste + 2;
                }
                else if (this.Archetype == Archetype.tracker)
                {
                    return haste + 6;
                }
                else if (this.Archetype == Archetype.enlightened)
                {
                    return haste + 2;
                }
                else if (this.Archetype == Archetype.normal)
                {
                    return haste + 2;
                }
                else
                {
                    return -999;//flag
                }
            }
        }
        //vitality members
        virtual public int Vitality
        {
            get
            {
                int vitality = this.constitution * 2;

                if (this.Archetype == Archetype.belligerent)
                {
                    return vitality + 6;
                }
                else if (this.Archetype == Archetype.occultist)
                {
                    return vitality + 2;
                }
                else if (this.Archetype == Archetype.tracker)
                {
                    return vitality + 4;
                }
                else if (this.Archetype == Archetype.enlightened)
                {
                    return vitality + 2;
                }
                else if (this.Archetype == Archetype.normal)
                {
                    return vitality + 2;
                }
                else
                {
                    return -999;//flag
                }
            }
        }
        virtual public int VitalRecovery
        {
            get
            {
                return this.constitution;
            }
        }
        //Mana members
        public virtual int Mana
        {
            get
            {
                int mana = this.knowledge * 2;
                if (this.Archetype == Archetype.belligerent)
                {
                    return mana + 2;
                }
                else if (this.Archetype == Archetype.occultist)
                {
                    return mana + 6;
                }
                else if (this.Archetype == Archetype.tracker)
                {
                    return mana + 2;
                }
                else if (this.Archetype == Archetype.enlightened)
                {
                    return mana + 4;
                }
                else if (this.Archetype == Archetype.normal)
                {
                    return mana + 2;
                }
                else
                {
                    return -999;//flag
                }
            }
        }
        virtual public int ManaRecovery
        {
            get
            {
                return this.knowledge;
            }
        }
        public Hero()
        {

        }
        public Hero(string fullName, Archetype archetype,
            int body, int agility, int dexterity, int strength, int constitution,
            int mind, int perception, int charisma, int will, int knowledge)
        {
            this.fullName = fullName;
            this.archetype = archetype;
            this.body = body;
            this.agility = agility;
            this.dexterity = dexterity;
            this.strength = strength;
            this.constitution = constitution;
            this.mind = mind;
            this.perception = perception;
            this.charisma = charisma;
            this.will = will;
            this.knowledge = knowledge;
        }

        public override string ToString()
        {
            return $"{this.Archetype} {this.Species}";
        }
    }
}
