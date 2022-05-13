namespace Objectium
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnKandolf = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInfoColor = new System.Windows.Forms.Button();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.comboColores = new System.Windows.Forms.ComboBox();
            this.comboEspecies = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEspecies2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(32, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnZ);
            this.tabPage1.Controls.Add(this.btnX);
            this.tabPage1.Controls.Add(this.btnY);
            this.tabPage1.Controls.Add(this.btnKandolf);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sonidos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ver Información sobre Nantium";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(672, 44);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(193, 48);
            this.btnZ.TabIndex = 8;
            this.btnZ.Text = "Emitir Sonido Z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(459, 44);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(193, 48);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "Emitir sonido X";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(248, 44);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(205, 48);
            this.btnY.TabIndex = 6;
            this.btnY.Text = "Emitir sonido Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnKandolf
            // 
            this.btnKandolf.Location = new System.Drawing.Point(43, 44);
            this.btnKandolf.Name = "btnKandolf";
            this.btnKandolf.Size = new System.Drawing.Size(199, 48);
            this.btnKandolf.TabIndex = 5;
            this.btnKandolf.Text = "Emitir sonido Kandolf";
            this.btnKandolf.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInfoColor);
            this.tabPage2.Controls.Add(this.btnCambiarColor);
            this.tabPage2.Controls.Add(this.comboColores);
            this.tabPage2.Controls.Add(this.comboEspecies);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInfoColor
            // 
            this.btnInfoColor.Location = new System.Drawing.Point(623, 69);
            this.btnInfoColor.Name = "btnInfoColor";
            this.btnInfoColor.Size = new System.Drawing.Size(176, 34);
            this.btnInfoColor.TabIndex = 3;
            this.btnInfoColor.Text = "Ver color actual";
            this.btnInfoColor.UseVisualStyleBackColor = true;
            this.btnInfoColor.Click += new System.EventHandler(this.btnInfoColor_Click);
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Location = new System.Drawing.Point(620, 16);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(179, 34);
            this.btnCambiarColor.TabIndex = 2;
            this.btnCambiarColor.Text = "Cambiar color especie";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click_1);
            // 
            // comboColores
            // 
            this.comboColores.FormattingEnabled = true;
            this.comboColores.Items.AddRange(new object[] {
            "Rojo",
            "Amarillo",
            "Azul",
            "Verde"});
            this.comboColores.Location = new System.Drawing.Point(328, 16);
            this.comboColores.Name = "comboColores";
            this.comboColores.Size = new System.Drawing.Size(260, 33);
            this.comboColores.TabIndex = 1;
            // 
            // comboEspecies
            // 
            this.comboEspecies.FormattingEnabled = true;
            this.comboEspecies.Items.AddRange(new object[] {
            "Kandolf",
            "X",
            "Y",
            "Z"});
            this.comboEspecies.Location = new System.Drawing.Point(20, 16);
            this.comboEspecies.Name = "comboEspecies";
            this.comboEspecies.Size = new System.Drawing.Size(274, 33);
            this.comboEspecies.TabIndex = 0;
            this.comboEspecies.SelectedIndexChanged += new System.EventHandler(this.comboEspecies_SelectedIndexChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.comboBoxEspecies2);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(908, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Formas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ver Forma Actual";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "cambiar forma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Circular",
            "Rombótica",
            "Triangular",
            "Trapezoide"});
            this.comboBox1.Location = new System.Drawing.Point(324, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBoxEspecies2
            // 
            this.comboBoxEspecies2.FormattingEnabled = true;
            this.comboBoxEspecies2.Items.AddRange(new object[] {
            "Kandolf",
            "X",
            "Y",
            "Z"});
            this.comboBoxEspecies2.Location = new System.Drawing.Point(16, 22);
            this.comboBoxEspecies2.Name = "comboBoxEspecies2";
            this.comboBoxEspecies2.Size = new System.Drawing.Size(274, 33);
            this.comboBoxEspecies2.TabIndex = 2;
            this.comboBoxEspecies2.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspecies2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Fauna Objectium";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private Button btnZ;
        private Button btnX;
        private Button btnY;
        private Button btnKandolf;
        private TabPage tabPage2;
        private ComboBox comboEspecies;
        private ComboBox comboColores;
        private Button btnCambiarColor;
        private Button btnInfoColor;
        private TabPage tabPage3;
        private ComboBox comboBox1;
        private ComboBox comboBoxEspecies2;
        private Button button2;
        private Button button3;
    }
}