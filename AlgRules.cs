/*Условие:Разработка алгоритмов и программ нисходящим способом.
Задание 2.5.3: Разработать алгоритм и программу нисходящим способом, предполагая заданной матрицу А из 5 строк и 5 столбцов или одномерные массивы указанной длины.
 */

/*Condition:Development of algorithms and programs in a top-down manner.
Task 2.5.3: Develop an algorithm and a program in a top-down way, assuming a given matrix A of 5 rows and 5 columns or one-dimensional arrays of a specified length.
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_variant_CSharp_2_5_3
{
    public partial class FormAlgRules : Form
    {
        public FormAlgRules()
        {
            InitializeComponent();
        }
        private void buttonMatrDim_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;                                       //кол-во строк
            dataGridView1.ColumnCount = 5;                                    //столбцов
            dataGridView2.RowCount = 5;                                      
            dataGridView2.ColumnCount = 5;
            dataGridView3.RowCount = 1;                                       //одномерный массив С
            dataGridView3.ColumnCount = 5;
            dataGridView1.Rows[0].HeaderCell.Value = "Матрица A";
            dataGridView2.Rows[0].HeaderCell.Value = "Матрица B";
            dataGridView3.Rows[0].HeaderCell.Value = "Матрица С";
            Random rnd = new Random();
            int[,] tableArr_A = new int[5, 5];
            int[,] tableArr_B = new int[5, 5];
            int[] tableArr_C = new int[5] { 0, 0, 0, 0, 0 };                 //одномерный массив С
            bool ArrayElGreater = false;									//флаг если элемент массива в строке больше чем в др. матрице
            for (int count_row = 0; count_row < 5; count_row++)
            {
                for (int count_column = 0; count_column < 5; count_column++)                                         //заполняем значения X
                {
                    tableArr_A[count_row, count_column] = rnd.Next(-25, 25); //заполняем массив случайными значениями
                    tableArr_B[count_row, count_column] = rnd.Next(-25, 25);
                    dataGridView1.Rows[count_row].Cells[count_column].Value = tableArr_A[count_row, count_column];
                    dataGridView2.Rows[count_row].Cells[count_column].Value = tableArr_B[count_row, count_column]; 
                    if (tableArr_A[count_row, count_column] < tableArr_B[count_row, count_column])                     //Если элемент Aii меньше хоть одного текущего элемента i-ой строки матрицы
                        ArrayElGreater = true;
                }
                if (ArrayElGreater == true)                                  //если элемент массива в строке больше чем в др. матрице
                {
                    for (int k = 0; k < 5; k++) 
                    { 
                        tableArr_C[count_row] += tableArr_A[k, count_row] + tableArr_B[k, count_row];
                        dataGridView3.Rows[0].Cells[count_row].Value = tableArr_C[count_row];
                    }
                    ArrayElGreater = false;
                }
            }
        }

        private void FormAlgRules_Load(object sender, EventArgs e)
        {

        }
    }
}