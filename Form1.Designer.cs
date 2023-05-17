namespace Tree_of_segments
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.build_tree_button = new System.Windows.Forms.Button();
			this.query_button = new System.Windows.Forms.Button();
			this.main_field = new System.Windows.Forms.GroupBox();
			this.comboBox_of_types = new System.Windows.Forms.ComboBox();
			this.list_radioButton = new System.Windows.Forms.RadioButton();
			this.keyboard_radioButton = new System.Windows.Forms.RadioButton();
			this.main_field_info = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.out_richTextBox = new System.Windows.Forms.RichTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBox_of_arrays = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.keyboard_array_textBox = new System.Windows.Forms.TextBox();
			this.print_tree_button = new System.Windows.Forms.Button();
			this.query_field = new System.Windows.Forms.GroupBox();
			this.query_field_info = new System.Windows.Forms.Button();
			this.query_result_textBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.query_r_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.query_l_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.update_field = new System.Windows.Forms.GroupBox();
			this.update_field_info = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.update_newValue_textBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.update_index_textBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.update_button = new System.Windows.Forms.Button();
			this.search_field = new System.Windows.Forms.GroupBox();
			this.search_field_info = new System.Windows.Forms.Button();
			this.search_result_textBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.search_r_textBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.search_l_textBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.search_max_button = new System.Windows.Forms.Button();
			this.search_min_button = new System.Windows.Forms.Button();
			this.main_field.SuspendLayout();
			this.query_field.SuspendLayout();
			this.update_field.SuspendLayout();
			this.search_field.SuspendLayout();
			this.SuspendLayout();
			// 
			// build_tree_button
			// 
			this.build_tree_button.Location = new System.Drawing.Point(74, 211);
			this.build_tree_button.Name = "build_tree_button";
			this.build_tree_button.Size = new System.Drawing.Size(150, 58);
			this.build_tree_button.TabIndex = 0;
			this.build_tree_button.Text = "Создать дерево отрезков";
			this.build_tree_button.UseVisualStyleBackColor = true;
			this.build_tree_button.Click += new System.EventHandler(this.build_tree_button_Click);
			// 
			// query_button
			// 
			this.query_button.Location = new System.Drawing.Point(40, 172);
			this.query_button.Name = "query_button";
			this.query_button.Size = new System.Drawing.Size(201, 36);
			this.query_button.TabIndex = 1;
			this.query_button.Text = "Найти сумму на отрезке";
			this.query_button.UseVisualStyleBackColor = true;
			this.query_button.Click += new System.EventHandler(this.query_button_Click);
			// 
			// main_field
			// 
			this.main_field.Controls.Add(this.comboBox_of_types);
			this.main_field.Controls.Add(this.list_radioButton);
			this.main_field.Controls.Add(this.keyboard_radioButton);
			this.main_field.Controls.Add(this.main_field_info);
			this.main_field.Controls.Add(this.label14);
			this.main_field.Controls.Add(this.out_richTextBox);
			this.main_field.Controls.Add(this.label13);
			this.main_field.Controls.Add(this.comboBox_of_arrays);
			this.main_field.Controls.Add(this.label12);
			this.main_field.Controls.Add(this.keyboard_array_textBox);
			this.main_field.Controls.Add(this.print_tree_button);
			this.main_field.Controls.Add(this.build_tree_button);
			this.main_field.Location = new System.Drawing.Point(23, 23);
			this.main_field.Name = "main_field";
			this.main_field.Size = new System.Drawing.Size(900, 290);
			this.main_field.TabIndex = 2;
			this.main_field.TabStop = false;
			this.main_field.Text = "Создание и управление";
			// 
			// comboBox_of_types
			// 
			this.comboBox_of_types.FormattingEnabled = true;
			this.comboBox_of_types.Items.AddRange(new object[] {
            "Выбрать",
            "ДО сумм на отрезках",
            "ДО максимальных значений",
            "ДО минимальных значений"});
			this.comboBox_of_types.Location = new System.Drawing.Point(555, 197);
			this.comboBox_of_types.Name = "comboBox_of_types";
			this.comboBox_of_types.Size = new System.Drawing.Size(262, 24);
			this.comboBox_of_types.TabIndex = 14;
			// 
			// list_radioButton
			// 
			this.list_radioButton.AutoSize = true;
			this.list_radioButton.Location = new System.Drawing.Point(195, 170);
			this.list_radioButton.Name = "list_radioButton";
			this.list_radioButton.Size = new System.Drawing.Size(151, 20);
			this.list_radioButton.TabIndex = 13;
			this.list_radioButton.Text = "Выбрать из списка";
			this.list_radioButton.UseVisualStyleBackColor = true;
			// 
			// keyboard_radioButton
			// 
			this.keyboard_radioButton.AutoSize = true;
			this.keyboard_radioButton.Location = new System.Drawing.Point(21, 170);
			this.keyboard_radioButton.Name = "keyboard_radioButton";
			this.keyboard_radioButton.Size = new System.Drawing.Size(136, 20);
			this.keyboard_radioButton.TabIndex = 12;
			this.keyboard_radioButton.Text = "Ввести вручную";
			this.keyboard_radioButton.UseVisualStyleBackColor = true;
			// 
			// main_field_info
			// 
			this.main_field_info.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.main_field_info.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.main_field_info.Location = new System.Drawing.Point(878, 12);
			this.main_field_info.Name = "main_field_info";
			this.main_field_info.Size = new System.Drawing.Size(18, 23);
			this.main_field_info.TabIndex = 11;
			this.main_field_info.Text = "i";
			this.main_field_info.UseVisualStyleBackColor = true;
			this.main_field_info.Click += new System.EventHandler(this.main_field_info_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(552, 33);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(265, 16);
			this.label14.TabIndex = 10;
			this.label14.Text = "Текущие значения узлов и листьев ДО:";
			// 
			// out_richTextBox
			// 
			this.out_richTextBox.Location = new System.Drawing.Point(477, 55);
			this.out_richTextBox.Name = "out_richTextBox";
			this.out_richTextBox.ReadOnly = true;
			this.out_richTextBox.Size = new System.Drawing.Size(405, 136);
			this.out_richTextBox.TabIndex = 9;
			this.out_richTextBox.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(24, 106);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(216, 16);
			this.label13.TabIndex = 6;
			this.label13.Text = "Выбор массива из сохранённых:";
			// 
			// comboBox_of_arrays
			// 
			this.comboBox_of_arrays.FormattingEnabled = true;
			this.comboBox_of_arrays.Items.AddRange(new object[] {
            "Выбрать"});
			this.comboBox_of_arrays.Location = new System.Drawing.Point(21, 125);
			this.comboBox_of_arrays.Name = "comboBox_of_arrays";
			this.comboBox_of_arrays.Size = new System.Drawing.Size(248, 24);
			this.comboBox_of_arrays.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(21, 33);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(152, 16);
			this.label12.TabIndex = 4;
			this.label12.Text = "Ручной ввод массива:";
			// 
			// keyboard_array_textBox
			// 
			this.keyboard_array_textBox.Location = new System.Drawing.Point(21, 55);
			this.keyboard_array_textBox.Name = "keyboard_array_textBox";
			this.keyboard_array_textBox.Size = new System.Drawing.Size(248, 22);
			this.keyboard_array_textBox.TabIndex = 3;
			// 
			// print_tree_button
			// 
			this.print_tree_button.Location = new System.Drawing.Point(572, 227);
			this.print_tree_button.Name = "print_tree_button";
			this.print_tree_button.Size = new System.Drawing.Size(231, 42);
			this.print_tree_button.TabIndex = 1;
			this.print_tree_button.Text = "Вывести дерево отрезков";
			this.print_tree_button.UseVisualStyleBackColor = true;
			this.print_tree_button.Click += new System.EventHandler(this.print_tree_button_Click);
			// 
			// query_field
			// 
			this.query_field.Controls.Add(this.query_field_info);
			this.query_field.Controls.Add(this.query_result_textBox);
			this.query_field.Controls.Add(this.label4);
			this.query_field.Controls.Add(this.label3);
			this.query_field.Controls.Add(this.query_r_textBox);
			this.query_field.Controls.Add(this.label2);
			this.query_field.Controls.Add(this.query_l_textBox);
			this.query_field.Controls.Add(this.label1);
			this.query_field.Controls.Add(this.query_button);
			this.query_field.Location = new System.Drawing.Point(23, 333);
			this.query_field.Name = "query_field";
			this.query_field.Size = new System.Drawing.Size(285, 223);
			this.query_field.TabIndex = 3;
			this.query_field.TabStop = false;
			this.query_field.Text = "Сумма";
			// 
			// query_field_info
			// 
			this.query_field_info.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.query_field_info.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.query_field_info.Location = new System.Drawing.Point(263, 11);
			this.query_field_info.Name = "query_field_info";
			this.query_field_info.Size = new System.Drawing.Size(18, 23);
			this.query_field_info.TabIndex = 9;
			this.query_field_info.Text = "i";
			this.query_field_info.UseVisualStyleBackColor = true;
			this.query_field_info.Click += new System.EventHandler(this.query_field_info_Click);
			// 
			// query_result_textBox
			// 
			this.query_result_textBox.Location = new System.Drawing.Point(104, 129);
			this.query_result_textBox.Name = "query_result_textBox";
			this.query_result_textBox.Size = new System.Drawing.Size(146, 22);
			this.query_result_textBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Результат:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(150, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Правая:";
			// 
			// query_r_textBox
			// 
			this.query_r_textBox.Location = new System.Drawing.Point(150, 82);
			this.query_r_textBox.Name = "query_r_textBox";
			this.query_r_textBox.Size = new System.Drawing.Size(100, 22);
			this.query_r_textBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Левая:";
			// 
			// query_l_textBox
			// 
			this.query_l_textBox.Location = new System.Drawing.Point(18, 82);
			this.query_l_textBox.Name = "query_l_textBox";
			this.query_l_textBox.Size = new System.Drawing.Size(100, 22);
			this.query_l_textBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(15, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Границы исследуемого отрезка:";
			// 
			// update_field
			// 
			this.update_field.Controls.Add(this.update_field_info);
			this.update_field.Controls.Add(this.label9);
			this.update_field.Controls.Add(this.update_newValue_textBox);
			this.update_field.Controls.Add(this.label10);
			this.update_field.Controls.Add(this.update_index_textBox);
			this.update_field.Controls.Add(this.label11);
			this.update_field.Controls.Add(this.update_button);
			this.update_field.Location = new System.Drawing.Point(332, 333);
			this.update_field.Name = "update_field";
			this.update_field.Size = new System.Drawing.Size(285, 223);
			this.update_field.TabIndex = 4;
			this.update_field.TabStop = false;
			this.update_field.Text = "Замена значения";
			// 
			// update_field_info
			// 
			this.update_field_info.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update_field_info.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.update_field_info.Location = new System.Drawing.Point(263, 11);
			this.update_field_info.Name = "update_field_info";
			this.update_field_info.Size = new System.Drawing.Size(18, 23);
			this.update_field_info.TabIndex = 10;
			this.update_field_info.Text = "i";
			this.update_field_info.UseVisualStyleBackColor = true;
			this.update_field_info.Click += new System.EventHandler(this.update_field_info_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(24, 119);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Новое значение:";
			// 
			// update_newValue_textBox
			// 
			this.update_newValue_textBox.Location = new System.Drawing.Point(149, 116);
			this.update_newValue_textBox.Name = "update_newValue_textBox";
			this.update_newValue_textBox.Size = new System.Drawing.Size(100, 22);
			this.update_newValue_textBox.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(27, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Индекс:";
			// 
			// update_index_textBox
			// 
			this.update_index_textBox.Location = new System.Drawing.Point(91, 69);
			this.update_index_textBox.Name = "update_index_textBox";
			this.update_index_textBox.Size = new System.Drawing.Size(100, 22);
			this.update_index_textBox.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(25, 25);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(155, 18);
			this.label11.TabIndex = 14;
			this.label11.Text = "Данные для замены:";
			// 
			// update_button
			// 
			this.update_button.Location = new System.Drawing.Point(48, 172);
			this.update_button.Name = "update_button";
			this.update_button.Size = new System.Drawing.Size(201, 36);
			this.update_button.TabIndex = 2;
			this.update_button.Text = "Заменить";
			this.update_button.UseVisualStyleBackColor = true;
			this.update_button.Click += new System.EventHandler(this.update_button_Click);
			// 
			// search_field
			// 
			this.search_field.Controls.Add(this.search_field_info);
			this.search_field.Controls.Add(this.search_result_textBox);
			this.search_field.Controls.Add(this.label5);
			this.search_field.Controls.Add(this.label6);
			this.search_field.Controls.Add(this.search_r_textBox);
			this.search_field.Controls.Add(this.label7);
			this.search_field.Controls.Add(this.search_l_textBox);
			this.search_field.Controls.Add(this.label8);
			this.search_field.Controls.Add(this.search_max_button);
			this.search_field.Controls.Add(this.search_min_button);
			this.search_field.Location = new System.Drawing.Point(638, 333);
			this.search_field.Name = "search_field";
			this.search_field.Size = new System.Drawing.Size(285, 223);
			this.search_field.TabIndex = 5;
			this.search_field.TabStop = false;
			this.search_field.Text = "Максимум и минимум";
			// 
			// search_field_info
			// 
			this.search_field_info.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_field_info.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.search_field_info.Location = new System.Drawing.Point(263, 11);
			this.search_field_info.Name = "search_field_info";
			this.search_field_info.Size = new System.Drawing.Size(18, 23);
			this.search_field_info.TabIndex = 19;
			this.search_field_info.Text = "i";
			this.search_field_info.UseVisualStyleBackColor = true;
			this.search_field_info.Click += new System.EventHandler(this.search_field_info_Click);
			// 
			// search_result_textBox
			// 
			this.search_result_textBox.Location = new System.Drawing.Point(110, 129);
			this.search_result_textBox.Name = "search_result_textBox";
			this.search_result_textBox.Size = new System.Drawing.Size(146, 22);
			this.search_result_textBox.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Результат:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(156, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Правая:";
			// 
			// search_r_textBox
			// 
			this.search_r_textBox.Location = new System.Drawing.Point(156, 82);
			this.search_r_textBox.Name = "search_r_textBox";
			this.search_r_textBox.Size = new System.Drawing.Size(100, 22);
			this.search_r_textBox.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Левая:";
			// 
			// search_l_textBox
			// 
			this.search_l_textBox.Location = new System.Drawing.Point(24, 82);
			this.search_l_textBox.Name = "search_l_textBox";
			this.search_l_textBox.Size = new System.Drawing.Size(100, 22);
			this.search_l_textBox.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(21, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(236, 18);
			this.label8.TabIndex = 9;
			this.label8.Text = "Границы исследуемого отрезка:";
			// 
			// search_max_button
			// 
			this.search_max_button.Location = new System.Drawing.Point(29, 172);
			this.search_max_button.Name = "search_max_button";
			this.search_max_button.Size = new System.Drawing.Size(101, 36);
			this.search_max_button.TabIndex = 3;
			this.search_max_button.Text = " Максимум";
			this.search_max_button.UseVisualStyleBackColor = true;
			this.search_max_button.Click += new System.EventHandler(this.search_max_button_Click);
			// 
			// search_min_button
			// 
			this.search_min_button.Location = new System.Drawing.Point(156, 172);
			this.search_min_button.Name = "search_min_button";
			this.search_min_button.Size = new System.Drawing.Size(101, 36);
			this.search_min_button.TabIndex = 2;
			this.search_min_button.Text = " Минимум";
			this.search_min_button.UseVisualStyleBackColor = true;
			this.search_min_button.Click += new System.EventHandler(this.search_min_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 580);
			this.Controls.Add(this.search_field);
			this.Controls.Add(this.update_field);
			this.Controls.Add(this.query_field);
			this.Controls.Add(this.main_field);
			this.Name = "Form1";
			this.Text = "Tree of segments";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.main_field.ResumeLayout(false);
			this.main_field.PerformLayout();
			this.query_field.ResumeLayout(false);
			this.query_field.PerformLayout();
			this.update_field.ResumeLayout(false);
			this.update_field.PerformLayout();
			this.search_field.ResumeLayout(false);
			this.search_field.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button build_tree_button;
		private System.Windows.Forms.Button query_button;
		private System.Windows.Forms.GroupBox main_field;
		private System.Windows.Forms.GroupBox query_field;
		private System.Windows.Forms.GroupBox update_field;
		private System.Windows.Forms.GroupBox search_field;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox query_l_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button update_button;
		private System.Windows.Forms.Button search_max_button;
		private System.Windows.Forms.Button search_min_button;
		private System.Windows.Forms.Button main_field_info;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RichTextBox out_richTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBox_of_arrays;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox keyboard_array_textBox;
		private System.Windows.Forms.Button print_tree_button;
		private System.Windows.Forms.Button query_field_info;
		private System.Windows.Forms.TextBox query_result_textBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox query_r_textBox;
		private System.Windows.Forms.Button update_field_info;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox update_newValue_textBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox update_index_textBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button search_field_info;
		private System.Windows.Forms.TextBox search_result_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox search_r_textBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox search_l_textBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton list_radioButton;
		private System.Windows.Forms.RadioButton keyboard_radioButton;
		private System.Windows.Forms.ComboBox comboBox_of_types;
	}
}

