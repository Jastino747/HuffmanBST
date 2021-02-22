namespace HuffmanBST
{
    partial class FormMain
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
            this.buttonEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonEncode
            // 
            this.buttonEncode.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncode.Location = new System.Drawing.Point(202, 91);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(263, 79);
            this.buttonEncode.TabIndex = 0;
            this.buttonEncode.Text = "START";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Binary Search Tree (Huffman)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 34;
            this.listBoxMembers.Items.AddRange(new object[] {
            "Jason Austin Juwono\t\t160417004",
            "Alvin Gotama\t\t160817049",
            "Michael Mone Jurrien\t\t160817022",
            "Matthew Vieri Suriawan\t160817004",
            "Chris Johan Susanto\t\t160817002",
            "Kelompok 10"});
            this.listBoxMembers.Location = new System.Drawing.Point(28, 193);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(635, 174);
            this.listBoxMembers.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 390);
            this.Controls.Add(this.listBoxMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEncode);
            this.Name = "FormMain";
            this.Text = "Binary Search Tree (Huffman)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMembers;
    }
}

