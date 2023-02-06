using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PngToIcoImageConverter
{
    public partial class FRM_Main : Form
    {

        string FolderMyPictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        int[] imageSizes = new int[] { 8, 16, 32, 48, 64, 72, 128, 256, 512 };

        ImageInformation imageInformation;
        public FRM_Main()
        {
            InitializeComponent();
            imageInformation = new ImageInformation();
        }

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

                imageInformation.FileName = Path.GetFileName(openFile.FileName);
                imageInformation.FilePath = openFile.FileName;
            }
        }

        /// <summary>
        /// Methode qui permet de convertir une image en png vers une icon
        /// </summary>
        /// <param name="path">Chemin du fichier source</param>
        /// <param name="nameFile">Nom du fichier source</param>
        /// <returns>Bool</returns>
        private bool ConvertPicturePngToIco(string path, string nameFile)
        {
            var images = new Icon[imageSizes.Length];

            for (int i = 0; i < imageSizes.Length; i++)
            {
                using (var originalImage = Image.FromFile(path))
                {
                    using (var resizedImage = new Bitmap(originalImage, new Size(imageSizes[i], imageSizes[i])))
                    {
                        images[i] = Icon.FromHandle(resizedImage.GetHicon());
                    }
                }
            }

            try
            {
                string icoFilePath = FolderMyPictures + "\\" + nameFile.Substring(0, nameFile.Length - 4) + ".ico";

                using (var originalImage = Image.FromFile(path))
                {
                    var resizedImage = new Bitmap(originalImage, new Size(originalImage.Width, originalImage.Height));
                    resizedImage.MakeTransparent(Color.Transparent);
                    var icon = Icon.FromHandle(resizedImage.GetHicon());
                 

                    using (var iconOutputStream = System.IO.File.Create(icoFilePath))
                    {
                        icon.Save(iconOutputStream);
                    }
                }

                //using (var originalImage = Image.FromFile(path))
                //{
                //    using (var icon = Icon.FromHandle(((Bitmap)originalImage).GetHicon()))
                //    {
                //        using (var iconOutputStream = System.IO.File.Create(icoFilePath))
                //        {
                //            icon.Save(iconOutputStream);
                //        }
                //    }
                //}

                //using (var iconFileStream = new FileStream(icoFilePath, FileMode.Create))
                //{
                //    using (var iconWriter = new BinaryWriter(iconFileStream))
                //    {
                //        // Écriture de l'en-tête du fichier icône
                //        iconWriter.Write((short)0);
                //        iconWriter.Write((short)1);
                //        iconWriter.Write((short)images.Length);

                //        // Écriture des entrées pour chaque image
                //        foreach (var image in images)
                //        {
                //            var imageData = GetBytes(image);
                //            iconWriter.Write(image.Width);
                //            iconWriter.Write(image.Height);
                //            iconWriter.Write((byte)0);
                //            iconWriter.Write((byte)0);
                //            iconWriter.Write((short)1);
                //            iconWriter.Write((short)32);
                //            iconWriter.Write(imageData.Length);
                //            iconWriter.Write(imageData.Length);
                //            iconWriter.Write(0);
                //            iconWriter.Write(0);
                //            iconWriter.Write(imageData);
                //        }
                //    }
                //}

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }

        /// <summary>
        /// Methode qui permet de convertir un icon en octet
        /// retourne un tableau de bytes
        /// </summary>
        /// <param name="icon">Icon</param>
        /// <returns>Bytes array</returns>
        private byte[] GetBytes(Icon icon)
        {
            MemoryStream ms = new MemoryStream();
            icon.Save(ms);
            return ms.ToArray();
        }

        private void BT_Convert_Click(object sender, EventArgs e)
        {
            bool flag = ConvertPicturePngToIco(imageInformation.FilePath, imageInformation.FileName);

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
        }

        private void BT_OpenFolderDest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", FolderMyPictures);
        }
    }

    public class ImageInformation
    {

        public string FileName { get; set; }
        public string FilePath { get; set; }

        public ImageInformation() { }

        public ImageInformation(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }

}
