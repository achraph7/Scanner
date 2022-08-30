using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace ScannerAppIrma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListScanners();
            textBoxFileLoc.Text = Path.GetTempPath();
            //MessageBox.Show(textBoxFileLoc.Text);
            // Set JPEG as default
            comboBoxFormatImg.SelectedIndex = 1;

        }

        //Get All the Form1s
        private void ListScanners()
        {
            // Clear the ListBox.
            comboBoxSelectScan.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                comboBoxSelectScan.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxFileLoc.Text = folderDlg.SelectedPath;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        }

        private void TriggerScan()
        {
            MessageBox.Show("Image succesfully scanned");
        }

        //start the scan

        public void StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = comboBoxSelectScan.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(textBoxFileLoc.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (comboBoxFormatImg.SelectedIndex)
                {
                    case 0:
                        image = device.ScanPNG();
                        imageExtension = ".png";
                        break;
                    case 1:
                        image = device.ScanJPEG();
                        imageExtension = ".jpeg";
                        break;
                    case 2:
                        image = device.ScanTIFF();
                        imageExtension = ".tiff";
                        break;
                }
            }));


            // Save the image
            //MessageBox.Show(imageExtension);
            //MessageBox.Show(textBoxFileLoc.Text);
            //MessageBox.Show(textBoxFileName.Text);

            var path = Path.Combine(textBoxFileLoc.Text, textBoxFileName.Text + imageExtension);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            //MessageBox.Show(textBox2.Text);
            //File.Copy("myscan" + imageExtension, path, true);
            image.SaveFile(path);

            ScannnedPic.Image = new Bitmap(path);
        }

        private void textBoxFileLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScannnedPic_Click(object sender, EventArgs e)
        {

        }

    }
}
