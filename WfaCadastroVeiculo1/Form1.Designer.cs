namespace WfaCadastroVeiculo1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.rb_Truck = new System.Windows.Forms.RadioButton();
            this.label_placa = new System.Windows.Forms.Label();
            this.label_ano = new System.Windows.Forms.Label();
            this.label_qtdAE = new System.Windows.Forms.Label();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_qtdAE = new System.Windows.Forms.TextBox();
            this.button_cad = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.masked_Placa = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(34, 12);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(58, 17);
            this.rbOnibus.TabIndex = 0;
            this.rbOnibus.TabStop = true;
            this.rbOnibus.Text = "Ônibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            this.rbOnibus.CheckedChanged += new System.EventHandler(this.rbOnibus_CheckedChanged);
            // 
            // rb_Truck
            // 
            this.rb_Truck.AutoSize = true;
            this.rb_Truck.Location = new System.Drawing.Point(152, 12);
            this.rb_Truck.Name = "rb_Truck";
            this.rb_Truck.Size = new System.Drawing.Size(72, 17);
            this.rb_Truck.TabIndex = 1;
            this.rb_Truck.TabStop = true;
            this.rb_Truck.Text = "Caminhão";
            this.rb_Truck.UseVisualStyleBackColor = true;
            this.rb_Truck.CheckedChanged += new System.EventHandler(this.rb_Truck_CheckedChanged);
            // 
            // label_placa
            // 
            this.label_placa.AutoSize = true;
            this.label_placa.Location = new System.Drawing.Point(12, 57);
            this.label_placa.Name = "label_placa";
            this.label_placa.Size = new System.Drawing.Size(34, 13);
            this.label_placa.TabIndex = 2;
            this.label_placa.Text = "Placa";
            // 
            // label_ano
            // 
            this.label_ano.AutoSize = true;
            this.label_ano.Location = new System.Drawing.Point(12, 106);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(26, 13);
            this.label_ano.TabIndex = 3;
            this.label_ano.Text = "Ano";
            // 
            // label_qtdAE
            // 
            this.label_qtdAE.AutoSize = true;
            this.label_qtdAE.Location = new System.Drawing.Point(12, 150);
            this.label_qtdAE.Name = "label_qtdAE";
            this.label_qtdAE.Size = new System.Drawing.Size(35, 13);
            this.label_qtdAE.TabIndex = 4;
            this.label_qtdAE.Text = "label3";
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(95, 106);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(129, 20);
            this.tb_ano.TabIndex = 6;
            this.tb_ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ano_KeyPress);
            // 
            // tb_qtdAE
            // 
            this.tb_qtdAE.Location = new System.Drawing.Point(95, 150);
            this.tb_qtdAE.Name = "tb_qtdAE";
            this.tb_qtdAE.Size = new System.Drawing.Size(129, 20);
            this.tb_qtdAE.TabIndex = 7;
            this.tb_qtdAE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtdAE_KeyPress);
            // 
            // button_cad
            // 
            this.button_cad.Location = new System.Drawing.Point(42, 239);
            this.button_cad.Name = "button_cad";
            this.button_cad.Size = new System.Drawing.Size(75, 23);
            this.button_cad.TabIndex = 8;
            this.button_cad.Text = "Cadastrar";
            this.button_cad.UseVisualStyleBackColor = true;
            this.button_cad.Click += new System.EventHandler(this.button_cad_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(152, 239);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Limpar";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 288);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 123);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // masked_Placa
            // 
            this.masked_Placa.Location = new System.Drawing.Point(95, 57);
            this.masked_Placa.Name = "masked_Placa";
            this.masked_Placa.Size = new System.Drawing.Size(129, 20);
            this.masked_Placa.TabIndex = 12;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(253, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(240, 250);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 13;
            this.pictureBoxImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(505, 418);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.masked_Placa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_cad);
            this.Controls.Add(this.tb_qtdAE);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.label_qtdAE);
            this.Controls.Add(this.label_ano);
            this.Controls.Add(this.label_placa);
            this.Controls.Add(this.rb_Truck);
            this.Controls.Add(this.rbOnibus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.RadioButton rb_Truck;
        private System.Windows.Forms.Label label_placa;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.Label label_qtdAE;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_qtdAE;
        private System.Windows.Forms.Button button_cad;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox masked_Placa;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}

