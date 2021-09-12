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
using System.Security.Cryptography;
using System.Diagnostics;

namespace CharacterCounter
{
    internal class Counter
    {
        private static string[] allowedFileEXT = new string[] { ".pdf", ".docx", ".txt", };

        public static DialogResult Counting(string character, string documentname)
        {
            int count = 0;
            string fileEXT = System.IO.Path.GetExtension(documentname);

            if (allowedFileEXT.Contains(fileEXT))
            {
                try
                {
                    string text = File.ReadAllText(documentname);
                    foreach (char c in text)
                    {
                        if (c.ToString() == character.ToLower() || c.ToString() == character) count++;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception: " + e.Message);
                }
                return MessageBox.Show("Er zit " + count.ToString() + " keer de letter " + character + " in");
            }
            else
            {
                return MessageBox.Show("Sorry, this file type is not allowed");
            }
        }
    }
}