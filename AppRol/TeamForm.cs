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
    public partial class TeamForm : Form
    {
        //En este formulario se permiten ver los personajes creados
        //asi como tambien eliminarlos.

        HeroDAO heroDAO = new HeroDAO();
        public TeamForm()
        {
            //En su constructor muestra la tabla de PJs
            //leida en HeroDAO en forma de listbox
            InitializeComponent();
            this.teamListBox.DataSource = heroDAO.SelectPJs();
            this.teamListBox.DisplayMember = "fullName";
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            HeroDAO heroDAO = new HeroDAO();
            var selectedItem = this.teamListBox.SelectedItem;
            if (selectedItem != null)
            {
                heroDAO.erasePj(selectedItem);
                this.teamListBox.DataSource = heroDAO.SelectPJs();
            }
            else
            {
                MessageBox.Show("Select a PJ to erase");
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            //Se muestra el PJ seleccionado en un nuevo viewPjForm
            //llamado con el constructor de un solo parametro.
            HeroDAO heroDAO = new HeroDAO();
            var selectedItem = this.teamListBox.SelectedItem;
            if (selectedItem != null)
            {
                ViewPjForm viewPjForm = new ViewPjForm((Hero)selectedItem);
                viewPjForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a PJ to display");
            }
        }
    }
}
