using FitnessTracker;

namespace FitnessTracker
{
    partial class Client
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
            this.typeId = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeId
            // 
            this.typeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeId.FormattingEnabled = true;
            this.typeId.Location = new System.Drawing.Point(0, 28);
            this.typeId.Name = "TypeId";
            this.typeId.Size = new System.Drawing.Size(192, 39);
            this.typeId.TabIndex = 0;
            this.typeId.Enabled = false;
            this.typeId.Text = new Connection().GetWorkoutType();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(0, 75);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(647, 319);
            this.description.TabIndex = 1;
            this.description.Text = new Connection().GetDescription();
            this.description.Enabled = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description);
            this.Controls.Add(this.typeId);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeId;
        private System.Windows.Forms.TextBox description;
    }
}

