
namespace ApiTester
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
            this.baseUrlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addtionalUrlText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tokenText = new System.Windows.Forms.TextBox();
            this.callApiButton = new System.Windows.Forms.Button();
            this.Getbutton = new System.Windows.Forms.RadioButton();
            this.PostButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.RadioButton();
            this.putButton = new System.Windows.Forms.RadioButton();
            this.outputText = new System.Windows.Forms.TextBox();
            this.beautifierButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.baseUrlHelp = new System.Windows.Forms.Button();
            this.additionalUrlHelp = new System.Windows.Forms.Button();
            this.tokenHelp = new System.Windows.Forms.Button();
            this.bodyHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseUrlText
            // 
            this.baseUrlText.Location = new System.Drawing.Point(152, 12);
            this.baseUrlText.Name = "baseUrlText";
            this.baseUrlText.Size = new System.Drawing.Size(416, 20);
            this.baseUrlText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base URL ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Additional URL";
            // 
            // addtionalUrlText
            // 
            this.addtionalUrlText.Location = new System.Drawing.Point(152, 47);
            this.addtionalUrlText.Name = "addtionalUrlText";
            this.addtionalUrlText.Size = new System.Drawing.Size(416, 20);
            this.addtionalUrlText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Authentication Token";
            // 
            // tokenText
            // 
            this.tokenText.Location = new System.Drawing.Point(152, 81);
            this.tokenText.Name = "tokenText";
            this.tokenText.Size = new System.Drawing.Size(416, 20);
            this.tokenText.TabIndex = 8;
            // 
            // callApiButton
            // 
            this.callApiButton.Location = new System.Drawing.Point(272, 249);
            this.callApiButton.Name = "callApiButton";
            this.callApiButton.Size = new System.Drawing.Size(181, 46);
            this.callApiButton.TabIndex = 9;
            this.callApiButton.Text = "Call API";
            this.callApiButton.UseVisualStyleBackColor = true;
            this.callApiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Getbutton
            // 
            this.Getbutton.AutoSize = true;
            this.Getbutton.Location = new System.Drawing.Point(6, 20);
            this.Getbutton.Name = "Getbutton";
            this.Getbutton.Size = new System.Drawing.Size(50, 17);
            this.Getbutton.TabIndex = 0;
            this.Getbutton.TabStop = true;
            this.Getbutton.Text = "GET ";
            this.Getbutton.UseVisualStyleBackColor = true;
            this.Getbutton.CheckedChanged += new System.EventHandler(this.Getbutton_CheckedChanged);
            // 
            // PostButton
            // 
            this.PostButton.AutoSize = true;
            this.PostButton.Location = new System.Drawing.Point(6, 43);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(54, 17);
            this.PostButton.TabIndex = 1;
            this.PostButton.TabStop = true;
            this.PostButton.Text = "POST";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.CheckedChanged += new System.EventHandler(this.PostButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.putButton);
            this.groupBox1.Controls.Add(this.PostButton);
            this.groupBox1.Controls.Add(this.Getbutton);
            this.groupBox1.Location = new System.Drawing.Point(627, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Call Method";
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(6, 89);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 17);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.TabStop = true;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.CheckedChanged += new System.EventHandler(this.deleteButton_CheckedChanged);
            // 
            // putButton
            // 
            this.putButton.AutoSize = true;
            this.putButton.Location = new System.Drawing.Point(6, 66);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(47, 17);
            this.putButton.TabIndex = 2;
            this.putButton.TabStop = true;
            this.putButton.Text = "PUT";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.CheckedChanged += new System.EventHandler(this.putButton_CheckedChanged);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(29, 323);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(737, 153);
            this.outputText.TabIndex = 10;
            // 
            // beautifierButton
            // 
            this.beautifierButton.Location = new System.Drawing.Point(272, 501);
            this.beautifierButton.Name = "beautifierButton";
            this.beautifierButton.Size = new System.Drawing.Size(181, 46);
            this.beautifierButton.TabIndex = 11;
            this.beautifierButton.Text = "JSON Beautifier";
            this.beautifierButton.UseVisualStyleBackColor = true;
            this.beautifierButton.Click += new System.EventHandler(this.beautifierButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Request Body";
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(152, 121);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(415, 74);
            this.bodyText.TabIndex = 13;
            // 
            // baseUrlHelp
            // 
            this.baseUrlHelp.Location = new System.Drawing.Point(574, 12);
            this.baseUrlHelp.Name = "baseUrlHelp";
            this.baseUrlHelp.Size = new System.Drawing.Size(38, 20);
            this.baseUrlHelp.TabIndex = 14;
            this.baseUrlHelp.Text = "?";
            this.baseUrlHelp.UseVisualStyleBackColor = true;
            this.baseUrlHelp.Click += new System.EventHandler(this.baseUrlHelp_Click);
            // 
            // additionalUrlHelp
            // 
            this.additionalUrlHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalUrlHelp.Location = new System.Drawing.Point(574, 47);
            this.additionalUrlHelp.Name = "additionalUrlHelp";
            this.additionalUrlHelp.Size = new System.Drawing.Size(38, 20);
            this.additionalUrlHelp.TabIndex = 15;
            this.additionalUrlHelp.Text = "?";
            this.additionalUrlHelp.UseVisualStyleBackColor = true;
            this.additionalUrlHelp.Click += new System.EventHandler(this.additionalUrlHelp_Click);
            // 
            // tokenHelp
            // 
            this.tokenHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenHelp.Location = new System.Drawing.Point(574, 81);
            this.tokenHelp.Name = "tokenHelp";
            this.tokenHelp.Size = new System.Drawing.Size(38, 20);
            this.tokenHelp.TabIndex = 16;
            this.tokenHelp.Text = "?";
            this.tokenHelp.UseVisualStyleBackColor = true;
            this.tokenHelp.Click += new System.EventHandler(this.tokenHelp_Click);
            // 
            // bodyHelp
            // 
            this.bodyHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyHelp.Location = new System.Drawing.Point(574, 140);
            this.bodyHelp.Name = "bodyHelp";
            this.bodyHelp.Size = new System.Drawing.Size(38, 20);
            this.bodyHelp.TabIndex = 17;
            this.bodyHelp.Text = "?";
            this.bodyHelp.UseVisualStyleBackColor = true;
            this.bodyHelp.Click += new System.EventHandler(this.bodyHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.bodyHelp);
            this.Controls.Add(this.tokenHelp);
            this.Controls.Add(this.additionalUrlHelp);
            this.Controls.Add(this.baseUrlHelp);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beautifierButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.callApiButton);
            this.Controls.Add(this.tokenText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addtionalUrlText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseUrlText);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox baseUrlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addtionalUrlText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tokenText;
        private System.Windows.Forms.Button callApiButton;
        private System.Windows.Forms.RadioButton Getbutton;
        private System.Windows.Forms.RadioButton PostButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button beautifierButton;
        private System.Windows.Forms.RadioButton putButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bodyText;
        private System.Windows.Forms.RadioButton deleteButton;
        private System.Windows.Forms.Button baseUrlHelp;
        private System.Windows.Forms.Button additionalUrlHelp;
        private System.Windows.Forms.Button tokenHelp;
        private System.Windows.Forms.Button bodyHelp;
    }
}

