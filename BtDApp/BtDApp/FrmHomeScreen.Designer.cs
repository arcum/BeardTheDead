namespace BtDApp
{
    partial class FrmHomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeScreen));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(354, 376);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(130, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(506, 376);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::BtDApp.Properties.Resources.logo;
            this.pbLogo.InitialImage = global::BtDApp.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(335, 386);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(354, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 360);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FrmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBrowse);
            this.Name = "FrmHomeScreen";
            this.Text = "Beard The Dead";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
    }
}

