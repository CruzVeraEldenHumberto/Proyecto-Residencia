
namespace Therapheye
{
    partial class FormVisNoc
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
            this.controlCirculoHorario1 = new Therapheye.ControlCirculoHorario();
            this.controlGreenwood1 = new Therapheye.ControlGreenwood();
            this.controlAmsler1 = new Therapheye.ControlAmsler();
            this.controlIshihara1 = new Therapheye.ControlIshihara();
            this.controlPelli1 = new Therapheye.ControlPelli();
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
            this.panel1.TabIndex = 0;
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
            this.button5.Location = new System.Drawing.Point(23, 280);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "Astigmatismo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 351);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "Campo Visual";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
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
            this.button3.Text = "Degeneración Macular";
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
            this.button2.Text = "Visión del color";
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
            this.button1.Text = "Sensibilidad de contraste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(279, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 36);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Seleccione una de las opciones del menu lateral";
            // 
            // controlCirculoHorario1
            // 
            this.controlCirculoHorario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlCirculoHorario1.Location = new System.Drawing.Point(269, 0);
            this.controlCirculoHorario1.Name = "controlCirculoHorario1";
            this.controlCirculoHorario1.Size = new System.Drawing.Size(997, 493);
            this.controlCirculoHorario1.TabIndex = 5;
            this.controlCirculoHorario1.Visible = false;
            this.controlCirculoHorario1.Load += new System.EventHandler(this.controlCirculoHorario1_Load);
            // 
            // controlGreenwood1
            // 
            this.controlGreenwood1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlGreenwood1.Location = new System.Drawing.Point(269, 3);
            this.controlGreenwood1.Margin = new System.Windows.Forms.Padding(5);
            this.controlGreenwood1.Name = "controlGreenwood1";
            this.controlGreenwood1.Size = new System.Drawing.Size(997, 487);
            this.controlGreenwood1.TabIndex = 4;
            this.controlGreenwood1.Visible = false;
            // 
            // controlAmsler1
            // 
            this.controlAmsler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlAmsler1.Location = new System.Drawing.Point(269, 0);
            this.controlAmsler1.Margin = new System.Windows.Forms.Padding(5);
            this.controlAmsler1.Name = "controlAmsler1";
            this.controlAmsler1.Size = new System.Drawing.Size(999, 490);
            this.controlAmsler1.TabIndex = 3;
            this.controlAmsler1.Visible = false;
            this.controlAmsler1.Load += new System.EventHandler(this.controlAmsler1_Load);
            // 
            // controlIshihara1
            // 
            this.controlIshihara1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlIshihara1.Location = new System.Drawing.Point(269, 1);
            this.controlIshihara1.Margin = new System.Windows.Forms.Padding(5);
            this.controlIshihara1.Name = "controlIshihara1";
            this.controlIshihara1.Size = new System.Drawing.Size(999, 485);
            this.controlIshihara1.TabIndex = 2;
            this.controlIshihara1.Visible = false;
            this.controlIshihara1.Load += new System.EventHandler(this.controlIshihara1_Load);
            // 
            // controlPelli1
            // 
            this.controlPelli1.AutoSize = true;
            this.controlPelli1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlPelli1.Location = new System.Drawing.Point(269, 0);
            this.controlPelli1.Margin = new System.Windows.Forms.Padding(5);
            this.controlPelli1.Name = "controlPelli1";
            this.controlPelli1.Size = new System.Drawing.Size(997, 487);
            this.controlPelli1.TabIndex = 1;
            this.controlPelli1.Visible = false;
            this.controlPelli1.Load += new System.EventHandler(this.controlPelli1_Load);
            // 
            // FormVisNoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 486);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlPelli1);
            this.Controls.Add(this.controlCirculoHorario1);
            this.Controls.Add(this.controlGreenwood1);
            this.Controls.Add(this.controlAmsler1);
            this.Controls.Add(this.controlIshihara1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVisNoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integridad Ocular";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private ControlPelli controlPelli1;
        private System.Windows.Forms.Button button2;
        private ControlIshihara controlIshihara1;
        private System.Windows.Forms.Button button3;
        private ControlAmsler controlAmsler1;
        private System.Windows.Forms.Button button4;
        private ControlGreenwood controlGreenwood1;
        private System.Windows.Forms.Button button5;
        private ControlCirculoHorario controlCirculoHorario1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.TextBox textBox1;
    }
}