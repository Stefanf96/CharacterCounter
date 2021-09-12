using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CharacterCounter
{
    public partial class Form1 : Form
    {
        private string OpenOnLocation = @"D:\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = OpenOnLocation;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentName.Text = fileDialog.FileName.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alpha = alphabet.ToCharArray();
            foreach (char letter in alpha)
            {
                CharComboBox.Items.Add(letter);
            }
        }

        private void CheckCharacterCount_Click(object sender, EventArgs e)
        {
            string DocName = DocumentName.Text;
            string character = CharComboBox.SelectedItem.ToString();
            Counter.Counting(character, DocName);
        }
    }
}