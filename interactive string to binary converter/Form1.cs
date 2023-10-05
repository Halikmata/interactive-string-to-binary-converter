using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interactive_string_to_binary_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string input_text = txt_input.Text, output_text = "";

        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            int length = txt_input.TextLength;

            //txt_output.Text = length.ToString();

            for (int i = 0; i < length; i++)
            {
                char character = txt_input.Text[i];
                string asciival = "";

                switch (character)
                {
                    case 'A':
                        asciival = "00110000";
                        break;

                    case 'B':
                        asciival = "00110000";
                        break;

                    case 'C':
                        asciival = "00110000";
                        break;

                    case 'D':
                        asciival = "00110000";
                        break;

                    case 'E':
                        asciival = "00110000";
                        break;

                    case 'F':
                        asciival = "00110000";
                        break;

                    case 'G':
                        asciival = "00110000";
                        break;

                    case 'H':
                        asciival = "00110000";
                        break;

                    case 'I':
                        asciival = "00110000";
                        break;

                    case 'J':
                        asciival = "00110000";
                        break;

                    case 'K':
                        asciival = "00110000";
                        break;

                    case 'L':
                        asciival = "00110000";
                        break;

                    case 'M':
                        asciival = "00110000";
                        break;

                    case 'N':
                        asciival = "00110000";
                        break;

                    case 'O':
                        asciival = "00110000";
                        break;

                    case 'P':
                        asciival = "00110000";
                        break;

                    case 'Q':
                        asciival = "00110000";
                        break;

                    case 'R':
                        asciival = "00110000";
                        break;

                    case 'S':
                        asciival = "00110000";
                        break;

                    case 'T':
                        asciival = "00110000";
                        break;

                    case 'U':
                        asciival = "00110000";
                        break;

                    case 'V':
                        asciival = "00110000";
                        break;

                    case 'W':
                        asciival = "00110000";
                        break;

                    case 'X':
                        asciival = "00110000";
                        break;

                    case 'Y':
                        asciival = "00110000";
                        break;

                    case 'Z':
                        asciival = "00110000";
                        break;



                    default:
                        break;
                }
            }
        }
    }
}
