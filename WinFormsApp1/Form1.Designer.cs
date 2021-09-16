
namespace WinFormsApp1
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
            this.generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exportXLS = new System.Windows.Forms.Button();
            this.closeApplication = new System.Windows.Forms.Button();
            this.listOfNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(599, 77);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(153, 38);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generuj nowe";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generator danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wygenerowane dane";
            // 
            // exportXLS
            // 
            this.exportXLS.Location = new System.Drawing.Point(595, 152);
            this.exportXLS.Name = "exportXLS";
            this.exportXLS.Size = new System.Drawing.Size(156, 42);
            this.exportXLS.TabIndex = 5;
            this.exportXLS.Text = "Eskportuj do txt";
            this.exportXLS.UseVisualStyleBackColor = true;
            this.exportXLS.Click += new System.EventHandler(this.exportXLS_Click);
            // 
            // closeApplication
            // 
            this.closeApplication.Location = new System.Drawing.Point(602, 236);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(148, 46);
            this.closeApplication.TabIndex = 6;
            this.closeApplication.Text = "Zamknij aplikację";
            this.closeApplication.UseVisualStyleBackColor = true;
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // listOfNames
            // 
            this.listOfNames.FormattingEnabled = true;
            this.listOfNames.ItemHeight = 20;
            this.listOfNames.Location = new System.Drawing.Point(43, 93);
            this.listOfNames.Name = "listOfNames";
            this.listOfNames.Size = new System.Drawing.Size(268, 204);
            this.listOfNames.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOfNames);
            this.Controls.Add(this.closeApplication);
            this.Controls.Add(this.exportXLS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportXLS;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.ListBox listOfNames;
    }
}

