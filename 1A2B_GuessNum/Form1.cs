using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B_GuessNum
{
    public partial class Form1 : Form
    {
        public static int[] secretNum = new int[4];

        public Form1()
        {
            InitializeComponent();
            SecretNumUpdate();
            //testLabel.Text = secretNum[0].ToString() + secretNum[1].ToString() + secretNum[2].ToString() + secretNum[3].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count_A = 0;
            int count_B = 0;
            int[] GuessNum = new int[4];

            StringProcessing stringKeyIn = new StringProcessing(keyInBox.Text);
            GuessNum = stringKeyIn.CheckAndConvert();

            if (GuessNum != null)
            {
                GuessNum guessNum = new GuessNum(GuessNum);
                guessNum.CheckMyself(ref count_A, ref count_B);
                var listView = new ListViewItem(keyInBox.Text);     //將資料新增到LListViewItem
                listView.SubItems.Add(count_A + "A" + count_B + "B");
                listView1.Items.Add(listView);
                keyInBox.Text = "";

                if (count_A == 4)
                {
                    MessageBox.Show("You Win!", "Congradulations");
                    SecretNumUpdate();
                    //testLabel.Text = secretNum[0].ToString() + secretNum[1].ToString() + secretNum[2].ToString() + secretNum[3].ToString();
                    listView1.Items.Clear();
                    keyInBox.Text = "";
                }

            }
            else
                keyInBox.Text = "";


        }


        public void SecretNumUpdate()
        {
            Random random = new Random();
            int[] randomNum = new int[4];
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            for (int i = 0; i <= 9; i++)
            {
                arrayList.Add(i);
            }
            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(0, arrayList.Count);
                randomNum[i] = (int)arrayList[index];
                arrayList.RemoveAt(index);
            }

            secretNum = randomNum;
        }


        class GuessNum
        {
            int[] guessNum = new int[4];
            public GuessNum(int[] guessNum)
            {
                this.guessNum = guessNum;
            }
            public void CheckMyself(ref int count_A, ref int count_B)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guessNum[i] == secretNum[j])
                            count_B++;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (guessNum[i] == secretNum[i])
                        count_A++;
                }
                count_B -= count_A;

            }
        }

        class StringProcessing
        {
            string keyIn;
            public int[] guessNum = new int[4];
            public StringProcessing(string keyIn)
            {
                this.keyIn = keyIn;
            }

            public int[] CheckAndConvert()
            {

                if (keyIn.Length != 4)
                {
                    MessageBox.Show("Guess Num is not reasonable!", "error");
                    return null;
                }
                else
                {
                    ConvertString(keyIn);
                    if (guessNum[0] == guessNum[1] || guessNum[1] == guessNum[2] || guessNum[2] == guessNum[3] || guessNum[3] == guessNum[0])
                    {
                        MessageBox.Show("Guess Num is not reasonable!", "error");
                        return null;
                    }

                    else
                        return guessNum;
                }
            }

            private void ConvertString(string keyIn)
            {
                int temp;
                if (int.TryParse(keyIn, out temp) & temp >= 0)      //Convert keyInBox.Text to int temp, and then convert temp to myNum[]
                {
                    for (int i = 0; i < 4; i++)
                    {
                        while (temp % 10 != 0)
                        {
                            temp -= 1;
                            this.guessNum[3 - i]++;
                        }
                        temp /= 10;
                    }
                }

            }


        }
    }
}
