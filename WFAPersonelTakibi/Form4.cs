using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace WFAPersonelTakibi
{
    using System;
    using Models.Context;
    using Models.Entities;
    using static Helper.HelperMethod;
    using MetroFramework.Fonts;
    public partial class Form4 : MetroForm
    {
        private Guid _id;

        public Form4()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        public Form4(Guid id) : this()
        {
            this._id = id;
        }
        Employee _employee;
        private void Form4_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = context.Departments.ToList();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

            _employee = context.Employees.Find(_id);
            txtAddress.Text = _employee.Address;
            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            txtMail.Text = _employee.Mail;
            txtPhone.Text = _employee.PhoneNumber;
            cmbDepartment.SelectedValue = _employee.DepartmentId;
            dtBirthDate.Value = _employee.BirthDate;

            var collection = metroPanel1.Controls.Find("rd" + _employee.Gender.ToString(), true);
            RadioButton radio = (RadioButton)collection[0];
            radio.Checked = true;

            pcbImageUrl.Image = Image.FromFile(Environment.CurrentDirectory + @"\..\..\Images\" + _employee.ImageUrl);
        }

      
        private void BtnSave_Click(object sender, EventArgs e)
        {
           

            if (_employee.ImageUrl == null)
            {
                MessageBox.Show(this, "Lütfen bir resim seçiniz!", "Kayıt Bildirimi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _employee.Mail = txtMail.Text;
            _employee.Address = txtAddress.Text;
            _employee.LastName = txtLastName.Text;
            _employee.PhoneNumber = txtPhone.Text;
            _employee.FirstName = txtFirstName.Text;
            _employee.BirthDate = dtBirthDate.Value;

            foreach (var radioButton in metroPanel1.Controls)
            {
                if (radioButton is RadioButton)
                {
                    RadioButton radio = (RadioButton)radioButton;
                    if (radio.Checked)
                    {
                        _employee.Gender = (Gender)Enum.Parse(typeof(Gender), radio.Text);
                    }
                }
            }

            _employee.DepartmentId = (Guid)cmbDepartment.SelectedValue;
            bool result = context.SaveChanges() > 0;
            _employee = null;
            clearControls(this);

            MessageBox.Show(this, result ? "Kayıt Eklendi" : "İşlem Hatası", "Kayıt Ekleme Bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        private void PcbImageUrl_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

               

                pcbImageUrl.Image = Image.FromFile(openFile.FileName);
                _employee.ImageUrl = $"{Guid.NewGuid()}{System.IO.Path.GetExtension(openFile.FileName)}";
                pcbImageUrl.Image.Save($@"{Environment.CurrentDirectory}\..\..\Images\{_employee.ImageUrl}");
                _employee.HasImage = true;
            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
