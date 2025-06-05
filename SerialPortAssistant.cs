using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySerialPort
{
    public partial class SerialPortAssistant : Form
    {
        private bool m_bReceiveDataShow = true;
        private List<byte> m_receiveDataBuffer = new List<byte>();
        private List<byte> m_sendDataBuffer = new List<byte>();
        private int m_receiveDataBufferCount = 0;
        private int m_sendDataBufferCount = 0;
        public SerialPortAssistant()
        {
            InitializeComponent();
        }

        private void mOpenSerialPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = mPortNo.Text;
                    serialPort1.BaudRate = int.Parse(this.mBaudRate.Text);
                    serialPort1.DataBits = int.Parse(this.mDataBits.Text);
                    switch (mCheckDigit.SelectedIndex)
                    {
                        case 0:
                            serialPort1.Parity = System.IO.Ports.Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = System.IO.Ports.Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = System.IO.Ports.Parity.Even;
                            break;
                        default:
                            break;
                    }
                    switch (mStopBits.SelectedIndex)
                    {
                        case 0:
                            serialPort1.StopBits = System.IO.Ports.StopBits.None;
                            break;
                        case 1:
                            serialPort1.StopBits = System.IO.Ports.StopBits.One;
                            break;
                        case 2:
                            serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                            break;
                        case 3:
                            serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                            break;
                        default:
                            break;
                    }
                    serialPort1.Open();
                    mOpenSerialPortButton.Text = "关闭串口";
                    if (serialPort1.IsOpen)
                    {
                        mStatusInfoToolStripStatusLabel.Text = "串口已打开";
                    }else
                    {
                        mStatusInfoToolStripStatusLabel.Text = "串口打开失败";
                    }
                }
                else
                { 
                    serialPort1.Close();
                    mOpenSerialPortButton.Text = "打开串口";
                    if (!serialPort1.IsOpen)
                    {
                        mStatusInfoToolStripStatusLabel.Text = "串口已关闭";
                    }
                    else
                    {
                        mStatusInfoToolStripStatusLabel.Text = "串口关闭失败";
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()+serialPort1.PortName.ToString());
            }
        }

        private void SerialPortAssistant_Load(object sender, EventArgs e)
        {
            LoadPortNo();
            this.mPortNo.SelectedIndex = 0;
            this.mBaudRate.SelectedIndex = 1;
            this.mCheckDigit.SelectedIndex = 0;
            this.mDataBits.SelectedIndex = 3;
            this.mStopBits.SelectedIndex = 1;
            mStatusInfoToolStripStatusLabel.Text = "串口未连接！";
        }

        private void LoadPortNo()
        {
            string[] portNos = SerialPort.GetPortNames();
            for (int i = 0; i < portNos.Length; i++)
            {
                mPortNo.Items.Add(portNos[i]);
            }
        }

        private void mManualSendButton_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void SendData()
        {
            if(serialPort1 != null)
            {
                MessageBox.Show("串口异常");
                return;
            }
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("请打开串口");
                return;
            }
            if ( mSendAreaRichTextBox.Text != "")
            {
                if(mSendHexadecimalCheckBox.Checked == true)
                {
                    serialPort1.Write(Transform.ToHexString(m_sendDataBuffer.ToArray()));
                }
                else
                {
                    serialPort1.Write(mSendAreaRichTextBox.Text);
                }
                m_sendDataBufferCount += serialPort1.BytesToWrite;
                mSendCountInfoToolStripStatusLabel.Text = m_sendDataBufferCount.ToString();
            }
            else
            {
                MessageBox.Show("请输入发送数据");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (m_bReceiveDataShow == false)
                {
                    return;
                }

                byte[] receiveTemp = new byte[serialPort1.BytesToRead];
                serialPort1.Read(receiveTemp, 0, receiveTemp.Length);
                m_receiveDataBuffer.AddRange(receiveTemp);
                m_receiveDataBufferCount += receiveTemp.Length;
                mReceiveCountInfoToolStripStatusLabel.Text = m_receiveDataBufferCount.ToString();
                this.Invoke(new EventHandler(delegate
                {
                    if (!mReceiveHexadecimalCheckBox.Checked)
                    {
                        mReceiveAreaRichTextBox.AppendText(Encoding.GetEncoding("gb2312").GetString(receiveTemp).Replace("\0", "\\0"));
                    } else
                    {
                        mReceiveAreaRichTextBox.AppendText(Transform.ToHexString(receiveTemp));
                    }
                }));
            }
        }

        private void mStopReceiveButton_Click(object sender, EventArgs e)
        {
            if (m_bReceiveDataShow == true)
            {
                m_bReceiveDataShow = false;
                mStopReceiveButton.Text = "取消暂停";
            } else
            {
                m_bReceiveDataShow = true;
                mStopReceiveButton.Text = "暂停";
            }
        }

        private void mManualClearButton_Click(object sender, EventArgs e)
        {
            clearReceiveData();
        }

        private void clearReceiveData()
        {
            mReceiveAreaRichTextBox.Text = string.Empty;
            m_receiveDataBuffer.Clear();
            m_receiveDataBufferCount = 0;
            mReceiveCountInfoToolStripStatusLabel.Text = "0";
        }

        private void clearSendData()
        {
            mSendAreaRichTextBox.Text = string.Empty;
            mSendCountInfoToolStripStatusLabel.Text = "0";
            m_sendDataBuffer.Clear();
            m_sendDataBufferCount = 0;
        }

        private void mClearSendButton_Click(object sender, EventArgs e)
        {
            clearSendData();
        }

        private void mReceiveHexadecimalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(mReceiveAreaRichTextBox.Text == "")
            {
                return;
            }
            if (mReceiveHexadecimalCheckBox.Checked == true)
            {
                mReceiveAreaRichTextBox.Text = Transform.ToHexString(m_receiveDataBuffer.ToArray()," ");
            } else
            {
                mReceiveAreaRichTextBox.Text = Encoding.GetEncoding("gb2312").GetString(m_receiveDataBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void mAutoClearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mAutoClearCheckBox.Checked == true)
            {
                mAutoClearReceiveTimer.Start();
            } else
            {
                mAutoClearReceiveTimer.Stop();
            }
        }

        private void mAutoClearReceiveTimer_Tick(object sender, EventArgs e)
        {
            if (mAutoClearCheckBox.Checked == true)
            {
                if (m_receiveDataBufferCount >= 4096)
                {
                    clearReceiveData();
                }
            }
        }

        private void mAutoSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mAutoSendCheckBox.Checked == true)
            {
                SendData();
            }
        }

        private void mSendAreaRichTextBox_Leave(object sender, EventArgs e)
        {
            if(mSendHexadecimalCheckBox.Checked == true)
            {
                if (DataEncoding.IsHexString(mSendAreaRichTextBox.Text.Replace(" ", "")))
                {
                    m_sendDataBuffer.Clear();
                    m_sendDataBuffer.AddRange(Transform.ToBytes(mSendAreaRichTextBox.Text.Replace(" ", "")));
                }else
                {
                    MessageBox.Show("请输入正确的十六进制数");
                    mSendAreaRichTextBox.Select();
                }
            }
            else
            {
                m_sendDataBuffer.Clear();
                m_sendDataBuffer.AddRange(Encoding.GetEncoding("gb2312").GetBytes(mSendAreaRichTextBox.Text));

            }

            if (mAutoSendCheckBox.Checked == true)
            {
                SendData();
            }
        }

        private void mSendHexadecimalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (mSendAreaRichTextBox.Text == "")
            {
                return;
            }
            if (mSendHexadecimalCheckBox.Checked == true)
            {
                mSendAreaRichTextBox.Text = Transform.ToHexString(m_sendDataBuffer.ToArray(), " ");
            }
            else
            {
                mSendAreaRichTextBox.Text = Encoding.GetEncoding("gb2312").GetString(m_sendDataBuffer.ToArray()).Replace("\0", "\\0");
            }
            
        }

        private void mClearCountToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            clearReceiveData();
            clearSendData();
        }
    }
}
