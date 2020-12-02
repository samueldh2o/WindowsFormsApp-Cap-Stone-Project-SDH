namespace WindowsFormsApp_Cap_Stone_Project_SDH
{
    partial class frm_myNumberGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_myNumberGame));
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lal_title = new System.Windows.Forms.Label();
            this.lbl_impute = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_rools = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_1
            // 
            this.textBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_1.Location = new System.Drawing.Point(23, 278);
            this.textBox_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(273, 22);
            this.textBox_1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(409, 278);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 22);
            this.textBox2.TabIndex = 1;
            // 
            // lal_title
            // 
            this.lal_title.AutoSize = true;
            this.lal_title.Font = new System.Drawing.Font("Arial Narrow", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lal_title.Location = new System.Drawing.Point(215, 47);
            this.lal_title.Name = "lal_title";
            this.lal_title.Size = new System.Drawing.Size(297, 27);
            this.lal_title.TabIndex = 2;
            this.lal_title.Text = "Samuel\'s Number Guessing Game";
            // 
            // lbl_impute
            // 
            this.lbl_impute.AutoSize = true;
            this.lbl_impute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_impute.Location = new System.Drawing.Point(20, 252);
            this.lbl_impute.Name = "lbl_impute";
            this.lbl_impute.Size = new System.Drawing.Size(87, 18);
            this.lbl_impute.TabIndex = 3;
            this.lbl_impute.Text = "Your Guess";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(406, 252);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(112, 18);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "Machine Output";
            // 
            // lbl_rools
            // 
            this.lbl_rools.AutoSize = true;
            this.lbl_rools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rools.Location = new System.Drawing.Point(85, 120);
            this.lbl_rools.Name = "lbl_rools";
            this.lbl_rools.Size = new System.Drawing.Size(612, 64);
            this.lbl_rools.TabIndex = 5;
            this.lbl_rools.Text = resources.GetString("lbl_rools.Text");
            this.lbl_rools.Click += new System.EventHandler(this.lbl_rools_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_myNumberGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_rools);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_impute);
            this.Controls.Add(this.lal_title);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_myNumberGame";
            this.Text = "Samuels NumberGame";
            this.Load += new System.EventHandler(this.frm_MyNumberGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lal_title;
        private System.Windows.Forms.Label lbl_impute;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_rools;
        private System.Windows.Forms.Button button1;
    }
}

