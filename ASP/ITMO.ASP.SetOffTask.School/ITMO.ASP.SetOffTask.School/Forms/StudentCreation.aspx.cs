using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBModel;

namespace ITMO.ASP.SetOffTask.School.Forms
{
    public partial class StudentCreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            try
            {
                Student student = new Student
                {
                    FirstName = firstnameTB.Text,
                    SecondName = secondnameTB.Text,
                    Phone = phoneTB.Text,
                    Email = emailTB.Text,

                };
                context.Students.Add(student);
                context.SaveChanges();
                secondnameTB.Text = String.Empty;
                firstnameTB.Text = String.Empty;
                phoneTB.Text = String.Empty;
                emailTB.Text = String.Empty;

                Label2.Text = "Студент добавлен";
                Label2.Visible = true;
            }
            catch (Exception ex)
            {
                Label2.Text = "Что-то пошло не так";
                Label2.Visible = true;
            }

        }
    }
}