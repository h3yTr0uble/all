using Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForms
{
	public partial class AwardForm : Form
	{
		private string title;
		private string description;

		private bool createNew = true;


		#region Properties

		public string Title
		{
			get
			{
				return title;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
		}


		#endregion

		public AwardForm()
		{
			InitializeComponent();
        }

		public AwardForm(Award award)
		{
			InitializeComponent();

            this.title = award.Title;
            this.description = award.Description;

            createNew = false;
		}

		private void Form_Load(object sender, EventArgs e)
		{
            txtTitle.Text=title;
            txtDescription.Text=description;

            if (createNew == true)
			{
				this.Text = "Добавление новой награды";
				btnOK.Text = "Создать";
			}
			else
			{
				this.Text = "Редактирование записи о награде";
				btnOK.Text = "Обновить";
			}
		}

		private void OK_Click(object sender, EventArgs e)
		{
            title = txtTitle.Text;
            description = txtDescription.Text;

            if (this.ValidateChildren() == true)
			{
				this.DialogResult = DialogResult.OK;
			}
			else 
			{
				this.DialogResult = DialogResult.None;
			}
		}

		private void Title_Validating(object sender, CancelEventArgs e)
		{
            String_Validating(txtTitle, sender, e);
		}

		private void Title_Validated(object sender, EventArgs e)
		{
			title = txtTitle.Text;
		}

        private void String_Validating(TextBox txt, object sender, CancelEventArgs e)
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
    }
}
