using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PngToIcoImageConverter
{
    public partial class FRM_Main : Form
    {
        readonly string FolderMyPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        readonly RadioButton[] RadioButtonsList;

        ImageInformation imageInformation;
        public FRM_Main()
        {
            InitializeComponent();
            RadioButtonsList = new RadioButton[] { RB_16, RB_32, RB_48, RB_64, RB_72, RB_128, RB_256, RB_Origin };
        }

        /// <summary>
        /// Bouton qui permet de sélectionner l'image en Png
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_SetSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image Files|*.png;",
                Multiselect = false,
                Title = "Select picture",
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                TXT_Source.Text = openFile.FileName;

                var image = Image.FromFile(openFile.FileName);

                imageInformation = new ImageInformation(Path.GetFileName(openFile.FileName), openFile.FileName, image.Width, image.Height);
            }
        }


        private void BT_Convert_Click(object sender, EventArgs e)
        {
            string icoFilePath = FolderMyPictures + "\\" + imageInformation.FileName.Substring(0, imageInformation.FileName.Length - 4) + ".ico";

            FileStream fileStreamImage = new FileStream(imageInformation.FilePath, FileMode.Open, FileAccess.Read);
            FileStream fileStreamIcon = new FileStream(icoFilePath, FileMode.CreateNew, FileAccess.Write);

            bool flag = ConverteurImage.ConvertPicturePngToIco(fileStreamImage, fileStreamIcon, GetSizeImage());

            fileStreamImage.Close();
            fileStreamIcon.Close();

            if (flag)
            {
                LBL_Message.Text = "success";
                LBL_Message.ForeColor = Color.Green;
            }
            else
            {
                LBL_Message.Text = "Error";
                LBL_Message.ForeColor = Color.Red;
            }

            fileStreamImage.Dispose();
            fileStreamIcon.Dispose();
        }

        private void BT_OpenFolderDest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", FolderMyPictures);
        }

        private Size GetSizeImage()
        {
            Size size = new Size();
            foreach (var check in RadioButtonsList)
            {
                switch (check.Name)
                {
                    case "RB_16": size = new Size(16, 16); break;
                    case "RB_32": size = new Size(32, 32); break;
                    case "RB_48": size = new Size(48, 48); break;
                    case "RB_64": size = new Size(64, 64); break;
                    case "RB_72": size = new Size(72, 72); break;
                    case "RB_128": size = new Size(128, 128); break;
                    case "RB_256": size = new Size(256, 256); break;
                    case "RB_Origin": size = imageInformation.Size; break;
                }
            }
            return size;
        }
    }

    public class ImageInformation
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Size Size { get; }

        public ImageInformation() { }

        public ImageInformation(string _fileName, string _filePath)
        {
            FileName = _fileName;
            FilePath = _filePath;
        }

        public ImageInformation(string _fileName, string _filePath, int _width, int _height)
        {
            FileName = _fileName;
            FilePath = _filePath;
            Width = _width;
            Height = _height;

            this.Size = new Size(Width, Height);
        }

    }

}
