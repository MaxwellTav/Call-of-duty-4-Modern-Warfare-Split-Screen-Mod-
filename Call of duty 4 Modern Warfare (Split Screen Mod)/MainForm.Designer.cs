
namespace Call_of_duty_4_Modern_Warfare__Split_Screen_Mod_
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.titleText = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BannerLabel = new Guna.UI.WinForms.GunaLabel();
            this.MultiplayerButton = new Guna.UI2.WinForms.Guna2Button();
            this.SinglePlayerButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.BannerAnim = new System.Windows.Forms.Timer(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.NormalOnlineButton = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.titleText);
            this.TopPanel.Controls.Add(this.guna2Button3);
            this.TopPanel.Controls.Add(this.guna2Button1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 30);
            this.TopPanel.TabIndex = 2;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Enabled = false;
            this.titleText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleText.Location = new System.Drawing.Point(9, 8);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(60, 15);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "ErrorText";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::Call_of_duty_4_Modern_Warfare__Split_Screen_Mod_.Properties.Resources.DownArrowWhite;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(710, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.SystemColors.Highlight;
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(45, 30);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.guna2Button1.HoverState.Image = global::Call_of_duty_4_Modern_Warfare__Split_Screen_Mod_.Properties.Resources.MinusWhite;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Call_of_duty_4_Modern_Warfare__Split_Screen_Mod_.Properties.Resources.MinusBlack;
            this.guna2Button1.ImageSize = new System.Drawing.Size(17, 17);
            this.guna2Button1.Location = new System.Drawing.Point(755, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(45, 30);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.TopPanel;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.BannerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 3;
            // 
            // BannerLabel
            // 
            this.BannerLabel.AutoSize = true;
            this.BannerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BannerLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BannerLabel.Location = new System.Drawing.Point(-540, 7);
            this.BannerLabel.Name = "BannerLabel";
            this.BannerLabel.Size = new System.Drawing.Size(1621, 15);
            this.BannerLabel.TabIndex = 0;
            this.BannerLabel.Text = resources.GetString("BannerLabel.Text");
            this.BannerLabel.Click += new System.EventHandler(this.BannerLabel_Click);
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.CheckedState.Parent = this.MultiplayerButton;
            this.MultiplayerButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MultiplayerButton.CustomImages.Parent = this.MultiplayerButton;
            this.MultiplayerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MultiplayerButton.FillColor = System.Drawing.Color.Empty;
            this.MultiplayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplayerButton.ForeColor = System.Drawing.Color.White;
            this.MultiplayerButton.HoverState.Parent = this.MultiplayerButton;
            this.MultiplayerButton.Location = new System.Drawing.Point(399, 30);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.ShadowDecoration.Parent = this.MultiplayerButton;
            this.MultiplayerButton.Size = new System.Drawing.Size(401, 219);
            this.MultiplayerButton.TabIndex = 6;
            this.MultiplayerButton.Text = "Multijugador Local | Pantalla Dividida | MOD";
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            // 
            // SinglePlayerButton
            // 
            this.SinglePlayerButton.CheckedState.Parent = this.SinglePlayerButton;
            this.SinglePlayerButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SinglePlayerButton.CustomImages.Parent = this.SinglePlayerButton;
            this.SinglePlayerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SinglePlayerButton.FillColor = System.Drawing.Color.Empty;
            this.SinglePlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayerButton.ForeColor = System.Drawing.Color.White;
            this.SinglePlayerButton.HoverState.Parent = this.SinglePlayerButton;
            this.SinglePlayerButton.Location = new System.Drawing.Point(0, 30);
            this.SinglePlayerButton.Name = "SinglePlayerButton";
            this.SinglePlayerButton.ShadowDecoration.Parent = this.SinglePlayerButton;
            this.SinglePlayerButton.Size = new System.Drawing.Size(399, 395);
            this.SinglePlayerButton.TabIndex = 5;
            this.SinglePlayerButton.Text = "Campaña | Historia | Un solo jugador";
            this.SinglePlayerButton.Click += new System.EventHandler(this.SinglePlayerButton_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.guna2VSeparator1.Enabled = false;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Gray;
            this.guna2VSeparator1.Location = new System.Drawing.Point(394, 131);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 200);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // BannerAnim
            // 
            this.BannerAnim.Enabled = true;
            this.BannerAnim.Interval = 1;
            this.BannerAnim.Tick += new System.EventHandler(this.BannerAnim_Tick);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(499, 243);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // NormalOnlineButton
            // 
            this.NormalOnlineButton.CheckedState.Parent = this.NormalOnlineButton;
            this.NormalOnlineButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.NormalOnlineButton.CustomImages.Parent = this.NormalOnlineButton;
            this.NormalOnlineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NormalOnlineButton.FillColor = System.Drawing.Color.Empty;
            this.NormalOnlineButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalOnlineButton.ForeColor = System.Drawing.Color.White;
            this.NormalOnlineButton.HoverState.Parent = this.NormalOnlineButton;
            this.NormalOnlineButton.Location = new System.Drawing.Point(399, 249);
            this.NormalOnlineButton.Name = "NormalOnlineButton";
            this.NormalOnlineButton.ShadowDecoration.Parent = this.NormalOnlineButton;
            this.NormalOnlineButton.Size = new System.Drawing.Size(401, 170);
            this.NormalOnlineButton.TabIndex = 9;
            this.NormalOnlineButton.Text = "Multijugador | Online";
            this.NormalOnlineButton.Click += new System.EventHandler(this.NormalOnlineButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NormalOnlineButton);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.MultiplayerButton);
            this.Controls.Add(this.SinglePlayerButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Of Duty 4 Modern Warfare Split Screen Mod";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI.WinForms.GunaLabel titleText;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button MultiplayerButton;
        private Guna.UI2.WinForms.Guna2Button SinglePlayerButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel BannerLabel;
        private System.Windows.Forms.Timer BannerAnim;
        private Guna.UI2.WinForms.Guna2Button NormalOnlineButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}

