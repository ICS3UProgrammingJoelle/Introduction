/*
 * Created by: Joelle Ishimwe
 * Created on: 11-Feb.-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Name of Program
 * This program displays the language that is clicked by the user
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            //translate to Enshish
            lblHelloWorld.Text = "Hello World!";
        }

        private void RadFrançais_CheckedChanged(object sender, EventArgs e)
        {
            //translate to French
            lblHelloWorld.Text = "Bonjour, le Monde!";
        }

        private void RadEspañol_CheckedChanged(object sender, EventArgs e)
        {
            //translate to Spanish
            lblHelloWorld.Text = "Hola, Monda!"; 
        }

        private void RadTürk_CheckedChanged(object sender, EventArgs e)
        {
            //translate to Turkish
            lblHelloWorld.Text = "Selam Dünya!";
        }
    }
}
