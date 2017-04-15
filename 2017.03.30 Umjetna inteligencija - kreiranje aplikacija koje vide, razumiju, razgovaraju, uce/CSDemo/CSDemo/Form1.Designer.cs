namespace CSDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbImageName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnAnalyzeImage = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVision = new System.Windows.Forms.TabPage();
            this.gbOCR = new System.Windows.Forms.GroupBox();
            this.cbOCRDetectOrientation = new System.Windows.Forms.CheckBox();
            this.btnGetOCR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxLanguage = new System.Windows.Forms.ComboBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetEmotions = new System.Windows.Forms.Button();
            this.tabPageSpellCheck = new System.Windows.Forms.TabPage();
            this.btnSpellCheckOptions = new System.Windows.Forms.GroupBox();
            this.tbPostContext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPreContext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxSpellCheckLanguage = new System.Windows.Forms.ComboBox();
            this.rbProofMode = new System.Windows.Forms.RadioButton();
            this.rbSpellMode = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbSpellCheckResult = new System.Windows.Forms.RichTextBox();
            this.btnSpellCheck = new System.Windows.Forms.Button();
            this.tbSpellCheck = new System.Windows.Forms.TextBox();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.cmbxSearchMarket = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbxSafeSearch = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbSearchVideo = new System.Windows.Forms.RadioButton();
            this.rbNews = new System.Windows.Forms.RadioButton();
            this.rbSearchAllWeb = new System.Windows.Forms.RadioButton();
            this.rbSearchImage = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageVision.SuspendLayout();
            this.gbOCR.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabPageSpellCheck.SuspendLayout();
            this.btnSpellCheckOptions.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Image:";
            // 
            // tbImageName
            // 
            this.tbImageName.Location = new System.Drawing.Point(6, 20);
            this.tbImageName.Name = "tbImageName";
            this.tbImageName.Size = new System.Drawing.Size(551, 20);
            this.tbImageName.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(563, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(46, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(615, 18);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(62, 23);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnAnalyzeImage
            // 
            this.btnAnalyzeImage.Location = new System.Drawing.Point(12, 374);
            this.btnAnalyzeImage.Name = "btnAnalyzeImage";
            this.btnAnalyzeImage.Size = new System.Drawing.Size(152, 23);
            this.btnAnalyzeImage.TabIndex = 5;
            this.btnAnalyzeImage.Text = "Analyze image";
            this.btnAnalyzeImage.UseVisualStyleBackColor = true;
            this.btnAnalyzeImage.Click += new System.EventHandler(this.btnAnalyzeImage_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(329, 69);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(627, 613);
            this.rtbResult.TabIndex = 6;
            this.rtbResult.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVision);
            this.tabControl1.Controls.Add(this.tabPageSpellCheck);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 717);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageVision
            // 
            this.tabPageVision.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageVision.Controls.Add(this.btnAnalyzeImage);
            this.tabPageVision.Controls.Add(this.gbOCR);
            this.tabPageVision.Controls.Add(this.panelImage);
            this.tabPageVision.Controls.Add(this.label7);
            this.tabPageVision.Controls.Add(this.btnGetEmotions);
            this.tabPageVision.Controls.Add(this.label1);
            this.tabPageVision.Controls.Add(this.label2);
            this.tabPageVision.Controls.Add(this.tbImageName);
            this.tabPageVision.Controls.Add(this.rtbResult);
            this.tabPageVision.Controls.Add(this.btnOpen);
            this.tabPageVision.Controls.Add(this.btnLoadImage);
            this.tabPageVision.Location = new System.Drawing.Point(4, 22);
            this.tabPageVision.Name = "tabPageVision";
            this.tabPageVision.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVision.Size = new System.Drawing.Size(966, 691);
            this.tabPageVision.TabIndex = 0;
            this.tabPageVision.Text = "Vision";
            // 
            // gbOCR
            // 
            this.gbOCR.Controls.Add(this.cbOCRDetectOrientation);
            this.gbOCR.Controls.Add(this.btnGetOCR);
            this.gbOCR.Controls.Add(this.label5);
            this.gbOCR.Controls.Add(this.cmbxLanguage);
            this.gbOCR.Location = new System.Drawing.Point(6, 585);
            this.gbOCR.Name = "gbOCR";
            this.gbOCR.Size = new System.Drawing.Size(317, 100);
            this.gbOCR.TabIndex = 23;
            this.gbOCR.TabStop = false;
            this.gbOCR.Text = "OCR";
            // 
            // cbOCRDetectOrientation
            // 
            this.cbOCRDetectOrientation.AutoSize = true;
            this.cbOCRDetectOrientation.Location = new System.Drawing.Point(180, 34);
            this.cbOCRDetectOrientation.Name = "cbOCRDetectOrientation";
            this.cbOCRDetectOrientation.Size = new System.Drawing.Size(110, 17);
            this.cbOCRDetectOrientation.TabIndex = 13;
            this.cbOCRDetectOrientation.Text = "Detect orientation";
            this.cbOCRDetectOrientation.UseVisualStyleBackColor = true;
            // 
            // btnGetOCR
            // 
            this.btnGetOCR.Location = new System.Drawing.Point(60, 71);
            this.btnGetOCR.Name = "btnGetOCR";
            this.btnGetOCR.Size = new System.Drawing.Size(168, 23);
            this.btnGetOCR.TabIndex = 10;
            this.btnGetOCR.Text = "Read text (OCR) from image";
            this.btnGetOCR.UseVisualStyleBackColor = true;
            this.btnGetOCR.Click += new System.EventHandler(this.btnGetOCR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Language:";
            // 
            // cmbxLanguage
            // 
            this.cmbxLanguage.BackColor = System.Drawing.Color.White;
            this.cmbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxLanguage.FormattingEnabled = true;
            this.cmbxLanguage.Location = new System.Drawing.Point(6, 32);
            this.cmbxLanguage.Name = "cmbxLanguage";
            this.cmbxLanguage.Size = new System.Drawing.Size(168, 21);
            this.cmbxLanguage.TabIndex = 11;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImage.Controls.Add(this.pbImage);
            this.panelImage.Location = new System.Drawing.Point(10, 70);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(313, 286);
            this.panelImage.TabIndex = 22;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(6, 13);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(55, 50);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Main image:";
            // 
            // btnGetEmotions
            // 
            this.btnGetEmotions.Location = new System.Drawing.Point(12, 476);
            this.btnGetEmotions.Name = "btnGetEmotions";
            this.btnGetEmotions.Size = new System.Drawing.Size(152, 23);
            this.btnGetEmotions.TabIndex = 13;
            this.btnGetEmotions.Text = "Emotions from image";
            this.btnGetEmotions.UseVisualStyleBackColor = true;
            this.btnGetEmotions.Click += new System.EventHandler(this.btnGetEmotions_Click);
            // 
            // tabPageSpellCheck
            // 
            this.tabPageSpellCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageSpellCheck.Controls.Add(this.btnSpellCheckOptions);
            this.tabPageSpellCheck.Controls.Add(this.label8);
            this.tabPageSpellCheck.Controls.Add(this.label6);
            this.tabPageSpellCheck.Controls.Add(this.rtbSpellCheckResult);
            this.tabPageSpellCheck.Controls.Add(this.btnSpellCheck);
            this.tabPageSpellCheck.Controls.Add(this.tbSpellCheck);
            this.tabPageSpellCheck.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpellCheck.Name = "tabPageSpellCheck";
            this.tabPageSpellCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpellCheck.Size = new System.Drawing.Size(966, 691);
            this.tabPageSpellCheck.TabIndex = 2;
            this.tabPageSpellCheck.Text = "Bing Spell Check";
            // 
            // btnSpellCheckOptions
            // 
            this.btnSpellCheckOptions.Controls.Add(this.tbPostContext);
            this.btnSpellCheckOptions.Controls.Add(this.label11);
            this.btnSpellCheckOptions.Controls.Add(this.tbPreContext);
            this.btnSpellCheckOptions.Controls.Add(this.label10);
            this.btnSpellCheckOptions.Controls.Add(this.label9);
            this.btnSpellCheckOptions.Controls.Add(this.cmbxSpellCheckLanguage);
            this.btnSpellCheckOptions.Controls.Add(this.rbProofMode);
            this.btnSpellCheckOptions.Controls.Add(this.rbSpellMode);
            this.btnSpellCheckOptions.Location = new System.Drawing.Point(10, 241);
            this.btnSpellCheckOptions.Name = "btnSpellCheckOptions";
            this.btnSpellCheckOptions.Size = new System.Drawing.Size(869, 60);
            this.btnSpellCheckOptions.TabIndex = 10;
            this.btnSpellCheckOptions.TabStop = false;
            this.btnSpellCheckOptions.Text = "Options";
            // 
            // tbPostContext
            // 
            this.tbPostContext.Location = new System.Drawing.Point(413, 28);
            this.tbPostContext.Name = "tbPostContext";
            this.tbPostContext.Size = new System.Drawing.Size(100, 20);
            this.tbPostContext.TabIndex = 7;
            this.toolTip1.SetToolTip(this.tbPostContext, "A string that gives context to the text string. ");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Postcontext:";
            // 
            // tbPreContext
            // 
            this.tbPreContext.Location = new System.Drawing.Point(244, 28);
            this.tbPreContext.Name = "tbPreContext";
            this.tbPreContext.Size = new System.Drawing.Size(100, 20);
            this.tbPreContext.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbPreContext, "A string that gives context to the text string. ");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Precontext:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Language:";
            // 
            // cmbxSpellCheckLanguage
            // 
            this.cmbxSpellCheckLanguage.BackColor = System.Drawing.Color.White;
            this.cmbxSpellCheckLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSpellCheckLanguage.FormattingEnabled = true;
            this.cmbxSpellCheckLanguage.Location = new System.Drawing.Point(610, 28);
            this.cmbxSpellCheckLanguage.Name = "cmbxSpellCheckLanguage";
            this.cmbxSpellCheckLanguage.Size = new System.Drawing.Size(253, 21);
            this.cmbxSpellCheckLanguage.TabIndex = 2;
            // 
            // rbProofMode
            // 
            this.rbProofMode.AutoSize = true;
            this.rbProofMode.Location = new System.Drawing.Point(89, 29);
            this.rbProofMode.Name = "rbProofMode";
            this.rbProofMode.Size = new System.Drawing.Size(79, 17);
            this.rbProofMode.TabIndex = 1;
            this.rbProofMode.Text = "Proof mode";
            this.toolTip1.SetToolTip(this.rbProofMode, "Meant to provide Office Word like spelling corrections. It can correct long queri" +
        "es, provide casing corrections and suppresses aggressive corrections.");
            this.rbProofMode.UseVisualStyleBackColor = true;
            // 
            // rbSpellMode
            // 
            this.rbSpellMode.AutoSize = true;
            this.rbSpellMode.Checked = true;
            this.rbSpellMode.Location = new System.Drawing.Point(6, 29);
            this.rbSpellMode.Name = "rbSpellMode";
            this.rbSpellMode.Size = new System.Drawing.Size(77, 17);
            this.rbSpellMode.TabIndex = 0;
            this.rbSpellMode.TabStop = true;
            this.rbSpellMode.Text = "Spell mode";
            this.toolTip1.SetToolTip(this.rbSpellMode, resources.GetString("rbSpellMode.ToolTip"));
            this.rbSpellMode.UseVisualStyleBackColor = true;
            this.rbSpellMode.CheckedChanged += new System.EventHandler(this.rbSpellMode_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Result:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Text:";
            // 
            // rtbSpellCheckResult
            // 
            this.rtbSpellCheckResult.Location = new System.Drawing.Point(10, 326);
            this.rtbSpellCheckResult.Name = "rtbSpellCheckResult";
            this.rtbSpellCheckResult.Size = new System.Drawing.Size(950, 355);
            this.rtbSpellCheckResult.TabIndex = 7;
            this.rtbSpellCheckResult.Text = "";
            // 
            // btnSpellCheck
            // 
            this.btnSpellCheck.Location = new System.Drawing.Point(885, 270);
            this.btnSpellCheck.Name = "btnSpellCheck";
            this.btnSpellCheck.Size = new System.Drawing.Size(75, 23);
            this.btnSpellCheck.TabIndex = 1;
            this.btnSpellCheck.Text = "Spell Check";
            this.btnSpellCheck.UseVisualStyleBackColor = true;
            this.btnSpellCheck.Click += new System.EventHandler(this.btnSpellCheck_Click);
            // 
            // tbSpellCheck
            // 
            this.tbSpellCheck.Location = new System.Drawing.Point(6, 25);
            this.tbSpellCheck.Multiline = true;
            this.tbSpellCheck.Name = "tbSpellCheck";
            this.tbSpellCheck.Size = new System.Drawing.Size(954, 210);
            this.tbSpellCheck.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageSearch.Controls.Add(this.cmbxSearchMarket);
            this.tabPageSearch.Controls.Add(this.label15);
            this.tabPageSearch.Controls.Add(this.numOffset);
            this.tabPageSearch.Controls.Add(this.label14);
            this.tabPageSearch.Controls.Add(this.numCount);
            this.tabPageSearch.Controls.Add(this.label13);
            this.tabPageSearch.Controls.Add(this.cmbxSafeSearch);
            this.tabPageSearch.Controls.Add(this.label12);
            this.tabPageSearch.Controls.Add(this.rbSearchVideo);
            this.tabPageSearch.Controls.Add(this.rbNews);
            this.tabPageSearch.Controls.Add(this.rbSearchAllWeb);
            this.tabPageSearch.Controls.Add(this.rbSearchImage);
            this.tabPageSearch.Controls.Add(this.label4);
            this.tabPageSearch.Controls.Add(this.label3);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.rtbSearch);
            this.tabPageSearch.Controls.Add(this.tbQuery);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(966, 691);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Bing Search";
            // 
            // cmbxSearchMarket
            // 
            this.cmbxSearchMarket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchMarket.FormattingEnabled = true;
            this.cmbxSearchMarket.Location = new System.Drawing.Point(737, 57);
            this.cmbxSearchMarket.Name = "cmbxSearchMarket";
            this.cmbxSearchMarket.Size = new System.Drawing.Size(69, 21);
            this.cmbxSearchMarket.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(688, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Market:";
            // 
            // numOffset
            // 
            this.numOffset.Location = new System.Drawing.Point(572, 90);
            this.numOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(56, 20);
            this.numOffset.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(528, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Offset:";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(572, 62);
            this.numCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(63, 20);
            this.numCount.TabIndex = 12;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(528, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Count:";
            // 
            // cmbxSafeSearch
            // 
            this.cmbxSafeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSafeSearch.FormattingEnabled = true;
            this.cmbxSafeSearch.Items.AddRange(new object[] {
            "Off",
            "Moderate",
            "Strict"});
            this.cmbxSafeSearch.Location = new System.Drawing.Point(715, 89);
            this.cmbxSafeSearch.Name = "cmbxSafeSearch";
            this.cmbxSafeSearch.Size = new System.Drawing.Size(91, 21);
            this.cmbxSafeSearch.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(641, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Safe search:";
            // 
            // rbSearchVideo
            // 
            this.rbSearchVideo.AutoSize = true;
            this.rbSearchVideo.Location = new System.Drawing.Point(754, 27);
            this.rbSearchVideo.Name = "rbSearchVideo";
            this.rbSearchVideo.Size = new System.Drawing.Size(52, 17);
            this.rbSearchVideo.TabIndex = 8;
            this.rbSearchVideo.Text = "Video";
            this.rbSearchVideo.UseVisualStyleBackColor = true;
            // 
            // rbNews
            // 
            this.rbNews.AutoSize = true;
            this.rbNews.Location = new System.Drawing.Point(695, 27);
            this.rbNews.Name = "rbNews";
            this.rbNews.Size = new System.Drawing.Size(52, 17);
            this.rbNews.TabIndex = 7;
            this.rbNews.Text = "News";
            this.rbNews.UseVisualStyleBackColor = true;
            // 
            // rbSearchAllWeb
            // 
            this.rbSearchAllWeb.AutoSize = true;
            this.rbSearchAllWeb.Checked = true;
            this.rbSearchAllWeb.Location = new System.Drawing.Point(569, 27);
            this.rbSearchAllWeb.Name = "rbSearchAllWeb";
            this.rbSearchAllWeb.Size = new System.Drawing.Size(59, 17);
            this.rbSearchAllWeb.TabIndex = 6;
            this.rbSearchAllWeb.TabStop = true;
            this.rbSearchAllWeb.Text = "All web";
            this.rbSearchAllWeb.UseVisualStyleBackColor = true;
            // 
            // rbSearchImage
            // 
            this.rbSearchImage.AutoSize = true;
            this.rbSearchImage.Location = new System.Drawing.Point(634, 27);
            this.rbSearchImage.Name = "rbSearchImage";
            this.rbSearchImage.Size = new System.Drawing.Size(54, 17);
            this.rbSearchImage.TabIndex = 5;
            this.rbSearchImage.Text = "Image";
            this.rbSearchImage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Response:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtbSearch
            // 
            this.rtbSearch.Location = new System.Drawing.Point(7, 116);
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(953, 568);
            this.rtbSearch.TabIndex = 1;
            this.rtbSearch.Text = "";
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(7, 30);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(402, 20);
            this.tbQuery.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 730);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cognitive Services Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVision.ResumeLayout(false);
            this.tabPageVision.PerformLayout();
            this.gbOCR.ResumeLayout(false);
            this.gbOCR.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabPageSpellCheck.ResumeLayout(false);
            this.tabPageSpellCheck.PerformLayout();
            this.btnSpellCheckOptions.ResumeLayout(false);
            this.btnSpellCheckOptions.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImageName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnAnalyzeImage;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVision;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.ComboBox cmbxLanguage;
        private System.Windows.Forms.Button btnGetOCR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetEmotions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageSpellCheck;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox gbOCR;
        private System.Windows.Forms.CheckBox cbOCRDetectOrientation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbSpellCheckResult;
        private System.Windows.Forms.Button btnSpellCheck;
        private System.Windows.Forms.TextBox tbSpellCheck;
        private System.Windows.Forms.GroupBox btnSpellCheckOptions;
        private System.Windows.Forms.RadioButton rbProofMode;
        private System.Windows.Forms.RadioButton rbSpellMode;
        private System.Windows.Forms.ComboBox cmbxSpellCheckLanguage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbPostContext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPreContext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbxSearchMarket;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbxSafeSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbSearchVideo;
        private System.Windows.Forms.RadioButton rbNews;
        private System.Windows.Forms.RadioButton rbSearchAllWeb;
        private System.Windows.Forms.RadioButton rbSearchImage;
    }
}

