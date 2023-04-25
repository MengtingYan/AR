using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;/*切换场景必须添加的前缀*/

public class start2: MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void AudioScene()/*定义一个切换场景*/
    {
        SceneManager.LoadScene("Audio");/*双引号里面填入你创建的场景命名*/
    }

}