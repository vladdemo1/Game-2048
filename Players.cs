using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Game2048
{
    [Serializable]
    public class Players
    {
        /// <summary>
        /// Игрок 1
        /// </summary>
        public string Player1 { get; set; }
        /// <summary>
        /// Игрок 2
        /// </summary>
        public string Player2 { get; set; }
        /// <summary>
        /// Игрок 3
        /// </summary>
        public string Player3 { get; set; }
        /// <summary>
        /// Игрок 4
        /// </summary>
        public string Player4 { get; set; }
        /// <summary>
        /// Игрок 5
        /// </summary>
        public string Player5 { get; set; }
        /// <summary>
        /// Метод для ввода имен игроков
        /// </summary>
        /// <param name="form1"></param>
        public void In(Form1 form1)
        {
            Player1 = form1.Player1.Text;
            Player2 = form1.Player2.Text;
            Player3 = form1.Player3.Text;
            Player4 = form1.Player4.Text;
            Player5 = form1.Player5.Text;            
        }
        /// <summary>
        /// Метод с сохранением данных с помощью xml
        /// </summary>
        public void Save()
        {
            SaveFileDialog saving = new SaveFileDialog();
            saving.Filter = "xml files (*.xml)|*.xml";
            saving.RestoreDirectory = true;

            if (saving.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Players));
                using (FileStream fs = new FileStream(saving.FileName,
                    FileMode.Create))
                {
                    formatter.Serialize(fs, this);
                }
            }
        }
        /// <summary>
        /// Выгрузка данных xml
        /// </summary>      
        public void Upload(Form1 myform)
        {
            OpenFileDialog opening = new OpenFileDialog();
            opening.Filter = "xml files (*.xml)|*.xml";
            opening.RestoreDirectory = true;

            if (opening.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Players));
                using (FileStream fs = new FileStream(opening.FileName,
                    FileMode.OpenOrCreate))
                {
                    Players data = (Players)formatter.Deserialize(fs);

                    myform.Player1.Text = data.Player1;
                    myform.Player2.Text = data.Player2;
                    myform.Player3.Text = data.Player3;
                    myform.Player4.Text = data.Player4;
                    myform.Player5.Text = data.Player5;
                }
            }
        }
    }
}
