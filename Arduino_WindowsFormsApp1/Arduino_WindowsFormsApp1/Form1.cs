using System;
using System.IO.Ports; // 네임스페이스 필요 > 즉 IO 객체를 불러와 using
using System.Windows.Forms;

namespace Arduino_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //시리얼 포트를 사용하려면 System.IO.Ports 네임스페이스가 필요
        //시리얼포트를 초기화하는 코드에서 통신 속도는 아두이노에서 설정한 통신 속도와 일치해야 정상으로 데이터를 주고받을 수 있다.
        //COM3는 통신 채널의 이름으로 아두이노 보드를 컴퓨터에 연결할 때 COM# 과 같이 숫자가 달라질 수 있다. 따라서 컴퓨터에 맞는 통신채널 이름을 사용하도록 주의.
        //COM3, COM4와 같이 통신 채널의 번호는 컴퓨터와 아두이노 보드를 USB 케이블로 연결한 상태에서 내 컴퓨터의 장치 관리자 프로그램을 열어 (COM & LPT) 항목을 확장해 확인 할 수 있다.
        SerialPort port = new SerialPort("COM4", 1042); //시리얼 포트 초기화 

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOn_Click(object sender, EventArgs e)
        {
            port.Open();
            port.Write("1"); //LED 켜짐
            port.Close();
        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            port.Open();
            port.Write("0"); //LED 꺼짐    
            port.Close();
        }

        // port 는 시리얼 통신하는 인스턴스 변수, 채널을 여닫고 쓰고 읽기 가능.
        // port.Write() 메소드를 호출하면 USB 케이블로 데이터 전달
        // 매개변수로 문자열 "1" 을 쓰면 1을 전달하고, "0" 을 쓰면 0을 전달.
        // 앞서 스케치 코드에서 문자열 1을 받으면 LED를 켜고,
        // 그 이외의 값을 전달받으면 LED를 끄도록 작성, 즉 0 전달받으면 꺼짐
        // 
    }
}
