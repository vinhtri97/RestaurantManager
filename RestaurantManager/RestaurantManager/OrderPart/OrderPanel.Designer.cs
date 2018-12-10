namespace RestaurantManager
{
    partial class OrderPanel
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
            this.dine_inButton = new System.Windows.Forms.Button();
            this.carryOutButton = new System.Windows.Forms.Button();
            this.deliveryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dine_inButton
            // 
            this.dine_inButton.Location = new System.Drawing.Point(26, 149);
            this.dine_inButton.Name = "dine_inButton";
            this.dine_inButton.Size = new System.Drawing.Size(226, 105);
            this.dine_inButton.TabIndex = 0;
            this.dine_inButton.Text = "Dine-in";
            this.dine_inButton.UseVisualStyleBackColor = true;
            // 
            // carryOutButton
            // 
            this.carryOutButton.Location = new System.Drawing.Point(289, 149);
            this.carryOutButton.Name = "carryOutButton";
            this.carryOutButton.Size = new System.Drawing.Size(226, 105);
            this.carryOutButton.TabIndex = 0;
            this.carryOutButton.Text = "Carry Out";
            this.carryOutButton.UseVisualStyleBackColor = true;
            // 
            // deliveryButton
            // 
            this.deliveryButton.Location = new System.Drawing.Point(553, 149);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(226, 105);
            this.deliveryButton.TabIndex = 0;
            this.deliveryButton.Text = "Delivery";
            this.deliveryButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(26, 372);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 43);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deliveryButton);
            this.Controls.Add(this.carryOutButton);
            this.Controls.Add(this.dine_inButton);
            this.Name = "OrderPanel";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dine_inButton;
        private System.Windows.Forms.Button carryOutButton;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.Button backButton;
    }
}
