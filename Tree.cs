using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tree_of_segments
{
	class Tree // класс реализующий создание и работу с деревом отрезков (в будущем ДО)
	{
		public int[] sum_tree; // массив, в котором будет храниться ДО
		public int[] min_tree; // массив хранения отрезка, для поиска минимального значения 
		public int[] max_tree; // массив хранения отрезка, для поиска ммального значения
		public int size;

		public Tree(int v, int l, int r, ref int[] array) // конструктор класса для быстрого создания ДО при создании экземпляра
		{
			size = 4 * array.Length;
			sum_tree = new int[size];
			min_tree = new int[size];
			max_tree = new int[size];
			build_sumTree(v, l, r, ref array); // создание ДО с суммами значений на отрезке в узлах
			build_minTree(v, l, r, ref array); // создание ДО с минимальными значениями в узлах
			build_maxTree(v, l, r, ref array); // создание ДО с максимальными значениями в узлах
		}

		// метод, отвечающий за создание ДО, содержащего суммы отрезков в узлах
		private void build_sumTree(int v, int l, int r, ref int[] array)
		{
			if (r - l == 1)
			{
				sum_tree[v] = array[l];
				return;
			}
			int middle = (l + r) / 2;
			build_sumTree(2 * v + 1, l, middle, ref array); // создание правой ветки
			build_sumTree(2 * v + 2, middle, r, ref array); // создание левой ветки
			sum_tree[v] = sum_tree[2 * v + 1] + sum_tree[2 * v + 2]; // запись в узел суммы значений двух дочерних узлов
		}

		// метод, отвечающий за создание ДО, содержащего минимальные значения в узлах
		private void build_minTree(int v, int l, int r, ref int[] array)
		{
			if (r - l == 1)
			{
				min_tree[v] = array[l];
				return;
			}
			int middle = (l + r) / 2;
			build_minTree(2 * v + 1, l, middle, ref array); // создание правой ветки
			build_minTree(2 * v + 2, middle, r, ref array); // создание левой ветки
			min_tree[v] = Math.Min(min_tree[2 * v + 1], min_tree[2 * v + 2]); // запись в узел минимального значения среди двух вершин
		}

		// метод, отвечающий за создание ДО, содержащего максимальные значения в узлах
		private void build_maxTree(int v, int l, int r, ref int[] array)
		{
			if (r - l == 1)
			{
				max_tree[v] = array[l];
				return;
			}
			int middle = (l + r) / 2;
			build_maxTree(2 * v + 1, l, middle, ref array); // создание правой ветки
			build_maxTree(2 * v + 2, middle, r, ref array); // создание левой ветки
			max_tree[v] = Math.Max(max_tree[2 * v + 1], max_tree[2 * v + 2]); // запись в узел максимального значения среди двух вершин
		}

		// метод, возвращающий сумму на отрезке
		public int query(int v, int l, int r, int ql, int qr)
		{
			int middle = (l + r) / 2;
			if (ql >= r || l >= qr)
			{
				return 0;
			}
			if (ql <= l && r <= qr)
			{
				return sum_tree[v];
			}
			int q1 = query(2 * v + 1, l, middle, ql, qr);
			int q2 = query(2 * v + 2, middle, r, ql, qr);
			return q1 + q2;
		}

		// метод, отвечающий за замену числа "x" на отрезке на число "i"
		public void update(int v, int l, int r, int index, int new_value)
		{
			if (r - l == 1)
			{
				sum_tree[v] = new_value;
				min_tree[v] = new_value;
				max_tree[v] = new_value;
				return;
			}
			int middle = (l + r) / 2;
			if (index < middle)
			{
				update(2 * v + 1, l, middle, index, new_value);
			}
			else
			{
				update(2 * v + 2, middle, r, index, new_value);
			}
			sum_tree[v] = sum_tree[2 * v + 1] + sum_tree[2 * v + 2];
			min_tree[v] = Math.Min(min_tree[2 * v + 1], min_tree[2 * v + 2]);
			max_tree[v] = Math.Max(max_tree[2 * v + 1], max_tree[2 * v + 2]);
		}

		// метод для поиска максимального значения на отрезке
		public int search_max(int v, int l, int r, int ql, int qr)
		{
			int middle = (l + r) / 2;
			if (ql >= r || l >= qr)
			{
				return int.MinValue;
			}
			if (ql <= l && r <= qr)
			{
				return max_tree[v];
			}
			int max1 = search_max(2 * v + 1, l, middle, ql, qr);
			int max2 = search_max(2 * v + 2, middle, r, ql, qr);
			return Math.Max(max1, max2);
		}

		// метод для поиска минимального значения на отрезке
		public int search_min(int v, int l, int r, int ql, int qr)
		{
			int middle = (l + r) / 2;
			if (ql >= r || l >= qr)
			{
				return int.MaxValue;
			}
			if (ql <= l && r <= qr)
			{
				return min_tree[v];
			}
			int min1 = search_min(2 * v + 1, l, middle, ql, qr);
			int min2 = search_min(2 * v + 2, middle, r, ql, qr);
			return Math.Min(min1, min2);
		}
	}
}
