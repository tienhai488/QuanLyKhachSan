namespace HotelManagement.GUI
{
    partial class InvoicePdfUI
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
            richTextBox1 = new RichTextBox();
            mbtnPrint = new MaterialSkin.Controls.MaterialButton();
            mbtnCancel = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.White;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(719, 819);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // mbtnPrint
            // 
            mbtnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mbtnPrint.AutoSize = false;
            mbtnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnPrint.Depth = 0;
            mbtnPrint.HighEmphasis = true;
            mbtnPrint.Icon = null;
            mbtnPrint.Location = new Point(573, 840);
            mbtnPrint.Margin = new Padding(4, 6, 4, 6);
            mbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnPrint.Name = "mbtnPrint";
            mbtnPrint.NoAccentTextColor = Color.Empty;
            mbtnPrint.Size = new Size(158, 36);
            mbtnPrint.TabIndex = 1;
            mbtnPrint.Text = "SAVE AND PRINT";
            mbtnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnPrint.UseAccentColor = true;
            mbtnPrint.UseVisualStyleBackColor = true;
            mbtnPrint.Click += mbtnPrint_Click;
            // 
            // mbtnCancel
            // 
            mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mbtnCancel.AutoSize = false;
            mbtnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnCancel.Depth = 0;
            mbtnCancel.HighEmphasis = true;
            mbtnCancel.Icon = null;
            mbtnCancel.Location = new Point(407, 840);
            mbtnCancel.Margin = new Padding(4, 6, 4, 6);
            mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnCancel.Name = "mbtnCancel";
            mbtnCancel.NoAccentTextColor = Color.Empty;
            mbtnCancel.Size = new Size(158, 36);
            mbtnCancel.TabIndex = 2;
            mbtnCancel.Text = "CANCEL";
            mbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            mbtnCancel.UseAccentColor = true;
            mbtnCancel.UseVisualStyleBackColor = true;
            mbtnCancel.Click += mbtnCancel_Click;
            // 
            // InvoicePdf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 891);
            Controls.Add(mbtnCancel);
            Controls.Add(mbtnPrint);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoicePdf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceDetail";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialButton mbtnPrint;
        private MaterialSkin.Controls.MaterialButton mbtnCancel;
    }
}