
namespace TarkovOverlay
{
    partial class Form1
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
            this.showmapBtn = new Guna.UI2.WinForms.Guna2Button();
            this.toggleRaidStatus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.mapPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // showmapBtn
            // 
            this.showmapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showmapBtn.Animated = true;
            this.showmapBtn.BorderRadius = 5;
            this.showmapBtn.CheckedState.Parent = this.showmapBtn;
            this.showmapBtn.CustomImages.Parent = this.showmapBtn;
            this.showmapBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showmapBtn.ForeColor = System.Drawing.Color.White;
            this.showmapBtn.HoverState.Parent = this.showmapBtn;
            this.showmapBtn.Location = new System.Drawing.Point(669, 406);
            this.showmapBtn.Name = "showmapBtn";
            this.showmapBtn.ShadowDecoration.Parent = this.showmapBtn;
            this.showmapBtn.Size = new System.Drawing.Size(119, 32);
            this.showmapBtn.TabIndex = 0;
            this.showmapBtn.Text = "Show Map (p)";
            this.showmapBtn.Click += new System.EventHandler(this.showmapBtn_Click);
            // 
            // toggleRaidStatus
            // 
            this.toggleRaidStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleRaidStatus.Animated = true;
            this.toggleRaidStatus.BorderRadius = 5;
            this.toggleRaidStatus.CheckedState.Parent = this.toggleRaidStatus;
            this.toggleRaidStatus.CustomImages.Parent = this.toggleRaidStatus;
            this.toggleRaidStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleRaidStatus.ForeColor = System.Drawing.Color.White;
            this.toggleRaidStatus.HoverState.Parent = this.toggleRaidStatus;
            this.toggleRaidStatus.Location = new System.Drawing.Point(12, 406);
            this.toggleRaidStatus.Name = "toggleRaidStatus";
            this.toggleRaidStatus.ShadowDecoration.Parent = this.toggleRaidStatus;
            this.toggleRaidStatus.Size = new System.Drawing.Size(119, 32);
            this.toggleRaidStatus.TabIndex = 1;
            this.toggleRaidStatus.Text = "Toggle Raid Status";
            this.toggleRaidStatus.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Select Map",
            "Customs",
            "Woods",
            "Reserve",
            "Interchange (Not added)",
            "Factory (Not added)",
            "Shoreline (Not added)",
            "Labs (Not added)"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(558, 364);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(230, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 4;
            this.guna2ComboBox1.DropDownClosed += new System.EventHandler(this.guna2ComboBox1_DropDownClosed);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(137, 406);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(119, 32);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Ammo Chart ( buggy )";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // mapPicture
            // 
            this.mapPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPicture.BorderRadius = 5;
            this.mapPicture.Location = new System.Drawing.Point(12, 12);
            this.mapPicture.Name = "mapPicture";
            this.mapPicture.ShadowDecoration.Parent = this.mapPicture;
            this.mapPicture.Size = new System.Drawing.Size(776, 350);
            this.mapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPicture.TabIndex = 3;
            this.mapPicture.TabStop = false;
            this.mapPicture.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.toggleRaidStatus);
            this.Controls.Add(this.showmapBtn);
            this.Controls.Add(this.mapPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escapee";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button showmapBtn;
        private Guna.UI2.WinForms.Guna2Button toggleRaidStatus;
        private Guna.UI2.WinForms.Guna2PictureBox mapPicture;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

