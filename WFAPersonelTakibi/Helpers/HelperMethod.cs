using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPersonelTakibi.Helper
{
    public class HelperMethod
    {
        public static void clearControls(Control cls)
        {
            foreach (Control control in cls.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)control;
                    dt.Value = DateTime.Now;
                }
                else if (control is PictureBox)
                {
                    PictureBox pcb = (PictureBox)control;
                    pcb.Image = null;
                }
                
                   
                
            }
        }
    }
}
