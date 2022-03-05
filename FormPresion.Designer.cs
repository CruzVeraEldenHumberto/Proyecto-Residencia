
namespace Therapheye
{
    partial class FormPresion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.controlMasajeCuenca1 = new Therapheye.ControlMasajeCuenca();
            this.controlMasajeGlobo1 = new Therapheye.ControlMasajeGlobo();
            this.controlPresionMano1 = new Therapheye.ControlPresionMano();
            this.controlPresionSimple1 = new Therapheye.ControlPresionSimple();
            this.controlPresionCuenca1 = new Therapheye.ControlPresionCuenca();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 486);
            this.panel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SidePanel.Location = new System.Drawing.Point(7, 69);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(9, 63);
            this.SidePanel.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(23, 350);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "Masaje Cuenca";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 279);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "Masaje en Globos oculares";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(23, 209);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Presión con pulgar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Presión con la mano";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Presión Simple";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(278, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 36);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Seleccione una de las opciones del menu lateral";
            // 
            // controlMasajeCuenca1
            // 
            this.controlMasajeCuenca1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlMasajeCuenca1.Location = new System.Drawing.Point(269, -1);
            this.controlMasajeCuenca1.Name = "controlMasajeCuenca1";
            this.controlMasajeCuenca1.Size = new System.Drawing.Size(993, 487);
            this.controlMasajeCuenca1.TabIndex = 6;
            this.controlMasajeCuenca1.Visible = false;
            // 
            // controlMasajeGlobo1
            // 
            this.controlMasajeGlobo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlMasajeGlobo1.Location = new System.Drawing.Point(269, -1);
            this.controlMasajeGlobo1.Name = "controlMasajeGlobo1";
            this.controlMasajeGlobo1.Size = new System.Drawing.Size(993, 487);
            this.controlMasajeGlobo1.TabIndex = 5;
            this.controlMasajeGlobo1.Visible = false;
            // 
            // controlPresionMano1
            // 
            this.controlPresionMano1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlPresionMano1.Location = new System.Drawing.Point(269, -1);
            this.controlPresionMano1.Name = "controlPresionMano1";
            this.controlPresionMano1.Size = new System.Drawing.Size(993, 487);
            this.controlPresionMano1.TabIndex = 3;
            this.controlPresionMano1.Visible = false;
            // 
            // controlPresionSimple1
            // 
            this.controlPresionSimple1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlPresionSimple1.Location = new System.Drawing.Point(269, 0);
            this.controlPresionSimple1.Name = "controlPresionSimple1";
            this.controlPresionSimple1.Size = new System.Drawing.Size(993, 487);
            this.controlPresionSimple1.TabIndex = 2;
            this.controlPresionSimple1.Visible = false;
            this.controlPresionSimple1.Load += new System.EventHandler(this.controlPresionSimple1_Load);
            // 
            // controlPresionCuenca1
            // 
            this.controlPresionCuenca1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlPresionCuenca1.Location = new System.Drawing.Point(269, -1);
            this.controlPresionCuenca1.Name = "controlPresionCuenca1";
            this.controlPresionCuenca1.Size = new System.Drawing.Size(993, 487);
            this.controlPresionCuenca1.TabIndex = 4;
            this.controlPresionCuenca1.Visible = false;
            // 
            // FormPresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 486);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.controlMasajeCuenca1);
            this.Controls.Add(this.controlMasajeGlobo1);
            this.Controls.Add(this.controlPresionMano1);
            this.Controls.Add(this.controlPresionSimple1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPresionCuenca1);
            this.Name = "FormPresion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicios de Presión";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ControlPresionSimple controlPresionSimple1;
        private ControlPresionMano controlPresionMano1;
        private ControlPresionCuenca controlPresionCuenca1;
        private ControlMasajeGlobo controlMasajeGlobo1;
        private ControlMasajeCuenca controlMasajeCuenca1;
        private System.Windows.Forms.TextBox textBox1;
    }
}