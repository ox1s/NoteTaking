namespace NoteTaking
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Title = new Label();
            Message = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            bttNew = new Button();
            bttSave = new Button();
            bttRead = new Button();
            bttDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.ForeColor = Color.DarkRed;
            Title.Location = new Point(29, 23);
            Title.Name = "Title";
            Title.Size = new Size(59, 15);
            Title.TabIndex = 0;
            Title.Text = "Название";
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.ForeColor = Color.IndianRed;
            Message.Location = new Point(29, 96);
            Message.Name = "Message";
            Message.Size = new Size(68, 15);
            Message.TabIndex = 1;
            Message.Text = "Пояснение";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.BurlyWood;
            txtTitle.Location = new Point(29, 41);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(238, 52);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.Bisque;
            txtMessage.Location = new Point(29, 114);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(324, 315);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Linen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SaddleBrown;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Linen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Linen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Coral;
            dataGridView1.Location = new Point(375, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Linen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Linen;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.SaddleBrown;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(401, 370);
            dataGridView1.TabIndex = 4;
            // 
            // bttNew
            // 
            bttNew.BackColor = Color.White;
            bttNew.Location = new Point(273, 69);
            bttNew.Name = "bttNew";
            bttNew.Size = new Size(80, 24);
            bttNew.TabIndex = 5;
            bttNew.Text = "Очистить";
            bttNew.UseVisualStyleBackColor = false;
            bttNew.Click += bttNew_Click;
            // 
            // bttSave
            // 
            bttSave.BackColor = Color.White;
            bttSave.ForeColor = Color.FromArgb(0, 192, 0);
            bttSave.Location = new Point(273, 41);
            bttSave.Name = "bttSave";
            bttSave.Size = new Size(80, 23);
            bttSave.TabIndex = 6;
            bttSave.Text = "Сохранить";
            bttSave.UseVisualStyleBackColor = false;
            bttSave.Click += bttSave_Click;
            // 
            // bttRead
            // 
            bttRead.BackColor = Color.White;
            bttRead.ForeColor = Color.Black;
            bttRead.Location = new Point(699, 399);
            bttRead.Name = "bttRead";
            bttRead.Size = new Size(77, 30);
            bttRead.TabIndex = 7;
            bttRead.Text = "Прочитать";
            bttRead.UseVisualStyleBackColor = false;
            bttRead.Click += bttRead_Click;
            // 
            // bttDelete
            // 
            bttDelete.BackColor = Color.White;
            bttDelete.ForeColor = Color.Red;
            bttDelete.Location = new Point(375, 399);
            bttDelete.Name = "bttDelete";
            bttDelete.Size = new Size(77, 30);
            bttDelete.TabIndex = 8;
            bttDelete.Text = "Удалить";
            bttDelete.UseVisualStyleBackColor = false;
            bttDelete.Click += bttDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(bttDelete);
            Controls.Add(bttRead);
            Controls.Add(bttSave);
            Controls.Add(bttNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(Message);
            Controls.Add(Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Заметки";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Message;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Button bttNew;
        private Button bttSave;
        private Button bttRead;
        private Button bttDelete;
    }
}
