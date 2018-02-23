using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDIRM.Navegacao;

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

            Instance.Controls.Clear();
            

            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            m.Parent = MainFormView.Instance;
            m.FormBorderStyle = FormBorderStyle.None;
            Instance.Text = m.Text;

            Instance.Icon = m.Icon;
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
