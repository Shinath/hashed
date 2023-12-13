namespace Hashed
{
    partial class SingIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameSingInTB = new System.Windows.Forms.TextBox();
            this.registerSingInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassSingInTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pass2SingInTB = new System.Windows.Forms.TextBox();
            this.backSingInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(99, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // usernameSingInTB
            // 
            this.usernameSingInTB.Location = new System.Drawing.Point(140, 112);
            this.usernameSingInTB.Name = "usernameSingInTB";
            this.usernameSingInTB.Size = new System.Drawing.Size(148, 20);
            this.usernameSingInTB.TabIndex = 1;
            // 
            // registerSingInButton
            // 
            this.registerSingInButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerSingInButton.Location = new System.Drawing.Point(140, 234);
            this.registerSingInButton.Name = "registerSingInButton";
            this.registerSingInButton.Size = new System.Drawing.Size(75, 23);
            this.registerSingInButton.TabIndex = 2;
            this.registerSingInButton.Text = "Sing in";
            this.registerSingInButton.UseVisualStyleBackColor = true;
            this.registerSingInButton.Click += new System.EventHandler(this.registerSingInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(59, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(59, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // PassSingInTB
            // 
            this.PassSingInTB.Location = new System.Drawing.Point(140, 151);
            this.PassSingInTB.Name = "PassSingInTB";
            this.PassSingInTB.PasswordChar = '*';
            this.PassSingInTB.Size = new System.Drawing.Size(148, 20);
            this.PassSingInTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // Pass2SingInTB
            // 
            this.Pass2SingInTB.Location = new System.Drawing.Point(140, 190);
            this.Pass2SingInTB.Name = "Pass2SingInTB";
            this.Pass2SingInTB.PasswordChar = '*';
            this.Pass2SingInTB.Size = new System.Drawing.Size(148, 20);
            this.Pass2SingInTB.TabIndex = 6;
            // 
            // backSingInButton
            // 
            this.backSingInButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backSingInButton.Location = new System.Drawing.Point(273, 342);
            this.backSingInButton.Name = "backSingInButton";
            this.backSingInButton.Size = new System.Drawing.Size(75, 23);
            this.backSingInButton.TabIndex = 8;
            this.backSingInButton.Text = "Back";
            this.backSingInButton.UseVisualStyleBackColor = true;
            this.backSingInButton.Click += new System.EventHandler(this.backSingInButton_Click);
            // 
            // SingIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 377);
            this.Controls.Add(this.backSingInButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pass2SingInTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassSingInTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerSingInButton);
            this.Controls.Add(this.usernameSingInTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sing In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameSingInTB;
        private System.Windows.Forms.Button registerSingInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassSingInTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pass2SingInTB;
        private System.Windows.Forms.Button backSingInButton;
    }
}