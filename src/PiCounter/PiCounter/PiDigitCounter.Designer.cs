namespace PiCounter
{
    partial class PiDigitCounter
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
            this.labelPiDigit = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPiDigitMsg = new System.Windows.Forms.Label();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabelReset = new System.Windows.Forms.LinkLabel();
            this.panelPiPict = new System.Windows.Forms.Panel();
            this.labelTotalMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPiDigit
            // 
            this.labelPiDigit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPiDigit.AutoSize = true;
            this.labelPiDigit.BackColor = System.Drawing.Color.Transparent;
            this.labelPiDigit.Font = new System.Drawing.Font("Calibri", 130F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiDigit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(217)))), ((int)(((byte)(15)))));
            this.labelPiDigit.Location = new System.Drawing.Point(705, 95);
            this.labelPiDigit.Name = "labelPiDigit";
            this.labelPiDigit.Size = new System.Drawing.Size(143, 213);
            this.labelPiDigit.TabIndex = 0;
            this.labelPiDigit.Text = "-";
            this.labelPiDigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Calibri", 130F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(109)))), ((int)(((byte)(17)))));
            this.labelTotal.Location = new System.Drawing.Point(617, 297);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(178, 213);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPiDigitMsg
            // 
            this.labelPiDigitMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPiDigitMsg.AutoSize = true;
            this.labelPiDigitMsg.BackColor = System.Drawing.Color.Transparent;
            this.labelPiDigitMsg.Font = new System.Drawing.Font("Calibri", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiDigitMsg.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPiDigitMsg.Location = new System.Drawing.Point(323, 136);
            this.labelPiDigitMsg.Name = "labelPiDigitMsg";
            this.labelPiDigitMsg.Size = new System.Drawing.Size(390, 146);
            this.labelPiDigitMsg.TabIndex = 7;
            this.labelPiDigitMsg.Text = "   digit:";
            this.labelPiDigitMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(217)))), ((int)(((byte)(15)))));
            this.buttonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Calibri", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMinus.Location = new System.Drawing.Point(562, 523);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.buttonMinus.Size = new System.Drawing.Size(220, 136);
            this.buttonMinus.TabIndex = 2;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMinus_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabelReset);
            this.panel1.Controls.Add(this.panelPiPict);
            this.panel1.Controls.Add(this.labelPiDigitMsg);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.labelPiDigit);
            this.panel1.Controls.Add(this.labelTotalMsg);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 683);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(217)))), ((int)(((byte)(15)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(289, 523);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.button1.Size = new System.Drawing.Size(220, 136);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPlus_MouseDown);
            // 
            // linkLabelReset
            // 
            this.linkLabelReset.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelReset.AutoSize = true;
            this.linkLabelReset.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelReset.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelReset.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelReset.Location = new System.Drawing.Point(1021, 646);
            this.linkLabelReset.Name = "linkLabelReset";
            this.linkLabelReset.Size = new System.Drawing.Size(32, 13);
            this.linkLabelReset.TabIndex = 3;
            this.linkLabelReset.TabStop = true;
            this.linkLabelReset.Text = "reset";
            this.linkLabelReset.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReset_LinkClicked);
            // 
            // panelPiPict
            // 
            this.panelPiPict.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPiPict.BackgroundImage = global::PiCounter.Properties.Resources.pi1;
            this.panelPiPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPiPict.Location = new System.Drawing.Point(174, 15);
            this.panelPiPict.Name = "panelPiPict";
            this.panelPiPict.Size = new System.Drawing.Size(250, 238);
            this.panelPiPict.TabIndex = 10;
            // 
            // labelTotalMsg
            // 
            this.labelTotalMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTotalMsg.AutoSize = true;
            this.labelTotalMsg.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalMsg.Font = new System.Drawing.Font("Calibri", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMsg.ForeColor = System.Drawing.Color.Gray;
            this.labelTotalMsg.Location = new System.Drawing.Point(261, 331);
            this.labelTotalMsg.Name = "labelTotalMsg";
            this.labelTotalMsg.Size = new System.Drawing.Size(368, 164);
            this.labelTotalMsg.TabIndex = 6;
            this.labelTotalMsg.Text = "Total:";
            this.labelTotalMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PiDigitCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 712);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PiDigitCounter";
            this.Text = "Pi Recitation Contest - Digit Counter - v1.0";
            this.Load += new System.EventHandler(this.PiDigitCounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPiDigit;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPiDigitMsg;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalMsg;
        private System.Windows.Forms.Panel panelPiPict;
        private System.Windows.Forms.LinkLabel linkLabelReset;
        private System.Windows.Forms.Button button1;
    }
}

