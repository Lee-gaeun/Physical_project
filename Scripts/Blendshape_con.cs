using UnityEngine;

public class Blendshape_con : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer; // SkinnedMeshRenderer�� ���� GameObject�� �����մϴ�.
    public GameObject Receiver; // �Լ��� ����� ���ӿ�����Ʈ ������ ����

    //string messageC;
    float numb;


    public float lerpSpeed = 1.0f; // ���� ���� �ӵ� ����Ƽ������ �ӵ��� ���������ϵ��� public���� �������ش�
    private float currentB = 0;

    void ChangeMeshRederer()
    {
        //messageC = Receiver.GetComponent<SerialReceiver>().message;
        numb = Receiver.GetComponent<Reciever>().num;


        if (currentB < 100 && currentB < numb)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(0, currentB);
            currentB += lerpSpeed;
        }
        else if (currentB > 0 && currentB > numb)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(0, currentB);
            currentB -= lerpSpeed;
        }
    }

    void Start()
    {

    }

    private void Update()
    {
        ChangeMeshRederer();
    }
}