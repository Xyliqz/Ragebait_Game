using System;
using System.Drawing;
using System.Windows.Forms;

namespace random_button
{
    public partial class Form1 : Form
    {



        int score = 0;
        Random random = new Random();


        //Фон
        Color[] colors = { Color.White, Color.Green, Color.Red };
        int currentColorIndex = 0;

        string[] button1Texts =
        {
            "Другият път по-добре малко братленце.",
            "Твърде си бавен!",
            "Хайде UNC, по-бързо!",
                "Инвалид е по-бърз от теб!",
                "Мишката ти работи ли?",
                "Почти успя!"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Брой цъкания
            score++;
            label1.Text = "Точки: " + score.ToString();

            //Цвят
            button1.BackColor = Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256)



                );


            //Къде се мести
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            button1.Location = new Point(newX, newY);

            //texts
            int randomIndex = random.Next(button1Texts.Length);
            button1.Text = button1Texts[randomIndex];

            //Ефекти
            button1.Size = new Size(button1.Width + 5, button1.Height + 5);
            await Task.Delay(1000);
            button1.Size = new Size(button1.Width - 5, button1.Height - 5);

            //Фон
            if (score % 10 == 0)
            {
                currentColorIndex++;
                if (currentColorIndex >= colors.Length)
                    currentColorIndex = 0;

                this.BackColor = colors[currentColorIndex];

            }
        }
    }
}
      
    

        
    

