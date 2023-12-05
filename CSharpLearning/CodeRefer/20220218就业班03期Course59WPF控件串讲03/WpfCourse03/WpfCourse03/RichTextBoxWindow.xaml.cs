using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfCourse03
{
    /// <summary>
    /// RichTextBoxWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RichTextBoxWindow : Window
    {
        public RichTextBoxWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 将文件加载到RichTextBox中
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="richTextBox"></param>
        private static void LoadFile(string filename, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentNullException();
            }
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (FileStream stream = File.OpenRead(filename))
            {
                TextRange documentTextRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                string dataFormat = DataFormats.Text;
                string ext = System.IO.Path.GetExtension(filename);
                if (String.Compare(ext, ".txt", true) == 0)
                {
                    dataFormat = DataFormats.Text;
                }
                else if (String.Compare(ext, ".rtf", true) == 0)
                {
                    dataFormat = DataFormats.Rtf;
                }
                else if (String.Compare(ext, ".xaml", true) == 0)
                {
                    dataFormat = DataFormats.Xaml;
                }
                documentTextRange.Load(stream, dataFormat);
            }
        }


        /// <summary>
        /// RichTextBox内容保存到文件
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="richTextBox"></param>
        private static void SaveFile(string filename, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentNullException();
            }
            using (FileStream stream = File.OpenWrite(filename))
            {
                TextRange documentTextRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                string dataFormat = DataFormats.Text;
                string ext = System.IO.Path.GetExtension(filename);
                if (String.Compare(ext, ".xaml", true) == 0)
                {
                    dataFormat = DataFormats.Xaml;
                }
                else if (String.Compare(ext, ".rtf", true) == 0)
                {
                    dataFormat = DataFormats.Rtf;
                }
                else if (String.Compare(ext, ".txt", true) == 0)
                {
                    dataFormat = DataFormats.Text;
                }
                documentTextRange.Save(stream, dataFormat);
            }
        }

        /// <summary>
        /// 以Rtf格式取出
        /// </summary>
        private void GetRtf(RichTextBox richTextBox)
        {
            string rtf = string.Empty;
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                textRange.Save(ms, System.Windows.DataFormats.Rtf);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                System.IO.StreamReader sr = new System.IO.StreamReader(ms);
                rtf = sr.ReadToEnd();
            }
        }

        /// <summary>
        /// 获取指定RichTextBox的内容
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <returns></returns>
        private string GetText(RichTextBox richTextBox)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            return textRange.Text;
        }

        /// <summary>
        ///  将RTF (rich text format)放到RichTextBox中
        /// </summary>
        /// <param name="rtf"></param>
        /// <param name="richTextBox"></param>
        private static void LoadRTF(string rtf, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(rtf))
            {
                throw new ArgumentNullException();
            }
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            using (MemoryStream rtfMemoryStream = new MemoryStream())
            {
                using (StreamWriter rtfStreamWriter = new StreamWriter(rtfMemoryStream))
                {
                    rtfStreamWriter.Write(rtf);
                    rtfStreamWriter.Flush();
                    rtfMemoryStream.Seek(0, SeekOrigin.Begin);
                    //Load the MemoryStream into TextRange ranging from start to end of RichTextBox.  
                    textRange.Load(rtfMemoryStream, DataFormats.Rtf);
                }
            }
        }

        /// <summary>
        /// 将纯文本文件内容读取放入RichTextBox中
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="filename"></param>
        private void LoadTextFile(RichTextBox richTextBox, string filename)
        {
            richTextBox.Document.Blocks.Clear();
            using (StreamReader streamReader = File.OpenText(filename))
            {
                Paragraph paragraph = new Paragraph();
                Run run = new Run(streamReader.ReadToEnd());
                paragraph.Inlines.Add(run);
                richTextBox.Document.Blocks.Add(paragraph);
            }
        }
        /// <summary>
        /// 将文本内容放入RichTextBox中
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="txtContent"></param>
        private void LoadText(RichTextBox richTextBox, string txtContent)
        {
            richTextBox.Document.Blocks.Clear();
            Paragraph paragraph = new Paragraph();
            paragraph.TextIndent = 24;
            Run run = new Run(txtContent);
            paragraph.Inlines.Add(run);
            richTextBox.Document.Blocks.Add(paragraph);
        }

        /// <summary>
        /// 打开链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "http://www.zhaoxiedu.net";
            process.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("你点击了Get");
        }

        private void addUI_Click(object sender, RoutedEventArgs e)
        {
            //Run run1 = new Run("这是新插入的内容1");
            //run1.Background = new SolidColorBrush(Colors.Purple);
            //Paragraph pf = new Paragraph();
            //pf.Inlines.Add(run1);
            //rtbContent.Document.Blocks.Add(pf);//添加到新段落中

            Run run2 = new Run("这是新插入的内容2", rtbContent.Selection.Start);
            run2.Foreground = new SolidColorBrush(Colors.YellowGreen);

            BlockUIContainer bui = new BlockUIContainer();
            Label lbl = new Label();
            lbl.Content = "你好！";
            bui.Child = lbl;
            rtbContent.Document.Blocks.Add(bui);
        }

        /// <summary>
        /// 获取文本内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            //TextRange range = new TextRange(rtbContent.Document.ContentStart, rtbContent.Document.ContentEnd);
            //string text = range.Text;
            string text = GetText(rtbContent);//整个的文本内容
            //选定的文本内容
            TextRange selRange = new TextRange(rtbContent.Selection.Start, rtbContent.Selection.End);
            string selText = selRange.Text;
        }

        private string GetSelectText(RichTextBox rtb)
        {
            TextRange selRange = new TextRange(rtbContent.Selection.Start, rtbContent.Selection.End);
            return selRange.Text;
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(GetSelectText(rtbContent));
        }

        private void btnPaste_Click(object sender, RoutedEventArgs e)
        {
            string str = Clipboard.GetText();
            Run run = new Run(str, rtbContent.Selection.Start);
        }

        /// <summary>
        /// 加粗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldBtn_Click(object sender, RoutedEventArgs e)
        {
            var boldStyle = rtbContent.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            if (boldStyle.ToString() == "Normal")
            {
                rtbContent.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
            else
            {
                rtbContent.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
            }
        }

        /// <summary>
        /// 居中对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void centerAlign_Click(object sender, RoutedEventArgs e)
        {
            var alginStyle = rtbContent.Selection.GetPropertyValue(Block.TextAlignmentProperty);
            if (alginStyle.ToString() == TextAlignment.Left.ToString())
            {
                rtbContent.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Center);
            }
            else
            {
                rtbContent.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Left);
            }
        }

        /// <summary>
        /// 替换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            TextRange range = new TextRange(rtbContent.Selection.Start, rtbContent.Selection.End);
            range.Text = tbText.Text;

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            TextRange range = new TextRange(rtbContent.Selection.Start, rtbContent.Selection.End);
            range.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int fontsize = Convert.ToInt32(rtbContent.Selection.GetPropertyValue(TextElement.FontSizeProperty));
            fontsize += 2;
            rtbContent.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, fontsize.ToString());
        }

        /// <summary>
        /// 加载文本文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadTextFile_Click(object sender, RoutedEventArgs e)
        {
            LoadTextFile(rtbContent, @"d:\本周课程内容.txt");
        }

        private void btnLoadText_Click(object sender, RoutedEventArgs e)
        {
            LoadText(rtbContent, "本周内至少学习完这些控件）。一定要一边看一边结合实操，并完成第十一次作业（作业已上传到群文件中）。 尽量在这下周五前交给我。");
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            LoadFile(@"d:\newFile.rtf", rtbContent);
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile(@"d:\newText.txt", rtbContent);
        }
    }
}
