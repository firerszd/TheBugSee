using System.Collections;
using System.Collections.Generic;
using SeeBug;
using UnityEngine;

[CCEditorBtn("测试用")]
public class SeeBugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [CCButton("我测试",1,0,"两个参数", "火烈鸟", 1)]
    public void Test(string test, float value)
    {
        Debug.Log("日志: " + test + " - " + value);
    }

    [CCFloat("测试数字", 1,new float[]{1f,11f,1f,100f})]
    public void FloatTest(float value, float value2)
    {
        Debug.Log("FloatTest: " + value + " - " + value2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
