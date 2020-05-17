using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace WhatsappAutoMessageSender
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }
        string CLIP_BUTTON = "/html/body/div[1]/div/div/div[4]/div/header/div[3]/div/div[2]/div";
        string VIDEO_OR_PICTURE = "/html/body/div[1]/div/div/div[4]/div/header/div[3]/div/div[2]/span/div/div/ul/li[1]/button/input";
        string DOCUMENT_Xpath = "/html/body/div[1]/div/div/div[4]/div/header/div[3]/div/div[2]/span/div/div/ul/li[3]/button/input";
        IWebDriver Driver;
        string Status;
        int FailedProcess = 0;
        int SuccedProcess = 0;
        int NumbersIndexCounter = 0;
        int ProcessCounter = 0;

        
        OpenFileDialog openFileDialog = new OpenFileDialog();

        List<string> PhoneNumbersList = new List<string>();
        List<Infos> InfoList = new List<Infos>();

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }       

        public void ImportNumbers(string filePath)
        {

            lstBxNumbers.Items.Clear();
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);            
            StreamReader streamReader = new StreamReader(fileStream);            
            string PhoneNumber = streamReader.ReadLine();
            int PhoneNumbersCount = 0;
            while (PhoneNumber != null)
            {
                PhoneNumbersList.Add(PhoneNumber);
                lstBxNumbers.Items.Add(PhoneNumber);
                lblNumbersCount.Text = "Numbers Count: " + ++PhoneNumbersCount;
                PhoneNumber = streamReader.ReadLine();
            }
            
            streamReader.Close();
            fileStream.Close();
        }

        public void SendText(string number)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("_35EW6")));

                Driver.FindElement(By.ClassName("_35EW6")).Click();//Whatsapp send button click
                SuccedProcess++;
                Status = "Succed";
            }
            catch (ElementClickInterceptedException)
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("_35EW6")));
                Driver.FindElement(By.ClassName("_35EW6")).Click();
                SuccedProcess++;
                Status = "Succed";
            }
            catch (NoSuchElementException)
            {
                FailedProcess++;
                Status = "Failed";
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
                Status = "Failed";
            }


        }

        public void SendImageOrVideo(string number)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(CLIP_BUTTON)));
            try
            {
                
                Driver.FindElement(By.XPath(CLIP_BUTTON)).Click();//Web.whatsapp 'CLİP' button click
            }
            catch (ElementClickInterceptedException )
            {
                Driver.FindElement(By.XPath(CLIP_BUTTON)).Click();
            }
            catch (ElementNotInteractableException )
            {
               
                Driver.FindElement(By.XPath(CLIP_BUTTON)).Click();
            }
            catch (NoSuchElementException)
            {
                //FailedProcess++;
            }
            Thread.Sleep(3000);
          //  wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(VIDEO_OR_PICTURE)));
            try
            {
                Driver.FindElement(By.XPath(VIDEO_OR_PICTURE)).SendKeys(txtBxFilePath.Text);//Web.whatsapp input image or video file path
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span/div/div")));
                Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span/div/div")).Click();//Click send button
                SuccedProcess++;
                Status = "Succed";
            }
            catch (NoSuchElementException)
            {
                FailedProcess++;
                Status = "Failed";
            }
            catch (Exception Excp)
            {
                MessageBox.Show(Excp.Message);
                Status = "Failed";
            }
            Thread.Sleep(3000);


        }
            
        public void SendFile(string number)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(CLIP_BUTTON)));
            try
            {
                Driver.FindElement(By.XPath(CLIP_BUTTON)).Click();//Web.whatsapp 'CLİP' button click

            }
            catch (ElementClickInterceptedException )
            {
                Driver.FindElement(By.XPath(CLIP_BUTTON)).Click();
            }
            catch (ElementNotInteractableException )
            {
                Driver.FindElement(By.XPath(CLIP_BUTTON)).Click();
            }
            catch (NoSuchElementException)
            {
                //Thread.Sleep(2000);
                // FailedProcess++;
            }
            Thread.Sleep(3000);
            try
            {
               // wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(DOCUMENT_Xpath)));

                Driver.FindElement(By.XPath(DOCUMENT_Xpath)).SendKeys(txtBxFilePath.Text);//Web.whatsapp input File(pdf,rar,zip,exe...) file path
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span/div/div")));
                Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span/div/div")).Click();
                Status = "Succed";
                SuccedProcess++;
            }
            catch (NoSuchElementException)
            {
                FailedProcess++;
                Status = "Failed";
            }
            catch (Exception Excp)
            {
                MessageBox.Show(Excp.Message);
                Status = "Failed";
            }
            Thread.Sleep(3000);

        }

        public void SendMessage(string number)
        {               
            Driver.Navigate().GoToUrl("http://web.whatsapp.com/send?phone=" + number + "&text=" + Uri.EscapeDataString(txtBxMessageText.Text) + "&source=&data=");
           
            if (radioBtnText.Checked == true)//Sending Text Message
            {
                SendText(number);
            }
            else if (radioBtnImageOrvideo.Checked == true)//Sending Image or Video 
            {
                SendImageOrVideo(number);
                
            }
            else if (radioBtnFile.Checked == true) //Sending File
            {
                SendFile(number);
            }

            GetInfos(number);
        }

        public void GetInfos(string number)
        {
            Infos info = new Infos();
            info.Time = DateTime.Now;
            info.Number = number;
            info.Message = txtBxMessageText.Text;
            info.Status = Status;
            InfoList.Add(info);
        }       

        private void btnImprotNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Choose Numbers List..";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowDialog();
                ImportNumbers(openFileDialog.FileName);
                NumbersIndexCounter = 0;
            }
            catch (Exception excp)
            {
                
            }

        }

        public void radioButtonCheckControl(object sender, EventArgs e)//radioButtons CheckChanged method
        {
            if (radioBtnText.Checked == true)
            {
                grpBxFilePath.Enabled = false;
            }
            else if (radioBtnImageOrvideo.Checked == true)
            {
                grpBxFilePath.Enabled = true;
            }
            else if (radioBtnFile.Checked == true)
            {
                grpBxFilePath.Enabled = true;
            }

        }

        private void btnLoginWhatsapp_Click(object sender, EventArgs e)
        {
            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            
            try
            {
                Driver = new FirefoxDriver(driverService);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Driver.Navigate().GoToUrl("http://web.whatsapp.com");                
                btnStart.Enabled = true;
            }
            catch(Exception excp)
            {
                MessageBox.Show(excp.Message);
            }           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (txtMessageCountForWait.Text == "" || txtWait.Text == "" || txtWaitBeforeEveryMessage.Text == "" || PhoneNumbersList.Count == 0)
            {
                MessageBox.Show("Please fill in the required fields.");
            }
            else if(radioBtnImageOrvideo.Checked==true && txtBxFilePath.Text == "")
            {
                MessageBox.Show("Please choose image or video.");
            }
            else if (radioBtnFile.Checked == true && txtBxFilePath.Text == "")
            {
                MessageBox.Show("Please choose file.");
            }
            else
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                grpBxMessage.Enabled = false;
                grpBxPhoneNumbers.Enabled = false;
                grpBxSettings.Enabled = false;
                timer1.Start();
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Title = "Choose Image, Video or File";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowDialog();
                txtBxFilePath.Text = openFileDialog.FileName;

            }
            catch(Exception excp)
            {
                MessageBox.Show(excp.Message);
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled =false;
            timer1.Stop();
            grpBxMessage.Enabled = true;
            grpBxPhoneNumbers.Enabled = true;
            grpBxSettings.Enabled = true;
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NumbersIndexCounter != PhoneNumbersList.Count)
            {
                SendMessage(PhoneNumbersList[NumbersIndexCounter++]);
            }
            lblFailedProcess.Text = FailedProcess.ToString();
            lblSuccedProcess.Text = SuccedProcess.ToString() ;
            Thread.Sleep(2000);
            dataGridİnfos.DataSource = "";
            dataGridİnfos.DataSource = InfoList;
            Thread.Sleep(Convert.ToInt16(txtWaitBeforeEveryMessage.Text)*1000);
            ProcessCounter++;

            if (NumbersIndexCounter == PhoneNumbersList.Count)
            {
                timer1.Stop();

                MessageBox.Show("Finished!");
                NumbersIndexCounter = 0;
                grpBxMessage.Enabled = true;
                grpBxPhoneNumbers.Enabled = true;
                grpBxSettings.Enabled = true;

            }

            if (ProcessCounter == Convert.ToInt32(txtMessageCountForWait.Text))
            {                
                Thread.Sleep(Convert.ToInt16(txtWait.Text) * 1000);
                ProcessCounter = 0;
            }

               
        }            
    }
}
