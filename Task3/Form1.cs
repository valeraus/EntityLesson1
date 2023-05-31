using Microsoft.EntityFrameworkCore;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var context = new UserbaseContext())
            {
                var users = await context.Users.ToListAsync();

                dataGridView1.DataSource = users;
            }
        }
    }
}