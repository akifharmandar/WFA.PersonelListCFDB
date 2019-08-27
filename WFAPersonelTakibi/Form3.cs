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
using System.Data.Entity;
using WFAPersonelTakibi.Models.Context;
using WFAPersonelTakibi.Models.Entities;
using System.Reflection;


namespace WFAPersonelTakibi
{
    
    public partial class Form3 : MetroForm
    {
        private Guid _id;
        public Form3()
        {
            InitializeComponent();
        }
        MyContext contex = new MyContext();
        
        public Form3(Guid id):this()
        {
            this._id = id;
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            Employee employee = contex.Employees.Find(_id);
            foreach (PropertyInfo property in employee.GetType().GetProperties())
            {
                var controls = this.Controls.Find(property.Name, true);
                if (controls.Length > 0)
                {
                    if (controls[0] is Label)
                {
                    controls[0].Text = property.GetValue(employee).ToString();
                }
                else if (controls[0] is PictureBox)
                {
                    PictureBox pcb = (PictureBox)controls[0];
                    pcb.Image = System.Drawing.Image.FromFile(Environment.CurrentDirectory + @"\..\..\Images\" + property.GetValue(employee).ToString());
                }
                }
            }


        }
    }
}
