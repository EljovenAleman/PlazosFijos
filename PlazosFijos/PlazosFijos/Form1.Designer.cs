
namespace PlazosFijos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_ProcesarOperación = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_TotalUnicaInversion = new System.Windows.Forms.Label();
            this.label_TotalReinversionMensual = new System.Windows.Forms.Label();
            this.label_TotalGananciaReinversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese inversión inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese interes anual";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 23);
            this.textBox2.TabIndex = 3;
            // 
            // button_ProcesarOperación
            // 
            this.button_ProcesarOperación.Location = new System.Drawing.Point(417, 50);
            this.button_ProcesarOperación.Name = "button_ProcesarOperación";
            this.button_ProcesarOperación.Size = new System.Drawing.Size(126, 23);
            this.button_ProcesarOperación.TabIndex = 4;
            this.button_ProcesarOperación.Text = "Procesar Inversión";
            this.button_ProcesarOperación.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total anual con única inversión:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(45, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 244);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ganancia por reinversión mensual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(272, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total anual reinvirtiendo mensualmente:";
            // 
            // label_TotalUnicaInversion
            // 
            this.label_TotalUnicaInversion.AutoSize = true;
            this.label_TotalUnicaInversion.Location = new System.Drawing.Point(650, 139);
            this.label_TotalUnicaInversion.Name = "label_TotalUnicaInversion";
            this.label_TotalUnicaInversion.Size = new System.Drawing.Size(38, 15);
            this.label_TotalUnicaInversion.TabIndex = 10;
            this.label_TotalUnicaInversion.Text = "label7";
            // 
            // label_TotalReinversionMensual
            // 
            this.label_TotalReinversionMensual.AutoSize = true;
            this.label_TotalReinversionMensual.Location = new System.Drawing.Point(650, 169);
            this.label_TotalReinversionMensual.Name = "label_TotalReinversionMensual";
            this.label_TotalReinversionMensual.Size = new System.Drawing.Size(38, 15);
            this.label_TotalReinversionMensual.TabIndex = 11;
            this.label_TotalReinversionMensual.Text = "label8";
            // 
            // label_TotalGananciaReinversion
            // 
            this.label_TotalGananciaReinversion.AutoSize = true;
            this.label_TotalGananciaReinversion.Location = new System.Drawing.Point(650, 231);
            this.label_TotalGananciaReinversion.Name = "label_TotalGananciaReinversion";
            this.label_TotalGananciaReinversion.Size = new System.Drawing.Size(38, 15);
            this.label_TotalGananciaReinversion.TabIndex = 12;
            this.label_TotalGananciaReinversion.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_TotalGananciaReinversion);
            this.Controls.Add(this.label_TotalReinversionMensual);
            this.Controls.Add(this.label_TotalUnicaInversion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_ProcesarOperación);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_ProcesarOperación;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_TotalUnicaInversion;
        private System.Windows.Forms.Label label_TotalReinversionMensual;
        private System.Windows.Forms.Label label_TotalGananciaReinversion;
    }
}

