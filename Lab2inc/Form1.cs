using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2inc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void work1_do_button_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(work1_x.Value);
            double y = Convert.ToDouble(work1_y.Value);
            double z = Convert.ToDouble(work1_z.Value);
            //
            double result1 = 0, result2 = 0;
            result1 = (2 * Math.Pow(Math.Cos(x - Math.PI / 6), 4)) / (0.5 + Math.Pow(Math.Sin(y), 2));
            //
            result2 = 1 + (Math.Pow(z, 2) / 3 + (Math.Pow(z, 2) / 5));
            //
            work1_result_a.Value = Convert.ToDecimal(result1);
            work1_result_b.Value = Convert.ToDecimal(result2);
        }

        private void work2_do_button_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3;
            //
            x1 = Convert.ToDouble(work2_x1.Value);
            x2 = Convert.ToDouble(work2_x2.Value);
            x3 = Convert.ToDouble(work2_x3.Value);

            y1 = Convert.ToDouble(work2_y1.Value);
            y2 = Convert.ToDouble(work2_y2.Value);
            y3 = Convert.ToDouble(work2_y3.Value);
            //
            double per,squ;
            per = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) 
                + Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2)) 
                + Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            //
            squ = Math.Abs(((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)) * 0.5);
            //
            work2_perimeter.Value = Convert.ToDecimal(per);
            work2_square.Value = Convert.ToDecimal(squ);
        }

        private void work3_do_button_Click(object sender, EventArgs e)
        {
            double[] arr;
            arr = new double[3];
            //
            arr[0] = Convert.ToDouble(work3_1.Value);
            arr[1] = Convert.ToDouble(work3_2.Value);
            arr[2] = Convert.ToDouble(work3_3.Value);
            //
            double res = -99999999;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > res) res = arr[i];
            }
            //
            double temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            //
            work3_higher.Value = Convert.ToDecimal(res);
            work3_sort.Text = "В порядке убывания: " + arr[0].ToString() + "  " 
                + arr[1].ToString() + "  " + arr[2].ToString();
        }

        private void work4_do_button_Click(object sender, EventArgs e)
        {
            string result;
            switch (Convert.ToInt16(work4_id.Value))
            {
                case 1: result = "Понедельник день бездельник"; break;
                case 2: result = "Вторник повторник"; break;
                case 3: result = "Среда тамада"; break;
                case 4: result = "Четверг все заботы я отверг"; break;
                case 5: result = "Пятница пьяница"; break;
                case 6: result = "Суббота не работа"; break;
                case 7: result = "Воскресенье день веселья"; break;
                default:
                    result = "Неверный номер дня недели"; break;
            }
            //
            work4_day.Text = result;
            if (Convert.ToInt16(work4_id.Value) >= 6) work4_holiday.Checked = true;
            else work4_holiday.Checked = false;
        }
    }
}
