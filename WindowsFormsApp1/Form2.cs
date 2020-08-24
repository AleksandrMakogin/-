using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 form1;
        TextBox textBox;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
            form1 = f;
                      
        }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Text = "TEST";
            textBox = new TextBox();
            textBox.BackColor = Color.Yellow;
            textBox.Dock = DockStyle.Bottom;
            textBox.Multiline = true;
            textBox.Font = new Font(textBox.Font, textBox.Font.Style);
            textBox.Text = form1.Text;
            this.Controls.Add(textBox);
            Button but_Close = new Button();
            this.Controls.Add(but_Close);
            but_Close.Text = "CLOSE";
            but_Close.BackColor = Color.Green;
            but_Close.Location = new Point(Left);
            but_Close.Click += new EventHandler(but_CloseClick);

        }
        private void but_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
