using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Diagnostics;


namespace Project
{
    public partial class MainForm : Form
    {
        int eventblock = 0; //Переменная, контролирующая отмену выполнения обработки событий

        //Эти переменные инициализируются в Data_redactor -> button_save_Click()
        public int machine = 0; //количество станков
        public int detail = 0; //количество деталей
        public int random_s = 0; //random_start, минимум генератора случайных чисел
        public int random_e = 0; //random_end, максимум генератора случайных чисел
        public double[,] Data;
        /////////////////////////////////////////////////////


        public MainForm()
        {
            InitializeComponent();
        }

        private void button_processing_Click(object sender, EventArgs e)
        {
            /*
           /* //Ответ для этого примера: 2-3, 4-6, 6-8, 9-7, 9-5, 8-3  
            int row_count = 6;
            double[] Ai = { 2, 8, 4, 9, 6, 9 };
            double[] Bi = { 3, 3, 6, 5, 8, 7 };
            

            //Блок получения данных из формы
            int row_count = datagridview_in.RowCount; //получаем количество строк в таблице
            row_count--;
            double[] Ai = new double[row_count]; //массив для хранения данных из таблицы с исходными значениями
            double[] Bi = new double[row_count]; //массив для хранения данных из таблицы с исходными значениями
            int[] number_element = new int[row_count];
            int[] number_element_sort = new int[row_count];
            for (int i = 0; i < row_count; i++) //Получили данные с таблицы
            {
                Ai[i] = Convert.ToDouble(datagridview_in.Rows[i].Cells[1].Value);
                Bi[i] = Convert.ToDouble(datagridview_in.Rows[i].Cells[2].Value);
                number_element[i] = Convert.ToInt32(datagridview_in.Rows[i].Cells[0].Value);
            }


            double[,] C = new double[row_count, 2];
            

            AlgorithmDjonson(Ai,Bi,C,number_element,number_element_sort);



            for (int i = 0; i < row_count; i++)
            {
                datagridview_in.Rows[i].Cells[0].Value = number_element_sort[i];
                datagridview_in.Rows[i].Cells[1].Value = C[i,0];
                datagridview_in.Rows[i].Cells[2].Value = C[i,1];
            }

            for (int i = 0; i < row_count; i++) //Получили оптимальные данные с таблицы
            {
                Ai[i] = Convert.ToDouble(datagridview_in.Rows[i].Cells[1].Value);
                Bi[i] = Convert.ToDouble(datagridview_in.Rows[i].Cells[2].Value);
            }

            string name_series_a;
            string name_series_b;
            int counter_point = 0;
            int counter_point_2 = 0;
            double all_time = 0;
            double last_time = 0;
            double last_b_2 = 0;

            double start_x = 0;
            double start_b = 0;
            double last_b = 0;
            double new_b = 0;

            chart1.Titles[0].Text = "Диаграма Ганта для оптимальных значений";
            chart1.Series.Clear();

            for (int i = 0; i < row_count; i++)
            {
                name_series_a = "a" + counter_point;
                name_series_b = "b" + counter_point;
                chart1.Series.Add(name_series_a);
                chart1.Series.FindByName(name_series_a).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series.FindByName(name_series_a).Color = Color.Red;
                chart1.Series.FindByName(name_series_a).BorderWidth = 4;

                chart1.Series.FindByName(name_series_a).Points.AddXY(start_x, 1);
                chart1.Series.FindByName(name_series_a).Points.AddXY(Ai[i] + start_x, 1);

                chart1.Series.FindByName(name_series_a).ChartArea = "ChartArea1";
                chart1.Series.FindByName(name_series_a).Points[0].Label = "a" + (i + 1) + " = " + Ai[i];
                chart1.Series.FindByName(name_series_a).Points[1].Label = "a" + (i + 1);
                chart1.Series.FindByName(name_series_a).Points[0].MarkerBorderColor = Color.Black;
                chart1.Series.FindByName(name_series_a).Points[0].MarkerBorderWidth = 1;
                chart1.Series.FindByName(name_series_a).Points[0].MarkerColor = Color.Black;
                chart1.Series.FindByName(name_series_a).Points[0].MarkerSize = 5;
                chart1.Series.FindByName(name_series_a).Points[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chart1.Series.FindByName(name_series_a).Points[1].MarkerBorderColor = Color.Black;
                chart1.Series.FindByName(name_series_a).Points[1].MarkerBorderWidth = 1;
                chart1.Series.FindByName(name_series_a).Points[1].MarkerColor = Color.Black;
                chart1.Series.FindByName(name_series_a).Points[1].MarkerSize = 5;
                chart1.Series.FindByName(name_series_a).Points[1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;

                start_x += Ai[i];
                last_b = start_b;
                start_b = start_x;

                chart1.Series.Add(name_series_b);
                chart1.Series.FindByName(name_series_b).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series.FindByName(name_series_b).IsValueShownAsLabel = false;
                chart1.Series.FindByName(name_series_b).Color = Color.Green;
                chart1.Series.FindByName(name_series_b).BorderWidth = 4;

                if (start_b >= new_b)
                {
                    chart1.Series.FindByName(name_series_b).Points.AddXY(start_b, 2);
                    chart1.Series.FindByName(name_series_b).Points.AddXY(start_b + Bi[i], 2);
                    new_b = start_b + Bi[i];
                }
                else
                {
                    chart1.Series.FindByName(name_series_b).Points.AddXY(new_b, 2);
                    chart1.Series.FindByName(name_series_b).Points.AddXY(new_b + Bi[i], 2);
                    last_b = new_b + Bi[i];
                    last_b_2 = last_b;
                }


                chart1.Series.FindByName(name_series_b).ChartArea = "ChartArea1";
                chart1.Series.FindByName(name_series_b).Points[0].Label = "b" + (i + 1) + " = " + Bi[i];
                chart1.Series.FindByName(name_series_b).Points[1].Label = "b" + (i + 1);
                chart1.Series.FindByName(name_series_b).Points[0].MarkerBorderColor = Color.Black;
                chart1.Series.FindByName(name_series_b).Points[0].MarkerBorderWidth = 1;
                chart1.Series.FindByName(name_series_b).Points[0].MarkerColor = Color.Black;
                chart1.Series.FindByName(name_series_b).Points[0].MarkerSize = 5;
                chart1.Series.FindByName(name_series_b).Points[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chart1.Series.FindByName(name_series_b).Points[1].MarkerBorderColor = Color.Black;
                chart1.Series.FindByName(name_series_b).Points[1].MarkerBorderWidth = 1;
                chart1.Series.FindByName(name_series_b).Points[1].MarkerColor = Color.Black;
                chart1.Series.FindByName(name_series_b).Points[1].MarkerSize = 5;
                chart1.Series.FindByName(name_series_b).Points[1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                counter_point++;
                all_time = start_b;



            }

            last_time = 0;
            counter_point_2 = chart1.Series.Count;
            counter_point_2--;
            for (int i = counter_point_2; i > 1;)
            {
                last_time += chart1.Series[i].Points[0].XValue - chart1.Series[i - 2].Points[1].XValue;
                i -= 2;
                if (i == 1)
                {
                    last_time += chart1.Series[i].Points[0].XValue - chart1.Series[0].Points[0].XValue;
                }
            }

            all_time += Bi[counter_point - 1];
            label3.Visible = true;
            label3.Text = Convert.ToString(all_time);

            label4.Visible = true;
            label4.Text = Convert.ToString(last_time);

            eventblock = 1;
            */

        }

        private void AlgorithmDjonson(double[] ai, double[] bi, double[,] c, int[] n, int[] n2)
        {
            double min_ai = ai[0];
            double min_bi = bi[0];
            double minimum;
            int i = 0;
            int index_ai_minimum = 0;
            int index_bi_minimum = 0;
            int first_index_C = 0;
            int last_index_C = ai.Length - 1;
            int ai_is_minus = 0;
            int bi_is_minus = 0;
            int index_number_ai = 0;
            int index_number_bi = 0;
            int number = 0;

            while (ai_is_minus == 0 && bi_is_minus == 0)
            {
                for(i = 0; i < ai.Length; i++) //Выбор еще рабочего значения ai
                {
                    if(ai[i] != -99999)
                    {
                        min_ai = ai[i];
                        index_ai_minimum = i;
                        index_number_ai = i;
                        break;
                    }
                }

                for (i = 0; i < bi.Length; i++)//Выбор любого еще рабочего значения bi
                {
                    if (bi[i] != -99999)
                    {
                        min_bi = bi[i];
                        index_bi_minimum = i;
                        index_number_bi = i;
                        break;
                    }
                }

                for (i = 0; i < ai.Length; i++) //Поиск минимального ai
                {
                    if (min_ai > ai[i] && ai[i] != -99999)
                    {
                        min_ai = ai[i];
                        index_number_ai = i;
                        index_ai_minimum = i;
                    }
                }

                for (i = 0; i < bi.Length; i++) //Поиск минимального bi
                {
                    if (min_bi > bi[i] && bi[i] != -99999)
                    {
                        min_bi = bi[i];
                        index_bi_minimum = i;
                        index_number_bi = i;
                    }
                }

                if (min_ai <= min_bi) //Сравнение, какое из них меньше
                {
                    minimum = min_ai;
                    c[first_index_C, 0] = minimum;
                    c[first_index_C, 1] = bi[index_ai_minimum];
                    ai[index_ai_minimum] = -99999;
                    bi[index_ai_minimum] = -99999;
                    n2[first_index_C] = n[index_ai_minimum];
                    first_index_C++;
                }
                else
                {
                    minimum = min_bi;
                    c[last_index_C, 0] = ai[index_bi_minimum];
                    c[last_index_C, 1] = minimum;
                    ai[index_bi_minimum] = -99999;
                    bi[index_bi_minimum] = -99999;
                    n2[last_index_C] = n[index_bi_minimum];
                    last_index_C--;
                }

                for(i = 0; i < ai.Length; i++)
                {
                    if (ai[i] == -99999)
                        ai_is_minus++;
                }
                if (ai_is_minus != ai.Length)
                    ai_is_minus = 0;

                for (i = 0; i < bi.Length; i++)
                {
                    if (bi[i] == -99999)
                        bi_is_minus++;
                }
                if (bi_is_minus != bi.Length)
                    bi_is_minus = 0;
            }
        }

        //Построение диаграммы Ганта для начальных значений
        private void button_enter_in_Click(object sender, EventArgs e)
        {
            int[] numeric = new int[detail];
            for (int i = 0; i < detail; i++)
            {
                numeric[i] = i + 1;
            }
            chart1.Series.Clear();//Отчистить существующие серии на графике
            
            PaintGant(Data, numeric);//Отрисовать диаграмму
        }

        private void datagridview_in_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            eventblock = 0;
        }

        private void datagridview_in_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (eventblock == 0)
            {
                int row_count = datagridview_in.RowCount; //получаем количество строк в таблице
                row_count--;
                for (int i = 0; i < row_count; i++) //Получили данные с таблицы
                {
                    datagridview_in.Rows[i].Cells[0].Value = i + 1;
                }
            }*/
        }

        private void datagridview_in_MouseLeave(object sender, EventArgs e)
        {/*
            if (eventblock == 0)
            {
                int row_count = datagridview_in.RowCount; //получаем количество строк в таблице
                row_count--;
                for (int i = 0; i < row_count; i++) //Получили данные с таблицы
                {
                    datagridview_in.Rows[i].Cells[0].Value = i + 1;
                }
            }*/
        }

        private void datagridview_in_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            eventblock = 0;
        }

        private void datagridview_in_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            eventblock = 0;
        }

        private void button_form_redactor_Click(object sender, EventArgs e)
        {
            //Вызов формы для редактирования исходных данных
            Data_redactor data_redactor = new Data_redactor();
            data_redactor.Owner = this; //Назначаем владельца второй формы, т.е. первую форму владельцем второй.
            data_redactor.ShowDialog();
            button_enter_in.Enabled = true;
            button_djons_1.Enabled = true;
            button_djons_2.Enabled = true;
            button_djons_3.Enabled = true;
            button_djons_4.Enabled = true;

            button_enter_in.BackColor = Color.DeepSkyBlue;
            button_djons_1.BackColor = Color.DeepSkyBlue;
            button_djons_2.BackColor = Color.DeepSkyBlue;
            button_djons_3.BackColor = Color.DeepSkyBlue;
            button_djons_4.BackColor = Color.DeepSkyBlue;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Потсроение Диаграмммы Ганта
        private void PaintGant(double[,] D, int[] numeric) //D - от Data, массив с данными.
        {
            Random rand = new Random();//Для Генерации RGB цвета
            string[] series = new string[machine*detail];//Переменная для хранения имен серий для отрисовки
            int series_number = 0; //Переменная для хранения номера серии для отрисоввки
            Color[] color = new Color[machine]; //Массив, хранящий цвета для серий в зависимости количество этих самых серий

            int[,] positon = new int[series.Length, 2];//Массив, который хранит стартовую и конечную точку отрисовки серий
            int x = 0;//Координаты Х для отрисовки точки
            int y = 0;//Координаты Y для отрисовки точки
            int c_trans_mod = 0; //Модификатор, переводящий вычисления координат к другому алгоритму

            //Цикл зануления координаты Х и задания координаты Y (1,2,3,4...n)
            int z = 1;//Переменная для задания координат Y в сериях
            for(int i = 0; i < series.Length; i++)
            {
                if (z == machine+1)
                {
                    z = 1;
                }
                for (int j = 0; j < 1; j++)
                {
                    positon[i, j] = 0;
                    positon[i, j + 1] = z;
                    z++;
                }
            }

            //Формируем копию массива с данными для того, чтобы они не потерялись
            double[,] Data2 = new double[detail,machine]; //Должна быть точной копией массива Data
            Array.Copy(D,Data2,Data.Length);//Копируем массив Data в массив Data2 и работаем с ним

            double lost_time = 0;//Суммарное время простоя всех станков

            CreateSeries(series);//Сформировали имена серий
            chart1.Series.Clear();

            //Цикл отрисовки серий
            for(int i = 0; i < detail; i++) //Пока не закочаться детали (или строки)
            {
                //Цикл, в котором серии будут рисоваться по строчно в зависимости от количества станков
                for (int j = 0; j < machine; j++)//Пока не закончаться столбцы
                {
                    //Блок отрисовки серии
                    chart1.Series.Add(series[series_number]);//Добавили серию в график
                    chart1.Series.FindByName(series[series_number]).ChartArea = "ChartArea1";//Добавили область рисования
                    chart1.Series.FindByName(series[series_number]).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;//Установили тип Line

                    if (color[j].Name == "0" || (color[j].G == 0 && color[j].B == 0 && color[j].R == 0)) //Если цвет серии не хранится
                    {
                        color[j] = Color.FromArgb(255, rand.Next(1, 256), rand.Next(1, 256), rand.Next(1, 256)); //Задаем цвет случайным числом и храним его в массиве
                        chart1.Series.FindByName(series[series_number]).Color = color[j];//Присваиваем серии цвет
                    }
                    else
                    {
                        chart1.Series.FindByName(series[series_number]).Color = color[j];//Присваиваем серии цвает
                    }
                    //chart1.Series.FindByName(series[series_number]).Color = Color.Red;
                    chart1.Series.FindByName(series[series_number]).BorderWidth = 5;
                    ///////////////////////////////////////////////////////////////////

                    //Блок отрисовки и добавления точек в серии
                    if (series_number == 0) //Если отрисовывается самая первая серия
                    {
                        x = positon[series_number, 0]; //Начальная X позиция отрисовки точки
                        y = positon[series_number, 1]; //Начальная Y позиция отрисовки точки
                    }
                    else if (c_trans_mod == 0) //Если выполняется самый первый цикл отрисовки серий
                    {
                        positon[series_number, 0] = positon[series_number - 1, 0];
                        x = positon[series_number, 0]; //Начальная X позиция отрисовки точки
                        y = positon[series_number, 1]; //Начальная Y позиция отрисовки точки
                        
                    }
                    else if (c_trans_mod == 1) //Если выполняются последующие отрисовки
                    {
                        //Если позиция предыдущей серии меньше позиции серии на ранг выше и это не самая первая серия (линия серий)
                        if (positon[series_number - machine, 0] < positon[series_number - 1, 0] && positon[series_number, 1] != 1)
                        {
                            positon[series_number, 0] = positon[series_number - 1, 0];
                            x = positon[series_number, 0]; //Начальная X позиция отрисовки точки
                            y = positon[series_number, 1]; //Начальная Y позиция отрисовки точки
                        }
                        else
                        {
                            positon[series_number, 0] = positon[series_number - machine, 0];
                            x = positon[series_number, 0]; //Начальная X позиция отрисовки точки
                            y = positon[series_number, 1]; //Начальная Y позиция отрисовки точки
                        }
                    }

                    chart1.Series.FindByName(series[series_number]).Points.AddXY(x, y);//Конечная точка линии
                    positon[series_number, 0] += Convert.ToInt32(Data2[i, j]); //Установили новую конечную точку линии
                    x = positon[series_number, 0];//Записали её в переменную
                    chart1.Series.FindByName(series[series_number]).Points.AddXY(x, y);//Конечная точка линии

                    for(int g = 0; g < 2; g++)
                    {
                        //chart1.Series.FindByName(series[series_number]).Points[0].Label = "" + (i+1);
                        chart1.Series.FindByName(series[series_number]).Points[g].MarkerBorderColor = Color.Black;
                        chart1.Series.FindByName(series[series_number]).Points[g].MarkerBorderWidth = 1;
                        chart1.Series.FindByName(series[series_number]).Points[g].MarkerColor = Color.Black;
                        chart1.Series.FindByName(series[series_number]).Points[g].MarkerSize = 5;
                        chart1.Series.FindByName(series[series_number]).Points[g].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                    }

                    ///////////////////////////////////////////
                    series_number++;//Увеличели индекс имен серий для следующей серии, которую нужно будет отрисовать

                }
                if(c_trans_mod == 0) //Если это первый цикл отрисовки серий
                {
                    c_trans_mod = 1;
                }
            }

            //Изменение координат
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = machine + 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = positon[machine * detail - 1, 0] + 5;

            //Вывод суммарного времени обработки деталей
            label3.Visible = true;
            label3.Text = Convert.ToString(positon[machine * detail - 1, 0]);

            c_trans_mod = 0; //Зануляем модификатор
            series_number = 0;//Заунляем серии
            for (int i = 0; i < detail; i++) //Двигаемся по деталям
            {
                if(c_trans_mod == 0) //Если это первые серии
                {
                    for(int j = 0; j < machine; j++)
                    {
                        lost_time += positon[j,0] - Data2[i,j];
                        series_number++;
                    }
                }
                if(c_trans_mod == 1)
                {
                    for (int j = 0; j < machine; j++)
                    {
                        lost_time += positon[series_number, 0] - Data[i,j] - positon[series_number-machine,0];
                        series_number++;
                    }
                }


                c_trans_mod = 1;
            }

            label4.Visible = true;
            label4.Text = Convert.ToString(lost_time);

            series_number = 0;
            listView1.Items.Clear();
            listView1.Groups[0].Header = "Список элементов";
            for (int i = 0; i < detail; i++)
            {
                for(int j = 0; j < machine; j++)
                {
                    chart1.Series.FindByName(series[series_number]).Points[0].Label = Convert.ToString(numeric[i]);
                    series_number++;
                }
                listView1.Items.Add(Convert.ToString(numeric[i]));
                listView1.Items[i].Group = listView1.Groups[0];
            }
            
            
        }

        //Создание серий для отрисовки диаграммы
        private void CreateSeries(string[] s) //s - series, или массив наименований серий
        {
            for(int i = 0; i < s.Length; i++)//Цикл формирования имен серий
            {
                s[i] = "series_" + i;
            }
        }

        //Обобщение Джонсона 1. минимальное время обработки на первом станке в порядке возрастания этого времени.
        private void button_djons_1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();// Переменная для отслеживания работы алгоритмов
            sw.Start();
            double[,] D = new double[detail, machine];//Данные, работаем с копией
            double[,] D1 = new double[detail, machine]; //Массив для хранения оптимизированных данных
            int[] numeric = new int[detail];//Массив хранящий нумерацию элементов
            int[] numeric_opt = new int[detail];//Массив хранящий нумерацию элементов уже оптимизированных
            int min = 0; //Переменная для поиска минимального значения

            int new_index = 0;//Новый вычисляемый индекс при поиске минимального значения
            int index_first = 0; //Первый индекс в массиве для хранения оптимальных данных. В ходе будет меняться

            Array.Copy(Data, D, Data.Length);

            //Создаем нумерацию исходных элементов
            for(int i = 0; i < detail; i++)
            {
                numeric[i] = i + 1;
            }

            min = Convert.ToInt32(D[0,0]);
            int x = 0;
            while(index_first != detail) //Пока не будут размещены все детали
            {
                while (min == -9999999)
                {
                    min = Convert.ToInt32(D[x, 0]);
                    new_index = x;
                    x++;
                }
                for (int i = 0; i < detail; i++) //Двигаемся по деталям
                {
                    //Нашли минимальную деталь
                    if (min > D[i, 0] && D[i,0] != -9999999)
                    {
                        min = Convert.ToInt32(D[i, 0]);
                        new_index = i;
                    } 
                }

                for (int j = 0; j < machine; j++)
                {
                    D1[index_first, j] = D[new_index, j];
                    D[new_index, j] = -9999999;
                }

                numeric_opt[index_first] = numeric[new_index];
                index_first++;
                min = -9999999;
                x = 0;
            }

           
            PaintGant(D1, numeric_opt);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label6.Visible = true;
            label6.Text = (elapsed);
        }

        //Обобщение Джонсона 2. запускаются сначала детали, требующие максимальное время обработки на последнем станке в порядке убывания этого времени
        //Код частично скопирован из Обобщения Джонсона 1, но передал для поиска максимального значения на последнем станке. Возможны косяки в комментариях
        private void button_djons_2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();// Переменная для отслеживания работы алгоритмов
            sw.Start();
            double[,] D = new double[detail, machine];//Данные, работаем с копией
            double[,] D1 = new double[detail, machine]; //Массив для хранения оптимизированных данных
            int[] numeric = new int[detail];//Массив хранящий нумерацию элементов
            int[] numeric_opt = new int[detail];//Массив хранящий нумерацию элементов уже оптимизированных
            int max = 0; //Переменная для поиска минимального значения

            int new_index = 0;//Новый вычисляемый индекс при поиске минимального значения
            int index_first = 0; //Первый индекс в массиве для хранения оптимальных данных. В ходе будет меняться

            Array.Copy(Data, D, Data.Length);

            //Создаем нумерацию исходных элементов
            for (int i = 0; i < detail; i++)
            {
                numeric[i] = i + 1;
            }

            max = Convert.ToInt32(D[0, 0]);
            int x = 0;
            while (index_first != detail) //Пока не будут размещены все детали
            {
                while (max == -9999999)
                {
                    max = Convert.ToInt32(D[x, machine-1]);
                    new_index = x;
                    x++;
                }
                for (int i = 0; i < detail; i++) //Двигаемся по деталям
                {
                    //Нашли минимальную деталь
                    if (max < D[i, machine - 1] && D[i, machine - 1] != -9999999)
                    {
                        max = Convert.ToInt32(D[i, machine - 1]);
                        new_index = i;
                    }
                }

                for (int j = 0; j < machine; j++)
                {
                    D1[index_first, j] = D[new_index, j];
                    D[new_index, j] = -9999999;
                }

                numeric_opt[index_first] = numeric[new_index];
                index_first++;
                max = -9999999;
                x = 0;
            }

            
            PaintGant(D1, numeric_opt);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label6.Visible = true;
            label6.Text = (elapsed);
        }

        /*Обобщение Джонсона 3. В обработку запускаются сначала детали, у которых ―узкое
        место‖ находится дальше от начала процесса обработки(―узким местом‖ для
        данной детали называется станок, на котором обработка этой деталей
        занимает наибольшее время).*/
        private void button_djons_3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();// Переменная для отслеживания работы алгоритмов
            sw.Start();
            double[,] D = new double[detail, machine];//Данные, работаем с копией
            double[,] D1 = new double[detail, machine]; //Массив для хранения оптимизированных данных
            int[] numeric = new int[detail];//Массив хранящий нумерацию элементов
            int[] numeric_opt = new int[detail];//Массив хранящий нумерацию элементов уже оптимизированных
            int max = 0; //Переменная для поиска минимального значения

            int new_index = 0;//Новый вычисляемый индекс при поиске минимального значения
            int index_first = detail - 1; //Первый индекс в массиве для хранения оптимальных данных. В ходе будет меняться

            Array.Copy(Data, D, Data.Length);

            //Создаем нумерацию исходных элементов
            for (int i = 0; i < detail; i++)
            {
                numeric[i] = i + 1;
            }

            max = Convert.ToInt32(D[0, 0]);
            int x = 0;
            while (index_first >= 0) //Пока не будут размещены все детали
            {
                while (max == -9999999)
                {
                    for(int i = 0; i < detail; i++)
                    {
                        for (int j = 0; j < machine; j++)
                        {
                            if(max != -9999999)
                            {
                                break;
                            }
                            else
                            {
                                max = Convert.ToInt32(D[i, j]);
                                new_index = i;
                                x++;
                            }
                        }
                    }
                    
                }

                for (int i = 0; i < detail; i++)
                {
                    for (int j = 0; j < machine; j++)
                    {
                        if (max < D[i,j] && D[i,j] != -9999999)
                        {
                            max = Convert.ToInt32(D[i, j]);
                            new_index = i;
                        }
                    }
                }

                /*for (int i = 0; i < detail; i++) //Двигаемся по деталям
                {
                    //Нашли минимальную деталь
                    if (max < D[i, machine - 1] && D[i, machine - 1] != -9999999)
                    {
                        max = Convert.ToInt32(D[i, machine - 1]);
                        new_index = i;
                    }
                }*/

                for (int j = 0; j < machine; j++)
                {
                    D1[index_first, j] = D[new_index, j];
                    D[new_index, j] = -9999999;
                }

                numeric_opt[index_first] = numeric[new_index];
                index_first--;
                max = -9999999;
                x = 0;
            }

            
            PaintGant(D1, numeric_opt);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label6.Visible = true;
            label6.Text = (elapsed);
        }

        /*Обрабатываются вначале детали, у которых суммарное время
        обработки на всех станках максимальное в порядке убывания этого времени.*/
        private void button_djons_4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();// Переменная для отслеживания работы алгоритмов
            sw.Start();
            double[,] D = new double[detail, machine];//Данные, работаем с копией
            double[,] D1 = new double[detail, machine]; //Массив для хранения оптимизированных данных
            double[,] D_S = new double[1, machine];
            int[] numeric = new int[detail];//Массив хранящий нумерацию элементов
            int[] numeric_opt = new int[detail];//Массив хранящий нумерацию элементов уже оптимизированных
            int max = 0; //Переменная для поиска минимального значения

            int new_index = 0;//Новый вычисляемый индекс при поиске минимального значения
            int index_first = detail - 1; //Первый индекс в массиве для хранения оптимальных данных. В ходе будет меняться
            int sort_element = 0;

            int[] sum = new int[detail];//Массив для хранения сумм
            int[] sort_sum = new int[detail];//Массив для хранения сортированных сумм

            Array.Copy(Data, D, Data.Length);

            for (int i = 0; i < detail; i++)
            {
                for (int j = 0; j < machine; j++)
                {
                    sum[i] = 0;
                }
            }


            //Создаем нумерацию исходных элементов
            for (int i = 0; i < detail; i++)
            {
                numeric[i] = i + 1;
            }

            for (int i = 0; i < detail; i++)
            {
                for (int j = 0; j < machine; j++)
                {
                    sum[i] += Convert.ToInt32(D[i, j]);
                }
            }

            int x = 0;
            max = sum[0];
            index_first = 0;
            while (index_first != detail) //Пока не будут размещены все детали
            {
                while (max == -9999999)
                {
                    max = Convert.ToInt32(sum[x]);
                    new_index = x;
                    x++;
                }
                for (int i = 0; i < detail; i++) //Двигаемся по деталям
                {
                    //Нашли максимальную сумму
                    if (max < sum[i] && sum[i] != -9999999)
                    {
                        max = Convert.ToInt32(sum[i]);
                        new_index = i;
                    }
                }

                
                    sort_sum[index_first] = sum[new_index];
                    sum[new_index] = -9999999;
                    numeric_opt[index_first] = numeric[new_index];
                    max = -9999999;
                    index_first++;
                    x = 0;
            }
            
            for (int i = 0; i < detail; i++)
            {
                for (int j = 0; j < machine; j++)
                {
                    D1[i,j] = D[numeric_opt[i]-1,j];
                }
            }

            
            PaintGant(D1, numeric_opt);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label6.Visible = true;
            label6.Text = (elapsed);
        }
    }
}
