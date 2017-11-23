using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIRM
{
    public partial class MainFormView : Form
    {
        static MainFormView Instance;

        static Button Back { get; set; }

        public static void ShowForm(Form m)
        {
            if (Instance == null)
                return;
            var controls = Instance.Controls;

            for (int i = 0; controls.Count > 1;)
            {
                if (controls[i] != Back)
                    controls.RemoveAt(i);
                else
                {
                    i++;
                }
            }

            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            m.Parent = MainFormView.Instance;
            m.FormBorderStyle = FormBorderStyle.None;
            Instance.Text = m.Text;
            
            m.Show();
        }


        public MainFormView()
        {
            InitializeComponent();
            Instance = this;
            ShowForm(new Menu());
        }
        private void MainFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
