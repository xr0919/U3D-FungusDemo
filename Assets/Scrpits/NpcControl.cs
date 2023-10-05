using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcControl : MonoBehaviour
{
    public string ChatName;
    //���Ƶ�ǰ�Ƿ���ԶԻ�
    private bool canChat = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Say();

        }
    }
    //����Ҳ���ԶԻ�
    public void OnMouseDown()
    {
        Say();
    }
    public void Say()
    {
        if(canChat)
        {
            //�Ի�
            Flowchart flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
            //���Ի��Ƿ����
            if(flowchart.HasBlock(ChatName))
            {
                //ִ�жԻ�
                flowchart.ExecuteBlock(ChatName);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        canChat = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canChat = false;
    }
}
