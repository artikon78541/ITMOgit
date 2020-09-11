using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP.SetOffTask.School.Forms
{
    public partial class CourseCreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Context context = new Context();
                try
                {
                    Course course = new Course
                    {
                        CourseName = newCourseTB.Text,
                    };
                    context.Courses.Add(course);
                    context.SaveChanges();
                    newCourseTB.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    Response.Redirect("Ошибка: " + ex.ToString());
                }
            }
            catch
            {
                LabelError.Text = "Что-то пошло не так";
                LabelError.Visible = true;
            }
        }
    }
}