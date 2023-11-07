namespace DateTimeInfoApp
{
    partial class DateTimeInfoApp
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
            this.buttonShowDateTime = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowDateTime
            // 
            this.buttonShowDateTime.Location = new System.Drawing.Point(278, 192);
            this.buttonShowDateTime.Name = "buttonShowDateTime";
            this.buttonShowDateTime.Size = new System.Drawing.Size(159, 45);
            this.buttonShowDateTime.TabIndex = 0;
            this.buttonShowDateTime.Text = "Покажи дата и час";
            this.buttonShowDateTime.UseVisualStyleBackColor = true;
            this.buttonShowDateTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DateTimeInfoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonShowDateTime);
            this.Name = "DateTimeInfoApp";
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.DateTimeInfoApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowDateTime;
        private System.Windows.Forms.Button button2;
    }
}

