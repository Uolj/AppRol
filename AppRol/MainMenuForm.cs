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
    public delegate void CloseCallback();
    public partial class MainMenuForm : Form
    {
        //Form de menu principal: desde aca se podra crear un PJ para jugar al juego de rol
        //"Deus Ex Machina". 
        //Tambien se podra ver/eliminar los PJs que ya hemos creado
        public MainMenuForm()
        {
            InitializeComponent();
        }

        //con el boton "create" se accede a la creacion de un PJ
        private void createBtn_Click(object sender, EventArgs e)
        {
            PjCreationForm pjCreationForm = new PjCreationForm();
            
            pjCreationForm.ShowDialog();

        }

        //con el boton "my team" se accede a los PJs ya creados
        private void viewTeamBtn_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            teamForm.ShowDialog();
        }
    }
}
