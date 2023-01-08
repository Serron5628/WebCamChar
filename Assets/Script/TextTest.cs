using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 書き込み
        string path = Application.persistentDataPath + "/test.txt";
        //File.WriteAllText(path, "hoge");

        // 追記
        File.AppendAllText(path, "fuga");
        File.AppendAllText(path, "\n");
        Debug.Log("Save at " + path);

        // 読み込み
        string data = File.ReadAllText(path);
        Debug.Log("Data is " + data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
