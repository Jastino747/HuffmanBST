namespace HuffmanBST
{
    partial class FormEncode
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
            this.buttonEncode = new System.Windows.Forms.Button();
            this.listBoxNodeList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEncodedChars = new System.Windows.Forms.DataGridView();
            this.Character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Binary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEncodedChars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert your text here :";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncode.Location = new System.Drawing.Point(39, 258);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(176, 38);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "ENCODE";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // listBoxNodeList
            // 
            this.listBoxNodeList.FormattingEnabled = true;
            this.listBoxNodeList.ItemHeight = 16;
            this.listBoxNodeList.Location = new System.Drawing.Point(12, 302);
            this.listBoxNodeList.Name = "listBoxNodeList";
            this.listBoxNodeList.Size = new System.Drawing.Size(436, 372);
            this.listBoxNodeList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Huffman Tree\'s Generated Node List";
            // 
            // dataGridViewEncodedChars
            // 
            this.dataGridViewEncodedChars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEncodedChars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Character,
            this.Binary});
            this.dataGridViewEncodedChars.Location = new System.Drawing.Point(454, 302);
            this.dataGridViewEncodedChars.Name = "dataGridViewEncodedChars";
            this.dataGridViewEncodedChars.RowTemplate.Height = 24;
            this.dataGridViewEncodedChars.Size = new System.Drawing.Size(396, 372);
            this.dataGridViewEncodedChars.TabIndex = 5;
            // 
            // Character
            // 
            this.Character.HeaderText = "Char";
            this.Character.Name = "Character";
            this.Character.Width = 50;
            // 
            // Binary
            // 
            this.Binary.HeaderText = "Binary";
            this.Binary.Name = "Binary";
            this.Binary.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Huffman Tree\'s Encoded Char List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1015, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output :";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecode.Location = new System.Drawing.Point(238, 258);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(176, 38);
            this.buttonDecode.TabIndex = 9;
            this.buttonDecode.Text = "DECODE 1";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(856, 48);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(386, 626);
            this.textBoxOutput.TabIndex = 10;
            this.textBoxOutput.Text = "";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 48);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(838, 204);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "DECODE 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInstructions
            // 
            this.buttonInstructions.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstructions.Location = new System.Drawing.Point(636, 258);
            this.buttonInstructions.Name = "buttonInstructions";
            this.buttonInstructions.Size = new System.Drawing.Size(176, 38);
            this.buttonInstructions.TabIndex = 13;
            this.buttonInstructions.Text = "INSTRUCTIONS";
            this.buttonInstructions.UseVisualStyleBackColor = true;
            this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
            // 
            // FormEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 704);
            this.Controls.Add(this.buttonInstructions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewEncodedChars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxNodeList);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.label1);
            this.Name = "FormEncode";
            this.Text = "FormEncode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEncode_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEncodedChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.ListBox listBoxNodeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEncodedChars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Character;
        private System.Windows.Forms.DataGridViewTextBoxColumn Binary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInstructions;
    }
}