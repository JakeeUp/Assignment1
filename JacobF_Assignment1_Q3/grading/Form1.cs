using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grading
{
    public partial class frmGrading : Form
    {
        
        public frmGrading()
        {
            InitializeComponent();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            int homeworkGrade, testGrade, projectworkGrade, finalExamGrade;
            bool hasErrors = HandleGradeErrors(out homeworkGrade, out testGrade, out projectworkGrade, out finalExamGrade);

            if (hasErrors) return; 

            float finalGrade = await HandleGradeCalc(homeworkGrade, testGrade, projectworkGrade, finalExamGrade);
            HandleGradeMessages(finalGrade);
        }

        private bool HandleGradeErrors(out int homeworkGrade, out int testGrade, out int projectworkGrade, out int finalExamGrade)
        {
            //shoutout to last semester game programming 2 final for the list error method
            List<string> errors = new List<string>();

            txtHomework.ForeColor = Color.White;
            txtTest.ForeColor = Color.White;
            txtProject.ForeColor = Color.White;
            txtFinalexam.ForeColor = Color.White;

            if (!int.TryParse(txtHomework.Text, out homeworkGrade) || homeworkGrade < 0 || homeworkGrade > 100)
            {
                txtHomework.ForeColor = System.Drawing.Color.Red;
                errors.Add("Homework");
            }
            if (!int.TryParse(txtTest.Text, out testGrade) || testGrade < 0 || testGrade > 100)
            {
                txtTest.ForeColor = System.Drawing.Color.Red;
                errors.Add("Test");
            }
            if (!int.TryParse(txtProject.Text, out projectworkGrade) || projectworkGrade < 0 || projectworkGrade > 100)
            {
                txtProject.ForeColor = System.Drawing.Color.Red;
                errors.Add("Project");
            }
            if (!int.TryParse(txtFinalexam.Text, out finalExamGrade) || finalExamGrade < 0 || finalExamGrade > 100)
            {
                txtFinalexam.ForeColor = System.Drawing.Color.Red;
                errors.Add("Final Exam");
            }
            if (errors.Count > 0)
            {
                lblFinal.Text = "Error in " + string.Join(",\n", errors);
                return true;  
            }
            return false;
        }

        private async Task<float> HandleGradeCalc(int homeworkGrade, int testGrade, int projectGrade, int finalExam)
        {
            float finalGrade = .15f * homeworkGrade + .25f * testGrade + .20f * projectGrade + .40f * finalExam;
            lblFinal.Text = $"Final Grade : {finalGrade:0.##}%";

            await Task.Delay(3000);
            lblFinal.Text = "";
            return finalGrade;
        }

        private void HandleGradeMessages(float finalGrade)
        {
            if (finalGrade >= 90)
                lblFinal.Text += "You did Amazing!";
            else if (finalGrade >= 80)
                lblFinal.Text += "You did Great!";
            else if (finalGrade >= 70)
                lblFinal.Text += "You did your best!";
            else
                lblFinal.Text += "Talk to me after class!";
        }
    }
}
