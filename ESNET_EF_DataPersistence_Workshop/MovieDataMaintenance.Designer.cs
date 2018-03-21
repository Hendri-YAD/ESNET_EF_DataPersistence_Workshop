namespace ESNET_EF_DataPersistence_Workshop
{
    partial class MovieDataMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_videoCode = new System.Windows.Forms.TextBox();
            this.tb_movieTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rentalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Code";
            // 
            // tb_videoCode
            // 
            this.tb_videoCode.Location = new System.Drawing.Point(253, 52);
            this.tb_videoCode.Multiline = true;
            this.tb_videoCode.Name = "tb_videoCode";
            this.tb_videoCode.Size = new System.Drawing.Size(109, 22);
            this.tb_videoCode.TabIndex = 1;
            // 
            // tb_movieTitle
            // 
            this.tb_movieTitle.Location = new System.Drawing.Point(253, 108);
            this.tb_movieTitle.Multiline = true;
            this.tb_movieTitle.Name = "tb_movieTitle";
            this.tb_movieTitle.Size = new System.Drawing.Size(351, 22);
            this.tb_movieTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie Title";
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(253, 158);
            this.tb_genre.Multiline = true;
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(109, 22);
            this.tb_genre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre";
            // 
            // tb_rentalCost
            // 
            this.tb_rentalCost.Location = new System.Drawing.Point(253, 217);
            this.tb_rentalCost.Multiline = true;
            this.tb_rentalCost.Name = "tb_rentalCost";
            this.tb_rentalCost.Size = new System.Drawing.Size(109, 22);
            this.tb_rentalCost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rental Cost";
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(60, 307);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(47, 33);
            this.btn_prev.TabIndex = 8;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(136, 307);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(61, 33);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(230, 307);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(66, 33);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Enabled = false;
            this.btn_insert.Location = new System.Drawing.Point(332, 307);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(66, 33);
            this.btn_insert.TabIndex = 11;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(434, 307);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(66, 33);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(545, 307);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(47, 33);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(60, 373);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(47, 33);
            this.btn_first.TabIndex = 14;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(545, 374);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(47, 33);
            this.btn_end.TabIndex = 15;
            this.btn_end.Text = ">>";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // tb_find
            // 
            this.tb_find.Location = new System.Drawing.Point(136, 378);
            this.tb_find.Multiline = true;
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(282, 22);
            this.tb_find.TabIndex = 16;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(434, 373);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(92, 33);
            this.btn_find.TabIndex = 17;
            this.btn_find.Text = "Find Movie";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // MovieDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 501);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.tb_rentalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_movieTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_videoCode);
            this.Controls.Add(this.label1);
            this.Name = "MovieDataMaintenance";
            this.Text = "Movie Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_videoCode;
        private System.Windows.Forms.TextBox tb_movieTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_rentalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button btn_find;
    }
}