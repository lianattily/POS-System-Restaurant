
namespace POS_System_Arthurs
{
    partial class CustomOrder
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
            this.MeatComboBox = new System.Windows.Forms.ComboBox();
            this.SidesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeatComboBox
            // 
            this.MeatComboBox.FormattingEnabled = true;
            this.MeatComboBox.Items.AddRange(new object[] {
            "Beef",
            "Chicken"});
            this.MeatComboBox.Location = new System.Drawing.Point(90, 38);
            this.MeatComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MeatComboBox.Name = "MeatComboBox";
            this.MeatComboBox.Size = new System.Drawing.Size(82, 21);
            this.MeatComboBox.TabIndex = 0;
            // 
            // SidesComboBox
            // 
            this.SidesComboBox.FormattingEnabled = true;
            this.SidesComboBox.Items.AddRange(new object[] {
            "MacNCheese",
            "Curly Fries",
            "Nachos",
            "Mashed Potatoes"});
            this.SidesComboBox.Location = new System.Drawing.Point(265, 38);
            this.SidesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SidesComboBox.Name = "SidesComboBox";
            this.SidesComboBox.Size = new System.Drawing.Size(82, 21);
            this.SidesComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sides";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drinks";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(193, 82);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(152, 84);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "button1";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CustomOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(414, 343);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SidesComboBox);
            this.Controls.Add(this.MeatComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomOrder";
            this.Text = "CustomOrder";
            this.Load += new System.EventHandler(this.CustomOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MeatComboBox;
        private System.Windows.Forms.ComboBox SidesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
    }
}