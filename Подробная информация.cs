using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace d1
{
	public partial class Form3 : Form
	{
		bool rezhim = false;
		bool flag = false;
		int answer = 0;
		public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = DB.mdb";
		private OleDbConnection Connect;
		public Form3()
		{
			InitializeComponent();

			pictureBox1.ImageLocation = "D:/ccc.jpg";

			Invisible();

			Connect = new OleDbConnection(connect);
			Connect.Open();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (answer)
			{
				case 0:

					pictureBox1.ImageLocation = "D:/a.jpg";

					if (radioButton2.Checked)
					{
						rezhim = true;
					}
					label1.Text = "За какую сторону играете?";
					radioButton1.Text = "Атака";
					radioButton2.Text = "Оборона";

					break;

				case 1:

					pictureBox1.ImageLocation = "D:/aa.jpg";

					if (radioButton1.Checked)
					{
						for (int i = 0; i <= 27; i++)
						{
							string query = "SELECT Role FROM Heroes WHERE id = " + i;
							OleDbCommand command = new OleDbCommand(query, Connect);
							if (Convert.ToString(command.ExecuteScalar()) == "Атака")
							{
								query = "UPDATE Heroes SET PriorityAnswer1 = '10' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
							else if (Convert.ToString(command.ExecuteScalar()) == "Атака/Защита")
							{
								query = "UPDATE Heroes SET PriorityAnswer1 = '5' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
							else
							{
								query = "UPDATE Heroes SET PriorityAnswer1 = '0' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
						}

						if (rezhim == true)
						{
							string query2 = "UPDATE Heroes SET PriorityAnswer1 = '5' WHERE Role = 'Защита'";
							OleDbCommand command2 = new OleDbCommand(query2, Connect);
							command2.ExecuteNonQuery();
						}
					}
					else if (radioButton2.Checked)
					{
						for (int i = 0; i <= 27; i++)
						{
							string  query = "SELECT Role FROM Heroes WHERE id = " + i;
							OleDbCommand command = new OleDbCommand(query, Connect);
							if (Convert.ToString(command.ExecuteScalar()) == "Атака")
							{
								query = "UPDATE Heroes SET PriorityAnswer1 = '10' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
							else if (Convert.ToString(command.ExecuteScalar()) == "Атака/Защита")
							{
								query = "UPDATE Heroes SET PriorityAnswer1 = '5' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
							else
							{
								query = "UPDATE Heroes SET PriorityAnswer1 = '0' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
						}
					}

					string query76 = "UPDATE Heroes SET PriorityAnswer1 = '" + 10 + "' WHERE Name = 'Солдат-76'";
					OleDbCommand command76 = new OleDbCommand(query76, Connect);
					command76.ExecuteNonQuery();

					label1.Text = "Ваша карта большая или не очень?";
					radioButton1.Text = "Маленькая";
					radioButton2.Text = "Большая";

					break;

				case 2:

					pictureBox1.ImageLocation = "D:/aaa.jpg";

					if (radioButton1.Checked)
					{
						for (int i = 0; i <= 27; i++)
						{
							string query = "SELECT damage FROM Heroes WHERE id = " + i;
							OleDbCommand command = new OleDbCommand(query, Connect);
							if (Convert.ToString(command.ExecuteScalar()) == "Урон по площади")
							{
								query = "UPDATE Heroes SET PriorityAnswer2 = '3' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
							else if (Convert.ToString(command.ExecuteScalar()) == "Лечение по площади")
							{
								query = "UPDATE Heroes SET PriorityAnswer2 = '3' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
							else
							{
								query = "UPDATE Heroes SET PriorityAnswer2 = '0' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
						}

					}
					else if (radioButton2.Checked)
					{
						for (int i = 0; i <= 27; i++)
						{
							string query = "SELECT Mobility FROM Heroes WHERE id = " + i;
							OleDbCommand command = new OleDbCommand(query, Connect);

							query = "SELECT damage FROM Heroes WHERE id = " + i;
							OleDbCommand command2 = new OleDbCommand(query, Connect);

							query = "SELECT heal FROM Heroes WHERE id = " + i;
							OleDbCommand command3 = new OleDbCommand(query, Connect);

							if (Convert.ToString(command.ExecuteScalar()) == "Гипер" || Convert.ToString(command.ExecuteScalar()) == "Высокая" || Convert.ToString(command.ExecuteScalar()) == "Средняя" || Convert.ToString(command2.ExecuteScalar()) == "Точечный урон" || Convert.ToString(command3.ExecuteScalar()) == "Точечный хил")
							{
								query = "UPDATE Heroes SET PriorityAnswer2 = '3' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}

							else
							{
								query = "UPDATE Heroes SET PriorityAnswer2 = '0' WHERE id = " + i;
								command = new OleDbCommand(query, Connect);
								command.ExecuteNonQuery();
							}
						}
					}

					label1.Text = "За кого хотите играть?";

					radioButton1.Visible = false;
					radioButton2.Visible = false;

					MessageBox.Show("Отметьте галочками желаемых персонажей");

					break;

				case 3:

					pictureBox1.ImageLocation = "D:/aaaa.jpg";

                    for (int i = 0; i <= 27; i++)
                    {
                        string query = "SELECT PriorityAnswer3 FROM Heroes WHERE id = " + i;
                        OleDbCommand command = new OleDbCommand(query, Connect);

                        if (Convert.ToString(command.ExecuteScalar()).Contains("1"))
                        {
                            i = 28;
                            label1.Text = "За какие классы играете лучше всего?";
                            NewVisible();
                            flag = true;
                        }
                    }

                    break;

				case 4:

					pictureBox1.ImageLocation = "D:/aaaaa.jpg";

                    Invisible();

                    foreach (CheckBox checkBox in panel1.Controls.OfType<CheckBox>())
                    {
                        if (flag)
                        {
                            if (checkBox.Checked)
                            {
                                string query = "UPDATE Heroes SET PriorityAnswer4 = '1' WHERE Class = '" + checkBox.Text + "'";
                                OleDbCommand command = new OleDbCommand(query, Connect);
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                string query = "UPDATE Heroes SET PriorityAnswer4 = '0' WHERE Class = '" + checkBox.Text + "'";
                                OleDbCommand command = new OleDbCommand(query, Connect);
                                command.ExecuteNonQuery();
                            }
                        }

                        else
                        {
                            MessageBox.Show("Выберите класс. Это не сложно. ^^\nПросто поставьте галочку. ");
                            answer--;
                        }
                    }

                    label1.Text = "Какой ваш предпочитаемый герой из этого класса?\nОтметьте его галочкой";

                    break;

				case 5:


                    for (int i = 0; i <= 27; i++)
                    {
                        string query = "SELECT PriorityAnswer5 FROM Heroes WHERE id = " + i;
                        OleDbCommand command = new OleDbCommand(query, Connect);

                        if (Convert.ToString(command.ExecuteScalar()).Contains("2"))
                        {
                            i = 28;
                            label1.Text = "А за кого хотел бы сыграть из этого класса?";
                            Invisible();
                        }
                    }

                    break;

                case 6:

                    MessageBox.Show("Спасибо за терпение, сейчас вы увидете результат ^^");

                    string query1 = "UPDATE Heroes SET Flag = '1' WHERE id = 1";
                    OleDbCommand command1 = new OleDbCommand(query1, Connect);

                    command1.ExecuteNonQuery();

                    break;
            }
			answer++;
		}

		private void Invisible()
		{
			foreach (CheckBox checkBox in panel1.Controls.OfType<CheckBox>())
			{
				checkBox.Visible = false;
			}
		}

		private void NewVisible()
		{
			foreach (CheckBox checkBox in panel1.Controls.OfType<CheckBox>())
			{
				checkBox.Visible = true;
			}
		}
	}
}
