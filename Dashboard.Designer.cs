namespace Hashed
{
    partial class Dashboard
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
            this.linksTableAdapter1 = new Hashed.ModelDataSetTableAdapters.LinksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dashBackButton = new System.Windows.Forms.Button();
            this.deleteLinkButton = new System.Windows.Forms.Button();
            this.openLinkButton = new System.Windows.Forms.Button();
            this.tableDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // linksTableAdapter1
            // 
            this.linksTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(172, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Hashes";
            // 
            // dashBackButton
            // 
            this.dashBackButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashBackButton.Location = new System.Drawing.Point(360, 82);
            this.dashBackButton.Name = "dashBackButton";
            this.dashBackButton.Size = new System.Drawing.Size(75, 23);
            this.dashBackButton.TabIndex = 2;
            this.dashBackButton.Text = "Back";
            this.dashBackButton.UseVisualStyleBackColor = true;
            this.dashBackButton.Click += new System.EventHandler(this.dashBackButton_Click);
            // 
            // deleteLinkButton
            // 
            this.deleteLinkButton.Location = new System.Drawing.Point(240, 82);
            this.deleteLinkButton.Name = "deleteLinkButton";
            this.deleteLinkButton.Size = new System.Drawing.Size(75, 23);
            this.deleteLinkButton.TabIndex = 1;
            this.deleteLinkButton.Text = "Delete";
            this.deleteLinkButton.UseVisualStyleBackColor = true;
            this.deleteLinkButton.Click += new System.EventHandler(this.deleteLinkButton_Click);
            // 
            // openLinkButton
            // 
            this.openLinkButton.Location = new System.Drawing.Point(122, 82);
            this.openLinkButton.Name = "openLinkButton";
            this.openLinkButton.Size = new System.Drawing.Size(75, 23);
            this.openLinkButton.TabIndex = 3;
            this.openLinkButton.Text = "Open";
            this.openLinkButton.UseVisualStyleBackColor = true;
            this.openLinkButton.Click += new System.EventHandler(this.openLinkButton_Click);
            // 
            // tableDashboard
            // 
            this.tableDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.tableDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableDashboard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableDashboard.ColumnCount = 3;
            this.tableDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.35089F));
            this.tableDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.82456F));
            this.tableDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.82456F));
            this.tableDashboard.Controls.Add(this.label2, 1, 0);
            this.tableDashboard.Controls.Add(this.label3, 2, 0);
            this.tableDashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableDashboard.Location = new System.Drawing.Point(31, 137);
            this.tableDashboard.Name = "tableDashboard";
            this.tableDashboard.RowCount = 1;
            this.tableDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableDashboard.Size = new System.Drawing.Size(482, 30);
            this.tableDashboard.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(269, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hash";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 567);
            this.Controls.Add(this.tableDashboard);
            this.Controls.Add(this.openLinkButton);
            this.Controls.Add(this.dashBackButton);
            this.Controls.Add(this.deleteLinkButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tableDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ModelDataSetTableAdapters.LinksTableAdapter linksTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashBackButton;
        private System.Windows.Forms.Button deleteLinkButton;
        private System.Windows.Forms.Button openLinkButton;
        private System.Windows.Forms.TableLayoutPanel tableDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}