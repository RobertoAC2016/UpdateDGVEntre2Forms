namespace UpdateDGVFromOtherForm
{
    partial class windowtwo
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
            this.btnload = new System.Windows.Forms.Button();
            this.btnsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(581, 12);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(162, 23);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "leer datos forma 1";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(581, 96);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(162, 23);
            this.btnsec.TabIndex = 3;
            this.btnsec.Text = "Leer datos forma 2";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // windowtwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.btnload);
            this.Name = "windowtwo";
            this.Text = "windowtwo";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnload;
        private Button btnsec;
    }
}