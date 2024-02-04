using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

public partial class Form1 : Form
{
	public Form1()
	{
		this.InitializeComponent();
		Control.CheckForIllegalCrossThreadCalls = false;
	}
	private void method_0()
	{
		try
		{
			string path = "C:\\Profile";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			directoryInfo.Create();
			this.random_0.Next(0, this.string_6.Length);
			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddArguments(new string[]
			{
				"user-data-dir=" + this.string_5 + "\\Profile1"
			});
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
			chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
			chromeOptions.AddArgument("--disable-images");
			chromeOptions.AddArgument("--disable-extensions");
			chromeOptions.AddArgument("--disable-webgl");
			chromeOptions.AddArgument("--disable-dev-shm-usage");
			chromeOptions.AddArgument("--no-sandbox");
			ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
			chromeDriverService.HideCommandPromptWindow = true;
			IWebDriver webDriver = new ChromeDriver(chromeDriverService, chromeOptions);
			webDriver.Manage().Window.Size = new Size(500, 840);
			webDriver.Manage().Window.Position = new Point(0, 0);
			new Actions(webDriver);
			Thread.Sleep(1000);
			webDriver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmyaccount.google.com%3Futm_source%3Daccount-marketing-page%26utm_medium%3Dgo-to-account-button&ifkv=AXo7B7VrQXoH1EEHXUyXp48sn652Gy4voxY9UWNSIBh0lOVlBRYJUnG2j1pvDWIhVUt16bWqsury&service=accountsettings&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S2047624028%3A1691806446243652");
			int i = 0;
			while (i < 1)
			{
				Thread.Sleep(2000);
				Form4 form = new Form4();
				form.StartPosition = FormStartPosition.Manual;
				form.Left = 0;
				form.Top = 420;
				form.string_0 = "- Nếu đã đăng nhập thành công , hãy tắt thông báo này";
				form.string_1 = "- KHÔNG đăng nhập thành công hãy thử lại bằng THỦ CÔNG (TAY)-> RỒI HÃY TẮT TH.BÁO NÀY";
				form.ShowDialog();
				IWebElement webElement = webDriver.FindElement(By.XPath("//div[@class='GiKO7c']"));
				if (webElement != null)
				{
					webDriver.Quit();
					Thread thread = new Thread(new ThreadStart(method_0));
					thread.Start();
					Thread.Sleep(1000);
					this.method_11("C:\\Profile\\Profile1", "C:\\Profile\\Profile2");
					Thread.Sleep(1000);
					this.method_11("C:\\Profile\\Profile2", "C:\\Profile\\Profile3");
					Thread.Sleep(1000);
					this.method_11("C:\\Profile\\Profile3", "C:\\Profile\\Profile4");
					Thread.Sleep(1000);
					this.method_11("C:\\Profile\\Profile3", "C:\\Profile\\Profile5");
					Thread.Sleep(1000);
					this.method_11("C:\\Profile\\Profile3", "C:\\Profile\\Profile6");
					Thread.Sleep(1000);
					if (this.string_4 == "PRO")
					{
						this.button1k.Enabled = true;
						this.button2k.Enabled = true;
						this.button3k.Enabled = true;
						this.button4k.Enabled = true;
						this.button5k.Enabled = true;
						this.button6k.Enabled = true;
					}
					form.StartPosition = FormStartPosition.Manual;
					form.Left = 500;
					form.Top = 420;
					form.string_0 = "- Đã copy Proifile thành công";
					form.string_1 = "- Tiến hành đăng ký thôi nào !!! ";
					form.ShowDialog();
					i = 2;
				}
			}
		}
		catch (Exception)
		{
			Thread thread2 = new Thread(new ThreadStart(this.method_21));
			thread2.Start();
		}
	}

	private void method_1()
	{
		Form1.Class6 @class = new Form1.Class6();
		@class.form1_0 = this;
		string text = this.namegv1.Text;
		string text2 = this.date1.Text;
		string arg = text.Trim();
		string text3 = text2.Trim();
		string text4 = this.textBox1k.Text;
		string text5 = text4.Replace(" ", string.Empty);
		text5 = text5.Replace("\t", "");
		string[] array = text5.Split(new char[]
		{
			'_'
		});
		string str = array[0];
		if (!text4.Contains("_"))
		{
			MessageBox.Show(" Mã lớp sai ,Update mã lớp không phải mã môn . ví dụ : 'ENGL330337_02'");
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments(new string[]
		{
			"user-data-dir=" + this.string_5 + "\\Profile1"
		});
		int num = this.random_0.Next(0, this.string_6.Length);
		chromeOptions.AddArgument("--user-agent=" + this.string_6[num]);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
		chromeOptions.AddArgument("--disable-images");
		chromeOptions.AddArgument("--disable-webgl");
		chromeOptions.AddArgument("--disable-dev-shm-usage");
		chromeOptions.AddArgument("--no-sandbox");
		if (this.cbstory1.Checked)
		{
			chromeOptions.AddArguments(new string[]
			{
				"--headless"
			});
		}
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		@class.iwebDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		@class.iwebDriver_0.Manage().Window.Size = new Size(1000, 840);
		@class.iwebDriver_0.Manage().Window.Position = new Point(0, 0);
		@class.method_3("Đã mở chrome");
		@class.int_0 = 0;
		@class.int_1 = 0;
		IL_1E3:
		while (this.button1k.Text != "START")
		{
			int num2 = 0;
			int num3 = 0;
			try
			{
				@class.iwebDriver_0.Url = "https://dkmh.hcmute.edu.vn";
				@class.iwebDriver_0.Navigate();
				num3 = 1;
			}
			catch
			{
			}
			if (num3 == 1)
			{
				int num4 = 0;
				int i = 1;
				while (i < 10)
				{
					@class.method_4();
					@class.method_0();
					try
					{
						if (num4 == 0)
						{
							IWebElement webElement = @class.iwebDriver_0.FindElement(By.XPath("//span[.='\u00a0Đăng nhập với Google']"));
							if (webElement != null)
							{
								webElement.Click();
								i = 1;
								Thread.Sleep(1000);
								string currentWindowHandle = @class.iwebDriver_0.CurrentWindowHandle;
								List<string> list = new List<string>(@class.iwebDriver_0.WindowHandles);
								foreach (string text6 in list)
								{
									if (text6 != currentWindowHandle)
									{
										@class.iwebDriver_0.SwitchTo().Window(text6);
										break;
									}
								}
								for (int j = 1; j < 20; j++)
								{
									@class.method_4();
									@class.method_0();
									try
									{
										IWebElement webElement2 = @class.iwebDriver_0.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div/div[1]/div/div[1]"));
										webElement2.Click();
										@class.iwebDriver_0.SwitchTo().Window(currentWindowHandle);
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("//div[@class='scrollbar-container ps']"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("(//img[@alt='Vietnamese'])[1]"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					@class.method_4();
					@class.method_0();
					i++;
					continue;
				}
			}
			if (num2 == 1)
			{
				for (int k = 1; k < 4; k++)
				{
					try
					{
						@class.method_4();
						@class.method_0();
						string pageSource = @class.iwebDriver_0.PageSource;
						if (pageSource.Contains(this.string_2))
						{
							@class.int_1 = 0;
							break;
						}
						@class.int_1++;
						ThreadStart start;
						if ((start = @class.threadStart_0) == null)
						{
							start = (@class.threadStart_0 = new ThreadStart(@class.method_1));
						}
						Thread thread = new Thread(start);
						thread.Start();
						if (@class.int_1 == 5)
						{
							Environment.Exit(0);
						}
					}
					catch
					{
					}
				}
				int num5 = 0;
				int l = 1;
				while (l < 10)
				{
					if (!this.KH1.Checked)
					{
						@class.method_3("Tìm đăng ký ngoài KH " + l.ToString());
						@class.method_4();
						@class.method_0();
						try
						{
							IWebElement webElement3 = @class.iwebDriver_0.FindElement(By.XPath("//span[contains(text(),'Đăng ký ngoài kế hoạch')]"));
							webElement3.Click();
							num5 = 1;
							break;
						}
						catch
						{
						}
						l++;
						continue;
					}
					num5 = 1;
					if (this.CN1.Checked)
					{
						for (int m = 1; m < 10; m++)
						{
							@class.method_4();
							@class.method_0();
							try
							{
								IWebElement webElement4 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + str + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
								webElement4.Click();
								@class.method_3("Chuyển nhóm lần " + m.ToString());
								Thread.Sleep(1000);
								num5 = 2;
								break;
							}
							catch
							{
							}
						}
					}
					else if (num5 == 1)
					{
						for (int n = 1; n < 10; n++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Môn lần thứ " + n.ToString());
							try
							{
								IWebElement webElement5 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[2]"));
								webElement5.Click();
								num5 = 2;
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement6 = @class.iwebDriver_0.FindElement(By.XPath("//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')]"));
									webElement6.Click();
									num5 = 2;
									break;
								}
								catch
								{
									try
									{
										IWebElement webElement7 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[1]"));
										webElement7.Click();
										num5 = 2;
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 2)
					{
						int num6 = 0;
						for (int num7 = 1; num7 < 10; num7++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Lớp lần thứ " + num7.ToString());
							try
							{
								if (text3 == "")
								{
									text3 = "werwerwerfgf";
								}
								IWebElement webElement8 = @class.iwebDriver_0.FindElement(By.XPath("//td[normalize-space()='" + text4 + "']/preceding-sibling::td/span"));
								webElement8.Click();
								num5 = 3;
								@class.method_3("Chọn lớp thành công");
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement9 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'" + text3 + "')]/preceding-sibling::td/span"));
									webElement9.Click();
									@class.method_3("Chọn lớp thành công");
									num5 = 3;
									break;
								}
								catch
								{
									int num8 = 0;
									int num9 = 1;
									while (num9 < 10)
									{
										@class.method_3("    Tìm Lớp lần thứ " + (num7 + 1).ToString());
										try
										{
											IWebElement webElement10 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(),'{0}')])[{1}]/following-sibling::td[1]", arg, num9)));
											string text7 = webElement10.Text;
											if (text7 == "")
											{
												num8 = num9;
											}
											goto IL_7AF;
										}
										catch
										{
											goto IL_7AF;
										}
										IL_7A4:
										num9++;
										continue;
										IL_765:
										try
										{
											IWebElement webElement11 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(), '{0}')]/following-sibling::td[contains(text(), ' ')]/preceding-sibling::td/span)[{1}]", arg, num8)));
											webElement11.Click();
											@class.method_3("Chọn lớp thành công");
											num5 = 3;
											break;
										}
										catch
										{
										}
										goto IL_7A4;
										IL_7AF:
										if (num8 != 0)
										{
											goto IL_765;
										}
										goto IL_7A4;
									}
								}
								try
								{
									IWebElement webElement12 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'Không tìm')]"));
									if (webElement12 != null)
									{
										@class.method_3("Không có lớp học phần nào ");
										break;
									}
								}
								catch
								{
									try
									{
										IWebElement webElement13 = @class.iwebDriver_0.FindElement(By.XPath("(//tbody)[1]//tr[1]//td[2]"));
										if (webElement13 != null)
										{
											@class.method_3("Không tìm thấy lớp lần thứ " + num6.ToString());
											num6++;
											if (num6 == 10)
											{
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 3)
					{
						int num10 = 1;
						while (num10 < 10)
						{
							int num11 = 0;
							@class.method_4();
							@class.method_0();
							try
							{
								@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
								IWebElement webElement14 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Đăng ký']"));
								webElement14.Click();
								num11 = 1;
								goto IL_9EA;
							}
							catch
							{
								try
								{
									@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
									IWebElement webElement15 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Chuyển nhóm']"));
									webElement15.Click();
									num11 = 1;
								}
								catch
								{
								}
								goto IL_9EA;
							}
							IL_9D5:
							int num12;
							if (num12 != 0)
							{
								num10++;
								continue;
							}
							break;
							IL_8EF:
							for (int num13 = 1; num13 < 7; num13++)
							{
								@class.method_4();
								@class.method_0();
								@class.method_3("Check Đăng ký thành công" + num13.ToString());
								try
								{
									IWebElement webElement16 = @class.iwebDriver_0.FindElement(By.XPath("//div[contains(text(),'" + text3 + "')]"));
									if (webElement16 != null)
									{
										@class.method_2(text4);
										@class.method_3("Đăng ký thành công !!!");
										num12 = 1;
										@class.iwebDriver_0.Quit();
										break;
									}
								}
								catch
								{
									try
									{
										if (num13 > 4)
										{
											IWebElement webElement17 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + text4 + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
											if (webElement17 != null)
											{
												@class.method_2(text4);
												@class.method_3("Đăng ký thành công !!!");
												num12 = 1;
												@class.iwebDriver_0.Quit();
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
							goto IL_9D5;
							IL_9EA:
							num12 = 0;
							if (num11 == 1)
							{
								goto IL_8EF;
							}
							goto IL_9D5;
						}
						goto IL_1E3;
					}
					goto IL_1E3;
				}
			}
		}
	}

		private void method_2()
	{
		Form1.Class7 @class = new Form1.Class7();
		@class.form1_0 = this;
		string text = this.namegv2.Text;
		string text2 = this.date2.Text;
		string arg = text.Trim();
		string text3 = text2.Trim();
		string text4 = this.textBox2k.Text;
		string text5 = text4.Replace(" ", string.Empty);
		text5 = text5.Replace("\t", "");
		string[] array = text5.Split(new char[]
		{
			'_'
		});
		string str = array[0];
		if (!text4.Contains("_"))
		{
			MessageBox.Show(" Mã lớp sai ,cập nhật mới là mã lớp không phải mã môn ");
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments(new string[]
		{
			"user-data-dir=" + this.string_5 + "\\Profile2"
		});
		int num = this.random_0.Next(0, this.string_6.Length);
		chromeOptions.AddArgument("--user-agent=" + this.string_6[num]);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
		chromeOptions.AddArgument("--disable-images");
		chromeOptions.AddArgument("--disable-extensions");
		chromeOptions.AddArgument("--disable-webgl");
		chromeOptions.AddArgument("--disable-dev-shm-usage");
		chromeOptions.AddArgument("--no-sandbox");
		if (this.cbstory1.Checked)
		{
			chromeOptions.AddArguments(new string[]
			{
				"--headless"
			});
		}
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		@class.iwebDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		@class.iwebDriver_0.Manage().Window.Size = new Size(1000, 840);
		@class.iwebDriver_0.Manage().Window.Position = new Point(0, 150);
		@class.method_3("Đã mở chrome");
		@class.int_0 = 0;
		@class.int_1 = 0;
		IL_1F3:
		while (this.button2k.Text != "START")
		{
			int num2 = 0;
			int num3 = 0;
			try
			{
				@class.iwebDriver_0.Url = "https://dkmh.hcmute.edu.vn";
				@class.iwebDriver_0.Navigate();
				num3 = 1;
			}
			catch
			{
			}
			if (num3 == 1)
			{
				int num4 = 0;
				int i = 1;
				while (i < 10)
				{
					@class.method_4();
					@class.method_0();
					try
					{
						if (num4 == 0)
						{
							IWebElement webElement = @class.iwebDriver_0.FindElement(By.XPath("//span[.='\u00a0Đăng nhập với Google']"));
							if (webElement != null)
							{
								webElement.Click();
								i = 1;
								Thread.Sleep(1000);
								string currentWindowHandle = @class.iwebDriver_0.CurrentWindowHandle;
								List<string> list = new List<string>(@class.iwebDriver_0.WindowHandles);
								foreach (string text6 in list)
								{
									if (text6 != currentWindowHandle)
									{
										@class.iwebDriver_0.SwitchTo().Window(text6);
										break;
									}
								}
								for (int j = 1; j < 20; j++)
								{
									@class.method_4();
									@class.method_0();
									try
									{
										IWebElement webElement2 = @class.iwebDriver_0.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div/div[1]/div/div[1]"));
										webElement2.Click();
										@class.iwebDriver_0.SwitchTo().Window(currentWindowHandle);
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("//div[@class='scrollbar-container ps']"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("(//img[@alt='Vietnamese'])[1]"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					@class.method_4();
					@class.method_0();
					i++;
					continue;
				}
			}
			if (num2 == 1)
			{
				for (int k = 1; k < 4; k++)
				{
					try
					{
						@class.method_4();
						@class.method_0();
						string pageSource = @class.iwebDriver_0.PageSource;
						if (pageSource.Contains(this.string_2))
						{
							@class.int_1 = 0;
							break;
						}
						@class.int_1++;
						ThreadStart start;
						if ((start = @class.threadStart_0) == null)
						{
							start = (@class.threadStart_0 = new ThreadStart(@class.method_1));
						}
						Thread thread = new Thread(start);
						thread.Start();
						if (@class.int_1 == 5)
						{
							Environment.Exit(0);
						}
					}
					catch
					{
					}
				}
				int num5 = 0;
				int l = 1;
				while (l < 10)
				{
					if (!this.KH2.Checked)
					{
						@class.method_3("Tìm đăng ký ngoài KH " + l.ToString());
						@class.method_4();
						@class.method_0();
						try
						{
							IWebElement webElement3 = @class.iwebDriver_0.FindElement(By.XPath("//span[contains(text(),'Đăng ký ngoài kế hoạch')]"));
							webElement3.Click();
							num5 = 1;
							break;
						}
						catch
						{
						}
						l++;
						continue;
					}
					num5 = 1;
					if (this.CN2.Checked)
					{
						for (int m = 1; m < 10; m++)
						{
							@class.method_4();
							@class.method_0();
							try
							{
								IWebElement webElement4 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + str + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
								webElement4.Click();
								@class.method_3("Chuyển nhóm lần " + m.ToString());
								Thread.Sleep(1000);
								num5 = 2;
								break;
							}
							catch
							{
							}
						}
					}
					else if (num5 == 1)
					{
						for (int n = 1; n < 10; n++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Môn lần thứ " + n.ToString());
							try
							{
								IWebElement webElement5 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[2]"));
								webElement5.Click();
								num5 = 2;
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement6 = @class.iwebDriver_0.FindElement(By.XPath("//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')]"));
									webElement6.Click();
									num5 = 2;
									break;
								}
								catch
								{
									try
									{
										IWebElement webElement7 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[1]"));
										webElement7.Click();
										num5 = 2;
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 2)
					{
						int num6 = 0;
						for (int num7 = 1; num7 < 10; num7++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Lớp lần thứ " + num7.ToString());
							try
							{
								if (text3 == "")
								{
									text3 = "werwerwerfgf";
								}
								IWebElement webElement8 = @class.iwebDriver_0.FindElement(By.XPath("//td[normalize-space()='" + text4 + "']/preceding-sibling::td/span"));
								webElement8.Click();
								num5 = 3;
								@class.method_3("Chọn lớp thành công");
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement9 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'" + text3 + "')]/preceding-sibling::td/span"));
									webElement9.Click();
									@class.method_3("Chọn lớp thành công");
									num5 = 3;
									break;
								}
								catch
								{
									int num8 = 0;
									int num9 = 1;
									while (num9 < 10)
									{
										@class.method_3("    Tìm Lớp lần thứ " + (num7 + 1).ToString());
										try
										{
											IWebElement webElement10 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(),'{0}')])[{1}]/following-sibling::td[1]", arg, num9)));
											string text7 = webElement10.Text;
											if (text7 == "")
											{
												num8 = num9;
											}
											goto IL_7BF;
										}
										catch
										{
											goto IL_7BF;
										}
										IL_7B4:
										num9++;
										continue;
										IL_775:
										try
										{
											IWebElement webElement11 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(), '{0}')]/following-sibling::td[contains(text(), ' ')]/preceding-sibling::td/span)[{1}]", arg, num8)));
											webElement11.Click();
											@class.method_3("Chọn lớp thành công");
											num5 = 3;
											break;
										}
										catch
										{
										}
										goto IL_7B4;
										IL_7BF:
										if (num8 != 0)
										{
											goto IL_775;
										}
										goto IL_7B4;
									}
								}
								try
								{
									IWebElement webElement12 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'Không tìm')]"));
									if (webElement12 != null)
									{
										@class.method_3("Không có lớp học phần nào ");
										break;
									}
								}
								catch
								{
									try
									{
										IWebElement webElement13 = @class.iwebDriver_0.FindElement(By.XPath("(//tbody)[1]//tr[1]//td[2]"));
										if (webElement13 != null)
										{
											@class.method_3("Không tìm thấy lớp lần thứ " + num6.ToString());
											num6++;
											if (num6 == 10)
											{
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 3)
					{
						int num10 = 1;
						while (num10 < 10)
						{
							int num11 = 0;
							@class.method_4();
							@class.method_0();
							try
							{
								@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
								IWebElement webElement14 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Đăng ký']"));
								webElement14.Click();
								num11 = 1;
								goto IL_9FA;
							}
							catch
							{
								try
								{
									@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
									IWebElement webElement15 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Chuyển nhóm']"));
									webElement15.Click();
									num11 = 1;
								}
								catch
								{
								}
								goto IL_9FA;
							}
							IL_9E5:
							int num12;
							if (num12 != 0)
							{
								num10++;
								continue;
							}
							break;
							IL_8FF:
							for (int num13 = 1; num13 < 7; num13++)
							{
								@class.method_4();
								@class.method_0();
								@class.method_3("Check Đăng ký thành công" + num13.ToString());
								try
								{
									IWebElement webElement16 = @class.iwebDriver_0.FindElement(By.XPath("//div[contains(text(),'" + text3 + "')]"));
									if (webElement16 != null)
									{
										@class.method_2(text4);
										@class.method_3("Đăng ký thành công !!!");
										num12 = 1;
										@class.iwebDriver_0.Quit();
										break;
									}
								}
								catch
								{
									try
									{
										if (num13 > 4)
										{
											IWebElement webElement17 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + text4 + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
											if (webElement17 != null)
											{
												@class.method_2(text4);
												@class.method_3("Đăng ký thành công !!!");
												num12 = 1;
												@class.iwebDriver_0.Quit();
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
							goto IL_9E5;
							IL_9FA:
							num12 = 0;
							if (num11 == 1)
							{
								goto IL_8FF;
							}
							goto IL_9E5;
						}
						goto IL_1F3;
					}
					goto IL_1F3;
				}
			}
		}
	}

		private void method_3()
	{
		Form1.Class8 @class = new Form1.Class8();
		@class.form1_0 = this;
		string text = this.namegv3.Text;
		string text2 = this.date3.Text;
		string arg = text.Trim();
		string text3 = text2.Trim();
		string text4 = this.textBox3k.Text;
		string text5 = text4.Replace(" ", string.Empty);
		text5 = text5.Replace("\t", "");
		string[] array = text5.Split(new char[]
		{
			'_'
		});
		string str = array[0];
		if (!text4.Contains("_"))
		{
			MessageBox.Show(" Mã lớp sai ,cập nhật mới là mã lớp không phải mã môn ");
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments(new string[]
		{
			"user-data-dir=" + this.string_5 + "\\Profile3"
		});
		int num = this.random_0.Next(0, this.string_6.Length);
		chromeOptions.AddArgument("--user-agent=" + this.string_6[num]);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
		chromeOptions.AddArgument("--disable-images");
		chromeOptions.AddArgument("--disable-extensions");
		chromeOptions.AddArgument("--disable-webgl");
		chromeOptions.AddArgument("--disable-dev-shm-usage");
		chromeOptions.AddArgument("--no-sandbox");
		if (this.cbstory1.Checked)
		{
			chromeOptions.AddArguments(new string[]
			{
				"--headless"
			});
		}
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		@class.iwebDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		@class.iwebDriver_0.Manage().Window.Size = new Size(1000, 840);
		@class.iwebDriver_0.Manage().Window.Position = new Point(0, 300);
		@class.method_3("Đã mở chrome");
		@class.int_0 = 0;
		@class.int_1 = 0;
		IL_1F3:
		while (this.button3k.Text != "START")
		{
			int num2 = 0;
			int num3 = 0;
			try
			{
				@class.iwebDriver_0.Url = "https://dkmh.hcmute.edu.vn";
				@class.iwebDriver_0.Navigate();
				num3 = 1;
			}
			catch
			{
			}
			if (num3 == 1)
			{
				int num4 = 0;
				int i = 1;
				while (i < 10)
				{
					@class.method_4();
					@class.method_0();
					try
					{
						if (num4 == 0)
						{
							IWebElement webElement = @class.iwebDriver_0.FindElement(By.XPath("//span[.='\u00a0Đăng nhập với Google']"));
							if (webElement != null)
							{
								webElement.Click();
								i = 1;
								Thread.Sleep(1000);
								string currentWindowHandle = @class.iwebDriver_0.CurrentWindowHandle;
								List<string> list = new List<string>(@class.iwebDriver_0.WindowHandles);
								foreach (string text6 in list)
								{
									if (text6 != currentWindowHandle)
									{
										@class.iwebDriver_0.SwitchTo().Window(text6);
										break;
									}
								}
								for (int j = 1; j < 20; j++)
								{
									@class.method_4();
									@class.method_0();
									try
									{
										IWebElement webElement2 = @class.iwebDriver_0.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div/div[1]/div/div[1]"));
										webElement2.Click();
										@class.iwebDriver_0.SwitchTo().Window(currentWindowHandle);
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("//div[@class='scrollbar-container ps']"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("(//img[@alt='Vietnamese'])[1]"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					@class.method_4();
					@class.method_0();
					i++;
					continue;
				}
			}
			if (num2 == 1)
			{
				for (int k = 1; k < 4; k++)
				{
					try
					{
						@class.method_4();
						@class.method_0();
						string pageSource = @class.iwebDriver_0.PageSource;
						if (pageSource.Contains(this.string_2))
						{
							@class.int_1 = 0;
							break;
						}
						@class.int_1++;
						ThreadStart start;
						if ((start = @class.threadStart_0) == null)
						{
							start = (@class.threadStart_0 = new ThreadStart(@class.method_1));
						}
						Thread thread = new Thread(start);
						thread.Start();
						if (@class.int_1 == 5)
						{
							Environment.Exit(0);
						}
					}
					catch
					{
					}
				}
				int num5 = 0;
				int l = 1;
				while (l < 10)
				{
					if (!this.KH3.Checked)
					{
						@class.method_3("Tìm đăng ký ngoài KH " + l.ToString());
						@class.method_4();
						@class.method_0();
						try
						{
							IWebElement webElement3 = @class.iwebDriver_0.FindElement(By.XPath("//span[contains(text(),'Đăng ký ngoài kế hoạch')]"));
							webElement3.Click();
							num5 = 1;
							break;
						}
						catch
						{
						}
						l++;
						continue;
					}
					num5 = 1;
					if (this.CN3.Checked)
					{
						for (int m = 1; m < 10; m++)
						{
							@class.method_4();
							@class.method_0();
							try
							{
								IWebElement webElement4 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + str + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
								webElement4.Click();
								@class.method_3("Chuyển nhóm lần " + m.ToString());
								Thread.Sleep(1000);
								num5 = 2;
								break;
							}
							catch
							{
							}
						}
					}
					else if (num5 == 1)
					{
						for (int n = 1; n < 10; n++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Môn lần thứ " + n.ToString());
							try
							{
								IWebElement webElement5 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[2]"));
								webElement5.Click();
								num5 = 2;
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement6 = @class.iwebDriver_0.FindElement(By.XPath("//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')]"));
									webElement6.Click();
									num5 = 2;
									break;
								}
								catch
								{
									try
									{
										IWebElement webElement7 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[1]"));
										webElement7.Click();
										num5 = 2;
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 2)
					{
						int num6 = 0;
						for (int num7 = 1; num7 < 10; num7++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Lớp lần thứ " + num7.ToString());
							try
							{
								if (text3 == "")
								{
									text3 = "werwerwerfgf";
								}
								IWebElement webElement8 = @class.iwebDriver_0.FindElement(By.XPath("//td[normalize-space()='" + text4 + "']/preceding-sibling::td/span"));
								webElement8.Click();
								num5 = 3;
								@class.method_3("Chọn lớp thành công");
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement9 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'" + text3 + "')]/preceding-sibling::td/span"));
									webElement9.Click();
									@class.method_3("Chọn lớp thành công");
									num5 = 3;
									break;
								}
								catch
								{
									int num8 = 0;
									int num9 = 1;
									while (num9 < 10)
									{
										@class.method_3("    Tìm Lớp lần thứ " + (num7 + 1).ToString());
										try
										{
											IWebElement webElement10 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(),'{0}')])[{1}]/following-sibling::td[1]", arg, num9)));
											string text7 = webElement10.Text;
											if (text7 == "")
											{
												num8 = num9;
											}
											goto IL_7BF;
										}
										catch
										{
											goto IL_7BF;
										}
										IL_7B4:
										num9++;
										continue;
										IL_775:
										try
										{
											IWebElement webElement11 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(), '{0}')]/following-sibling::td[contains(text(), ' ')]/preceding-sibling::td/span)[{1}]", arg, num8)));
											webElement11.Click();
											@class.method_3("Chọn lớp thành công");
											num5 = 3;
											break;
										}
										catch
										{
										}
										goto IL_7B4;
										IL_7BF:
										if (num8 != 0)
										{
											goto IL_775;
										}
										goto IL_7B4;
									}
								}
								try
								{
									IWebElement webElement12 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'Không tìm')]"));
									if (webElement12 != null)
									{
										@class.method_3("Không có lớp học phần nào ");
										break;
									}
								}
								catch
								{
									try
									{
										IWebElement webElement13 = @class.iwebDriver_0.FindElement(By.XPath("(//tbody)[1]//tr[1]//td[2]"));
										if (webElement13 != null)
										{
											@class.method_3("Không tìm thấy lớp lần thứ " + num6.ToString());
											num6++;
											if (num6 == 10)
											{
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 3)
					{
						int num10 = 1;
						while (num10 < 10)
						{
							int num11 = 0;
							@class.method_4();
							@class.method_0();
							try
							{
								@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
								IWebElement webElement14 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Đăng ký']"));
								webElement14.Click();
								num11 = 1;
								goto IL_9FA;
							}
							catch
							{
								try
								{
									@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
									IWebElement webElement15 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Chuyển nhóm']"));
									webElement15.Click();
									num11 = 1;
								}
								catch
								{
								}
								goto IL_9FA;
							}
							IL_9E5:
							int num12;
							if (num12 != 0)
							{
								num10++;
								continue;
							}
							break;
							IL_8FF:
							for (int num13 = 1; num13 < 7; num13++)
							{
								@class.method_4();
								@class.method_0();
								@class.method_3("Check Đăng ký thành công" + num13.ToString());
								try
								{
									IWebElement webElement16 = @class.iwebDriver_0.FindElement(By.XPath("//div[contains(text(),'" + text3 + "')]"));
									if (webElement16 != null)
									{
										@class.method_2(text4);
										@class.method_3("Đăng ký thành công !!!");
										num12 = 1;
										@class.iwebDriver_0.Quit();
										break;
									}
								}
								catch
								{
									try
									{
										if (num13 > 4)
										{
											IWebElement webElement17 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + text4 + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
											if (webElement17 != null)
											{
												@class.method_2(text4);
												@class.method_3("Đăng ký thành công !!!");
												num12 = 1;
												@class.iwebDriver_0.Quit();
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
							goto IL_9E5;
							IL_9FA:
							num12 = 0;
							if (num11 == 1)
							{
								goto IL_8FF;
							}
							goto IL_9E5;
						}
						goto IL_1F3;
					}
					goto IL_1F3;
				}
			}
		}
	}

		private void method_4()
	{
		Form1.Class9 @class = new Form1.Class9();
		@class.form1_0 = this;
		string text = this.namegv4.Text;
		string text2 = this.date4.Text;
		string arg = text.Trim();
		string text3 = text2.Trim();
		string text4 = this.textBox4k.Text;
		string text5 = text4.Replace(" ", string.Empty);
		text5 = text5.Replace("\t", "");
		string[] array = text5.Split(new char[]
		{
			'_'
		});
		string str = array[0];
		if (!text4.Contains("_"))
		{
			MessageBox.Show(" Mã lớp sai ,cập nhật mới là mã lớp không phải mã môn ");
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments(new string[]
		{
			"user-data-dir=" + this.string_5 + "\\Profile4"
		});
		int num = this.random_0.Next(0, this.string_6.Length);
		chromeOptions.AddArgument("--user-agent=" + this.string_6[num]);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
		chromeOptions.AddArgument("--disable-images");
		chromeOptions.AddArgument("--disable-extensions");
		chromeOptions.AddArgument("--disable-webgl");
		chromeOptions.AddArgument("--disable-dev-shm-usage");
		chromeOptions.AddArgument("--no-sandbox");
		if (this.cbstory1.Checked)
		{
			chromeOptions.AddArguments(new string[]
			{
				"--headless"
			});
		}
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		@class.iwebDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		@class.iwebDriver_0.Manage().Window.Size = new Size(1000, 840);
		@class.iwebDriver_0.Manage().Window.Position = new Point(1000, 0);
		@class.method_3("Đã mở chrome");
		@class.int_0 = 0;
		@class.int_1 = 0;
		IL_1F3:
		while (this.button4k.Text != "START")
		{
			int num2 = 0;
			int num3 = 0;
			try
			{
				@class.iwebDriver_0.Url = "https://dkmh.hcmute.edu.vn";
				@class.iwebDriver_0.Navigate();
				num3 = 1;
			}
			catch
			{
			}
			if (num3 == 1)
			{
				int num4 = 0;
				int i = 1;
				while (i < 10)
				{
					@class.method_4();
					@class.method_0();
					try
					{
						if (num4 == 0)
						{
							IWebElement webElement = @class.iwebDriver_0.FindElement(By.XPath("//span[.='\u00a0Đăng nhập với Google']"));
							if (webElement != null)
							{
								webElement.Click();
								i = 1;
								Thread.Sleep(1000);
								string currentWindowHandle = @class.iwebDriver_0.CurrentWindowHandle;
								List<string> list = new List<string>(@class.iwebDriver_0.WindowHandles);
								foreach (string text6 in list)
								{
									if (text6 != currentWindowHandle)
									{
										@class.iwebDriver_0.SwitchTo().Window(text6);
										break;
									}
								}
								for (int j = 1; j < 20; j++)
								{
									@class.method_4();
									@class.method_0();
									try
									{
										IWebElement webElement2 = @class.iwebDriver_0.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div/div[1]/div/div[1]"));
										webElement2.Click();
										@class.iwebDriver_0.SwitchTo().Window(currentWindowHandle);
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("//div[@class='scrollbar-container ps']"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("(//img[@alt='Vietnamese'])[1]"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					@class.method_4();
					@class.method_0();
					i++;
					continue;
				}
			}
			if (num2 == 1)
			{
				for (int k = 1; k < 4; k++)
				{
					try
					{
						@class.method_4();
						@class.method_0();
						string pageSource = @class.iwebDriver_0.PageSource;
						if (pageSource.Contains(this.string_2))
						{
							@class.int_1 = 0;
							break;
						}
						@class.int_1++;
						ThreadStart start;
						if ((start = @class.threadStart_0) == null)
						{
							start = (@class.threadStart_0 = new ThreadStart(@class.method_1));
						}
						Thread thread = new Thread(start);
						thread.Start();
						if (@class.int_1 == 5)
						{
							Environment.Exit(0);
						}
					}
					catch
					{
					}
				}
				int num5 = 0;
				int l = 1;
				while (l < 10)
				{
					if (!this.KH4.Checked)
					{
						@class.method_3("Tìm đăng ký ngoài KH " + l.ToString());
						@class.method_4();
						@class.method_0();
						try
						{
							IWebElement webElement3 = @class.iwebDriver_0.FindElement(By.XPath("//span[contains(text(),'Đăng ký ngoài kế hoạch')]"));
							webElement3.Click();
							num5 = 1;
							break;
						}
						catch
						{
						}
						l++;
						continue;
					}
					num5 = 1;
					if (this.CN4.Checked)
					{
						for (int m = 1; m < 10; m++)
						{
							@class.method_4();
							@class.method_0();
							try
							{
								IWebElement webElement4 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + str + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
								webElement4.Click();
								@class.method_3("Chuyển nhóm lần " + m.ToString());
								Thread.Sleep(1000);
								num5 = 2;
								break;
							}
							catch
							{
							}
						}
					}
					else if (num5 == 1)
					{
						for (int n = 1; n < 10; n++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Môn lần thứ " + n.ToString());
							try
							{
								IWebElement webElement5 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[2]"));
								webElement5.Click();
								num5 = 2;
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement6 = @class.iwebDriver_0.FindElement(By.XPath("//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')]"));
									webElement6.Click();
									num5 = 2;
									break;
								}
								catch
								{
									try
									{
										IWebElement webElement7 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[1]"));
										webElement7.Click();
										num5 = 2;
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 2)
					{
						int num6 = 0;
						for (int num7 = 1; num7 < 10; num7++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Lớp lần thứ " + num7.ToString());
							try
							{
								if (text3 == "")
								{
									text3 = "werwerwerfgf";
								}
								IWebElement webElement8 = @class.iwebDriver_0.FindElement(By.XPath("//td[normalize-space()='" + text4 + "']/preceding-sibling::td/span"));
								webElement8.Click();
								num5 = 3;
								@class.method_3("Chọn lớp thành công");
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement9 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'" + text3 + "')]/preceding-sibling::td/span"));
									webElement9.Click();
									@class.method_3("Chọn lớp thành công");
									num5 = 3;
									break;
								}
								catch
								{
									int num8 = 0;
									int num9 = 1;
									while (num9 < 10)
									{
										@class.method_3("    Tìm Lớp lần thứ " + (num7 + 1).ToString());
										try
										{
											IWebElement webElement10 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(),'{0}')])[{1}]/following-sibling::td[1]", arg, num9)));
											string text7 = webElement10.Text;
											if (text7 == "")
											{
												num8 = num9;
											}
											goto IL_7BF;
										}
										catch
										{
											goto IL_7BF;
										}
										IL_775:
										try
										{
											IWebElement webElement11 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(), '{0}')]/following-sibling::td[contains(text(), ' ')]/preceding-sibling::td/span)[{1}]", arg, num8)));
											webElement11.Click();
											@class.method_3("Chọn lớp thành công");
											num5 = 3;
											break;
										}
										catch
										{
										}
										IL_7BF:
										if (num8 != 0)
										{
											goto IL_775;
										}
									}
								}
								try
								{
									IWebElement webElement12 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'Không tìm')]"));
									if (webElement12 != null)
									{
										@class.method_3("Không có lớp học phần nào ");
										break;
									}
								}
								catch
								{
									try
									{
										IWebElement webElement13 = @class.iwebDriver_0.FindElement(By.XPath("(//tbody)[1]//tr[1]//td[2]"));
										if (webElement13 != null)
										{
											@class.method_3("Không tìm thấy lớp lần thứ " + num6.ToString());
											num6++;
											if (num6 == 10)
											{
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 3)
					{
						int num10 = 1;
						while (num10 < 10)
						{
							int num11 = 0;
							@class.method_4();
							@class.method_0();
							try
							{
								@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
								IWebElement webElement14 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Đăng ký']"));
								webElement14.Click();
								num11 = 1;
								goto IL_9FA;
							}
							catch
							{
								try
								{
									@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
									IWebElement webElement15 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Chuyển nhóm']"));
									webElement15.Click();
									num11 = 1;
								}
								catch
								{
								}
								goto IL_9FA;
							}
							IL_9E5:
							int num12;
							if (num12 != 0)
							{
								num10++;
								continue;
							}
							break;
							IL_8FF:
							for (int num13 = 1; num13 < 7; num13++)
							{
								@class.method_4();
								@class.method_0();
								@class.method_3("Check Đăng ký thành công" + num13.ToString());
								try
								{
									IWebElement webElement16 = @class.iwebDriver_0.FindElement(By.XPath("//div[contains(text(),'" + text3 + "')]"));
									if (webElement16 != null)
									{
										@class.method_2(text4);
										@class.method_3("Đăng ký thành công !!!");
										num12 = 1;
										@class.iwebDriver_0.Quit();
										break;
									}
								}
								catch
								{
									try
									{
										if (num13 > 4)
										{
											IWebElement webElement17 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + text4 + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
											if (webElement17 != null)
											{
												@class.method_2(text4);
												@class.method_3("Đăng ký thành công !!!");
												num12 = 1;
												@class.iwebDriver_0.Quit();
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
							goto IL_9E5;
							IL_9FA:
							num12 = 0;
							if (num11 == 1)
							{
								goto IL_8FF;
							}
							goto IL_9E5;
						}
						goto IL_1F3;
					}
					goto IL_1F3;
				}
			}
		}
	}

	private void method_5()
	{
		Form1.Class10 @class = new Form1.Class10();
		@class.form1_0 = this;
		string text = this.namegv5.Text;
		string text2 = this.date5.Text;
		string arg = text.Trim();
		string text3 = text2.Trim();
		string text4 = this.textBox5k.Text;
		string text5 = text4.Replace(" ", string.Empty);
		text5 = text5.Replace("\t", "");
		string[] array = text5.Split(new char[]
		{
			'_'
		});
		string str = array[0];
		if (!text4.Contains("_"))
		{
			MessageBox.Show(" Mã lớp sai ,cập nhật mới là mã lớp không phải mã môn ");
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments(new string[]
		{
			"user-data-dir=" + this.string_5 + "\\Profile5"
		});
		int num = this.random_0.Next(0, this.string_6.Length);
		chromeOptions.AddArgument("--user-agent=" + this.string_6[num]);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
		chromeOptions.AddArgument("--disable-images");
		chromeOptions.AddArgument("--disable-extensions");
		chromeOptions.AddArgument("--disable-webgl");
		chromeOptions.AddArgument("--disable-dev-shm-usage");
		chromeOptions.AddArgument("--no-sandbox");
		if (this.cbstory1.Checked)
		{
			chromeOptions.AddArguments(new string[]
			{
				"--headless"
			});
		}
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		@class.iwebDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		@class.iwebDriver_0.Manage().Window.Size = new Size(1000, 840);
		@class.iwebDriver_0.Manage().Window.Position = new Point(1000, 150);
		@class.method_3("Đã mở chrome");
		@class.int_0 = 0;
		@class.int_1 = 0;
		IL_1F7:
		while (this.button5k.Text != "START")
		{
			int num2 = 0;
			int num3 = 0;
			try
			{
				@class.iwebDriver_0.Url = "https://dkmh.hcmute.edu.vn";
				@class.iwebDriver_0.Navigate();
				num3 = 1;
			}
			catch
			{
			}
			if (num3 == 1)
			{
				int num4 = 0;
				int i = 1;
				while (i < 10)
				{
					@class.method_4();
					@class.method_0();
					try
					{
						if (num4 == 0)
						{
							IWebElement webElement = @class.iwebDriver_0.FindElement(By.XPath("//span[.='\u00a0Đăng nhập với Google']"));
							if (webElement != null)
							{
								webElement.Click();
								i = 1;
								Thread.Sleep(1000);
								string currentWindowHandle = @class.iwebDriver_0.CurrentWindowHandle;
								List<string> list = new List<string>(@class.iwebDriver_0.WindowHandles);
								foreach (string text6 in list)
								{
									if (text6 != currentWindowHandle)
									{
										@class.iwebDriver_0.SwitchTo().Window(text6);
										break;
									}
								}
								for (int j = 1; j < 20; j++)
								{
									@class.method_4();
									@class.method_0();
									try
									{
										IWebElement webElement2 = @class.iwebDriver_0.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div/div[1]/div/div[1]"));
										webElement2.Click();
										@class.iwebDriver_0.SwitchTo().Window(currentWindowHandle);
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("//div[@class='scrollbar-container ps']"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("(//img[@alt='Vietnamese'])[1]"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					@class.method_4();
					@class.method_0();
					i++;
					continue;
				}
			}
			if (num2 == 1)
			{
				for (int k = 1; k < 4; k++)
				{
					try
					{
						@class.method_4();
						@class.method_0();
						string pageSource = @class.iwebDriver_0.PageSource;
						if (pageSource.Contains(this.string_2))
						{
							@class.int_1 = 0;
							break;
						}
						@class.int_1++;
						ThreadStart start;
						if ((start = @class.threadStart_0) == null)
						{
							start = (@class.threadStart_0 = new ThreadStart(@class.method_1));
						}
						Thread thread = new Thread(start);
						thread.Start();
						if (@class.int_1 == 5)
						{
							Environment.Exit(0);
						}
					}
					catch
					{
					}
				}
				int num5 = 0;
				int l = 1;
				while (l < 10)
				{
					if (!this.KH5.Checked)
					{
						@class.method_3("Tìm đăng ký ngoài KH " + l.ToString());
						@class.method_4();
						@class.method_0();
						try
						{
							IWebElement webElement3 = @class.iwebDriver_0.FindElement(By.XPath("//span[contains(text(),'Đăng ký ngoài kế hoạch')]"));
							webElement3.Click();
							num5 = 1;
							break;
						}
						catch
						{
						}
						l++;
						continue;
					}
					num5 = 1;
					if (this.CN5.Checked)
					{
						for (int m = 1; m < 10; m++)
						{
							@class.method_4();
							@class.method_0();
							try
							{
								IWebElement webElement4 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + str + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
								webElement4.Click();
								@class.method_3("Chuyển nhóm lần " + m.ToString());
								Thread.Sleep(1000);
								num5 = 2;
								break;
							}
							catch
							{
							}
						}
					}
					else if (num5 == 1)
					{
						for (int n = 1; n < 10; n++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Môn lần thứ " + n.ToString());
							try
							{
								IWebElement webElement5 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[2]"));
								webElement5.Click();
								num5 = 2;
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement6 = @class.iwebDriver_0.FindElement(By.XPath("//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')]"));
									webElement6.Click();
									num5 = 2;
									break;
								}
								catch
								{
									try
									{
										IWebElement webElement7 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[1]"));
										webElement7.Click();
										num5 = 2;
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 2)
					{
						int num6 = 0;
						for (int num7 = 1; num7 < 10; num7++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Lớp lần thứ " + num7.ToString());
							try
							{
								if (text3 == "")
								{
									text3 = "werwerwerfgf";
								}
								IWebElement webElement8 = @class.iwebDriver_0.FindElement(By.XPath("//td[normalize-space()='" + text4 + "']/preceding-sibling::td/span"));
								webElement8.Click();
								num5 = 3;
								@class.method_3("Chọn lớp thành công");
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement9 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'" + text3 + "')]/preceding-sibling::td/span"));
									webElement9.Click();
									@class.method_3("Chọn lớp thành công");
									num5 = 3;
									break;
								}
								catch
								{
									int num8 = 0;
									int num9 = 1;
									while (num9 < 10)
									{
										@class.method_3("    Tìm Lớp lần thứ " + (num7 + 1).ToString());
										try
										{
											IWebElement webElement10 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(),'{0}')])[{1}]/following-sibling::td[1]", arg, num9)));
											string text7 = webElement10.Text;
											if (text7 == "")
											{
												num8 = num9;
											}
											goto IL_7C3;
										}
										catch
										{
											goto IL_7C3;
										}
										IL_7B8:
										num9++;
										continue;
										IL_779:
										try
										{
											IWebElement webElement11 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(), '{0}')]/following-sibling::td[contains(text(), ' ')]/preceding-sibling::td/span)[{1}]", arg, num8)));
											webElement11.Click();
											@class.method_3("Chọn lớp thành công");
											num5 = 3;
											break;
										}
										catch
										{
										}
										goto IL_7B8;
										IL_7C3:
										if (num8 != 0)
										{
											goto IL_779;
										}
										goto IL_7B8;
									}
								}
								try
								{
									IWebElement webElement12 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'Không tìm')]"));
									if (webElement12 != null)
									{
										@class.method_3("Không có lớp học phần nào ");
										break;
									}
								}
								catch
								{
									try
									{
										IWebElement webElement13 = @class.iwebDriver_0.FindElement(By.XPath("(//tbody)[1]//tr[1]//td[2]"));
										if (webElement13 != null)
										{
											@class.method_3("Không tìm thấy lớp lần thứ " + num6.ToString());
											num6++;
											if (num6 == 10)
											{
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 3)
					{
						int num10 = 1;
						while (num10 < 10)
						{
							int num11 = 0;
							@class.method_4();
							@class.method_0();
							try
							{
								@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
								IWebElement webElement14 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Đăng ký']"));
								webElement14.Click();
								num11 = 1;
								goto IL_9FE;
							}
							catch
							{
								try
								{
									@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
									IWebElement webElement15 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Chuyển nhóm']"));
									webElement15.Click();
									num11 = 1;
								}
								catch
								{
								}
								goto IL_9FE;
							}
							IL_9E9:
							int num12;
							if (num12 != 0)
							{
								num10++;
								continue;
							}
							break;
							IL_903:
							for (int num13 = 1; num13 < 7; num13++)
							{
								@class.method_4();
								@class.method_0();
								@class.method_3("Check Đăng ký thành công" + num13.ToString());
								try
								{
									IWebElement webElement16 = @class.iwebDriver_0.FindElement(By.XPath("//div[contains(text(),'" + text3 + "')]"));
									if (webElement16 != null)
									{
										@class.method_2(text4);
										@class.method_3("Đăng ký thành công !!!");
										num12 = 1;
										@class.iwebDriver_0.Quit();
										break;
									}
								}
								catch
								{
									try
									{
										if (num13 > 4)
										{
											IWebElement webElement17 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + text4 + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
											if (webElement17 != null)
											{
												@class.method_2(text4);
												@class.method_3("Đăng ký thành công !!!");
												num12 = 1;
												@class.iwebDriver_0.Quit();
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
							goto IL_9E9;
							IL_9FE:
							num12 = 0;
							if (num11 == 1)
							{
								goto IL_903;
							}
							goto IL_9E9;
						}
						goto IL_1F7;
					}
					goto IL_1F7;
				}
			}
		}
	}

		private void method_6()
	{
		Form1.Class11 @class = new Form1.Class11();
		@class.form1_0 = this;
		string text = this.namegv6.Text;
		string text2 = this.date6.Text;
		string arg = text.Trim();
		string text3 = text2.Trim();
		string text4 = this.textBox6k.Text;
		string text5 = text4.Replace(" ", string.Empty);
		text5 = text5.Replace("\t", "");
		string[] array = text5.Split(new char[]
		{
			'_'
		});
		string str = array[0];
		if (!text4.Contains("_"))
		{
			MessageBox.Show(" Mã lớp sai ,cập nhật mới là mã lớp không phải mã môn ");
		}
		ChromeOptions chromeOptions = new ChromeOptions();
		chromeOptions.AddArguments(new string[]
		{
			"user-data-dir=" + this.string_5 + "\\Profile6"
		});
		int num = this.random_0.Next(0, this.string_6.Length);
		chromeOptions.AddArgument("--user-agent=" + this.string_6[num]);
		chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
		chromeOptions.AddUserProfilePreference("profile.managed_default_content_settings.stylesheets", 2);
		chromeOptions.AddArgument("--disable-images");
		chromeOptions.AddArgument("--disable-extensions");
		chromeOptions.AddArgument("--disable-webgl");
		chromeOptions.AddArgument("--disable-dev-shm-usage");
		chromeOptions.AddArgument("--no-sandbox");
		if (this.cbstory1.Checked)
		{
			chromeOptions.AddArguments(new string[]
			{
				"--headless"
			});
		}
		ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
		chromeDriverService.HideCommandPromptWindow = true;
		@class.iwebDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions);
		@class.iwebDriver_0.Manage().Window.Size = new Size(1000, 840);
		@class.iwebDriver_0.Manage().Window.Position = new Point(1000, 300);
		@class.method_3("Đã mở chrome");
		@class.int_0 = 0;
		@class.int_1 = 0;
		IL_1F7:
		while (this.button6k.Text != "START")
		{
			int num2 = 0;
			int num3 = 0;
			try
			{
				@class.iwebDriver_0.Url = "https://dkmh.hcmute.edu.vn";
				@class.iwebDriver_0.Navigate();
				num3 = 1;
			}
			catch
			{
			}
			if (num3 == 1)
			{
				int num4 = 0;
				int i = 1;
				while (i < 10)
				{
					@class.method_4();
					@class.method_0();
					try
					{
						if (num4 == 0)
						{
							IWebElement webElement = @class.iwebDriver_0.FindElement(By.XPath("//span[.='\u00a0Đăng nhập với Google']"));
							if (webElement != null)
							{
								webElement.Click();
								i = 1;
								Thread.Sleep(1000);
								string currentWindowHandle = @class.iwebDriver_0.CurrentWindowHandle;
								List<string> list = new List<string>(@class.iwebDriver_0.WindowHandles);
								foreach (string text6 in list)
								{
									if (text6 != currentWindowHandle)
									{
										@class.iwebDriver_0.SwitchTo().Window(text6);
										break;
									}
								}
								for (int j = 1; j < 20; j++)
								{
									@class.method_4();
									@class.method_0();
									try
									{
										IWebElement webElement2 = @class.iwebDriver_0.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div/div/ul/li[1]/div/div[1]/div/div[1]"));
										webElement2.Click();
										@class.iwebDriver_0.SwitchTo().Window(currentWindowHandle);
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("//div[@class='scrollbar-container ps']"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					try
					{
						@class.iwebDriver_0.FindElement(By.XPath("(//img[@alt='Vietnamese'])[1]"));
						num2 = 1;
						break;
					}
					catch
					{
					}
					@class.method_4();
					@class.method_0();
					i++;
					continue;
				}
			}
			if (num2 == 1)
			{
				for (int k = 1; k < 4; k++)
				{
					try
					{
						@class.method_4();
						@class.method_0();
						string pageSource = @class.iwebDriver_0.PageSource;
						if (pageSource.Contains(this.string_2))
						{
							@class.int_1 = 0;
							break;
						}
						@class.int_1++;
						ThreadStart start;
						if ((start = @class.threadStart_0) == null)
						{
							start = (@class.threadStart_0 = new ThreadStart(@class.method_1));
						}
						Thread thread = new Thread(start);
						thread.Start();
						if (@class.int_1 == 5)
						{
							Environment.Exit(0);
						}
					}
					catch
					{
					}
				}
				int num5 = 0;
				int l = 1;
				while (l < 10)
				{
					if (!this.KH6.Checked)
					{
						@class.method_3("Tìm đăng ký ngoài KH " + l.ToString());
						@class.method_4();
						@class.method_0();
						try
						{
							IWebElement webElement3 = @class.iwebDriver_0.FindElement(By.XPath("//span[contains(text(),'Đăng ký ngoài kế hoạch')]"));
							webElement3.Click();
							num5 = 1;
							break;
						}
						catch
						{
						}
						l++;
						continue;
					}
					num5 = 1;
					if (this.CN6.Checked)
					{
						for (int m = 1; m < 10; m++)
						{
							@class.method_4();
							@class.method_0();
							try
							{
								IWebElement webElement4 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + str + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
								webElement4.Click();
								@class.method_3("Chuyển nhóm lần " + m.ToString());
								Thread.Sleep(1000);
								num5 = 2;
								break;
							}
							catch
							{
							}
						}
					}
					else if (num5 == 1)
					{
						for (int n = 1; n < 10; n++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Môn lần thứ " + n.ToString());
							try
							{
								IWebElement webElement5 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[2]"));
								webElement5.Click();
								num5 = 2;
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement6 = @class.iwebDriver_0.FindElement(By.XPath("//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')]"));
									webElement6.Click();
									num5 = 2;
									break;
								}
								catch
								{
									try
									{
										IWebElement webElement7 = @class.iwebDriver_0.FindElement(By.XPath("(//td[text()='" + str + "']/following-sibling::td[.='Đăng ký']//span[contains(text(),'Đăng ký')])[1]"));
										webElement7.Click();
										num5 = 2;
										break;
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 2)
					{
						int num6 = 0;
						for (int num7 = 1; num7 < 10; num7++)
						{
							@class.method_4();
							@class.method_0();
							@class.method_3("Tìm Lớp lần thứ " + num7.ToString());
							try
							{
								if (text3 == "")
								{
									text3 = "werwerwerfgf";
								}
								IWebElement webElement8 = @class.iwebDriver_0.FindElement(By.XPath("//td[normalize-space()='" + text4 + "']/preceding-sibling::td/span"));
								webElement8.Click();
								num5 = 3;
								@class.method_3("Chọn lớp thành công");
								break;
							}
							catch
							{
								try
								{
									IWebElement webElement9 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'" + text3 + "')]/preceding-sibling::td/span"));
									webElement9.Click();
									@class.method_3("Chọn lớp thành công");
									num5 = 3;
									break;
								}
								catch
								{
									int num8 = 0;
									int num9 = 1;
									while (num9 < 10)
									{
										@class.method_3("    Tìm Lớp lần thứ " + (num7 + 1).ToString());
										try
										{
											IWebElement webElement10 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(),'{0}')])[{1}]/following-sibling::td[1]", arg, num9)));
											string text7 = webElement10.Text;
											if (text7 == "")
											{
												num8 = num9;
											}
											goto IL_7C3;
										}
										catch
										{
											goto IL_7C3;
										}
										IL_7B8:
										num9++;
										continue;
										IL_779:
										try
										{
											IWebElement webElement11 = @class.iwebDriver_0.FindElement(By.XPath(string.Format("(//td[contains(text(), '{0}')]/following-sibling::td[contains(text(), ' ')]/preceding-sibling::td/span)[{1}]", arg, num8)));
											webElement11.Click();
											@class.method_3("Chọn lớp thành công");
											num5 = 3;
											break;
										}
										catch
										{
										}
										goto IL_7B8;
										IL_7C3:
										if (num8 != 0)
										{
											goto IL_779;
										}
										goto IL_7B8;
									}
								}
								try
								{
									IWebElement webElement12 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(),'Không tìm')]"));
									if (webElement12 != null)
									{
										@class.method_3("Không có lớp học phần nào ");
										break;
									}
								}
								catch
								{
									try
									{
										IWebElement webElement13 = @class.iwebDriver_0.FindElement(By.XPath("(//tbody)[1]//tr[1]//td[2]"));
										if (webElement13 != null)
										{
											@class.method_3("Không tìm thấy lớp lần thứ " + num6.ToString());
											num6++;
											if (num6 == 10)
											{
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
						}
					}
					if (num5 == 3)
					{
						int num10 = 1;
						while (num10 < 10)
						{
							int num11 = 0;
							@class.method_4();
							@class.method_0();
							try
							{
								@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
								IWebElement webElement14 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Đăng ký']"));
								webElement14.Click();
								num11 = 1;
								goto IL_9FE;
							}
							catch
							{
								try
								{
									@class.method_3("Ấn đăng ký lần thứ " + num10.ToString());
									IWebElement webElement15 = @class.iwebDriver_0.FindElement(By.XPath("//span[.=' Chuyển nhóm']"));
									webElement15.Click();
									num11 = 1;
								}
								catch
								{
								}
								goto IL_9FE;
							}
							IL_9E9:
							int num12;
							if (num12 != 0)
							{
								num10++;
								continue;
							}
							break;
							IL_903:
							for (int num13 = 1; num13 < 7; num13++)
							{
								@class.method_4();
								@class.method_0();
								@class.method_3("Check Đăng ký thành công" + num13.ToString());
								try
								{
									IWebElement webElement16 = @class.iwebDriver_0.FindElement(By.XPath("//div[contains(text(),'" + text3 + "')]"));
									if (webElement16 != null)
									{
										@class.method_2(text4);
										@class.method_3("Đăng ký thành công !!!");
										num12 = 1;
										@class.iwebDriver_0.Quit();
										break;
									}
								}
								catch
								{
									try
									{
										if (num13 > 4)
										{
											IWebElement webElement17 = @class.iwebDriver_0.FindElement(By.XPath("//td[contains(text(), '" + text4 + "')]/following-sibling::td/div/button[1]/span[contains(., 'C.Nhóm')]"));
											if (webElement17 != null)
											{
												@class.method_2(text4);
												@class.method_3("Đăng ký thành công !!!");
												num12 = 1;
												@class.iwebDriver_0.Quit();
												break;
											}
										}
									}
									catch
									{
									}
								}
							}
							goto IL_9E9;
							IL_9FE:
							num12 = 0;
							if (num11 == 1)
							{
								goto IL_903;
							}
							goto IL_9E9;
						}
						goto IL_1F7;
					}
					goto IL_1F7;
				}
			}
		}
	}

		private void button1k_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_22));
		thread.Start();
	}

		private void button2k_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_23));
		thread.Start();
	}

		private string method_7(string string_7)
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/c" + string_7;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		string result;
		if (!string.IsNullOrEmpty(text))
		{
			result = text;
		}
		else
		{
			result = "";
		}
		return result;
	}

		private void Form1_Load(object sender, EventArgs e)
	{
		this.labelactive.ForeColor = Color.ForestGreen;
		this.labelactive.Text = "Yes";
		Thread thread = new Thread(new ThreadStart(this.method_24));
		thread.Start();
	}

		private void method_8(string string_7)
	{
		Form1.Class12 @class = new Form1.Class12();
		int length = string_7.Length;
		@class.form_0 = new Form();
		@class.form_0.FormBorderStyle = FormBorderStyle.FixedDialog;
		@class.form_0.StartPosition = FormStartPosition.CenterScreen;
		@class.form_0.ClientSize = new Size(length * 13, 150);
		Label label = new Label();
		label.Text = string_7;
		label.Font = new Font("Arial", 16f, FontStyle.Bold);
		label.AutoSize = true;
		label.Location = new Point(20, 20);
		Button button = new Button();
		button.Text = "OK";
		button.AutoSize = true;
		button.Location = new Point(length * 13 / 2 - 30, 80);
		button.Click += @class.method_0;
		@class.form_0.Controls.Add(label);
		@class.form_0.Controls.Add(button);
		@class.form_0.ShowDialog();
	}

	

		private void button7_Click(object sender, EventArgs e)
	{
		string text = "SAve_DuLieu";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(text + "\\luuthongtin.txt"))
			{
				streamWriter.WriteLine(string.Concat(new string[]
				{
					"c?c?",
					this.textBox1k.Text,
					"?",
					this.textBox2k.Text,
					"?",
					this.textBox3k.Text,
					"?",
					this.textBox4k.Text,
					"?",
					this.textBox5k.Text,
					"?",
					this.textBox6k.Text,
					"?",
					this.namegv1.Text,
					"?",
					this.namegv2.Text,
					"?",
					this.namegv3.Text,
					"?",
					this.namegv4.Text,
					"?",
					this.namegv5.Text,
					"?",
					this.namegv6.Text,
					"?",
					this.date1.Text,
					"?",
					this.date2.Text,
					"?",
					this.date3.Text,
					"?",
					this.date4.Text,
					"?",
					this.date5.Text,
					"?",
					this.date6.Text,
					"?"
				}));
				streamWriter.Close();
			}
		}
		catch (Exception)
		{
		}
	}

		public void method_10()
	{
		try
		{
			string text = "SAve_DuLieu";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = File.ReadAllText(text + "\\luuthongtin.txt");
			string[] array = text2.Split(new char[]
			{
				'?'
			});
			this.textBox1k.Text = array[2];
			this.textBox2k.Text = array[3];
			this.textBox3k.Text = array[4];
			this.textBox4k.Text = array[5];
			this.textBox5k.Text = array[6];
			this.textBox6k.Text = array[7];
			this.namegv1.Text = array[8];
			this.namegv2.Text = array[9];
			this.namegv3.Text = array[10];
			this.namegv4.Text = array[11];
			this.namegv5.Text = array[12];
			this.namegv6.Text = array[13];
			this.date1.Text = array[14];
			this.date2.Text = array[15];
			this.date3.Text = array[16];
			this.date4.Text = array[17];
			this.date5.Text = array[18];
			this.date6.Text = array[19];
		}
		catch (Exception)
		{
		}
	}

		private void button8_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_25));
		thread.Start();
	}

		private void button9_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_26));
		thread.Start();
	}

		private void method_11(string string_7, string string_8)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_7);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (directoryInfo.Exists)
		{
			if (!Directory.Exists(string_8))
			{
				Directory.CreateDirectory(string_8);
			}
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				string destFileName = Path.Combine(string_8, fileInfo.Name);
				fileInfo.CopyTo(destFileName, true);
			}
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string string_9 = Path.Combine(string_8, directoryInfo2.Name);
				this.method_11(directoryInfo2.FullName, string_9);
			}
			return;
		}
		throw new DirectoryNotFoundException("Không tìm thấy thư mục: " + string_7);
	}

		private void method_12(object sender, EventArgs e)
	{
	}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		string text = "SAve_DuLieu";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(text + "\\luuthongtin.txt"))
			{
				streamWriter.WriteLine(string.Concat(new string[]
				{
					"c?c?",
					this.textBox1k.Text,
					"?",
					this.textBox2k.Text,
					"?",
					this.textBox3k.Text,
					"?",
					this.textBox4k.Text,
					"?",
					this.textBox5k.Text,
					"?",
					this.textBox6k.Text,
					"?",
					this.namegv1.Text,
					"?",
					this.namegv2.Text,
					"?",
					this.namegv3.Text,
					"?",
					this.namegv4.Text,
					"?",
					this.namegv5.Text,
					"?",
					this.namegv6.Text,
					"?",
					this.date1.Text,
					"?",
					this.date2.Text,
					"?",
					this.date3.Text,
					"?",
					this.date4.Text,
					"?",
					this.date5.Text,
					"?",
					this.date6.Text,
					"?"
				}));
				streamWriter.Close();
			}
		}
		catch (Exception)
		{
		}
		Environment.Exit(0);
	}

		private void button3_Click(object sender, EventArgs e)
	{
		try
		{
			string path = "C:\\Profile";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			if (directoryInfo.Exists)
			{
				directoryInfo.Delete(true);
			}
			MessageBox.Show("Đã xóa data Profile , cần SETTUP lại để sử dụng", "Thông Báo :");
		}
		catch
		{
			MessageBox.Show("Xóa Profile thất bại , cần Shutdown(tắt máy tính) rồi thực hiện lại", "Thông Báo :");
		}
	}

		private void method_13(object sender, EventArgs e)
	{
	}

		private void method_14(object sender, EventArgs e)
	{
	}

		private void method_15(object sender, EventArgs e)
	{
	}

		private void method_16(object sender, EventArgs e)
	{
	}

		private void method_17(object sender, EventArgs e)
	{
	}

		private void method_18(object sender, EventArgs e)
	{
	}

		private void method_19(object sender, EventArgs e)
	{
		MessageBox.Show(string.Concat(new string[]
		{
			string.Concat(new string[]
			{
				"HIDE : Ẩn chrome (chạy ngầm) ",
				Environment.NewLine,
				"DCL : Xem danh sách lớp môn đó ",
				Environment.NewLine,
				"PĐK : Xem môn đã đăng ký ",
				Environment.NewLine
			}),
			Environment.NewLine,
			"Khiếu nại thắc mắc GoogleChat vs email :",
			Environment.NewLine,
			" peartonspkt@gmail.com"
		}), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

		private void method_20(object sender, EventArgs e)
	{
	}

		private void button3k_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_27));
		thread.Start();
	}

		private void button4k_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_28));
		thread.Start();
	}

		private void label12_Click(object sender, EventArgs e)
	{
	}

		private void label3_Click(object sender, EventArgs e)
	{
	}

		private void button5k_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_29));
		thread.Start();
	}

		private void button6k_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_30));
		thread.Start();
	}

		private void button1_Click(object sender, EventArgs e)
	{
		DialogResult dialogResult = MessageBox.Show(" Việc làm mới tool sẽ đóng toàn bộ các Chrome đang chạy kể cả chrome cá nhân đang dùng  , bạn có muốn tiếp tục không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (dialogResult == DialogResult.Yes)
		{
			try
			{
				string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "refreshdriver.exe");
				Process.Start(fileName);
				Thread.Sleep(2000);
				MessageBox.Show("Đã làm mới tool");
				return;
			}
			catch
			{
				return;
			}
		}
		if (dialogResult == DialogResult.No)
		{
		}
	}
	[CompilerGenerated]
	private void method_21()
	{
		MessageBox.Show("Tự động đăng nhập email thất bại .Vui lòng đăng nhập bằng THỦ CÔNG (TAY)!!! Rồi tắt thông báo này ");
		Form4 form = new Form4();
		form.StartPosition = FormStartPosition.Manual;
		form.Left = 0;
		form.Top = 420;
		form.string_0 = "- Nếu đã đăng nhập thành công , hãy tắt thông báo này và ";
		form.string_1 = "- Tắt Chorme đẵ đăng nhập email thành công ";
		form.ShowDialog();
		Thread thread = new Thread(new ThreadStart(method_1));
		thread.Start();
		Thread.Sleep(1000);
		this.method_11("C:\\Profile\\Profile1", "C:\\Profile\\Profile2");
		Thread.Sleep(1000);
		this.method_11("C:\\Profile\\Profile2", "C:\\Profile\\Profile3");
		Thread.Sleep(1000);
		this.method_11("C:\\Profile\\Profile3", "C:\\Profile\\Profile4");
		Thread.Sleep(1000);
		this.method_11("C:\\Profile\\Profile3", "C:\\Profile\\Profile5");
		Thread.Sleep(1000);
		this.method_11("C:\\Profile\\Profile3", "C:\\Profile\\Profile6");
		Thread.Sleep(1000);
		if (this.string_4 == "PRO")
		{
			this.button1k.Enabled = true;
			this.button2k.Enabled = true;
			this.button3k.Enabled = true;
			this.button4k.Enabled = true;
			this.button5k.Enabled = true;
			this.button6k.Enabled = true;
		}
		form.StartPosition = FormStartPosition.Manual;
		form.Left = 500;
		form.Top = 420;
		form.string_0 = "- Đã copy Proifile thành công";
		form.string_1 = "- Tiến hành đăng ký thôi nào !!! ";
		form.ShowDialog();
	}

		[CompilerGenerated]
	private void method_22()
	{
		if (this.button1k.Text == "START")
		{
			this.button1k.Text = "STOP";
			this.method_1();
		}
		else
		{
			this.button1k.Text = "START";
		}
	}

		[CompilerGenerated]
	private void method_23()
	{
		if (this.button2k.Text == "START")
		{
			this.button2k.Text = "STOP";
			this.method_2();
		}
		else
		{
			this.button2k.Text = "START";
		}
	}

		[CompilerGenerated]
	private void method_24()
	{
		this.method_10();
		if (this.int_0 == 1)
		{
			this.button1k.Enabled = false;
			this.button2k.Enabled = false;
			this.button3k.Enabled = false;
			this.button4k.Enabled = false;
			this.button5k.Enabled = false;
			this.button6k.Enabled = false;
		}
	}

		[CompilerGenerated]
	private void method_25()
	{
		this.method_10();
	}

		[CompilerGenerated]
	private void method_26()
	{
		this.button1k.Enabled = false;
		this.button2k.Enabled = false;
		this.button3k.Enabled = false;
		this.button4k.Enabled = false;
		this.button5k.Enabled = false;
		this.button6k.Enabled = false;
		this.method_0();
	}

		[CompilerGenerated]
	private void method_27()
	{
		if (this.button3k.Text == "START")
		{
			this.button3k.Text = "STOP";
			this.method_3();
		}
		else
		{
			this.button3k.Text = "START";
		}
	}

		[CompilerGenerated]
	private void method_28()
	{
		if (!(this.button4k.Text == "START"))
		{
			this.button4k.Text = "START";
		}
		else
		{
			this.button4k.Text = "STOP";
			this.method_4();
		}
	}

		[CompilerGenerated]
	private void method_29()
	{
		if (this.button5k.Text == "START")
		{
			this.button5k.Text = "STOP";
			this.method_5();
		}
		else
		{
			this.button5k.Text = "START";
		}
	}

		[CompilerGenerated]
	private void method_30()
	{
		if (!(this.button6k.Text == "START"))
		{
			this.button6k.Text = "START";
		}
		else
		{
			this.button6k.Text = "STOP";
			this.method_6();
		}
	}

		public string string_0;

		public string string_1;

		public int int_0;

		public string string_2;

		public string string_3;

		public string string_4;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		private string string_5 = "C:\\Profile";

		private string[] string_6 = File.ReadAllLines("useragent.txt");

		private Random random_0 = new Random();

		[CompilerGenerated]
	[Serializable]
	private sealed class Class5
	{
				internal void method_0()
		{
			MessageBox.Show(" Đợi xíu đang copy Profile !!!");
		}

				internal void method_1()
		{
			MessageBox.Show(" Đợi xíu đang copy Profile !!!");
		}
	}

		[CompilerGenerated]
	private sealed class Class6
	{
				internal void method_0()
		{
			int num = (int)this.form1_0.numericUpDown1.Value;
			this.int_0 = num * 300;
			Thread.Sleep(this.int_0);
		}

				internal void method_1()
		{
			MessageBox.Show(string.Format("Check không cho chạy thay người khác vi phạm {0}/5 . ( 5/5 lần tự động thoát ) ", this.int_1));
		}

				internal void method_2(string string_0)
		{
			this.form1_0.method_8(" Đăng ký thành công học phần " + string_0);
			this.form1_0.button1k.Text = "START";
		}

				internal void method_3(string string_0)
		{
			if (this.form1_0.button1k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story1.Text = " Đã tắt chrome ";
			}
			else
			{
				this.form1_0.story1.Text = string_0;
			}
		}

				internal void method_4()
		{
			if (this.form1_0.button1k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story1.Text = " Đã tắt chrome ";
			}
		}

				public Form1 form1_0;

				public int int_0;

				public int int_1;

				public IWebDriver iwebDriver_0;

				public ThreadStart threadStart_0;
	}

		[CompilerGenerated]
	private sealed class Class7
	{
				internal void method_0()
		{
			int num = (int)this.form1_0.numericUpDown1.Value;
			this.int_0 = num * 300;
			Thread.Sleep(this.int_0);
		}

				internal void method_1()
		{
			MessageBox.Show(string.Format("Check không cho chạy thay người khác vi phạm {0}/5 . ( 5/5 lần tự động thoát ) ", this.int_1));
		}

				internal void method_2(string string_0)
		{
			this.form1_0.method_8(" Đăng ký thành công học phần " + string_0);
			this.form1_0.button2k.Text = "START";
		}

				internal void method_3(string string_0)
		{
			if (this.form1_0.button2k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story2.Text = " Đã tắt chrome ";
			}
			else
			{
				this.form1_0.story2.Text = string_0;
			}
		}

				internal void method_4()
		{
			if (this.form1_0.button2k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story2.Text = " Đã tắt chrome ";
			}
		}

				public Form1 form1_0;

				public int int_0;

				public int int_1;

				public IWebDriver iwebDriver_0;

				public ThreadStart threadStart_0;
	}

		[CompilerGenerated]
	private sealed class Class8
	{
				internal void method_0()
		{
			int num = (int)this.form1_0.numericUpDown1.Value;
			this.int_0 = num * 300;
			Thread.Sleep(this.int_0);
		}

				internal void method_1()
		{
			MessageBox.Show(string.Format("Check không cho chạy thay người khác vi phạm {0}/5 . ( 5/5 lần tự động thoát ) ", this.int_1));
		}

				internal void method_2(string string_0)
		{
			this.form1_0.method_8(" Đăng ký thành công học phần " + string_0);
			this.form1_0.button3k.Text = "START";
		}

				internal void method_3(string string_0)
		{
			if (this.form1_0.button3k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story3.Text = " Đã tắt chrome ";
			}
			else
			{
				this.form1_0.story3.Text = string_0;
			}
		}

				internal void method_4()
		{
			if (this.form1_0.button3k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story3.Text = " Đã tắt chrome ";
			}
		}

				public Form1 form1_0;

				public int int_0;

				public int int_1;

				public IWebDriver iwebDriver_0;

		public ThreadStart threadStart_0;
	}

	[CompilerGenerated]
	private sealed class Class9
	{
		internal void method_0()
		{
			int num = (int)this.form1_0.numericUpDown1.Value;
			this.int_0 = num * 300;
			Thread.Sleep(this.int_0);
		}

		internal void method_1()
		{
			MessageBox.Show(string.Format("Check không cho chạy thay người khác vi phạm {0}/5 . ( 5/5 lần tự động thoát ) ", this.int_1));
		}

		internal void method_2(string string_0)
		{
			this.form1_0.method_8(" Đăng ký thành công học phần " + string_0);
			this.form1_0.button4k.Text = "START";
		}
		internal void method_3(string string_0)
		{
			if (this.form1_0.button4k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story4.Text = " Đã tắt chrome ";
			}
			else
			{
				this.form1_0.story4.Text = string_0;
			}
		}
		internal void method_4()
		{
			if (this.form1_0.button4k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story4.Text = " Đã tắt chrome ";
			}
		}

		public Form1 form1_0;

		public int int_0;

		public int int_1;

		public IWebDriver iwebDriver_0;

		public ThreadStart threadStart_0;
	}

	[CompilerGenerated]
	private sealed class Class10
	{
		internal void method_0()
		{
			int num = (int)this.form1_0.numericUpDown1.Value;
			this.int_0 = num * 300;
			Thread.Sleep(this.int_0);
		}

		internal void method_1()
		{
			MessageBox.Show(string.Format("Check không cho chạy thay người khác vi phạm {0}/5 . ( 5/5 lần tự động thoát ) ", this.int_1));
		}

		internal void method_2(string string_0)
		{
			this.form1_0.method_8(" Đăng ký thành công học phần " + string_0);
			this.form1_0.button5k.Text = "START";
		}

		internal void method_3(string string_0)
		{
			if (this.form1_0.button5k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story5.Text = " Đã tắt chrome ";
			}
			else
			{
				this.form1_0.story5.Text = string_0;
			}
		}

		internal void method_4()
		{
			if (this.form1_0.button5k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story5.Text = " Đã tắt chrome ";
			}
		}

		
		public Form1 form1_0;

		public int int_0;

		public int int_1;

		public IWebDriver iwebDriver_0;

		public ThreadStart threadStart_0;
	}

	[CompilerGenerated]
	private sealed class Class11
	{
		internal void method_0()
		{
			int num = (int)this.form1_0.numericUpDown1.Value;
			this.int_0 = num * 300;
			Thread.Sleep(this.int_0);
		}

		internal void method_1()
		{
			MessageBox.Show(string.Format("Check không cho chạy thay người khác vi phạm {0}/5 . ( 5/5 lần tự động thoát ) ", this.int_1));
		}

		internal void method_2(string string_0)
		{
			this.form1_0.method_8(" Đăng ký thành công học phần " + string_0);
			this.form1_0.button6k.Text = "START";
		}

		internal void method_3(string string_0)
		{
			if (this.form1_0.button6k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story6.Text = " Đã tắt chrome ";
			}
			else
			{
				this.form1_0.story6.Text = string_0;
			}
		}
		internal void method_4()
		{
			if (this.form1_0.button6k.Text == "START")
			{
				this.iwebDriver_0.Quit();
				this.form1_0.story6.Text = " Đã tắt chrome ";
			}
		}

		public Form1 form1_0;

		public int int_0;

		public int int_1;

		public IWebDriver iwebDriver_0;

		public ThreadStart threadStart_0;
	}

	[CompilerGenerated]
	private sealed class Class12
	{
		internal void method_0(object sender, EventArgs e)
		{
			this.form_0.Close();
		}

		public Form form_0;
	}

}
