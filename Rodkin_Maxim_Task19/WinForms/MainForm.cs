using Department.BLL;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
	public partial class MainForm : Form
	{
		private enum SortMode { Asceding, Desceding };

		public readonly UserBL users;
        public readonly AwardBL awards;

        private SortMode userSortMode = SortMode.Asceding;
        private SortMode awardSortMode = SortMode.Asceding;


        public MainForm()
		{
			users = new UserBL();
            awards = new AwardBL();
            InitializeComponent();
			
			//
			this.Visible = false;
		}

		private void FileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
            ctlAwards.DataSource = awards.InitList();
            ctlUsers.AutoGenerateColumns = false;

            ctlUsers.DataSource = users.InitList();
            ctlAwards.AutoGenerateColumns = false;
        }

     

        private void DisplayUsers()
		{
			// Data binding
			ctlUsers.DataSource = null;
			ctlUsers.DataSource = users.GetList();
        }

        private void DisplayAwards()
        {
            // Data binding
            ctlAwards.DataSource = null;
            ctlAwards.DataSource = awards.GetList();
        }

        private void Users_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			EditSelectedUser();
		}

		private void UserRegister_Click(object sender, EventArgs e)
		{
			RegisterNewUser();
		}

		private void UserEdit_Click(object sender, EventArgs e)
		{
			EditSelectedUser();
		}

		private void UserRemove_Click(object sender, EventArgs e)
		{
			RemoveSelectedUser();
		}



		private void RegisterNewUser()
		{
			UserForm form = new UserForm(awards);

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				users.Add(form.FirstName, form.LastName, form.Birthdate, form.UserAwards);
				DisplayUsers();
			}
		}

		private void EditSelectedUser()
		{
			if (ctlUsers.SelectedCells.Count > 0)
			{
				User user = (User) ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;

                UserForm form = new UserForm(user, awards);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.Birthdate = form.Birthdate;
                    user.Awards = form.UserAwards;
                    users.Edit(user);
                    DisplayUsers();
                }
            }


		}

		private void RemoveSelectedUser()
		{
			if (ctlUsers.SelectedCells.Count > 0)
			{
				User user = (User) ctlUsers.SelectedCells[0].OwningRow.DataBoundItem;

                users.Remove(user);
                DisplayUsers();
            }
		}


        private void AwardRegister_Click(object sender, EventArgs e)
        {
            RegisterNewAward();
        }

        private void AwardEdit_Click(object sender, EventArgs e)
        {
            EditSelectedAward();
        }

        private void AwardRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedAward();
        }



        private void RegisterNewAward()
        {
            AwardForm form = new AwardForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                awards.Add(form.Title, form.Description);
                DisplayAwards();
            }
        }

        private void EditSelectedAward()
        {
            if (ctlAwards.SelectedCells.Count > 0)
            {
                Award award = (Award)ctlAwards.SelectedCells[0].OwningRow.DataBoundItem;

                AwardForm form = new AwardForm(award);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    award.Title = form.Title;
                    award.Description = form.Description;
                    awards.Edit(award);
                    DisplayAwards();
                    DisplayUsers();
                }
            }
        }

        private void RemoveSelectedAward()
        {
            if (ctlUsers.SelectedCells.Count > 0)
            {
                Award award = (Award)ctlAwards.SelectedCells[0].OwningRow.DataBoundItem;

                awards.Remove(award);
                awards.Remove(award, users);
                DisplayAwards();
                DisplayUsers();
            }
        }



        private void SortUsers(IEnumerable<User> SortUsersAsc, IEnumerable<User> SortUsersDesc)
        {
            ctlUsers.DataSource = null;
            if (userSortMode == SortMode.Asceding)
            {
                ctlUsers.DataSource = SortUsersAsc;
                userSortMode = SortMode.Desceding;
            }
            else
            {
                ctlUsers.DataSource = SortUsersDesc;
                userSortMode = SortMode.Asceding;
            }
        }


        private void ctlUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    SortUsers(users.SortUsersByFirstNameDesc(), users.SortUsersByFirstNameAsc());
                    break;
                case 2:
                    SortUsers(users.SortUsersByLastNameDesc(), users.SortUsersByLastNameAsc());
                    break;
                case 3:
                    SortUsers(users.SortUsersByBirthdateDesc(), users.SortUsersByBirthdateAsc());
                    break;
                case 4:
                    SortUsers(users.SortUsersByAgeDesc(), users.SortUsersByAgeAsc());
                    break;
            }
        }

        private void ctlAwards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                ctlAwards.DataSource = null;
                if (awardSortMode == SortMode.Asceding)
                {
                    ctlAwards.DataSource = awards.SortAwardsByTitleAsc();
                    awardSortMode = SortMode.Desceding;
                }
                else
                {
                    ctlAwards.DataSource = awards.SortAwardsByTitleDesc();
                    awardSortMode = SortMode.Asceding;
                }
            }
        }


    }
}

