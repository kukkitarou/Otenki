using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {

        float lat;
        float lon;
        float maxtem;
        float mintem;
        float winsp;

        public Form1()
        {
            InitializeComponent();
        }
    
        //パラメータ取得・URLの生成
        public void parameters()
        {
            lat = float.Parse(latBox.Text);
            lon = float.Parse(lonBox.Text);
            
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            parameters();
        }
        //URLの取得
    }
}
