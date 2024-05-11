namespace frmIntro
{
    partial class frmSignup
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
            this.components = new System.ComponentModel.Container();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordSignup = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsernameSignup = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.Animated = true;
            this.btnSignin.AutoRoundedCorners = true;
            this.btnSignin.BackColor = System.Drawing.Color.Transparent;
            this.btnSignin.BorderRadius = 23;
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignin.FillColor = System.Drawing.Color.Transparent;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(475, 542);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(249, 48);
            this.btnSignin.TabIndex = 0;
            this.btnSignin.UseTransparentBackground = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(657, 557);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 25);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(399, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Already Have An Account?";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Animated = true;
            this.dtpBirth.AutoRoundedCorners = true;
            this.dtpBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtpBirth.BorderRadius = 24;
            this.dtpBirth.Checked = true;
            this.dtpBirth.FillColor = System.Drawing.Color.White;
            this.dtpBirth.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirth.Location = new System.Drawing.Point(592, 301);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(288, 50);
            this.dtpBirth.TabIndex = 8;
            this.dtpBirth.UseTransparentBackground = true;
            this.dtpBirth.Value = new System.DateTime(2024, 5, 7, 19, 13, 44, 310);
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.AutoRoundedCorners = true;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 24;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(296, 230);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(584, 50);
            this.txtAddress.TabIndex = 7;
            // 
            // txtConfirmpass
            // 
            this.txtConfirmpass.Animated = true;
            this.txtConfirmpass.AutoRoundedCorners = true;
            this.txtConfirmpass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmpass.BorderRadius = 24;
            this.txtConfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmpass.DefaultText = "";
            this.txtConfirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmpass.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmpass.Location = new System.Drawing.Point(592, 434);
            this.txtConfirmpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmpass.Name = "txtConfirmpass";
            this.txtConfirmpass.PasswordChar = '\0';
            this.txtConfirmpass.PlaceholderText = "Confirm Password";
            this.txtConfirmpass.SelectedText = "";
            this.txtConfirmpass.Size = new System.Drawing.Size(288, 50);
            this.txtConfirmpass.TabIndex = 6;
            // 
            // txtPasswordSignup
            // 
            this.txtPasswordSignup.Animated = true;
            this.txtPasswordSignup.AutoRoundedCorners = true;
            this.txtPasswordSignup.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordSignup.BorderRadius = 24;
            this.txtPasswordSignup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordSignup.DefaultText = "";
            this.txtPasswordSignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordSignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordSignup.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordSignup.Location = new System.Drawing.Point(296, 434);
            this.txtPasswordSignup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswordSignup.Name = "txtPasswordSignup";
            this.txtPasswordSignup.PasswordChar = '\0';
            this.txtPasswordSignup.PlaceholderText = "Password";
            this.txtPasswordSignup.SelectedText = "";
            this.txtPasswordSignup.Size = new System.Drawing.Size(288, 50);
            this.txtPasswordSignup.TabIndex = 5;
            this.txtPasswordSignup.TextChanged += new System.EventHandler(this.txtPasswordSignup_TextChanged);
            this.txtPasswordSignup.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordSignup_Validating);
            // 
            // txtUsernameSignup
            // 
            this.txtUsernameSignup.Animated = true;
            this.txtUsernameSignup.AutoRoundedCorners = true;
            this.txtUsernameSignup.BackColor = System.Drawing.Color.Transparent;
            this.txtUsernameSignup.BorderRadius = 24;
            this.txtUsernameSignup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsernameSignup.DefaultText = "";
            this.txtUsernameSignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsernameSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameSignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsernameSignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameSignup.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsernameSignup.Location = new System.Drawing.Point(296, 370);
            this.txtUsernameSignup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsernameSignup.Name = "txtUsernameSignup";
            this.txtUsernameSignup.PasswordChar = '\0';
            this.txtUsernameSignup.PlaceholderText = "Username";
            this.txtUsernameSignup.SelectedText = "";
            this.txtUsernameSignup.Size = new System.Drawing.Size(288, 50);
            this.txtUsernameSignup.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Animated = true;
            this.txtContact.AutoRoundedCorners = true;
            this.txtContact.BackColor = System.Drawing.Color.Transparent;
            this.txtContact.BorderRadius = 24;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.Location = new System.Drawing.Point(296, 297);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "Contact Number";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(288, 50);
            this.txtContact.TabIndex = 3;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtLname
            // 
            this.txtLname.Animated = true;
            this.txtLname.AutoRoundedCorners = true;
            this.txtLname.BackColor = System.Drawing.Color.Transparent;
            this.txtLname.BorderRadius = 24;
            this.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLname.DefaultText = "";
            this.txtLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLname.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLname.Location = new System.Drawing.Point(592, 152);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLname.Name = "txtLname";
            this.txtLname.PasswordChar = '\0';
            this.txtLname.PlaceholderText = "Lastname";
            this.txtLname.SelectedText = "";
            this.txtLname.Size = new System.Drawing.Size(288, 50);
            this.txtLname.TabIndex = 2;
            this.txtLname.TextChanged += new System.EventHandler(this.txtLname_TextChanged);
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLname_KeyPress);
            // 
            // txtFname
            // 
            this.txtFname.Animated = true;
            this.txtFname.AutoRoundedCorners = true;
            this.txtFname.BackColor = System.Drawing.Color.Transparent;
            this.txtFname.BorderRadius = 24;
            this.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFname.DefaultText = "";
            this.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFname.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFname.Location = new System.Drawing.Point(296, 152);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.PlaceholderText = "Firstname";
            this.txtFname.SelectedText = "";
            this.txtFname.Size = new System.Drawing.Size(288, 50);
            this.txtFname.TabIndex = 1;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Black;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmIntro.Properties.Resources.Your_paragraph_text;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1175, 661);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtConfirmpass);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPasswordSignup);
            this.Controls.Add(this.txtUsernameSignup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2TextBox txtLname;
        private Guna.UI2.WinForms.Guna2TextBox txtFname;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmpass;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordSignup;
        private Guna.UI2.WinForms.Guna2TextBox txtUsernameSignup;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}