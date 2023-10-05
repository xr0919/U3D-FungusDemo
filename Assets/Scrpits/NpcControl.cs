using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcControl : MonoBehaviour
{
    public string ChatName;
    //控制当前是否可以对话
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
    //按键也可以对话
    public void OnMouseDown()
    {
        Say();
    }
    public void Say()
    {
        if(canChat)
        {
            //对话
            Flowchart flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
            //检测对话是否存在
            if(flowchart.HasBlock(ChatName))
            {
                //执行对话
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
