using DBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP.SetOffTask.School.Forms
{
    public partial class StudentMarks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context context = new Context())
                {
                    if (searchStudentTB.Text != "")
                    {
                        System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@searchline", searchStudentTB.Text);
                        var students = context.Database.SqlQuery<Student>("SELECT * FROM Students WHERE SecondName LIKE @searchline", param);
                        GridView1.DataSource = students.ToList();
                        GridView1.DataBind();
                        labelToChooseStud.Text = "Выберите студента из списка";
                    }
                    else
                    {
                        var students = context.Database.SqlQuery<Student>("SELECT * FROM Students");
                        GridView1.DataSource = students.ToList();
                        GridView1.DataBind();
                        labelToChooseStud.Text = "Выберите студента из списка";
                    }
                }
            }
            catch (Exception ex)
            {
                LabelError.Text = "Что-то пошло не так";
                LabelError.Visible = true;
            }
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Select")
                {
                    int nrow;
                    nrow = Convert.ToInt32(e.CommandArgument.ToString());
                    string nstudentId = GridView1.Rows[nrow].Cells[0].Text;
                    string k = "";


                    using (Context context = new Context())
                    {

                        var sql = "SELECT COUNT(*) FROM Courses";
                        var courseCount = context.Database.SqlQuery<int>(sql).Single();


                        for (int c = 1; c <= courseCount; c++)
                        {
                            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@nstudentId", nstudentId);
                            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@courseId", c);
                            var marks = context.Database.SqlQuery<int>("SELECT Mark FROM Performances WHERE Student_StudentId=@nstudentId AND Course_CourseId=@courseId", param1, param2).ToList();

                            var course = context.Courses.Where(co => co.CourseId == c).SingleOrDefault();


                            string ka = "";
                            foreach (int m in marks)
                            {

                                ka = ka + " " + m.ToString();
                            }

                            k = k + course.CourseName + ": " + ka + "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp    ";

                        }
 

                    }
                    marklist.Text = k;

                }
            }
            catch (Exception ex)
            {
                LabelError.Text = "Что-то пошло не так";
                LabelError.Visible = true;
            }
        }

    }
}