namespace FunnyRust
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.HeldWeapon = new System.Windows.Forms.Label();
            this.ListWear = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Held weapon";
            // 
            // HeldWeapon
            // 
            this.HeldWeapon.AutoSize = true;
            this.HeldWeapon.Location = new System.Drawing.Point(14, 28);
            this.HeldWeapon.Name = "HeldWeapon";
            this.HeldWeapon.Size = new System.Drawing.Size(0, 13);
            this.HeldWeapon.TabIndex = 7;
            // 
            // ListWear
            // 
            this.ListWear.HideSelection = false;
            this.ListWear.Location = new System.Drawing.Point(182, 28);
            this.ListWear.Name = "ListWear";
            this.ListWear.Size = new System.Drawing.Size(239, 110);
            this.ListWear.TabIndex = 8;
            this.ListWear.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wearing";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListWear);
            this.Controls.Add(this.HeldWeapon);
            this.Controls.Add(this.label8);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(424, 141);
            this.Load += new System.EventHandler(this.PlayerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label HeldWeapon;
        public System.Windows.Forms.ListView ListWear;
        private System.Windows.Forms.Label label1;
    }
}
