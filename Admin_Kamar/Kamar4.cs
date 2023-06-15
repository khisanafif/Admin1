using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;

namespace Admin_Kamar
{
    public partial class Kamar4 : Form
    {
        private Size formOriginalSize;
        private Rectangle recpanel1;
        private Rectangle recpanel14;
        private Rectangle recpictureBox3;
        private Rectangle recpictureBox2;
        private Rectangle recpictureBox1;
        private Rectangle rectableLayoutPanel1;
        private Rectangle recpanel8;
        private Rectangle recbutton6;
        private Rectangle reclabel6;
        private Rectangle reccomboBox6;
        private Rectangle recpanel5;
        private Rectangle recbutton3;
        private Rectangle reclabel3;
        private Rectangle reccomboBox3;
        private Rectangle recpanel2;
        private Rectangle recbutton7;
        private Rectangle reclabel8;
        private Rectangle reccomboBox7;
        private Rectangle recpanel3;
        private Rectangle recbutton1;
        private Rectangle reclabel1;
        private Rectangle reccomboBox1;
        private Rectangle recpanel4;
        private Rectangle recbutton2;
        private Rectangle reclabel2;
        private Rectangle reccomboBox2;
        private Rectangle recpanel9;
        private Rectangle recbutton8;
        private Rectangle reclabel7;
        private Rectangle reccombobox4;
        private Rectangle recpanel10;
        private Rectangle recbutton9;
        private Rectangle reclabel9;
        private Rectangle reccomboBox9;
        private Rectangle recpanel11;
        private Rectangle recbutton10;
        private Rectangle reclabel10;
        private Rectangle reccomboBox10;
        private Rectangle rectableLayoutPanel2;
        private Rectangle recpanel6;
        private Rectangle recbutton4;
        private Rectangle reclabel4;
        private Rectangle reccombobox8;
        private Rectangle recpanel7;
        private Rectangle recbutton5;
        private Rectangle reclabel5;
        private Rectangle reccombobox5;
        private Rectangle reclabel15;
        private Rectangle recpanel16;
        private Rectangle recbutton14;
        private Rectangle reclabel14;
        private Rectangle reccombobox14;
        private Rectangle recpanel13;
        private Rectangle recbutton12;
        private Rectangle reclabel12;
        private Rectangle reccombobox12;
        private Rectangle recpanel12;
        private Rectangle recbutton11;
        private Rectangle reclabel11;
        private Rectangle reccombobox11;
        private Rectangle recpanel15;
        private Rectangle recbutton13;
        private Rectangle reclabel13;
        private Rectangle reccombobox13;
        public Kamar4()
        {
            InitializeComponent();
            this.Resize += Kamar4_Resize;
            formOriginalSize = this.Size;
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpanel14 = new Rectangle(panel14.Location, panel14.Size);
            recbutton1 = new Rectangle(button1.Location, button1.Size);
            recbutton10 = new Rectangle(button10.Location, button10.Size);
            recbutton11 = new Rectangle(button11.Location, button11.Size);
            recbutton12 = new Rectangle(button12.Location, button12.Size);
            recbutton13 = new Rectangle(button13.Location, button13.Size);
            recbutton14 = new Rectangle(button14.Location, button14.Size);
            recbutton2 = new Rectangle(button2.Location, button2.Size);
            recbutton3 = new Rectangle(button3.Location, button3.Size);
            //recbutton4 = new Rectangle(button4.Location, button4.Size);
            //recbutton5 = new Rectangle(button5.Location, button5.Size);
            recbutton6 = new Rectangle(button6.Location, button6.Size);
            recbutton7 = new Rectangle(button7.Location, button7.Size);
            recbutton8 = new Rectangle(button8.Location, button8.Size);
            recbutton9 = new Rectangle(button9.Location, button9.Size);
            reccomboBox1 = new Rectangle(comboBox1.Location, comboBox1.Size);
            reccomboBox10 = new Rectangle(comboBox10.Location, comboBox10.Size);
            reccombobox11 = new Rectangle(comboBox11.Location, comboBox11.Size);
            reccombobox12 = new Rectangle(comboBox12.Location, comboBox12.Size);
            reccombobox13 = new Rectangle(comboBox13.Location, comboBox13.Size);
            reccombobox14 = new Rectangle(comboBox14.Location, comboBox14.Size);
            reccomboBox2 = new Rectangle(comboBox2.Location, comboBox2.Size);
            reccomboBox3 = new Rectangle(comboBox3.Location, comboBox3.Size);
            //reccombobox4 = new Rectangle(comboBox4.Location, comboBox4.Size);
            //reccombobox5 = new Rectangle(comboBox5.Location, comboBox5.Size);
            reccomboBox6 = new Rectangle(comboBox6.Location, comboBox6.Size);
            reccomboBox7 = new Rectangle(comboBox7.Location, comboBox7.Size);
            reccombobox8 = new Rectangle(comboBox8.Location, comboBox8.Size);
            reccomboBox9 = new Rectangle(comboBox9.Location, comboBox9.Size);
            reclabel1 = new Rectangle(label1.Location, label1.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            reclabel13 = new Rectangle(label13.Location, label13.Size);
            reclabel14 = new Rectangle(label14.Location, label14.Size);
            reclabel15 = new Rectangle(label15.Location, label15.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            //reclabel4 = new Rectangle(label4.Location, label4.Size);
            //reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpanel10 = new Rectangle(panel10.Location, panel10.Size);
            recpanel11 = new Rectangle(panel11.Location, panel11.Size);
            recpanel12 = new Rectangle(panel12.Location, panel12.Size);
            recpanel13 = new Rectangle(panel13.Location, panel13.Size);
            recpanel14 = new Rectangle(panel14.Location, panel14.Size);
            recpanel15 = new Rectangle(panel15.Location, panel15.Size);
            recpanel16 = new Rectangle(panel16.Location, panel16.Size);
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            recpanel4 = new Rectangle(panel4.Location, panel4.Size);
            recpanel5 = new Rectangle(panel5.Location, panel5.Size);
            //recpanel6 = new Rectangle(panel6.Location, panel6.Size);
            //recpanel7 = new Rectangle(panel7.Location, panel7.Size);
            recpanel8 = new Rectangle(panel8.Location, panel8.Size);
            recpanel9 = new Rectangle(panel9.Location, panel9.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpictureBox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpictureBox3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            rectableLayoutPanel1 = new Rectangle(tableLayoutPanel1.Location, tableLayoutPanel1.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpictureBox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpictureBox3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);


        }

        private void Kamar4_Resize(object sender, EventArgs e)
        {
            resize_Control(panel13, recpanel13);
            resize_Control(panel14, recpanel14);
            resize_Control(panel15, recpanel15);
            resize_Control(panel16, recpanel16);
            resize_Control(panel1, recpanel1);
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
            resize_Control(panel4, recpanel4);
            resize_Control(panel5, recpanel5);
            //resize_Control(panel6, recpanel6);
            //resize_Control(panel7, recpanel7);
            resize_Control(panel8, recpanel8);
            resize_Control(panel9, recpanel9);
            resize_Control(panel10, recpanel10);
            resize_Control(panel11, recpanel11);
            resize_Control(panel12, recpanel12);
            resize_Control(button1, recbutton1);
            resize_Control(button2, recbutton2);
            resize_Control(button3, recbutton3);
            //resize_Control(button4, recbutton4);
            // resize_Control(button5, recbutton5);
            resize_Control(button6, recbutton6);
            resize_Control(button7, recbutton7);
            resize_Control(button8, recbutton8);
            resize_Control(button9, recbutton9);
            resize_Control(button10, recbutton10);
            resize_Control(button11, recbutton11);
            resize_Control(button12, recbutton12);
            resize_Control(button13, recbutton13);
            resize_Control(button14, recbutton14);
            resize_Control(label1, reclabel1);
            resize_Control(label2, reclabel2);
            resize_Control(label3, reclabel3);
            //resize_Control(label4, reclabel4);
            //resize_Control(label5, reclabel5);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(label14, reclabel14);
            resize_Control(label15, reclabel15);
            resize_Control(tableLayoutPanel1, rectableLayoutPanel1);
            //resize_Control(tableLayoutPanel2, rectableLayoutPanel2);
            resize_Control(comboBox1, reccomboBox1);
            resize_Control(comboBox2, reccomboBox2);
            resize_Control(comboBox3, reccomboBox3);
            resize_Control(comboBox3, reccomboBox3);
            //resize_Control(comboBox4, reccombobox4);
            resize_Control(comboBox6, reccomboBox6);
            resize_Control(comboBox7, reccomboBox7);
            resize_Control(comboBox8, reccombobox8);
            resize_Control(comboBox9, reccomboBox9);
            resize_Control(comboBox10, reccomboBox10);
            resize_Control(comboBox11, reccombobox11);
            resize_Control(comboBox12, reccombobox12);
            resize_Control(comboBox13, reccombobox13);
            resize_Control(comboBox14, reccombobox14);
            //resize_Control(comboBox5, reccombobox5);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(pictureBox2, recpictureBox2);
            resize_Control(pictureBox3, recpictureBox3);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
