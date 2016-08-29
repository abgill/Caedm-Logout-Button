using System.Windows.Forms;

namespace Sign_out
{
    partial class LogoutWindow
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
            this.sign_out_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.countdown_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_out_btn
            // 
            this.sign_out_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.sign_out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_out_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_out_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.sign_out_btn.Location = new System.Drawing.Point(303, 117);
            this.sign_out_btn.Name = "sign_out_btn";
            this.sign_out_btn.Size = new System.Drawing.Size(97, 49);
            this.sign_out_btn.TabIndex = 0;
            this.sign_out_btn.Text = "Sign Out";
            this.sign_out_btn.UseVisualStyleBackColor = true;
            this.sign_out_btn.Click += new System.EventHandler(this.log_off_button_click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancel_btn.Location = new System.Drawing.Point(406, 117);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(97, 49);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_button_click);
            // 
            // countdown_label
            // 
            this.countdown_label.AutoSize = true;
            this.countdown_label.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.countdown_label.Location = new System.Drawing.Point(22, 27);
            this.countdown_label.Name = "countdown_label";
            this.countdown_label.Size = new System.Drawing.Size(378, 24);
            this.countdown_label.TabIndex = 2;
            this.countdown_label.Text = "Signing you out of Windows in 10 seconds...";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.countdown_label);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.sign_out_btn);
            this.panel1.Location = new System.Drawing.Point(180, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 181);
            this.panel1.TabIndex = 3;
            // 
            // LogoutWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(917, 384);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogoutWindow";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CAEDM Logout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign_out_btn;
        private System.Windows.Forms.Button cancel_btn;
        private Label countdown_label;
        private Panel panel1;
    }
}

