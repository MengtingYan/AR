using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;/*�л�����������ӵ�ǰ׺*/

public class start1: MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void ReturnScene()/*����һ���л�����*/
    {
        SceneManager.LoadScene("Start");/*˫�������������㴴���ĳ�������*/
    }

}