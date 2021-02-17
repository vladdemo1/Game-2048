using System;
using System.Windows.Forms;

namespace Game2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label_Add.Visible = false; // Скрываем label над кнопкой
            textbox_Name.Visible = false; // Скрываем textbox над кнопкой
            Play.Visible = false; // Скрываем кнопку "Играть"
        }
        /// <summary>
        /// Метод сохранения игроков
        /// </summary>
        private void Save()
        {
            players.In(this); 
            players.Save(); // Сохранение игроков
        }
        /// <summary>
        /// Экземпляр класса Players
        /// </summary>
        Players players = new Players();
        /// <summary>
        /// Кнопка выхода вызывает окно для сохранения игроков
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Save(); // Метод сохранения
            this.Close(); // Закрытие формы
        }
        int ForSwitch = 1; // Выбранная кнопка

        public string PlayerNow = ""; // Имя игрока, который сейчас играет
        /// <summary>
        /// После выбранной ячейки под игрока появляется пункт добавления игрока
        /// </summary>
        private void AddNewPlayer()
        {
            label_Add.Visible = true;
            textbox_Name.Visible = true;
            Play.Visible = true;
        }
        /// <summary>
        /// Метод присваивает текущему игроку лишь буквы (без цифр)
        /// </summary>       
        private void CheckName(string str)
        {
            foreach(char c in str)
            {
                if (!Char.IsDigit(c)) PlayerNow += c;
            }
        }
        /// <summary>
        /// Проверка на имя игрока, чтобы не содержало цифр и не было больше 10 символов
        /// </summary>  
        private bool CheckNamePlayer(string str)
        {
            int i = 0; // Счетчик для кол-ва символов в имени игрока
            foreach(char c in str)
            {
                if (Char.IsDigit(c)) return false;
                i++;
            }
            if (i > 10) return false; // Ограничение имени на 10 символов
            else        return true;
        }
        /// <summary>
        /// Метод для открытия второй формы и начала самой игры
        /// </summary>
        private void PlayGame(int i)
        {
            Form2 form2 = new Form2(i, this); // i - номер игрока, который начал игру
            form2.ShowDialog(); // Показ 2й формы как модальной
        }
        /// <summary>
        /// Метод для кнопок с отображением Имени игрока и его счета
        /// </summary>
        private void ShowAdd(int i, out int forSwitch)
        {
            switch (i)
            {
                // При выборе первой кнопки остальные потухают
                case 1:
                    {
                        if(Player1.Text == "Пусто")
                        {
                            Player2.Enabled = false;
                            Player3.Enabled = false;
                            Player4.Enabled = false;
                            Player5.Enabled = false;

                            AddNewPlayer(); // Вызов метода по добавлению нового игрока
                        }
                        else
                        {
                            CheckName(Player1.Text);
                            For2Form(); // В момент перед открытием формы с игрой восстанавливаем все кнопки
                            PlayGame(1); // Начало игры (открытие 2 формы) с игроком 1
                        }                        
                    }
                    break;
                case 2:
                    {
                        if(Player2.Text == "Пусто")
                        {
                            Player1.Enabled = false;
                            Player3.Enabled = false;
                            Player4.Enabled = false;
                            Player5.Enabled = false;

                            AddNewPlayer(); // Вызов метода по добавлению нового игрока
                        }
                        else
                        {
                            CheckName(Player2.Text);
                            For2Form(); // В момент перед открытием формы с игрой восстанавливаем все кнопки
                            PlayGame(2); // Начало игры (открытие 2 формы) с игроком 2
                        }                       
                    }
                    break;
                case 3:
                    {
                        if (Player3.Text == "Пусто")
                        {
                            Player1.Enabled = false;
                            Player2.Enabled = false;
                            Player4.Enabled = false;
                            Player5.Enabled = false;

                            AddNewPlayer();
                        }
                        else
                        {
                            CheckName(Player3.Text);
                            For2Form(); // В момент перед открытием формы с игрой восстанавливаем все кнопки
                            PlayGame(3); // Начало игры (открытие 2 формы) с игроком 3
                        }                      
                    }
                    break;
                case 4:
                    {
                        if(Player4.Text == "Пусто")
                        {
                            Player1.Enabled = false;
                            Player2.Enabled = false;
                            Player3.Enabled = false;
                            Player5.Enabled = false;

                            AddNewPlayer(); // Вызов метода по добавлению нового игрока
                        }
                        else
                        {
                            CheckName(Player4.Text);
                            For2Form(); // В момент перед открытием формы с игрой восстанавливаем все кнопки
                            PlayGame(4); // Начало игры (открытие 2 формы) с игроком 4
                        }                    
                    }
                    break;
                case 5:
                    {
                        if(Player5.Text == "Пусто")
                        {
                            Player1.Enabled = false;
                            Player2.Enabled = false;
                            Player3.Enabled = false;
                            Player4.Enabled = false;

                            AddNewPlayer(); // Вызов метода по добавлению нового игрока
                        }
                        else
                        {
                            CheckName(Player5.Text);
                            For2Form(); // В момент перед открытием формы с игрой восстанавливаем все кнопки
                            PlayGame(5); // Начало игры (открытие 2 формы) с игроком 5
                        }                     
                    }
                    break;
            }
            forSwitch = i;
        }
        /// <summary>
        /// Восстановление всех кнопок перед открытием формы с игрой
        /// </summary>
        public void For2Form()
        {
            Player1.Enabled = true; // Делаем 1 ячейку доступной
            Player2.Enabled = true; // Делаем 2 ячейку доступной
            Player3.Enabled = true; // Делаем 3 ячейку доступной
            Player4.Enabled = true; // Делаем 4 ячейку доступной
            Player5.Enabled = true; // Делаем 5 ячейку доступной

            label_Add.Visible = false; // Убираем из виду label "Добавить игрока"
            textbox_Name.Visible = false; // Убираем из виду textBox для ввода имени игрока
            Play.Visible = false; // Убираем из виду кнопку "Играть"
        }
        /// <summary>
        /// Нажата 1я ячейка с игроков
        /// </summary> 
        private void Player1_Click(object sender, EventArgs e)
        {           
            ShowAdd(1, out ForSwitch);
        }
        /// <summary>
        /// Нажата 2я ячейка с игроков
        /// </summary> 
        private void Player2_Click(object sender, EventArgs e)
        {
            ShowAdd(2, out ForSwitch);
        }
        /// <summary>
        /// Нажата 3я ячейка с игроков
        /// </summary> 
        private void Player3_Click(object sender, EventArgs e)
        {
            ShowAdd(3, out ForSwitch);
        }
        /// <summary>
        /// Нажата 4я ячейка с игроков
        /// </summary> 
        private void Player4_Click(object sender, EventArgs e)
        {
            ShowAdd(4, out ForSwitch);
        }
        /// <summary>
        /// Нажата 5я ячейка с игроков
        /// </summary>    
        private void Player5_Click(object sender, EventArgs e)
        {
            ShowAdd(5, out ForSwitch);
        }
        /// <summary>
        /// Кнопка Играть, если нажато по кнопке с пустым слотом открывает форму 2 с игрой
        /// </summary>       
        private void Play_Click(object sender, EventArgs e)
        {
            if(textbox_Name.Text != "" && CheckNamePlayer(textbox_Name.Text))
            {
                switch (ForSwitch)
                {
                    case 1:
                        {
                            Player1.Text = textbox_Name.Text; // Делаем текст на ячейке 1 с именем игрока
                            PlayGame(1); // Начало игры (открытие 2 формы) с игроком 1
                        }
                        break;
                    case 2:
                        {
                            Player2.Text = textbox_Name.Text; // Делаем текст на ячейке 2 с именем игрока
                            PlayGame(2); // Начало игры (открытие 2 формы) с игроком 2
                        }
                        break;
                    case 3:
                        {
                            Player3.Text = textbox_Name.Text; // Делаем текст на ячейке 3 с именем игрока
                            PlayGame(3); // Начало игры (открытие 2 формы) с игроком 3
                        }
                        break;
                    case 4:
                        {
                            Player4.Text = textbox_Name.Text; // Делаем текст на ячейке 4 с именем игрока
                            PlayGame(4); // Начало игры (открытие 2 формы) с игроком 4
                        }
                        break;
                    case 5:
                        {
                            Player5.Text = textbox_Name.Text; // Делаем текст на ячейке 5 с именем игрока
                            PlayGame(5); // Начало игры (открытие 2 формы) с игроком 5
                        }
                        break;
                }
            }
            textbox_Name.Clear(); // очистка textBox для ввода имени игрока
            For2Form(); // Возвращаем (восстанавливаем) все кнопки и делаем их активными
        }
        /// <summary>
        /// Кнопка с сохранениями игроков
        /// </summary>   
        private void Saving_Click(object sender, EventArgs e)
        {
            players.Upload(this);  
        }
    }
}
