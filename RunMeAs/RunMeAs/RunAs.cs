using System.Diagnostics;
using System.Security;
using Utility.Serializer;

namespace RunMeAs
{
    public partial class RunAs : Form
    {
        public RunAs()
        {
            InitializeComponent();

            AllowDrop = true;
            DragEnter += RunAs_DragEnter;
            DragOver += RunAs_DragOver;
            DragDrop += RunAs_DragDrop;

            Init();

        }

        private void Init()
        {
            LoadSettings settings = JsonWapper.DeserializeFromFile<LoadSettings>(Path.Combine(Folder.ProgramFolder, "settings.json"));

            tbFilePath.Text = settings.FilePath;
            tbUserName.Text = settings.UserName;
            try
            {
                tbPassword.Text = EncryptionWapper.Decrypt(settings.Password, "Abe12");
            }
            catch (Exception e)
            {
                tbPassword.Text = "";
            }
            cbRunAsAdmin.Checked = settings.RunAsAdmin;
        }

        private void RunAs_DragDrop(object? sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            tbFilePath.Text = files[0];
        }

        private void RunAs_DragOver(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
        }

        private void RunAs_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
        }

        private void btnSeatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                DefaultExt = "exe",
                Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoadSettings settings = new LoadSettings()
            {
                FilePath = tbFilePath.Text,
                Password = EncryptionWapper.Encrypt(tbPassword.Text, "Abe12"),
                UserName = tbUserName.Text,
                RunAsAdmin = cbRunAsAdmin.Checked
            };

            if (File.Exists(Path.Combine(Folder.ProgramFolder, "settings.json")))
            {
                File.Delete(Path.Combine(Folder.ProgramFolder, "settings.json"));
            }


            JsonWapper.SerializeToFile(settings, Path.Combine(Folder.ProgramFolder, "settings.json"));

            Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                var p1 = new ProcessStartInfo
                {
                    UseShellExecute = cbRunAsAdmin.Checked,
                    Verb = "runas",
                    FileName = tbFilePath.Text
                };

                if(!cbRunAsAdmin.Checked)
                {
                    p1.UserName = tbUserName.Text;
                    p1.Password = ConvertToSecureString(tbPassword.Text);
                }

                Process.Start(p1);
            }
            catch (Exception ex)
            {

            }
        }

        private SecureString ConvertToSecureString(string password)
        {
            if (password == null)
                throw new ArgumentNullException("password");

            var securePassword = new SecureString();

            foreach (char c in password)
                securePassword.AppendChar(c);

            securePassword.MakeReadOnly();
            return securePassword;
        }

        private void cbRunAsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox checkBox)
            {
                PUser.Enabled = !checkBox.Checked;
            }
            
        }
    }
}