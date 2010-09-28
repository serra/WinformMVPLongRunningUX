namespace Serra.Micros.MVP.Views
{
    partial class ItemListForm
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
            this.startLoadingButton = new System.Windows.Forms.Button();
            this.itemLlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startLoadingButton
            // 
            this.startLoadingButton.Enabled = false;
            this.startLoadingButton.Location = new System.Drawing.Point(12, 12);
            this.startLoadingButton.Name = "startLoadingButton";
            this.startLoadingButton.Size = new System.Drawing.Size(75, 23);
            this.startLoadingButton.TabIndex = 0;
            this.startLoadingButton.Text = "Start loading";
            this.startLoadingButton.UseVisualStyleBackColor = true;
            this.startLoadingButton.Click += new System.EventHandler(this.StartLoadingButtonClick);
            // 
            // itemLlistBox
            // 
            this.itemLlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.itemLlistBox.FormattingEnabled = true;
            this.itemLlistBox.Location = new System.Drawing.Point(12, 41);
            this.itemLlistBox.Name = "itemLlistBox";
            this.itemLlistBox.Size = new System.Drawing.Size(260, 212);
            this.itemLlistBox.TabIndex = 1;
            // 
            // ItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.itemLlistBox);
            this.Controls.Add(this.startLoadingButton);
            this.Name = "ItemListForm";
            this.Text = "ItemListForm";
            this.Load += new System.EventHandler(this.ItemListFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startLoadingButton;
        private System.Windows.Forms.ListBox itemLlistBox;
    }
}