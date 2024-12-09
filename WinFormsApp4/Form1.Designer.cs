namespace WinFormsApp4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Save = new Button();
            ShowInfo = new ListBox();
            name = new TextBox();
            author = new TextBox();
            genre = new TextBox();
            year = new TextBox();
            Delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 53);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Название книги:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 103);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор книги:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 159);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 1;
            label3.Text = "Жанр:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 221);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 1;
            label4.Text = "Год издания:";
            // 
            // Save
            // 
            Save.Location = new Point(38, 331);
            Save.Name = "Save";
            Save.Size = new Size(137, 36);
            Save.TabIndex = 2;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            // 
            // ShowInfo
            // 
            ShowInfo.FormattingEnabled = true;
            ShowInfo.ItemHeight = 15;
            ShowInfo.Location = new Point(410, 26);
            ShowInfo.Name = "ShowInfo";
            ShowInfo.Size = new Size(366, 379);
            ShowInfo.TabIndex = 3;
            ShowInfo.SelectedIndexChanged += ShowInfo_SelectedIndexChanged;
            // 
            // name
            // 
            name.Location = new Point(143, 50);
            name.Name = "name";
            name.Size = new Size(223, 23);
            name.TabIndex = 4;
            // 
            // author
            // 
            author.Location = new Point(143, 100);
            author.Name = "author";
            author.Size = new Size(223, 23);
            author.TabIndex = 4;
            // 
            // genre
            // 
            genre.Location = new Point(143, 156);
            genre.Name = "genre";
            genre.Size = new Size(223, 23);
            genre.TabIndex = 4;
            // 
            // year
            // 
            year.Location = new Point(143, 218);
            year.Name = "year";
            year.Size = new Size(100, 23);
            year.TabIndex = 4;
            // 
            // Delete
            // 
            Delete.Location = new Point(229, 331);
            Delete.Name = "Delete";
            Delete.Size = new Size(137, 36);
            Delete.TabIndex = 2;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(year);
            Controls.Add(genre);
            Controls.Add(author);
            Controls.Add(name);
            Controls.Add(ShowInfo);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Save;
        private ListBox ShowInfo;
        private TextBox name;
        private TextBox author;
        private TextBox genre;
        private TextBox year;
        private Button Delete;
    }
}
