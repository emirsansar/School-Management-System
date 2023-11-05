using System.ComponentModel;

namespace SchoolManagementSystem.View;

partial class TeacherGUI
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.lbl_greeting = new System.Windows.Forms.Label();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.dataGridView_teacher = new System.Windows.Forms.DataGridView();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.btn_cancelLesson = new System.Windows.Forms.Button();
        this.text_lessonID = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btn_showTakenLessons = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btn_remainingLessons = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.groupBox4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacher)).BeginInit();
        this.groupBox3.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // lbl_greeting
        // 
        this.lbl_greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.lbl_greeting.Location = new System.Drawing.Point(12, 9);
        this.lbl_greeting.Name = "lbl_greeting";
        this.lbl_greeting.Size = new System.Drawing.Size(269, 33);
        this.lbl_greeting.TabIndex = 5;
        this.lbl_greeting.Text = "Welcome, Dear ";
        this.lbl_greeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.dataGridView_teacher);
        this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.groupBox4.Location = new System.Drawing.Point(7, 127);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(539, 224);
        this.groupBox4.TabIndex = 8;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Lessons:";
        // 
        // dataGridView_teacher
        // 
        this.dataGridView_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView_teacher.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView_teacher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
        this.dataGridView_teacher.Location = new System.Drawing.Point(3, 18);
        this.dataGridView_teacher.Name = "dataGridView_teacher";
        this.dataGridView_teacher.ReadOnly = true;
        this.dataGridView_teacher.Size = new System.Drawing.Size(533, 203);
        this.dataGridView_teacher.TabIndex = 0;
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.btn_cancelLesson);
        this.groupBox3.Controls.Add(this.text_lessonID);
        this.groupBox3.Controls.Add(this.label3);
        this.groupBox3.Location = new System.Drawing.Point(314, 45);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(232, 76);
        this.groupBox3.TabIndex = 7;
        this.groupBox3.TabStop = false;
        // 
        // btn_cancelLesson
        // 
        this.btn_cancelLesson.Location = new System.Drawing.Point(106, 39);
        this.btn_cancelLesson.Name = "btn_cancelLesson";
        this.btn_cancelLesson.Size = new System.Drawing.Size(120, 26);
        this.btn_cancelLesson.TabIndex = 4;
        this.btn_cancelLesson.Text = "Cancel";
        this.btn_cancelLesson.UseVisualStyleBackColor = true;
        this.btn_cancelLesson.Click += new System.EventHandler(this.btn_cancelLesson_Click);
        // 
        // text_lessonID
        // 
        this.text_lessonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.text_lessonID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        this.text_lessonID.Location = new System.Drawing.Point(106, 12);
        this.text_lessonID.Name = "text_lessonID";
        this.text_lessonID.Size = new System.Drawing.Size(120, 22);
        this.text_lessonID.TabIndex = 5;
        this.text_lessonID.Text = "Enter a Lesson ID";
        this.text_lessonID.Click += new System.EventHandler(this.text_lessonID_Click);
        this.text_lessonID.Leave += new System.EventHandler(this.text_lessonID_Leave);
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label3.Location = new System.Drawing.Point(6, 15);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(101, 36);
        this.label3.TabIndex = 4;
        this.label3.Text = "Cancel Lesson:";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btn_showTakenLessons);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Location = new System.Drawing.Point(12, 45);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(117, 76);
        this.groupBox1.TabIndex = 6;
        this.groupBox1.TabStop = false;
        // 
        // btn_showTakenLessons
        // 
        this.btn_showTakenLessons.Location = new System.Drawing.Point(29, 39);
        this.btn_showTakenLessons.Name = "btn_showTakenLessons";
        this.btn_showTakenLessons.Size = new System.Drawing.Size(82, 26);
        this.btn_showTakenLessons.TabIndex = 1;
        this.btn_showTakenLessons.Text = "Show";
        this.btn_showTakenLessons.UseVisualStyleBackColor = true;
        this.btn_showTakenLessons.Click += new System.EventHandler(this.btn_showTakenLessons_Click);
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label1.Location = new System.Drawing.Point(6, 15);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(105, 36);
        this.label1.TabIndex = 0;
        this.label1.Text = "Taken Lessons:";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.btn_remainingLessons);
        this.groupBox2.Controls.Add(this.label2);
        this.groupBox2.Location = new System.Drawing.Point(135, 45);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(146, 76);
        this.groupBox2.TabIndex = 7;
        this.groupBox2.TabStop = false;
        // 
        // btn_remainingLessons
        // 
        this.btn_remainingLessons.Location = new System.Drawing.Point(58, 39);
        this.btn_remainingLessons.Name = "btn_remainingLessons";
        this.btn_remainingLessons.Size = new System.Drawing.Size(82, 26);
        this.btn_remainingLessons.TabIndex = 1;
        this.btn_remainingLessons.Text = "Show";
        this.btn_remainingLessons.UseVisualStyleBackColor = true;
        this.btn_remainingLessons.Click += new System.EventHandler(this.btn_remainingLessons_Click);
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label2.Location = new System.Drawing.Point(6, 15);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(134, 36);
        this.label2.TabIndex = 0;
        this.label2.Text = "Remaining Lessons:";
        // 
        // TeacherGUI
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.LightBlue;
        this.ClientSize = new System.Drawing.Size(555, 358);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox4);
        this.Controls.Add(this.groupBox3);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.lbl_greeting);
        this.Name = "TeacherGUI";
        this.Text = "Teacher Control Panel";
        this.Load += new System.EventHandler(this.TeacherGUI_Load);
        this.groupBox4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacher)).EndInit();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btn_remainingLessons;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.DataGridView dataGridView_teacher;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btn_cancelLesson;
    private System.Windows.Forms.TextBox text_lessonID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btn_showTakenLessons;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label lbl_greeting;

    #endregion
}