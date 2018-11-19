namespace WinForms
{
	partial class UserForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPassNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblAwards = new System.Windows.Forms.Label();
            this.ctlAwards = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(425, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(332, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OK_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 12);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.errorProvider.SetIconPadding(this.txtFirstName, 2);
            this.txtFirstName.Location = new System.Drawing.Point(124, 12);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 24);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.FullName_Validated);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 80);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(68, 17);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Birthdate:";
            // 
            // lblPassNumber
            // 
            this.lblPassNumber.AutoSize = true;
            this.lblPassNumber.Location = new System.Drawing.Point(12, 48);
            this.lblPassNumber.Name = "lblPassNumber";
            this.lblPassNumber.Size = new System.Drawing.Size(77, 17);
            this.lblPassNumber.TabIndex = 2;
            this.lblPassNumber.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.errorProvider.SetIconPadding(this.txtLastName, 2);
            this.txtLastName.Location = new System.Drawing.Point(124, 44);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 24);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.LastName_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ctlBirthdate
            // 
            this.ctlBirthdate.Location = new System.Drawing.Point(124, 80);
            this.ctlBirthdate.Name = "ctlBirthdate";
            this.ctlBirthdate.Size = new System.Drawing.Size(200, 24);
            this.ctlBirthdate.TabIndex = 8;
            this.ctlBirthdate.Validating += new System.ComponentModel.CancelEventHandler(this.Birthdate_Validating);
            this.ctlBirthdate.Validated += new System.EventHandler(this.Birthdate_Validated);
            // 
            // lblAwards
            // 
            this.lblAwards.AutoSize = true;
            this.lblAwards.Location = new System.Drawing.Point(12, 115);
            this.lblAwards.Name = "lblAwards";
            this.lblAwards.Size = new System.Drawing.Size(57, 17);
            this.lblAwards.TabIndex = 9;
            this.lblAwards.Text = "Awards:";
            // 
            // ctlAwards
            // 
            this.ctlAwards.FormattingEnabled = true;
            this.ctlAwards.ItemHeight = 17;
            this.ctlAwards.Location = new System.Drawing.Point(124, 115);
            this.ctlAwards.Name = "ctlAwards";
            this.ctlAwards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ctlAwards.Size = new System.Drawing.Size(200, 55);
            this.ctlAwards.TabIndex = 10;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(521, 240);
            this.Controls.Add(this.ctlAwards);
            this.Controls.Add(this.lblAwards);
            this.Controls.Add(this.ctlBirthdate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPassNumber);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblPassNumber;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker ctlBirthdate;
        private System.Windows.Forms.ListBox ctlAwards;
        private System.Windows.Forms.Label lblAwards;
    }
}