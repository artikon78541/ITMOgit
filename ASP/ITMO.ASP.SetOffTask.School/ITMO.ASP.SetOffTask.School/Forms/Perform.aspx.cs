using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ITMO.ASP.SetOffTask.School.Forms
{
    public partial class Perform : System.Web.UI.Page
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
                Label1.Text = "Что-то пошло не так";
                Label1.Visible = true;
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
                    studentIdTB.Text = nstudentId;
                    studentIdTB.Enabled = false;

                    string nStudentName = GridView1.Rows[nrow].Cells[1].Text + " " + GridView1.Rows[nrow].Cells[2].Text;
                    studentName.Text = nStudentName;
                    studentName.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Что-то пошло не так";
                Label1.Visible = true;
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(MarkTB.Text) > 1 && Convert.ToInt32(MarkTB.Text) < 6)
                {
                    Context context = new Context();

                    int StudentIdNumber = Convert.ToInt16(studentIdTB.Text);
                    var selectedStudent = context.Students.Where(s => s.StudentId == StudentIdNumber).SingleOrDefault();
                    var selectedCourse = context.Courses.Where(c => c.CourseName == DropDownList1.Text).SingleOrDefault();



                    Performance mark = new Performance
                    {
                        Mark = Convert.ToInt32(MarkTB.Text),
                        Student = selectedStudent,
                        Course = selectedCourse
                    };
                    context.Performances.Add(mark);
                    context.SaveChanges();

                    MarkTB.Text = String.Empty;

                    Label1.Text = "Данные внесены";
                    Label1.Visible = true;

                    if (Label3.Visible)
                        Label3.Visible = false;


                }
                else
                {
                    if(Label1.Visible)
                        Label1.Visible = false;
                    Label3.Text = "Оценка должна быть в диапазоне от 1 до 5";
                    Label3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                if (Label1.Visible)
                    Label1.Visible = false;
                Label1.Text = "Что-то пошло не так";
                Label1.Visible = true;
                Label3.Text = "Оценка должна быть в диапазоне от 1 до 5";
                Label3.Visible = true;
            }

        }
    }
}