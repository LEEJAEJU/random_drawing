using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_02_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //리스트 박스 정리
            listBox1.Items.Add("지금까지 뽑은 포켓몬 목록(1회 : 100원)");
            first_load_setting();
            price_show.Text = "0원";
        }

        public void first_load_setting()
        {
            o_doctor.Image = Properties.Resources._3F3F3F_3F_3F3F;
            o_doctor.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_01.Image = Properties.Resources._7165_shop1_234345;
            ball_01.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_02.Image = Properties.Resources._7165_shop1_234345;
            ball_02.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_03.Image = Properties.Resources._7165_shop1_234345;
            ball_03.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_04.Image = Properties.Resources._7165_shop1_234345;
            ball_04.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_05.Image = Properties.Resources._7165_shop1_234345;
            ball_05.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_06.Image = Properties.Resources._7165_shop1_234345;
            ball_06.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_07.Image = Properties.Resources._7165_shop1_234345;
            ball_07.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_08.Image = Properties.Resources._7165_shop1_234345;
            ball_08.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_09.Image = Properties.Resources._7165_shop1_234345;
            ball_09.SizeMode = PictureBoxSizeMode.StretchImage;
            ball_10.Image = Properties.Resources._7165_shop1_234345;
            ball_10.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        class test
        {
            public string vv;
        }

        public int rs = 0;
        public string Pp()
        {
            Random rr = new Random();
            List<test> list = new List<test>();
            {
                list.Add(new test() { vv = "pi.gif" });
                list.Add(new test() { vv = "eve.gif" });
                list.Add(new test() { vv = "king.gif" });
                list.Add(new test() { vv = "liza.gif" });
                list.Add(new test() { vv = "wq.gif" });
                list.Add(new test() { vv = "picu.gif" });
                list.Add(new test() { vv = "ciko.gif" });
                list.Add(new test() { vv = "pang.gif" });
            }
            rs = rr.Next(0, 8);
            string str = list[rs].vv;
            return str;
        }

        public string Pp2()
        {
            if (rs == 0)
                return "피카츄";
            else if (rs == 1)
                return "이브이";
            else if (rs == 2)
                return "거북왕";
            else if (rs == 3)
                return "리자몽";
            else if (rs == 4)
                return "화이트큐레무";
            else if (rs == 5)
                return "피츄";
            else if (rs == 6)
                return "타는 쓰래기";
            else
                return "팽도리";
        }

        public void result_cc_print()
        {
            if (ball_se_01.Checked == true)
            {
                ball_01.Image = Image.FromFile(Pp());
                ball_01.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_01.Text = Pp2();
                listBox1.Items.Add(ball_se_01.Text);
            }
            else if (ball_se_02.Checked == true)
            {
                ball_02.Image = Image.FromFile(Pp());
                ball_02.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_02.Text = Pp2();
                listBox1.Items.Add(ball_se_02.Text);
            }
            else if (ball_se_03.Checked == true)
            {
                ball_03.Image = Image.FromFile(Pp());
                ball_03.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_03.Text = Pp2();
                listBox1.Items.Add(ball_se_03.Text);
            }
            else if (ball_se_04.Checked == true)
            {
                ball_04.Image = Image.FromFile(Pp());
                ball_04.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_04.Text = Pp2();
                listBox1.Items.Add(ball_se_04.Text);
            }
            else if (ball_se_05.Checked == true)
            {
                ball_05.Image = Image.FromFile(Pp());
                ball_05.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_05.Text = Pp2();
                listBox1.Items.Add(ball_se_05.Text);
            }
            else if (ball_se_06.Checked == true)
            {
                ball_06.Image = Image.FromFile(Pp());
                ball_06.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_06.Text = Pp2();
                listBox1.Items.Add(ball_se_06.Text);
            }
            else if (ball_se_07.Checked == true)
            {
                ball_07.Image = Image.FromFile(Pp());
                ball_07.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_07.Text = Pp2();
                listBox1.Items.Add(ball_se_07.Text);
            }
            else if (ball_se_08.Checked == true)
            {
                ball_08.Image = Image.FromFile(Pp());
                ball_08.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_08.Text = Pp2();
                listBox1.Items.Add(ball_se_08.Text);
            }
            else if (ball_se_09.Checked == true)
            {
                ball_09.Image = Image.FromFile(Pp());
                ball_09.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_09.Text = Pp2();
                listBox1.Items.Add(ball_se_09.Text);
            }
            else if (ball_se_10.Checked == true)
            {
                ball_10.Image = Image.FromFile(Pp());
                ball_10.SizeMode = PictureBoxSizeMode.StretchImage;
                ball_se_10.Text = Pp2();
                listBox1.Items.Add(ball_se_10.Text);
            }
        }

        public int reset_Click_check = 0;
        public int reset_price_end = 0;
        private void result_check_Click(object sender, EventArgs e)
        {
            if (ball_se_01.Checked == true || ball_se_02.Checked == true || ball_se_03.Checked == true || ball_se_04.Checked == true || ball_se_05.Checked == true
                || ball_se_06.Checked == true || ball_se_07.Checked == true || ball_se_08.Checked == true || ball_se_09.Checked == true || ball_se_10.Checked == true)
            {
                reset_Click_check++;
                if (reset_Click_check >= 2)
                {
                    first_load_setting();
                    all_radio_check_false();
                    reset_Click_check = 0;
                }
                else
                {
                    result_cc_print();
                    reset_price_end = 100 * (listBox1.Items.Count - 1);
                    price_show.Text = reset_price_end.ToString() + "원";
                }
            }
            else
            {
                reset_Click_check = 0;
            }
        }

        public  void all_radio_check_false()
        {
            if (ball_se_01.Checked == true)
                ball_se_01.Checked = false;
            else if (ball_se_02.Checked == true)
                ball_se_02.Checked = false;
            else if(ball_se_03.Checked == true)
                ball_se_03.Checked = false;
            else if(ball_se_04.Checked == true)
                ball_se_04.Checked = false;
            else if(ball_se_05.Checked == true)
                ball_se_05.Checked = false;
            else if(ball_se_06.Checked == true)
                ball_se_06.Checked = false;
            else if(ball_se_07.Checked == true)
                ball_se_07.Checked = false;
            else if(ball_se_08.Checked == true)
                ball_se_08.Checked = false;
            else if(ball_se_09.Checked == true)
                ball_se_09.Checked = false;
            else if(ball_se_10.Checked == true)
                ball_se_10.Checked = false;
            ball_se_01.Text = "???";
            ball_se_02.Text = "???";
            ball_se_03.Text = "???";
            ball_se_04.Text = "???";
            ball_se_05.Text = "???";
            ball_se_06.Text = "???";
            ball_se_07.Text = "???";
            ball_se_08.Text = "???";
            ball_se_09.Text = "???";
            ball_se_10.Text = "???";
        }

        private void reset_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("지금까지 뽑은 포켓몬 목록(1회 : 100원)");
            first_load_setting();
            all_radio_check_false();
            reset_Click_check = 0;
            reset_price_end = 0;
            price_show.Text = "0원";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            first_load_setting();
            all_radio_check_false();
            reset_Click_check = 0;
        }

        private void purchase_Click(object sender, EventArgs e)
        {

            if (reset_price_end == 0)
            {
                MessageBox.Show("시작을 하지 않았습니다.");
            }
            else
            {
                if (MessageBox.Show($"{Pp2()}를 구매하시겠습니까? \n총 금액은 {reset_price_end}입니다.", "결재 창", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
