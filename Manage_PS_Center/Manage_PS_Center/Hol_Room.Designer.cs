﻿namespace Manage_PS_Center
{
    partial class Hol_Room
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
            this.components = new System.ComponentModel.Container();
            this.stop_time = new System.Windows.Forms.Button();
            this.add_consum = new System.Windows.Forms.Button();
            this.reset_price = new System.Windows.Forms.Button();
            this.time_left = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stop_time
            // 
            this.stop_time.Location = new System.Drawing.Point(318, 79);
            this.stop_time.Name = "stop_time";
            this.stop_time.Size = new System.Drawing.Size(135, 40);
            this.stop_time.TabIndex = 2;
            this.stop_time.Text = "Stop Timp";
            this.stop_time.UseVisualStyleBackColor = true;
            this.stop_time.Click += new System.EventHandler(this.stop_time_Click);
            // 
            // add_consum
            // 
            this.add_consum.Location = new System.Drawing.Point(318, 128);
            this.add_consum.Name = "add_consum";
            this.add_consum.Size = new System.Drawing.Size(135, 40);
            this.add_consum.TabIndex = 3;
            this.add_consum.Text = "Adauga Consumatie";
            this.add_consum.UseVisualStyleBackColor = true;
            this.add_consum.Click += new System.EventHandler(this.add_consum_Click);
            // 
            // reset_price
            // 
            this.reset_price.Location = new System.Drawing.Point(318, 174);
            this.reset_price.Name = "reset_price";
            this.reset_price.Size = new System.Drawing.Size(135, 40);
            this.reset_price.TabIndex = 4;
            this.reset_price.Text = "Reset Setari";
            this.reset_price.UseVisualStyleBackColor = true;
            this.reset_price.Click += new System.EventHandler(this.reset_price_Click);
            // 
            // time_left
            // 
            this.time_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.time_left.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time_left.Location = new System.Drawing.Point(12, 60);
            this.time_left.Name = "time_left";
            this.time_left.Size = new System.Drawing.Size(144, 89);
            this.time_left.TabIndex = 6;
            this.time_left.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time Total";
            // 
            // price_total
            // 
            this.price_total.AutoSize = true;
            this.price_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_total.Location = new System.Drawing.Point(34, 179);
            this.price_total.Name = "price_total";
            this.price_total.Size = new System.Drawing.Size(23, 25);
            this.price_total.TabIndex = 8;
            this.price_total.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pret Total";
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(319, 33);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(135, 40);
            this.start_time.TabIndex = 10;
            this.start_time.Text = "Start Timp";
            this.start_time.UseVisualStyleBackColor = true;
            this.start_time.Click += new System.EventHandler(this.start_time_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hol_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(466, 347);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_left);
            this.Controls.Add(this.reset_price);
            this.Controls.Add(this.add_consum);
            this.Controls.Add(this.stop_time);
            this.Name = "Hol_Room";
            this.Text = "Hol_Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hol_Room_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stop_time;
        private System.Windows.Forms.Button add_consum;
        private System.Windows.Forms.Button reset_price;
        private System.Windows.Forms.Label time_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_time;
        private System.Windows.Forms.Timer timer1;
    }
}