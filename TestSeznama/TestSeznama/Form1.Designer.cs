
namespace TestSeznama
{
    partial class Form1
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
            this.txtvnos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndodaj = new System.Windows.Forms.Button();
            this.btnizpis = new System.Windows.Forms.Button();
            this.txtkonzola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtvnos
            // 
            this.txtvnos.Location = new System.Drawing.Point(104, 36);
            this.txtvnos.Name = "txtvnos";
            this.txtvnos.Size = new System.Drawing.Size(341, 22);
            this.txtvnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vnesi niz: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(478, 36);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(75, 23);
            this.btndodaj.TabIndex = 2;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // btnizpis
            // 
            this.btnizpis.Location = new System.Drawing.Point(478, 92);
            this.btnizpis.Name = "btnizpis";
            this.btnizpis.Size = new System.Drawing.Size(75, 23);
            this.btnizpis.TabIndex = 3;
            this.btnizpis.Text = "Izpis";
            this.btnizpis.UseVisualStyleBackColor = true;
            this.btnizpis.Click += new System.EventHandler(this.btnizpis_Click);
            // 
            // txtkonzola
            // 
            this.txtkonzola.Location = new System.Drawing.Point(34, 136);
            this.txtkonzola.Multiline = true;
            this.txtkonzola.Name = "txtkonzola";
            this.txtkonzola.ReadOnly = true;
            this.txtkonzola.Size = new System.Drawing.Size(517, 166);
            this.txtkonzola.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 333);
            this.Controls.Add(this.txtkonzola);
            this.Controls.Add(this.btnizpis);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.Button btnizpis;
        private System.Windows.Forms.TextBox txtkonzola;
    }
}

