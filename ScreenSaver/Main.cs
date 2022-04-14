using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using ScreenSaver.Properties;

namespace ScreenSaver
{
    public partial class MainScreen : Form
    {
        private static string path = Path.Combine(Environment.CurrentDirectory, "LastScreen.bmp");
        Image imageStored;
        public bool IsMaximized 
        { 
            get
            {
                return Settings.Default.IsMaximized;
            }
            set
            {
                Settings.Default.IsMaximized = value;
            }
        }
        public MainScreen()
        {
            InitializeComponent();
            pbScreen.AllowDrop = true;

            if(IsMaximized)
                WindowState = FormWindowState.Maximized;

            try
            {
                var confirmLastScreen = MessageBox.Show("Do You want to reload last screen?", "Last Screen", MessageBoxButtons.OKCancel);
                if (confirmLastScreen == DialogResult.OK)
                {
                    imageStored = Image.FromFile(path);
                    pbScreen.Image = imageStored;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("There is no last screen.", "No Last Screen",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            
        }

        private void btScreenAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageStored = Image.FromFile(dialog.FileName);
                    pbScreen.Image = imageStored;
                }
            }
            catch
            {
                MessageBox.Show("Error while uploading image from hard drive","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btScreenDelete_Click(object sender, EventArgs e)
        {
            try
            {
                imageStored.Dispose();
                pbScreen.Dispose();
            }
            catch { }
        }

        private void btScreenSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Filter = "JPG(*.jpg)|*.jpg";
            if (dialogSave.ShowDialog() == DialogResult.OK)
            {
                imageStored.Save(dialogSave.FileName);
            }
        }

        private void pbScreen_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbScreen_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string picture in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                imageStored = Image.FromFile(picture);
                pbScreen.Image = imageStored;
            }
        }

        private void btScreenShot_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(500);
            pbScreen.Image = ScreenShot();
            imageStored = pbScreen.Image;
            this.Show();
        }

        private Image ScreenShot()
        {
            Bitmap screenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppRgb);
            Graphics memoryGraphic = Graphics.FromImage(screenShot);
            memoryGraphic.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            return screenShot;
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                    IsMaximized = true;
                else
                    IsMaximized=false;

                Settings.Default.Save();

                imageStored.Save(path);
            }
            catch (Exception)
            { }
        }
    }
}
