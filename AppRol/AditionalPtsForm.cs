using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AppRol
{
    public partial class AditionalPtsForm : Form
    {
        //En este form se le da a elegir al usuario que puntos quiere adicionar
        //como bono por el/la especie/arquetipo elegido/a

        private Hero hero;
        private PjCreationForm pjCreationForm;
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        public AditionalPtsForm()
        {
        }
        public AditionalPtsForm(Hero hero, PjCreationForm pjCreationForm)
        {
            //recibe como parametros al formulario anterior y al heroe creado en este.
            InitializeComponent();
            this.hero = hero;
            this.pjCreationForm = pjCreationForm;

            //suscribo todas mis checkboxes al evento CheckedChanged
            this.checkBoxes.Add(perceptionBtn);
            this.checkBoxes.Add(strengthBtn);
            this.checkBoxes.Add(constitutionBtn);
            this.checkBoxes.Add(knowledgeBtn);
            this.checkBoxes.Add(dexterityBtn);
            this.checkBoxes.Add(charismaBtn);
            this.checkBoxes.Add(willBtn);
            this.checkBoxes.Add(agilityBtn);
            foreach(CheckBox item in checkBoxes)
            {
                item.CheckedChanged += checkBoxes_CheckedChanged;
            }

            //En cada caso los rasgos que se permiten upgradear
            //son distintos; muestro solo los que necesito (en archetype
            //con los radio buttons y en species con las checkboxes).

            //----------------------------
            //ARCHETYPE ADITIONAL POINTS--
            //----------------------------
            //Algunos de los bonos de arquetipo son automaticos (2 excepto
            //el arquetipo "Normal") mientras un tercero se le deja elegir
            //al usuario.
            //----------------------------
            //"Normal" no posee mejoras de arquetipo automaticas pero deja
            //al jugador elegir por un punto adicional de CUALQUIER rasgo.
            //----------------------------

            if (hero.Archetype == Archetype.belligerent)
            {
                hero.Dexterity++;
                hero.Will++;

                this.perceptionRadio.Hide();
                this.knowledgeRadio.Hide();
                this.dexterityRadio.Hide();
                this.charismaRadio.Hide();
                this.willRadio.Hide();
            }
            else if (hero.Archetype == Archetype.occultist)
            {
                hero.Knowledge++;
                hero.Will++;

                this.perceptionRadio.Hide();
                this.strengthRadio.Hide();
                this.constitutionRadio.Hide();
                this.knowledgeRadio.Hide();
                this.willRadio.Hide();
            }
            else if (hero.Archetype == Archetype.tracker)
            {
                hero.Agility++;
                hero.Dexterity++;

                this.strengthRadio.Hide();
                this.constitutionRadio.Hide();
                this.knowledgeRadio.Hide();
                this.dexterityRadio.Hide();
                this.charismaRadio.Hide();
            }
            else if (hero.Archetype == Archetype.enlightened)
            {
                hero.Perception++;
                hero.Charisma++;

                this.perceptionRadio.Hide();
                this.strengthRadio.Hide();
                this.constitutionRadio.Hide();
                this.dexterityRadio.Hide();
                this.charismaRadio.Hide();
            }
            //--------------------------
            //SPECIES ADITIONAL POINTS--
            //--------------------------
            //todas las especies tienen mejoras excepto "Human".
            //--------------------------

            if (hero.Species == Species.Human)
            {
                this.speciesAditionalPtsBox.Hide();
            }
            else if (hero.Species == Species.Draesirian)
            {
                this.charismaBtn.Hide();
                this.constitutionBtn.Hide();
                this.knowledgeBtn.Hide();
                this.strengthBtn.Hide();
            }
            else if (hero.Species == Species.Elf)
            {
                this.charismaBtn.Hide();
                this.constitutionBtn.Hide();
                this.willBtn.Hide();
                this.strengthBtn.Hide();
            }
            else if (hero.Species == Species.Faerya)
            {
                this.knowledgeBtn.Hide();
                this.constitutionBtn.Hide();
                this.willBtn.Hide();
                this.strengthBtn.Hide();
            }
            else if (hero.Species == Species.Dwarf)
            {
                this.charismaBtn.Hide();
                this.willBtn.Hide();
                this.agilityBtn.Hide();
                this.perceptionBtn.Hide();
            }
            else if (hero.Species == Species.Khraldar)
            {
                this.agilityBtn.Hide();
                this.charismaBtn.Hide();
                this.perceptionBtn.Hide();
                this.dexterityBtn.Hide();
            }
            else if (hero.Species == Species.Wolvem)
            {
                this.knowledgeBtn.Hide();
                this.constitutionBtn.Hide();
                this.willBtn.Hide();
                this.charismaBtn.Hide();
            }
            else if (hero.Species == Species.Silen)
            {
                this.constitutionBtn.Hide();
                this.agilityBtn.Hide();
                this.strengthBtn.Hide();
                this.charismaBtn.Hide();
            }

        }
        ///////////////////////////////////
        //EVENTHANDLER DE CIERRE AUTOMATICO:
        public void aditionalPtsForm_closeForms()
        {
            this.Close();
        }

        //EVENTHANDLER para el comportamiento de checkboxes(solo pueden haber 2 seleccionadas a la vez)
        private int checkedBts = 0;
        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkedBts++;
            }
            else
            {
                checkedBts--;
            }
            if (checkedBts > 2)
            {
                ((CheckBox)sender).Checked = false;
            }
        }

        //--------------------------
        //SUBMIT BUTTON-------------
        //--------------------------
        //Solo se permite presionar este boton cuando se han elegido
        //2 mejoras en el panel de especies (Excepto que sea "Human").
        //--------------------------
        //Se añaden todos los puntos seleccionados a nuestro PJ y se
        //abre el form "ViewPjForm" con su 2do constructor.
        //--------------------------

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (checkedBts == 2 || hero.Species==Species.Human)
            {

                //---------------------
                //Add Archetype Pts
                //---------------------

                if (this.perceptionRadio.Checked)
                {
                    hero.Perception++;
                }
                else if (this.dexterityRadio.Checked)
                {
                    hero.Dexterity++;
                }
                else if (this.strengthRadio.Checked)
                {
                    hero.Strength++;
                }
                else if (this.charismaRadio.Checked)
                {
                    hero.Charisma++;
                }
                else if (this.constitutionRadio.Checked)
                {
                    hero.Constitution++;
                }
                else if (this.willRadio.Checked)
                {
                    hero.Will++;
                }
                else if (this.knowledgeRadio.Checked)
                {
                    hero.Knowledge++;
                }

                //---------------------
                //Add Species Pts
                //---------------------

                if (perceptionBtn.Checked)
                {
                    hero.Perception++;
                }
                if (dexterityBtn.Checked)
                {
                    hero.Dexterity++;
                }
                if (strengthBtn.Checked)
                {
                    hero.Strength++;
                }
                if (charismaBtn.Checked)
                {
                    hero.Charisma++;
                }
                if (constitutionBtn.Checked)
                {
                    hero.Constitution++;
                }
                if (willBtn.Checked)
                {
                    hero.Will++;
                }
                if (knowledgeBtn.Checked)
                {
                    hero.Knowledge++;
                }
                if (agilityBtn.Checked)
                {
                    hero.Agility++;
                }
                //------------------------------------
                //------------------------------------
                //HORRIBLE(refactorear)---------------
                //------------------------------------

                ViewPjForm viewPjForm = new ViewPjForm(hero, this, pjCreationForm);
                viewPjForm.Show();
                
            }
            else
            {
                MessageBox.Show("You have to choose 2 aditional pts in Species panel");
            }
        }
        
    }
}
