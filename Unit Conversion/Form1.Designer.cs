namespace Unit_Conversion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboxOutput = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cboxUnit = new System.Windows.Forms.ComboBox();
            this.cboxInput = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Persona Aura", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(235, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIT CONVERSION";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboxOutput);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Controls.Add(this.cboxUnit);
            this.panel2.Controls.Add(this.cboxInput);
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(16, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 348);
            this.panel2.TabIndex = 1;
            // 
            // cboxOutput
            // 
            this.cboxOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOutput.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.cboxOutput.FormattingEnabled = true;
            this.cboxOutput.Location = new System.Drawing.Point(400, 103);
            this.cboxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cboxOutput.Name = "cboxOutput";
            this.cboxOutput.Size = new System.Drawing.Size(312, 45);
            this.cboxOutput.TabIndex = 7;
            this.cboxOutput.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.cboxOutput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(400, 164);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(313, 44);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxUnit
            // 
            this.cboxUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(253)))));
            this.cboxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnit.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.cboxUnit.FormattingEnabled = true;
            this.cboxUnit.Items.AddRange(new object[] {
            "Length",
            "Temperature",
            "Weight / Mass",
            "Volume / Capacity",
            "Time",
            "Speed",
            "Area",
            "Data Storage",
            "Currency"});
            this.cboxUnit.Location = new System.Drawing.Point(195, 43);
            this.cboxUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cboxUnit.Name = "cboxUnit";
            this.cboxUnit.Size = new System.Drawing.Size(373, 45);
            this.cboxUnit.TabIndex = 5;
            this.cboxUnit.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            this.cboxUnit.TextChanged += new System.EventHandler(this.cboxUnit_TextChanged);
            // 
            // cboxInput
            // 
            this.cboxInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxInput.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.cboxInput.FormattingEnabled = true;
            this.cboxInput.Location = new System.Drawing.Point(60, 103);
            this.cboxInput.Margin = new System.Windows.Forms.Padding(4);
            this.cboxInput.Name = "cboxInput";
            this.cboxInput.Size = new System.Drawing.Size(312, 45);
            this.cboxInput.TabIndex = 2;
            this.cboxInput.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.cboxInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(60, 164);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(313, 44);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(196)))));
            this.button1.Font = new System.Drawing.Font("Persona Aura", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(289, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboxUnit;
        private System.Windows.Forms.ComboBox cboxInput;
        private System.Windows.Forms.ComboBox cboxOutput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

