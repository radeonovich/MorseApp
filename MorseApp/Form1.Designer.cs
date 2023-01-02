namespace MorseApp
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxFrequency = new System.Windows.Forms.TextBox();
            this.boxVolume = new System.Windows.Forms.TextBox();
            this.boxVolumeError = new System.Windows.Forms.TextBox();
            this.trackVolumeError = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DashTimeSelector = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DotTimeSelector = new System.Windows.Forms.NumericUpDown();
            this.trackFrequency = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashTimeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotTimeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(462, 26);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(104, 27);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Выбрать...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(6, 26);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(450, 27);
            this.FilePathBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilePathBox);
            this.groupBox1.Controls.Add(this.BrowseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Открыть файл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxInput);
            this.groupBox2.Location = new System.Drawing.Point(304, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 171);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(6, 26);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(268, 139);
            this.textBoxInput.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxFrequency);
            this.groupBox3.Controls.Add(this.boxVolume);
            this.groupBox3.Controls.Add(this.boxVolumeError);
            this.groupBox3.Controls.Add(this.trackVolumeError);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.DashTimeSelector);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.DotTimeSelector);
            this.groupBox3.Controls.Add(this.trackFrequency);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trackVolume);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(18, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 344);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кодер/Декодер";
            // 
            // boxFrequency
            // 
            this.boxFrequency.Location = new System.Drawing.Point(206, 218);
            this.boxFrequency.Name = "boxFrequency";
            this.boxFrequency.Size = new System.Drawing.Size(68, 27);
            this.boxFrequency.TabIndex = 12;
            // 
            // boxVolume
            // 
            this.boxVolume.Location = new System.Drawing.Point(206, 62);
            this.boxVolume.Name = "boxVolume";
            this.boxVolume.Size = new System.Drawing.Size(68, 27);
            this.boxVolume.TabIndex = 11;
            // 
            // boxVolumeError
            // 
            this.boxVolumeError.Location = new System.Drawing.Point(206, 138);
            this.boxVolumeError.Name = "boxVolumeError";
            this.boxVolumeError.Size = new System.Drawing.Size(68, 27);
            this.boxVolumeError.TabIndex = 10;
            // 
            // trackVolumeError
            // 
            this.trackVolumeError.Location = new System.Drawing.Point(6, 139);
            this.trackVolumeError.Name = "trackVolumeError";
            this.trackVolumeError.Size = new System.Drawing.Size(194, 56);
            this.trackVolumeError.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Погрешность длительности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Длительность тире, мс";
            // 
            // DashTimeSelector
            // 
            this.DashTimeSelector.Location = new System.Drawing.Point(185, 311);
            this.DashTimeSelector.Name = "DashTimeSelector";
            this.DashTimeSelector.Size = new System.Drawing.Size(89, 27);
            this.DashTimeSelector.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длительность точки, мс";
            // 
            // DotTimeSelector
            // 
            this.DotTimeSelector.Location = new System.Drawing.Point(185, 278);
            this.DotTimeSelector.Name = "DotTimeSelector";
            this.DotTimeSelector.Size = new System.Drawing.Size(89, 27);
            this.DotTimeSelector.TabIndex = 4;
            // 
            // trackFrequency
            // 
            this.trackFrequency.Location = new System.Drawing.Point(8, 221);
            this.trackFrequency.Name = "trackFrequency";
            this.trackFrequency.Size = new System.Drawing.Size(192, 56);
            this.trackFrequency.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Частота";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(6, 62);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(194, 56);
            this.trackVolume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Громкость/чувствительность";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxOutput);
            this.groupBox4.Location = new System.Drawing.Point(304, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 172);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вывод";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 26);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(268, 140);
            this.textBoxOutput.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDecode);
            this.groupBox5.Controls.Add(this.buttonEncode);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(18, 444);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(566, 66);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(6, 26);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(137, 29);
            this.buttonEncode.TabIndex = 1;
            this.buttonEncode.Text = "Закодировать";
            this.buttonEncode.UseVisualStyleBackColor = true;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(149, 26);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(131, 29);
            this.buttonDecode.TabIndex = 2;
            this.buttonDecode.Text = "Декодировать";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 522);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashTimeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotTimeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button BrowseButton;
        private TextBox FilePathBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TrackBar trackVolume;
        private Label label1;
        private NumericUpDown DashTimeSelector;
        private Label label3;
        private NumericUpDown DotTimeSelector;
        private TrackBar trackFrequency;
        private Label label2;
        private TextBox textBoxInput;
        private Label label4;
        private GroupBox groupBox4;
        private TextBox textBoxOutput;
        private TextBox boxFrequency;
        private TextBox boxVolume;
        private TextBox boxVolumeError;
        private TrackBar trackVolumeError;
        private Label label5;
        private GroupBox groupBox5;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonDecode;
        private Button buttonEncode;
    }
}