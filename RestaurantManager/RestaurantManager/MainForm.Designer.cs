namespace RestaurantManager
{
    partial class MainForm
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
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.seatButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.orderPanel = new RestaurantManager.OrderPanel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantLabel.Location = new System.Drawing.Point(190, 63);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.Size = new System.Drawing.Size(421, 58);
            this.restaurantLabel.TabIndex = 3;
            this.restaurantLabel.Text = "Matxa Restaurant";
            this.restaurantLabel.UseWaitCursor = true;
            // 
            // seatButton
            // 
            this.seatButton.Location = new System.Drawing.Point(286, 251);
            this.seatButton.Name = "seatButton";
            this.seatButton.Size = new System.Drawing.Size(193, 49);
            this.seatButton.TabIndex = 6;
            this.seatButton.Text = "Seat";
            this.seatButton.UseVisualStyleBackColor = true;
            this.seatButton.UseWaitCursor = true;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(286, 156);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(193, 49);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.UseWaitCursor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(286, 339);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(193, 49);
            this.paymentButton.TabIndex = 4;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.UseWaitCursor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.restaurantLabel);
            this.mainPanel.Controls.Add(this.seatButton);
            this.mainPanel.Controls.Add(this.orderButton);
            this.mainPanel.Controls.Add(this.paymentButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // orderPanel
            // 
            this.orderPanel.Location = new System.Drawing.Point(0, 0);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(800, 450);
            this.orderPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "Matxa Restaurant";
            this.UseWaitCursor = true;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

            this.Controls.Add(orderPanel);
            this.orderPanel.Visible = false;
        }

        #endregion

        private System.Windows.Forms.Label restaurantLabel;
        private System.Windows.Forms.Button seatButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Panel mainPanel;

        private RestaurantManager.OrderPanel orderPanel;

        public System.Windows.Forms.Panel getMainPanel()
        {
            return this.mainPanel;
        }
    }
}

