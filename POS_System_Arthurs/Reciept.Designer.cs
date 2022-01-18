
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
            this.customOrderLabel = new System.Windows.Forms.LinkLabel();
            this.ITEMS = new System.Windows.Forms.RichTextBox();
            this.QTYPRICE = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TitlesLabel = new System.Windows.Forms.Label();
            this.TotalTitle_Label = new System.Windows.Forms.Label();
            this.TOTAL_Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.closeBtn.Location = new System.Drawing.Point(151, 6);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(190, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close Window";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // printReceipt
            // 
            this.printReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(117)))), ((int)(((byte)(128)))));
            this.printReceipt.FlatAppearance.BorderSize = 0;
            this.printReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceipt.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceipt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printReceipt.Location = new System.Drawing.Point(8, 6);
            this.printReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(127, 36);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 65);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 65);
            this.panel4.TabIndex = 13;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.successLabel.Location = new System.Drawing.Point(31, 23);
            this.successLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(240, 25);
            this.successLabel.TabIndex = 0;
            this.successLabel.Text = "Successful Transaction";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.printReceipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 55);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customOrderLabel);
            this.panel3.Controls.Add(this.ITEMS);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 421);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // customOrderLabel
            // 
            this.customOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.customOrderLabel.Font = new System.Drawing.Font("Rockwell", 9F);
            this.customOrderLabel.Location = new System.Drawing.Point(15, 358);
            this.customOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customOrderLabel.Name = "customOrderLabel";
            this.customOrderLabel.Size = new System.Drawing.Size(299, 42);
            this.customOrderLabel.TabIndex = 20;
            this.customOrderLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customOrderLabel_LinkClicked);
            // 
            // ITEMS
            // 
            this.ITEMS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ITEMS.Font = new System.Drawing.Font("Rockwell", 8F);
            this.ITEMS.Location = new System.Drawing.Point(21, 186);
            this.ITEMS.Margin = new System.Windows.Forms.Padding(2);
            this.ITEMS.Name = "ITEMS";
            this.ITEMS.ReadOnly = true;
            this.ITEMS.Size = new System.Drawing.Size(157, 148);
            this.ITEMS.TabIndex = 17;
            this.ITEMS.Text = "";
            this.ITEMS.TextChanged += new System.EventHandler(this.ITEMS_TextChanged);
            // 
            // QTYPRICE
            // 
            this.QTYPRICE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QTYPRICE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QTYPRICE.Font = new System.Drawing.Font("Rockwell", 8F);
            this.QTYPRICE.Location = new System.Drawing.Point(2, 2);
            this.QTYPRICE.Margin = new System.Windows.Forms.Padding(2);
            this.QTYPRICE.Name = "QTYPRICE";
            this.QTYPRICE.ReadOnly = true;
            this.QTYPRICE.Size = new System.Drawing.Size(152, 144);
            this.QTYPRICE.TabIndex = 18;
            this.QTYPRICE.Text = "";
            this.QTYPRICE.TextChanged += new System.EventHandler(this.QTYPRICE_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.QTYPRICE);
            this.panel6.Location = new System.Drawing.Point(182, 186);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 148);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.TitlesLabel);
            this.panel5.Controls.Add(this.TotalTitle_Label);
            this.panel5.Controls.Add(this.TOTAL_Label);
            this.panel5.Location = new System.Drawing.Point(18, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 62);
            this.panel5.TabIndex = 15;
            // 
            // TitlesLabel
            // 
            this.TitlesLabel.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlesLabel.Location = new System.Drawing.Point(0, 5);
            this.TitlesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitlesLabel.Name = "TitlesLabel";
            this.TitlesLabel.Size = new System.Drawing.Size(151, 27);
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
            this.TotalTitle_Label.Location = new System.Drawing.Point(4, 29);
            this.TotalTitle_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTitle_Label.Name = "TotalTitle_Label";
            this.TotalTitle_Label.Size = new System.Drawing.Size(66, 22);
            this.TotalTitle_Label.TabIndex = 11;
            this.TotalTitle_Label.Text = "TOTAL:";
            // 
            // TOTAL_Label
            // 
            this.TOTAL_Label.AutoSize = true;
            this.TOTAL_Label.BackColor = System.Drawing.Color.Transparent;
            this.TOTAL_Label.Font = new System.Drawing.Font("Rockwell Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.TOTAL_Label.Location = new System.Drawing.Point(73, 29);
            this.TOTAL_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TOTAL_Label.Name = "TOTAL_Label";
            this.TOTAL_Label.Size = new System.Drawing.Size(0, 22);
            this.TOTAL_Label.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OrderSummaryLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 37);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderSummaryLabel.Font = new System.Drawing.Font("Rockwell", 9F);
            this.OrderSummaryLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OrderSummaryLabel.Location = new System.Drawing.Point(2, 0);
            this.OrderSummaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(298, 33);
            this.OrderSummaryLabel.TabIndex = 15;
            this.OrderSummaryLabel.Text = "ORDER SUMMARY";
            this.OrderSummaryLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.priceListBox);
            this.panel7.Controls.Add(this.itemListBox);
            this.panel7.Controls.Add(this.okButton);
            this.panel7.Location = new System.Drawing.Point(627, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 237);
            this.panel7.TabIndex = 21;
            this.panel7.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "CustomOrder Details";
            // 
            // priceListBox
            // 
            this.priceListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(146, 44);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(44, 134);
            this.priceListBox.TabIndex = 4;
            // 
            // itemListBox
            // 
            this.itemListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(23, 44);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(117, 134);
            this.itemListBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.okButton.Location = new System.Drawing.Point(70, 195);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(79, 24);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 476);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reciept";
            this.ShowInTaskbar = false;
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.Reciept_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.LinkLabel customOrderLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button okButton;
    }
}