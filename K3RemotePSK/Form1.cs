using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace K3RemotePSK
{


    public partial class Form1 : Form
    {

        public static SerialPort serialPort;
        public static BackgroundWorker backgroundWorker1 = new BackgroundWorker();
        public static string rxData = "";
        public static string ifData = "";
        delegate void SetTextCallback(string text);
        public bool isIFString = false;
        public bool isTBString = false;
        public bool pausePoll = false;


        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
        }


        private void comConnectButton_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort();


            if (serialPort is SerialPort)
            {
                serialPort.PortName = comPortName.Text;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.BaudRate = 38400;
                serialPort.RtsEnable = true;

                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                try
                {
                    serialPort.Open();
                    statusLabel.Text = "Connected";
                    serialPort.DiscardOutBuffer();
                    serialPort.DiscardInBuffer();
                    serialPort.Write("TT0;");
                    serialPort.Write("FA00014071700;"); // Sets 20m - 14.070MHz + 1700Hz audio
                    Thread.Sleep(500);
                    serialPort.Write("MD6;"); // Sets data mode
                    Thread.Sleep(200);
                    serialPort.Write("DT3;"); // Sets PSK
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception exc)
                {
                }// end CATCH portion of TRY/CATCH block


            }



        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (serialPort.IsOpen)
            {
                if (pausePoll != true)
                {
                    Thread.Sleep(1000);
                    readFrequency();
                }
                if (pausePoll != true)
                {
                    Thread.Sleep(1000);
                    readBuffer();
                }
            }
        }

        private static void readFrequency()
        {
            serialPort.Write("IF;");
        }
        private static void readBuffer()
        {
            serialPort.Write("TB;");
        }

        private void updateFrequency(string freqString)
        {
            if (vfoATextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(updateFrequency);
                this.Invoke(d, new object[] { freqString });
            }
            else
            {
                vfoATextBox.Text = freqString;
            }
            vfoATextBox.Text = freqString;
        }

        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if (indata.Length > 2)
            {

                if (indata.Substring(0, 2) == "IF")
                {
                    isIFString = true;
                    isTBString = false;
                }
                else if (indata.Substring(0, 2) == "TB")
                {
                    isTBString = true;
                    isIFString = false;
                }
            }
            rxData += indata;
            if (indata.Substring(indata.Length - 1) == ";")
            {
                if (isIFString == true)
                {
                    Console.WriteLine("IF:" + rxData);
                    parseReceivedIFData(rxData);
                    isIFString = false;
                }
                if (isTBString == true)
                {
                    rxData = rxData.Substring(0, rxData.Length - 1); // Remove trailing semi-colon
                    Console.WriteLine("TB:" + rxData);
                    if (rxData.Length > 5)
                    {
                        displayDecode(rxData.Substring(5));
                    }
                    isTBString = false;
                }
                rxData = "";
            }
        }


        private void displayDecode(string indata)
        {
            rxData = indata;
            AppendDecode(rxData);
        }

        private void parseReceivedIFData(string ifData)
        {
            try
            {
                decimal freq = Decimal.Parse(ifData.Substring(2, 11));
                freq = freq / 1000000;
                string freqString = freq.ToString();
                updateFrequency(freqString);
                // The 28th char of the IF string is 0 if receive, 1 if TX 
                string txStatus = ifData.Substring(28, 1);
                updateTxStatus(txStatus);
            }
            catch (Exception exc)
            { // Can happen if a decoded char comes in in the middle of the IF packet
            }
        }

        private void updateTxStatus(string txStatus)
        {
            if (txStatus == "1")
            {
                txButton.BackColor = Color.Red;
                txButton.ForeColor = Color.White;
                txButton.Text = "TX";
            }
            else
            {
                txButton.BackColor = Color.DarkOliveGreen;
                txButton.ForeColor = Color.White;
                txButton.Text = "RX";
            }
        }

        public void AppendDecode(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendDecode), new object[] { value });
                return;
            }
            decodedText.Text += value;
            decodedText.SelectionStart = decodedText.Text.Length;
            decodedText.ScrollToCaret();
        }

        public void AppendTX(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTX), new object[] { value });
                return;
            }
            txTextBox.Text += value;
            Application.DoEvents();
            txTextBox.SelectionStart = txTextBox.Text.Length;
            txTextBox.ScrollToCaret();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transmitThis(string value)
        {
            if (value.Length > 20) { throw new FormatException("String to transmit too long"); }
            serialPort.Write("KYW" + value + ";");
            AppendTX(value + "\r\n");
        }

        private void transmitThisMulti(string value)
        {
            pausePoll = true;
            updateTxStatus("1");
            if (value.Length <= 20) { transmitThis(value); }
            else
            {
                double numSplits = value.Length / 20;
                numSplits = Math.Ceiling(numSplits);
                for (int i = 0; i <= numSplits; i++)
                {
                    int startChar = (i * 20);
                    if (value.Substring(startChar).Length > 20)
                    {
                        transmitThis(value.Substring(startChar, 20));
                    }
                    else
                    {
                        transmitThis(value.Substring(startChar));
                    }
                    Thread.Sleep(5250);
                }
            }
            updateTxStatus("0");
            pausePoll = false;
        }

        private string overIntro()
        {
            string toCall = "NOCALL";
            if (callsignTextBox.Text.Length>1) { toCall = callsignTextBox.Text; }
            return toCall + " " + toCall + " " + toCall + " de M0BLF M0BLF M0BLF.";
        }

        private void cqButton_Click(object sender, EventArgs e)
        {
            transmitThisMulti("CQ CQ CQ de M0BLF M0BLF M0BLF K");
        }

        private void over1Button_Click(object sender, EventArgs e)
        {
            string personName = "OM";
            if (nameTextBox.Text.Length > 1) { personName = nameTextBox.Text; }
            string intro = overIntro();
            transmitThisMulti(intro + " Hello dear " + personName + " and thanks for the call = Your RST RST " + rstTextBox.Text + " " + rstTextBox.Text + " = Name Name is Dom Dom Dom and QTH QTH is Cambridge Cambridge Cambridge (JO02bg JO02bg) + " + intro + " )");
        }

        private void lastOverButton_Click(object sender, EventArgs e)
        {
            string intro = overIntro();
            transmitThisMulti(intro + " OK, Thanks for the information = Running an Elecraft K3 K3 with 30W 30W to  dipole = 73 73 and thanks for the nice QSO. + " + intro + " *");
        }

        private void freqUpButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("UP;");
        }

        private void freqDownButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("DN;");
        }
    }
}
