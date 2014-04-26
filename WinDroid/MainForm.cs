using MetroFramework.Forms;
using Microsoft.VisualBasic;
using RegawMOD.Android;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinDroid;

namespace WinDroid
{
    public partial class MainForm : MetroForm
    {
        private AndroidController _android;
        private Device _device;

        public MainForm()
        {
            InitializeComponent();
        }

        private void adbCommand_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Adb.ExecuteAdbCommand(Adb.FormAdbCommand(_device, AndroidLib.InitialCmd, AndroidLib.SecondaryCmd));
                loadingSpinner.Visible = false;
                backupButton.Enabled = true;
                uninstallAppButton.Enabled = true;
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

        private void adbCommand_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (AndroidLib.Selector == "sideload")
                {
                    sideloadROMButton.Enabled = true;
                    MessageBox.Show(
                        openFileDialog1.SafeFileName +
                        @" has been successfully sideloaded! The ZIP will now automatically begin to flash on your phone.",
                        @"Hurray for ADB Sideload!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (AndroidLib.Selector == "pullFile")
                {
                    pullFilesButton.Enabled = true;
                    MessageBox.Show(
                        saveFileDialog1.FileName + @" has been successfully pulled!",
                        @"File Pull Successful!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

        private void backupButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will create a full backup of the data on your phone." + "\n" + "\n" +
                            @"This method can be unreliable and does not guarantee all of your data being saved in the event of unlocking your bootloader, rooting, etc." +
                            "\n" + "\n" + @"This method only works with Android 4.0 and above." + "\n" + "\n" +
                            @"Are you ready to continue?", @"Phone Backup", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loadingSpinner.Visible = true;
                        backupButton.Enabled = false;
                        AndroidLib.InitialCmd = "backup";
                        AndroidLib.SecondaryCmd = "-apk -all -f ./Data/Backups/" + fileDateTime + ".ab";
                        adbCommand.RunWorkerAsync();
                        MessageBox.Show(
                            @"A process will now open on your phone allowing you to password protect and continue with the backup process." +
                            "\n" + "\n" +
                            @"Please do not disturb your phone or the toolkit until the process completes." + "\n" +
                            "\n" + @"You may close this popup.", @"Phone Backup", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void changePhoneComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (changePhoneComboBox.Text)
                {
                    case "Amaze":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "Amaze";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "HTC Amaze";
                            secondTWRPButton.Enabled = false;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "Option Two";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "Desire HD":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "Desire HD";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "HTC Desire HD";
                            secondTWRPButton.Enabled = false;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "Option Two";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "Desire X":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "Desire X";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "Hboot 1.25 (JB)";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "Hboot 1.24 (ICS)";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "Droid DNA":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "Droid DNA";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = true;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "HTC Droid DNA";
                            secondTWRPButton.Enabled = false;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "Option Two";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "EVO 4G LTE":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "EVO 4G LTE";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "EVO 4G LTE";
                            secondTWRPButton.Enabled = false;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "Option Two";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "One (M7)":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "One (M7)";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "GSM One (M7)";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "Verizon";
                            secondRecoveriesGroupBox.Text = "CDMA One (M7)";
                            thirdTWRPButton.Enabled = true;
                            thirdTWRPButton.Text = "Sprint";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "One (M8)":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "One (M8)";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "GSM One (M8)";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "Verizon";
                            secondRecoveriesGroupBox.Text = "CDMA One (M8)";
                            thirdTWRPButton.Enabled = true;
                            thirdTWRPButton.Text = "Sprint";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "One S":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "One S";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "One S (S4)";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "One S (S3_C2)";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "One V":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "One V";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "PrimoU (GSM)";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "PrimoC (CDMA)";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "One X":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "One X";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = true;
                            gainSuperCIDButton.Text = "AT&&T One X ONLY";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "HTC One X";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "AT&&T One X";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "One X+":
                        {
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "One X+";
                            phoneDownload.Show();
                            gainSuperCIDButton.Enabled = false;
                            gainSuperCIDButton.Text = "Gain SuperCID";
                            firstTWRPButton.Enabled = true;
                            firstRecoveriesGroupBox.Text = "International X+";
                            secondTWRPButton.Enabled = true;
                            secondTWRPButton.Text = "TWRP";
                            secondRecoveriesGroupBox.Text = "AT&&T One X+";
                            thirdTWRPButton.Enabled = false;
                            thirdTWRPButton.Text = "CWM";
                            mainTabControl.SelectedIndex = 0;
                        }
                        break;

                    case "Other":
                        gainSuperCIDButton.Enabled = false;
                        firstTWRPButton.Enabled = false;
                        firstRecoveriesGroupBox.Text = "Option One";
                        secondTWRPButton.Enabled = false;
                        thirdTWRPButton.Enabled = false;
                        secondRecoveriesGroupBox.Text = "Option Two";
                        secondTWRPButton.Text = "TWRP";
                        thirdTWRPButton.Text = "CWM";
                        mainTabControl.SelectedIndex = 0;
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

        private void CheckFileSystem()
        {
            string[] neededDirectories = new string[] { "Data/", "Data/Backups", "Data/Installers", "Data/Logcats", "Data/Logs", "Data/Recoveries" };

            foreach (string dir in neededDirectories)
            {
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            }
        }

        private void deviceRecognition_DoWork(object sender, DoWorkEventArgs e)
        {
            _android = AndroidController.Instance;
            try
            {
                _android.UpdateDeviceList();
                if (_android.HasConnectedDevices)
                {
                    _device = _android.GetConnectedDevice(_android.ConnectedDevices[0]);
                    switch (_device.State.ToString())
                    {
                        case "ONLINE":
                            if (_device.BuildProp.GetProp("ro.product.model") == null)
                            {
                                deviceLabel.Text = "Device: " + _device.SerialNumber;
                                statusLabel.Text = @"Status: Online";
                                statusLabel.Location = new Point(deviceLabel.Location.X + deviceLabel.Width,
                                    deviceLabel.Location.Y);
                                statusProgressSpinner.Location = new Point(statusLabel.Location.X + statusLabel.Width,
                                    statusLabel.Location.Y);
                                deviceProgressSpinner.Visible = false;
                                statusProgressSpinner.Visible = false;
                                refreshSpinner.Visible = false;
                            }
                            else
                            {
                                deviceLabel.Text = "Device: " + _device.BuildProp.GetProp("ro.product.model");
                                statusLabel.Text = @"Status: Online";
                                statusLabel.Location = new Point(deviceLabel.Location.X + deviceLabel.Width,
                                    deviceLabel.Location.Y);
                                statusProgressSpinner.Location = new Point(statusLabel.Location.X + statusLabel.Width,
                                    statusLabel.Location.Y);
                                deviceProgressSpinner.Visible = false;
                                statusProgressSpinner.Visible = false;
                                refreshSpinner.Visible = false;
                            }
                            break;

                        case "FASTBOOT":
                            deviceLabel.Text = "Device: " + _device.SerialNumber;
                            statusLabel.Text = @"Status: Fastboot";
                            statusLabel.Location = new Point(deviceLabel.Location.X + deviceLabel.Width,
                                deviceLabel.Location.Y);
                            statusProgressSpinner.Location = new Point(statusLabel.Location.X + statusLabel.Width,
                                statusLabel.Location.Y);
                            deviceProgressSpinner.Visible = false;
                            statusProgressSpinner.Visible = false;
                            refreshSpinner.Visible = false;
                            break;

                        case "RECOVERY":
                            deviceLabel.Text = "Device: " + _device.SerialNumber;
                            statusLabel.Text = @"Status: Recovery";
                            statusLabel.Location = new Point(deviceLabel.Location.X + deviceLabel.Width,
                                deviceLabel.Location.Y);
                            statusProgressSpinner.Location = new Point(statusLabel.Location.X + statusLabel.Width,
                                statusLabel.Location.Y);
                            deviceProgressSpinner.Visible = false;
                            statusProgressSpinner.Visible = false;
                            refreshSpinner.Visible = false;
                            break;

                        case "UNKNOWN":
                            deviceLabel.Text = "Device: " + _device.SerialNumber;
                            statusLabel.Text = @"Status: Unknown";
                            statusLabel.Location = new Point(deviceLabel.Location.X + deviceLabel.Width,
                                deviceLabel.Location.Y);
                            statusProgressSpinner.Location = new Point(statusLabel.Location.X + statusLabel.Width,
                                statusLabel.Location.Y);
                            deviceProgressSpinner.Visible = false;
                            statusProgressSpinner.Visible = false;
                            break;
                    }
                    deviceProgressSpinner.Visible = false;
                    refreshSpinner.Visible = false;
                }
                else
                {
                    deviceLabel.Text = @"Device: Not Found!";
                    statusLabel.Text = @"Status: Not Found!";
                    statusLabel.Location = new Point(deviceLabel.Location.X + deviceLabel.Width,
                        deviceLabel.Location.Y);
                    statusProgressSpinner.Location = new Point(statusLabel.Location.X + statusLabel.Width,
                        statusLabel.Location.Y);
                    deviceProgressSpinner.Visible = false;
                    statusProgressSpinner.Visible = false;
                    refreshSpinner.Visible = false;
                }
                _android.Dispose();
                reloadButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    @"An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        private void dmesgButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    dmesgButton.Enabled = false;
                    AndroidLib.InitialCmd = "dmesg";
                    getDmesg.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void donateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://forum.xda-developers.com/donatetome.php?u=4485224");
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

        private void donateTile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://forum.xda-developers.com/donatetome.php?u=4485224");
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

        private void emailButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mailto:windycityrockr@gmail.com");
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

        private void firstTWRPButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("./Data/Recoveries/TWRP1.img"))
                {
                    if (statusLabel.Text == @"Status: Fastboot")
                    {
                        loadingSpinner.Visible = true;
                        firstTWRPButton.Enabled = false;
                        AndroidLib.InitialCmd = "flash";
                        AndroidLib.SecondaryCmd = "recovery ./Data/Recoveries/TWRP1.img";
                        AndroidLib.Selector = "firstTWRP";
                        noReturnFastbootCommand.RunWorkerAsync();
                    }
                    else if (statusLabel.Text == @"Status: Online")
                    {
                        loadingSpinner.Visible = true;
                        firstTWRPButton.Enabled = false;
                        AndroidLib.InitialCmd = "reboot bootloader";
                        AndroidLib.Selector = "firstTWRP";
                        noReturnADBCommand.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show(this,
                            @"A phone has not been recognized by the toolkit!",
                            @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, @"This recovery appears to be missing from the Data folder!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void flashKernelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will allow you to flash a custom Kernel .img. Are you ready to continue?",
                            @"Custom Recovery Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a Kernel .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            flashKernelButton.Enabled = false;
                            AndroidLib.InitialCmd = "flash";
                            AndroidLib.SecondaryCmd = "boot " + openFileDialog1.FileName;
                            AndroidLib.Selector = "flashKernel";
                            noReturnFastbootCommand.RunWorkerAsync();
                        }
                    }
                }
                else if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will allow you to flash a custom Kernel .img. Are you ready to continue?",
                            @"Custom Recovery Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a Kernel .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            flashKernelButton.Enabled = false;
                            AndroidLib.InitialCmd = "reboot bootloader";
                            AndroidLib.Selector = "flashKernel";
                            noReturnADBCommand.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void flashROMButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will push a ROM .zip file of your choosing to your phone and boot you into Recovery. Once there, flash the ROM .zip like any other file." +
                            "\n" + "\n" +
                            @"Afterwards, use the 'Flash Kernel' option to flash the boot.img that came with your ROM if needed." +
                            "\n" + "\n" +
                            @"The process can take awhile depending on the size of the ROM." +
                            "\n" + "\n" + @"Are you ready to continue?", @"Flash ROM", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Select your ROM .zip file.";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .ZIP|*.zip";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            flashROMButton.Enabled = false;
                            AndroidLib.InitialCmd = openFileDialog1.FileName;
                            AndroidLib.SecondaryCmd = "/sdcard/" + openFileDialog1.SafeFileName;
                            AndroidLib.Selector = "flashROM";
                            pushFile.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void flashSuperSUButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will push SuperSU.zip to your phone and boot you into Recovery." + "\n" + "\n" +
                            @"Once there, flash the SuperSU.zip like any other file." + "\n" + "\n" +
                            @"Are you ready to continue?", @"Flash SuperSU", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loadingSpinner.Visible = true;
                        AndroidLib.InitialCmd = "./Data/Installers/SuperSU.zip";
                        AndroidLib.SecondaryCmd = "/sdcard/SuperSU.zip";
                        AndroidLib.Selector = "superSU";
                        pushFile.RunWorkerAsync();
                        flashSuperSUButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gainSuperCIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sr = new StreamReader("./Data/Settings/Phone.ini"))
                {
                    String line = sr.ReadToEnd();
                    if (line == "Droid DNA")
                    {
                        if (statusLabel.Text == @"Status: Online")
                        {
                            DialogResult dialogResult =
                                MessageBox.Show(
                                    @"This is an app to be installed on your phone that will automatically give you SuperCID. Would you like to download and install it now?",
                                    @"SuperCID", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
                                var phoneDownload = new PhoneDownload();
                                PhoneDownload.AndroidLib.Selector = "Droid DNA SuperCID";
                                phoneDownload.mainLabel.Text = "Downloading SuperCID Files...";
                                phoneDownload.Show();
                            }
                            if (dialogResult == DialogResult.No)
                            {
                                Process.Start("http://forum.xda-developers.com/showthread.php?t=2109862");
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                @"A phone has not been recognized by the toolkit!",
                                @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (line == "One X")
                    {
                        if (statusLabel.Text == @"Status: Online")
                        {
                            DialogResult dialogResult =
                                MessageBox.Show(
                                    @"To unlock your bootloader, you must gain SuperCID on your phone through a special program. Would you like to download it now?",
                                    @"SuperCID", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
                                var phoneDownload = new PhoneDownload();
                                PhoneDownload.AndroidLib.Selector = "One X SuperCID";
                                phoneDownload.mainLabel.Text = "Downloading SuperCID...";
                                phoneDownload.Show();
                            }
                            if (dialogResult == DialogResult.No)
                            {
                                Process.Start("http://forum.xda-developers.com/showthread.php?t=2285086");
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                @"A phone has not been recognized by the toolkit! Please click the Reload button to check again!",
                                @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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

        private void getCIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    loadingSpinner.Visible = true;
                    getCIDButton.Enabled = false;
                    AndroidLib.InitialCmd = "getvar";
                    AndroidLib.SecondaryCmd = "cid";
                    getFastbootInfo.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void getDmesg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                using (StreamWriter sw = File.CreateText("./Data/Logcats/" + fileDateTime + "_DMESG.txt"))
                {
                    sw.WriteLine(Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(_device, true, AndroidLib.InitialCmd)));
                }
                Process.Start(Application.StartupPath + "/Data/Logcats");
                _android.Dispose();
                loadingSpinner.Visible = false;
                dmesgButton.Enabled = true;
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

        private void getFastbootInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                fastbootInformationTextBox.Text =
                    Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(_device, AndroidLib.InitialCmd,
                        AndroidLib.SecondaryCmd));
                getSerialNumberButton.Enabled = true;
                getIMEIButton.Enabled = true;
                getCIDButton.Enabled = true;
                getMIDButton.Enabled = true;
                loadingSpinner.Visible = false;
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

        private void getIMEIButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    loadingSpinner.Visible = true;
                    getIMEIButton.Enabled = false;
                    AndroidLib.InitialCmd = "getvar";
                    AndroidLib.SecondaryCmd = "imei";
                    getFastbootInfo.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void getLogcat_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                using (StreamWriter sw = File.CreateText("./Data/Logcats/" + fileDateTime + ".txt"))
                {
                    sw.WriteLine(
                        Adb.ExecuteAdbCommand(Adb.FormAdbCommand(AndroidLib.InitialCmd, AndroidLib.SecondaryCmd)));
                }
                Process.Start(Application.StartupPath + "/Data/Logcats");
                _android.Dispose();
                loadingSpinner.Visible = false;
                logcatButton.Enabled = true;
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

        private void getMIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    loadingSpinner.Visible = true;
                    getMIDButton.Enabled = false;
                    AndroidLib.InitialCmd = "getvar";
                    AndroidLib.SecondaryCmd = "mid";
                    getFastbootInfo.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void getSerialNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    fastbootInformationTextBox.Text = _device.SerialNumber;
                }
                else if (statusLabel.Text == @"Status: Fastboot")
                {
                    loadingSpinner.Visible = true;
                    getSerialNumberButton.Enabled = false;
                    AndroidLib.InitialCmd = "getvar";
                    AndroidLib.SecondaryCmd = "serialno";
                    getFastbootInfo.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void getTokenIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(this,
                            @"This is the first (or second) step in unlocking your bootloader." + "\n" + "\n" +
                            @"This will retrieve your Token ID." + "\n" + "\n" +
                            @"Once the process has completed, a text file will open with your Token ID and further instructions." +
                            "\n" + "\n" + @"Are you ready to continue?", @"Get Token ID", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loadingSpinner.Visible = true;
                        getTokenIDButton.Enabled = false;
                        AndroidLib.InitialCmd = "oem";
                        AndroidLib.SecondaryCmd = "get_identifier_token";
                        tokenID.RunWorkerAsync();
                    }
                }
                else if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(this,
                            @"This is the first (or second) step in unlocking your bootloader." + "\n" + "\n" +
                            @"This will retrieve your Token ID." + "\n" + "\n" +
                            @"Once the process has completed, a text file will open with your Token ID and further instructions." +
                            "\n" + "\n" + @"Are you ready to continue?", @"Get Token ID", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        loadingSpinner.Visible = true;
                        getTokenIDButton.Enabled = false;
                        AndroidLib.InitialCmd = "reboot bootloader";
                        AndroidLib.Selector = "tokenID";
                        noReturnADBCommand.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void helpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://forum.xda-developers.com/showpost.php?p=52041197&postcount=2");
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

        private void helpTile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://forum.xda-developers.com/showpost.php?p=52041197&postcount=2");
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
                if (_device.InstallApk(AndroidLib.InitialCmd).ToString() == "True")
                {
                    loadingSpinner.Visible = false;
                    installAppButton.Enabled = true;
                    MessageBox.Show(openFileDialog1.SafeFileName + @" was successfully installed!",
                        @"Hurray for Apps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _android.Dispose();
                }
                else
                {
                    loadingSpinner.Visible = false;
                    installAppButton.Enabled = true;
                    MessageBox.Show(
                        @"An issue occured while attempting to install " + openFileDialog1.SafeFileName +
                        @". Please try again in a few moments.", @"Houston, we have a problem!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _android.Dispose();
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

        private void installAppButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    openFileDialog1.InitialDirectory = @"C:\";
                    openFileDialog1.Title = @"Select a valid Android app file (.apk)";
                    openFileDialog1.FileName = "Choose File...";
                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;
                    openFileDialog1.Filter = @" .APK|*.apk";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        loadingSpinner.Visible = true;
                        AndroidLib.InitialCmd = openFileDialog1.FileName;
                        installApp.RunWorkerAsync();
                        installAppButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void logcatButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    logcatButton.Enabled = false;
                    AndroidLib.InitialCmd = "logcat";
                    AndroidLib.SecondaryCmd = "-d";
                    getLogcat.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                deviceRecognition.CancelAsync();
                tokenID.CancelAsync();
                noReturnADBCommand.CancelAsync();
                noReturnFastbootCommand.CancelAsync();
                pushFile.CancelAsync();
                installApp.CancelAsync();
                adbCommand.CancelAsync();
                getLogcat.CancelAsync();
                getDmesg.CancelAsync();
                getFastbootInfo.CancelAsync();
            }
            catch (Exception ex)
            {
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                deviceRecognition.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    @"An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }

            CheckFileSystem();

            try
            {
                switch (Properties.Settings.Default.SelectedDevice)
                {
                    case "None":
                        {
                            DialogResult pickDeviceDialogResult = MessageBox.Show(this,
                                @"Thanks for choosing the WinDroid Toolkit." + "\n" +
                                @"A specific phone has not been chosen." + "\n" +
                                @"Some toolkit features may not function correctly." + "\n" +
                                @"Would you like to choose one at this time?" + "\n",
                                @"Welcome To WinDroid!", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                            if (pickDeviceDialogResult == DialogResult.Yes)
                            {
                                changePhoneComboBox.Text = "Choose";
                                mainTabControl.SelectedIndex = 3;
                            }
                        }
                        break;

                    case "Amaze":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "Amaze";
                        changePhoneComboBox.Text = "Amaze";
                        break;

                    case "Desire HD":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "Desire HD";
                        changePhoneComboBox.Text = "Desire HD";
                        break;

                    case "Desire X":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "Hboot 1.25 (JB)";
                        secondTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "Hboot 1.24 (ICS)";
                        changePhoneComboBox.Text = "Desire X";
                        break;

                    case "Droid DNA":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "Droid DNA";
                        gainSuperCIDButton.Enabled = true;
                        changePhoneComboBox.Text = "Droid DNA";
                        break;

                    case "EVO 4G LTE":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "EVO 4G LTE";
                        changePhoneComboBox.Text = "EVO 4G LTE";
                        break;

                    case "One (M7)":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "GSM One (M7)";
                        secondTWRPButton.Enabled = true;
                        thirdTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "CDMA One (M7)";
                        secondTWRPButton.Text = "Verizon";
                        thirdTWRPButton.Text = "Sprint";
                        changePhoneComboBox.Text = "One (M7)";
                        break;

                    case "One (M8)":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "GSM One (M8)";
                        secondTWRPButton.Enabled = true;
                        thirdTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "CDMA One (M8)";
                        secondTWRPButton.Text = "Verizon";
                        thirdTWRPButton.Text = "Sprint";
                        changePhoneComboBox.Text = "One (M8)";
                        break;

                    case "One S":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "One S (S4)";
                        secondTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "One S (S3_C2) ";
                        changePhoneComboBox.Text = "Desire X";
                        break;

                    case "One V":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "PrimoU (GSM)";
                        secondTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "PrimoC (CDMA)";
                        changePhoneComboBox.Text = "One V";
                        break;

                    case "One X":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "HTC One X";
                        secondTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "AT&&T One X";
                        gainSuperCIDButton.Enabled = true;
                        gainSuperCIDButton.Text = "AT&&T One X ONLY";
                        changePhoneComboBox.Text = "One X";
                        break;

                    case "One X+":
                        firstTWRPButton.Enabled = true;
                        firstRecoveriesGroupBox.Text = "International X+";
                        secondTWRPButton.Enabled = true;
                        secondRecoveriesGroupBox.Text = "AT&&T One X+";
                        changePhoneComboBox.Text = "One X+";
                        break;

                    case "Other":
                        changePhoneComboBox.Text = "Other";
                        break;
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

            try
            {
                if (!Directory.Exists("C:/Program Files (x86)/ClockworkMod/Universal Adb Driver") &&
                    !Directory.Exists("C:/Program Files/ClockworkMod/Universal Adb Driver"))
                {
                    if (!Properties.Settings.Default.AdbDriverReminderEnabled) return;
                    DialogResult installDriversDialogResult =
                        MessageBox.Show(this,
                            @"You are missing some ADB Drivers!" + "\n" +
                            @"They are required for your phone to connect properly with the computer. Would you like to install them now?",
                            @"Hang on a second!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (installDriversDialogResult)
                    {
                        case DialogResult.Yes:
                            var phoneDownload = new PhoneDownload();
                            PhoneDownload.AndroidLib.Selector = "ADB";
                            phoneDownload.Show();
                            break;

                        case DialogResult.No:
                            DialogResult adbreminderEnabledDialogResult =
                                MessageBox.Show(this,
                                    @"Would you like to be reminded of this the next time you open the toolkit?",
                                    @"Just double checking.", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                            Properties.Settings.Default.AdbDriverReminderEnabled = adbreminderEnabledDialogResult ==
                                                                                   DialogResult.Yes;
                            Properties.Settings.Default.Save();

                            break;
                    }
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

        private void noReturnADBCommand_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand(AndroidLib.InitialCmd));
                _android.Dispose();
                loadingSpinner.Visible = false;
                rebootToBootloaderButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    @"An error has occured! A log file has been placed in the Logs folder within the Data folder. Please send the file to WindyCityRockr or post the file in the toolkit thread.",
                    @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string fileDateTime = DateTime.Now.ToString("MMddyyyy") + "_" + DateTime.Now.ToString("HHmmss");
                var file = new StreamWriter("./Data/Logs/" + fileDateTime + ".txt");
                file.WriteLine(ex);
                file.Close();
            }
        }

        private void noReturnADBCommand_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (AndroidLib.Selector == "tokenID")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "oem";
                    AndroidLib.SecondaryCmd = "get_identifier_token";
                    tokenID.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "bootloaderUnlock")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "flash";
                    AndroidLib.SecondaryCmd = "unlocktoken " + openFileDialog1.FileName;
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "firstTWRP")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "flash";
                    AndroidLib.SecondaryCmd = "recovery ./Data/Recoveries/TWRP1.img";
                    AndroidLib.Selector = "firstTWRP";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "secondTWRP")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "flash";
                    AndroidLib.SecondaryCmd = "recovery ./Data/Recoveries/TWRP2.img";
                    AndroidLib.Selector = "secondTWRP";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "thirdTWRP")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "flash";
                    AndroidLib.SecondaryCmd = "recovery ./Data/Recoveries/TWRP3.img";
                    AndroidLib.Selector = "thirdTWRP";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "permanentRecovery")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "flash";
                    AndroidLib.SecondaryCmd = "recovery " + openFileDialog1.FileName;
                    AndroidLib.Selector = "permanentRecovery";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "flashKernel")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "flash";
                    AndroidLib.SecondaryCmd = "boot " + openFileDialog1.FileName;
                    AndroidLib.Selector = "flashKernel";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "flashTempKernel")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "boot";
                    AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                    AndroidLib.Selector = "flashTempKernel";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "flashTempRecovery")
                {
                    loadingSpinner.Visible = true;
                    AndroidLib.InitialCmd = "boot";
                    AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                    AndroidLib.Selector = "flashTempRecovery";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "rebootRecoverySideload")
                {
                    loadingSpinner.Visible = true;
                    MessageBox.Show(
                        @"Your phone is now rebooting into Recovery." + "\n" + "\n" + @"DO NOT PRESS OKAY YET." + "\n" +
                        "\n" +
                        @"Wait until your recovery has completely loaded, then open the ADB Sideload option and let it initialize." +
                        "\n" + "\n" + @"If you are using TWRP, it will be under Advanced." + "\n" + "\n" +
                        @"Once it has fully initialized, click OK to begin flashing your chosen ZIP", @"ADB Sideload",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AndroidLib.InitialCmd = "sideload";
                    AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                    AndroidLib.Selector = "sideload";
                    adbCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "relockBootloader")
                {
                    AndroidLib.InitialCmd = "oem";
                    AndroidLib.SecondaryCmd = "lock";
                    AndroidLib.Selector = "relockBootloader";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                rebootButton.Enabled = true;
                rebootRecoveryButton.Enabled = true;
                rebootBootloaderButton.Enabled = true;
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

        private void noReturnFastbootCommand_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Fastboot.ExecuteFastbootCommandNoReturn(Fastboot.FormFastbootCommand(_device, AndroidLib.InitialCmd,
                    AndroidLib.SecondaryCmd));
                _android.Dispose();
                loadingSpinner.Visible = false;
                rebootFromBootloaderButton.Enabled = true;
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

        private void noReturnFastbootCommand_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (AndroidLib.Selector == "bootloaderUnlock")
                {
                    MessageBox.Show(
                        @"Your bootloader has been successfully unlocked! You may now proceed to flash a Custom Recovery, flash a ROM and Kernel, as well as gain Permanent Root.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (AndroidLib.Selector == "firstTWRP")
                {
                    firstTWRPButton.Enabled = true;
                    MessageBox.Show(@"TWRP has been flashed!",
                        @"Hurray for TWRP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AndroidLib.InitialCmd = "reboot";
                    AndroidLib.Selector = "";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "secondTWRP")
                {
                    secondTWRPButton.Enabled = true;
                    MessageBox.Show(@"TWRP has been flashed!", @"Hurray for TWRP!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AndroidLib.InitialCmd = "reboot";
                    AndroidLib.Selector = "";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "thirdTWRP")
                {
                    secondTWRPButton.Enabled = true;
                    MessageBox.Show(@"TWRP has been flashed!", @"Hurray for TWRP!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AndroidLib.InitialCmd = "reboot";
                    AndroidLib.Selector = "";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "flashKernel")
                {
                    flashKernelButton.Enabled = true;
                    MessageBox.Show(openFileDialog1.SafeFileName + @" has been flashed!", @"Hurray for Kernels!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (AndroidLib.Selector == "flashTempKernel")
                {
                    temporaryKernelButton.Enabled = true;
                    MessageBox.Show(openFileDialog1.SafeFileName + @" has been temporarily flashed!",
                        @"Hurray for Kernels!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (AndroidLib.Selector == "flashTempRecovery")
                {
                    temporaryRecoveryButton.Enabled = true;
                    MessageBox.Show(openFileDialog1.SafeFileName + @" has been temporarily flashed!",
                        @"Hurray for Recoveries!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (AndroidLib.Selector == "permanentRecovery")
                {
                    permanentRecoveryButton.Enabled = true;
                    MessageBox.Show(openFileDialog1.SafeFileName + @" has been flashed!",
                        @"Hurray for Custom Recoveries!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AndroidLib.InitialCmd = "reboot";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else if (AndroidLib.Selector == "relockBootloader")
                {
                    relockBootloaderButton.Enabled = true;
                    MessageBox.Show(@"Your bootloader has been successfully relocked!",
                        @"#BootloaderSwag",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void permanentRecoveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(this,
                            @"This will allow you to flash a custom Custom Recovery." + "\n" +
                            "This requires a valid Recovery .IMG file." + "\n" + "Are you ready to continue?",
                            @"Custom Recovery Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a Recovery .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            permanentRecoveryButton.Enabled = false;
                            AndroidLib.InitialCmd = "flash";
                            AndroidLib.SecondaryCmd = "recovery " + openFileDialog1.FileName;
                            AndroidLib.Selector = "permanentRecovery";
                            noReturnFastbootCommand.RunWorkerAsync();
                        }
                    }
                }
                else if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(this,
                            @"This will allow you to flash a custom Custom Recovery." + "\n" +
                            "This requires a valid Recovery .IMG file." + "\n" + "Are you ready to continue?",
                            @"Custom Recovery Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a Recovery .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            permanentRecoveryButton.Enabled = false;
                            AndroidLib.InitialCmd = "reboot bootloader";
                            AndroidLib.Selector = "permanentRecovery";
                            noReturnADBCommand.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pullFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.Title =
                        @"Choose a name for your file with a file extension (.png, .apk, etc) that matches the file on your phone.";
                    saveFileDialog1.FileName = "Save your File...";
                    saveFileDialog1.CheckPathExists = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string location =
                            Interaction.InputBox(
                                "Please input the EXACT location of the file within your phone. For example, if you wanted to pull a specific file off your main storage, you would put '/sdcard/SpecificFile.file', without quotes. DO NOT PUT AN ENDING SLASH (/) IN THE LOCATION!",
                                "Location", "", 775, 450);
                        loadingSpinner.Visible = true;
                        pullFilesButton.Enabled = false;
                        AndroidLib.InitialCmd = "pull";
                        AndroidLib.SecondaryCmd = location + " " + saveFileDialog1.FileName;
                        adbCommand.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pushFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (_device.PushFile(AndroidLib.InitialCmd, AndroidLib.SecondaryCmd).ToString() == "True")
                {
                    if (AndroidLib.Selector == "superSU")
                    {
                        AndroidLib.InitialCmd = "reboot recovery";
                        noReturnADBCommand.RunWorkerAsync();
                        MessageBox.Show(
                            @"SuperSU was successfully pushed! Your phone will now reboot to Recovery." + "\n" +
                            "Once there, hit the Install button in the top left corner of TWRP." + "\n" +
                            "Then, scroll down until you see SuperSU.zip. Tap on it, and confirm flashing it." + "\n" +
                            "Once it finishes flashing, reboot your phone back to Android." + "\n" + "\n" +
                            "Congratulations! Your phone is now rooted!",
                            @"SuperSU Push Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flashSuperSUButton.Enabled = true;
                    }
                    else if (AndroidLib.Selector == "flashROM")
                    {
                        AndroidLib.InitialCmd = "reboot recovery";
                        noReturnADBCommand.RunWorkerAsync();
                        MessageBox.Show(
                            openFileDialog1.SafeFileName +
                            @" was successfully pushed! Your phone will now reboot into Recovery." + "\n" +
                            "Once there, hit the Backup button and do a backup of your current ROM." + "\n" +
                            "Then, go back and hit the Wipe button to wipe your current ROM and allow space for the new ROM to be flashed" +
                            "\n" + "Then, hit the Install button in the top left corner of TWRP." + "\n" +
                            "Then, scroll down until you see the ROM file you previously chose. Tap on it, and confirm flashing it." +
                            "\n" + "Once it finishes flashing, reboot your phone back to Android.",
                            @"ROM Push Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flashROMButton.Enabled = true;
                    }
                    else
                    {
                        loadingSpinner.Visible = false;
                        pushFilesButton.Enabled = true;
                        MessageBox.Show(openFileDialog1.SafeFileName + @" was successfully pushed!",
                            @"File Push Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    _android.Dispose();
                }
                else
                {
                    if (AndroidLib.Selector == "superSU")
                    {
                        loadingSpinner.Visible = false;
                        MessageBox.Show(
                            @"An error occured while attempting to push SuperSU.zip. Please try again in a few moments.",
                            @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flashSuperSUButton.Enabled = true;
                    }
                    else
                    {
                        loadingSpinner.Visible = false;
                        MessageBox.Show(
                            @"An error occured while attempting to push " + openFileDialog1.SafeFileName + @". " +
                            @"Please try again in a few moments.", @"Houston, we have a problem!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        pushFilesButton.Enabled = true;
                    }
                    _android.Dispose();
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

        private void pushFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    openFileDialog1.InitialDirectory = @"C:\";
                    openFileDialog1.Title = @"Select a file";
                    openFileDialog1.FileName = "Choose File...";
                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        loadingSpinner.Visible = true;
                        pushFilesButton.Enabled = false;
                        AndroidLib.InitialCmd = openFileDialog1.FileName;
                        AndroidLib.SecondaryCmd = "/sdcard/" + openFileDialog1.SafeFileName;
                        pushFile.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rebootBootloaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    rebootBootloaderButton.Enabled = false;
                    AndroidLib.InitialCmd = "reboot bootloader";
                    noReturnADBCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rebootButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    rebootButton.Enabled = false;
                    AndroidLib.InitialCmd = "reboot";
                    noReturnADBCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rebootFromBootloaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    loadingSpinner.Visible = true;
                    rebootFromBootloaderButton.Enabled = false;
                    AndroidLib.InitialCmd = "reboot";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rebootRecoveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    rebootRecoveryButton.Enabled = false;
                    AndroidLib.InitialCmd = "reboot recovery";
                    noReturnADBCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rebootToBootloaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    rebootToBootloaderButton.Enabled = false;
                    AndroidLib.InitialCmd = "reboot bootloader";
                    noReturnADBCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void reloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                reloadButton.Enabled = false;
                refreshSpinner.Visible = true;
                deviceRecognition.RunWorkerAsync();
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

        private void relockBootloaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    loadingSpinner.Visible = true;
                    relockBootloaderButton.Enabled = false;
                    AndroidLib.InitialCmd = "reboot bootloader";
                    AndroidLib.Selector = "relockBootloader";
                    noReturnADBCommand.RunWorkerAsync();
                }
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    loadingSpinner.Visible = true;
                    relockBootloaderButton.Enabled = false;
                    AndroidLib.InitialCmd = "oem";
                    AndroidLib.SecondaryCmd = "lock";
                    AndroidLib.Selector = "relockBootloader";
                    noReturnFastbootCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void requestsTile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(
                    "https://docs.google.com/forms/d/1fBsKXhHilnwtqDQdJuJ9dDpxSB5cZMu5zAEWsM_ogGE/viewform?usp=send_form");
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

        private void restoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    openFileDialog1.InitialDirectory = @"C:\";
                    openFileDialog1.Title = @"Please select an Android backup file (.ab)";
                    openFileDialog1.FileName = "Choose File...";
                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;
                    openFileDialog1.Filter = @" .AB|*.ab";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        loadingSpinner.Visible = true;
                        restoreButton.Enabled = false;
                        AndroidLib.InitialCmd = "restore";
                        AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                        adbCommand.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void secondTWRPButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("./Data/Recoveries/TWRP2.img"))
                {
                    if (statusLabel.Text == @"Status: Fastboot")
                    {
                        loadingSpinner.Visible = true;
                        secondTWRPButton.Enabled = false;
                        AndroidLib.InitialCmd = "flash";
                        AndroidLib.SecondaryCmd = "recovery ./Data/Recoveries/TWRP2.img";
                        AndroidLib.Selector = "secondTWRP";
                        noReturnFastbootCommand.RunWorkerAsync();
                    }
                    else if (statusLabel.Text == @"Status: Online")
                    {
                        loadingSpinner.Visible = true;
                        secondTWRPButton.Enabled = false;
                        AndroidLib.InitialCmd = "reboot bootloader";
                        AndroidLib.Selector = "secondTWRP";
                        noReturnADBCommand.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show(this,
                            @"A phone has not been recognized by the toolkit!",
                            @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, @"This recovery appears to be missing from the Data folder!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void sideloadROMButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    @"This will push a ROM or other .zip file to your phone and automatically install it." + "\n" +
                    "\n" + @"This is best used when only the recovery is accessible on your phone." + "\n" + "\n" +
                    @"Are you ready to continue?", @"ADB Sideload", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    if (statusLabel.Text == @"Status: Unknown")
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Select the .zip file you would like to flash in ADB Sideload";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.Filter = @" .ZIP|*.zip";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            sideloadROMButton.Enabled = false;
                            AndroidLib.InitialCmd = "sideload";
                            AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                            AndroidLib.Selector = "sideload";
                            adbCommand.RunWorkerAsync();
                        }
                    }
                    else if (statusLabel.Text == @"Status: Online")
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Select the .zip file you would like to sideloaded";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.Filter = @" .ZIP|*.zip";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            sideloadROMButton.Enabled = false;
                            AndroidLib.InitialCmd = "reboot recovery";
                            AndroidLib.Selector = "rebootRecoverySideload";
                            noReturnADBCommand.RunWorkerAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this,
                            @"A phone has not been recognized by the toolkit!",
                            @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void temporaryKernelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will allow you to temporarily boot with a custom kernel .img file without permanently flashing it. It will default to your previous kernel upon reboot. Are you ready to continue?",
                            @"Temporary Custom Kernel Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a kernel .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            temporaryKernelButton.Enabled = false;
                            AndroidLib.InitialCmd = "boot";
                            AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                            AndroidLib.Selector = "flashTempKernel";
                            noReturnFastbootCommand.RunWorkerAsync();
                        }
                    }
                }
                else if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will allow you to temporarily boot with a custom kernel .img file without permanently flashing it. It will default to your previous kernel upon reboot. Are you ready to continue?",
                            @"Temporary Custom Kernel Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a kernel .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            temporaryKernelButton.Enabled = false;
                            AndroidLib.InitialCmd = "reboot bootloader";
                            AndroidLib.Selector = "flashTempKernel";
                            noReturnADBCommand.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void temporaryRecoveryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will allow you to temporarily flash and use a custom recovery without permanently flashing it. It will default to your previous recovery upon reboot. Are you ready to continue?",
                            @"Temporary Custom Recovery Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a recovery .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            temporaryRecoveryButton.Enabled = false;
                            AndroidLib.InitialCmd = "boot";
                            AndroidLib.SecondaryCmd = openFileDialog1.FileName;
                            AndroidLib.Selector = "flashTempRecovery";
                            noReturnFastbootCommand.RunWorkerAsync();
                        }
                    }
                }
                else if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will allow you to temporarily flash and use a custom recovery without permanently flashing it. It will default to your previous recovery upon reboot. Are you ready to continue?",
                            @"Temporary Custom Recovery Flash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Please select a recovery .img file";
                        openFileDialog1.FileName = "Choose File...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .IMG|*.img";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            temporaryRecoveryButton.Enabled = false;
                            AndroidLib.InitialCmd = "reboot bootloader";
                            AndroidLib.Selector = "flashTempRecovery";
                            noReturnADBCommand.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void thirdTWRPButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("./Data/Recoveries/TWRP3.img"))
                {
                    if (statusLabel.Text == @"Status: Fastboot")
                    {
                        loadingSpinner.Visible = true;
                        thirdTWRPButton.Enabled = false;
                        AndroidLib.InitialCmd = "flash";
                        AndroidLib.SecondaryCmd = "recovery ./Data/Recoveries/TWRP3.img";
                        AndroidLib.Selector = "thirdTWRP";
                        noReturnFastbootCommand.RunWorkerAsync();
                    }
                    else if (statusLabel.Text == @"Status: Online")
                    {
                        loadingSpinner.Visible = true;
                        thirdTWRPButton.Enabled = false;
                        AndroidLib.InitialCmd = "reboot bootloader";
                        AndroidLib.Selector = "thirdTWRP";
                        noReturnADBCommand.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show(this,
                            @"A phone has not been recognized by the toolkit!",
                            @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, @"This recovery appears to be missing from the Data folder!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tokenID_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                loadingSpinner.Visible = true;
                using (StreamWriter sw = File.CreateText("./Data/token.txt"))
                {
                    sw.WriteLine(
                        Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(_device, AndroidLib.InitialCmd,
                            AndroidLib.SecondaryCmd)));
                    sw.WriteLine(" ");
                    sw.WriteLine(
                        "PLEASE COPY EVERYTHING FROM <<<< Indentifier Token Start >>>> TO <<<< Indentifier Token End >>>>!");
                    sw.WriteLine("PLEASE ENSURE THAT YOU DELETE ALL (bootloader)'s AS WELL!");
                    sw.WriteLine(" ");
                    sw.WriteLine("NEXT, SIGN IN TO YOUR HTC DEV ACCOUNT ON THE WEBPAGE THAT JUST OPENED!");
                    sw.WriteLine(
                        "IF YOU DO NOT HAVE ONE, CREATE AND ACTIVATE AN ACCOUNT WITH A VALID EMAIL ADDRESS THEN COME BACK TO THAT LINK!");
                    sw.WriteLine(
                        "THEN, PASTE THE TOKEN ID YOU JUST COPIED AT THE BOTTOM OF THE HTCDEV WEBPAGE THAT JUST OPENED!");
                    sw.WriteLine("HIT SUBMIT, AND WAIT FOR THE EMAIL WITH THE UNLOCK BINARY FILE!");
                    sw.WriteLine(" ");
                    sw.WriteLine(
                        "ONCE YOU HAVE RECEIVED THE UNLOCK FILE IN YOUR EMAIL, YOU CAN CONTINUE ON TO THE NEXT STEP!");
                    sw.WriteLine("THIS FILE IS SAVED AS token.txt WITHIN THE DATA FOLDER IF NEEDED FOR FUTURE USE!");
                }
                Process.Start("http://www.htcdev.com/bootloader/unlock-instructions/page-3");
                Process.Start(Application.StartupPath + "/Data/token.txt");
                _android.Dispose();
                loadingSpinner.Visible = false;
                getTokenIDButton.Enabled = true;
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

        private void twitterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://twitter.com/WindyCityRockr");
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

        private void uninstallAppButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Online")
                {
                    string location =
                        Interaction.InputBox(
                            "Please input the name of the APK package for the app you want to uninstall. For example, Adobe Reader's package file is 'com.adobe.reader'.",
                            "Uninstall App", "", 775, 450);
                    loadingSpinner.Visible = true;
                    pullFilesButton.Enabled = false;
                    AndroidLib.InitialCmd = "uninstall";
                    AndroidLib.SecondaryCmd = location;
                    adbCommand.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void unlockBootloaderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusLabel.Text == @"Status: Fastboot")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will unlock your bootloader and completely wipe your phone." + "\n" + "\n" +
                            @"You must have received the unlock_code.bin file from HTC in your email, and have it downloaded and ready to be used." +
                            "\n" + "\n" + @"Have you backed up all necessary files and are ready to continue?",
                            @"Ready To Unlock?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Select the binary file sent to you by HTC.";
                        openFileDialog1.FileName = "Choose unlock_code.bin...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .BIN|*.bin";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            AndroidLib.InitialCmd = "flash";
                            AndroidLib.SecondaryCmd = "unlocktoken " + openFileDialog1.FileName;
                            AndroidLib.Selector = "bootloaderUnlock";
                            noReturnFastbootCommand.RunWorkerAsync();
                        }
                    }
                }
                else if (statusLabel.Text == @"Status: Online")
                {
                    DialogResult dialogResult =
                        MessageBox.Show(
                            @"This will unlock your bootloader and completely wipe your phone." + "\n" + "\n" +
                            @"You must have received the unlock_code.bin file from HTC in your email, and have it downloaded and ready to be used." +
                            "\n" + "\n" + @"Have you backed up all necessary files and are ready to continue?",
                            @"Ready To Unlock?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        openFileDialog1.InitialDirectory = @"C:\";
                        openFileDialog1.Title = @"Select the binary file sent to you by HTC.";
                        openFileDialog1.FileName = "Choose unlock_code.bin...";
                        openFileDialog1.CheckFileExists = true;
                        openFileDialog1.CheckPathExists = true;
                        openFileDialog1.Filter = @" .BIN|*.bin";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            loadingSpinner.Visible = true;
                            AndroidLib.InitialCmd = "reboot bootloader";
                            AndroidLib.Selector = "bootloaderUnlock";
                            noReturnADBCommand.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,
                        @"A phone has not been recognized by the toolkit!",
                        @"Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void xdaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://forum.xda-developers.com/private.php?do=newpm&u=4485224");
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

        private static class AndroidLib
        {
            public static string InitialCmd = "";
            public static string SecondaryCmd = "";
            public static string Selector = "";
        }

        #endregion Nested type: AndroidLib
    }
}