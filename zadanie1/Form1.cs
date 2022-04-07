using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code_text = textBox1.Text;
            string k = textBox3.Text;
            int nomer; // Номер в алфавите
            int d; // Смещение на букву
            string s; // шифрованный текст
            string c; // расшифрованный текст
            int j, f; 
            int t = 0; // Преременная для  символа ключа.
            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            char[] massage = code_text.ToCharArray(); 
            char[] key = k.ToCharArray(); 
            if (radioButton1.Checked)
            {
                for (int i = 0; i < massage.Length; i++)
                {
                   
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (massage[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 33) //проверяем из алфавита ли буква
                    {
                        nomer = j; 

                        
                        if (t > key.Length - 1)
                        { t = 0; }

                       
                        for (f = 0; f < alfavit.Length; f++)
                        {
                            if (key[t] == alfavit[f])
                            {
                                break;
                            }
                        }

                        t++;

                        if (f != 33) 
                        {
                            d = nomer + f;
                        }
                        else
                        {
                            d = nomer;
                        }

                        
                        if (d > 32)
                        {
                            d = d - 33;
                        }

                        massage[i] = alfavit[d]; // Замена буквы
                    }
                }
                s = new string(massage); 
                textBox2.Text = s;


            }
            else // если пользовтель выбирает расшифровать текст то алгоритм тот же, но
            {
                for (int i = 0; i < massage.Length; i++)
                {
                    
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (massage[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 33) 
                    {
                        nomer = j; 

                        
                        if (t > key.Length - 1) { t = 0; }

                        
                        for (f = 0; f < alfavit.Length; f++)
                        {
                            if (key[t] == alfavit[f])
                            {
                                break;
                            }
                        }

                        t++;

                        if (f != 33) 
                        {
                            d = nomer - f + alfavit.Length; // тут происходит расшифровка текста
                        }
                        else
                        {
                            d = nomer;
                        }

                        
                        if (d > 32)
                        {
                            d = d - 33;
                        }

                        massage[i] = alfavit[d]; 
                    }
                }
                c = new string(massage); 
                textBox2.Text = c;
            }
        }
    }
}

    

