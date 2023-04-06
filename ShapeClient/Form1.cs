using System;
using System.Linq;
using System.Windows.Forms;

namespace ShapeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = client
            comboBox1.Items.Add("Circle");
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Square");
            comboBox1.Items.Add("Triangle");

            param1.Visible = false;
            param2.Visible = false;
            param3.Visible = false;
            paraml1.Visible = false;
            paraml2.Visible = false;
            paraml3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            param1.Visible = false;
            param2.Visible = false;
            param3.Visible = false;
            paraml1.Visible = false;
            paraml2.Visible = false;
            paraml3.Visible = false;

            switch (this.comboBox1.Text)
            {
                case "Circle":
                    param1.Visible = true;
                    paraml1.Visible = true;
                    paraml1.Text = "Radius";

                    break;
                case "Rectangle":
                    param1.Visible = true;
                    param2.Visible = true;
                    paraml1.Visible = true;
                    paraml2.Visible = true;
                    paraml1.Text = "Length";
                    paraml2.Text = "Width";
                    break;
                case "Square":
                    param1.Visible = true;
                    paraml1.Visible = true;
                    paraml1.Text = "Length";
                    break;
                case "Triangle":
                    param1.Visible = true;
                    param2.Visible = true;
                    param3.Visible = true;
                    paraml1.Visible = true;
                    paraml2.Visible = true;
                    paraml3.Visible = true;
                    paraml1.Text = "Length 1";
                    paraml2.Text = "Length 2";
                    paraml3.Text = "Length 3";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShapeServiceReference.ShapeServiceSoapClient client = new ShapeServiceReference.ShapeServiceSoapClient();
            this.result.Text = client.ComputePerimeter(this.comboBox1.Text, param1.Text, param2.Text, param3.Text).ToString();
        }
    }
}
