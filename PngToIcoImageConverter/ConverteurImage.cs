using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
namespace PngToIcoImageConverter
{
    internal class ConverteurImage
    {

        /// <summary>
        /// Méthode qui permet de convertir une image au format PNG ver le format ICO
        /// Convertion byte à byte afin de converser la profondeur des couleurs
        /// </summary>
        /// <param name="fileStreamImage">Flux Stream de l'image png</param>
        /// <param name="fileStreamIcon">Flux Stream de l'image ico</param>
        /// <param name="sizeImage">Taille de l'image W x H</param>
        /// <returns>retourne un boolean</returns>
        public static bool ConvertPicturePngToIco(FileStream fileStreamImage, FileStream fileStreamIcon, Size sizeImage)
        {
            try
            {
                Bitmap source = (Bitmap)Bitmap.FromStream(fileStreamImage);
                if (source != null)
                {
                    int w = sizeImage.Width;
                    int h = sizeImage.Height;
                    Size size = sizeImage;

                    Bitmap bitmapSource = new Bitmap(source, size);

                    if (bitmapSource != null)
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            bitmapSource.Save(memoryStream, ImageFormat.Png);

                            BinaryWriter binaryIcon = new BinaryWriter(fileStreamIcon);

                            if (fileStreamIcon != null && binaryIcon != null)
                            {
                                // 0-1 reserved, 0
                                binaryIcon.Write((byte)0);
                                binaryIcon.Write((byte)0);

                                // 2-3 image type, 1 = icon, 2 = cursor
                                binaryIcon.Write((short)1);
                                // 4 - 5 number of images
                                binaryIcon.Write((short)1);
                                // image entry 1
                                // 0 image width
                                binaryIcon.Write((byte)w);
                                // 1 image height
                                binaryIcon.Write((byte)h);
                                // 2 number of colors
                                binaryIcon.Write((byte)0);
                                // 3 reserved
                                binaryIcon.Write((byte)0);
                                // 4-5 color planes
                                binaryIcon.Write((short)0);
                                // 6-7 bits per pixel
                                binaryIcon.Write((short)32);
                                // 8-11 size of image data
                                binaryIcon.Write((int)memoryStream.Length);
                                // 12-15 offset of image data
                                binaryIcon.Write((int)(6 + 16));
                                // Ecrire des données d'image.
                                // Les données png doivent contenir l'intégralité du fichier
                                binaryIcon.Write(memoryStream.ToArray());
                                binaryIcon.Flush();
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
