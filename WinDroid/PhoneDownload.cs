using Ionic.Zip;
using MetroFramework.Forms;
using RegawMOD.Android;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WinDroid
{
    public partial class PhoneDownload : MetroForm
    {
        private AndroidController _android;
        private Device _device;

        public PhoneDownload()
        {
            InitializeComponent();
        }

        private void PhoneDownload_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("./Data/Recoveries/TWRP1.img"))
                {
                    File.Delete("./Data/Recoveries/TWRP1.img");
                }
                if (File.Exists("./Data/Recoveries/TWRP2.img"))
                {
                    File.Delete("./Data/Recoveries/TWRP2.img");
                }
                if (File.Exists("./Data/Recoveries/TWRP3.img"))
                {
                    File.Delete("./Data/Recoveries/TWRP3.img");
                }
                if (File.Exists("./Data/Installers/fastboot.exe"))
                {
                    File.Delete("./Data/Installers/fastboot.exe");
                }
                if (File.Exists("./Data/Installers/run.bat"))
                {
                    File.Delete("./Data/Installers/run.bat");
                }
                if (File.Exists("./Data/Installers/busybox"))
                {
                    File.Delete("./Data/Installers/busybox");
                }
                if (File.Exists("./Data/Installers/oneXchopper"))
                {
                    File.Delete("./Data/Installers/oneXchopper");
                }
                if (File.Exists("./Data/Installers/ownage"))
                {
                    File.Delete("./Data/Installers/ownage");
                }

                switch (AndroidLib.Selector)
                {
                    case "ADB":
                        {
                            mainLabel.Text = "Downloading Drivers...";
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CbDZlaXZZZko1ZDA"),
                                "./Data/Installers/ADBDriver.msi");
                        }
                        break;

                    case "Amaze":
                        {
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CRFFqc2FMeGJZTTQ"),
                                "./Data/Recoveries/TWRP1.img");
                        }
                        break;

                    case "Desire HD":
                        {
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CdkUtT0RXaXVIT2s"),
                                "./Data/Recoveries/TWRP1.img");
                        }
                        break;

                    case "Desire X":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CUGJpcTQ1NmItMGM"),
                                "./Data/Recoveries/TWRP1.img"); //HBOOT 1.25 (JB)
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CaWpPSU5MVnJNbHc"),
                                "./Data/Recoveries/TWRP2.img"); //HBOOT 1.24 (ICS)
                        }
                        break;

                    case "Droid DNA":
                        {
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2Cb01yVUh4bTBGQXc"),
                                "./Data/Recoveries/TWRP1.img");
                        }
                        break;

                    case "Droid DNA SuperCID":
                        {
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CalZNMkhyTzNvdW8"),
                                "./Data/Installers/SuperCID.apk");
                        }
                        break;

                    case "EVO 4G LTE":
                        {
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CaWw0WkdGcEZMV0k"),
                                "./Data/Recoveries/TWRP1.img");
                        }
                        break;

                    case "One (M7)":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            var client3 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CTUZyYUtOaGNxM3c"),
                                "./Data/Recoveries/TWRP1.img"); //GSM
                            client3.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CY0JSbDVjMklCV3M"),
                                "./Data/Recoveries/TWRP2.img"); //Verzion
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CaWFFeHRLalJlMGc"),
                                "./Data/Recoveries/TWRP3.img"); //Sprint
                        }
                        break;

                    case "One (M8)":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            var client3 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CMTBzd2hFSEFUZjQ"),
                                "./Data/Recoveries/TWRP1.img"); //GSM
                            client3.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CLUp4X19TOW8yeHM"),
                                "./Data/Recoveries/TWRP2.img"); //Verizon
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CQlo1cGh0dXdYZjQ"),
                                "./Data/Recoveries/TWRP3.img"); //Sprint
                        }
                        break;

                    case "One S":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2Cd1hSbVNrUXFOU2c"),
                                "./Data/Recoveries/TWRP1.img"); //S4
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CdGg1TE11cF9wVnc"),
                                "./Data/Recoveries/TWRP2.img"); //S3_C2
                        }
                        break;

                    case "One V":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2Cc1dIdVFiS2hvcXc"),
                                "./Data/Recoveries/TWRP1.img"); //GSM
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CRHVMMnlVVGVEVjg"),
                                "./Data/Recoveries/TWRP2.img"); //CDMA
                        }
                        break;

                    case "One X":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CSEw4MlFVRlhKU1U"),
                                "./Data/Recoveries/TWRP1.img");
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CQjRjUFJ5MEg5aDQ"),
                                "./Data/Recoveries/TWRP2.img");
                        }
                        break;

                    case "One X SuperCID":
                        {
                            var client = new WebClient();
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CLXFpajlGNllZQjQ"),
                                "./Data/Installers/SuperCID.zip");
                        }
                        break;

                    case "One X+":
                        {
                            var client = new WebClient();
                            var client2 = new WebClient();
                            client2.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CRWRfbENONk9wa3M"),
                                "./Data/Recoveries/TWRP1.img"); //International
                            client.DownloadProgressChanged += (client_DownloadProgressChanged);
                            client.DownloadFileCompleted += (client_DownloadFileCompleted);
                            client.DownloadFileAsync(
                                new Uri("https://docs.google.com/uc?export=download&id=0BzIE430dYN2CZHRxY0JyNGZ3WEU"),
                                "./Data/Recoveries/TWRP2.img"); //AT&T
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    "Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                double bytesIn = e.BytesReceived;
                double totalBytes = e.TotalBytesToReceive;
                double percentage = bytesIn / totalBytes * 100;
                soffProgressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
                soffProgressBar.Value = (int)Math.Truncate(percentage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show(
                        @"An error occured while attempting to download the necessary files! Please check your internet conenction and try again in a few minutes.",
                        @"Download Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (File.Exists("./Data/Recoveries/TWRP1.img"))
                    {
                        File.Delete("./Data/Recoveries/TWRP1.img");
                    }
                    if (File.Exists("./Data/Recoveries/TWRP2.img"))
                    {
                        File.Delete("./Data/Recoveries/TWRP2.img");
                    }
                    if (File.Exists("./Data/Recoveries/TWRP3.img"))
                    {
                        File.Delete("./Data/Recoveries/TWRP3.img");
                    }
                    if (File.Exists("./Data/Installers/fastboot.exe"))
                    {
                        File.Delete("./Data/Installers/fastboot.exe");
                    }
                    if (File.Exists("./Data/Installers/run.bat"))
                    {
                        File.Delete("./Data/Installers/run.bat");
                    }
                    if (File.Exists("./Data/Installers/busybox"))
                    {
                        File.Delete("./Data/Installers/busybox");
                    }
                    if (File.Exists("./Data/Installers/oneXchopper"))
                    {
                        File.Delete("./Data/Installers/oneXchopper");
                    }
                    if (File.Exists("./Data/Installers/ownage"))
                    {
                        File.Delete("./Data/Installers/ownage");
                    }
                    Close();
                }
                else if (AndroidLib.Selector == "Droid DNA SuperCID")
                {
                    AndroidLib.InitialCmd = "./Data/Installers/SuperCID.apk";
                    installApp.RunWorkerAsync();
                    Close();
                }
                else if (AndroidLib.Selector == "One X SuperCID")
                {
                    using (ZipFile zip = ZipFile.Read("./Data/Installers/SuperCID.zip"))
                    {
                        zip.ExtractAll("./Data/Installers");
                    }
                    File.Delete("./Data/Installers/SuperCID.zip");
                    soffProgressBar.Value = 100;
                    Process.Start(Application.StartupPath + "/Data/Installers/run.bat");
                    Close();
                }
                else if (AndroidLib.Selector == "ADB")
                {
                    Process.Start(Application.StartupPath + "/Data/Installers/ADBDriver.msi");
                    Close();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        private void installApp_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _android = AndroidController.Instance;
                _device = _android.GetConnectedDevice(_android.ConnectedDevices[0]);
                if (_device.InstallApk(AndroidLib.InitialCmd).ToString() == "True")
                {
                    MessageBox.Show(@"The SuperCID app was successfully installed!", @"Hurray for SuperCID!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(
                        @"The app will be named 'HTC DNA SuperCID' in your app drawer. Please run it and continue on to the next step.",
                        @"SuperCID App",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        @"An issue occured while attempting to install the SuperCID app. Please try again in a few moments.",
                        @"Houston, we have a problem!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _android.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        #region Nested type: AndroidLib

        public static class AndroidLib
        {
            public static string InitialCmd = "";
            public static string SecondaryCmd = "";
            public static string Selector = "";
        }

        #endregion Nested type: AndroidLib
    }
}