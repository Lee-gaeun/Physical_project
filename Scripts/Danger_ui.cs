using UnityEngine;
using System.IO.Ports;
using System.Collections;

public class Danger_ui : MonoBehaviour
{
    //SerialPort serialPort = new SerialPort("COM5", 9600); // COM ��Ʈ�� ���巹��Ʈ ����
    float num1;
    private float currentA = 0;

    public GameObject dangerImage; // ��� �̹����� ���� ����
    public GameObject SerialReceiver; // ��� �̹����� ���� ����
    IEnumerator dangerUp()
    {
        //messageC = Receiver.GetComponent<SerialReceiver>().message;
        num1 = SerialReceiver.GetComponent<Reciever>().num;

        if (num1 < 30)
        {
            dangerImage.SetActive(true); // �̹��� Ȱ��ȭ
            yield return new WaitForSeconds(5); // 5�� ���
            dangerImage.SetActive(false); // �̹��� ��Ȱ��ȭ
        }
    }
    void Start()
    {

    }

    void Update()
    {
        //();

    }
    /*
    IEnumerator ShowDangerImage()
    {
        dangerImage.SetActive(true); // �̹��� Ȱ��ȭ
        yield return new WaitForSeconds(5); // 5�� ���
        dangerImage.SetActive(false); // �̹��� ��Ȱ��ȭ
    }*/

}

