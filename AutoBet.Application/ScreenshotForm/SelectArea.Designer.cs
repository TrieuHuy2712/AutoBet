
namespace AutoBet.Application.ScreenshotForm
{
    partial class SelectArea
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
            this.pnSelectArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnSelectArea
            // 
            this.pnSelectArea.Location = new System.Drawing.Point(5, 7);
            this.pnSelectArea.Name = "pnSelectArea";
            this.pnSelectArea.Size = new System.Drawing.Size(139, 82);
            this.pnSelectArea.TabIndex = 1;
            this.pnSelectArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnSelectArea_MouseDown);
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 90);
            this.Controls.Add(this.pnSelectArea);
            this.Name = "SelectArea";
            this.Text = "SelectArea";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectArea_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSelectArea;
    }
}