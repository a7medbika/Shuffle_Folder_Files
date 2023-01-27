namespace Shuffle_Folder_Files
{
    partial class MainForm
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ln_1 = new System.Windows.Forms.Panel();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Shuffle = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(421, 57);
            this.pnl_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "إعادة ترتيب الملفات عن طريق إعادة تسميتها بشكل عشوائي";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnl_1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 284);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.btn_Browse);
            this.pnl_1.Controls.Add(this.txt_Path);
            this.pnl_1.Controls.Add(this.ln_1);
            this.pnl_1.Controls.Add(this.label2);
            this.pnl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_1.Location = new System.Drawing.Point(3, 23);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.pnl_1.Size = new System.Drawing.Size(415, 91);
            this.pnl_1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "1- قم بإختيار المجلد الذي تريد إعادة ترتيب ملفاته";
            // 
            // ln_1
            // 
            this.ln_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.ln_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ln_1.Location = new System.Drawing.Point(5, 29);
            this.ln_1.Name = "ln_1";
            this.ln_1.Size = new System.Drawing.Size(410, 2);
            this.ln_1.TabIndex = 1;
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(88)))));
            this.txt_Path.Location = new System.Drawing.Point(11, 49);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(301, 26);
            this.txt_Path.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(89)))), ((int)(((byte)(88)))));
            this.btn_Browse.Location = new System.Drawing.Point(318, 49);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(86, 26);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "تصفح";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Shuffle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 120);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(415, 140);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 2);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "2- بعد التأكد من صحة المجلد المختار قم بالضغط على زر إعادة الترتيب وسوف يتم إعادة" +
    " ترتيب الملفات بشكل تلقائي";
            // 
            // btn_Shuffle
            // 
            this.btn_Shuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_Shuffle.FlatAppearance.BorderSize = 0;
            this.btn_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shuffle.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btn_Shuffle.Location = new System.Drawing.Point(127, 74);
            this.btn_Shuffle.Name = "btn_Shuffle";
            this.btn_Shuffle.Size = new System.Drawing.Size(161, 49);
            this.btn_Shuffle.TabIndex = 2;
            this.btn_Shuffle.Text = "إعادة الترتيب";
            this.btn_Shuffle.UseVisualStyleBackColor = false;
            this.btn_Shuffle.Click += new System.EventHandler(this.Btn_Shuffle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(421, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 380);
            this.MinimumSize = new System.Drawing.Size(437, 380);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shuffle Files\' Order";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Shuffle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Panel ln_1;
        private System.Windows.Forms.Label label2;
    }
}