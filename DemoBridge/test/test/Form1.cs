using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            System.Drawing.Graphics graphicsObj = panel1.CreateGraphics();

            graphicsObj.Clear(Color.FromArgb(224, 224, 224));

            var blue_color = new Blue();
            var red_color = new Red();

            Shape square;
            Shape circle;

            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                square = new Square { color = red_color };
                square.drawShape(graphicsObj);
            }
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                square = new Square { color = blue_color };
                square.drawShape(graphicsObj);
            }
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                circle = new Circle { color = red_color };
                circle.drawShape(graphicsObj);
            }
            else if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                circle = new Circle { color = blue_color };
                circle.drawShape(graphicsObj);
            }
        }
    }
}
