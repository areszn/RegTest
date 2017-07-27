using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegTest
{
    public partial class RegTest : Form
    {
        public RegTest()
        {
            InitializeComponent();
        }

        private void tbTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbReg.Text) || string.IsNullOrEmpty(tbSrc.Text))
                return;

            try
            {
                Regex r = new Regex(tbReg.Text);

                if (r.IsMatch(tbSrc.Text))
                {
                    tbMatch.Text = "";
                    MatchCollection mc = r.Matches(tbSrc.Text);
                    int index = 0;
                    tbMatch.Text = string.Format("共匹配成功{0}处，分别为：",mc.Count) ;
                    foreach(Match m in mc)
                    {
                        tbMatch.Text += "\r\n " +(++index).ToString() + "，内容：\""+ m.Value + "\"，位置：" + m.Index.ToString() +"；";
                        char index2 = 'a';
                        foreach(Group g in m.Groups)
                        {
                            tbMatch.Text += "\r\n     分组" + index2++.ToString() +"：开始位置" + g.Index + "，内容：\"" + g.Value + "\"，长度：" + g.Length + "；";
                        }
                        
                    }
                }
                else
                {
                    tbMatch.Text = "没有匹配！";
                }
            }
            catch (Exception ex)
            {
                tbMatch.Text = ex.Message;
            }


        }
    }
}
