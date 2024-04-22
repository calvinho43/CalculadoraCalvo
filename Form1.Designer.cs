namespace CalculadoraCalvo
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
            System.Windows.Forms.Button button7;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonigual = new System.Windows.Forms.Button();
            this.buttonvir = new System.Windows.Forms.Button();
            this.buttonpor = new System.Windows.Forms.Button();
            this.buttonmais = new System.Windows.Forms.Button();
            this.buttonmenos = new System.Windows.Forms.Button();
            this.buttonvezes = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttoncop = new System.Windows.Forms.Button();
            this.buttonapa = new System.Windows.Forms.Button();
            this.buttonlim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.94737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.05264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(297, 84);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "43 + 43";
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonigual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonvir, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonpor, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonmais, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonmenos, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonvezes, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttondiv, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttoncop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonapa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonlim, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(button7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 283);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // buttonigual
            // 
            this.buttonigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonigual.Location = new System.Drawing.Point(225, 227);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(68, 50);
            this.buttonigual.TabIndex = 19;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = true;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // buttonvir
            // 
            this.buttonvir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvir.Location = new System.Drawing.Point(151, 227);
            this.buttonvir.Name = "buttonvir";
            this.buttonvir.Size = new System.Drawing.Size(68, 50);
            this.buttonvir.TabIndex = 18;
            this.buttonvir.Text = ".";
            this.buttonvir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonvir.UseVisualStyleBackColor = true;
            this.buttonvir.Click += new System.EventHandler(this.buttonvir_Click);
            // 
            // buttonpor
            // 
            this.buttonpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpor.Location = new System.Drawing.Point(3, 227);
            this.buttonpor.Name = "buttonpor";
            this.buttonpor.Size = new System.Drawing.Size(68, 50);
            this.buttonpor.TabIndex = 17;
            this.buttonpor.Text = "%";
            this.buttonpor.UseVisualStyleBackColor = true;
            this.buttonpor.Click += new System.EventHandler(this.buttonpor_Click);
            // 
            // buttonmais
            // 
            this.buttonmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmais.Location = new System.Drawing.Point(225, 171);
            this.buttonmais.Name = "buttonmais";
            this.buttonmais.Size = new System.Drawing.Size(68, 50);
            this.buttonmais.TabIndex = 16;
            this.buttonmais.Text = "+";
            this.buttonmais.UseVisualStyleBackColor = true;
            this.buttonmais.Click += new System.EventHandler(this.buttonmais_Click);
            // 
            // buttonmenos
            // 
            this.buttonmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmenos.Location = new System.Drawing.Point(225, 115);
            this.buttonmenos.Name = "buttonmenos";
            this.buttonmenos.Size = new System.Drawing.Size(68, 50);
            this.buttonmenos.TabIndex = 15;
            this.buttonmenos.Text = "-";
            this.buttonmenos.UseVisualStyleBackColor = true;
            this.buttonmenos.Click += new System.EventHandler(this.buttonmenos_Click);
            // 
            // buttonvezes
            // 
            this.buttonvezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvezes.Location = new System.Drawing.Point(225, 59);
            this.buttonvezes.Name = "buttonvezes";
            this.buttonvezes.Size = new System.Drawing.Size(68, 50);
            this.buttonvezes.TabIndex = 14;
            this.buttonvezes.Text = "X";
            this.buttonvezes.UseVisualStyleBackColor = true;
            this.buttonvezes.Click += new System.EventHandler(this.buttonvezes_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondiv.Location = new System.Drawing.Point(225, 3);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(68, 50);
            this.buttondiv.TabIndex = 13;
            this.buttondiv.Text = "/";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.buttondiv_Click);
            // 
            // buttoncop
            // 
            this.buttoncop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncop.Location = new System.Drawing.Point(151, 3);
            this.buttoncop.Name = "buttoncop";
            this.buttoncop.Size = new System.Drawing.Size(68, 50);
            this.buttoncop.TabIndex = 12;
            this.buttoncop.Text = "Copiar";
            this.buttoncop.UseVisualStyleBackColor = true;
            this.buttoncop.Click += new System.EventHandler(this.buttoncop_Click);
            // 
            // buttonapa
            // 
            this.buttonapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonapa.Location = new System.Drawing.Point(77, 3);
            this.buttonapa.Name = "buttonapa";
            this.buttonapa.Size = new System.Drawing.Size(68, 50);
            this.buttonapa.TabIndex = 11;
            this.buttonapa.Text = "Apagar";
            this.buttonapa.UseVisualStyleBackColor = true;
            this.buttonapa.Click += new System.EventHandler(this.buttonapa_Click);
            // 
            // buttonlim
            // 
            this.buttonlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlim.Location = new System.Drawing.Point(3, 3);
            this.buttonlim.Name = "buttonlim";
            this.buttonlim.Size = new System.Drawing.Size(68, 50);
            this.buttonlim.TabIndex = 10;
            this.buttonlim.Text = "Limpar";
            this.buttonlim.UseVisualStyleBackColor = true;
            this.buttonlim.Click += new System.EventHandler(this.buttonlim_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(77, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(151, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(77, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(151, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button7
            // 
            button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button7.Location = new System.Drawing.Point(3, 59);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(68, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(77, 227);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 50);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(77, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(151, 59);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 50);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 404);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonigual;
        private System.Windows.Forms.Button buttonvir;
        private System.Windows.Forms.Button buttonpor;
        private System.Windows.Forms.Button buttonmais;
        private System.Windows.Forms.Button buttonmenos;
        private System.Windows.Forms.Button buttonvezes;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttoncop;
        private System.Windows.Forms.Button buttonapa;
        private System.Windows.Forms.Button buttonlim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

