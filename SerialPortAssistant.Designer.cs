namespace MySerialPort
{
    partial class SerialPortAssistant
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mSerialPortConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.mOpenSerialPortButton = new System.Windows.Forms.Button();
            this.mDTRCheckBox = new System.Windows.Forms.CheckBox();
            this.mRTSCheckBox = new System.Windows.Forms.CheckBox();
            this.mStopBits = new System.Windows.Forms.ComboBox();
            this.mDataBits = new System.Windows.Forms.ComboBox();
            this.mCheckDigit = new System.Windows.Forms.ComboBox();
            this.mBaudRate = new System.Windows.Forms.ComboBox();
            this.mPortNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mStopBitsLable = new System.Windows.Forms.Label();
            this.mDataBitsLable = new System.Windows.Forms.Label();
            this.mCheckDigitLable = new System.Windows.Forms.Label();
            this.mBaudRateLable = new System.Windows.Forms.Label();
            this.mPortNoLable = new System.Windows.Forms.Label();
            this.mReceiveConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.mSelectReceivePathText = new System.Windows.Forms.TextBox();
            this.mSaveReceiveDataButton = new System.Windows.Forms.Button();
            this.mManualClearButton = new System.Windows.Forms.Button();
            this.mStopReceiveButton = new System.Windows.Forms.Button();
            this.mReceiveHexadecimalCheckBox = new System.Windows.Forms.CheckBox();
            this.mSelectReceivePathButton = new System.Windows.Forms.Button();
            this.mAutoClearCheckBox = new System.Windows.Forms.CheckBox();
            this.mSendConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.mAutomaticSendingCycleText = new System.Windows.Forms.TextBox();
            this.mAutomaticSendingCycleLable = new System.Windows.Forms.Label();
            this.mOpenFilePathText = new System.Windows.Forms.TextBox();
            this.mSendFileButton = new System.Windows.Forms.Button();
            this.mManualSendButton = new System.Windows.Forms.Button();
            this.mAutoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.mClearSendButton = new System.Windows.Forms.Button();
            this.mOpenFileButton = new System.Windows.Forms.Button();
            this.mSendHexadecimalCheckBox = new System.Windows.Forms.CheckBox();
            this.mReceiveArea = new System.Windows.Forms.GroupBox();
            this.mReceiveAreaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.mSednArea = new System.Windows.Forms.GroupBox();
            this.mSendAreaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mStatusInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mSendCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mSendCountInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mReceiveCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mReceiveCountInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mClearCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.mAutoClearReceiveTimer = new System.Windows.Forms.Timer(this.components);
            this.mSerialPortConfigGroupBox.SuspendLayout();
            this.mReceiveConfigGroupBox.SuspendLayout();
            this.mSendConfigGroupBox.SuspendLayout();
            this.mReceiveArea.SuspendLayout();
            this.mSednArea.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSerialPortConfigGroupBox
            // 
            this.mSerialPortConfigGroupBox.Controls.Add(this.mOpenSerialPortButton);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mDTRCheckBox);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mRTSCheckBox);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mStopBits);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mDataBits);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mCheckDigit);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mBaudRate);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mPortNo);
            this.mSerialPortConfigGroupBox.Controls.Add(this.label6);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mStopBitsLable);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mDataBitsLable);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mCheckDigitLable);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mBaudRateLable);
            this.mSerialPortConfigGroupBox.Controls.Add(this.mPortNoLable);
            this.mSerialPortConfigGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mSerialPortConfigGroupBox.Name = "mSerialPortConfigGroupBox";
            this.mSerialPortConfigGroupBox.Size = new System.Drawing.Size(217, 246);
            this.mSerialPortConfigGroupBox.TabIndex = 0;
            this.mSerialPortConfigGroupBox.TabStop = false;
            this.mSerialPortConfigGroupBox.Text = "串口配置";
            // 
            // mOpenSerialPortButton
            // 
            this.mOpenSerialPortButton.Location = new System.Drawing.Point(90, 181);
            this.mOpenSerialPortButton.Name = "mOpenSerialPortButton";
            this.mOpenSerialPortButton.Size = new System.Drawing.Size(121, 38);
            this.mOpenSerialPortButton.TabIndex = 3;
            this.mOpenSerialPortButton.Text = "打开串口";
            this.mOpenSerialPortButton.UseVisualStyleBackColor = true;
            this.mOpenSerialPortButton.Click += new System.EventHandler(this.mOpenSerialPortButton_Click);
            // 
            // mDTRCheckBox
            // 
            this.mDTRCheckBox.AutoSize = true;
            this.mDTRCheckBox.Location = new System.Drawing.Point(9, 203);
            this.mDTRCheckBox.Name = "mDTRCheckBox";
            this.mDTRCheckBox.Size = new System.Drawing.Size(42, 16);
            this.mDTRCheckBox.TabIndex = 2;
            this.mDTRCheckBox.Text = "DTR";
            this.mDTRCheckBox.UseVisualStyleBackColor = true;
            // 
            // mRTSCheckBox
            // 
            this.mRTSCheckBox.AutoSize = true;
            this.mRTSCheckBox.Location = new System.Drawing.Point(9, 181);
            this.mRTSCheckBox.Name = "mRTSCheckBox";
            this.mRTSCheckBox.Size = new System.Drawing.Size(42, 16);
            this.mRTSCheckBox.TabIndex = 2;
            this.mRTSCheckBox.Text = "RTS";
            this.mRTSCheckBox.UseVisualStyleBackColor = true;
            // 
            // mStopBits
            // 
            this.mStopBits.FormattingEnabled = true;
            this.mStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.mStopBits.Location = new System.Drawing.Point(90, 145);
            this.mStopBits.Name = "mStopBits";
            this.mStopBits.Size = new System.Drawing.Size(121, 20);
            this.mStopBits.TabIndex = 1;
            // 
            // mDataBits
            // 
            this.mDataBits.FormattingEnabled = true;
            this.mDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.mDataBits.Location = new System.Drawing.Point(90, 113);
            this.mDataBits.Name = "mDataBits";
            this.mDataBits.Size = new System.Drawing.Size(121, 20);
            this.mDataBits.TabIndex = 1;
            // 
            // mCheckDigit
            // 
            this.mCheckDigit.FormattingEnabled = true;
            this.mCheckDigit.Items.AddRange(new object[] {
            "none",
            "ODD",
            "EVEN"});
            this.mCheckDigit.Location = new System.Drawing.Point(90, 81);
            this.mCheckDigit.Name = "mCheckDigit";
            this.mCheckDigit.Size = new System.Drawing.Size(121, 20);
            this.mCheckDigit.TabIndex = 1;
            // 
            // mBaudRate
            // 
            this.mBaudRate.FormattingEnabled = true;
            this.mBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "1120"});
            this.mBaudRate.Location = new System.Drawing.Point(90, 49);
            this.mBaudRate.Name = "mBaudRate";
            this.mBaudRate.Size = new System.Drawing.Size(121, 20);
            this.mBaudRate.TabIndex = 1;
            // 
            // mPortNo
            // 
            this.mPortNo.FormattingEnabled = true;
            this.mPortNo.Location = new System.Drawing.Point(90, 13);
            this.mPortNo.Name = "mPortNo";
            this.mPortNo.Size = new System.Drawing.Size(121, 20);
            this.mPortNo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 0;
            // 
            // mStopBitsLable
            // 
            this.mStopBitsLable.AutoSize = true;
            this.mStopBitsLable.Location = new System.Drawing.Point(7, 149);
            this.mStopBitsLable.Name = "mStopBitsLable";
            this.mStopBitsLable.Size = new System.Drawing.Size(53, 12);
            this.mStopBitsLable.TabIndex = 0;
            this.mStopBitsLable.Text = "停止位：";
            // 
            // mDataBitsLable
            // 
            this.mDataBitsLable.AutoSize = true;
            this.mDataBitsLable.Location = new System.Drawing.Point(7, 117);
            this.mDataBitsLable.Name = "mDataBitsLable";
            this.mDataBitsLable.Size = new System.Drawing.Size(53, 12);
            this.mDataBitsLable.TabIndex = 0;
            this.mDataBitsLable.Text = "数据位：";
            // 
            // mCheckDigitLable
            // 
            this.mCheckDigitLable.AutoSize = true;
            this.mCheckDigitLable.Location = new System.Drawing.Point(7, 85);
            this.mCheckDigitLable.Name = "mCheckDigitLable";
            this.mCheckDigitLable.Size = new System.Drawing.Size(53, 12);
            this.mCheckDigitLable.TabIndex = 0;
            this.mCheckDigitLable.Text = "校验位：";
            // 
            // mBaudRateLable
            // 
            this.mBaudRateLable.AutoSize = true;
            this.mBaudRateLable.Location = new System.Drawing.Point(7, 53);
            this.mBaudRateLable.Name = "mBaudRateLable";
            this.mBaudRateLable.Size = new System.Drawing.Size(53, 12);
            this.mBaudRateLable.TabIndex = 0;
            this.mBaudRateLable.Text = "波特率：";
            // 
            // mPortNoLable
            // 
            this.mPortNoLable.AutoSize = true;
            this.mPortNoLable.Location = new System.Drawing.Point(7, 17);
            this.mPortNoLable.Name = "mPortNoLable";
            this.mPortNoLable.Size = new System.Drawing.Size(53, 12);
            this.mPortNoLable.TabIndex = 0;
            this.mPortNoLable.Text = "端口号：";
            // 
            // mReceiveConfigGroupBox
            // 
            this.mReceiveConfigGroupBox.Controls.Add(this.mSelectReceivePathText);
            this.mReceiveConfigGroupBox.Controls.Add(this.mSaveReceiveDataButton);
            this.mReceiveConfigGroupBox.Controls.Add(this.mManualClearButton);
            this.mReceiveConfigGroupBox.Controls.Add(this.mStopReceiveButton);
            this.mReceiveConfigGroupBox.Controls.Add(this.mReceiveHexadecimalCheckBox);
            this.mReceiveConfigGroupBox.Controls.Add(this.mSelectReceivePathButton);
            this.mReceiveConfigGroupBox.Controls.Add(this.mAutoClearCheckBox);
            this.mReceiveConfigGroupBox.Location = new System.Drawing.Point(12, 264);
            this.mReceiveConfigGroupBox.Name = "mReceiveConfigGroupBox";
            this.mReceiveConfigGroupBox.Size = new System.Drawing.Size(217, 139);
            this.mReceiveConfigGroupBox.TabIndex = 0;
            this.mReceiveConfigGroupBox.TabStop = false;
            this.mReceiveConfigGroupBox.Text = "接收配置";
            // 
            // mSelectReceivePathText
            // 
            this.mSelectReceivePathText.Location = new System.Drawing.Point(9, 107);
            this.mSelectReceivePathText.Name = "mSelectReceivePathText";
            this.mSelectReceivePathText.Size = new System.Drawing.Size(202, 21);
            this.mSelectReceivePathText.TabIndex = 2;
            // 
            // mSaveReceiveDataButton
            // 
            this.mSaveReceiveDataButton.Location = new System.Drawing.Point(106, 78);
            this.mSaveReceiveDataButton.Name = "mSaveReceiveDataButton";
            this.mSaveReceiveDataButton.Size = new System.Drawing.Size(105, 23);
            this.mSaveReceiveDataButton.TabIndex = 1;
            this.mSaveReceiveDataButton.Text = "保存数据";
            this.mSaveReceiveDataButton.UseVisualStyleBackColor = true;
            // 
            // mManualClearButton
            // 
            this.mManualClearButton.Location = new System.Drawing.Point(106, 17);
            this.mManualClearButton.Name = "mManualClearButton";
            this.mManualClearButton.Size = new System.Drawing.Size(105, 23);
            this.mManualClearButton.TabIndex = 1;
            this.mManualClearButton.Text = "手动清空";
            this.mManualClearButton.UseVisualStyleBackColor = true;
            this.mManualClearButton.Click += new System.EventHandler(this.mManualClearButton_Click);
            // 
            // mStopReceiveButton
            // 
            this.mStopReceiveButton.Location = new System.Drawing.Point(106, 40);
            this.mStopReceiveButton.Name = "mStopReceiveButton";
            this.mStopReceiveButton.Size = new System.Drawing.Size(105, 23);
            this.mStopReceiveButton.TabIndex = 1;
            this.mStopReceiveButton.Text = "暂停";
            this.mStopReceiveButton.UseVisualStyleBackColor = true;
            this.mStopReceiveButton.Click += new System.EventHandler(this.mStopReceiveButton_Click);
            // 
            // mReceiveHexadecimalCheckBox
            // 
            this.mReceiveHexadecimalCheckBox.AutoSize = true;
            this.mReceiveHexadecimalCheckBox.Location = new System.Drawing.Point(9, 43);
            this.mReceiveHexadecimalCheckBox.Name = "mReceiveHexadecimalCheckBox";
            this.mReceiveHexadecimalCheckBox.Size = new System.Drawing.Size(72, 16);
            this.mReceiveHexadecimalCheckBox.TabIndex = 0;
            this.mReceiveHexadecimalCheckBox.Text = "十六进制";
            this.mReceiveHexadecimalCheckBox.UseVisualStyleBackColor = true;
            this.mReceiveHexadecimalCheckBox.CheckedChanged += new System.EventHandler(this.mReceiveHexadecimalCheckBox_CheckedChanged);
            // 
            // mSelectReceivePathButton
            // 
            this.mSelectReceivePathButton.Location = new System.Drawing.Point(9, 78);
            this.mSelectReceivePathButton.Name = "mSelectReceivePathButton";
            this.mSelectReceivePathButton.Size = new System.Drawing.Size(72, 23);
            this.mSelectReceivePathButton.TabIndex = 1;
            this.mSelectReceivePathButton.Text = "选择路径";
            this.mSelectReceivePathButton.UseVisualStyleBackColor = true;
            // 
            // mAutoClearCheckBox
            // 
            this.mAutoClearCheckBox.AutoSize = true;
            this.mAutoClearCheckBox.Location = new System.Drawing.Point(9, 20);
            this.mAutoClearCheckBox.Name = "mAutoClearCheckBox";
            this.mAutoClearCheckBox.Size = new System.Drawing.Size(72, 16);
            this.mAutoClearCheckBox.TabIndex = 0;
            this.mAutoClearCheckBox.Text = "自动清空";
            this.mAutoClearCheckBox.UseVisualStyleBackColor = true;
            this.mAutoClearCheckBox.CheckedChanged += new System.EventHandler(this.mAutoClearCheckBox_CheckedChanged);
            // 
            // mSendConfigGroupBox
            // 
            this.mSendConfigGroupBox.Controls.Add(this.mAutomaticSendingCycleText);
            this.mSendConfigGroupBox.Controls.Add(this.mAutomaticSendingCycleLable);
            this.mSendConfigGroupBox.Controls.Add(this.mOpenFilePathText);
            this.mSendConfigGroupBox.Controls.Add(this.mSendFileButton);
            this.mSendConfigGroupBox.Controls.Add(this.mManualSendButton);
            this.mSendConfigGroupBox.Controls.Add(this.mAutoSendCheckBox);
            this.mSendConfigGroupBox.Controls.Add(this.mClearSendButton);
            this.mSendConfigGroupBox.Controls.Add(this.mOpenFileButton);
            this.mSendConfigGroupBox.Controls.Add(this.mSendHexadecimalCheckBox);
            this.mSendConfigGroupBox.Location = new System.Drawing.Point(12, 409);
            this.mSendConfigGroupBox.Name = "mSendConfigGroupBox";
            this.mSendConfigGroupBox.Size = new System.Drawing.Size(217, 171);
            this.mSendConfigGroupBox.TabIndex = 0;
            this.mSendConfigGroupBox.TabStop = false;
            this.mSendConfigGroupBox.Text = "发送配置";
            // 
            // mAutomaticSendingCycleText
            // 
            this.mAutomaticSendingCycleText.Location = new System.Drawing.Point(127, 141);
            this.mAutomaticSendingCycleText.Name = "mAutomaticSendingCycleText";
            this.mAutomaticSendingCycleText.Size = new System.Drawing.Size(84, 21);
            this.mAutomaticSendingCycleText.TabIndex = 4;
            // 
            // mAutomaticSendingCycleLable
            // 
            this.mAutomaticSendingCycleLable.AutoSize = true;
            this.mAutomaticSendingCycleLable.Location = new System.Drawing.Point(7, 145);
            this.mAutomaticSendingCycleLable.Name = "mAutomaticSendingCycleLable";
            this.mAutomaticSendingCycleLable.Size = new System.Drawing.Size(113, 12);
            this.mAutomaticSendingCycleLable.TabIndex = 3;
            this.mAutomaticSendingCycleLable.Text = "自动发送周期(ms)：";
            // 
            // mOpenFilePathText
            // 
            this.mOpenFilePathText.Location = new System.Drawing.Point(9, 108);
            this.mOpenFilePathText.Name = "mOpenFilePathText";
            this.mOpenFilePathText.Size = new System.Drawing.Size(202, 21);
            this.mOpenFilePathText.TabIndex = 2;
            // 
            // mSendFileButton
            // 
            this.mSendFileButton.Location = new System.Drawing.Point(106, 78);
            this.mSendFileButton.Name = "mSendFileButton";
            this.mSendFileButton.Size = new System.Drawing.Size(105, 23);
            this.mSendFileButton.TabIndex = 1;
            this.mSendFileButton.Text = "发送文件";
            this.mSendFileButton.UseVisualStyleBackColor = true;
            // 
            // mManualSendButton
            // 
            this.mManualSendButton.Location = new System.Drawing.Point(106, 20);
            this.mManualSendButton.Name = "mManualSendButton";
            this.mManualSendButton.Size = new System.Drawing.Size(105, 23);
            this.mManualSendButton.TabIndex = 1;
            this.mManualSendButton.Text = "手动发送";
            this.mManualSendButton.UseVisualStyleBackColor = true;
            this.mManualSendButton.Click += new System.EventHandler(this.mManualSendButton_Click);
            // 
            // mAutoSendCheckBox
            // 
            this.mAutoSendCheckBox.AutoSize = true;
            this.mAutoSendCheckBox.Location = new System.Drawing.Point(9, 23);
            this.mAutoSendCheckBox.Name = "mAutoSendCheckBox";
            this.mAutoSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.mAutoSendCheckBox.TabIndex = 0;
            this.mAutoSendCheckBox.Text = "自动发送";
            this.mAutoSendCheckBox.UseVisualStyleBackColor = true;
            this.mAutoSendCheckBox.CheckedChanged += new System.EventHandler(this.mAutoSendCheckBox_CheckedChanged);
            // 
            // mClearSendButton
            // 
            this.mClearSendButton.Location = new System.Drawing.Point(106, 43);
            this.mClearSendButton.Name = "mClearSendButton";
            this.mClearSendButton.Size = new System.Drawing.Size(105, 23);
            this.mClearSendButton.TabIndex = 1;
            this.mClearSendButton.Text = "清空发送";
            this.mClearSendButton.UseVisualStyleBackColor = true;
            this.mClearSendButton.Click += new System.EventHandler(this.mClearSendButton_Click);
            // 
            // mOpenFileButton
            // 
            this.mOpenFileButton.Location = new System.Drawing.Point(9, 78);
            this.mOpenFileButton.Name = "mOpenFileButton";
            this.mOpenFileButton.Size = new System.Drawing.Size(72, 23);
            this.mOpenFileButton.TabIndex = 1;
            this.mOpenFileButton.Text = "打开文件";
            this.mOpenFileButton.UseVisualStyleBackColor = true;
            // 
            // mSendHexadecimalCheckBox
            // 
            this.mSendHexadecimalCheckBox.AutoSize = true;
            this.mSendHexadecimalCheckBox.Location = new System.Drawing.Point(9, 46);
            this.mSendHexadecimalCheckBox.Name = "mSendHexadecimalCheckBox";
            this.mSendHexadecimalCheckBox.Size = new System.Drawing.Size(72, 16);
            this.mSendHexadecimalCheckBox.TabIndex = 0;
            this.mSendHexadecimalCheckBox.Text = "十六进制";
            this.mSendHexadecimalCheckBox.UseVisualStyleBackColor = true;
            this.mSendHexadecimalCheckBox.CheckedChanged += new System.EventHandler(this.mSendHexadecimalCheckBox_CheckedChanged);
            // 
            // mReceiveArea
            // 
            this.mReceiveArea.Controls.Add(this.mReceiveAreaRichTextBox);
            this.mReceiveArea.Location = new System.Drawing.Point(235, 12);
            this.mReceiveArea.Name = "mReceiveArea";
            this.mReceiveArea.Size = new System.Drawing.Size(547, 391);
            this.mReceiveArea.TabIndex = 0;
            this.mReceiveArea.TabStop = false;
            this.mReceiveArea.Text = "接收区";
            // 
            // mReceiveAreaRichTextBox
            // 
            this.mReceiveAreaRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mReceiveAreaRichTextBox.Location = new System.Drawing.Point(3, 17);
            this.mReceiveAreaRichTextBox.Name = "mReceiveAreaRichTextBox";
            this.mReceiveAreaRichTextBox.Size = new System.Drawing.Size(541, 371);
            this.mReceiveAreaRichTextBox.TabIndex = 0;
            this.mReceiveAreaRichTextBox.Text = "";
            // 
            // mSednArea
            // 
            this.mSednArea.Controls.Add(this.mSendAreaRichTextBox);
            this.mSednArea.Location = new System.Drawing.Point(235, 409);
            this.mSednArea.Name = "mSednArea";
            this.mSednArea.Size = new System.Drawing.Size(547, 171);
            this.mSednArea.TabIndex = 0;
            this.mSednArea.TabStop = false;
            this.mSednArea.Text = "发送区";
            // 
            // mSendAreaRichTextBox
            // 
            this.mSendAreaRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.mSendAreaRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mSendAreaRichTextBox.Location = new System.Drawing.Point(3, 17);
            this.mSendAreaRichTextBox.Name = "mSendAreaRichTextBox";
            this.mSendAreaRichTextBox.Size = new System.Drawing.Size(541, 151);
            this.mSendAreaRichTextBox.TabIndex = 0;
            this.mSendAreaRichTextBox.Text = "";
            this.mSendAreaRichTextBox.Leave += new System.EventHandler(this.mSendAreaRichTextBox_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStatusToolStripStatusLabel,
            this.mStatusInfoToolStripStatusLabel,
            this.mSendCountToolStripStatusLabel,
            this.mSendCountInfoToolStripStatusLabel,
            this.mReceiveCountToolStripStatusLabel,
            this.mReceiveCountInfoToolStripStatusLabel,
            this.mClearCountToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mStatusToolStripStatusLabel
            // 
            this.mStatusToolStripStatusLabel.Name = "mStatusToolStripStatusLabel";
            this.mStatusToolStripStatusLabel.Size = new System.Drawing.Size(44, 17);
            this.mStatusToolStripStatusLabel.Text = "状态：";
            // 
            // mStatusInfoToolStripStatusLabel
            // 
            this.mStatusInfoToolStripStatusLabel.Name = "mStatusInfoToolStripStatusLabel";
            this.mStatusInfoToolStripStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.mStatusInfoToolStripStatusLabel.Text = "初始化正常！";
            // 
            // mSendCountToolStripStatusLabel
            // 
            this.mSendCountToolStripStatusLabel.Name = "mSendCountToolStripStatusLabel";
            this.mSendCountToolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.mSendCountToolStripStatusLabel.Text = "发送计数：";
            // 
            // mSendCountInfoToolStripStatusLabel
            // 
            this.mSendCountInfoToolStripStatusLabel.Name = "mSendCountInfoToolStripStatusLabel";
            this.mSendCountInfoToolStripStatusLabel.Size = new System.Drawing.Size(15, 17);
            this.mSendCountInfoToolStripStatusLabel.Text = "0";
            // 
            // mReceiveCountToolStripStatusLabel
            // 
            this.mReceiveCountToolStripStatusLabel.Name = "mReceiveCountToolStripStatusLabel";
            this.mReceiveCountToolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.mReceiveCountToolStripStatusLabel.Text = "接收计数：";
            // 
            // mReceiveCountInfoToolStripStatusLabel
            // 
            this.mReceiveCountInfoToolStripStatusLabel.Name = "mReceiveCountInfoToolStripStatusLabel";
            this.mReceiveCountInfoToolStripStatusLabel.Size = new System.Drawing.Size(15, 17);
            this.mReceiveCountInfoToolStripStatusLabel.Text = "0";
            // 
            // mClearCountToolStripStatusLabel
            // 
            this.mClearCountToolStripStatusLabel.Name = "mClearCountToolStripStatusLabel";
            this.mClearCountToolStripStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.mClearCountToolStripStatusLabel.Text = "全部清除";
            this.mClearCountToolStripStatusLabel.Click += new System.EventHandler(this.mClearCountToolStripStatusLabel_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // mAutoClearReceiveTimer
            // 
            this.mAutoClearReceiveTimer.Tick += new System.EventHandler(this.mAutoClearReceiveTimer_Tick);
            // 
            // SerialPortAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 620);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mReceiveArea);
            this.Controls.Add(this.mSednArea);
            this.Controls.Add(this.mSendConfigGroupBox);
            this.Controls.Add(this.mReceiveConfigGroupBox);
            this.Controls.Add(this.mSerialPortConfigGroupBox);
            this.Name = "SerialPortAssistant";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.SerialPortAssistant_Load);
            this.mSerialPortConfigGroupBox.ResumeLayout(false);
            this.mSerialPortConfigGroupBox.PerformLayout();
            this.mReceiveConfigGroupBox.ResumeLayout(false);
            this.mReceiveConfigGroupBox.PerformLayout();
            this.mSendConfigGroupBox.ResumeLayout(false);
            this.mSendConfigGroupBox.PerformLayout();
            this.mReceiveArea.ResumeLayout(false);
            this.mSednArea.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mSerialPortConfigGroupBox;
        private System.Windows.Forms.GroupBox mReceiveConfigGroupBox;
        private System.Windows.Forms.GroupBox mSendConfigGroupBox;
        private System.Windows.Forms.GroupBox mReceiveArea;
        private System.Windows.Forms.ComboBox mStopBits;
        private System.Windows.Forms.ComboBox mDataBits;
        private System.Windows.Forms.ComboBox mCheckDigit;
        private System.Windows.Forms.ComboBox mBaudRate;
        private System.Windows.Forms.ComboBox mPortNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mStopBitsLable;
        private System.Windows.Forms.Label mDataBitsLable;
        private System.Windows.Forms.Label mCheckDigitLable;
        private System.Windows.Forms.Label mBaudRateLable;
        private System.Windows.Forms.Label mPortNoLable;
        private System.Windows.Forms.GroupBox mSednArea;
        private System.Windows.Forms.Button mOpenSerialPortButton;
        private System.Windows.Forms.CheckBox mDTRCheckBox;
        private System.Windows.Forms.CheckBox mRTSCheckBox;
        private System.Windows.Forms.Button mSaveReceiveDataButton;
        private System.Windows.Forms.Button mSelectReceivePathButton;
        private System.Windows.Forms.Button mStopReceiveButton;
        private System.Windows.Forms.Button mManualClearButton;
        private System.Windows.Forms.CheckBox mReceiveHexadecimalCheckBox;
        private System.Windows.Forms.CheckBox mAutoClearCheckBox;
        private System.Windows.Forms.TextBox mSelectReceivePathText;
        private System.Windows.Forms.TextBox mOpenFilePathText;
        private System.Windows.Forms.Button mSendFileButton;
        private System.Windows.Forms.Button mManualSendButton;
        private System.Windows.Forms.CheckBox mAutoSendCheckBox;
        private System.Windows.Forms.Button mClearSendButton;
        private System.Windows.Forms.Button mOpenFileButton;
        private System.Windows.Forms.CheckBox mSendHexadecimalCheckBox;
        private System.Windows.Forms.TextBox mAutomaticSendingCycleText;
        private System.Windows.Forms.Label mAutomaticSendingCycleLable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mStatusToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mStatusInfoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mSendCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mSendCountInfoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mReceiveCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mReceiveCountInfoToolStripStatusLabel;
        private System.Windows.Forms.RichTextBox mReceiveAreaRichTextBox;
        private System.Windows.Forms.RichTextBox mSendAreaRichTextBox;
        private System.Windows.Forms.ToolStripStatusLabel mClearCountToolStripStatusLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer mAutoClearReceiveTimer;
    }
}

