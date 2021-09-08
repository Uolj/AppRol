using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace AppRol
{
    public partial class PjCreationForm : Form
    {
        //Form de menu de creacion de PJ;
        //Desde aqui se podra crear un personaje eligiendole un nombre,
        //su especie, su arquetipo, 2 atributos(cuerpo/mente) y
        //8 rasgos (4 de cada atributo) 

        //Lista de todas las cajas de texto presentes en el formulario
        private List<TextBox> textBoxes = new List<TextBox>();
        private HeroDAO heroDAO;

        //Esencia
        private int essence = 15;
        public int Essence
        {
            get
            {
                return essence;
            }
            set
            {
                this.essence = value;
            }
        }

        //------------CTOR-----------//
        public PjCreationForm()
        {
            //en el constructor del formulario agrego todas las cajas
            //de texto a mi lista para que sea mas facil la suscripcion
            //de eventos
            InitializeComponent();
            textBoxes.Add(this.bodyTxtBox);
            textBoxes.Add(this.mindTxtBox);
            textBoxes.Add(this.agilityTxtBox);
            textBoxes.Add(this.dexterityTxtBox);
            textBoxes.Add(this.strengthTxtBox);
            textBoxes.Add(this.constitutionTxtBox);
            textBoxes.Add(this.perceptionTxtBox);
            textBoxes.Add(this.charismaTxtBox);
            textBoxes.Add(this.willTxtBox);
            textBoxes.Add(this.knowledgeTxtBox);

            foreach (TextBox item in this.textBoxes)
            {
                item.TextChanged += pointsCheck;
                item.TextChanged += essenceCheck;
            }

            this.essenceAmount.Text = this.Essence.ToString();
            this.speciesCombo.DataSource = Enum.GetValues(typeof(Species));
            this.archetypeCombo.DataSource = Enum.GetValues(typeof(Archetype));
        }

        ///////////////////////////////////
        //EVENTHANDLER DE CIERRE AUTOMATICO:
        public void PjCreationForm_closeForms()
        {
            this.Close();
        }

        ////////////////////////////////////
        //EVENTHANDLER DE CONTROL DE PUNTOS:
        private void pointsCheck(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = "1";
            }
            else
            {
                if (int.Parse(((TextBox)sender).Text) < 1 || int.Parse(((TextBox)sender).Text) > 4)
                {
                    ((TextBox)sender).Text = "1";
                    MessageBox.Show("En periodo de creacion, el valor del rasgo no puede ser menor a 1 ni mayor a 4.");
                }
            }
        }

        /////////////////////////////////////////////////
        ///EVENTHANDLER DE CONTROL DE ESENCIA:
        ///la esencia inicial es de 15 puntos, estos son los puntos que se podran
        ///distribuir entre los rasgos y atributos, por lo tanto no pueden ser superados.
        private void essenceCheck(object sender, EventArgs e)
        {
            int txtBoxPts = int.Parse(((TextBox)sender).Text);
            int counter = 0;
            this.Essence = 15;

            //Para controlar la esencia, en cada cambio reinicio dicho atributo 
            //y recorro todas las txtBoxes controlando que no se supere la cantidad
            //disponible.
            foreach (TextBox item in this.textBoxes)
            {
                counter += (int.Parse(item.Text) - 1);
            }
            this.Essence -= counter;

            //En caso de ser superada, revierto el ultimo cambio,
            //reiniciando la caja en la que sucedio, y devolviendo sus pts a la esencia
            if (this.Essence >= 0)
            {
                this.essenceAmount.Text = this.Essence.ToString();
            }
            else
            {
                this.Essence += (txtBoxPts - 1);
                ((TextBox)sender).Text = "1";
                this.essenceAmount.Text = this.Essence.ToString();
                MessageBox.Show("Se supero la cantidad de Esencia disponible");
            }
        }

        //SELECTOR DE ESPECIES: se muestra informacion sobre puntos adicionales relacionados con la especie.
        //refactorear
        private void specieCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (speciesCombo.SelectedItem == speciesCombo.Items[0])
            {
                this.speciesCommentaryTxtBox.Text = "Human species has no aditional points";
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[1])
            {
                speciesCommentaryTxtBoxContent("AGI / DEXT / PER / WILL");
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[2])
            {
                speciesCommentaryTxtBoxContent("AGI / DEXT / PER / KLDG");
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[3])
            {
                speciesCommentaryTxtBoxContent("AGI / DEXT / PER / CHAR");
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[4])
            {
                speciesCommentaryTxtBoxContent("DEXT / STRG / CON / KLDG");
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[5])
            {
                speciesCommentaryTxtBoxContent("STRG / CON / KLDG / WILL");
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[6])
            {
                speciesCommentaryTxtBoxContent("AGI / DEXT / STRG / PER");
            }
            else if (speciesCombo.SelectedItem == speciesCombo.Items[7])
            {
                speciesCommentaryTxtBoxContent("DEXT / PER / INT / WILL");
            }
        }

        //SELECTOR DE ARQUETIPOS: se muestra informacion sobre puntos adicionales relacionados con el arquetipo.
        //refactorear

        private void archetypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (archetypeCombo.SelectedItem == archetypeCombo.Items[0])
            {
                archCommentaryTxtBoxContent("DEXT/WILL/CON or STRG");
            }
            else if (archetypeCombo.SelectedItem == archetypeCombo.Items[1])
            {
                archCommentaryTxtBoxContent("KLDG/WILL/DEXT or CHAR");
            }
            else if (archetypeCombo.SelectedItem == archetypeCombo.Items[2])
            {
                archCommentaryTxtBoxContent("DEXT/AGI/PER or WILL");
            }
            else if (archetypeCombo.SelectedItem == archetypeCombo.Items[3])
            {
                archCommentaryTxtBoxContent("PER/CHAR/KLDG or WILL");
            }
            else if (archetypeCombo.SelectedItem == archetypeCombo.Items[4])
            {
                archCommentaryTxtBoxContent("only one attribute that you choose");
            }
        }

        ////////////////////////////////////////////
        //BOTON SUBMIT: 
        ////////////////////////////////////////////
        //Con este boton se crea al personaje en cuestion, reune los
        //atributos/rasgos/nombre y los asigna a un objeto hijo de la clase "Hero"
        //la designacion del tipo de objeto lo define la funcion "crearPj<T>", en 
        //base a lo elegido en la caja de "Species".
        //Creado el objeto, se lo pasa como parametro al siguiente form y lo abre.
        ////////////////////////////////////////////  

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var selectedSpecies = this.speciesCombo.SelectedItem;
            if (nameCheck(this.nameTxtBox.Text.TrimStart()))
            {
                if (selectedSpecies == speciesCombo.Items[0])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Human>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[1])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Draesirian>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[2])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Elf>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[3])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Faerya>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[4])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Dwarf>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[5])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Khraldar>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[6])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Wolvem>(), this);
                    aditionalPointsForm.Show();
                }
                else if (selectedSpecies == speciesCombo.Items[7])
                {
                    AditionalPtsForm aditionalPointsForm = new AditionalPtsForm(crearPj<Silen>(), this);
                    aditionalPointsForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Your name is already chosed");
            }
        }

        //Funcion para chequear si el nombre ya se encuentra usado por otro PJ.
        private bool nameCheck(string name)
        {
            this.heroDAO = new HeroDAO();
            foreach (Hero item in heroDAO.SelectPJs())
            {
                if (name == item.FullName)
                {
                    return false;
                }
            }
            return true;
        }

        //////////////////////////////////////////////////////////
        //2 Funciones para mostrar informacion en cajas inferiores:
        private void speciesCommentaryTxtBoxContent(string attributes)
        {
            this.speciesCommentaryTxtBox.Text = $"{this.speciesCombo.SelectedItem} Species aditional point in  {attributes} (you can only choose 2)";
        }
        private void archCommentaryTxtBoxContent(string attributes)
        {
            this.archCommentaryTxtBox.Text = $"{this.archetypeCombo.SelectedItem} Archetype aditional point in  {attributes}";
        }

        //////////////////////////
        //FUNCION CREADORA DE PJS:
        //recibe un tipo generico (que hereda de Hero) y crea un PJ
        //con el contenido de las cajas del form
        public T crearPj<T>() where T : Hero, new()
        {
            T createdPj = (T)Activator.CreateInstance(typeof(T), new object[] {this.nameTxtBox.Text,
                this.archetypeCombo.SelectedItem, int.Parse(this.bodyTxtBox.Text),
                int.Parse(this.agilityTxtBox.Text), int.Parse(this.dexterityTxtBox.Text), int.Parse(this.strengthTxtBox.Text),
                int.Parse(this.constitutionTxtBox.Text), int.Parse(this.mindTxtBox.Text), int.Parse(this.perceptionTxtBox.Text),
                int.Parse(this.charismaTxtBox.Text), int.Parse(this.willTxtBox.Text), int.Parse(this.knowledgeTxtBox.Text) });
            return createdPj;
        }
    }
}

