﻿namespace BookManager
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.Bname = new System.Windows.Forms.TextBox();
            this.Bauthor = new System.Windows.Forms.TextBox();
            this.Bpublish = new System.Windows.Forms.TextBox();
            this.Bprice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要修改的书籍信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label2.Location = new System.Drawing.Point(119, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label3.Location = new System.Drawing.Point(119, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "书名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label4.Location = new System.Drawing.Point(119, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "作者:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label5.Location = new System.Drawing.Point(100, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版社：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F);
            this.label6.Location = new System.Drawing.Point(119, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "价格：";
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(191, 76);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(201, 21);
            this.BID.TabIndex = 6;
            // 
            // Bname
            // 
            this.Bname.Location = new System.Drawing.Point(191, 136);
            this.Bname.Name = "Bname";
            this.Bname.Size = new System.Drawing.Size(201, 21);
            this.Bname.TabIndex = 7;
            // 
            // Bauthor
            // 
            this.Bauthor.Location = new System.Drawing.Point(191, 200);
            this.Bauthor.Name = "Bauthor";
            this.Bauthor.Size = new System.Drawing.Size(201, 21);
            this.Bauthor.TabIndex = 8;
            // 
            // Bpublish
            // 
            this.Bpublish.Location = new System.Drawing.Point(191, 259);
            this.Bpublish.Name = "Bpublish";
            this.Bpublish.Size = new System.Drawing.Size(201, 21);
            this.Bpublish.TabIndex = 9;
            // 
            // Bprice
            // 
            this.Bprice.Location = new System.Drawing.Point(191, 325);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(201, 21);
            this.Bprice.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookManager.Properties.Resources.边框7;
            this.ClientSize = new System.Drawing.Size(517, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.Bpublish);
            this.Controls.Add(this.Bauthor);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.TextBox Bauthor;
        private System.Windows.Forms.TextBox Bpublish;
        private System.Windows.Forms.TextBox Bprice;
        private System.Windows.Forms.Button button1;
    }
}