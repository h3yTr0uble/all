using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForms
{
	public partial class UserForm : Form
	{
		private string firstName;
		private string lastName;
		private DateTime birthdate;
        private List<Award> userAwards;
        private List<Award> awards;

        private bool createNew = true;


		#region Properties

        public List<Award> UserAwards
        {
            get
            {
                return userAwards;
            }
        }

		public string FirstName
		{
			get
			{
				return firstName;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
		}

		public DateTime Birthdate
        {
			get
			{
				return birthdate;
			}
		}

		#endregion

		public UserForm(AwardBL awards)
		{
			InitializeComponent();
            this.awards = awards.GetList();
        }

		public UserForm(User user, AwardBL awards)
		{
			InitializeComponent();

            this.firstName = user.FirstName;
            this.lastName = user.LastName;
            this.birthdate = user.Birthdate;
            this.userAwards = user.Awards;
            this.awards = awards.GetList();

            createNew = false;
		}

		private void Form_Load(object sender, EventArgs e)
		{
            txtFirstName.Text=firstName;
            txtLastName.Text=lastName;
            foreach (var award in awards)
            {
                ctlAwards.Items.Add(award.Title);
                if (userAwards!=null)
                {
                    foreach (var userAward in userAwards)
                    {
                        if (award.Id == userAward.Id)
                        {
                            ctlAwards.SelectedIndex = ctlAwards.Items.Count - 1;
                            break;
                        }
                    }
                }
               
            }
            if (!createNew)
            {
                ctlBirthdate.Value = birthdate;
            }
            if (createNew == true)
			{
                userAwards = new List<Award>();
				this.Text = "Добавление нового пользователя";
				btnOK.Text = "Создать";
			}
			else
			{
				this.Text = "Редактирование записи о пользователе";
				btnOK.Text = "Обновить";
			}
		}

		private void OK_Click(object sender, EventArgs e)
		{
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            birthdate = ctlBirthdate.Value.Date;

            if (this.ValidateChildren() == true)
			{
                userAwards?.Clear();
                for (int i = 0; i < ctlAwards.Items.Count; i++)
                {
                    if (ctlAwards.GetSelected(i))
                    {
                        userAwards.Add(awards[i]);
                    }
                }
				this.DialogResult = DialogResult.OK;
			}
			else 
			{
				this.DialogResult = DialogResult.None;
			}
		}

		private void FirstName_Validating(object sender, CancelEventArgs e)
		{
            Name_Validating(txtFirstName, sender, e);
		}

		private void FullName_Validated(object sender, EventArgs e)
		{
			firstName = txtFirstName.Text;
		}

        private void Name_Validating(TextBox txt, object sender, CancelEventArgs e)
        {
            string input = txt.Text.Trim();

            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(txt, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txt, String.Empty);
                e.Cancel = false;
            }
        }


		private void LastName_Validating(object sender, CancelEventArgs e)
		{
            Name_Validating(txtLastName, sender, e);
        }

		private void LastName_Validated(object sender, EventArgs e)
		{
			lastName = txtLastName.Text;
		}

		private void Birthdate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
            var input = ctlBirthdate.Value.Date;

            if (input>=DateTime.Now.Date)
            {
                errorProvider.SetError(ctlBirthdate, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(ctlBirthdate, String.Empty);
                e.Cancel = false;
            }
        }

		private void Birthdate_Validated(object sender, EventArgs e)
		{
			birthdate = ctlBirthdate.Value.Date;
		}
	}
}
