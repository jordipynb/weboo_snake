namespace SnakeVisual
{
    partial class SnakeApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeApp));
            this.butCrear = new System.Windows.Forms.Button();
            this.butImportar = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.OpenFileDialog();
            this.butJugar = new System.Windows.Forms.Button();
            this.butFacil = new System.Windows.Forms.Button();
            this.butMedio = new System.Windows.Forms.Button();
            this.butDificil = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.lblTextoRules = new System.Windows.Forms.Label();
            this.buttcargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCrear
            // 
            this.butCrear.BackColor = System.Drawing.Color.Khaki;
            this.butCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butCrear.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCrear.ForeColor = System.Drawing.Color.SteelBlue;
            this.butCrear.Location = new System.Drawing.Point(378, 406);
            this.butCrear.Name = "butCrear";
            this.butCrear.Size = new System.Drawing.Size(171, 47);
            this.butCrear.TabIndex = 1;
            this.butCrear.Text = "Crear";
            this.butCrear.UseVisualStyleBackColor = false;
            this.butCrear.Click += new System.EventHandler(this.Button2_Click);
            // 
            // butImportar
            // 
            this.butImportar.BackColor = System.Drawing.Color.Khaki;
            this.butImportar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butImportar.ForeColor = System.Drawing.Color.SteelBlue;
            this.butImportar.Location = new System.Drawing.Point(1057, 32);
            this.butImportar.Name = "butImportar";
            this.butImportar.Size = new System.Drawing.Size(148, 50);
            this.butImportar.TabIndex = 2;
            this.butImportar.Text = "Importar";
            this.butImportar.UseVisualStyleBackColor = false;
            this.butImportar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // archivo
            // 
            this.archivo.FileName = "archivo";
            // 
            // butJugar
            // 
            this.butJugar.BackColor = System.Drawing.Color.Khaki;
            this.butJugar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butJugar.ForeColor = System.Drawing.Color.SteelBlue;
            this.butJugar.Location = new System.Drawing.Point(128, 405);
            this.butJugar.Name = "butJugar";
            this.butJugar.Size = new System.Drawing.Size(168, 47);
            this.butJugar.TabIndex = 3;
            this.butJugar.Text = "Jugar";
            this.butJugar.UseVisualStyleBackColor = false;
            this.butJugar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // butFacil
            // 
            this.butFacil.BackColor = System.Drawing.Color.ForestGreen;
            this.butFacil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butFacil.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFacil.Location = new System.Drawing.Point(801, 453);
            this.butFacil.Name = "butFacil";
            this.butFacil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butFacil.Size = new System.Drawing.Size(174, 61);
            this.butFacil.TabIndex = 4;
            this.butFacil.Text = "FÁCIL";
            this.butFacil.UseVisualStyleBackColor = false;
            this.butFacil.Click += new System.EventHandler(this.Bufacil_Click);
            // 
            // butMedio
            // 
            this.butMedio.BackColor = System.Drawing.Color.ForestGreen;
            this.butMedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butMedio.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMedio.ForeColor = System.Drawing.Color.Black;
            this.butMedio.Location = new System.Drawing.Point(671, 577);
            this.butMedio.Name = "butMedio";
            this.butMedio.Size = new System.Drawing.Size(181, 67);
            this.butMedio.TabIndex = 5;
            this.butMedio.Text = "MEDIO";
            this.butMedio.UseVisualStyleBackColor = false;
            this.butMedio.Click += new System.EventHandler(this.Butmedio_Click);
            // 
            // butDificil
            // 
            this.butDificil.BackColor = System.Drawing.Color.ForestGreen;
            this.butDificil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDificil.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDificil.Location = new System.Drawing.Point(913, 577);
            this.butDificil.Name = "butDificil";
            this.butDificil.Size = new System.Drawing.Size(173, 67);
            this.butDificil.TabIndex = 6;
            this.butDificil.Text = "DIFÍCIL";
            this.butDificil.UseVisualStyleBackColor = false;
            this.butDificil.Click += new System.EventHandler(this.Butdificil_Click);
            // 
            // butVolver
            // 
            this.butVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.butVolver.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVolver.ForeColor = System.Drawing.Color.Aqua;
            this.butVolver.Location = new System.Drawing.Point(1078, 378);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(127, 52);
            this.butVolver.TabIndex = 7;
            this.butVolver.Text = "Volver";
            this.butVolver.UseVisualStyleBackColor = false;
            this.butVolver.Click += new System.EventHandler(this.ButVolver_Click);
            // 
            // lblTextoRules
            // 
            this.lblTextoRules.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTextoRules.CausesValidation = false;
            this.lblTextoRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextoRules.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRules.ForeColor = System.Drawing.Color.Khaki;
            this.lblTextoRules.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTextoRules.Location = new System.Drawing.Point(36, 32);
            this.lblTextoRules.Name = "lblTextoRules";
            this.lblTextoRules.Size = new System.Drawing.Size(605, 368);
            this.lblTextoRules.TabIndex = 8;
            this.lblTextoRules.Text = resources.GetString("lblTextoRules.Text");
            this.lblTextoRules.Visible = false;
            // 
            // buttcargar
            // 
            this.buttcargar.BackColor = System.Drawing.Color.Khaki;
            this.buttcargar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttcargar.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttcargar.Location = new System.Drawing.Point(250, 403);
            this.buttcargar.Name = "buttcargar";
            this.buttcargar.Size = new System.Drawing.Size(148, 50);
            this.buttcargar.TabIndex = 9;
            this.buttcargar.Text = "Cargar";
            this.buttcargar.UseVisualStyleBackColor = false;
            this.buttcargar.Click += new System.EventHandler(this.Buttcargar_Click);
            // 
            // SnakeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 683);
            this.Controls.Add(this.buttcargar);
            this.Controls.Add(this.lblTextoRules);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.butDificil);
            this.Controls.Add(this.butMedio);
            this.Controls.Add(this.butFacil);
            this.Controls.Add(this.butJugar);
            this.Controls.Add(this.butCrear);
            this.Controls.Add(this.butImportar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SnakeVisual.Properties.Settings.Default, "jordan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SnakeVisual.Properties.Settings.Default.jordan;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnakeApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SnakeApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnakeApp_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butCrear;
        private System.Windows.Forms.Button butImportar;
        private System.Windows.Forms.OpenFileDialog archivo;
        private System.Windows.Forms.Button butJugar;
        private System.Windows.Forms.Button butFacil;
        private System.Windows.Forms.Button butMedio;
        private System.Windows.Forms.Button butDificil;
        private System.Windows.Forms.Button butVolver;
        private System.Windows.Forms.Label lblTextoRules;
        private System.Windows.Forms.Button buttcargar;
    }
}