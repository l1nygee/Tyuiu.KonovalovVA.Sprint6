using Tyuiu.KonovalovVA.Sprint6.Task0.V23.Lib;
namespace Tyuiu.KonovalovVA.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataSerivce ds = new DataSerivce();
            try
            {
                textBox2.Text = Convert.ToString(ds.Calculate(3));
            }
            catch
            {
                MessageBox.Show("������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 | ��������� �������� �������� ������� 23 | ���-24-1", "������ 6", MessageBoxButtons.OK);
        }
    }
}
