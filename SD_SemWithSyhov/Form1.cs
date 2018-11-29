using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_SemWithSyhov
{
    public partial class Form1 : Form
    {
        private Model1Container _cont;

        public Form1()
        {
            InitializeComponent();
            _cont = new Model1Container();
        }

        /// <summary>
        /// Добавление студента
        /// </summary>
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            if (tbStudentName.Text.Trim(' ') == "" || cbStudentCurrentCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля.", "Ошибка!");
                return;
            }

            Student s = new Student
            {
                Name = tbStudentName.Text.Trim(' '),
                CurrentCourse = byte.Parse(cbStudentCurrentCourse.Text)
            };

            _cont.StudentSet.Add(s);
            _cont.SaveChanges();

            tbStudentName.Text = "";
            cbStudentCurrentCourse.SelectedIndex = -1;

            RefreshDgvStudent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDgvStudent();
            RefreshDgvTeacher();
            RefreshDgvCW();
        }

        /// <summary>
        /// Удаление студента
        /// </summary>
        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            Student s = _cont.StudentSet.Find(dgvStudent.SelectedRows[0].Cells[0].Value);

            _cont.StudentSet.Remove(s);
            _cont.SaveChanges();

            RefreshDgvStudent();
        }

        /// <summary>
        /// Обновление DataGridView для Student
        /// </summary>
        private void RefreshDgvStudent()
        {
            if (_cont.StudentSet.Any())
            {
                dgvStudent.DataSource = _cont.StudentSet.ToList();
                cbCWStudent.DataSource = _cont.StudentSet.ToList();
                cbCWStudent.DisplayMember = "Name";
            }

            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[3].Visible = false;
        }

        /// <summary>
        /// Обновление DataGridView для Teacher
        /// </summary>
        private void RefreshDgvTeacher()
        {
            if (_cont.TeacherSet.Any())
            {
                dgvTeacher.DataSource = _cont.TeacherSet.ToList();
                cbCWTeacher.DataSource = _cont.TeacherSet.ToList();
                cbCWTeacher.DisplayMember = "Name";
            }

            dgvTeacher.Columns[0].Visible = false;
            dgvTeacher.Columns[3].Visible = false;
        }

        /// <summary>
        /// Обновление DataGridView для Teacher
        /// </summary>
        private void RefreshDgvCW()
        {
            if (_cont.CourseWorkSet.Any())
            {
                dgvCW.DataSource = _cont.CourseWorkSet.ToList();
            }

            dgvCW.Columns[0].Visible = false;
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            if (tbTeacherName.Text.Trim(' ') == "" || cbTeacherPost.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля.", "Ошибка!");
                return;
            }

            Teacher t = new Teacher
            {
                Name = tbTeacherName.Text.Trim(' '),
                Post = (TPost)cbTeacherPost.SelectedIndex
            };

            _cont.TeacherSet.Add(t);
            _cont.SaveChanges();

            tbTeacherName.Text = "";
            cbTeacherPost.SelectedIndex = -1;

            RefreshDgvTeacher();
        }

        private void btnCWAdd_Click(object sender, EventArgs e)
        {
            if (tbCWTitle.Text.Trim(' ') == "" || cbCWCourse.SelectedIndex == -1 || cbCWMark.SelectedIndex == -1 ||
                cbCWStudent.SelectedIndex == -1 || cbCWTeacher.SelectedIndex == -1) 
            {
                MessageBox.Show("Заполните все поля.", "Ошибка!");
                return;
            }

            CourseWork cw = new CourseWork()
            {
                Title = tbCWTitle.Text.Trim(' '),
                Mark = cbCWMark.Text,
                Course = byte.Parse(cbCWCourse.Text),
                Student = _cont.StudentSet.Find(((Student)cbCWStudent.SelectedValue).Id),
                Teacher = _cont.TeacherSet.Find(((Teacher)cbCWTeacher.SelectedValue).Id)
            };

            _cont.CourseWorkSet.Add(cw);
            _cont.SaveChanges();

            tbCWTitle.Text = "";
            cbCWMark.SelectedIndex = -1;
            cbCWCourse.SelectedIndex = -1;
            cbCWStudent.SelectedIndex = -1;
            cbCWTeacher.SelectedIndex = -1;

            RefreshDgvCW();
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            Teacher t = _cont.TeacherSet.Find(dgvTeacher.SelectedRows[0].Cells[0].Value);

            _cont.TeacherSet.Remove(t);
            _cont.SaveChanges();

            RefreshDgvTeacher();
        }

        private void btnCWDelete_Click(object sender, EventArgs e)
        {
            CourseWork cw = _cont.CourseWorkSet.Find(dgvCW.SelectedRows[0].Cells[0].Value);

            _cont.CourseWorkSet.Remove(cw);
            _cont.SaveChanges();

            RefreshDgvCW();
        }
    }
}
