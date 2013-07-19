using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TestMyLib
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text+";";
            string CommandText = "select * from people";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            if (result.HasError == false)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = result.ResultData.DefaultView;
                MessageBox.Show("найдено записей: "+result.ResultData.Rows.Count.ToString());
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "select people.e_id, people.surname, people.fname, people.birth, razryad.razryad,razryad.zvanie, razryad.date_zvanie, razryad.sud_kval, razryad.date_sud_kval,razryad.tren_kat, razryad.date_tren_kat from people join razryad USING(e_id)";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            if (result.HasError == false)
            {
                dataGridView2.Columns.Clear();
                dataGridView2.DataSource = result.ResultData.DefaultView;
                MessageBox.Show("найдено записей: " + result.ResultData.Rows.Count.ToString());
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "select people.e_id, people.surname, people.fname, people.birth, sorevnovaniya.date_sor, sorevnovaniya.name_sor, sorevnovaniya.mesto, sorevnovaniya.sud_dolgn from people join sorevnovaniya USING(e_id)";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            if (result.HasError == false)
            {
                dataGridView4.Columns.Clear();
                dataGridView4.DataSource = result.ResultData.DefaultView;
                MessageBox.Show("найдено записей: " + result.ResultData.Rows.Count.ToString());
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

   
    

        private void button7_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "insert into people (surname,fname,otch,birth,raion,town,street,home_index,phone,email,educ,work) values ('"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+maskedTextBox1.Text+"','"+comboBox1.Text +"','"+textBox7.Text+"','"+textBox8.Text+"',"+textBox9.Text+","+textBox10.Text+",'"+textBox11.Text+"','"+textBox12.Text+"','"+textBox13.Text+"')";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button1_Click(sender, e);
        }

   

        private void button8_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "update people set surname = '"+textBox4.Text+"', fname = '"+textBox5.Text+"', otch = '"+textBox6.Text+"', birth = '"+maskedTextBox1.Text+"', raion = '"+comboBox1.Text+"', town = '"+textBox7.Text+"', street = '"+textBox8.Text+"', home_index = "+textBox9.Text+", phone = "+textBox10.Text+", email = '"+textBox11.Text+"', educ = '"+textBox12.Text+"', work = '"+textBox13.Text+"' where people.e_id = "+textBox14.Text+";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button1_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "select * from people where surname like '"+textBox3.Text+"';";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            if (result.HasError == false)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = result.ResultData.DefaultView;
                MessageBox.Show("найдено записей: " + result.ResultData.Rows.Count.ToString());
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        

        

        

        private void button15_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "insert into razryad (e_id, razryad, zvanie, date_zvanie, sud_kval, date_sud_kval, tren_kat, date_tren_kat) values ("+textBox18.Text+", '"+comboBox2.Text+"', '"+textBox19.Text+"', '"+maskedTextBox6.Text+"', '"+comboBox3.Text+"', '"+maskedTextBox7.Text+"', '"+comboBox4.Text+"', '"+maskedTextBox8.Text+"')";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button2_Click(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "update razryad set e_id="+textBox18.Text+",razryad.razryad = '" + comboBox2.Text + "',zvanie='" + textBox19.Text + "',date_zvanie='" + maskedTextBox6.Text + "',sud_kval='" + comboBox3.Text + "',date_sud_kval='" + maskedTextBox7.Text + "',tren_kat='" + comboBox4.Text + "',date_tren_kat='" + maskedTextBox8.Text + "' where razryad.e_id = " + textBox18.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button2_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "delete FROM razryad where razryad.e_id = " + textBox17.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button2_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "select people.e_id, people.surname, people.fname, people.birth, razryad.razryad,razryad.zvanie, razryad.date_zvanie, razryad.sud_kval, razryad.date_sud_kval,razryad.tren_kat, razryad.date_tren_kat from people join razryad USING(e_id) where razryad.e_id="+textBox17.Text+";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            if (result.HasError == false)
            {
                dataGridView2.Columns.Clear();
                dataGridView2.DataSource = result.ResultData.DefaultView;
                MessageBox.Show("найдено записей: " + result.ResultData.Rows.Count.ToString());
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "select people.e_id, people.surname, people.fname, people.birth, sorevnovaniya.date_sor, sorevnovaniya.name_sor, sorevnovaniya.mesto, sorevnovaniya.sud_dolgn from people join sorevnovaniya USING(e_id) where sorevnovaniya.e_id=" + textBox20.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            if (result.HasError == false)
            {
                dataGridView4.Columns.Clear();
                dataGridView4.DataSource = result.ResultData.DefaultView;
                MessageBox.Show("найдено записей: " + result.ResultData.Rows.Count.ToString());
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "delete FROM sorevnovaniya where sorevnovaniya.e_id = " + textBox20.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button4_Click(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "insert into sorevnovaniya (e_id, date_sor, name_sor, mesto, sud_dolgn) values (" + textBox21.Text + ", '" + maskedTextBox9.Text + "', '" + textBox22.Text + "', '" + textBox23.Text + "', '" + textBox24.Text + "')";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button4_Click(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "update sorevnovaniya set e_id=" + textBox21.Text + ",date_sor = '" + maskedTextBox9.Text + "',name_sor='" + textBox22.Text + "',mesto='" + textBox23.Text + "',sud_dolgn='" + textBox24.Text + "' where sorevnovaniya.e_id = " + textBox21.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button4_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            /*ExcelApp.Cells[1, 1] = "id";
            ExcelApp.Cells[1, 2] = "fam";
            ExcelApp.Cells[1, 3] = "name";
            ExcelApp.Cells[1, 4] = "otch";
            ExcelApp.Cells[1, 5] = "date";
            ExcelApp.Cells[1, 6] = "raion";
            ExcelApp.Cells[1, 7] = "town";
            ExcelApp.Cells[1, 8] = "adress";
            ExcelApp.Cells[1, 9] = "index";
            ExcelApp.Cells[1, 10] = "phone";
            ExcelApp.Cells[1, 11] = "email";
            ExcelApp.Cells[1, 12] = "educ";
            ExcelApp.Cells[1, 13] = "work";*/
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                ExcelApp.Cells[1, i+1] = dataGridView1.Columns[i].HeaderText;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    ExcelApp.Cells[j+2,i+1] = (dataGridView1[i,j].Value);
                }
            }
            ExcelApp.Visible = true;
            //ExcelApp.Quit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sis_diag = new System.Diagnostics.Stopwatch();
            sis_diag.Start();
            Random r = new Random();
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            for (int i = 0; i < Convert.ToInt32(textBox15.Text); i++)
            {
                int id = r.Next(1000);
                string CommandText = "insert into people (e_id,surname,fname,otch,birth,raion,town,street,home_index,phone,email,educ,work) values (" + id + ",'" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + maskedTextBox1.Text + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "'," + r.Next(1000).ToString() + "," + r.Next(1000).ToString() + ",'" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "')";
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
                CommandText = "delete FROM people where people.e_id = " + id.ToString() + ";";
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            }
            MessageBox.Show("Result: " + sis_diag.Elapsed.ToString());
            sis_diag.Stop();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            string CommandText = "delete FROM attestaciya where attestaciya.e_id = " + textBox14.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            CommandText = "delete FROM events where events.e_id = " + textBox14.Text + ";";
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            CommandText = "delete FROM razryad where razryad.e_id = " + textBox14.Text + ";";
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            CommandText = "delete FROM sorevnovaniya where sorevnovaniya.e_id = " + textBox14.Text + ";";
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            CommandText = "delete FROM people where people.e_id = " + textBox14.Text + ";";
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
            MessageBox.Show("Выполнено");
            button1_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sis_diag = new System.Diagnostics.Stopwatch();
            sis_diag.Start();
            Random r = new Random();
            string all = "select * from people";
            string Connect = "Database=tourist;Data Source=localhost;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";";
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            for (int i = 0; i < Convert.ToInt32(textBox15.Text); i++)
            {
                int id = r.Next(1000);
                string CommandText = "insert into people (e_id,surname,fname,otch,birth,raion,town,street,home_index,phone,email,educ,work) values (" + id + ",'" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + maskedTextBox1.Text + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "'," + r.Next(1000).ToString() + "," + r.Next(1000).ToString() + ",'" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "','" + r.Next(1000).ToString() + "')";
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(all, Connect);
                dataGridView1.DataSource = result.ResultData.DefaultView;
                CommandText = "delete FROM people where people.e_id = " + id.ToString() + ";";
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(CommandText, Connect);
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(all, Connect);
                dataGridView1.DataSource = result.ResultData.DefaultView;
            }
            MessageBox.Show("Result: " + sis_diag.Elapsed.ToString());
            sis_diag.Stop();
        }


        

        

        

        

    }
}
