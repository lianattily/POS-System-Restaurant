
namespace POS_System_Arthurs
{
    partial class Reciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reciept));
            this.closeBtn = new System.Windows.Forms.Button();
            this.printReceipt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.successLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QTYPRICE = new System.Windows.Forms.RichTextBox();
            this.ITEMS = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TitlesLabel = new System.Windows.Forms.Label();
            this.TotalTitle_Label = new System.Windows.Forms.Label();
            this.TOTAL_Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ITEMSs = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBtn.Location = new System.Drawing.Point(226, 25);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(214, 55);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close Window";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // printReceipt
            // 
            this.printReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(117)))), ((int)(((byte)(128)))));
            this.printReceipt.FlatAppearance.BorderSize = 0;
            this.printReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceipt.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceipt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printReceipt.Location = new System.Drawing.Point(12, 25);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(214, 55);
            this.printReceipt.TabIndex = 0;
            this.printReceipt.Text = "Print Reciept";
            this.printReceipt.UseVisualStyleBackColor = false;
            this.printReceipt.Click += new System.EventHandler(this.printReceipt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.successLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 100);
            this.panel4.TabIndex = 13;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.successLabel.Location = new System.Drawing.Point(47, 35);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(344, 36);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "Successful Transaction";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.printReceipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ITEMS);
            this.panel3.Controls.Add(this.QTYPRICE);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.ITEMSs);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 617);
            this.panel3.TabIndex = 7;
            // 
            // QTYPRICE
            // 
            this.QTYPRICE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QTYPRICE.Font = new System.Drawing.Font("Rockwell", 8F);
            this.QTYPRICE.Location = new System.Drawing.Point(275, 255);
            this.QTYPRICE.Name = "QTYPRICE";
            this.QTYPRICE.ReadOnly = true;
            this.QTYPRICE.Size = new System.Drawing.Size(174, 262);
            this.QTYPRICE.TabIndex = 18;
            this.QTYPRICE.Text = "";
            // 
            // ITEMS
            // 
            this.ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ITEMS.Font = new System.Drawing.Font("Rockwell", 8F);
            this.ITEMS.Location = new System.Drawing.Point(0, 255);
            this.ITEMS.Name = "ITEMS";
            this.ITEMS.ReadOnly = true;
            this.ITEMS.Size = new System.Drawing.Size(269, 262);
            this.ITEMS.TabIndex = 17;
            this.ITEMS.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TitlesLabel);
            this.panel5.Controls.Add(this.TotalTitle_Label);
            this.panel5.Controls.Add(this.TOTAL_Label);
            this.panel5.Location = new System.Drawing.Point(0, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 104);
            this.panel5.TabIndex = 15;
            // 
            // TitlesLabel
            // 
            this.TitlesLabel.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlesLabel.Location = new System.Drawing.Point(0, 7);
            this.TitlesLabel.Name = "TitlesLabel";
            this.TitlesLabel.Size = new System.Drawing.Size(226, 41);
            this.TitlesLabel.TabIndex = 6;
            this.TitlesLabel.Text = "  ";
            this.TitlesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalTitle_Label
            // 
            this.TotalTitle_Label.AutoSize = true;
            this.TotalTitle_Label.BackColor = System.Drawing.Color.Transparent;
            this.TotalTitle_Label.Font = new System.Drawing.Font("Rockwell Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTitle_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.TotalTitle_Label.Location = new System.Drawing.Point(6, 45);
            this.TotalTitle_Label.Name = "TotalTitle_Label";
            this.TotalTitle_Label.Size = new System.Drawing.Size(98, 33);
            this.TotalTitle_Label.TabIndex = 11;
            this.TotalTitle_Label.Text = "TOTAL:";
            // 
            // TOTAL_Label
            // 
            this.TOTAL_Label.AutoSize = true;
            this.TOTAL_Label.BackColor = System.Drawing.Color.Transparent;
            this.TOTAL_Label.Font = new System.Drawing.Font("Rockwell Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.TOTAL_Label.Location = new System.Drawing.Point(109, 45);
            this.TOTAL_Label.Name = "TOTAL_Label";
            this.TOTAL_Label.Size = new System.Drawing.Size(0, 33);
            this.TOTAL_Label.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OrderSummaryLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 57);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.Font = new System.Drawing.Font("Rockwell", 9F);
            this.OrderSummaryLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OrderSummaryLabel.Location = new System.Drawing.Point(3, 0);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(447, 51);
            this.OrderSummaryLabel.TabIndex = 15;
            this.OrderSummaryLabel.Text = "ORDER SUMMARY";
            this.OrderSummaryLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(189, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // ITEMSs
            // 
            this.ITEMSs.BackColor = System.Drawing.SystemColors.Control;
            this.ITEMSs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ITEMSs.Font = new System.Drawing.Font("Rockwell", 8F);
            this.ITEMSs.Location = new System.Drawing.Point(4, 264);
            this.ITEMSs.Multiline = true;
            this.ITEMSs.Name = "ITEMSs";
            this.ITEMSs.ReadOnly = true;
            this.ITEMSs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ITEMSs.Size = new System.Drawing.Size(437, 247);
            this.ITEMSs.TabIndex = 16;
            // 
            // Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reciept";
            this.ShowInTaskbar = false;
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.Reciept_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TOTAL_Label;
        private System.Windows.Forms.Label TotalTitle_Label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label OrderSummaryLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TitlesLabel;
        private System.Windows.Forms.RichTextBox ITEMS;
        private System.Windows.Forms.RichTextBox QTYPRICE;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox ITEMSs;
    }
}