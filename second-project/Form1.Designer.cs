
namespace second_project
{
    partial class MainMenu
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
            this.translateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(1450, 25);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(450, 60);
            this.translateButton.TabIndex = 0;
            this.translateButton.Text = "Cyfieithu i\'r Gymraeg";
            this.translateButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.translateButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button translateButton;
    }
}

