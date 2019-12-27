namespace Harris7800HMP
{
    partial class LessonsInfo
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
            this.rtbLessonsInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbLessonsInfo
            // 
            this.rtbLessonsInfo.Location = new System.Drawing.Point(12, 12);
            this.rtbLessonsInfo.Name = "rtbLessonsInfo";
            this.rtbLessonsInfo.ReadOnly = true;
            this.rtbLessonsInfo.Size = new System.Drawing.Size(776, 426);
            this.rtbLessonsInfo.TabIndex = 0;
            this.rtbLessonsInfo.Text = "";
            // 
            // LessonsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbLessonsInfo);
            this.Name = "LessonsInfo";
            this.Text = "Iнформацiя";
            this.Load += new System.EventHandler(this.LessonsInfo_Load);
            this.Resize += new System.EventHandler(this.LessonsInfo_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLessonsInfo;
    }
}