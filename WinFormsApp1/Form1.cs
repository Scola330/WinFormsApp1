namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Gracz g = new Gracz();
        int iloscRozgrywek = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void switchPlyerChar()
        {
            g.SwitchP();
            label2.Text = "aktywny gracz: " + g.GetP();
            label1.Text = "iloœæ rozgrywek: " + iloscRozgrywek;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text != "")
            {
                return;
            }

            button.Text = g.GetP();
            switchPlyerChar();

            
            checkResult();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void checkResult()
        {
            List<Button> buttonList = tableLayoutPanel1.Controls.OfType<Button>().ToList();
            int empty = 0;
            foreach (Button button in buttonList)
            {
                if (button.Text == String.Empty)
                {
                    empty++;
                }
            }

            if (topLeft.Text != String.Empty &&
                    topMiddle.Text != String.Empty &&
                    topRight.Text != String.Empty)
            {
                if (topLeft.Text == topMiddle.Text && topMiddle.Text == topRight.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + topLeft.Text);
                    restartGame();
                }
            }

            if (middleLeft.Text != String.Empty &&
                    midleCenter.Text != String.Empty &&
                    middleRight.Text != String.Empty)
            {
                if (middleLeft.Text == midleCenter.Text && midleCenter.Text == middleRight.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + middleLeft.Text);
                    restartGame();
                }
            }

            if (bottomLeft.Text != String.Empty &&
                    bottomMiddle.Text != String.Empty &&
                    bottomRight.Text != String.Empty)
            {
                if (bottomLeft.Text == bottomMiddle.Text && bottomMiddle.Text == bottomRight.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + bottomLeft.Text);
                    restartGame();
                }
            }

            if (topLeft.Text != String.Empty &&
                    middleLeft.Text != String.Empty &&
                    bottomLeft.Text != String.Empty)
            {
                if (topLeft.Text == middleLeft.Text && middleLeft.Text == bottomLeft.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + topLeft.Text);
                    restartGame();
                }
            }

            if (topMiddle.Text != String.Empty &&
                    midleCenter.Text != String.Empty &&
                    bottomMiddle.Text != String.Empty)
            {
                if (topMiddle.Text == midleCenter.Text && midleCenter.Text == bottomMiddle.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + topMiddle.Text);
                    restartGame();
                }
            }

            if (topRight.Text != String.Empty &&
                    middleRight.Text != String.Empty &&
                    bottomRight.Text != String.Empty)
            {
                if (topRight.Text == middleRight.Text && middleRight.Text == bottomRight.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + topRight.Text);
                    restartGame();
                }
            }

            if (topLeft.Text != String.Empty &&
                    midleCenter.Text != String.Empty &&
                    bottomRight.Text != String.Empty)
            {
                if (topLeft.Text == midleCenter.Text && midleCenter.Text == bottomRight.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + topLeft.Text);
                    restartGame();
                }
            }

            if (topRight.Text != String.Empty &&
                    midleCenter.Text != String.Empty &&
                    bottomLeft.Text != String.Empty)
            {
                if (topRight.Text == midleCenter.Text && midleCenter.Text == bottomLeft.Text)
                {
                    MessageBox.Show("wygra³ gracz: " + topRight.Text);
                    restartGame();
                }
            }

            if (empty == 0)
            {
                MessageBox.Show("remis");
                restartGame();
            }
        }

        void restartGame()
        {
            List<Button> buttonList = tableLayoutPanel1.Controls.OfType<Button>().ToList();
            foreach (Button button in buttonList)
            {
                button.Text = String.Empty;
            }
            g.Reset();
            label2.Text = "aktywny gracz: " + g.GetP();
            iloscRozgrywek++;
            
        }


    }

}

