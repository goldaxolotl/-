using System;
using System.IO;
using System.Windows.Forms;

namespace satoriNotePad1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //読み込みスクリプト
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)

                textBox1.Text = File.ReadAllText(dialog.FileName);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //終了のスクリプト
            DialogResult result = MessageBox.Show("メモ帳を終了しますか?", "終了", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //保存のスクリプト
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)

                File.WriteAllText(dialog.FileName, textBox1.Text);
        }

        private void 概要ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ほかのアプリToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
