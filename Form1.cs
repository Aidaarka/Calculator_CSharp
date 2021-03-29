using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        //глобальные переменные
        double value = 0; 
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        //нажатие цифр
        private void buttion_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //определение типа кнопки и запись в него значения нажатого значения
            if ((result.Text == "0") || (operation_pressed))//если в TextBox написан Нуль или кнопка цифры не нажата, 
            {
                result.Clear(); //то строка TextBox очищается 
            }
            operation_pressed = false; //кнопка нажата = false(нет)
            result.Text = result.Text + b.Text; //поочередное суммирование стринговых нажатых значений и запись в TextBox
        }

        //Оператор математические операции
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //определение типа кнопки и запись в него значения нажатого оператора
            operation = b.Text; //запись с кнопки значения строкового типа в переменную Operation
            value = double.Parse(result.Text); //деление результирующей строки методом Parse, перевод в тип double и запись в переменную value
            operation_pressed = true; //кнопка нажата = true(да)
            equat.Text = value + " " + operation; //идет запись в строку Lable (знаяение + операция = перевод в строку)
        }

        //Кнопка равно
        private void button17_Click(object sender, EventArgs e)
        {
            equat.Text = "";
            switch(operation)//выбирается операция с помощью условной функции SWITCH-CASE
            {
                case "+"://плюс
                    result.Text = (value + double.Parse(result.Text)).ToString();//запись в строковую переменную Result
                    break;
                case "-"://минус
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*"://умножение
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/"://деление
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                case "√"://корень
                    result.Text = (Math.Sqrt(double.Parse(result.Text))).ToString();
                    break;
                case "x²"://квадрат
                    result.Text = (Math.Pow(double.Parse(result.Text), 2)).ToString();
                    break;
                case "-/+"://смена знака
                    result.Text = ( - double.Parse(result.Text)).ToString();
                    break;
                case "cos"://косинус
                    result.Text = (Math.Cos(double.Parse(result.Text))).ToString();
                    break;
                case "sin"://синус
                    result.Text = (Math.Sin(double.Parse(result.Text))).ToString();
                    break;
                case "ln"://натуральный логарифм
                    result.Text = (Math.Log10(double.Parse(result.Text))).ToString();
                    break;
                default:
                    break;
            }
        }

        //оператор С - очистить всё введенное 
        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0"; //зануляется строка выведенная в TextBox
            value = 0; //зануляется значение переменной числа с плавающей запятой 
        }

        //оператор CE - очистить последнее введенное 
        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        
    }
}


/* 
 * 1 - пишем для значений цифр код, при этом там оставляем операция=ложно
 * 2 - создаем глобальные переменные, объясняем эти переменные и почему они глобальные
 * 3 - пишем код для кнопок операций 
 * 4 - дописываем в цифры код операция=ложно
 * 5 - пишем SWITCH-CASE
 * 6 - пишем оператор С и оператор СЕ
 */