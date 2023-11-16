namespace LAB02
{
    partial class Test
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
            this.enCategory = new LAB02.User_Control.ENCategory();
            this.SuspendLayout();
            // 
            // enCategory
            // 
            this.enCategory.BackColor = System.Drawing.Color.Transparent;
            this.enCategory.Location = new System.Drawing.Point(12, 12);
            this.enCategory.Name = "enCategory";
            this.enCategory.Size = new System.Drawing.Size(1222, 700);
            this.enCategory.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 735);
            this.Controls.Add(this.enCategory);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Control.ENCategory enCategory;
    }
}