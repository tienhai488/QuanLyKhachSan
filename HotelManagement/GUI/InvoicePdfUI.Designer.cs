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
            richTextBox1.Location = new Point(14, 16);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(821, 596);
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
            mbtnPrint.Location = new Point(655, 624);
            mbtnPrint.Margin = new Padding(5, 8, 5, 8);
            mbtnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnPrint.Name = "mbtnPrint";
            mbtnPrint.NoAccentTextColor = Color.Empty;
            mbtnPrint.Size = new Size(181, 48);
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
            mbtnCancel.Location = new Point(465, 624);
            mbtnCancel.Margin = new Padding(5, 8, 5, 8);
            mbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnCancel.Name = "mbtnCancel";
            mbtnCancel.NoAccentTextColor = Color.Empty;
            mbtnCancel.Size = new Size(181, 48);
            mbtnCancel.TabIndex = 2;
            mbtnCancel.Text = "CANCEL";
            mbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            mbtnCancel.UseAccentColor = true;
            mbtnCancel.UseVisualStyleBackColor = true;
            mbtnCancel.Click += mbtnCancel_Click;
            // 
            // InvoicePdfUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 692);
            Controls.Add(mbtnCancel);
            Controls.Add(mbtnPrint);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoicePdfUI";
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