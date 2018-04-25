using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project
{
    public partial class Data_redactor : Form
    { 
        public Data_redactor()
        {
            InitializeComponent();
        }

        //Генерация данных в файл
        private void button_random_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //Наш генератор случайных чисел
            int machine = Convert.ToInt32(textBox_machine.Text); //количество станков
            int detail = Convert.ToInt32(textBox_detail.Text); //количество деталей
            int random_s = Convert.ToInt32(textBox_random_ot.Text); //random_start, минимум генератора случайных чисел
            int random_e = Convert.ToInt32(textBox_random_do.Text); //random_end, максимум генератора случайных чисел
            string format = "{0," + Convert.ToString(Convert.ToInt32(textBox_random_do.TextLength) * (-1) - 1) + "}";//Задает формат вывода исходных данных в файл (количество пробелов)
            double[,] Data = new double[detail, machine]; //Массив, будет хранить в себе сгенерированные числа
            //double random_step = Convert.ToDouble(textBox_step.Text); //число, кратное которому генератор должен выдать

            FileStream filestream = new FileStream("in.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); //Поток, открытый для доступа к файлу
            StreamWriter s_writer = new StreamWriter(filestream); //Поток для записи в файл

            //Запись в начало файла первых необходимых данных
            s_writer.WriteLine(machine);
            s_writer.WriteLine(detail);
            s_writer.WriteLine(random_s);
            s_writer.WriteLine(random_e);
            s_writer.WriteLine(); //Сделать отступ для визуального разграничения данных для следующих записей

            //Цикл генерации случайных чисел и одновременная запись данных в файл. В данном случае detail - число, определяющие строки, machine - число, опеределяющие столбцы
            for (int i = 0; i < detail; i++)
            {
                for(int j = 0; j < machine; j++)
                {
                    //Проверка, только для редактирования формата вывода в файл
                    if(j == machine-1)//Убрать пробелы перед началом следующей строки
                    {
                        Data[i, j] = Convert.ToDouble(random.Next(random_s, random_e + 1));
                        s_writer.Write("{0}", Data[i, j]);

                        //Для корректных отступов после конца столбца
                        s_writer.WriteLine();
                        s_writer.WriteLine();
                    }
                    else//Добавить пробелов перед началом следующего символа-значения
                    {
                        Data[i, j] = Convert.ToDouble(random.Next(random_s, random_e + 1));
                        s_writer.Write(format, Data[i, j]);
                    }
                    
                }
            }
            //Закрытие использованных потоков
            s_writer.Close();
            filestream.Close();

            MessageBox.Show("Данные успешно сгенерированы");
        }

        //Загрузить данные в ПО для дальнейшей обработки
        private void button_save_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream("in.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); //Поток, открытый для доступа к файлу
            StreamReader s_reader = new StreamReader(filestream);//Поток, чиатющий файл построчно 
            MainForm main = this.Owner as MainForm;//Установили родителя и обеспечили доступ к его методам, полям и т.д.
            string read_line="";//Переменная для считывания числа из файла
            string[] separator_string;
            char[] separator = {' '}; //Массив для разделения строки, считанной из файла

            //Считываем из файла основные данные по генератору чисел и массиву исходных данных
            main.machine = Convert.ToInt32(s_reader.ReadLine());
            main.detail = Convert.ToInt32(s_reader.ReadLine());
            main.random_s = Convert.ToInt32(s_reader.ReadLine());
            main.random_e = Convert.ToInt32(s_reader.ReadLine());
            //separator = new char[1];//Инициализация массива, по размеру равного элементам + кол-ву разделителей в тексте
            separator_string = new string[((Convert.ToString(main.random_e)).Length) + main.machine];
            read_line = s_reader.ReadLine();//Прочитать и опустить пустую строку

            main.Data = new double[main.detail, main.machine];//Инициализировали массив для хранения данных
            //Цикл сччитывания файлов и заполнение массива
            for (int i = 0; i < main.detail; i++)
            {
                for (int j = 0; j < main.machine; j++)
                {
                    read_line = s_reader.ReadLine();
                    while (read_line == " " || read_line == "")
                    {
                        read_line = s_reader.ReadLine();
                    }
                        separator_string = read_line.Split(separator);
                    for(int k = 0; k < separator_string.Length; k++)
                    {
                        if(separator_string[k] == "" || separator_string[k]== " ")
                        {
                            ;
                        }
                        else
                        {
                            main.Data[i, j] = Convert.ToDouble(separator_string[k]);
                            j++;
                        }  
                    }
                    /*while (read_line == " " || read_line == "") //Если был считан пробел
                    {
                        read_line = Convert.ToString(s_reader.Read()); //Перебираем по файлу дальше
                    }*/
                    //main.Data[i, j] = Convert.ToDouble(read_line); //Записываем в массив
                }
            }

            //Закрытие потоков
            s_reader.Close();
            filestream.Close();

            MessageBox.Show("Данные готовы к обработке");
            this.Close();
        }

        //Открыть "Блокнот" для ручного редактирования и просмотра файла с данными
        private void button_open_write_Click(object sender, EventArgs e)
        {
            //Получаем каталог, где лежит исполняемый файл и формируем строку-параметр для передачи в приложение notepad, он же блокнот
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string location_exe = Path.GetDirectoryName(location);
            string location_file = location_exe + "\\in.txt";

            Process.Start("notepad", location_file);
        }

        private void Data_redactor_Load(object sender, EventArgs e)
        {

        }
    }
}
