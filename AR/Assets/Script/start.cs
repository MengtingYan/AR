using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;/*�л�����������ӵ�ǰ׺*/

public class start: MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void ChangeScene()/*����һ���л�����*/
    {
        SceneManager.LoadScene("Scan");/*˫�������������㴴���ĳ�������*/
    }

}