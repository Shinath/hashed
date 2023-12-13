namespace Hashed
{
    partial class Menu
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
            this.loggedUserLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashLinkButton = new System.Windows.Forms.Button();
            this.viewHashButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggedUserLabel
            // 
            this.loggedUserLabel.AutoSize = true;
            this.loggedUserLabel.Location = new System.Drawing.Point(333, 9);
            this.loggedUserLabel.Name = "loggedUserLabel";
            this.loggedUserLabel.Size = new System.Drawing.Size(35, 13);
            this.loggedUserLabel.TabIndex = 0;
            this.loggedUserLabel.Text = "User: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(255, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "C# Edition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(187, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hashed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(59, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to";
            // 
            // hashLinkButton
            // 
            this.hashLinkButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hashLinkButton.Location = new System.Drawing.Point(105, 141);
            this.hashLinkButton.Name = "hashLinkButton";
            this.hashLinkButton.Size = new System.Drawing.Size(79, 49);
            this.hashLinkButton.TabIndex = 7;
            this.hashLinkButton.Text = "Hash link!";
            this.hashLinkButton.UseVisualStyleBackColor = true;
            this.hashLinkButton.Click += new System.EventHandler(this.hashLinkButton_Click);
            // 
            // viewHashButton
            // 
            this.viewHashButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.viewHashButton.Location = new System.Drawing.Point(247, 141);
            this.viewHashButton.Name = "viewHashButton";
            this.viewHashButton.Size = new System.Drawing.Size(79, 49);
            this.viewHashButton.TabIndex = 8;
            this.viewHashButton.Text = "View Hash Table";
            this.viewHashButton.UseVisualStyleBackColor = true;
            this.viewHashButton.Click += new System.EventHandler(this.viewHashButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(366, 210);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 245);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.viewHashButton);
            this.Controls.Add(this.hashLinkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loggedUserLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedUserLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hashLinkButton;
        private System.Windows.Forms.Button viewHashButton;
        private System.Windows.Forms.Button logOutButton;
    }
}