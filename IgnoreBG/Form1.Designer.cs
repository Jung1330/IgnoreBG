namespace IgnoreBG
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordCheck = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.Label();
            this.Ignore = new System.Windows.Forms.Label();
            this.Success = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuccessTimer = new System.Windows.Forms.Timer(this.components);
            this.WrongTimer = new System.Windows.Forms.Timer(this.components);
            this.Hideme = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayHelper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.madeByUnknownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tray = new System.Windows.Forms.Timer(this.components);
            this.KeyPressHelper = new System.Windows.Forms.Timer(this.components);
            this.Protector = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.TrayHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.PasswordCheck);
            this.panel1.Controls.Add(this.TestLabel);
            this.panel1.Controls.Add(this.Ignore);
            this.panel1.Controls.Add(this.Success);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PasswordTextbox);
            this.panel1.Location = new System.Drawing.Point(250, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 132);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.AutoSize = true;
            this.PasswordCheck.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordCheck.Location = new System.Drawing.Point(13, 83);
            this.PasswordCheck.Name = "PasswordCheck";
            this.PasswordCheck.Size = new System.Drawing.Size(20, 13);
            this.PasswordCheck.TabIndex = 5;
            this.PasswordCheck.Text = "Sa";
            this.PasswordCheck.Visible = false;
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TestLabel.Location = new System.Drawing.Point(13, 39);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(25, 13);
            this.TestLabel.TabIndex = 4;
            this.TestLabel.Text = "Null";
            this.TestLabel.Visible = false;
            // 
            // Ignore
            // 
            this.Ignore.AutoSize = true;
            this.Ignore.ForeColor = System.Drawing.Color.Red;
            this.Ignore.Location = new System.Drawing.Point(137, 109);
            this.Ignore.Name = "Ignore";
            this.Ignore.Size = new System.Drawing.Size(97, 13);
            this.Ignore.TabIndex = 4;
            this.Ignore.Text = "Wrong Password !!";
            this.Ignore.Visible = false;
            // 
            // Success
            // 
            this.Success.AutoSize = true;
            this.Success.ForeColor = System.Drawing.Color.Chartreuse;
            this.Success.Location = new System.Drawing.Point(13, 109);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(84, 13);
            this.Success.TabIndex = 3;
            this.Success.Text = "Welcome again.";
            this.Success.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Protect Services of BG";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(159, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(55, 57);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(179, 20);
            this.PasswordTextbox.TabIndex = 0;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // SuccessTimer
            // 
            this.SuccessTimer.Interval = 1000;
            this.SuccessTimer.Tick += new System.EventHandler(this.SuccessTimer_Tick);
            // 
            // WrongTimer
            // 
            this.WrongTimer.Interval = 300;
            this.WrongTimer.Tick += new System.EventHandler(this.WrongTimer_Tick);
            // 
            // Hideme
            // 
            this.Hideme.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Hideme.BalloonTipText = "XD";
            this.Hideme.BalloonTipTitle = "XD";
            this.Hideme.ContextMenuStrip = this.TrayHelper;
            this.Hideme.Icon = ((System.Drawing.Icon)(resources.GetObject("Hideme.Icon")));
            this.Hideme.Text = "IgnoreBG";
            this.Hideme.Visible = true;
            this.Hideme.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Hideme_MouseDoubleClick);
            // 
            // TrayHelper
            // 
            this.TrayHelper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByUnknownToolStripMenuItem});
            this.TrayHelper.Name = "TrayHelper";
            this.TrayHelper.Size = new System.Drawing.Size(175, 26);
            // 
            // madeByUnknownToolStripMenuItem
            // 
            this.madeByUnknownToolStripMenuItem.Image = global::IgnoreBG.Properties.Resources.AnyConv_com__ee83abe7_0d48_459f_a210_2459d501cdcdfile_509277;
            this.madeByUnknownToolStripMenuItem.Name = "madeByUnknownToolStripMenuItem";
            this.madeByUnknownToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.madeByUnknownToolStripMenuItem.Text = "Made By Unknown";
            // 
            // Tray
            // 
            this.Tray.Interval = 1000;
            // 
            // KeyPressHelper
            // 
            this.KeyPressHelper.Enabled = true;
            this.KeyPressHelper.Interval = 1000;
            // 
            // Protector
            // 
            this.Protector.Enabled = true;
            this.Protector.Tick += new System.EventHandler(this.Protector_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1065, 592);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IgnoreBG";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TrayHelper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Success;
        private System.Windows.Forms.Timer SuccessTimer;
        private System.Windows.Forms.Label Ignore;
        private System.Windows.Forms.Label PasswordCheck;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Timer WrongTimer;
        private System.Windows.Forms.NotifyIcon Hideme;
        private System.Windows.Forms.Timer Tray;
        private System.Windows.Forms.ContextMenuStrip TrayHelper;
        private System.Windows.Forms.ToolStripMenuItem madeByUnknownToolStripMenuItem;
        private System.Windows.Forms.Timer KeyPressHelper;
        private System.Windows.Forms.Timer Protector;
    }
}

