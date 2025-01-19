﻿//#define TryCatchDemo
//#define Chapter_3_1
//#define Chapter_3_2
//#define Chapter_3_3_1
#define Chapter_3_3_2

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TryCatch
{

#if TryCatchDemo
class TryCatchDemo
{
	static void Main()
	{
		MessageBox.Show("Выполняется программа!", "Начало");
		try
		{
			Double.Parse(Interaction.InputBox("Введите действительное число: ", "Число"));
			MessageBox.Show("Да, это было число!", "Число");
		}
		catch
		{
			MessageBox.Show("Надо было ввести число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		MessageBox.Show("Программа завершена!", "Завершение");
	}
} 
#endif
#if Chapter_3_1
class Chapter_3_1
{
	static void Main() //Это число 21
	{
		try
		{
			int number = Int32.Parse(Interaction.InputBox("Введите целое число которое делится на три и семь без остатка.\nHint: This is a number - 21", "Input"));
			if(number % 3 == 0 && number % 7 == 0)
			{
				MessageBox.Show($"Число {number} делится на три и семь без остатка","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"Число {number} не делится на три и семь без остатка","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		catch
		{
			MessageBox.Show("Вы ввели не целое число","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

	}
}

#endif
#if Chapter_3_2
	class Chapter_3_2
	{
		static void Main()
		{
			try
			{
				double num1 = Double.Parse(Interaction.InputBox("Введите первое число: ", "Ввод первого числа"));
				double num2 = Double.Parse(Interaction.InputBox("Введите второе число: ", "Ввод второго числа"));
				if (num1 > num2) MessageBox.Show($"Первое число {num1} больше второго {num2}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if (num1 < num2) MessageBox.Show($"Второе число {num2} больше чем первое число {num1}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if (num1 == num2) MessageBox.Show($"Числа {num1} и {num2} равны", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Вы ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
#endif
#if Chapter_3_3_1
	class Chapter_3_3
	{
		static void Main()
		{
			double sum = 0;
			try
			{
				double one_number = Double.Parse(Interaction.InputBox("Введите первое число: ", "Entering a number"));
				double two_number = Double.Parse(Interaction.InputBox("Введите второе число: ", "Entering a number"));
				sum = one_number + two_number;
				do
				{
					MessageBox.Show($"Сумма введённых Вами чисел равна: {sum}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
					two_number = Double.Parse(Interaction.InputBox("Введите число: ", "Entering a number"));
					sum += two_number;
				} while (two_number != 0);
			}
			catch
			{
				MessageBox.Show("Вы не ввели число, программа закончила работу\n" +
					$"Сумма введённых Вами чисел равна: {sum}", "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
#endif
#if Chapter_3_3_2
	class Chapter_3_3_2
	{
		static void Main()
		{
			var sum = 0;
			var number = 0;
			do
			{
				number = int.Parse(Interaction.InputBox("Введите число: ", "Entering a number"));
				while (!int.TryParse(Convert.ToString(number), out number));
				sum += number;
			} while (number != 0);
			MessageBox.Show($"{sum}");
		}
	}
}
#endif
//var sum = 0;
//var n = 0;
//do
//{
//	Console.Write("=>");
//	while (!int.TryParse(Console.ReadLine(), out n)) Console.Write("=>");
//	sum += n;
//} while (n != 0);
//Console.WriteLine(sum);