using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace aiav
{
    [Serializable]
    public class MLModel
    {
        private static readonly double Threshold = 0.5;

        public bool Predict(string inputData)
        {
            double feature = inputData[0];
            return feature > Threshold;

            // Return true if malicious, false if not
            // This is a dummy example that always returns false
            // return false;
        }

    }
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        private string modelFilePath = "classifier.pkl";
        private string featuresFilePath = "features.pkl";
        private MLModel mlModel;
        public Form1()
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "drum.wav";
            soundPlayer.LoadAsync();
        }
        private int viruses = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string removex = this.listBox1.Text;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete(removex);
            listBox1.Items.Clear();
            MessageBox.Show("Selected Malware Removed");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = "Selected Location : " + folderBrowserDialog1.SelectedPath;
            viruses = 0;
            progressBar1.Value = 0;
            listBox1.Items.Clear();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                if (string.IsNullOrWhiteSpace(selectedFolderPath) || selectedFolderPath.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
                {
                    MessageBox.Show("Invalid folder path.");
                    return;
                }

                string[] search = Directory.GetFiles(selectedFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                          .Where(file => file.ToLower().EndsWith(".exe") || file.ToLower().EndsWith(".txt") || file.ToLower().EndsWith(".bat"))
                                          .ToArray();

                progressBar1.Maximum = search.Length;

                MessageBox.Show($"Number of files found: {search.Length}");

                foreach (string item in search)
                {
                    try
                    {
                        StreamReader stream = new StreamReader(item);
                        string read = stream.ReadToEnd();

                        // Use the model to predict if the file is malicious
                        bool isMalicious = mlModel.Predict(read);

                        if (isMalicious)
                        {
                            viruses += 1;
                            listBox1.Items.Add(item);
                            button3.Show();
                            label2.Text = "Detected: " + viruses.ToString();
                        }

                        progressBar1.Increment(1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing directory: {ex.Message}");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            soundPlayer.Play();
            try
            {
                using (FileStream stream = new FileStream(modelFilePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    mlModel = (MLModel)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deserializing the model: " + ex.Message);
            }
        }
        
        }
    }
