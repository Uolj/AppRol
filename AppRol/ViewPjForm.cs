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
    public partial class ViewPjForm : Form
    {
        //evento "closeForms" para cierre automatico de los anteriores forms
        public event CloseCallback closeForms;
        public HeroDAO heroDAO;

        //CTORES----------------------------------------------------/////
        public ViewPjForm()
        {
        }
        //El primer constructor con parametro es llamado en el TeamForm,
        //ya que solo necesita recibir el PJ (objeto) a mostrar.
        public ViewPjForm(Hero hero)
        {
            InitializeComponent();
            this.nameTxtBox.Text = hero.FullName;
            this.speciesArchTxtBox.Text = hero.ToString();

            this.bodyTxtBox.Text = hero.Body.ToString();

            this.agilityTxtBox.Text = hero.Agility.ToString();
            this.dexterityTxtBox.Text = hero.Dexterity.ToString();
            this.strengthTxtBox.Text = hero.Strength.ToString();
            this.constitutionTxtBox.Text = hero.Constitution.ToString();

            this.mindTxtBox.Text = hero.Mind.ToString();

            this.perceptionTxtBox.Text = hero.Perception.ToString();
            this.charismaTxtBox.Text = hero.Charisma.ToString();
            this.willTxtBox.Text = hero.Will.ToString();
            this.knowledgeTxtBox.Text = hero.Knowledge.ToString();

            this.minLoadTxtBox.Text = hero.Load(1).ToString();
            this.medLoadTxtBox.Text = hero.Load(2).ToString();
            this.heavyLoadTxtBox.Text = hero.Load(3).ToString();

            this.vitalityTxtBox.Text = hero.Vitality.ToString();
            this.vitalityRecTxtBox.Text = hero.VitalRecovery.ToString();

            this.manaTxtBox.Text = hero.Mana.ToString();
            this.manaRecTxtBox.Text = hero.ManaRecovery.ToString();

            this.movementTxtBox.Text = hero.Movement.ToString();
            this.jumpTxtBox.Text = hero.Jump.ToString();

            this.hasteTxtBox.Text = hero.Haste.ToString();
        }
        //El 2do constructor con parametro es llamado en el AditionalPtsForm,
        //Recibe como parametros a los 2 anteriores formularios para suscribir 
        //sus eventHandlers al evento closeForms.
        //Recibe tambien el PJ(objeto) no solo para mostrarlo, sino tambien para 
        //guardarlo en una base de datos.
        public ViewPjForm(Hero hero, AditionalPtsForm aditionalPtsForm, PjCreationForm pjCreationForm) : this(hero)
        {
            this.heroDAO = new HeroDAO();
            this.heroDAO.InsertPJ(hero);

            closeForms += pjCreationForm.PjCreationForm_closeForms;
            closeForms += aditionalPtsForm.aditionalPtsForm_closeForms;
        }

        //LOAD EVENTHANDLER----------------//
        //Invoca al evento closeForms y situa al formulario en primera vista
        private void ViewPjForm_Load(object sender, EventArgs e)
        {
            closeForms?.Invoke();

            this.TopMost = true;
        }

    }
}
