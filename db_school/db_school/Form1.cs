using Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace db_school
{
	public class Form1 : Form
	{
		private IContainer components;
		private TextBox userName;
		private TextBox userPassword;
		private Button button1;
		private BindingSource personBindingSource;
		private TabControl tabControl1;
		private TabPage persons;
		private TabPage qualification;
		private Label name;
		private Label password;
		private Button button2;
		private TextBox textBox1;
		private TabPage events;
		private TextBox textBox2;
		private Button button3;
		private DataGridView dataGridView2;
		private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categorydateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn judgecategoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn judgecategorydateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn trainercategoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn trainercategorydateDataGridViewTextBoxColumn;
		private BindingSource qualificationBindingSource;
		private DataGridView dataGridView3;
		private BindingSource eventBindingSource;
		private TextBox textBox3;
		private Button button4;
		private Button button8;
		private Button button7;
		private Button button6;
		private Label label8;
		private Button button5;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox textBox8;
		private TextBox textBox7;
		private TextBox textBox6;
		private MaskedTextBox maskedTextBox1;
		private TextBox textBox5;
		private TextBox textBox4;
		private Label label1;
		private MaskedTextBox maskedTextBox4;
		private MaskedTextBox maskedTextBox3;
		private MaskedTextBox maskedTextBox2;
		private TextBox textBox11;
		private TextBox textBox10;
		private TextBox textBox9;
		private Button button9;
		private Label label15;
		private Label label14;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label9;
		private Button button11;
		private Button button14;
		private Button button13;
		private Button button12;
		private Label label20;
		private TextBox textBox14;
		private Label label19;
		private Label label18;
		private Label label17;
		private Label label16;
		private MaskedTextBox maskedTextBox5;
		private TextBox textBox13;
		private TextBox textBox12;
		private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn judgepostDataGridViewTextBoxColumn;
		private TextBox textBox15;
		private Label label21;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem экспортВExcelИзлюдиToolStripMenuItem;
		private ToolStripMenuItem экспортВExcelИзмероприятияToolStripMenuItem;
		private ToolStripMenuItem экспортВExcelИзмероприятияToolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripMenuItem оПрограммеToolStripMenuItem;
		private ToolStripMenuItem помощьToolStripMenuItem;
		private Label label22;
		private TextBox textBox16;
		private Label label23;
		private TextBox textBox17;
		private Label label24;
		private TextBox textBox18;
		private Label label25;
		private TextBox textBox19;
		private Label label27;
		private TextBox textBox21;
		private Label label26;
		private TextBox textBox20;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn otchDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn homeindexDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn qualificationsDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn eventsDataGridViewTextBoxColumn;
		private Button button10;
		private TextBox textBox22;
		private Label label28;
		private Button button15;
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.components = new Container();
			this.userName = new TextBox();
			this.userPassword = new TextBox();
			this.button1 = new Button();
			this.tabControl1 = new TabControl();
			this.persons = new TabPage();
			this.button8 = new Button();
			this.button7 = new Button();
			this.button6 = new Button();
			this.label8 = new Label();
			this.button5 = new Button();
			this.label7 = new Label();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.textBox8 = new TextBox();
			this.textBox7 = new TextBox();
			this.textBox6 = new TextBox();
			this.maskedTextBox1 = new MaskedTextBox();
			this.textBox5 = new TextBox();
			this.textBox4 = new TextBox();
			this.label1 = new Label();
			this.button2 = new Button();
			this.textBox1 = new TextBox();
			this.qualification = new TabPage();
			this.button11 = new Button();
			this.label15 = new Label();
			this.label14 = new Label();
			this.label13 = new Label();
			this.label12 = new Label();
			this.label11 = new Label();
			this.label10 = new Label();
			this.label9 = new Label();
			this.maskedTextBox4 = new MaskedTextBox();
			this.maskedTextBox3 = new MaskedTextBox();
			this.maskedTextBox2 = new MaskedTextBox();
			this.textBox11 = new TextBox();
			this.textBox10 = new TextBox();
			this.textBox9 = new TextBox();
			this.button9 = new Button();
			this.textBox2 = new TextBox();
			this.button3 = new Button();
			this.dataGridView2 = new DataGridView();
			this.events = new TabPage();
			this.label21 = new Label();
			this.textBox15 = new TextBox();
			this.button14 = new Button();
			this.button13 = new Button();
			this.button12 = new Button();
			this.label20 = new Label();
			this.textBox14 = new TextBox();
			this.label19 = new Label();
			this.label18 = new Label();
			this.label17 = new Label();
			this.label16 = new Label();
			this.maskedTextBox5 = new MaskedTextBox();
			this.textBox13 = new TextBox();
			this.textBox12 = new TextBox();
			this.textBox3 = new TextBox();
			this.button4 = new Button();
			this.dataGridView3 = new DataGridView();
			this.name = new Label();
			this.password = new Label();
			this.menuStrip1 = new MenuStrip();
			this.toolStripMenuItem1 = new ToolStripMenuItem();
			this.экспортВExcelИзлюдиToolStripMenuItem = new ToolStripMenuItem();
			this.экспортВExcelИзмероприятияToolStripMenuItem = new ToolStripMenuItem();
			this.экспортВExcelИзмероприятияToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new ToolStripMenuItem();
			this.помощьToolStripMenuItem = new ToolStripMenuItem();
			this.textBox16 = new TextBox();
			this.label22 = new Label();
			this.textBox17 = new TextBox();
			this.label23 = new Label();
			this.textBox18 = new TextBox();
			this.label24 = new Label();
			this.textBox19 = new TextBox();
			this.label25 = new Label();
			this.textBox20 = new TextBox();
			this.label26 = new Label();
			this.textBox21 = new TextBox();
			this.label27 = new Label();
			this.dataGridView1 = new DataGridView();
			this.button10 = new Button();
			this.textBox22 = new TextBox();
			this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.fnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.snameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.otchDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.areaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.townDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.homeindexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.educationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.workDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.qualificationsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.eventsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.personBindingSource = new BindingSource(this.components);
			this.categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.categorydateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.judgecategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.judgecategorydateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.trainercategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.trainercategorydateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.qualificationBindingSource = new BindingSource(this.components);
			this.titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.judgepostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.eventBindingSource = new BindingSource(this.components);
			this.label28 = new Label();
			this.button15 = new Button();
			this.tabControl1.SuspendLayout();
			this.persons.SuspendLayout();
			this.qualification.SuspendLayout();
			((ISupportInitialize)this.dataGridView2).BeginInit();
			this.events.SuspendLayout();
			((ISupportInitialize)this.dataGridView3).BeginInit();
			this.menuStrip1.SuspendLayout();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			((ISupportInitialize)this.personBindingSource).BeginInit();
			((ISupportInitialize)this.qualificationBindingSource).BeginInit();
			((ISupportInitialize)this.eventBindingSource).BeginInit();
			base.SuspendLayout();
			this.userName.Location = new Point(6, 44);
			this.userName.Name = "userName";
			this.userName.Size = new Size(100, 20);
			this.userName.TabIndex = 0;
			this.userName.Text = "admin";
			this.userPassword.Location = new Point(112, 44);
			this.userPassword.Name = "userPassword";
			this.userPassword.PasswordChar = '*';
			this.userPassword.Size = new Size(100, 20);
			this.userPassword.TabIndex = 1;
			this.userPassword.Text = "bushsuxx";
			this.button1.Location = new Point(7, 367);
			this.button1.Name = "button1";
			this.button1.Size = new Size(90, 49);
			this.button1.TabIndex = 3;
			this.button1.Text = "Показать всё";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.tabControl1.Controls.Add(this.persons);
			this.tabControl1.Controls.Add(this.qualification);
			this.tabControl1.Controls.Add(this.events);
			this.tabControl1.Location = new Point(6, 70);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(775, 499);
			this.tabControl1.TabIndex = 7;
			this.persons.Controls.Add(this.dataGridView1);
			this.persons.Controls.Add(this.label27);
			this.persons.Controls.Add(this.textBox21);
			this.persons.Controls.Add(this.label26);
			this.persons.Controls.Add(this.textBox20);
			this.persons.Controls.Add(this.label25);
			this.persons.Controls.Add(this.textBox19);
			this.persons.Controls.Add(this.label24);
			this.persons.Controls.Add(this.textBox18);
			this.persons.Controls.Add(this.label23);
			this.persons.Controls.Add(this.textBox17);
			this.persons.Controls.Add(this.label22);
			this.persons.Controls.Add(this.textBox16);
			this.persons.Controls.Add(this.button8);
			this.persons.Controls.Add(this.button7);
			this.persons.Controls.Add(this.button6);
			this.persons.Controls.Add(this.label8);
			this.persons.Controls.Add(this.button5);
			this.persons.Controls.Add(this.label7);
			this.persons.Controls.Add(this.label6);
			this.persons.Controls.Add(this.label5);
			this.persons.Controls.Add(this.label4);
			this.persons.Controls.Add(this.label3);
			this.persons.Controls.Add(this.label2);
			this.persons.Controls.Add(this.textBox8);
			this.persons.Controls.Add(this.textBox7);
			this.persons.Controls.Add(this.textBox6);
			this.persons.Controls.Add(this.maskedTextBox1);
			this.persons.Controls.Add(this.textBox5);
			this.persons.Controls.Add(this.textBox4);
			this.persons.Controls.Add(this.label1);
			this.persons.Controls.Add(this.button2);
			this.persons.Controls.Add(this.textBox1);
			this.persons.Controls.Add(this.button1);
			this.persons.Location = new Point(4, 22);
			this.persons.Name = "persons";
			this.persons.Padding = new Padding(3);
			this.persons.Size = new Size(767, 473);
			this.persons.TabIndex = 0;
			this.persons.Text = "люди";
			this.persons.UseVisualStyleBackColor = true;
			this.button8.Location = new Point(691, 427);
			this.button8.Name = "button8";
			this.button8.Size = new Size(66, 30);
			this.button8.TabIndex = 26;
			this.button8.Text = "Удалить";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			this.button8.HelpRequested += new HelpEventHandler(this.button8_HelpRequested);
			this.button7.Location = new Point(691, 395);
			this.button7.Name = "button7";
			this.button7.Size = new Size(66, 30);
			this.button7.TabIndex = 25;
			this.button7.Text = "Обновить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			this.button7.HelpRequested += new HelpEventHandler(this.button7_HelpRequested);
			this.button6.Location = new Point(691, 360);
			this.button6.Name = "button6";
			this.button6.Size = new Size(66, 32);
			this.button6.TabIndex = 24;
			this.button6.Text = "Добавить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			this.button6.HelpRequested += new HelpEventHandler(this.button6_HelpRequested);
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.label8.Location = new Point(98, 434);
			this.label8.Name = "label8";
			this.label8.Size = new Size(40, 20);
			this.label8.TabIndex = 23;
			this.label8.Text = "или";
			this.button5.Location = new Point(144, 431);
			this.button5.Name = "button5";
			this.button5.Size = new Size(97, 23);
			this.button5.TabIndex = 22;
			this.button5.Text = "по фамилии";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			this.button5.HelpRequested += new HelpEventHandler(this.button5_HelpRequested);
			this.label7.AutoSize = true;
			this.label7.Location = new Point(374, 389);
			this.label7.Name = "label7";
			this.label7.Size = new Size(75, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "Образование";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(111, 389);
			this.label6.Name = "label6";
			this.label6.Size = new Size(38, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Адрес";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(602, 351);
			this.label5.Name = "label5";
			this.label5.Size = new Size(37, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Город";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(440, 352);
			this.label4.Name = "label4";
			this.label4.Size = new Size(86, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Дата рождения";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(264, 352);
			this.label3.Name = "label3";
			this.label3.Size = new Size(56, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Фамилия";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(178, 351);
			this.label2.Name = "label2";
			this.label2.Size = new Size(29, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Имя";
			this.textBox8.Location = new Point(377, 405);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new Size(94, 20);
			this.textBox8.TabIndex = 15;
			this.textBox7.Location = new Point(103, 405);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new Size(96, 20);
			this.textBox7.TabIndex = 14;
			this.textBox6.Location = new Point(605, 367);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new Size(80, 20);
			this.textBox6.TabIndex = 13;
			this.maskedTextBox1.Location = new Point(443, 367);
			this.maskedTextBox1.Mask = "00.00.0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new Size(80, 20);
			this.maskedTextBox1.TabIndex = 12;
			this.maskedTextBox1.Text = "01011901";
			this.textBox5.Location = new Point(267, 367);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new Size(80, 20);
			this.textBox5.TabIndex = 11;
			this.textBox4.Location = new Point(181, 367);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new Size(80, 20);
			this.textBox4.TabIndex = 10;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(103, 352);
			this.label1.Name = "label1";
			this.label1.Size = new Size(18, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "ID";
			this.button2.Location = new Point(7, 431);
			this.button2.Name = "button2";
			this.button2.Size = new Size(89, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "показ по id";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button2.HelpRequested += new HelpEventHandler(this.button2_HelpRequested);
			this.textBox1.Location = new Point(103, 367);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(72, 20);
			this.textBox1.TabIndex = 7;
			this.qualification.Controls.Add(this.button11);
			this.qualification.Controls.Add(this.label15);
			this.qualification.Controls.Add(this.label14);
			this.qualification.Controls.Add(this.label13);
			this.qualification.Controls.Add(this.label12);
			this.qualification.Controls.Add(this.label11);
			this.qualification.Controls.Add(this.label10);
			this.qualification.Controls.Add(this.label9);
			this.qualification.Controls.Add(this.maskedTextBox4);
			this.qualification.Controls.Add(this.maskedTextBox3);
			this.qualification.Controls.Add(this.maskedTextBox2);
			this.qualification.Controls.Add(this.textBox11);
			this.qualification.Controls.Add(this.textBox10);
			this.qualification.Controls.Add(this.textBox9);
			this.qualification.Controls.Add(this.button9);
			this.qualification.Controls.Add(this.textBox2);
			this.qualification.Controls.Add(this.button3);
			this.qualification.Controls.Add(this.dataGridView2);
			this.qualification.Location = new Point(4, 22);
			this.qualification.Name = "qualification";
			this.qualification.Padding = new Padding(3);
			this.qualification.Size = new Size(767, 473);
			this.qualification.TabIndex = 1;
			this.qualification.Text = "категории";
			this.qualification.UseVisualStyleBackColor = true;
			this.button11.Location = new Point(529, 227);
			this.button11.Name = "button11";
			this.button11.Size = new Size(203, 24);
			this.button11.TabIndex = 18;
			this.button11.Text = "Удалить";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			this.label15.AutoSize = true;
			this.label15.Location = new Point(629, 156);
			this.label15.Name = "label15";
			this.label15.Size = new Size(96, 13);
			this.label15.TabIndex = 16;
			this.label15.Text = "Дата присвоения";
			this.label14.AutoSize = true;
			this.label14.Location = new Point(526, 156);
			this.label14.Name = "label14";
			this.label14.Size = new Size(91, 13);
			this.label14.TabIndex = 15;
			this.label14.Text = "Тренерская кат.";
			this.label13.AutoSize = true;
			this.label13.Location = new Point(417, 156);
			this.label13.Name = "label13";
			this.label13.Size = new Size(96, 13);
			this.label13.TabIndex = 14;
			this.label13.Text = "Дата присвоения";
			this.label12.AutoSize = true;
			this.label12.Location = new Point(311, 156);
			this.label12.Name = "label12";
			this.label12.Size = new Size(80, 13);
			this.label12.TabIndex = 13;
			this.label12.Text = "Суд.категория";
			this.label11.AutoSize = true;
			this.label11.Location = new Point(205, 156);
			this.label11.Name = "label11";
			this.label11.Size = new Size(96, 13);
			this.label11.TabIndex = 12;
			this.label11.Text = "Дата присвоения";
			this.label10.AutoSize = true;
			this.label10.Location = new Point(99, 156);
			this.label10.Name = "label10";
			this.label10.Size = new Size(60, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Категория";
			this.label9.AutoSize = true;
			this.label9.Location = new Point(11, 156);
			this.label9.Name = "label9";
			this.label9.Size = new Size(15, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "id";
			this.maskedTextBox4.Location = new Point(632, 172);
			this.maskedTextBox4.Mask = "00.00.0000";
			this.maskedTextBox4.Name = "maskedTextBox4";
			this.maskedTextBox4.Size = new Size(100, 20);
			this.maskedTextBox4.TabIndex = 9;
			this.maskedTextBox4.Text = "01011901";
			this.maskedTextBox3.Location = new Point(420, 172);
			this.maskedTextBox3.Mask = "00.00.0000";
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new Size(100, 20);
			this.maskedTextBox3.TabIndex = 8;
			this.maskedTextBox3.Text = "01011901";
			this.maskedTextBox2.Location = new Point(208, 172);
			this.maskedTextBox2.Mask = "00.00.0000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new Size(100, 20);
			this.maskedTextBox2.TabIndex = 7;
			this.maskedTextBox2.Text = "01011901";
			this.textBox11.Location = new Point(526, 172);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new Size(100, 20);
			this.textBox11.TabIndex = 6;
			this.textBox10.Location = new Point(314, 172);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new Size(100, 20);
			this.textBox10.TabIndex = 5;
			this.textBox9.Location = new Point(102, 172);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new Size(100, 20);
			this.textBox9.TabIndex = 4;
			this.button9.Location = new Point(529, 198);
			this.button9.Name = "button9";
			this.button9.Size = new Size(203, 23);
			this.button9.TabIndex = 3;
			this.button9.Text = "Добавить/Обновить";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			this.textBox2.Location = new Point(10, 172);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Size(86, 20);
			this.textBox2.TabIndex = 2;
			this.button3.Location = new Point(10, 198);
			this.button3.Name = "button3";
			this.button3.Size = new Size(86, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Показ по id";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.categoryDataGridViewTextBoxColumn,
				this.categorydateDataGridViewTextBoxColumn,
				this.judgecategoryDataGridViewTextBoxColumn,
				this.judgecategorydateDataGridViewTextBoxColumn,
				this.trainercategoryDataGridViewTextBoxColumn,
				this.trainercategorydateDataGridViewTextBoxColumn
			});
			this.dataGridView2.DataSource = this.qualificationBindingSource;
			this.dataGridView2.Location = new Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new Size(756, 147);
			this.dataGridView2.TabIndex = 0;
			this.events.Controls.Add(this.label21);
			this.events.Controls.Add(this.textBox15);
			this.events.Controls.Add(this.button14);
			this.events.Controls.Add(this.button13);
			this.events.Controls.Add(this.button12);
			this.events.Controls.Add(this.label20);
			this.events.Controls.Add(this.textBox14);
			this.events.Controls.Add(this.label19);
			this.events.Controls.Add(this.label18);
			this.events.Controls.Add(this.label17);
			this.events.Controls.Add(this.label16);
			this.events.Controls.Add(this.maskedTextBox5);
			this.events.Controls.Add(this.textBox13);
			this.events.Controls.Add(this.textBox12);
			this.events.Controls.Add(this.textBox3);
			this.events.Controls.Add(this.button4);
			this.events.Controls.Add(this.dataGridView3);
			this.events.Location = new Point(4, 22);
			this.events.Name = "events";
			this.events.Padding = new Padding(3);
			this.events.Size = new Size(767, 473);
			this.events.TabIndex = 2;
			this.events.Text = "мероприятия";
			this.events.UseVisualStyleBackColor = true;
			this.label21.AutoSize = true;
			this.label21.Location = new Point(655, 179);
			this.label21.Name = "label21";
			this.label21.Size = new Size(105, 26);
			this.label21.TabIndex = 21;
			this.label21.Text = "Номер события по \r\nпорядку в таблице";
			this.textBox15.Location = new Point(658, 206);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new Size(100, 20);
			this.textBox15.TabIndex = 20;
			this.button14.Location = new Point(533, 206);
			this.button14.Name = "button14";
			this.button14.Size = new Size(119, 23);
			this.button14.TabIndex = 19;
			this.button14.Text = "Обновить";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			this.button13.Location = new Point(408, 206);
			this.button13.Name = "button13";
			this.button13.Size = new Size(119, 23);
			this.button13.TabIndex = 18;
			this.button13.Text = "Удалить";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			this.button12.Location = new Point(533, 179);
			this.button12.Name = "button12";
			this.button12.Size = new Size(119, 21);
			this.button12.TabIndex = 17;
			this.button12.Text = "Добавить";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			this.label20.AutoSize = true;
			this.label20.Location = new Point(405, 164);
			this.label20.Name = "label20";
			this.label20.Size = new Size(119, 13);
			this.label20.TabIndex = 16;
			this.label20.Text = "Судейская должность";
			this.textBox14.Location = new Point(405, 180);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new Size(119, 20);
			this.textBox14.TabIndex = 15;
			this.label19.AutoSize = true;
			this.label19.Location = new Point(303, 164);
			this.label19.Name = "label19";
			this.label19.Size = new Size(96, 13);
			this.label19.TabIndex = 14;
			this.label19.Text = "Дата проведения";
			this.label18.AutoSize = true;
			this.label18.Location = new Point(195, 164);
			this.label18.Name = "label18";
			this.label18.Size = new Size(102, 13);
			this.label18.TabIndex = 13;
			this.label18.Text = "Место проведения";
			this.label17.AutoSize = true;
			this.label17.Location = new Point(99, 164);
			this.label17.Name = "label17";
			this.label17.Size = new Size(75, 13);
			this.label17.TabIndex = 12;
			this.label17.Text = "Мероприятие";
			this.label16.AutoSize = true;
			this.label16.Location = new Point(6, 164);
			this.label16.Name = "label16";
			this.label16.Size = new Size(15, 13);
			this.label16.TabIndex = 11;
			this.label16.Text = "id";
			this.maskedTextBox5.Location = new Point(303, 180);
			this.maskedTextBox5.Mask = "00.00.0000";
			this.maskedTextBox5.Name = "maskedTextBox5";
			this.maskedTextBox5.Size = new Size(96, 20);
			this.maskedTextBox5.TabIndex = 5;
			this.maskedTextBox5.Text = "01011901";
			this.textBox13.Location = new Point(198, 180);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new Size(99, 20);
			this.textBox13.TabIndex = 4;
			this.textBox12.Location = new Point(102, 180);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new Size(90, 20);
			this.textBox12.TabIndex = 3;
			this.textBox3.Location = new Point(6, 180);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new Size(90, 20);
			this.textBox3.TabIndex = 2;
			this.button4.Location = new Point(6, 206);
			this.button4.Name = "button4";
			this.button4.Size = new Size(90, 23);
			this.button4.TabIndex = 1;
			this.button4.Text = "show by id";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new DataGridViewColumn[]
			{
				this.titleDataGridViewTextBoxColumn,
				this.placeDataGridViewTextBoxColumn,
				this.dateDataGridViewTextBoxColumn,
				this.judgepostDataGridViewTextBoxColumn
			});
			this.dataGridView3.DataSource = this.eventBindingSource;
			this.dataGridView3.Location = new Point(6, 6);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new Size(755, 153);
			this.dataGridView3.TabIndex = 0;
			this.name.AutoSize = true;
			this.name.Location = new Point(3, 28);
			this.name.Name = "name";
			this.name.Size = new Size(53, 13);
			this.name.TabIndex = 8;
			this.name.Text = "username";
			this.password.AutoSize = true;
			this.password.Location = new Point(109, 28);
			this.password.Name = "password";
			this.password.Size = new Size(52, 13);
			this.password.TabIndex = 9;
			this.password.Text = "password";
			this.menuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem1,
				this.toolStripMenuItem2
			});
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(784, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.экспортВExcelИзлюдиToolStripMenuItem,
				this.экспортВExcelИзмероприятияToolStripMenuItem,
				this.экспортВExcelИзмероприятияToolStripMenuItem1
			});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(64, 20);
			this.toolStripMenuItem1.Text = "Экспорт";
			this.экспортВExcelИзлюдиToolStripMenuItem.Name = "экспортВExcelИзлюдиToolStripMenuItem";
			this.экспортВExcelИзлюдиToolStripMenuItem.Size = new Size(259, 22);
			this.экспортВExcelИзлюдиToolStripMenuItem.Text = "Экспорт в excel из \"люди\"";
			this.экспортВExcelИзлюдиToolStripMenuItem.Click += new System.EventHandler(this.экспортВExcelИзлюдиToolStripMenuItem_Click);
			this.экспортВExcelИзмероприятияToolStripMenuItem.Name = "экспортВExcelИзмероприятияToolStripMenuItem";
			this.экспортВExcelИзмероприятияToolStripMenuItem.Size = new Size(259, 22);
			this.экспортВExcelИзмероприятияToolStripMenuItem.Text = "Экспорт в excel из \"категория\"";
			this.экспортВExcelИзмероприятияToolStripMenuItem1.Name = "экспортВExcelИзмероприятияToolStripMenuItem1";
			this.экспортВExcelИзмероприятияToolStripMenuItem1.Size = new Size(259, 22);
			this.экспортВExcelИзмероприятияToolStripMenuItem1.Text = "Экспорт в excel из \"мероприятия\"";
			this.toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.оПрограммеToolStripMenuItem,
				this.помощьToolStripMenuItem
			});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(68, 20);
			this.toolStripMenuItem2.Text = "Помощь";
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new Size(149, 22);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
			this.помощьToolStripMenuItem.Size = new Size(149, 22);
			this.помощьToolStripMenuItem.Text = "Помощь";
			this.textBox16.Location = new Point(353, 367);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new Size(84, 20);
			this.textBox16.TabIndex = 27;
			this.label22.AutoSize = true;
			this.label22.Location = new Point(350, 352);
			this.label22.Name = "label22";
			this.label22.Size = new Size(54, 13);
			this.label22.TabIndex = 28;
			this.label22.Text = "Отчество";
			this.textBox17.Location = new Point(529, 367);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new Size(70, 20);
			this.textBox17.TabIndex = 29;
			this.label23.AutoSize = true;
			this.label23.Location = new Point(526, 352);
			this.label23.Name = "label23";
			this.label23.Size = new Size(38, 13);
			this.label23.TabIndex = 30;
			this.label23.Text = "Район";
			this.textBox18.Location = new Point(205, 405);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new Size(80, 20);
			this.textBox18.TabIndex = 31;
			this.label24.AutoSize = true;
			this.label24.Location = new Point(202, 389);
			this.label24.Name = "label24";
			this.label24.Size = new Size(45, 13);
			this.label24.TabIndex = 32;
			this.label24.Text = "Индекс";
			this.textBox19.Location = new Point(291, 405);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new Size(80, 20);
			this.textBox19.TabIndex = 33;
			this.label25.AutoSize = true;
			this.label25.Location = new Point(288, 389);
			this.label25.Name = "label25";
			this.label25.Size = new Size(52, 13);
			this.label25.TabIndex = 34;
			this.label25.Text = "Телефон";
			this.textBox20.Location = new Point(477, 405);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new Size(97, 20);
			this.textBox20.TabIndex = 35;
			this.label26.AutoSize = true;
			this.label26.Location = new Point(474, 389);
			this.label26.Name = "label26";
			this.label26.Size = new Size(31, 13);
			this.label26.TabIndex = 36;
			this.label26.Text = "email";
			this.textBox21.Location = new Point(580, 405);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new Size(106, 20);
			this.textBox21.TabIndex = 37;
			this.label27.AutoSize = true;
			this.label27.Location = new Point(577, 389);
			this.label27.Name = "label27";
			this.label27.Size = new Size(43, 13);
			this.label27.TabIndex = 38;
			this.label27.Text = "Работа";
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn,
				this.fnameDataGridViewTextBoxColumn,
				this.snameDataGridViewTextBoxColumn,
				this.otchDataGridViewTextBoxColumn,
				this.dateOfBirthDataGridViewTextBoxColumn,
				this.areaDataGridViewTextBoxColumn,
				this.townDataGridViewTextBoxColumn,
				this.streetDataGridViewTextBoxColumn,
				this.homeindexDataGridViewTextBoxColumn,
				this.phoneDataGridViewTextBoxColumn,
				this.educationDataGridViewTextBoxColumn,
				this.emailDataGridViewTextBoxColumn,
				this.workDataGridViewTextBoxColumn,
				this.qualificationsDataGridViewTextBoxColumn,
				this.eventsDataGridViewTextBoxColumn
			});
			this.dataGridView1.DataSource = this.personBindingSource;
			this.dataGridView1.Location = new Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new Size(756, 343);
			this.dataGridView1.TabIndex = 39;
			this.button10.Location = new Point(397, 41);
			this.button10.Name = "button10";
			this.button10.Size = new Size(162, 23);
			this.button10.TabIndex = 11;
			this.button10.Text = "Тест без вывода в таблицу";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			this.textBox22.Location = new Point(291, 44);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new Size(100, 20);
			this.textBox22.TabIndex = 12;
			this.textBox22.Text = "100";
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
			this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
			this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
			this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
			this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
			this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
			this.otchDataGridViewTextBoxColumn.DataPropertyName = "otch";
			this.otchDataGridViewTextBoxColumn.HeaderText = "otch";
			this.otchDataGridViewTextBoxColumn.Name = "otchDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
			this.areaDataGridViewTextBoxColumn.HeaderText = "area";
			this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
			this.townDataGridViewTextBoxColumn.DataPropertyName = "town";
			this.townDataGridViewTextBoxColumn.HeaderText = "town";
			this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
			this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
			this.streetDataGridViewTextBoxColumn.HeaderText = "street";
			this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
			this.homeindexDataGridViewTextBoxColumn.DataPropertyName = "home_index";
			this.homeindexDataGridViewTextBoxColumn.HeaderText = "home_index";
			this.homeindexDataGridViewTextBoxColumn.Name = "homeindexDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.educationDataGridViewTextBoxColumn.DataPropertyName = "education";
			this.educationDataGridViewTextBoxColumn.HeaderText = "education";
			this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.workDataGridViewTextBoxColumn.DataPropertyName = "work";
			this.workDataGridViewTextBoxColumn.HeaderText = "work";
			this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
			this.qualificationsDataGridViewTextBoxColumn.DataPropertyName = "qualifications";
			this.qualificationsDataGridViewTextBoxColumn.HeaderText = "qualifications";
			this.qualificationsDataGridViewTextBoxColumn.Name = "qualificationsDataGridViewTextBoxColumn";
			this.qualificationsDataGridViewTextBoxColumn.Visible = false;
			this.eventsDataGridViewTextBoxColumn.DataPropertyName = "_events";
			this.eventsDataGridViewTextBoxColumn.HeaderText = "_events";
			this.eventsDataGridViewTextBoxColumn.Name = "eventsDataGridViewTextBoxColumn";
			this.eventsDataGridViewTextBoxColumn.Visible = false;
			this.personBindingSource.DataSource = typeof(person);
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categorydateDataGridViewTextBoxColumn.DataPropertyName = "category_date";
			this.categorydateDataGridViewTextBoxColumn.HeaderText = "category_date";
			this.categorydateDataGridViewTextBoxColumn.Name = "categorydateDataGridViewTextBoxColumn";
			this.judgecategoryDataGridViewTextBoxColumn.DataPropertyName = "judge_category";
			this.judgecategoryDataGridViewTextBoxColumn.HeaderText = "judge_category";
			this.judgecategoryDataGridViewTextBoxColumn.Name = "judgecategoryDataGridViewTextBoxColumn";
			this.judgecategorydateDataGridViewTextBoxColumn.DataPropertyName = "judge_category_date";
			this.judgecategorydateDataGridViewTextBoxColumn.HeaderText = "judge_category_date";
			this.judgecategorydateDataGridViewTextBoxColumn.Name = "judgecategorydateDataGridViewTextBoxColumn";
			this.judgecategorydateDataGridViewTextBoxColumn.Width = 120;
			this.trainercategoryDataGridViewTextBoxColumn.DataPropertyName = "trainer_category";
			this.trainercategoryDataGridViewTextBoxColumn.HeaderText = "trainer_category";
			this.trainercategoryDataGridViewTextBoxColumn.Name = "trainercategoryDataGridViewTextBoxColumn";
			this.trainercategorydateDataGridViewTextBoxColumn.DataPropertyName = "trainer_category_date";
			this.trainercategorydateDataGridViewTextBoxColumn.HeaderText = "trainer_category_date";
			this.trainercategorydateDataGridViewTextBoxColumn.Name = "trainercategorydateDataGridViewTextBoxColumn";
			this.trainercategorydateDataGridViewTextBoxColumn.Width = 120;
			this.qualificationBindingSource.DataSource = typeof(qualification);
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
			this.placeDataGridViewTextBoxColumn.HeaderText = "place";
			this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.judgepostDataGridViewTextBoxColumn.DataPropertyName = "judge_post";
			this.judgepostDataGridViewTextBoxColumn.HeaderText = "judge_post";
			this.judgepostDataGridViewTextBoxColumn.Name = "judgepostDataGridViewTextBoxColumn";
			this.eventBindingSource.DataSource = typeof(_event);
			this.label28.AutoSize = true;
			this.label28.Location = new Point(288, 28);
			this.label28.Name = "label28";
			this.label28.Size = new Size(89, 13);
			this.label28.TabIndex = 13;
			this.label28.Text = "Число проходов";
			this.button15.Location = new Point(397, 63);
			this.button15.Name = "button15";
			this.button15.Size = new Size(162, 23);
			this.button15.TabIndex = 14;
			this.button15.Text = "Тест с выводом в таблицу";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(784, 572);
			base.Controls.Add(this.button15);
			base.Controls.Add(this.label28);
			base.Controls.Add(this.textBox22);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.password);
			base.Controls.Add(this.name);
			base.Controls.Add(this.userName);
			base.Controls.Add(this.userPassword);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.menuStrip1);
			base.HelpButton = true;
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			this.MaximumSize = new Size(800, 610);
			base.MinimizeBox = false;
			this.MinimumSize = new Size(800, 610);
			base.Name = "Form1";
			base.SizeGripStyle = SizeGripStyle.Hide;
			this.Text = "База данных судей и тренеров туристической школы";
			this.tabControl1.ResumeLayout(false);
			this.persons.ResumeLayout(false);
			this.persons.PerformLayout();
			this.qualification.ResumeLayout(false);
			this.qualification.PerformLayout();
			((ISupportInitialize)this.dataGridView2).EndInit();
			this.events.ResumeLayout(false);
			this.events.PerformLayout();
			((ISupportInitialize)this.dataGridView3).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((ISupportInitialize)this.dataGridView1).EndInit();
			((ISupportInitialize)this.personBindingSource).EndInit();
			((ISupportInitialize)this.qualificationBindingSource).EndInit();
			((ISupportInitialize)this.eventBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		public Form1()
		{
			this.InitializeComponent();
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				this.dataGridView1.DataSource = collection.FindAll().ToList<person>();
				MessageBox.Show("найдено " + this.dataGridView1.Rows.Count.ToString() + " записей");
			}
			catch
			{
				MessageBox.Show("ошибка подключения. проверьте правильность имени и пароля пользователя");
			}
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox1.Text);
				collection.FindOne(query);
				this.dataGridView1.DataSource = collection.Find(query).ToList<person>();
				if (this.dataGridView1.Rows.Count > 0)
				{
					MessageBox.Show("найден");
				}
				else
				{
					MessageBox.Show("не найден");
				}
			}
			catch
			{
				MessageBox.Show("ошибка подключения. проверьте правильность имени и пароля пользователя");
			}
		}
		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				try
				{
					IMongoQuery query = Query.EQ("_id", this.textBox2.Text);
					person pers = collection.FindOne(query);
					System.Collections.Generic.IList<qualification> qualif = pers.qualifications;
					this.dataGridView2.DataSource = qualif.ToList<qualification>();
					if (this.dataGridView2.Rows.Count > 0)
					{
						MessageBox.Show("найдено " + this.dataGridView2.Rows.Count.ToString() + " записей");
					}
				}
				catch
				{
					MessageBox.Show("не найден");
				}
			}
			catch
			{
				MessageBox.Show("ошибка подключения или информация не найдена");
			}
		}
		private void button4_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				try
				{
					IMongoQuery query = Query.EQ("_id", this.textBox3.Text);
					person pers = collection.FindOne(query);
					System.Collections.Generic.IList<_event> ev = pers._events;
					this.dataGridView3.DataSource = ev.ToList<_event>();
					if (this.dataGridView3.Rows.Count > 0)
					{
						MessageBox.Show("найдено " + this.dataGridView3.Rows.Count.ToString() + " записей");
					}
				}
				catch
				{
					MessageBox.Show("не найден");
				}
			}
			catch
			{
				MessageBox.Show("ошибка подключения или информация не найдена");
			}
		}
		private void button8_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			MessageBox.Show("При нажатии будет полностью удалена запись о человеке, включая информацию о мероприятиях и его квалификации. Удаление произойдёт в случае, когда заполнено поле ID.");
		}
		private void button5_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			MessageBox.Show("При нажатии в таблице отобразятся все записи, где фамилия эквивалентна прописанной в поле 'фамилия'.");
		}
		private void button2_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			MessageBox.Show("При нажатии в таблице отобразится запись с номером, равным введёному в поле ID.");
		}
		private void button7_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			MessageBox.Show("При нажатии будет обновлена запись о человеке, вся информация будет эквивалентна записанной в соответсвующих полях. Обновление произойдёт в случае, когда заполнено поле ID.");
		}
		private void button6_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
			MessageBox.Show("При нажатии будет добавлена новая запись с данными, эквивалентными заполненным полям. Поле ID заполнять не требуется, т.к. будет сгенерировано новое значение.");
		}
		private void button6_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				person pers = new person
				{
					id = ObjectId.GenerateNewId().ToString(),
					fname = this.textBox4.Text,
					sname = this.textBox5.Text,
					otch = this.textBox16.Text,
					DateOfBirth = System.DateTime.Parse(this.maskedTextBox1.Text),
					area = this.textBox17.Text,
					town = this.textBox6.Text,
					street = this.textBox7.Text,
					home_index = this.textBox18.Text,
					phone = this.textBox19.Text,
					education = this.textBox8.Text,
					email = this.textBox20.Text,
					work = this.textBox21.Text
				};
				collection.Insert(pers);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка добавления");
			}
			this.button1_Click(sender, e);
		}
		private void button5_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("sname", this.textBox5.Text);
				collection.Find(query);
				this.dataGridView1.DataSource = collection.Find(query).ToList<person>();
				if (this.dataGridView1.Rows.Count > 0)
				{
					MessageBox.Show("найдено: " + this.dataGridView1.RowCount);
				}
				else
				{
					MessageBox.Show("не найден");
				}
			}
			catch
			{
				MessageBox.Show("ошибка подключения. проверьте правильность имени и пароля пользователя");
			}
		}
		private void button9_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox2.Text);
				person pers = collection.FindOne(query);
				System.Collections.Generic.List<qualification> qualify = new System.Collections.Generic.List<qualification>
				{
					new qualification
					{
						category = this.textBox9.Text,
						category_date = System.DateTime.Parse(this.maskedTextBox2.Text),
						judge_category = this.textBox10.Text,
						judge_category_date = System.DateTime.Parse(this.maskedTextBox3.Text),
						trainer_category = this.textBox11.Text,
						trainer_category_date = System.DateTime.Parse(this.maskedTextBox4.Text)
					}
				};
				pers.qualifications = qualify;
				collection.Save(pers);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка добавления");
			}
			this.button3_Click(sender, e);
		}
		private void button12_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox3.Text);
				person pers = collection.FindOne(query);
				System.Collections.Generic.List<_event> events = new System.Collections.Generic.List<_event>
				{
					new _event
					{
						title = this.textBox12.Text,
						place = this.textBox13.Text,
						date = System.DateTime.Parse(this.maskedTextBox5.Text),
						judge_post = this.textBox14.Text
					}
				};
				try
				{
					pers._events.Add(events[0]);
				}
				catch
				{
					pers._events = events;
				}
				collection.Save(pers);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка добавления");
			}
			this.button4_Click(sender, e);
		}
		private void button8_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox1.Text);
				collection.Remove(query);
				this.button1_Click(sender, e);
			}
			catch
			{
				MessageBox.Show("ошибка подключения. проверьте правильность имени и пароля пользователя");
			}
		}
		private void button7_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox1.Text);
				UpdateBuilder update = MongoDB.Driver.Builders.Update.Set("fname", this.textBox4.Text).Set("sname", this.textBox5.Text).Set("otch", this.textBox16.Text).Set("DateOfBirth", System.DateTime.Parse(this.maskedTextBox1.Text)).Set("area", this.textBox17.Text).Set("town", this.textBox6.Text).Set("street", this.textBox7.Text).Set("home_index", this.textBox18.Text).Set("phone", this.textBox19.Text).Set("education", this.textBox8.Text).Set("email", this.textBox20.Text).Set("work", this.textBox21.Text);
				collection.Update(query, update);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка добавления");
			}
			this.button1_Click(sender, e);
		}
		private void button14_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox3.Text);
				person pers = collection.FindOne(query);
				System.Collections.Generic.List<_event> events = new System.Collections.Generic.List<_event>
				{
					new _event
					{
						title = this.textBox12.Text,
						place = this.textBox13.Text,
						date = System.DateTime.Parse(this.maskedTextBox5.Text),
						judge_post = this.textBox14.Text
					}
				};
				pers._events[System.Convert.ToInt32(this.textBox15.Text) - 1] = events[0];
				collection.Save(pers);
				this.button4_Click(sender, e);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка добавления");
			}
		}
		private void button13_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox3.Text);
				person pers = collection.FindOne(query);
				pers._events.RemoveAt(System.Convert.ToInt32(this.textBox15.Text) - 1);
				collection.Save(pers);
				this.button4_Click(sender, e);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка удаления");
			}
		}
		private void button11_Click(object sender, System.EventArgs e)
		{
			try
			{
				string connection = string.Concat(new string[]
				{
					"mongodb://",
					this.userName.Text,
					":",
					this.userPassword.Text,
					"@localhost"
				});
				MongoClient client = new MongoClient(connection);
				MongoServer server = client.GetServer();
				MongoDatabase database = server.GetDatabase("school");
				MongoCollection<person> collection = database.GetCollection<person>("people");
				IMongoQuery query = Query.EQ("_id", this.textBox3.Text);
				person pers = collection.FindOne(query);
				pers.qualifications.RemoveAt(0);
				collection.Save(pers);
				this.button3_Click(sender, e);
			}
			catch
			{
				MessageBox.Show("ошибка подключения или ошибка удаления");
			}
		}
		private void экспортВExcelИзлюдиToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application ExcelApp = (Microsoft.Office.Interop.Excel.Application)System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(new System.Guid("00024500-0000-0000-C000-000000000046")));
			ExcelApp.Application.Workbooks.Add(System.Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			for (int i = 0; i < this.dataGridView1.ColumnCount - 2; i++)
			{
				ExcelApp.Cells[1, i + 1] = this.dataGridView1.Columns[i].HeaderText;
			}
			for (int j = 0; j < this.dataGridView1.ColumnCount - 2; j++)
			{
				for (int k = 0; k < this.dataGridView1.RowCount; k++)
				{
					ExcelApp.Cells[k + 2, j + 1] = this.dataGridView1[j, k].Value;
				}
			}
			ExcelApp.Visible = true;
		}
		private void оПрограммеToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			AboutBox1 form = new AboutBox1();
			form.Show();
		}
		private void button10_Click(object sender, System.EventArgs e)
		{
			Stopwatch sis_diag = new Stopwatch();
			sis_diag.Start();
			string connection = string.Concat(new string[]
			{
				"mongodb://",
				this.userName.Text,
				":",
				this.userPassword.Text,
				"@localhost"
			});
			MongoClient client = new MongoClient(connection);
			MongoServer server = client.GetServer();
			MongoDatabase database = server.GetDatabase("school");
			MongoCollection<person> collection = database.GetCollection<person>("people");
			System.Random r = new System.Random();
			for (int i = 0; i < System.Convert.ToInt32(this.textBox22.Text); i++)
			{
				string _id = r.Next(1000).ToString();
				person pers = new person
				{
					id = _id,
					fname = r.Next(1000).ToString(),
					sname = r.Next(1000).ToString(),
					otch = r.Next(1000).ToString(),
					DateOfBirth = System.DateTime.Parse(this.maskedTextBox1.Text),
					area = r.Next(1000).ToString(),
					town = r.Next(1000).ToString(),
					street = r.Next(1000).ToString(),
					home_index = r.Next(1000).ToString(),
					phone = r.Next(1000).ToString(),
					education = r.Next(1000).ToString(),
					email = r.Next(1000).ToString(),
					work = r.Next(1000).ToString()
				};
				collection.Insert(pers);
				IMongoQuery query = Query.EQ("_id", _id);
				collection.Remove(query);
			}
			MessageBox.Show("Result: " + sis_diag.Elapsed.ToString());
			sis_diag.Stop();
		}
		private void button15_Click(object sender, System.EventArgs e)
		{
			Stopwatch sis_diag = new Stopwatch();
			sis_diag.Start();
			string connection = string.Concat(new string[]
			{
				"mongodb://",
				this.userName.Text,
				":",
				this.userPassword.Text,
				"@localhost"
			});
			MongoClient client = new MongoClient(connection);
			MongoServer server = client.GetServer();
			MongoDatabase database = server.GetDatabase("school");
			MongoCollection<person> collection = database.GetCollection<person>("people");
			System.Random r = new System.Random();
			for (int i = 0; i < System.Convert.ToInt32(this.textBox22.Text); i++)
			{
				string _id = r.Next(1000).ToString();
				person pers = new person
				{
					id = _id,
					fname = r.Next(1000).ToString(),
					sname = r.Next(1000).ToString(),
					otch = r.Next(1000).ToString(),
					DateOfBirth = System.DateTime.Parse(this.maskedTextBox1.Text),
					area = r.Next(1000).ToString(),
					town = r.Next(1000).ToString(),
					street = r.Next(1000).ToString(),
					home_index = r.Next(1000).ToString(),
					phone = r.Next(1000).ToString(),
					education = r.Next(1000).ToString(),
					email = r.Next(1000).ToString(),
					work = r.Next(1000).ToString()
				};
				collection.Insert(pers);
				this.dataGridView1.DataSource = collection.FindAll().ToList<person>();
				IMongoQuery query = Query.EQ("_id", _id);
				collection.Remove(query);
				this.dataGridView1.DataSource = collection.FindAll().ToList<person>();
			}
			MessageBox.Show("Result: " + sis_diag.Elapsed.ToString());
			sis_diag.Stop();
		}
	}
}
