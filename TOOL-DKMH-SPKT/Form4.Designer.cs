// Token: 0x02000020 RID: 32
public partial class Form4 : global::System.Windows.Forms.Form
{
	// Token: 0x060000D6 RID: 214 RVA: 0x00016CA8 File Offset: 0x00014EA8
	private void InitializeComponent()
	{
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Arial", 9.792f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new global::System.Drawing.Point(12, 26);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(103, 19);
		this.label1.TabIndex = 0;
		this.label1.Text = "THONG BAO";
		this.label1.Click += new global::System.EventHandler(this.label1_Click);
		this.label2.AutoSize = true;
		this.label2.Font = new global::System.Drawing.Font("Arial", 9.792f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new global::System.Drawing.Point(12, 69);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(0, 19);
		this.label2.TabIndex = 1;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(845, 118);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Name = "Form4";
		this.Text = "Thông báo ";
		base.Load += new global::System.EventHandler(this.Form4_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000102 RID: 258
	private global::System.Windows.Forms.Label label1;

	// Token: 0x04000103 RID: 259
	private global::System.Windows.Forms.Label label2;
}
