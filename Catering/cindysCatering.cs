using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
 * @author Julio Paniagua
 * */
namespace Catering
{
    public partial class cindysCatering : Form
    {
        public cindysCatering()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox items = (CheckedListBox)sender;
            if (items.CheckedItems.Count > 1)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guestsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsLetter(e.KeyChar)|| char.IsSymbol(e.KeyChar))
            {
                errorProvider1.SetError(label1, "Numbers Only");
                label1.Text = "Numbers Only";
            }
            else {
                errorProvider1.SetError(label1, "");
                label1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                errorProvider1.SetError(label2, "Numbers Only");
                label2.Text = "Numbers Only";
            }
            else
            {
                errorProvider1.SetError(label2, "");
                label2.Text = "";
            }
        }

        private void submitEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Amount: $" + double.Parse(guestsTextBox.Text) * 35.00);
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Event\\" + customerNameTextBox.Text + ".txt"); //writing a separate file for every customer
            string s = "";
            for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            {
                s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + " ";
            }

            sw.WriteLine(customerName.Text + ": "+ customerNameTextBox.Text);
            sw.WriteLine(customerPhoneNumber.Text + ": " + phoneNumberTextBox.Text);
            sw.WriteLine(numOfGuests.Text + ": " + guestsTextBox.Text);
            sw.WriteLine(entree.Text + ": " + entreeComboBox.SelectedItem.ToString());
            sw.WriteLine(sides.Text + ": " + s);
            sw.WriteLine(desserts.Text + ": " + dessertComboBox.SelectedItem.ToString());
            sw.Close();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Event\\" + customerNameTextBox.Text + ".txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
