namespace SnakeVisual
{
    partial class SnakeAppCrear
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeAppCrear));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttDibuj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttVolver = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.archivo = new System.Windows.Forms.SaveFileDialog();
            this.numUDhuevos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhuevos = new System.Windows.Forms.Label();
            this.buttJugar = new System.Windows.Forms.Button();
            this.buttGuardar = new System.Windows.Forms.Button();
            this.numUDvelocid = new System.Windows.Forms.NumericUpDown();
            this.lblveloc = new System.Windows.Forms.Label();
            this.buttAcept = new System.Windows.Forms.Button();
            this.lblFilas = new System.Windows.Forms.Label();
            this.lblColum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDhuevos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDvelocid)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(929, 159);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.White;
            this.numericUpDown2.Location = new System.Drawing.Point(1084, 159);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(92, 22);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttDibuj
            // 
            this.buttDibuj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttDibuj.BackColor = System.Drawing.Color.Gray;
            this.buttDibuj.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDibuj.ForeColor = System.Drawing.Color.White;
            this.buttDibuj.Location = new System.Drawing.Point(989, 210);
            this.buttDibuj.Name = "buttDibuj";
            this.buttDibuj.Size = new System.Drawing.Size(121, 45);
            this.buttDibuj.TabIndex = 3;
            this.buttDibuj.Text = "Dibujar";
            this.buttDibuj.UseVisualStyleBackColor = false;
            this.buttDibuj.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 628);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // buttVolver
            // 
            this.buttVolver.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.buttVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttVolver.BackColor = System.Drawing.Color.Gray;
            this.buttVolver.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttVolver.ForeColor = System.Drawing.Color.White;
            this.buttVolver.Location = new System.Drawing.Point(1061, 614);
            this.buttVolver.Name = "buttVolver";
            this.buttVolver.Size = new System.Drawing.Size(120, 46);
            this.buttVolver.TabIndex = 5;
            this.buttVolver.Text = "Volver";
            this.buttVolver.UseVisualStyleBackColor = false;
            this.buttVolver.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // numUDhuevos
            // 
            this.numUDhuevos.Location = new System.Drawing.Point(1056, 292);
            this.numUDhuevos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUDhuevos.Name = "numUDhuevos";
            this.numUDhuevos.Size = new System.Drawing.Size(120, 22);
            this.numUDhuevos.TabIndex = 6;
            this.numUDhuevos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(924, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puntuación";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(929, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 42);
            this.label2.TabIndex = 8;
            // 
            // lblhuevos
            // 
            this.lblhuevos.AutoSize = true;
            this.lblhuevos.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhuevos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblhuevos.Location = new System.Drawing.Point(935, 292);
            this.lblhuevos.Name = "lblhuevos";
            this.lblhuevos.Size = new System.Drawing.Size(85, 23);
            this.lblhuevos.TabIndex = 9;
            this.lblhuevos.Text = "Huevos";
            // 
            // buttJugar
            // 
            this.buttJugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttJugar.BackColor = System.Drawing.Color.Gray;
            this.buttJugar.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttJugar.ForeColor = System.Drawing.Color.White;
            this.buttJugar.Location = new System.Drawing.Point(989, 531);
            this.buttJugar.Name = "buttJugar";
            this.buttJugar.Size = new System.Drawing.Size(121, 49);
            this.buttJugar.TabIndex = 10;
            this.buttJugar.Text = "Jugar";
            this.buttJugar.UseVisualStyleBackColor = false;
            this.buttJugar.Click += new System.EventHandler(this.ButtJugar_Click);
            // 
            // buttGuardar
            // 
            this.buttGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttGuardar.BackColor = System.Drawing.Color.Gray;
            this.buttGuardar.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttGuardar.ForeColor = System.Drawing.Color.White;
            this.buttGuardar.Location = new System.Drawing.Point(929, 614);
            this.buttGuardar.Name = "buttGuardar";
            this.buttGuardar.Size = new System.Drawing.Size(117, 46);
            this.buttGuardar.TabIndex = 11;
            this.buttGuardar.Text = "Guardar";
            this.buttGuardar.UseVisualStyleBackColor = false;
            this.buttGuardar.Click += new System.EventHandler(this.ButtGuardar_Click);
            // 
            // numUDvelocid
            // 
            this.numUDvelocid.Location = new System.Drawing.Point(1056, 454);
            this.numUDvelocid.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUDvelocid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDvelocid.Name = "numUDvelocid";
            this.numUDvelocid.Size = new System.Drawing.Size(120, 22);
            this.numUDvelocid.TabIndex = 12;
            this.numUDvelocid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblveloc
            // 
            this.lblveloc.AutoSize = true;
            this.lblveloc.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblveloc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblveloc.Location = new System.Drawing.Point(935, 453);
            this.lblveloc.Name = "lblveloc";
            this.lblveloc.Size = new System.Drawing.Size(115, 23);
            this.lblveloc.TabIndex = 13;
            this.lblveloc.Text = "Velocidad";
            // 
            // buttAcept
            // 
            this.buttAcept.BackColor = System.Drawing.Color.Gray;
            this.buttAcept.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAcept.ForeColor = System.Drawing.Color.White;
            this.buttAcept.Location = new System.Drawing.Point(989, 363);
            this.buttAcept.Name = "buttAcept";
            this.buttAcept.Size = new System.Drawing.Size(121, 44);
            this.buttAcept.TabIndex = 14;
            this.buttAcept.Text = "Agregar";
            this.buttAcept.UseVisualStyleBackColor = false;
            this.buttAcept.Click += new System.EventHandler(this.Button5_Click);
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFilas.Location = new System.Drawing.Point(925, 135);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(53, 21);
            this.lblFilas.TabIndex = 15;
            this.lblFilas.Text = "Filas";
            // 
            // lblColum
            // 
            this.lblColum.AutoSize = true;
            this.lblColum.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblColum.Location = new System.Drawing.Point(1080, 135);
            this.lblColum.Name = "lblColum";
            this.lblColum.Size = new System.Drawing.Size(98, 21);
            this.lblColum.TabIndex = 16;
            this.lblColum.Text = "Columnas";
            // 
            // SnakeAppCrear
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1217, 683);
            this.Controls.Add(this.lblColum);
            this.Controls.Add(this.lblFilas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttAcept);
            this.Controls.Add(this.lblveloc);
            this.Controls.Add(this.numUDvelocid);
            this.Controls.Add(this.buttGuardar);
            this.Controls.Add(this.buttJugar);
            this.Controls.Add(this.lblhuevos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDhuevos);
            this.Controls.Add(this.buttVolver);
            this.Controls.Add(this.buttDibuj);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SnakeVisual.Properties.Settings.Default, "jordan", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SnakeVisual.Properties.Settings.Default.jordan;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnakeAppCrear";
            this.Text = "SnakeApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeAppCrear_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SnakeAppCrear_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDhuevos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDvelocid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button buttDibuj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttVolver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog archivo;
        private System.Windows.Forms.NumericUpDown numUDhuevos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhuevos;
        private System.Windows.Forms.Button buttJugar;
        private System.Windows.Forms.Button buttGuardar;
        private System.Windows.Forms.NumericUpDown numUDvelocid;
        private System.Windows.Forms.Label lblveloc;
        private System.Windows.Forms.Button buttAcept;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Label lblColum;
    }
}