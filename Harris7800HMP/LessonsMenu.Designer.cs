namespace Harris7800HMP
{
    partial class LessonsMenu
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
            this.lbLessons = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbLessons
            // 
            this.lbLessons.FormattingEnabled = true;
            this.lbLessons.Location = new System.Drawing.Point(12, 12);
            this.lbLessons.Name = "lbLessons";
            this.lbLessons.Size = new System.Drawing.Size(334, 459);
            this.lbLessons.TabIndex = 0;
            this.lbLessons.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LessonsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 483);
            this.Controls.Add(this.lbLessons);
            this.Name = "LessonsMenu";
            this.Text = "Вправи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLessons;
    }
}