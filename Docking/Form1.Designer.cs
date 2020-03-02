namespace Docking
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.comboBox2 = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.pnlMain = new System.Windows.Forms.Panel();
         this.pnlRight = new System.Windows.Forms.Panel();
         this.pnlLeft = new System.Windows.Forms.Panel();
         this.pnl1Left = new System.Windows.Forms.Panel();
         this.pnl2Right = new System.Windows.Forms.Panel();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.pnlMain.SuspendLayout();
         this.pnlRight.SuspendLayout();
         this.pnlLeft.SuspendLayout();
         this.pnl1Left.SuspendLayout();
         this.pnl2Right.SuspendLayout();
         this.SuspendLayout();
         // 
         // comboBox1
         // 
         this.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(0, 23);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(220, 21);
         this.comboBox1.TabIndex = 0;
         // 
         // comboBox2
         // 
         this.comboBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.comboBox2.FormattingEnabled = true;
         this.comboBox2.Location = new System.Drawing.Point(0, 23);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new System.Drawing.Size(269, 21);
         this.comboBox2.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label1.Dock = System.Windows.Forms.DockStyle.Top;
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(220, 23);
         this.label1.TabIndex = 3;
         this.label1.Text = "Combo Box1";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label2
         // 
         this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label2.Dock = System.Windows.Forms.DockStyle.Top;
         this.label2.Location = new System.Drawing.Point(0, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(269, 23);
         this.label2.TabIndex = 4;
         this.label2.Text = "Combo Box2";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // pnlMain
         // 
         this.pnlMain.BackColor = System.Drawing.Color.Black;
         this.pnlMain.Controls.Add(this.pnlRight);
         this.pnlMain.Controls.Add(this.pnlLeft);
         this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnlMain.Location = new System.Drawing.Point(0, 0);
         this.pnlMain.Name = "pnlMain";
         this.pnlMain.Size = new System.Drawing.Size(489, 44);
         this.pnlMain.TabIndex = 5;
         // 
         // pnlRight
         // 
         this.pnlRight.BackColor = System.Drawing.Color.LightGray;
         this.pnlRight.Controls.Add(this.label2);
         this.pnlRight.Controls.Add(this.comboBox2);
         this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.pnlRight.Location = new System.Drawing.Point(220, 0);
         this.pnlRight.Name = "pnlRight";
         this.pnlRight.Size = new System.Drawing.Size(269, 44);
         this.pnlRight.TabIndex = 7;
         // 
         // pnlLeft
         // 
         this.pnlLeft.BackColor = System.Drawing.Color.Gray;
         this.pnlLeft.Controls.Add(this.label1);
         this.pnlLeft.Controls.Add(this.comboBox1);
         this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.pnlLeft.Location = new System.Drawing.Point(0, 0);
         this.pnlLeft.Name = "pnlLeft";
         this.pnlLeft.Size = new System.Drawing.Size(220, 44);
         this.pnlLeft.TabIndex = 6;
         // 
         // pnl1Left
         // 
         this.pnl1Left.Controls.Add(this.textBox1);
         this.pnl1Left.Dock = System.Windows.Forms.DockStyle.Left;
         this.pnl1Left.Location = new System.Drawing.Point(0, 44);
         this.pnl1Left.Name = "pnl1Left";
         this.pnl1Left.Size = new System.Drawing.Size(220, 586);
         this.pnl1Left.TabIndex = 6;
         // 
         // pnl2Right
         // 
         this.pnl2Right.Controls.Add(this.textBox2);
         this.pnl2Right.Dock = System.Windows.Forms.DockStyle.Right;
         this.pnl2Right.Location = new System.Drawing.Point(220, 44);
         this.pnl2Right.Name = "pnl2Right";
         this.pnl2Right.Size = new System.Drawing.Size(269, 586);
         this.pnl2Right.TabIndex = 7;
         // 
         // textBox1
         // 
         this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox1.Location = new System.Drawing.Point(0, 0);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox1.Size = new System.Drawing.Size(220, 586);
         this.textBox1.TabIndex = 0;
         // 
         // textBox2
         // 
         this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox2.Location = new System.Drawing.Point(0, 0);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox2.Size = new System.Drawing.Size(269, 586);
         this.textBox2.TabIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(489, 630);
         this.Controls.Add(this.pnl2Right);
         this.Controls.Add(this.pnl1Left);
         this.Controls.Add(this.pnlMain);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Resize += new System.EventHandler(this.Form1_Resize);
         this.pnlMain.ResumeLayout(false);
         this.pnlRight.ResumeLayout(false);
         this.pnlLeft.ResumeLayout(false);
         this.pnl1Left.ResumeLayout(false);
         this.pnl1Left.PerformLayout();
         this.pnl2Right.ResumeLayout(false);
         this.pnl2Right.PerformLayout();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnl1Left;
        private System.Windows.Forms.Panel pnl2Right;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
   }
}

