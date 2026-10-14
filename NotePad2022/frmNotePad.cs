using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace NotePadApp
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(richTxtBox.Text);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    richTxtBox.Text = reader.ReadToEnd();
                }
            }
        }

        private void frmNotePad_Load(object sender, EventArgs e)
        {

        }

        private void впвапваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void переносСоСловамиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmNotePad_Load_1(object sender, EventArgs e)
        {

        }

        private void richTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}