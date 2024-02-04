using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public partial class Form4 : Form
{
	public Form4()
	{
		this.InitializeComponent();
		Control.CheckForIllegalCrossThreadCalls = false;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00007A10 File Offset: 0x00005C10
	private void label1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00016C50 File Offset: 0x00014E50
	private void Form4_Load(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_0));
		thread.Start();
	}

	[CompilerGenerated]
	private void method_0()
	{
		string text = this.string_0;
		string text2 = this.string_1;
		string text3 = "";
		string text4 = "";
		for (int i = 0; i < text.Length; i++)
		{
			text3 += text[i].ToString();
			this.label1.Text = text3;
			Thread.Sleep(20);
		}
		for (int j = 0; j < text2.Length; j++)
		{
			try
			{
				text4 += text2[j].ToString();
				this.label2.Text = text4;
				Thread.Sleep(20);
			}
			catch
			{
			}
		}
	}

	public string string_0;

	public string string_1;

	private IContainer icontainer_0 = null;
}
