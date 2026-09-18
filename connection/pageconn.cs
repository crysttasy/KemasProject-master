using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemasProject
{
    class pageconn
    {
        public static void UntukKemas(Form FormKemas, Panel PanelKemas)
        {
            PanelKemas.Controls.Clear();
            FormKemas.FormBorderStyle = FormBorderStyle.None;
            FormKemas.Dock = DockStyle.Fill;
            PanelKemas.Controls.Add(FormKemas);
            FormKemas.Visible = true;
        }
    }
}
