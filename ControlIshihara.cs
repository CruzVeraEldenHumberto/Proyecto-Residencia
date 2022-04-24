﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Therapheye
{
    public partial class ControlIshihara : UserControl
    {
        public string Resp1;
        public string Resp2;
        public string Resp3;
        public string Resp4;
        public string Resp5;
        public string Resp6;
        public string Resp7;
        public string Resp8;
        public string DTNow;
        public int IDUser; //id del usuario
        public string Datetime; //variable datetime para obtener fecha actual
        Database databaseobject = new Database();

        public ControlIshihara()
        {
            InitializeComponent();
        }

        private void ControlIshihara_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            pictureBox5.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox6.BringToFront();
            pictureBox6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVisNoc.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "12")
            {
                textBox2.BackColor = Color.Green;
                Resp1 = Correct();
            }
            else
            {
                textBox2.BackColor = Color.Red;
                Resp1 = Incorrect();
            }

            if (textBox3.Text == "74")
            {
                textBox3.BackColor = Color.Green;
                Resp2 = Correct();
            }
            else
            {
                textBox3.BackColor = Color.Red;
                Resp2 = Incorrect();
            }

            if (textBox4.Text == "6")
            {
                textBox4.BackColor = Color.Green;
                Resp3 = Correct();
            }
            else
            {
                textBox4.BackColor = Color.Red;
                Resp3 = Incorrect();
            }

            if (textBox5.Text == "16")
            {
                textBox5.BackColor = Color.Green;
                Resp4 = Correct();
            }
            else
            {
                textBox5.BackColor = Color.Red;
                Resp4 = Incorrect();
            }

            if (textBox6.Text == "2")
            {
                textBox6.BackColor = Color.Green;
                Resp5 = Correct();
            }
            else
            {
                textBox6.BackColor = Color.Red;
                Resp5 = Incorrect();
            }

            if (textBox7.Text == "29")
            {
                textBox7.BackColor = Color.Green;
                Resp6 = Correct();
            }
            else
            {
                textBox7.BackColor = Color.Red;
                Resp6 = Incorrect();
            }

            if (textBox2.BackColor == Color.Green &&
                textBox3.BackColor == Color.Green &&
                textBox4.BackColor == Color.Green &&
                textBox5.BackColor == Color.Green &&
                textBox6.BackColor == Color.Green &&
                textBox7.BackColor == Color.Green) 
            {
                MessageBox.Show("Ha concluido el test de Ishihara satisfactoriamente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            InsertRespuestas();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            pictureBox5.Visible = true;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.BringToFront();
            pictureBox6.Visible = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }
       

        private void textBox6_KeyDown_1(object sender, KeyEventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void textBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        public void InsertRespuestas()
        {
            DBValue idval = new DBValue();
            IDUser = idval.IDValue(1);

            string query = "INSERT INTO Ejercicio_Vision_Color ('Id_Usuario', 'Fecha_Hora', 'Primer_Respuesta', 'Segunda_Respuesta', 'Tercer_Respuesta', 'Cuarta_Respuesta', 'Quinta_Respuesta', 'Sexta_Respuesta') VALUES (@IDU, @Timestamp, @R1, @R2, @R3, @R4, @R5, @R6)";
            SQLiteCommand mycommand = new SQLiteCommand(query, databaseobject.myConnection);

            databaseobject.OpenConnection();

            DTNow = databaseobject.GetDateTime();

            mycommand.Parameters.AddWithValue("@IDU", IDUser);
            mycommand.Parameters.AddWithValue("@Timestamp", DTNow);
            mycommand.Parameters.AddWithValue("@R1", Resp1);
            mycommand.Parameters.AddWithValue("@R2", Resp2);
            mycommand.Parameters.AddWithValue("@R3", Resp3);
            mycommand.Parameters.AddWithValue("@R4", Resp4);
            mycommand.Parameters.AddWithValue("@R5", Resp5);
            mycommand.Parameters.AddWithValue("@R6", Resp6);

            mycommand.ExecuteNonQuery();

        }

        public string Correct()
        {
            return "Correcta";
        }

        public string Incorrect()
        {
            return "Incorrecta";
        }
    }
}
