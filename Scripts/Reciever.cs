using System.Diagnostics;
using System.IO.Ports;
using UnityEngine;

public class Reciever : MonoBehaviour
{
    //computer 마다 포트 넘버가 다르기 때문에 업데이트 필요
    SerialPort serialPort = new SerialPort("COM4", 9600); // COM 포트와 바우드레이트 설정

    public string message;
    public float num;

    void Start()
    {
        serialPort.Open(); // 시리얼 포트 열기
    }

void Update()
    {

        if (serialPort.IsOpen)
        {
            try
            {
                message = serialPort.ReadLine(); // 데이터 읽기 
                //Debug.Log(message); // 콘솔 창에 데이터 출력
                num = float.Parse(message);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

    void OnApplicationQuit()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close(); // 시리얼 포트 닫기
        }
    }
}
