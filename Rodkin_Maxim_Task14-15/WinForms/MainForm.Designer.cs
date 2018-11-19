namespace WinForms
{
	partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наградуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.наградуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователяToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.наградуToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlContextRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlContextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.ctlStudentPage = new System.Windows.Forms.TabPage();
            this.ctlUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlAwards = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlContextMenuAwards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAwards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.ctlContextMenu.SuspendLayout();
            this.ctlTab.SuspendLayout();
            this.ctlStudentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).BeginInit();
            this.ctlContextMenuAwards.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(658, 28);
            this.mainMenu.TabIndex = 0;
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileRegister,
            this.ctlFileEdit,
            this.ctlFileRemove,
            this.toolStripMenuItem1,
            this.ctlFileExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(57, 24);
            this.ctlFile.Text = "Файл";
            // 
            // ctlFileRegister
            // 
            this.ctlFileRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователяToolStripMenuItem,
            this.наградуToolStripMenuItem});
            this.ctlFileRegister.Name = "ctlFileRegister";
            this.ctlFileRegister.Size = new System.Drawing.Size(192, 26);
            this.ctlFileRegister.Text = "Добавить...";
            // 
            // пользователяToolStripMenuItem
            // 
            this.пользователяToolStripMenuItem.Name = "пользователяToolStripMenuItem";
            this.пользователяToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.пользователяToolStripMenuItem.Text = "Пользователя";
            this.пользователяToolStripMenuItem.Click += new System.EventHandler(this.UserRegister_Click);
            // 
            // наградуToolStripMenuItem
            // 
            this.наградуToolStripMenuItem.Name = "наградуToolStripMenuItem";
            this.наградуToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.наградуToolStripMenuItem.Text = "Награду";
            this.наградуToolStripMenuItem.Click += new System.EventHandler(this.AwardRegister_Click);
            // 
            // ctlFileEdit
            // 
            this.ctlFileEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователяToolStripMenuItem1,
            this.наградуToolStripMenuItem1});
            this.ctlFileEdit.Name = "ctlFileEdit";
            this.ctlFileEdit.Size = new System.Drawing.Size(192, 26);
            this.ctlFileEdit.Text = "Редактировать..";
            // 
            // пользователяToolStripMenuItem1
            // 
            this.пользователяToolStripMenuItem1.Name = "пользователяToolStripMenuItem1";
            this.пользователяToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.пользователяToolStripMenuItem1.Text = "Пользователя";
            this.пользователяToolStripMenuItem1.Click += new System.EventHandler(this.UserEdit_Click);
            // 
            // наградуToolStripMenuItem1
            // 
            this.наградуToolStripMenuItem1.Name = "наградуToolStripMenuItem1";
            this.наградуToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.наградуToolStripMenuItem1.Text = "Награду";
            this.наградуToolStripMenuItem1.Click += new System.EventHandler(this.AwardEdit_Click);
            // 
            // ctlFileRemove
            // 
            this.ctlFileRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователяToolStripMenuItem2,
            this.наградуToolStripMenuItem2});
            this.ctlFileRemove.Name = "ctlFileRemove";
            this.ctlFileRemove.Size = new System.Drawing.Size(192, 26);
            this.ctlFileRemove.Text = "Удалить...";
            // 
            // пользователяToolStripMenuItem2
            // 
            this.пользователяToolStripMenuItem2.Name = "пользователяToolStripMenuItem2";
            this.пользователяToolStripMenuItem2.Size = new System.Drawing.Size(182, 26);
            this.пользователяToolStripMenuItem2.Text = "Пользователя";
            this.пользователяToolStripMenuItem2.Click += new System.EventHandler(this.UserRemove_Click);
            // 
            // наградуToolStripMenuItem2
            // 
            this.наградуToolStripMenuItem2.Name = "наградуToolStripMenuItem2";
            this.наградуToolStripMenuItem2.Size = new System.Drawing.Size(182, 26);
            this.наградуToolStripMenuItem2.Text = "Награду";
            this.наградуToolStripMenuItem2.Click += new System.EventHandler(this.AwardRemove_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // ctlFileExit
            // 
            this.ctlFileExit.Name = "ctlFileExit";
            this.ctlFileExit.Size = new System.Drawing.Size(192, 26);
            this.ctlFileExit.Text = "Выход";
            this.ctlFileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // ctlContextMenu
            // 
            this.ctlContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlContextRegister,
            this.ctlContextEdit,
            this.ctlContextRemove});
            this.ctlContextMenu.Name = "ctlContextMenu";
            this.ctlContextMenu.Size = new System.Drawing.Size(190, 76);
            // 
            // ctlContextRegister
            // 
            this.ctlContextRegister.Name = "ctlContextRegister";
            this.ctlContextRegister.Size = new System.Drawing.Size(189, 24);
            this.ctlContextRegister.Text = "Добавить...";
            this.ctlContextRegister.Click += new System.EventHandler(this.UserRegister_Click);
            // 
            // ctlContextEdit
            // 
            this.ctlContextEdit.Name = "ctlContextEdit";
            this.ctlContextEdit.Size = new System.Drawing.Size(189, 24);
            this.ctlContextEdit.Text = "Редактировать...";
            this.ctlContextEdit.Click += new System.EventHandler(this.UserEdit_Click);
            // 
            // ctlContextRemove
            // 
            this.ctlContextRemove.Name = "ctlContextRemove";
            this.ctlContextRemove.Size = new System.Drawing.Size(189, 24);
            this.ctlContextRemove.Text = "Удалить";
            this.ctlContextRemove.Click += new System.EventHandler(this.UserRemove_Click);
            // 
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.ctlStudentPage);
            this.ctlTab.Controls.Add(this.tabPage2);
            this.ctlTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTab.Location = new System.Drawing.Point(0, 28);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(658, 293);
            this.ctlTab.TabIndex = 5;
            // 
            // ctlStudentPage
            // 
            this.ctlStudentPage.Controls.Add(this.ctlUsers);
            this.ctlStudentPage.Location = new System.Drawing.Point(4, 26);
            this.ctlStudentPage.Name = "ctlStudentPage";
            this.ctlStudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.ctlStudentPage.Size = new System.Drawing.Size(650, 263);
            this.ctlStudentPage.TabIndex = 0;
            this.ctlStudentPage.Text = "Пользователи";
            this.ctlStudentPage.UseVisualStyleBackColor = true;
            // 
            // ctlUsers
            // 
            this.ctlUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Birthdate,
            this.Age,
            this.UserAwards});
            this.ctlUsers.ContextMenuStrip = this.ctlContextMenu;
            this.ctlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsers.Location = new System.Drawing.Point(3, 3);
            this.ctlUsers.Name = "ctlUsers";
            this.ctlUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlUsers.Size = new System.Drawing.Size(644, 257);
            this.ctlUsers.TabIndex = 3;
            this.ctlUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlUsers_ColumnHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlAwards);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(580, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Награды";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlAwards
            // 
            this.ctlAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.ctlAwards.ContextMenuStrip = this.ctlContextMenuAwards;
            this.ctlAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlAwards.Location = new System.Drawing.Point(3, 3);
            this.ctlAwards.Name = "ctlAwards";
            this.ctlAwards.ReadOnly = true;
            this.ctlAwards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlAwards.Size = new System.Drawing.Size(574, 257);
            this.ctlAwards.TabIndex = 4;
            this.ctlAwards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlAwards_ColumnHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // ctlContextMenuAwards
            // 
            this.ctlContextMenuAwards.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlContextMenuAwards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.ctlContextMenuAwards.Name = "ctlContextMenuAwards";
            this.ctlContextMenuAwards.Size = new System.Drawing.Size(190, 76);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить...";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AwardRegister_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать...";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.AwardEdit_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.AwardRemove_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // UserAwards
            // 
            this.UserAwards.DataPropertyName = "AwardsStr";
            this.UserAwards.HeaderText = "UserAwards";
            this.UserAwards.Name = "UserAwards";
            this.UserAwards.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 377);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users and awards";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ctlContextMenu.ResumeLayout(false);
            this.ctlTab.ResumeLayout(false);
            this.ctlStudentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).EndInit();
            this.ctlContextMenuAwards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlFile;
		private System.Windows.Forms.ToolStripMenuItem ctlFileExit;
		private System.Windows.Forms.ToolStripMenuItem ctlFileRegister;
		private System.Windows.Forms.ToolStripMenuItem ctlFileEdit;
		private System.Windows.Forms.ToolStripMenuItem ctlFileRemove;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip ctlContextMenu;
		private System.Windows.Forms.ToolStripMenuItem ctlContextRegister;
		private System.Windows.Forms.ToolStripMenuItem ctlContextRemove;
		private System.Windows.Forms.ToolStripMenuItem ctlContextEdit;
		private System.Windows.Forms.TabControl ctlTab;
		private System.Windows.Forms.TabPage ctlStudentPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ctlUsers;
        private System.Windows.Forms.ToolStripMenuItem пользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наградуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem наградуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пользователяToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem наградуToolStripMenuItem2;
        private System.Windows.Forms.DataGridView ctlAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuAwards;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAwards;
    }
}

