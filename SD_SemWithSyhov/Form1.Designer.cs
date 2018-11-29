namespace SD_SemWithSyhov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labStudentName = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.cbStudentCurrentCourse = new System.Windows.Forms.ComboBox();
            this.labStudentCurrentCourse = new System.Windows.Forms.Label();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.cWDataSet = new SD_SemWithSyhov.CWDataSet();
            this.studentSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentSetTableAdapter = new SD_SemWithSyhov.CWDataSetTableAdapters.StudentSetTableAdapter();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.labTeacherPost = new System.Windows.Forms.Label();
            this.cbTeacherPost = new System.Windows.Forms.ComboBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.labTeacherName = new System.Windows.Forms.Label();
            this.btnCWDelete = new System.Windows.Forms.Button();
            this.btnCWAdd = new System.Windows.Forms.Button();
            this.labCWCouse = new System.Windows.Forms.Label();
            this.cbCWCourse = new System.Windows.Forms.ComboBox();
            this.tbCWTitle = new System.Windows.Forms.TextBox();
            this.labCWTitle = new System.Windows.Forms.Label();
            this.labCWTeacher = new System.Windows.Forms.Label();
            this.cbCWTeacher = new System.Windows.Forms.ComboBox();
            this.labCWStudent = new System.Windows.Forms.Label();
            this.cbCWStudent = new System.Windows.Forms.ComboBox();
            this.labCWMark = new System.Windows.Forms.Label();
            this.cbCWMark = new System.Windows.Forms.ComboBox();
            this.dgvCW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCW)).BeginInit();
            this.SuspendLayout();
            // 
            // labStudentName
            // 
            this.labStudentName.AutoSize = true;
            this.labStudentName.Location = new System.Drawing.Point(12, 12);
            this.labStudentName.Name = "labStudentName";
            this.labStudentName.Size = new System.Drawing.Size(34, 13);
            this.labStudentName.TabIndex = 0;
            this.labStudentName.Text = "ФИО";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(53, 9);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(218, 20);
            this.tbStudentName.TabIndex = 1;
            // 
            // cbStudentCurrentCourse
            // 
            this.cbStudentCurrentCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentCurrentCourse.FormattingEnabled = true;
            this.cbStudentCurrentCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbStudentCurrentCourse.Location = new System.Drawing.Point(53, 35);
            this.cbStudentCurrentCourse.Name = "cbStudentCurrentCourse";
            this.cbStudentCurrentCourse.Size = new System.Drawing.Size(218, 21);
            this.cbStudentCurrentCourse.TabIndex = 2;
            // 
            // labStudentCurrentCourse
            // 
            this.labStudentCurrentCourse.AutoSize = true;
            this.labStudentCurrentCourse.Location = new System.Drawing.Point(12, 38);
            this.labStudentCurrentCourse.Name = "labStudentCurrentCourse";
            this.labStudentCurrentCourse.Size = new System.Drawing.Size(31, 13);
            this.labStudentCurrentCourse.TabIndex = 3;
            this.labStudentCurrentCourse.Text = "Курс";
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(53, 62);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(105, 23);
            this.btnStudentAdd.TabIndex = 4;
            this.btnStudentAdd.Text = "Добавить";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(166, 62);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(105, 23);
            this.btnStudentDelete.TabIndex = 5;
            this.btnStudentDelete.Text = "Удалить";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(15, 91);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(256, 150);
            this.dgvStudent.TabIndex = 6;
            // 
            // cWDataSet
            // 
            this.cWDataSet.DataSetName = "CWDataSet";
            this.cWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentSetBindingSource
            // 
            this.studentSetBindingSource.DataMember = "StudentSet";
            this.studentSetBindingSource.DataSource = this.cWDataSet;
            // 
            // studentSetTableAdapter
            // 
            this.studentSetTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(328, 91);
            this.dgvTeacher.MultiSelect = false;
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(256, 150);
            this.dgvTeacher.TabIndex = 13;
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.Location = new System.Drawing.Point(479, 62);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(105, 23);
            this.btnTeacherDelete.TabIndex = 12;
            this.btnTeacherDelete.Text = "Удалить";
            this.btnTeacherDelete.UseVisualStyleBackColor = true;
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Location = new System.Drawing.Point(366, 62);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(105, 23);
            this.btnTeacherAdd.TabIndex = 11;
            this.btnTeacherAdd.Text = "Добавить";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // labTeacherPost
            // 
            this.labTeacherPost.AutoSize = true;
            this.labTeacherPost.Location = new System.Drawing.Point(325, 38);
            this.labTeacherPost.Name = "labTeacherPost";
            this.labTeacherPost.Size = new System.Drawing.Size(65, 13);
            this.labTeacherPost.TabIndex = 10;
            this.labTeacherPost.Text = "Должность";
            // 
            // cbTeacherPost
            // 
            this.cbTeacherPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacherPost.FormattingEnabled = true;
            this.cbTeacherPost.Items.AddRange(new object[] {
            "Ассистент",
            "Преподаватель",
            "Старший преподаватель",
            "Доцент",
            "Профессор"});
            this.cbTeacherPost.Location = new System.Drawing.Point(396, 35);
            this.cbTeacherPost.Name = "cbTeacherPost";
            this.cbTeacherPost.Size = new System.Drawing.Size(188, 21);
            this.cbTeacherPost.TabIndex = 9;
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(366, 9);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(218, 20);
            this.tbTeacherName.TabIndex = 8;
            // 
            // labTeacherName
            // 
            this.labTeacherName.AutoSize = true;
            this.labTeacherName.Location = new System.Drawing.Point(325, 12);
            this.labTeacherName.Name = "labTeacherName";
            this.labTeacherName.Size = new System.Drawing.Size(34, 13);
            this.labTeacherName.TabIndex = 7;
            this.labTeacherName.Text = "ФИО";
            // 
            // btnCWDelete
            // 
            this.btnCWDelete.Location = new System.Drawing.Point(217, 414);
            this.btnCWDelete.Name = "btnCWDelete";
            this.btnCWDelete.Size = new System.Drawing.Size(105, 23);
            this.btnCWDelete.TabIndex = 19;
            this.btnCWDelete.Text = "Удалить";
            this.btnCWDelete.UseVisualStyleBackColor = true;
            this.btnCWDelete.Click += new System.EventHandler(this.btnCWDelete_Click);
            // 
            // btnCWAdd
            // 
            this.btnCWAdd.Location = new System.Drawing.Point(104, 414);
            this.btnCWAdd.Name = "btnCWAdd";
            this.btnCWAdd.Size = new System.Drawing.Size(105, 23);
            this.btnCWAdd.TabIndex = 18;
            this.btnCWAdd.Text = "Добавить";
            this.btnCWAdd.UseVisualStyleBackColor = true;
            this.btnCWAdd.Click += new System.EventHandler(this.btnCWAdd_Click);
            // 
            // labCWCouse
            // 
            this.labCWCouse.AutoSize = true;
            this.labCWCouse.Location = new System.Drawing.Point(12, 309);
            this.labCWCouse.Name = "labCWCouse";
            this.labCWCouse.Size = new System.Drawing.Size(31, 13);
            this.labCWCouse.TabIndex = 17;
            this.labCWCouse.Text = "Курс";
            // 
            // cbCWCourse
            // 
            this.cbCWCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCWCourse.FormattingEnabled = true;
            this.cbCWCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbCWCourse.Location = new System.Drawing.Point(53, 306);
            this.cbCWCourse.Name = "cbCWCourse";
            this.cbCWCourse.Size = new System.Drawing.Size(269, 21);
            this.cbCWCourse.TabIndex = 16;
            // 
            // tbCWTitle
            // 
            this.tbCWTitle.Location = new System.Drawing.Point(75, 280);
            this.tbCWTitle.Name = "tbCWTitle";
            this.tbCWTitle.Size = new System.Drawing.Size(247, 20);
            this.tbCWTitle.TabIndex = 15;
            // 
            // labCWTitle
            // 
            this.labCWTitle.AutoSize = true;
            this.labCWTitle.Location = new System.Drawing.Point(12, 283);
            this.labCWTitle.Name = "labCWTitle";
            this.labCWTitle.Size = new System.Drawing.Size(57, 13);
            this.labCWTitle.TabIndex = 14;
            this.labCWTitle.Text = "Название";
            // 
            // labCWTeacher
            // 
            this.labCWTeacher.AutoSize = true;
            this.labCWTeacher.Location = new System.Drawing.Point(12, 390);
            this.labCWTeacher.Name = "labCWTeacher";
            this.labCWTeacher.Size = new System.Drawing.Size(86, 13);
            this.labCWTeacher.TabIndex = 21;
            this.labCWTeacher.Text = "Преподаватель";
            // 
            // cbCWTeacher
            // 
            this.cbCWTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCWTeacher.FormattingEnabled = true;
            this.cbCWTeacher.Location = new System.Drawing.Point(104, 387);
            this.cbCWTeacher.Name = "cbCWTeacher";
            this.cbCWTeacher.Size = new System.Drawing.Size(218, 21);
            this.cbCWTeacher.TabIndex = 20;
            // 
            // labCWStudent
            // 
            this.labCWStudent.AutoSize = true;
            this.labCWStudent.Location = new System.Drawing.Point(12, 363);
            this.labCWStudent.Name = "labCWStudent";
            this.labCWStudent.Size = new System.Drawing.Size(47, 13);
            this.labCWStudent.TabIndex = 23;
            this.labCWStudent.Text = "Студент";
            // 
            // cbCWStudent
            // 
            this.cbCWStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCWStudent.FormattingEnabled = true;
            this.cbCWStudent.Location = new System.Drawing.Point(63, 360);
            this.cbCWStudent.Name = "cbCWStudent";
            this.cbCWStudent.Size = new System.Drawing.Size(259, 21);
            this.cbCWStudent.TabIndex = 22;
            // 
            // labCWMark
            // 
            this.labCWMark.AutoSize = true;
            this.labCWMark.Location = new System.Drawing.Point(12, 336);
            this.labCWMark.Name = "labCWMark";
            this.labCWMark.Size = new System.Drawing.Size(45, 13);
            this.labCWMark.TabIndex = 25;
            this.labCWMark.Text = "Оценка";
            // 
            // cbCWMark
            // 
            this.cbCWMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCWMark.FormattingEnabled = true;
            this.cbCWMark.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbCWMark.Location = new System.Drawing.Point(63, 333);
            this.cbCWMark.Name = "cbCWMark";
            this.cbCWMark.Size = new System.Drawing.Size(259, 21);
            this.cbCWMark.TabIndex = 24;
            // 
            // dgvCW
            // 
            this.dgvCW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCW.Location = new System.Drawing.Point(328, 280);
            this.dgvCW.MultiSelect = false;
            this.dgvCW.Name = "dgvCW";
            this.dgvCW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCW.Size = new System.Drawing.Size(256, 157);
            this.dgvCW.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 474);
            this.Controls.Add(this.dgvCW);
            this.Controls.Add(this.labCWMark);
            this.Controls.Add(this.cbCWMark);
            this.Controls.Add(this.labCWStudent);
            this.Controls.Add(this.cbCWStudent);
            this.Controls.Add(this.labCWTeacher);
            this.Controls.Add(this.cbCWTeacher);
            this.Controls.Add(this.btnCWDelete);
            this.Controls.Add(this.btnCWAdd);
            this.Controls.Add(this.labCWCouse);
            this.Controls.Add(this.cbCWCourse);
            this.Controls.Add(this.tbCWTitle);
            this.Controls.Add(this.labCWTitle);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.btnTeacherDelete);
            this.Controls.Add(this.btnTeacherAdd);
            this.Controls.Add(this.labTeacherPost);
            this.Controls.Add(this.cbTeacherPost);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.labTeacherName);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnStudentDelete);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.labStudentCurrentCourse);
            this.Controls.Add(this.cbStudentCurrentCourse);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.labStudentName);
            this.Name = "Form1";
            this.Text = "Курсовые работы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStudentName;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.ComboBox cbStudentCurrentCourse;
        private System.Windows.Forms.Label labStudentCurrentCourse;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private CWDataSet cWDataSet;
        private System.Windows.Forms.BindingSource studentSetBindingSource;
        private CWDataSetTableAdapters.StudentSetTableAdapter studentSetTableAdapter;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Label labTeacherPost;
        private System.Windows.Forms.ComboBox cbTeacherPost;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.Label labTeacherName;
        private System.Windows.Forms.Button btnCWDelete;
        private System.Windows.Forms.Button btnCWAdd;
        private System.Windows.Forms.Label labCWCouse;
        private System.Windows.Forms.ComboBox cbCWCourse;
        private System.Windows.Forms.TextBox tbCWTitle;
        private System.Windows.Forms.Label labCWTitle;
        private System.Windows.Forms.Label labCWTeacher;
        private System.Windows.Forms.ComboBox cbCWTeacher;
        private System.Windows.Forms.Label labCWStudent;
        private System.Windows.Forms.ComboBox cbCWStudent;
        private System.Windows.Forms.Label labCWMark;
        private System.Windows.Forms.ComboBox cbCWMark;
        private System.Windows.Forms.DataGridView dgvCW;
    }
}

