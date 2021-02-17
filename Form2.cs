using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game2048
{
    public partial class Form2 : Form
    {
        public int[,] map = new int[4, 4]; // Поле 4 на 4
        public Label[,] labels = new Label[4, 4]; //  Веса плиток
        public PictureBox[,] pics = new PictureBox[4, 4]; // picture box в качестве ячеек (плиток)
        /// <summary>
        /// Очки
        /// </summary>
        private int score = 0;
        /// <summary>
        /// Имя игрока, к которому после завершения игры будут добавлены игровые очки
        /// </summary>
        private string TempName = "";
        /// <summary>
        /// Переменная, которая указывает под каким номером сейчас активна учетная запись
        /// </summary>
        private int I = 1;
        Form1 _form1;
        public int PlayNow = 0; // Индекс игрока, который сейчас играет
        public Form2(int i, Form1 form1)
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(_keyboardEvent); // Обработчик нажатия клавиши
            map[0, 0] = 1;
            map[0, 1] = 1;
            _form1 = form1;
            I = i; // Переменная, которая указывает под каким номером сейчас активна учетная запись
            createMap();
            createPics();
            generateNewPic();
        }
        /// <summary>
        ///  Метод, который при инициализации создает поле 4 на 4
        /// </summary>
        private void createMap()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(12 + 56 * j, 73 + 56 * i); // Для перемещения ячейки
                    pic.Size = new Size(50, 50);
                    pic.BackColor = Color.Gray;
                    this.Controls.Add(pic);
                }
            }
        }   
        /// <summary>
        /// Метод, который генерирует следующие плитки
        /// </summary>
        private void generateNewPic()
        {
            Random rnd = new Random(); // Для случайного места появления следующей плитки
            int a = rnd.Next(0, 3);
            int b = rnd.Next(0, 3);           
            while (pics[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }
            map[a, b] = 1;
            pics[a, b] = new PictureBox();
            labels[a, b] = new Label();
            // Задаем параметры, стиль и тд для плитки
            labels[a, b].Text = "2";
            labels[a, b].Size = new Size(50, 50);
            labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
            labels[a, b].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[a, b].Controls.Add(labels[a, b]);
            pics[a, b].Location = new Point(12 + b * 56, 73 + 56 * a);
            pics[a, b].Size = new Size(50, 50);
            pics[a, b].BackColor = Color.Yellow;
            this.Controls.Add(pics[a, b]);
            pics[a, b].BringToFront();
        }
        /// <summary>
        /// Метод, который создает плитки на игровом поле
        /// </summary>
        private void createPics()
        {
            pics[0, 0] = new PictureBox();
            labels[0, 0] = new Label();
            // Задаем параметры, стиль и тд для плитки
            labels[0, 0].Text = "2";
            labels[0, 0].Size = new Size(50, 50);
            labels[0, 0].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 0].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[0, 0].Controls.Add(labels[0, 0]);
            pics[0, 0].Location = new Point(12, 73);
            pics[0, 0].Size = new Size(50, 50);
            pics[0, 0].BackColor = Color.Yellow;
            this.Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();
            // Задаем параметры, стиль и тд для плитки
            pics[0, 1] = new PictureBox();
            labels[0, 1] = new Label();
            labels[0, 1].Text = "2";
            labels[0, 1].Size = new Size(50, 50);
            labels[0, 1].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 1].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[0, 1].Controls.Add(labels[0, 1]);
            pics[0, 1].Location = new Point(68, 73);
            pics[0, 1].Size = new Size(50, 50);
            pics[0, 1].BackColor = Color.Yellow;
            this.Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();
        }
        /// <summary>
        /// Устанавливаем цвета на каждую плитку с разным значением
        /// </summary>
        /// <param name="sum">Общая сумма плитки</param>
        private void changeColor(int sum, int k, int j)
        {
            if (sum % 1024 == 0) pics[k, j].BackColor = Color.Pink;
            else if (sum % 512 == 0) pics[k, j].BackColor = Color.Red;
            else if (sum % 256 == 0) pics[k, j].BackColor = Color.DarkViolet;
            else if (sum % 128 == 0) pics[k, j].BackColor = Color.Blue;
            else if (sum % 64 == 0) pics[k, j].BackColor = Color.Brown;
            else if (sum % 32 == 0) pics[k, j].BackColor = Color.Coral;
            else if (sum % 16 == 0) pics[k, j].BackColor = Color.Cyan;
            else if (sum % 8 == 0) pics[k, j].BackColor = Color.Maroon;
            else pics[k, j].BackColor = Color.Green;
        }
        /// <summary>
        /// Метод, которые проверяет нажатую клавишу
        /// </summary>      
        private void _keyboardEvent(object sender, KeyEventArgs e)
        {
            // Данная переменная служит сигналом для метода по создании новых ячеек в конце данного метода
            // В случае, если при проходе данного метода ячейки смогли соединится
            // То мы присваиваем ifPicsWasMoved = true, после чего вызывается метод generateNewPic и создает новые плитки
            // Это происходит через проверку if в конце данного метода
            bool ifPicsWasMoved = false;
            // Через switch проверяем название нажатой клавиши
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    // Передвигаемся вправо пока мы можем это делать
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 2; l >= 0; l--)
                        {
                            // Проверка соседней ячейки относительно нашей
                            if (map[k, l] == 1)
                            {
                                for (int j = l + 1; j < 4; j++)
                                {                                    
                                    if (map[k, j] == 0)
                                    {
                                        ifPicsWasMoved = true;
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        labels[k, j] = labels[k, j - 1];
                                        labels[k, j - 1] = null;
                                        // Изменение для ячейки при передвижении вправо
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + 56, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicsWasMoved = true;
                                            // Тут ячейки смогли соединится, делаем так, что образуется одна
                                            // а на их месте будет пустота
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            // Вызом метода по изменения цвета для определенного веса плитки
                                            changeColor(a + b, k, j);
                                            label1.Text = "Очки: " + score; 
                                            map[k, j - 1] = 0;
                                            this.Controls.Remove(pics[k, j - 1]);
                                            this.Controls.Remove(labels[k, j - 1]);
                                            pics[k, j - 1] = null;
                                            
                                            labels[k, j - 1] = null;
                                        }
                                    }

                                }
                            }
                        }
                    }
                    break;
                case "Left":
                    // Передвигаемся влево пока мы можем это делать
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            // Проверка соседней ячейки относительно нашей
                            if (map[k, l] == 1)
                            {
                                for (int j = l - 1; j >= 0; j--)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicsWasMoved = true;
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        labels[k, j] = labels[k, j + 1];
                                        labels[k, j + 1] = null;
                                        // Изменение для ячейки при передвижении влево
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - 56, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicsWasMoved = true;
                                            // Тут ячейки смогли соединится, делаем так, что образуется одна
                                            // а на их месте будет пустота
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            // Вызом метода по изменения цвета для определенного веса плитки
                                            changeColor(a + b, k, j);
                                            label1.Text = "Очки: " + score;

                                            map[k, j + 1] = 0;                                         
                                            this.Controls.Remove(pics[k, j + 1]);
                                            this.Controls.Remove(labels[k, j + 1]);
                                            pics[k, j + 1] = null;
                                         
                                            labels[k, j + 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                    // Передвигаемся вниз пока мы можем это делать
                    for (int k = 2; k >= 0; k--)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            // Проверка соседней ячейки относительно нашей
                            if (map[k, l] == 1)
                            {
                                for (int j = k + 1; j < 4; j++)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicsWasMoved = true;
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        labels[j, l] = labels[j - 1, l];
                                        labels[j - 1, l] = null;
                                        // Изменение для ячейки при передвижении вниз
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + 56);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j - 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicsWasMoved = true;
                                            // Тут ячейки смогли соединится, делаем так, что образуется одна
                                            // а на их месте будет пустота
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            // Вызом метода по изменения цвета для определенного веса плитки
                                            changeColor(a + b, j, l);
                                            label1.Text = "Очки: " + score;                                          

                                            map[j - 1, l] = 0;                                        
                                            this.Controls.Remove(pics[j - 1, l]);
                                            this.Controls.Remove(labels[j - 1, l]);
                                            pics[j - 1, l] = null;
                                        
                                            labels[j - 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up":
                    // Передвигаемся вверх пока мы можем это делать
                    for (int k = 1; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            // Проверка соседней ячейки относительно нашей
                            if (map[k, l] == 1)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicsWasMoved = true;
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        labels[j, l] = labels[j + 1, l];
                                        labels[j + 1, l] = null;
                                        // Изменение для ячейки при передвижении вверх
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - 56);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j + 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicsWasMoved = true;
                                            // Тут ячейки смогли соединится, делаем так, что образуется одна
                                            // а на их месте будет пустота
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            // Вызом метода по изменения цвета для определенного веса плитки
                                            changeColor(a + b, j, l);
                                            label1.Text = "Очки: " + score;                                    

                                            map[j + 1, l] = 0;                                           
                                            this.Controls.Remove(pics[j + 1, l]);
                                            this.Controls.Remove(labels[j + 1, l]);
                                            pics[j + 1, l] = null;                                         
                                            labels[j + 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    break;
            }
            // Если было соединение, то создаются новые плитки
            if (ifPicsWasMoved)
                generateNewPic();
        }
        /// <summary>
        /// Метод при закрытии текущей формы передает кол-во очков играющего пользователя
        /// </summary>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (I)
            {
                case 1:
                    {
                        ChangeName(_form1.Player1.Text);
                        _form1.Player1.Text = TempName+" " + score;
                    }
                    break;
                case 2:
                    {
                        ChangeName(_form1.Player2.Text);
                        _form1.Player2.Text = TempName + " " + score;
                    }
                    break;
                case 3:
                    {
                        ChangeName(_form1.Player3.Text);
                        _form1.Player3.Text = TempName + " " + score;
                    }
                    break;
                case 4:
                    {
                        ChangeName(_form1.Player4.Text);
                        _form1.Player4.Text = TempName + " " + score;
                    }
                    break;
                case 5:
                    {
                        ChangeName(_form1.Player5.Text);
                        _form1.Player5.Text = TempName + " " + score;
                    }
                    break;
            }
        }
        /// <summary>
        /// Метод, который после окончания игры присваивает
        /// к учетной записи игрока его итоговый счет за игру
        /// </summary>
        private void ChangeName(string str)
        {
            foreach(char c in str)
            {
                if (!Char.IsDigit(c)) TempName += c;
            }
        }
    }
}