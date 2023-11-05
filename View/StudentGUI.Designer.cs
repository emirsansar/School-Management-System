using System.ComponentModel;

namespace SchoolManagementSystem.View;

partial class StudentGuı
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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btn_showBookedLessons = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.btn_showAvailableLessons = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.btn_bookLesson = new System.Windows.Forms.Button();
        this.text_lessonID = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.dataGridView_std = new System.Windows.Forms.DataGridView();
        this.lbl_greeting = new System.Windows.Forms.Label();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.groupBox4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).BeginInit();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btn_showBookedLessons);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Location = new System.Drawing.Point(12, 43);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(163, 76);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        // 
        // btn_showBookedLessons
        // 
        this.btn_showBookedLessons.Location = new System.Drawing.Point(66, 39);
        this.btn_showBookedLessons.Name = "btn_showBookedLessons";
        this.btn_showBookedLessons.Size = new System.Drawing.Size(82, 26);
        this.btn_showBookedLessons.TabIndex = 1;
        this.btn_showBookedLessons.Text = "Show";
        this.btn_showBookedLessons.UseVisualStyleBackColor = true;
        this.btn_showBookedLessons.Click += new System.EventHandler(this.btn_showBookedLessons_Click);
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label1.Location = new System.Drawing.Point(6, 15);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(151, 36);
        this.label1.TabIndex = 0;
        this.label1.Text = "My Booked Lessons:";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.btn_showAvailableLessons);
        this.groupBox2.Controls.Add(this.label2);
        this.groupBox2.Location = new System.Drawing.Point(181, 43);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(149, 76);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        // 
        // btn_showAvailableLessons
        // 
        this.btn_showAvailableLessons.Location = new System.Drawing.Point(49, 39);
        this.btn_showAvailableLessons.Name = "btn_showAvailableLessons";
        this.btn_showAvailableLessons.Size = new System.Drawing.Size(82, 26);
        this.btn_showAvailableLessons.TabIndex = 3;
        this.btn_showAvailableLessons.Text = "Show";
        this.btn_showAvailableLessons.UseVisualStyleBackColor = true;
        this.btn_showAvailableLessons.Click += new System.EventHandler(this.btn_showAvailableLessons_Click);
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label2.Location = new System.Drawing.Point(6, 15);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(139, 36);
        this.label2.TabIndex = 2;
        this.label2.Text = "Available Lessons:";
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.btn_bookLesson);
        this.groupBox3.Controls.Add(this.text_lessonID);
        this.groupBox3.Controls.Add(this.label3);
        this.groupBox3.Location = new System.Drawing.Point(336, 43);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(210, 76);
        this.groupBox3.TabIndex = 2;
        this.groupBox3.TabStop = false;
        // 
        // btn_bookLesson
        // 
        this.btn_bookLesson.Location = new System.Drawing.Point(92, 39);
        this.btn_bookLesson.Name = "btn_bookLesson";
        this.btn_bookLesson.Size = new System.Drawing.Size(112, 26);
        this.btn_bookLesson.TabIndex = 4;
        this.btn_bookLesson.Text = "Book";
        this.btn_bookLesson.UseVisualStyleBackColor = true;
        this.btn_bookLesson.Click += new System.EventHandler(this.btn_bookLesson_Click);
        // 
        // text_lessonID
        // 
        this.text_lessonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.text_lessonID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        this.text_lessonID.Location = new System.Drawing.Point(92, 12);
        this.text_lessonID.Name = "text_lessonID";
        this.text_lessonID.Size = new System.Drawing.Size(112, 22);
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
        this.label3.Text = "Book Lesson:";
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.dataGridView_std);
        this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.groupBox4.Location = new System.Drawing.Point(7, 125);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(539, 224);
        this.groupBox4.TabIndex = 3;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Lessons:";
        // 
        // dataGridView_std
        // 
        this.dataGridView_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView_std.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView_std.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
        this.dataGridView_std.Location = new System.Drawing.Point(3, 18);
        this.dataGridView_std.Name = "dataGridView_std";
        this.dataGridView_std.ReadOnly = true;
        this.dataGridView_std.Size = new System.Drawing.Size(533, 203);
        this.dataGridView_std.TabIndex = 0;
        // 
        // lbl_greeting
        // 
        this.lbl_greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.lbl_greeting.Location = new System.Drawing.Point(12, 9);
        this.lbl_greeting.Name = "lbl_greeting";
        this.lbl_greeting.Size = new System.Drawing.Size(269, 33);
        this.lbl_greeting.TabIndex = 4;
        this.lbl_greeting.Text = "Welcome, Dear ";
        this.lbl_greeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // StudentGuı
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.LightBlue;
        this.ClientSize = new System.Drawing.Size(559, 362);
        this.Controls.Add(this.lbl_greeting);
        this.Controls.Add(this.groupBox4);
        this.Controls.Add(this.groupBox3);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Name = "StudentGuı";
        this.Text = "Student Control Panel";
        this.Load += new System.EventHandler(this.StudentGUI_Load);
        this.groupBox1.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.groupBox4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl_greeting;

    private System.Windows.Forms.DataGridView dataGridView_std;

    private System.Windows.Forms.GroupBox groupBox4;

    private System.Windows.Forms.Button btn_bookLesson;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox text_lessonID;

    private System.Windows.Forms.Button btn_showBookedLessons;
    private System.Windows.Forms.Button btn_showAvailableLessons;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label1;

    #endregion
}