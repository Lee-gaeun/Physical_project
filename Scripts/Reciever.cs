using System.Diagnostics;
using System.IO.Ports;
using UnityEngine;

public class Reciever : MonoBehaviour
{
    //computer ���� ��Ʈ �ѹ��� �ٸ��� ������ ������Ʈ �ʿ�
    SerialPort serialPort = new SerialPort("COM4", 9600); // COM ��Ʈ�� �ٿ�巹��Ʈ ����

    public string message;
    public float num;

    void Start()
    {
        serialPort.Open(); // �ø��� ��Ʈ ����
    }

void Update()
    {

        if (serialPort.IsOpen)
        {
            try
            {
                message = serialPort.ReadLine(); // ������ �б� 
                //Debug.Log(message); // �ܼ� â�� ������ ���
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
            serialPort.Close(); // �ø��� ��Ʈ �ݱ�
        }
    }
}
