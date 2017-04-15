using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace CSDemo
{
    public partial class Form1 : Form
    {
        private string[] _OCRSupportedLanguages = {"unk (AutoDetect)", "zh-Hans (ChineseSimplified)", "zh-Hant (ChineseTraditional)",
            "cs (Czech)", "da (Danish)", "nl (Dutch)", "en (English)", "fi (Finnish)", "fr (French)", "de (German)", "el (Greek)",
            "hu (Hungarian)", "it (Italian)", "Ja (Japanese)", "ko (Korean)", "nb (Norwegian)", "pl (Polish)", "pt (Portuguese" ,
            "ru (Russian)", "es (Spanish)", "sv (Swedish)", "tr (Turkish)"};
        private string[] _searchMarkets = { "", "es - AR", "en - AU", "de - AT", "nl-BE", "fr-BE", "pt-BR", "en-CA", "fr-CA", "es-CL",
            "da-DK", "fi-FI", "fr - FR", "de - DE", "zh-HK", "en-IN", "en-ID", "en-IE", "it-IT", "ja-JP", "ko-KR", "en-MY", "es-MX",
            "nl-NL", "en-NZ", "no - NO", "zh - CN", "pl-PL", "pt-PT", "en-PH", "ru-RU", "ar-SA", "en-ZA", "es-ES", "sv-SE", "fr-CH",
            "de-CH", "zh-TW", "tr - TR", "en - GB", "en-US", "es-US"};

        const string NOT_SET = "read from keys.txt";
        private string _visionKey = NOT_SET;
        private string _emotionKey = NOT_SET;
        private string _bingSpellCheckKey = NOT_SET;
        private string _bingSearchKey = NOT_SET;

        private int _enUSIndex = 0;

        public Form1()
        {
            InitializeComponent();
            ReadAPIKeys();
            pbImage.Visible = false;
            cmbxLanguage.DataSource = _OCRSupportedLanguages;
            var allLanguages = File.ReadAllLines("language_codes.txt");
            for (int i = 0; i < allLanguages.Length; i++)
                allLanguages[i] = allLanguages[i].Replace("\t", "  ");
            cmbxSpellCheckLanguage.DataSource = allLanguages;
            for(int i=0;i<cmbxSpellCheckLanguage.Items.Count;i++)
                if (cmbxSpellCheckLanguage.Items[i].ToString().StartsWith("en-US"))
                {
                    _enUSIndex = i;
                    break;
                }
            cmbxSpellCheckLanguage.SelectedIndex = _enUSIndex;
            cmbxSearchMarket.DataSource = _searchMarkets;
            cmbxSafeSearch.SelectedIndex = 0;                  
        }

        private void ReadAPIKeys() {
            try
            {
                var allKeys = File.ReadAllLines("keys.txt");
                foreach (string keyLine in allKeys)
                {
                    var parts = keyLine.Split(new char[] { '=' });
                    if (parts[0].Trim().ToUpper().Equals("VISION_KEY"))
                        _visionKey = parts[1].Trim();
                    if (parts[0].Trim().ToUpper().Equals("EMOTION_KEY"))
                        _emotionKey = parts[1].Trim();
                    if (parts[0].Trim().ToUpper().Equals("BING_SPELL_CHECK_KEY"))
                        _bingSpellCheckKey = parts[1].Trim();
                    if (parts[0].Trim().ToUpper().Equals("BING_SEARCH_KEY"))
                        _bingSearchKey = parts[1].Trim();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Problem in reading API keys from keys.txt. " + ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                tbImageName.Text = ofd.FileName;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbImageName.Text.Trim()))
            {
                MessageBox.Show("Image file isn't set.");
                return;
            }

            if (!File.Exists(tbImageName.Text))
            {
                MessageBox.Show("Image file doesn't exist");
                return;
            }

            if (pbImage.Image != null)           
                pbImage.Image.Dispose();
            var img = Image.FromFile(tbImageName.Text);
            pbImage.Visible = true;
            if (panelImage.Width < img.Width || panelImage.Height < img.Height)
            {
                int newWidth = 0;
                int newHeight = 0;

                if (img.Width >= img.Height)
                {
                    newHeight = (int)(panelImage.Width / (float)img.Width * img.Height);
                    newWidth = panelImage.Width;
                }
                else
                {
                    newWidth = (int)(panelImage.Height / (float)img.Height * img.Width);
                    newHeight = panelImage.Height;
                }

                pbImage.Size = new Size(newWidth, newHeight);
                pbImage.Image = new Bitmap(img, new Size(newWidth, newHeight));
            }
            else
            {
                pbImage.Size = img.Size;
                pbImage.Image = new Bitmap(img, img.Size);
            }

            pbImage.Location = new Point((panelImage.Width - pbImage.Width) / 2, (panelImage.Height - pbImage.Height) / 2);
            img.Dispose();
        }

        HttpResponseMessage response;

        public static string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
                using (var stringWriter = new StringWriter())
                {
                    var jsonReader = new JsonTextReader(stringReader);
                    var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                    jsonWriter.WriteToken(jsonReader);
                    return stringWriter.ToString();
                }
        }

        async void MakeImageAnalytzeRequest(string fileName)
        {
            if (_visionKey.Equals(NOT_SET) || string.IsNullOrEmpty(_visionKey))
            {
                string msg = "Vision key must be set in keys.txt";
                MessageBox.Show(msg);
                rtbResult.Text = msg;
                return;
            }
            
            rtbResult.Text = "";
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers                                                                           
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _visionKey);

            // Request parameters
            queryString["visualFeatures"] = "Categories,Tags,Description,Faces,ImageType,Color,Adult"; // moze samo dio ovih podataka...
            queryString["details"] = "Celebrities";
            queryString["language"] = "en"; // Po dokumentaciji dostupna su dva jezika: en - English, Default. zh - Simplified Chinese. Ako stavim zh ne radi.
            var uri = "https://westus.api.cognitive.microsoft.com/vision/v1.0/analyze?" + queryString;            

            // Request body
            byte[] byteData = File.ReadAllBytes(fileName);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream"); 
                                                   
                response = await client.PostAsync(uri, content);
                var str = response.Content.ReadAsStringAsync();
                rtbResult.Text = JsonPrettify(str.Result);
            }
        }

        async void MakeImageEmotionRequest(string fileName)
        {
            if (_emotionKey.Equals(NOT_SET) || string.IsNullOrEmpty(_emotionKey))
            {
                string msg = "Emotion key must be set in keys.txt";
                MessageBox.Show(msg);
                rtbResult.Text = msg;
                return;
            }

            rtbResult.Text = "";
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers                                                                           
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _emotionKey);

            // Request parameters           
            var uri = "https://westus.api.cognitive.microsoft.com/emotion/v1.0/recognize?" + queryString;

            // Request body
            byte[] byteData = File.ReadAllBytes(fileName);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                response = await client.PostAsync(uri, content);
                var str = response.Content.ReadAsStringAsync();
                rtbResult.Text = JsonPrettify(str.Result);
            }
        }

        async void MakeOCRRequest(string fileName, string language, bool detectOrientation)
        {
            if (_visionKey.Equals(NOT_SET) || string.IsNullOrEmpty(_visionKey))
            {
                string msg = "Vision key must be set in keys.txt";
                MessageBox.Show(msg);
                rtbResult.Text = msg;
                return;
            }

            rtbResult.Text = "";
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers                                                                           
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _visionKey);
            
            queryString["detectOrientation"] = detectOrientation ? "true" : "false";
            queryString["language"] = language;

            // Request parameters           
            var uri = "https://westus.api.cognitive.microsoft.com/vision/v1.0/ocr?" + queryString;

            // Request body
            byte[] byteData = File.ReadAllBytes(fileName);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                response = await client.PostAsync(uri, content);
                var str = response.Content.ReadAsStringAsync();
                rtbResult.Text = JsonPrettify(str.Result);
            }
        }

        private void btnAnalyzeImage_Click(object sender, EventArgs e)
        {
            MakeImageAnalytzeRequest(tbImageName.Text);
        }

        private void btnGetEmotions_Click(object sender, EventArgs e)
        {
            MakeImageEmotionRequest(tbImageName.Text);
        }

        private void btnGetOCR_Click(object sender, EventArgs e)
        {
            string selectedLanguage = cmbxLanguage.SelectedValue.ToString();
            string ocrLanguage = selectedLanguage.Substring(0, selectedLanguage.IndexOf("(")).Trim();
            MakeOCRRequest(tbImageName.Text, ocrLanguage, cbOCRDetectOrientation.Checked);
        }

        async void MakeSpellCheckRequest(string text, string mode, string mkt, string precontext, string postcontext)
        {
            if (_bingSpellCheckKey.Equals(NOT_SET) || string.IsNullOrEmpty(_bingSpellCheckKey))
            {
                string msg = "Bing spell check key must be set in keys.txt";
                MessageBox.Show(msg);
                rtbSpellCheckResult.Text = msg;
                return;
            }

            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers                                                                           
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _bingSpellCheckKey);

            // Request parameters
            queryString["mode"] = mode;
            queryString["mkt"] = mkt;
            queryString["text"] = text;
            if (!string.IsNullOrEmpty(precontext))
                queryString["preContextText"] = precontext;
            if (!string.IsNullOrEmpty(postcontext))
                queryString["postContextText"] = postcontext;
            
            var uri = "https://api.cognitive.microsoft.com/bing/v5.0/spellcheck?" + queryString;
    
            var response = await client.GetAsync(uri);
            var str = response.Content.ReadAsStringAsync();
            rtbSpellCheckResult.Text = JsonPrettify(str.Result);
        }

        async void MakeSearchRequest(string query, string type, string count = "", string offset = "", string mkt = "", string safesearch = "")
        {
            if (_bingSearchKey.Equals(NOT_SET) || string.IsNullOrEmpty(_bingSearchKey))
            {
                string msg = "Bing search key must be set in keys.txt";
                rtbSearch.Text = msg;
                MessageBox.Show(msg);                
                return;
            }

            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers                                                                           
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _bingSearchKey);

            // Request parameters
            queryString["q"] = query;
            if (!string.IsNullOrEmpty(count))
                queryString["count"] = count;

            if (!string.IsNullOrEmpty(mkt))
                queryString["mkt"] = mkt;

            if (!string.IsNullOrEmpty(offset))
                queryString["offset"] = offset;

            if (!string.IsNullOrEmpty(safesearch))
                queryString["safesearch"] = safesearch;           

            var uri = string.Format("https://api.cognitive.microsoft.com/bing/v5.0/{0}search?", type) + queryString;

            var response = await client.GetAsync(uri);
            var str = response.Content.ReadAsStringAsync();
            rtbSearch.Text = JsonPrettify(str.Result);
        }

        private void btnSpellCheck_Click(object sender, EventArgs e)
        {
            string selectedLanguage = cmbxSpellCheckLanguage.SelectedValue.ToString();
            selectedLanguage = selectedLanguage.Substring(0, selectedLanguage.IndexOf("  ")).Trim();
            MakeSpellCheckRequest(tbSpellCheck.Text, rbProofMode.Checked ? "proof" : "spell", selectedLanguage, tbPreContext.Text, tbPostContext.Text);
        }
        
        private void rbSpellMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProofMode.Checked)
                cmbxSpellCheckLanguage.SelectedIndex = _enUSIndex;
            cmbxSpellCheckLanguage.Enabled = !rbProofMode.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string type = rbNews.Checked ? "news/" : rbSearchAllWeb.Checked ? "" : rbSearchImage.Checked ? "images/" : rbSearchVideo.Checked ? "videos/" : "";
            MakeSearchRequest(tbQuery.Text, type, numCount.Value.ToString(), numOffset.Value.ToString(), cmbxSearchMarket.SelectedValue.ToString(), cmbxSafeSearch.SelectedItem.ToString());
        }
    }
}
