using System.Data;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;


        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        { 
            
            
            
            table = new DataTable();
            dataGridView1.DataSource = table;

            table.Columns.Add("Заголовок", typeof(string));
            table.Columns.Add("Пояснение", typeof(string));

            dataGridView1.Columns["Пояснение"].Visible = false;
            dataGridView1.Columns["Заголовок"].Width = 140;
            

            
            

            
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtTitle.Text.Trim()))
            { 
                MessageBox.Show("Поле Title должно быть заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Записей и так нет, куда жмаешь", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        public void InitMyForm()
        {
            Label label1 = new Label();
            label1.Location = new System.Drawing.Point(80, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 80);
            label1.Text = "Start Position Information";
            this.Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            label1.Text = "The border is " + FormBorderStyle;
        }
    }
}
