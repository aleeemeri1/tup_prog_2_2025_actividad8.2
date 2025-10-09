namespace EJ1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnC = new System.Windows.Forms.Button();
            this.bttnA = new System.Windows.Forms.Button();
            this.bttnI = new System.Windows.Forms.Button();
            this.bttnE = new System.Windows.Forms.Button();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbI = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // bttnC
            // 
            this.bttnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnC.Location = new System.Drawing.Point(353, 38);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(119, 46);
            this.bttnC.TabIndex = 0;
            this.bttnC.Text = "Confirmar";
            this.bttnC.UseVisualStyleBackColor = true;
            this.bttnC.Click += new System.EventHandler(this.bttnC_Click);
            // 
            // bttnA
            // 
            this.bttnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnA.Location = new System.Drawing.Point(353, 124);
            this.bttnA.Name = "bttnA";
            this.bttnA.Size = new System.Drawing.Size(119, 46);
            this.bttnA.TabIndex = 1;
            this.bttnA.Text = "Actualizar";
            this.bttnA.UseVisualStyleBackColor = true;
            this.bttnA.Click += new System.EventHandler(this.bttnA_Click);
            // 
            // bttnI
            // 
            this.bttnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnI.Location = new System.Drawing.Point(353, 176);
            this.bttnI.Name = "bttnI";
            this.bttnI.Size = new System.Drawing.Size(119, 46);
            this.bttnI.TabIndex = 2;
            this.bttnI.Text = "Importar";
            this.bttnI.UseVisualStyleBackColor = true;
            this.bttnI.Click += new System.EventHandler(this.bttnI_Click);
            // 
            // bttnE
            // 
            this.bttnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnE.Location = new System.Drawing.Point(353, 228);
            this.bttnE.Name = "bttnE";
            this.bttnE.Size = new System.Drawing.Size(119, 46);
            this.bttnE.TabIndex = 3;
            this.bttnE.Text = "Exportar";
            this.bttnE.UseVisualStyleBackColor = true;
            // 
            // tbP
            // 
            this.tbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP.Location = new System.Drawing.Point(114, 7);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(216, 26);
            this.tbP.TabIndex = 4;
            // 
            // tbI
            // 
            this.tbI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbI.Location = new System.Drawing.Point(114, 91);
            this.tbI.Name = "tbI";
            this.tbI.Size = new System.Drawing.Size(216, 26);
            this.tbI.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vencimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Importe:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(27, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 144);
            this.listBox1.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 294);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbI);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.bttnE);
            this.Controls.Add(this.bttnI);
            this.Controls.Add(this.bttnA);
            this.Controls.Add(this.bttnC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnC;
        private System.Windows.Forms.Button bttnA;
        private System.Windows.Forms.Button bttnI;
        private System.Windows.Forms.Button bttnE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox tbP;
        public System.Windows.Forms.TextBox tbI;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

