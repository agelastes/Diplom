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
	public partial class Пик : Form
	{
		bool[] pick = new bool[28];
		int flag = 0;
		int j = 1;
		int tanks = 0;
		int dd = 0;
		int support = 0;
		int tanksfiend;
		bool scroll = false;
		public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";
		private OleDbConnection Connection;
		public Пик()
		{
			InitializeComponent();

			foreach (Label label in panel1.Controls.OfType<Label>())
			{
				label.Visible = false;
			}

			Connection = new OleDbConnection(connectString);
			Connection.Open();

			for (int i = 0; i < 28; i++)
			{
				pick[i] = false;
			}

			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;

			int pic = 1;

			foreach (PictureBox pictureBox in panel1.Controls.OfType<PictureBox>())
			{
				pictureBox.ImageLocation = "D:/" + Convert.ToString(pic) + ".png";
				pic++;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (flag)
			{
				case 0:

					if (!scroll)
					{
						richTextBox1.Text += "Ваши герои:" + "\n\n";
					}

					Rezume();

					if (!scroll)
					{
						label1.Text = "А теперь героев противника ^^";
						richTextBox1.Text += "Герои противника: " + "\n\n";

						UpdatePriority();

						CheckBoxRefresh();
					}
					else
					{
						MessageBox.Show("Спасибо за терпение, продолжим тест 🖤");
						CheckBoxRefresh();

						Form3 example = new Form3();
						example.Show();

						flag++;

						Connection.Close();
					}

					scroll = true;

					break;

				case 1:

					Connection.Open();
					richTextBox1.Text += "Желаемый персонаж:" + "\n\n";
					Rezume();
					flag++;

					CheckBoxRefresh();

					break;

				case 2:

					richTextBox1.Text += "Ваш самый удачный персонаж из желаемого класса:" + "\n\n";
					Rezume();

					CheckBoxRefresh();
					flag++;

					break;

				case 3:

					richTextBox1.Text += "Ваш желаемый персонаж из желаемого класса:" + "\n\n";
					Rezume();

					CheckBoxRefresh();
					flag++;

					break;

				case 4:

					Flag4();
					flag++;

					break;

			}
		}

		private void CheckBoxRefresh()
		{
			foreach (CheckBox checkBox in panel1.Controls.OfType<CheckBox>())
			{
				if (checkBox.Checked)
				{
					checkBox.Checked = false;
				}
			}
		}

		private void UpdatePriority()
		{
			if (tanks == 0)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Class FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "Танк")
					{
						query = "UPDATE Heroes SET PriorityPick = '10' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityPick = '0' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}
			}
			if (tanks == 1)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Class FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "Танк")
					{
						query = "UPDATE Heroes SET PriorityPick = '5' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityPick = '0' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}
			}

			if (tanksfiend >= 2)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Name FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "Жнец")
					{
						query = "UPDATE Heroes SET PriorityExcent = '3' WHERE Name = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityExcent = '0' WHERE Name = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}
			}

			if (dd == 0)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Class FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "ДД")
					{
						query = "UPDATE Heroes SET PriorityPick = '10' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityPick = '0' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}
			}

			if (dd == 1)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Class FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "ДД")
					{
						query = "UPDATE Heroes SET PriorityPick = '5' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityPick = '0' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}
			}

			if (support == 0)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Class FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "Саппорт")
					{
						query = "UPDATE Heroes SET PriorityPick = '10' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityPick = '0' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}

			    string query1 = "UPDATE Heroes SET PriorityExcent = '5' WHERE Name = 'Ангел'";
				OleDbCommand command1 = new OleDbCommand(query1, Connection);
				command1.ExecuteNonQuery();

			}
			if (support == 1)
			{
				for (int i = 0; i <= 27; i++)
				{
					string query = "SELECT Class FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					if (Convert.ToString(command.ExecuteScalar()) == "Саппорт")
					{
						query = "UPDATE Heroes SET PriorityPick = '5' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
					else
					{
						query = "UPDATE Heroes SET PriorityPick = '0' WHERE Class = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}
				}
			}
		}

		private void Rezume()
		{
			for (int i = 0; i < 28; i++)
			{
				if (pick[i])
				{
					string query = "SELECT Name FROM Heroes WHERE id = " + i;
					OleDbCommand command = new OleDbCommand(query, Connection);
					richTextBox1.Text += Convert.ToString(j) + ". " + Convert.ToString(command.ExecuteScalar()) + "\n\n";

					if (!scroll)
					{
						for (int j = 0; j <= 27; j++)
						{
							query = "SELECT Class FROM Heroes WHERE id = " + i;
							command = new OleDbCommand(query, Connection);
							if (Convert.ToString(command.ExecuteScalar()) == "Танк")
							{
								tanksfiend++;
							}
						}
					}

					if (flag == 1)
					{
						query = "UPDATE Heroes SET PriorityAnswer3 = '1' WHERE Name = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}

					if (flag == 2)
					{
						query = "UPDATE Heroes SET PriorityAnswer5 = '2' WHERE Name = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}

					if (flag == 3)
					{
						query = "UPDATE Heroes SET PriorityAnswer6 = '1' WHERE Name = '" + Convert.ToString(command.ExecuteScalar()) + "'";
						command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}

					if (flag == 4)
					{
						Flag4();

						foreach (CheckBox checkbox in panel1.Controls.OfType<CheckBox>())
						{
							checkbox.Visible = false;
						}

						foreach (Label label in panel1.Controls.OfType<Label>())
						{
							label.Visible = true;
						}
					}

					query = "SELECT Class FROM Heroes WHERE id = " + i;
					command = new OleDbCommand(query, Connection);
					richTextBox1.Text += "Класс: " + Convert.ToString(command.ExecuteScalar()) + "\n";

					if (Convert.ToString(command.ExecuteScalar()) == "Танк")
					{
						tanks++;
					}

					if (Convert.ToString(command.ExecuteScalar()) == "ДД")
					{
						dd++;
					}

					if (Convert.ToString(command.ExecuteScalar()) == "Саппорт")
					{
						support++;
					}

					query = "SELECT Role FROM Heroes WHERE id = " + i;
					command = new OleDbCommand(query, Connection);
					richTextBox1.Text += "Роль: " + Convert.ToString(command.ExecuteScalar()) + "\n";

					query = "SELECT Mobility FROM Heroes WHERE id = " + i;
					command = new OleDbCommand(query, Connection);
					richTextBox1.Text += "Мобильность: " + Convert.ToString(command.ExecuteScalar()) + "\n";

					query = "SELECT damage FROM Heroes WHERE id = " + i;
					command = new OleDbCommand(query, Connection);
					richTextBox1.Text += "Тип урона: " + Convert.ToString(command.ExecuteScalar()) + "\n\n";

					j++;
				}

				else
				{
					if (flag == 1)
					{
						string query = "UPDATE Heroes SET PriorityAnswer3 = '0' WHERE id = " + i;
						OleDbCommand command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}

					if (flag == 2)
					{
						string query = "UPDATE Heroes SET PriorityAnswer5 = '0' WHERE id = " + i;
						OleDbCommand command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}

					if (flag == 3)
					{
						string query = "UPDATE Heroes SET PriorityAnswer6 = '0' WHERE id = " + i;
						OleDbCommand command = new OleDbCommand(query, Connection);
						command.ExecuteNonQuery();
					}

					if (flag == 4)
					{
						Flag4();

						foreach (CheckBox checkbox in panel1.Controls.OfType<CheckBox>())
						{
							checkbox.Visible = false;
						}

						foreach (Label label in panel1.Controls.OfType<Label>())
						{
							label.Visible = true;
						}
					}
				}
			}
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox ckd = (CheckBox)sender;
			string tag = (string)ckd.Tag;
			pick[Convert.ToInt32(tag)] = !pick[Convert.ToInt32(tag)];
		}

		private void Flag4()
		{
			string query = "SELECT Flag FROM Heroes WHERE id = 1";
			OleDbCommand command = new OleDbCommand(query, Connection);
			int j = 1;

			int finalpriority = 0;

            foreach (CheckBox checkbox in panel1.Controls.OfType<CheckBox>())
            {
                checkbox.Visible = false;
            }

			if (Convert.ToString(command.ExecuteScalar()) == "1")                               // НЕ стерай, долбоеб, это ВАЖНО!
			{
				foreach (Label label in panel1.Controls.OfType<Label>())

				{
					query = "SELECT PriorityPick FROM Heroes WHERE id = " + j;
					string query1 = "SELECT PriorityAnswer1 FROM Heroes WHERE id = " + j;
					string query2 = "SELECT PriorityAnswer2 FROM Heroes WHERE id = " + j;
					string query3 = "SELECT PriorityAnswer3 FROM Heroes WHERE id = " + j;
					string query4 = "SELECT PriorityAnswer4 FROM Heroes WHERE id = " + j;
					string query5 = "SELECT PriorityAnswer5 FROM Heroes WHERE id = " + j;
					string query6 = "SELECT PriorityAnswer6 FROM Heroes WHERE id = " + j;
					string query7 = "SELECT PriorityExcent FROM Heroes WHERE id = " + j;

					command = new OleDbCommand(query, Connection);
					OleDbCommand command1 = new OleDbCommand(query1, Connection);
					OleDbCommand command2 = new OleDbCommand(query2, Connection);
					OleDbCommand command3 = new OleDbCommand(query3, Connection);
					OleDbCommand command4 = new OleDbCommand(query4, Connection);
					OleDbCommand command5 = new OleDbCommand(query5, Connection);
					OleDbCommand command6 = new OleDbCommand(query6, Connection);
					OleDbCommand command7 = new OleDbCommand(query7, Connection);

					finalpriority = Convert.ToInt32(command.ExecuteScalar()) + Convert.ToInt32(command1.ExecuteScalar()) + Convert.ToInt32(command2.ExecuteScalar()) + Convert.ToInt32(command3.ExecuteScalar()) + Convert.ToInt32(command4.ExecuteScalar()) + Convert.ToInt32(command5.ExecuteScalar()) + Convert.ToInt32(command6.ExecuteScalar()) + Convert.ToInt32(command7.ExecuteScalar());
                    finalpriority = (finalpriority / 33) * 100;

					string finalquery = "UPDATE Heroes SET FinalPriority = " + Convert.ToString(finalpriority) + "%" + " WHERE id = " + j;
					command = new OleDbCommand(finalquery, Connection);

					command.ExecuteNonQuery();

					query = "SELECT FinalPriority FROM Heroes WHERE id = " + j;
					command = new OleDbCommand(query, Connection);

                    label.Visible = true;
					label.Text = Convert.ToString(command.ExecuteScalar());

					j++;
				}
			}
		}
	}
}


