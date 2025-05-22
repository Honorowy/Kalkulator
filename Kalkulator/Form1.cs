namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double pierwsza = 0;
        string dzialanie = "";
        bool nowaLiczba = false;

        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            button10.Click += button10_Click;
            button11.Click += button11_Click;

            button12.Click += button12_Click;
            button13.Click += button13_Click;
            button15.Click += button15_Click;
            button18.Click += button18_Click;
            button16.Click += button16_Click;

            button14.Click += button14_Click;
            button17.Click += button17_Click;
        }

        public void DodajCyfre(string cyfra)
        {
            if (textBox1.Text == "0" || nowaLiczba)
                textBox1.Text = "";
            textBox1.Text += cyfra;
            nowaLiczba = false;
        }

        private void button1_Click(object sender, EventArgs e) { DodajCyfre("1"); }
        private void button2_Click(object sender, EventArgs e) { DodajCyfre("2"); }
        private void button3_Click(object sender, EventArgs e) { DodajCyfre("3"); }
        private void button4_Click(object sender, EventArgs e) { DodajCyfre("4"); }
        private void button5_Click(object sender, EventArgs e) { DodajCyfre("5"); }
        private void button6_Click(object sender, EventArgs e) { DodajCyfre("6"); }
        private void button7_Click(object sender, EventArgs e) { DodajCyfre("7"); }
        private void button8_Click(object sender, EventArgs e) { DodajCyfre("8"); }
        private void button9_Click(object sender, EventArgs e) { DodajCyfre("9"); }
        private void button10_Click(object sender, EventArgs e) { DodajCyfre("0"); }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e) { UstawDzialanie("*"); }
        private void button13_Click(object sender, EventArgs e) { UstawDzialanie("/"); }
        private void button15_Click(object sender, EventArgs e) { UstawDzialanie("-"); }
        private void button18_Click(object sender, EventArgs e) { UstawDzialanie("+"); }
        private void button16_Click(object sender, EventArgs e) { UstawDzialanie("^"); }

        void UstawDzialanie(string dz)
        {
            double.TryParse(textBox1.Text, out pierwsza);
            dzialanie = dz;
            nowaLiczba = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double druga;
            double.TryParse(textBox1.Text, out druga);
            double wynik = 0;
            if (dzialanie == "+") wynik = pierwsza + druga;
            else if (dzialanie == "-") wynik = pierwsza - druga;
            else if (dzialanie == "*") wynik = pierwsza * druga;
            else if (dzialanie == "/") wynik = druga != 0 ? pierwsza / druga : 0;
            else if (dzialanie == "^") wynik = Math.Pow(pierwsza, druga);
            textBox1.Text = wynik.ToString();
            nowaLiczba = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            pierwsza = 0;
            dzialanie = "";
            nowaLiczba = false;
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button17;
        private TextBox textBox1;
        private Button button18;
        private Button button16;

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button17 = new Button();
            textBox1 = new TextBox();
            button18 = new Button();
            button16 = new Button();
            SuspendLayout();

            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(278, 368);
            button1.Name = "button1";
            button1.Size = new Size(80, 70);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;

            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(364, 368);
            button2.Name = "button2";
            button2.Size = new Size(80, 70);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;

            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(450, 368);
            button3.Name = "button3";
            button3.Size = new Size(80, 70);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(278, 292);
            button4.Name = "button4";
            button4.Size = new Size(80, 70);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;

            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(364, 292);
            button5.Name = "button5";
            button5.Size = new Size(80, 70);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;

            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(450, 292);
            button6.Name = "button6";
            button6.Size = new Size(80, 70);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;

            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(278, 216);
            button7.Name = "button7";
            button7.Size = new Size(80, 70);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;

            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(364, 216);
            button8.Name = "button8";
            button8.Size = new Size(80, 70);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;

            button9.BackColor = SystemColors.ActiveCaptionText;
            button9.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(450, 216);
            button9.Name = "button9";
            button9.Size = new Size(80, 70);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;

            button10.BackColor = SystemColors.ActiveCaptionText;
            button10.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(278, 444);
            button10.Name = "button10";
            button10.Size = new Size(166, 70);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;

            button11.BackColor = SystemColors.ActiveCaptionText;
            button11.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button11.ForeColor = SystemColors.Control;
            button11.Location = new Point(450, 444);
            button11.Name = "button11";
            button11.Size = new Size(80, 70);
            button11.TabIndex = 10;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = false;

            button12.BackColor = SystemColors.ActiveCaptionText;
            button12.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button12.ForeColor = SystemColors.Control;
            button12.Location = new Point(450, 140);
            button12.Name = "button12";
            button12.Size = new Size(80, 70);
            button12.TabIndex = 11;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = false;

            button13.BackColor = SystemColors.ActiveCaptionText;
            button13.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button13.ForeColor = SystemColors.Control;
            button13.Location = new Point(364, 140);
            button13.Name = "button13";
            button13.Size = new Size(80, 70);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = false;

            button14.BackColor = SystemColors.ActiveCaptionText;
            button14.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button14.ForeColor = SystemColors.Control;
            button14.Location = new Point(278, 140);
            button14.Name = "button14";
            button14.Size = new Size(80, 70);
            button14.TabIndex = 13;
            button14.Text = "AC";
            button14.UseVisualStyleBackColor = false;

            button15.BackColor = SystemColors.ActiveCaptionText;
            button15.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button15.ForeColor = SystemColors.Control;
            button15.Location = new Point(536, 140);
            button15.Name = "button15";
            button15.Size = new Size(80, 70);
            button15.TabIndex = 14;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = false;

            button17.BackColor = SystemColors.ActiveCaptionText;
            button17.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button17.ForeColor = SystemColors.Control;
            button17.Location = new Point(536, 368);
            button17.Name = "button17";
            button17.Size = new Size(80, 146);
            button17.TabIndex = 16;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;

            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(278, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 67);
            textBox1.TabIndex = 17;

            button18.BackColor = SystemColors.ActiveCaptionText;
            button18.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button18.ForeColor = SystemColors.Control;
            button18.Location = new Point(536, 216);
            button18.Name = "button18";
            button18.Size = new Size(80, 70);
            button18.TabIndex = 18;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = false;

            button16.BackColor = SystemColors.ActiveCaptionText;
            button16.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            button16.ForeColor = SystemColors.Control;
            button16.Location = new Point(536, 292);
            button16.Name = "button16";
            button16.Size = new Size(80, 70);
            button16.TabIndex = 19;
            button16.Text = "^";
            button16.UseVisualStyleBackColor = false;

            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1056, 553);
            Controls.Add(button16);
            Controls.Add(button18);
            Controls.Add(textBox1);
            Controls.Add(button17);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
