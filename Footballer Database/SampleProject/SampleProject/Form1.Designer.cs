
namespace SampleProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teamName = new System.Windows.Forms.TextBox();
            this.fblName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Sponsor = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.updButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(656, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surrname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sponsor:";
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(192, 256);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(125, 27);
            this.teamName.TabIndex = 5;
            // 
            // fblName
            // 
            this.fblName.Location = new System.Drawing.Point(192, 303);
            this.fblName.Name = "fblName";
            this.fblName.Size = new System.Drawing.Size(125, 27);
            this.fblName.TabIndex = 6;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(192, 350);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(125, 27);
            this.Surname.TabIndex = 7;
            // 
            // Sponsor
            // 
            this.Sponsor.Location = new System.Drawing.Point(192, 397);
            this.Sponsor.Name = "Sponsor";
            this.Sponsor.Size = new System.Drawing.Size(125, 27);
            this.Sponsor.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(441, 308);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 31);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(441, 365);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(102, 31);
            this.delButton.TabIndex = 10;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updButton
            // 
            this.updButton.Location = new System.Drawing.Point(565, 306);
            this.updButton.Name = "updButton";
            this.updButton.Size = new System.Drawing.Size(102, 31);
            this.updButton.TabIndex = 11;
            this.updButton.Text = "Update";
            this.updButton.UseVisualStyleBackColor = true;
            this.updButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IDbox
            // 
            this.IDbox.Location = new System.Drawing.Point(192, 209);
            this.IDbox.Name = "IDbox";
            this.IDbox.ReadOnly = true;
            this.IDbox.Size = new System.Drawing.Size(125, 27);
            this.IDbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Sponsor);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.fblName);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Footballer Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public  System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.TextBox fblName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Sponsor;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button updButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

