using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public static  class Helper
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (var item in collection)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }else if (item is TextBox)
                {
                    ((TextBox)item).Text= "";

                }else if (item is RadioButton)
                {
                    RadioButton rdr = item as RadioButton;
                    
                    if (rdr.Name == "rdoKucuk")
                        rdr.Checked = true;
                    else
                        ((RadioButton)item).Checked= false;

                }else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
            }
        }

    }
}
