using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogGraph
{
    public partial class Form1 : Form
    {
        int count = 1; //カウント値
        public Form1() {
            InitializeComponent();
        }
        // リストデータ        
        private void UpdateByListData() {
            count = 1;
            Random r = new Random(); //乱数
            var timeList = new List<double>();
            var dataList = new List<double>();
            for (int i = 0; i < 100; i++) {
                var data = double.Parse($"{r.Next(1, 99)}");
                double miliSeconds = TimeSpan.FromSeconds(count).TotalMilliseconds; // 経過時間
                timeList.Add(miliSeconds);
                dataList.Add(data);
                count++;
            }
            this.LoGraphFx.UpdateValue(timeList.ToArray(), dataList.ToArray());
        }
        private void Button1_Click(object sender, EventArgs e) {
            UpdateByListData();
        }
        private void button2_Click(object sender, EventArgs e) {
            // データを追加
            //dataGridView1.Rows.Add("国語", "aa", "田中一郎", "A");
            string[] name ;
            Color[] color ;
            var list = LoGraphFx.RemoveSeries(out name, out color);
            foreach (var item in list) {
                listBox1.Items.Add(item);
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < name.Length; i++) {
                dataGridView1.Rows.Add(name[i], "aa", "サンプル", true);
                dataGridView1[1, i].Style.BackColor = color[i];
            }
            dataGridView1.Refresh();

        }
        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Button3_Click(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
        }
    }
}
