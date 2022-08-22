using System.Runtime.InteropServices;

namespace Inventory_Management
{
    public partial class GetStartedForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundEdges")]
        private static extern IntPtr CreateRoundEdges(
                int nLeft,
                int nRight,
                int nTop,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse


            );
        public GetStartedForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role role = new Role();
            role.Show();
        }
    }
}