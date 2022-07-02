namespace FitnessTracker
{
    partial class Admin
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
            this.workoutType = new System.Windows.Forms.ComboBox();
            this.workoutDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // workoutType
            // 
            this.workoutType.FormattingEnabled = true;
            this.workoutType.Location = new System.Drawing.Point(12, 45);
            this.workoutType.Name = "workoutType";
            this.workoutType.Size = new System.Drawing.Size(121, 21);
            this.workoutType.TabIndex = 0;
            foreach(var workout in new Connection().FillWorkoutTypes())
            {
                this.workoutType.Items.Add(workout);
            }
            
            // 
            // workoutDescription
            // 
            this.workoutDescription.Location = new System.Drawing.Point(12, 108);
            this.workoutDescription.Multiline = true;
            this.workoutDescription.Name = "workoutDescription";
            this.workoutDescription.Size = new System.Drawing.Size(554, 277);
            this.workoutDescription.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workoutDescription);
            this.Controls.Add(this.workoutType);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Visible = false;

        }

        #endregion

        private System.Windows.Forms.ComboBox workoutType;
        private System.Windows.Forms.TextBox workoutDescription;
    }
}