
namespace Clicker
{
    partial class Hydr0
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
            System.Windows.Forms.Timer Binding;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hydr0));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPSTrackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CPSValue = new System.Windows.Forms.Label();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bindBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.randomTB = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Timer(this.components);
            Binding = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Binding
            // 
            Binding.Enabled = true;
            Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morsa Clicker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Clicks CPS";
            // 
            // CPSTrackbar
            // 
            this.CPSTrackbar.HoverState.Parent = this.CPSTrackbar;
            this.CPSTrackbar.Location = new System.Drawing.Point(19, 92);
            this.CPSTrackbar.Maximum = 20;
            this.CPSTrackbar.Minimum = 6;
            this.CPSTrackbar.Name = "CPSTrackbar";
            this.CPSTrackbar.Size = new System.Drawing.Size(300, 23);
            this.CPSTrackbar.TabIndex = 4;
            this.CPSTrackbar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.CPSTrackbar.Value = 12;
            this.CPSTrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSTrackbar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.label4.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(150, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Created by zNotHydr0";
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CPSValue.Location = new System.Drawing.Point(325, 92);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(59, 19);
            this.CPSValue.TabIndex = 7;
            this.CPSValue.Text = "12 CPS";
            // 
            // Autoclicker
            // 
            this.Autoclicker.Enabled = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(200, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "v1.0";
            // 
            // bindBtn
            // 
            this.bindBtn.CheckedState.Parent = this.bindBtn;
            this.bindBtn.CustomImages.Parent = this.bindBtn;
            this.bindBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bindBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bindBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bindBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bindBtn.DisabledState.Parent = this.bindBtn;
            this.bindBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.bindBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindBtn.ForeColor = System.Drawing.Color.White;
            this.bindBtn.HoverState.Parent = this.bindBtn;
            this.bindBtn.Location = new System.Drawing.Point(117, 176);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.ShadowDecoration.Parent = this.bindBtn;
            this.bindBtn.Size = new System.Drawing.Size(60, 51);
            this.bindBtn.TabIndex = 14;
            this.bindBtn.Text = "none";
            this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // btnToggle
            // 
            this.btnToggle.Animated = true;
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnToggle.CheckedState.Parent = this.btnToggle;
            this.btnToggle.CustomImages.Parent = this.btnToggle;
            this.btnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggle.DisabledState.Parent = this.btnToggle;
            this.btnToggle.FillColor = System.Drawing.Color.White;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnToggle.HoverState.Parent = this.btnToggle;
            this.btnToggle.Location = new System.Drawing.Point(259, 12);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Parent = this.btnToggle;
            this.btnToggle.Size = new System.Drawing.Size(141, 31);
            this.btnToggle.TabIndex = 15;
            this.btnToggle.Text = "disable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // randomTB
            // 
            this.randomTB.HoverState.Parent = this.randomTB;
            this.randomTB.Location = new System.Drawing.Point(22, 132);
            this.randomTB.Maximum = 30;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(233, 24);
            this.randomTB.TabIndex = 16;
            this.randomTB.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.randomTB.Value = 12;
            this.randomTB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Key Bind";
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Hydr0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(436, 274);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPSTrackbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hydr0";
            this.Text = "Morsa Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Timer Autoclicker;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton bindBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnToggle;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar randomTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Random;
    }
}

