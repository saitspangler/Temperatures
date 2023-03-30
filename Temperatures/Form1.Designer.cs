namespace Temperatures
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
            this.lstTemperatures = new System.Windows.Forms.ListBox();
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewTemp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHighestTemp = new System.Windows.Forms.TextBox();
            this.txtLowestTemp = new System.Windows.Forms.TextBox();
            this.txtHotDays = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtNrDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpEntry.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTemperatures
            // 
            this.lstTemperatures.FormattingEnabled = true;
            this.lstTemperatures.ItemHeight = 15;
            this.lstTemperatures.Location = new System.Drawing.Point(521, 85);
            this.lstTemperatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstTemperatures.Name = "lstTemperatures";
            this.lstTemperatures.Size = new System.Drawing.Size(247, 364);
            this.lstTemperatures.TabIndex = 0;
            // 
            // grpEntry
            // 
            this.grpEntry.Controls.Add(this.btnAdd);
            this.grpEntry.Controls.Add(this.txtNewTemp);
            this.grpEntry.Location = new System.Drawing.Point(99, 54);
            this.grpEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEntry.Size = new System.Drawing.Size(272, 88);
            this.grpEntry.TabIndex = 1;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "New Tempatures";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewTemp
            // 
            this.txtNewTemp.Location = new System.Drawing.Point(9, 45);
            this.txtNewTemp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewTemp.Name = "txtNewTemp";
            this.txtNewTemp.Size = new System.Drawing.Size(132, 23);
            this.txtNewTemp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHighestTemp);
            this.groupBox2.Controls.Add(this.txtLowestTemp);
            this.groupBox2.Controls.Add(this.txtHotDays);
            this.groupBox2.Controls.Add(this.txtAverage);
            this.groupBox2.Controls.Add(this.txtNrDays);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(99, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(339, 277);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Highest Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lowest Temp";
            // 
            // txtHighestTemp
            // 
            this.txtHighestTemp.Location = new System.Drawing.Point(181, 229);
            this.txtHighestTemp.Name = "txtHighestTemp";
            this.txtHighestTemp.ReadOnly = true;
            this.txtHighestTemp.Size = new System.Drawing.Size(132, 23);
            this.txtHighestTemp.TabIndex = 7;
            // 
            // txtLowestTemp
            // 
            this.txtLowestTemp.Location = new System.Drawing.Point(181, 187);
            this.txtLowestTemp.Name = "txtLowestTemp";
            this.txtLowestTemp.ReadOnly = true;
            this.txtLowestTemp.Size = new System.Drawing.Size(132, 23);
            this.txtLowestTemp.TabIndex = 6;
            // 
            // txtHotDays
            // 
            this.txtHotDays.Location = new System.Drawing.Point(181, 138);
            this.txtHotDays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHotDays.Name = "txtHotDays";
            this.txtHotDays.ReadOnly = true;
            this.txtHotDays.Size = new System.Drawing.Size(132, 23);
            this.txtHotDays.TabIndex = 5;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(181, 90);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(132, 23);
            this.txtAverage.TabIndex = 4;
            // 
            // txtNrDays
            // 
            this.txtNrDays.Location = new System.Drawing.Point(181, 52);
            this.txtNrDays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNrDays.Name = "txtNrDays";
            this.txtNrDays.ReadOnly = true;
            this.txtNrDays.Size = new System.Drawing.Size(132, 23);
            this.txtNrDays.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Days Above Avg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr of Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperatures";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEntry);
            this.Controls.Add(this.lstTemperatures);
            this.Font = new System.Drawing.Font("CaskaydiaCove NF", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpEntry.ResumeLayout(false);
            this.grpEntry.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTemperatures;
        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHotDays;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtNrDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHighestTemp;
        private System.Windows.Forms.TextBox txtLowestTemp;
    }
}

