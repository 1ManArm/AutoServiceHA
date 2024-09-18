using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!FSWork.IsFileExist("AutoService.db")) MakeStore();
            FillMechanicsNames();
        }
        private void MakeStore()
        {
            if (DBWork.MakeDB())
            {
                MessageBox.Show($"База данных существует");
            } ;
        }
        private void FillMechanicsNames()
        {
            foreach (string name in DBWork.GetMechanics())
            {
                cmbMechanic.Items.Add(name);
            }
        }

		private void picBoxAvatar_Click(object sender, EventArgs e)
		{
            if (cmbMechanic.SelectedItem != null)
            {
                byte[] _image = FSWork.GetImage();
                string _name = cmbMechanic.SelectedItem.ToString();
                DBWork.AddAvatar(_name, _image);
            }
		}
        private void SetImage2PictureBox()
        {
			string _name = cmbMechanic.SelectedItem.ToString();
			MemoryStream ms = DBWork.GetAvatar(_name);
            if (ms != null)
            {
                picBoxAvatar.Image =
                Image.FromStream(DBWork.GetAvatar(_name));
            }
            else 
            {
                picBoxAvatar.BackColor = Color.Black;
                picBoxAvatar.Image = null;
            } 
                

            
        }

		private void cmbMechanic_SelectedValueChanged(object sender, EventArgs e)
		{
            SetImage2PictureBox();
		}
        private DBWork dBWork = new DBWork();
        private string mechanicName;
        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            string newName = GetNewName();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                dBWork.AddMechanic(newName);
                cmbMechanic.Items.Add(newName);
            }
        }
        private string GetInput(TextBox textBox)
        {
            string input = textBox.Text.Trim();
            textBox.Clear();
            return input;
        }

        private void btnRemoveMechanic_Click(object sender, EventArgs e)
        {
            string selectedName = cmbMechanic.SelectedItem?.ToString();
            if (selectedName != null)
            {
                dBWork.RemoveMechanic(selectedName);
                cmbMechanic.Items.Remove(selectedName);
            }
        }

        private void btnEditMechanic_Click(object sender, EventArgs e)
        {
            string selectedName = cmbMechanic.SelectedItem?.ToString();
            if (selectedName != null)
            {
                string newName = GetNewName();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    dBWork.EditMechanic(selectedName, newName);
                    int selectedIndex = cmbMechanic.SelectedIndex;
                    cmbMechanic.Items[selectedIndex] = newName;
                }
            }
        }
        private string GetNewName()
        {
            using (Form inputForm = new Form())
            {
                TextBox txtNewName = new TextBox { Width = 200 };
                Button btnSubmit = new Button { Text = "OK", DialogResult = DialogResult.OK };
                inputForm.Controls.Add(txtNewName);
                inputForm.Controls.Add(btnSubmit);
                inputForm.AcceptButton = btnSubmit;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    return txtNewName.Text.Trim();
                }
            }
            return null;
        }
    }
}
