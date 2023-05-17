using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tree_of_segments
{
	public partial class Form1 : Form
	{
		int[] array;
		Tree tree;

		public Form1()
		{
			InitializeComponent();
		}

		
		//_______________________________________________________________________________________________________________________________________________
		//     ОСНОВНЫЕ МЕТОДЫ ПРОГРАММЫ
		//_______________________________________________________________________________________________________________________________________________

		private void Form1_Load(object sender, EventArgs e)
		{
			print_tree_button.Enabled = false;
			query_field.Enabled = false;
			update_field.Enabled = false;
			search_field.Enabled = false;
			query_result_textBox.ReadOnly = true;
			search_result_textBox.ReadOnly = true;
			comboBox_of_arrays.SelectedItem = "Выбрать";
			comboBox_of_types.SelectedItem = "Выбрать";
			out_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
			load_info_message();
		}

		// событие создания ДО при
		private void build_tree_button_Click(object sender, EventArgs e)
		{
			if (keyboard_radioButton.Checked) // заполнение массива из поля keyboard_array_textBox
			{
				if (keyboard_array_textBox.Text == "")
				{
					MessageBox.Show("Вы не ввели массив!");
				}
				else
				{
					fill_array(keyboard_array_textBox.Text, out array);
					tree = new Tree(0, 0, array.Length, ref array); // создание экземпляра класса Tree
					reveal_panels();
				}
			}
			else if (list_radioButton.Checked) // заполнение массива из поля combBox_of_arrays
			{
				if (comboBox_of_arrays.Text == "Выбрать")
				{
					MessageBox.Show("Вы не выбрали массив!");
				}
				else
				{
					fill_array(comboBox_of_arrays.Text, out array);
					tree = new Tree(0, 0, array.Length, ref array); // создание экземпляра класса Tree
					reveal_panels();
				}
			}
			else 
			{
				MessageBox.Show("Вы не выбрали способ ввода массива!");
			}
		}

		// событие поиска суммы на отрезке
		private void query_button_Click(object sender, EventArgs e)
		{
			if (index_check(int.Parse(query_l_textBox.Text), int.Parse(query_r_textBox.Text)))
			{
				string result = (tree.query(0, 0, array.Length, int.Parse(query_l_textBox.Text), int.Parse(query_r_textBox.Text))).ToString();
				query_result_textBox.Text = result;
			}
		}

		// событие замены элемента по индексу
		private void update_button_Click(object sender, EventArgs e)
		{
			if (index_check(int.Parse(update_index_textBox.Text)))
			{
				tree.update(0, 0, array.Length, int.Parse(update_index_textBox.Text), int.Parse(update_newValue_textBox.Text));
				MessageBox.Show("Значение элемента с индексом " + update_index_textBox.Text + " было успешно заменено на значение " + update_newValue_textBox.Text + "!");
			}
		}

		// событие поиска максимума на отрезке
		private void search_max_button_Click(object sender, EventArgs e)
		{
			if (index_check(int.Parse(search_l_textBox.Text), int.Parse(search_r_textBox.Text)))
			{
				string result = (tree.search_max(0, 0, array.Length, int.Parse(search_l_textBox.Text), int.Parse(search_r_textBox.Text))).ToString();
				search_result_textBox.Text = result;
			}
		}

		// событие поиска минимума на отрезке
		private void search_min_button_Click(object sender, EventArgs e)
		{
			if (index_check(int.Parse(search_l_textBox.Text), int.Parse(search_r_textBox.Text)))
			{
				string result = (tree.search_min(0, 0, array.Length, int.Parse(search_l_textBox.Text), int.Parse(search_r_textBox.Text))).ToString();
				search_result_textBox.Text = result;
			}
		}

		// событие вывода ДО в текстовое поле
		private void print_tree_button_Click(object sender, EventArgs e)
		{
			out_richTextBox.Text = "";
			if (comboBox_of_types.Text == "Выбрать") MessageBox.Show("Вы не выбрали тип дерева отрезков, который хотите вывести!");
			else if (comboBox_of_types.Text == "ДО сумм на отрезках") print_tree(ref tree.sum_tree);
			else if (comboBox_of_types.Text == "ДО максимальных значений") print_tree(ref tree.max_tree);
			else if (comboBox_of_types.Text == "ДО минимальных значений") print_tree(ref tree.min_tree);
		}


		//_______________________________________________________________________________________________________________________________________________
		//     ПРОЧИЕ МЕТОДЫ ПРОГРАММЫ
		//_______________________________________________________________________________________________________________________________________________

		// метод, заполняющий массив данными из keyboard_array_textBox и comboBox_of_arrays
		private void fill_array(string text, out int[] array)
		{
			string[] str = text.Split(' ');
			array = new int[str.LongLength];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToInt32(str[i]);
			}
		}

		// метод, отображающий панели интерфейса после создания ДО
		private void reveal_panels()
		{
			print_tree_button.Enabled = true;
			query_field.Enabled = true;
			update_field.Enabled = true;
			search_field.Enabled = true;
		}

		// метод, отвечающий за вывод ДО в richTextBox
		private void print_tree(ref int[] type_tree)
		 {
			int count = 1;
			for (int i = 0; i < tree.size;)
			{
				for (int j = 0; j < count && i < tree.size; j++, i++)
				{
					out_richTextBox.AppendText((type_tree[i]).ToString() + "  ");
				}
				count = count * 2;
				out_richTextBox.AppendText("\n" +
					"----------------------------------------------------------------------------------------------" +
					"\n");
			}
		}

		// метод, отвечающий за правильность значения границ отрезка и индекса
		private bool index_check(int ql, int qr)
		{
			if (ql < 0 || qr < 0 || qr > array.Length || ql > array.Length || ql >= qr) 
			{
				MessageBox.Show("ОШИБКА!" +
				"\n 1) Границы не могут быть меньше нуля;" +
				"\n 2) Границы не могут быть больше длины массива;" +
				"\n 3) Границы не могут быть равны;" +
				"\n 4) Левая граница не может быть больше правой.");
				return false;
			}
			else
			{
				return true;
			}
		}
		private bool index_check(int index)
		{
			if (index < 0 || index > array.Length)
			{
				MessageBox.Show("ОШИБКА!" +
				"\n 1) Индекс не может быть меньше нуля;" +
				"\n 2) Индекс не может быть больше длины массива.");
				return false;
			}
			else
			{
				return true;
			}
		}


		//_______________________________________________________________________________________________________________________________________________
		//     ИНФОРМАЦИОННЫЕ ПОЛЯ ПРОГРАММЫ
		//_______________________________________________________________________________________________________________________________________________
		private void load_info_message()
		{
			MessageBox.Show("Приветствую вас в программе для создания и взаимодействия с деревьями отрезков!" +
				"\n\nНиже представлена полезная информация о возможностях программы:" +
				"\n\n- Поле 'Создание и управление' позволяет вам:" +
				"\n 1) Создать дерево отрезков по введённому или выбранному массиву;" +
				"\n 2) Вывести вершины дерева отрезков в текстовое поле;" +
				"\n\n- Поле 'Сумма' позволяет вам найти сумму элементов на выбранном отрезке." +
				"\n\n- Поле 'Замена значения' позволяет вам изменить значение элемента с указанным индексом на новое." +
				"\n\n- Поле 'Максимум и минимум' позволяет вам найти минимальное или максимальное значение на выбранном отрезке." +
				"\n\nВАЖНО!" +
				"\n 1) Ввод массива вручную должен быть в формате 'число-пробел-чилсо'." +
				"\n Пример: 1 2 3 4 ... n" +
				"\n 2) Нумерация индексов элементов начинается с 0;" +
				"\n 3) Правая граница отрезка является выколотой -> [l, r).");
		}
		private void main_field_info_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Данное поле позволяет вам:" +
				"\n 1) Создать дерево отрезков по введённому или выбранному массиву;" +
				"\n 2) Вывести вершины дерева отрезков в текстовое поле;" +
				"\nВАЖНО!" +
				"\nВвод массива вручную должен быть в формате 'число-пробел-чилсо'." +
				"\nПример: 1 2 3 4 ... n");
		}
		private void query_field_info_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Данное поле позволяет вам найти сумму элементов на выбранном отрезке." +
				"\nВАЖНО!" +
				"\n 1) Нумерация индексов элементов начинается с 0;" +
				"\n 2) Правая граница отрезка является выколотой -> [l, r).");
		}
		private void update_field_info_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Данное поле позволяет вам изменить значение элемента с указанным индексом на новое." +
				"\nВАЖНО!" +
				"\nНумерация индексов элементов начинается с 0;");
		}
		private void search_field_info_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Данное поле позволяет вам найти минимальное или максимальное значение на выбранном отрезке." +
				"\nВАЖНО!" +
				"\n 1) Нумерация индексов элементов начинается с 0;" +
				"\n 2) Правая граница отрезка является выколотой -> [l, r).");
		}
	}
}
