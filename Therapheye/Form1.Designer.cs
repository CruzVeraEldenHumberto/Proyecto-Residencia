
namespace Therapheye
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.controlTestFinal1 = new Therapheye.ControlTestFinal();
            this.controlEjercicios1 = new Therapheye.ControlEjercicios();
            this.controlTestInicial2 = new Therapheye.ControlTestInicial();
            this.controlInicio2 = new Therapheye.ControlInicio();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 548);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 43);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 64);
            this.SidePanel.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 16);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.panel4.Location = new System.Drawing.Point(1249, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 218);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(184, 516);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1203, 48);
            this.panel10.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Value Eye: Evaluación de Fatiga Visual y Vision Escotópica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Image = global::Therapheye.Properties.Resources.outline_check_circle_outline_white_24dp;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 66);
            this.button6.TabIndex = 5;
            this.button6.Text = " Test Final";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Image = global::Therapheye.Properties.Resources.outline_remove_red_eye_white_24dp;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ejercicios";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(6, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "  Info";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Therapheye.Properties.Resources.outline_close_white_24dp;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = " Salir";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::Therapheye.Properties.Resources.outline_flag_white_24dp;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Test Inicial";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "  Inicio";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlTestFinal1
            // 
            this.controlTestFinal1.Location = new System.Drawing.Point(214, 80);
            this.controlTestFinal1.Margin = new System.Windows.Forms.Padding(10);
            this.controlTestFinal1.Name = "controlTestFinal1";
            this.controlTestFinal1.Size = new System.Drawing.Size(1029, 364);
            this.controlTestFinal1.TabIndex = 15;
            // 
            // controlEjercicios1
            // 
            this.controlEjercicios1.Location = new System.Drawing.Point(190, 80);
            this.controlEjercicios1.Name = "controlEjercicios1";
            this.controlEjercicios1.Size = new System.Drawing.Size(1053, 430);
            this.controlEjercicios1.TabIndex = 14;
            // 
            // controlTestInicial2
            // 
            this.controlTestInicial2.Location = new System.Drawing.Point(190, 80);
            this.controlTestInicial2.Name = "controlTestInicial2";
            this.controlTestInicial2.Size = new System.Drawing.Size(1022, 417);
            this.controlTestInicial2.TabIndex = 12;
            // 
            // controlInicio2
            // 
            this.controlInicio2.Location = new System.Drawing.Point(190, 80);
            this.controlInicio2.Name = "controlInicio2";
            this.controlInicio2.Size = new System.Drawing.Size(1022, 376);
            this.controlInicio2.TabIndex = 11;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1387, 564);
            this.Controls.Add(this.controlTestFinal1);
            this.Controls.Add(this.controlEjercicios1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlTestInicial2);
            this.Controls.Add(this.controlInicio2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeraphEye";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel SidePanel;
        //private ControlTestInicial controlTestInicial1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private ControlInicio controlInicio1;
        private ControlInicio controlInicio2;
        private ControlTestInicial controlTestInicial2;
        private System.Windows.Forms.Label label1;
        private ControlEjercicios controlEjercicios1;
        private ControlTestFinal controlTestFinal1;
    }
}

