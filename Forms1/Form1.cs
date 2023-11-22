using EmpLib;

namespace Forms1
{
    public partial class Form1 : Form
    {
        Employee KpmgEmp = new Employee();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click2;
            button1.Click += Button1_Click3;

            KpmgEmp.Join += Srikar_Join;
            KpmgEmp.Join += Rohit_Join;
            KpmgEmp.Join += Lekha_Join;
            KpmgEmp.Join += Keerthi_Join;
            KpmgEmp.Resign += Asha_Resign;
            KpmgEmp.Resign += Rekha_Resign;

        }

        private void Rekha_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Asha resigned KPMG successfully");
        }

        private void Asha_Resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Rekha resigned KPMG successfully");
        }

        private void Keerthi_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Keerthi joined KPMG successfully");
        }

        private void Lekha_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Lekha joined KPMG successfully");

        }

        private void Rohit_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Rohit joined KPMG successfully");
        }

        private void Srikar_Join(object? sender, EventArgs e)
        {
            MessageBox.Show("Srikar joined KPMG successfully");
        }

        private void Button1_Click3(object? sender, EventArgs e)
        {
            MessageBox.Show("You clicked this button thrice");
        }

        private void Button1_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("You clicked this button twice");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KpmgEmp.TriggerJoinEvent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KpmgEmp.TriggerResignEvent();
        }
    }
}