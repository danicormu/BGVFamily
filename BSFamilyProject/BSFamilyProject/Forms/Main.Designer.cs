namespace BSFamilyProject
{
    partial class Main
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
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_quotes = new System.Windows.Forms.Button();
            this.btn_services = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_clients = new System.Windows.Forms.Panel();
            this.panel_employees = new System.Windows.Forms.Panel();
            this.panel_quotes = new System.Windows.Forms.Panel();
            this.panel_services = new System.Windows.Forms.Panel();
            this.panel_employees.SuspendLayout();
            this.panel_quotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(1, 0);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(217, 41);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Clientes";
            this.btn_clients.UseVisualStyleBackColor = true;
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(224, 0);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(217, 41);
            this.btn_employees.TabIndex = 1;
            this.btn_employees.Text = "Empleados";
            this.btn_employees.UseVisualStyleBackColor = true;
            // 
            // btn_quotes
            // 
            this.btn_quotes.Location = new System.Drawing.Point(447, 0);
            this.btn_quotes.Name = "btn_quotes";
            this.btn_quotes.Size = new System.Drawing.Size(217, 41);
            this.btn_quotes.TabIndex = 2;
            this.btn_quotes.Text = "Citas";
            this.btn_quotes.UseVisualStyleBackColor = true;
            // 
            // btn_services
            // 
            this.btn_services.Location = new System.Drawing.Point(670, 0);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(217, 41);
            this.btn_services.TabIndex = 3;
            this.btn_services.Text = "Servicios";
            this.btn_services.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(585, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel_clients
            // 
            this.panel_clients.Location = new System.Drawing.Point(12, 60);
            this.panel_clients.Name = "panel_clients";
            this.panel_clients.Size = new System.Drawing.Size(1338, 669);
            this.panel_clients.TabIndex = 5;
            this.panel_clients.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_employees
            // 
            this.panel_employees.Controls.Add(this.panel_quotes);
            this.panel_employees.Location = new System.Drawing.Point(12, 63);
            this.panel_employees.Name = "panel_employees";
            this.panel_employees.Size = new System.Drawing.Size(1338, 669);
            this.panel_employees.TabIndex = 6;
            // 
            // panel_quotes
            // 
            this.panel_quotes.Controls.Add(this.panel_services);
            this.panel_quotes.Location = new System.Drawing.Point(3, 0);
            this.panel_quotes.Name = "panel_quotes";
            this.panel_quotes.Size = new System.Drawing.Size(1338, 669);
            this.panel_quotes.TabIndex = 6;
            // 
            // panel_services
            // 
            this.panel_services.Location = new System.Drawing.Point(0, 0);
            this.panel_services.Name = "panel_services";
            this.panel_services.Size = new System.Drawing.Size(1338, 669);
            this.panel_services.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel_employees);
            this.Controls.Add(this.panel_clients);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_services);
            this.Controls.Add(this.btn_quotes);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.btn_clients);
            this.Name = "Main";
            this.Text = "Barber Good Vibes Family";
            this.panel_employees.ResumeLayout(false);
            this.panel_quotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_quotes;
        private System.Windows.Forms.Button btn_services;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_clients;
        private System.Windows.Forms.Panel panel_employees;
        private System.Windows.Forms.Panel panel_quotes;
        private System.Windows.Forms.Panel panel_services;
    }
}