using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form2 : Form
	{
		int[] arr = new int[44];
		public Form2(int[] arr1)
		{
			arr = arr1;
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 44; i++)
			{
				change_status(i + 1, arr[i]);
			}
			set_color();
        }
		void change_status(int num, int value)
		{
			String[] val = { "\tНЕ ГОТОВО", "\tГОТОВО" };

			richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.Text.IndexOf("\n", richTextBox1.Text.IndexOf("№" + num)), val[value]);
		}

		void set_color()
		{
			int pos = richTextBox1.Text.IndexOf("ГОТОВО");
            while (pos != -1)
			{
				richTextBox1.Select(pos, "ГОТОВО".Length);
				richTextBox1.SelectionColor = Color.Green;
				pos = richTextBox1.Text.IndexOf("ГОТОВО", pos + 1);
			}

			pos = richTextBox1.Text.IndexOf("НЕ ГОТОВО");
			while (pos != -1)
			{
				richTextBox1.Select(pos, "НЕ ГОТОВО".Length);
				richTextBox1.SelectionColor = Color.Red;
				pos = richTextBox1.Text.IndexOf("НЕ ГОТОВО", pos + 1);
			}
			richTextBox1.SelectionLength = 0;
			richTextBox1.SelectionStart = 0;
		}

	}
}
