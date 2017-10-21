namespace Sorter
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
            this.LeftList = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SortButton = new System.Windows.Forms.Button();
            this.Ascending = new System.Windows.Forms.CheckBox();
            this.Descending = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LeftList
            // 
            this.LeftList.Location = new System.Drawing.Point(0, 0);
            this.LeftList.Name = "LeftList";
            this.LeftList.Size = new System.Drawing.Size(137, 343);
            this.LeftList.TabIndex = 0;
            this.LeftList.UseCompatibleStateImageBehavior = false;
            this.LeftList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(363, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(137, 343);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(176, 238);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(120, 37);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Ascending
            // 
            this.Ascending.AutoSize = true;
            this.Ascending.Location = new System.Drawing.Point(196, 48);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(76, 17);
            this.Ascending.TabIndex = 3;
            this.Ascending.Text = "Ascending";
            this.Ascending.UseVisualStyleBackColor = true;
            this.Ascending.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Descending
            // 
            this.Descending.AutoSize = true;
            this.Descending.Location = new System.Drawing.Point(196, 128);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(83, 17);
            this.Descending.TabIndex = 4;
            this.Descending.Text = "Descending";
            this.Descending.UseVisualStyleBackColor = true;
            this.Descending.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 343);
            this.Controls.Add(this.Descending);
            this.Controls.Add(this.Ascending);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.LeftList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LeftList;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.CheckBox Ascending;
        private System.Windows.Forms.CheckBox Descending;
    }
}

