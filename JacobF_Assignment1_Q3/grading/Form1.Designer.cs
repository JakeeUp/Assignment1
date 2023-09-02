namespace grading
{
    partial class frmGrading
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
            this.txtHomework = new System.Windows.Forms.TextBox();
            this.lblHomework = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinalexam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHomework
            // 
            this.txtHomework.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomework.Location = new System.Drawing.Point(298, 89);
            this.txtHomework.Name = "txtHomework";
            this.txtHomework.Size = new System.Drawing.Size(182, 44);
            this.txtHomework.TabIndex = 0;
            // 
            // lblHomework
            // 
            this.lblHomework.AutoSize = true;
            this.lblHomework.Location = new System.Drawing.Point(120, 108);
            this.lblHomework.Name = "lblHomework";
            this.lblHomework.Size = new System.Drawing.Size(113, 25);
            this.lblHomework.TabIndex = 1;
            this.lblHomework.Text = "Homework";
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(298, 157);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(182, 44);
            this.txtTest.TabIndex = 0;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(120, 176);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(54, 25);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Test";
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(298, 229);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(182, 44);
            this.txtProject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project";
            // 
            // txtFinalexam
            // 
            this.txtFinalexam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalexam.Location = new System.Drawing.Point(298, 293);
            this.txtFinalexam.Name = "txtFinalexam";
            this.txtFinalexam.Size = new System.Drawing.Size(182, 44);
            this.txtFinalexam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final Exam";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(208, 481);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(367, 53);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "show Grade here";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(258, 384);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(263, 68);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 628);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblHomework);
            this.Controls.Add(this.txtFinalexam);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtHomework);
            this.Name = "frmGrading";
            this.Text = "Grading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHomework;
        private System.Windows.Forms.Label lblHomework;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFinalexam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

