using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OhOhMyDefence
{
    public partial class Form1 : Form
    {
        List<string> part1, part2, part3, part4;

        Random random;

        public Form1()
        {
            InitializeComponent();

            part1 = new List<string>();
            part2 = new List<string>();
            part3 = new List<string>();
            part4 = new List<string>();

            part1.Add("солнечный");
            part1.Add("траурный");
            part1.Add("плюшевый");
            part1.Add("бешеный");
            part1.Add("памятный");
            part1.Add("трепетный");
            part1.Add("базовый");
            part1.Add("скошенный");
            part1.Add("преданный");
            part1.Add("ласковый");
            part1.Add("пойманный");
            part1.Add("радужный");
            part1.Add("огненный");
            part1.Add("радостный");
            part1.Add("тензорный");
            part1.Add("шёлковый");
            part1.Add("пепельный");
            part1.Add("ламповый");
            part1.Add("жаренный");
            part1.Add("загнанный");

            part2.Add("зайчик");
            part2.Add("Верник");
            part2.Add("глобус");
            part2.Add("ветер");
            part2.Add("щавель");
            part2.Add("пёсик");
            part2.Add("копчик");
            part2.Add("ландыш");
            part2.Add("стольник");
            part2.Add("мальчик");
            part2.Add("дольщик");
            part2.Add("Игорь");
            part2.Add("невод");
            part2.Add("егерь");
            part2.Add("пончик");
            part2.Add("лобстер");
            part2.Add("жемчуг");
            part2.Add("кольщик");
            part2.Add("йогурт");
            part2.Add("овод");

            part3.Add("стеклянного");
            part3.Add("ванильного");
            part3.Add("резонного");
            part3.Add("широкого");
            part3.Add("дешёвого");
            part3.Add("горбатаго");
            part3.Add("собачьего");
            part3.Add("исконного");
            part3.Add("волшебного");
            part3.Add("картонного");
            part3.Add("лохматого");
            part3.Add("арбузного");
            part3.Add("огромного");
            part3.Add("запойного");
            part3.Add("великого");
            part3.Add("бараньего");
            part3.Add("вандального");
            part3.Add("едрёного");
            part3.Add("парадного");
            part3.Add("укромного");

            part4.Add("глаза");
            part4.Add("плова");
            part4.Add("Пельша");
            part4.Add("мира");
            part4.Add("деда");
            part4.Add("жира");
            part4.Add("мема");
            part4.Add("ада");
            part4.Add("бура");
            part4.Add("жала");
            part4.Add("нёба");
            part4.Add("гунна");
            part4.Add("хлама");
            part4.Add("шума");
            part4.Add("воза");
            part4.Add("сала");
            part4.Add("фена");
            part4.Add("зала");
            part4.Add("рака");
            part4.Add("смака");
            random = new Random();

            textBox1.Text = part1[random.Next() % part1.Count()];
            textBox2.Text = part2[random.Next() % part1.Count()];
            textBox3.Text = part3[random.Next() % part1.Count()];
            textBox4.Text = part4[random.Next() % part1.Count()];

            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = part1[random.Next() % part1.Count() * 2];
            textBox2.Text = part2[random.Next() % part1.Count() * 2];
            textBox3.Text = part3[random.Next() % part1.Count() * 2];
            textBox4.Text = part4[random.Next() % part1.Count() * 2];
        }
    }
}
