using System.Diagnostics;
using System.Windows.Forms;

namespace labSystemProgramming
{
    public partial class Form1 : Form
    {
        private int[] randomArray;
        public Form1()
        {
            InitializeComponent();

        }
        private void btnSnakeSort_Click(object sender, EventArgs e)
        {

            int[] zigZagSortedArray = (int[])randomArray.Clone();

            int zigZagSortIterations = 0;
            double zigZagSortTime = MeasureTime(() => ZigZagSort(zigZagSortedArray, out zigZagSortIterations));
            txtZigZagSort.Text = $"(Итерации: {zigZagSortIterations}, Время: {zigZagSortTime} мс):\r\n" + string.Join(" ", zigZagSortedArray);
            txtZigZagSortSteps.Text = "Промежуточные этапы:\r\n";
            int[] tempArray = (int[])zigZagSortedArray.Clone();
            ZigZagSort(tempArray, out zigZagSortIterations, logSteps: true, logTextBox: txtZigZagSortSteps);

        }

        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            int[] radixSortedArray = (int[])randomArray.Clone();
            int radixSortIterations = 0;
            double radixSortTime = MeasureTime(() => RadixSort(radixSortedArray, out radixSortIterations));
            txtRadixSort.Text = $"(Итерации: {radixSortIterations} , Время: {radixSortTime} мс):\r\n" + string.Join(" ", radixSortedArray);
            txtRadixSortSteps.Text = "Промежуточные этапы:\r\n";
            int[] tempArray = (int[])radixSortedArray.Clone();
            RadixSort(tempArray, out radixSortIterations, logSteps: true, logTextBox: txtRadixSortSteps);

        }

        private void btnPancakeSort_Click(object sender, EventArgs e)
        {

            int[] pancakeSortedArray = (int[])randomArray.Clone();
            int pancakeSortIterations = 0;
            double pancakeSortTime = MeasureTime(() => PancakeSort(pancakeSortedArray, out pancakeSortIterations));
            txtPancakeSort.Text = $"(Итерации: {pancakeSortIterations}, Время: {pancakeSortTime} мс):\r\n" + string.Join(" ", pancakeSortedArray);
            txtPancakeSortSteps.Text = "Промежуточные этапы:\r\n";
            int[] tempArray = (int[])pancakeSortedArray.Clone();
            PancakeSort(tempArray, out pancakeSortIterations, logSteps: true, logTextBox: txtPancakeSortSteps);

        }

        static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }

        // Вывод массива на консоль
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        // Сортировка змейкой (Cocktail Sort)


        // Поразрядная сортировка (Radix Sort)
        public static int GetMaxVal(int[] array, int size)
        {
            var maxVal = array[0];

            for (int i = 1; i < size; i++)
                if (array[i] > maxVal)
                    maxVal = array[i];

            return maxVal;
        }
        private void ZigZagSort(int[] array, out int iterations, bool logSteps = false, TextBox logTextBox = null)
        {
            iterations = 0;
            int n = array.Length;
            bool flag = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (flag)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap the elements if they are in the wrong order
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        iterations++;
                    }

                }
                else
                {
                    if (array[i] < array[i + 1])
                    {
                        // Swap the elements if they are in the wrong order
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        iterations++;
                    }

                }
                if (logSteps)
                    logTextBox.AppendText(string.Join(" ", array) + "\r\n");
                flag = !flag;
            }
        }

        public static int[] RadixSort(int[] array, out int iterations, bool logSteps = false, TextBox logTextBox = null)
        {
            var maxVal = GetMaxVal(array, array.Length);
            int digitCount = (int)Math.Floor(Math.Log10(maxVal) + 1); // Number of digits in maxVal
            iterations = 0;

            for (int digit = 1; digit <= maxVal; digit *= 10)
            {
                CountingSort(array, array.Length, digit, out iterations);
                if (logSteps)
                    logTextBox.AppendText(string.Join(" ", array) + "\r\n");
                iterations++;
            }

            return array;
        }

        public static void CountingSort(int[] array, int size, int exponent, out int iterations)
        {
            var outputArr = new int[size];
            iterations = 0;
            var occurrences = new int[10];

            for (int i = 0; i < 10; i++)
                occurrences[i] = 0;
            iterations++;

            for (int i = 0; i < size; i++)
                occurrences[(array[i] / exponent) % 10]++;
            iterations++;
            for (int i = 1; i < 10; i++)
                occurrences[i] += occurrences[i - 1];
            iterations++;
            for (int i = size - 1; i >= 0; i--)
            {
                outputArr[occurrences[(array[i] / exponent) % 10] - 1] = array[i];
                occurrences[(array[i] / exponent) % 10]--;
                iterations++;
            }

            for (int i = 0; i < size; i++)
                array[i] = outputArr[i];
            iterations++;
        }
        static void PancakeSort(int[] array, out int iterations, bool logSteps = false, TextBox logTextBox = null)
        {
            iterations = 0;
            for (int size = array.Length; size > 1; size--)
            {
                int maxIndex = FindMaxIndex(array, size);
                if (maxIndex != size - 1)
                {
                    if (maxIndex != 0)
                    {
                        FlipArray(array, maxIndex);
                        iterations++;
                        if (logSteps)
                            logTextBox.AppendText(string.Join(" ", array) + "\r\n");
                    }
                    FlipArray(array, size - 1);
                    iterations++;
                    if (logSteps)
                        logTextBox.AppendText(string.Join(" ", array) + "\r\n");
                }
            }
        }

        static int FindMaxIndex(int[] array, int size)
        {
            int maxIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void FlipArray(int[] array, int end)
        {
            int start = 0;
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }

        // Функция для измерения времени выполнения
        static double MeasureTime(Action action)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            action();
            stopwatch.Stop();

            return stopwatch.Elapsed.TotalMilliseconds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void radixInfoBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pancakeInfoBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lengthArr = inputLengthArr.Text;
            int length = int.Parse(lengthArr);
            randomArray = GenerateRandomArray(length, 1, 100);
            generateArrText.Text = string.Join(" ", randomArray);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}