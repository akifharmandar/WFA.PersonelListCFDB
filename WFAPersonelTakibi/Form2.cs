namespace WFAPersonelTakibi
{
    using MetroFramework.Forms;
    using Models.Context;
    using System;
    using System.Linq;
    public partial class Form2 : MetroForm
    {

        #region Constructor
        public Form2()
        {
            InitializeComponent();
        }
        #endregion

        MyContext context = new MyContext();

        #region Personel Listesi
        void EmployeeListesi()
        {
            dgvEmployees.DataSource = context.Employees.Select(x => new
            {
                x.Id,
                x.FirstName,
                x.LastName,
                x.Mail,
                x.PhoneNumber,
                x.BirthDate,
                x.Gender,
                Department = x.Department.Name
            }).ToList();
        }

        void EmployeeListesi(Guid id)
        {
            dgvEmployees.DataSource = context
                .Employees
                .Where(x => x.DepartmentId == id)
                .Select(x => new
                {
                    x.Id,
                    x.FirstName,
                    x.LastName,
                    x.Mail,
                    x.PhoneNumber,
                    x.BirthDate,
                    x.Gender,
                    Department = x.Department.Name
                }).ToList();
        }

        #endregion


        private void Form2_Load(object sender, EventArgs e)
        {
            EmployeeListesi();
            cmbDepartmanlar.DataSource = context.Departments.ToList();
            cmbDepartmanlar.DisplayMember = "Name";
            cmbDepartmanlar.ValueMember = "Id";
            cmbDepartmanlar.SelectedIndex = -1;
        }

        private void CmbDepartmanlar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EmployeeListesi((Guid)cmbDepartmanlar.SelectedValue);
        }

        private void TsmDuzenle_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value;

            Form4 frm = new Form4(id);
            this.Hide();
            frm.ShowDialog();
            
        }

        private void TsmSil_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value;
            var employee=context.Employees.Find(id);
            context.Employees.Remove(employee);
            context.SaveChanges();
            EmployeeListesi();
        }

        private void TsmYeni_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void TsmDetay_Click(object sender, EventArgs e)
        {
            Guid id = (Guid)dgvEmployees.SelectedRows[0].Cells[0].Value;

            Form3 frm = new Form3(id);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
