
namespace MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            this.Prev = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblDispCurrent = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblDispDuration = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDispName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(17, 247);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(94, 43);
            this.Prev.TabIndex = 0;
            this.Prev.Text = "Prev";
            this.Prev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(117, 247);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(94, 43);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(217, 247);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(94, 43);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(317, 247);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(94, 43);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(427, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 224);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(422, 17);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(51, 43);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(557, 17);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 43);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.lblDispCurrent);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.lblDispDuration);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblDispName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 224);
            this.panel1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(319, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Shuffle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDispCurrent
            // 
            this.lblDispCurrent.AutoSize = true;
            this.lblDispCurrent.Location = new System.Drawing.Point(91, 81);
            this.lblDispCurrent.Name = "lblDispCurrent";
            this.lblDispCurrent.Size = new System.Drawing.Size(0, 20);
            this.lblDispCurrent.TabIndex = 8;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(3, 83);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(70, 20);
            this.lblCurrent.TabIndex = 7;
            this.lblCurrent.Text = "Current :";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.Location = new System.Drawing.Point(3, 155);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(405, 69);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblDispDuration
            // 
            this.lblDispDuration.AutoSize = true;
            this.lblDispDuration.Location = new System.Drawing.Point(92, 49);
            this.lblDispDuration.Name = "lblDispDuration";
            this.lblDispDuration.Size = new System.Drawing.Size(0, 20);
            this.lblDispDuration.TabIndex = 5;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(4, 53);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(78, 20);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration :";
            // 
            // lblDispName
            // 
            this.lblDispName.AutoSize = true;
            this.lblDispName.Location = new System.Drawing.Point(92, 22);
            this.lblDispName.Name = "lblDispName";
            this.lblDispName.Size = new System.Drawing.Size(0, 20);
            this.lblDispName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(476, 17);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 43);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 302);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Prev);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

    

        #endregion

        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDispName;
        private System.Windows.Forms.Label lblDispDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblDispCurrent;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Delete;
    }
}

