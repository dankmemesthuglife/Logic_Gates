namespace Logic_Gates
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
            this.Input2 = new System.Windows.Forms.ComboBox();
            this.Input1 = new System.Windows.Forms.ComboBox();
            this.Input3 = new System.Windows.Forms.ComboBox();
            this.InputSelctor_Label = new System.Windows.Forms.Label();
            this.LogicGates_Label = new System.Windows.Forms.Label();
            this.PictureBoxLG = new System.Windows.Forms.PictureBox();
            this.Output_Label = new System.Windows.Forms.Label();
            this.Integer_Label = new System.Windows.Forms.Label();
            this.SelectGate1 = new System.Windows.Forms.ComboBox();
            this.SelectGate2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLG)).BeginInit();
            this.SuspendLayout();
            // 
            // Input2
            // 
            this.Input2.FormattingEnabled = true;
            this.Input2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Input2.Location = new System.Drawing.Point(128, 33);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(87, 21);
            this.Input2.TabIndex = 1;
            this.Input2.Text = "Select Input";
            this.Input2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Input1
            // 
            this.Input1.FormattingEnabled = true;
            this.Input1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Input1.Location = new System.Drawing.Point(12, 33);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(87, 21);
            this.Input1.TabIndex = 2;
            this.Input1.Text = "Select Input";
            this.Input1.SelectedIndexChanged += new System.EventHandler(this.Input1_SelectedIndexChanged);
            // 
            // Input3
            // 
            this.Input3.FormattingEnabled = true;
            this.Input3.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Input3.Location = new System.Drawing.Point(240, 33);
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(87, 21);
            this.Input3.TabIndex = 3;
            this.Input3.Text = "Select Input";
            // 
            // InputSelctor_Label
            // 
            this.InputSelctor_Label.AutoSize = true;
            this.InputSelctor_Label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSelctor_Label.Location = new System.Drawing.Point(8, 7);
            this.InputSelctor_Label.Name = "InputSelctor_Label";
            this.InputSelctor_Label.Size = new System.Drawing.Size(115, 23);
            this.InputSelctor_Label.TabIndex = 4;
            this.InputSelctor_Label.Text = "Input Selector";
            // 
            // LogicGates_Label
            // 
            this.LogicGates_Label.AutoSize = true;
            this.LogicGates_Label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogicGates_Label.Location = new System.Drawing.Point(8, 69);
            this.LogicGates_Label.Name = "LogicGates_Label";
            this.LogicGates_Label.Size = new System.Drawing.Size(158, 23);
            this.LogicGates_Label.TabIndex = 11;
            this.LogicGates_Label.Text = "Logic Gate Selector";
            // 
            // PictureBoxLG
            // 
            this.PictureBoxLG.Location = new System.Drawing.Point(12, 138);
            this.PictureBoxLG.Name = "PictureBoxLG";
            this.PictureBoxLG.Size = new System.Drawing.Size(394, 174);
            this.PictureBoxLG.TabIndex = 12;
            this.PictureBoxLG.TabStop = false;
            // 
            // Output_Label
            // 
            this.Output_Label.AutoSize = true;
            this.Output_Label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Label.Location = new System.Drawing.Point(8, 315);
            this.Output_Label.Name = "Output_Label";
            this.Output_Label.Size = new System.Drawing.Size(67, 23);
            this.Output_Label.TabIndex = 13;
            this.Output_Label.Text = "Output:";
            // 
            // Integer_Label
            // 
            this.Integer_Label.AutoSize = true;
            this.Integer_Label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Integer_Label.Location = new System.Drawing.Point(72, 315);
            this.Integer_Label.Name = "Integer_Label";
            this.Integer_Label.Size = new System.Drawing.Size(36, 23);
            this.Integer_Label.TabIndex = 14;
            this.Integer_Label.Text = "N/A";
            // 
            // SelectGate1
            // 
            this.SelectGate1.FormattingEnabled = true;
            this.SelectGate1.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOT",
            "NAND",
            "XOR",
            "NOR"});
            this.SelectGate1.Location = new System.Drawing.Point(12, 95);
            this.SelectGate1.Name = "SelectGate1";
            this.SelectGate1.Size = new System.Drawing.Size(87, 21);
            this.SelectGate1.TabIndex = 15;
            this.SelectGate1.Text = "Select Gate";
            // 
            // SelectGate2
            // 
            this.SelectGate2.FormattingEnabled = true;
            this.SelectGate2.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOT",
            "NAND",
            "XOR",
            "NOR"});
            this.SelectGate2.Location = new System.Drawing.Point(128, 95);
            this.SelectGate2.Name = "SelectGate2";
            this.SelectGate2.Size = new System.Drawing.Size(87, 21);
            this.SelectGate2.TabIndex = 16;
            this.SelectGate2.Text = "Select Gate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(451, 347);
            this.Controls.Add(this.SelectGate2);
            this.Controls.Add(this.SelectGate1);
            this.Controls.Add(this.Integer_Label);
            this.Controls.Add(this.Output_Label);
            this.Controls.Add(this.PictureBoxLG);
            this.Controls.Add(this.LogicGates_Label);
            this.Controls.Add(this.InputSelctor_Label);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Input2);
            this.Name = "Form1";
            this.Text = "Logical Gates";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Input2;
        private System.Windows.Forms.ComboBox Input1;
        private System.Windows.Forms.ComboBox Input3;
        private System.Windows.Forms.Label InputSelctor_Label;
        private System.Windows.Forms.Label LogicGates_Label;
        private System.Windows.Forms.PictureBox PictureBoxLG;
        private System.Windows.Forms.Label Output_Label;
        private System.Windows.Forms.Label Integer_Label;
        private System.Windows.Forms.ComboBox SelectGate1;
        private System.Windows.Forms.ComboBox SelectGate2;
    }
}

