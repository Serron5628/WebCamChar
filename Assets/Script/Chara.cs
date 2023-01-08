using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Chara : MonoBehaviour
{
    public int a = -1;
    public int b = -1;

    private string[,] chara = Nihongo();
    public string all = "";
    // Start is called before the first frame update

    public bool charaInputFlag1;
    public bool charaInputFlag2;

    string path;

    //SetActive用
    [SerializeField] GameObject AN;
    [SerializeField] GameObject HW;
    [SerializeField] GameObject AOL;
    [SerializeField] GameObject AOR;
    [SerializeField] GameObject sub;

    [SerializeField] GameObject an;
    [SerializeField] GameObject hw;
    [SerializeField] GameObject aol;
    [SerializeField] GameObject aor;
    [SerializeField] GameObject yyy;
    [SerializeField] GameObject www;

    //以下テキスト
    [SerializeField] GameObject h;
    [SerializeField] GameObject m;
    [SerializeField] GameObject y;
    [SerializeField] GameObject r;
    [SerializeField] GameObject w;

    [SerializeField] GameObject aa;
    [SerializeField] GameObject i;
    [SerializeField] GameObject u;
    [SerializeField] GameObject e;
    [SerializeField] GameObject o;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject target6;
    public GameObject target7;
    public GameObject target8;
    public GameObject target9;
    public GameObject target10;

    public GameObject target21;
    public GameObject target22;
    public GameObject target23;

    public GameObject kettei1;

    private float timeCount = 0.0f;
    private float[] time = new float[10];
    private int count = 0;

    [SerializeField] GameObject playText;
    private string randText;

    private void Start()
    {
        path = Application.persistentDataPath + "/test.txt";

        a = -1;
        b = -1;
        charaInputFlag1 = false;
        charaInputFlag2 = false;
        AN.SetActive(true);
        HW.SetActive(true);
        AOL.SetActive(true);
        AOR.SetActive(true);
        sub.SetActive(false);
        an.SetActive(true);
        hw.SetActive(true);
        aol.SetActive(true);
        aor.SetActive(true);
        yyy.SetActive(false);
        www.SetActive(false);

        h.GetComponent<Text>().text = "は";
        m.GetComponent<Text>().text = "ま";
        y.GetComponent<Text>().text = "や";
        r.GetComponent<Text>().text = "ら";
        w.GetComponent<Text>().text = "わ";
        aa.GetComponent<Text>().text = "あ";
        i.GetComponent<Text>().text = "い";
        u.GetComponent<Text>().text = "う";
        e.GetComponent<Text>().text = "え";
        o.GetComponent<Text>().text = "お";
    }

    private void FixedUpdate()
    {
        timeCount += Time.deltaTime;
        Debug.Log(timeCount);

        if (!(a == -1) && !(b == -1) && charaInputFlag1 && charaInputFlag2)
        {
            all += chara[a, b];
            Debug.Log(all);
            Start();
            time[count] = timeCount;
            File.AppendAllText(path, time[count].ToString() + "\n");
            count++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target1)
        {
            a = 0;
            charaInputFlag1 = false;
            aa.GetComponent<Text>().text = "あ";
            i.GetComponent<Text>().text = "い";
            u.GetComponent<Text>().text = "う";
            e.GetComponent<Text>().text = "え";
            o.GetComponent<Text>().text = "お";
            AN.SetActive(true);
            HW.SetActive(false);
            AOL.SetActive(false);
            AOR.SetActive(true);
            sub.SetActive(false);
            an.SetActive(true);
            hw.SetActive(false);
            aol.SetActive(false);
            aor.SetActive(true);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target2)
        {
            a = 1;
            charaInputFlag1 = false;
            aa.GetComponent<Text>().text = "か";
            i.GetComponent<Text>().text = "き";
            u.GetComponent<Text>().text = "く";
            e.GetComponent<Text>().text = "け";
            o.GetComponent<Text>().text = "こ";
            AN.SetActive(true);
            HW.SetActive(false);
            AOL.SetActive(false);
            AOR.SetActive(true);
            sub.SetActive(false);
            an.SetActive(true);
            hw.SetActive(false);
            aol.SetActive(false);
            aor.SetActive(true);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target3)
        {
            a = 2;
            charaInputFlag1 = false;
            aa.GetComponent<Text>().text = "さ";
            i.GetComponent<Text>().text = "し";
            u.GetComponent<Text>().text = "す";
            e.GetComponent<Text>().text = "せ";
            o.GetComponent<Text>().text = "そ";
            AN.SetActive(true);
            HW.SetActive(false);
            AOL.SetActive(false);
            AOR.SetActive(true);
            sub.SetActive(false);
            an.SetActive(true);
            hw.SetActive(false);
            aol.SetActive(false);
            aor.SetActive(true);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target4)
        {
            a = 3;
            charaInputFlag1 = false;
            aa.GetComponent<Text>().text = "た";
            i.GetComponent<Text>().text = "ち";
            u.GetComponent<Text>().text = "つ";
            e.GetComponent<Text>().text = "て";
            o.GetComponent<Text>().text = "と";
            AN.SetActive(true);
            HW.SetActive(false);
            AOL.SetActive(false);
            AOR.SetActive(true);
            sub.SetActive(false);
            an.SetActive(true);
            hw.SetActive(false);
            aol.SetActive(false);
            aor.SetActive(true);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target5)
        {
            a = 4;
            charaInputFlag1 = false;
            aa.GetComponent<Text>().text = "な";
            i.GetComponent<Text>().text = "に";
            u.GetComponent<Text>().text = "ぬ";
            e.GetComponent<Text>().text = "ね";
            o.GetComponent<Text>().text = "の";
            AN.SetActive(true);
            HW.SetActive(false);
            AOL.SetActive(false);
            AOR.SetActive(true);
            sub.SetActive(false);
            an.SetActive(true);
            hw.SetActive(false);
            aol.SetActive(false);
            aor.SetActive(true);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target6)
        {
            b = 0;
            charaInputFlag1 = false;
            h.GetComponent<Text>().text = "は";
            m.GetComponent<Text>().text = "ま";
            y.GetComponent<Text>().text = "や";
            r.GetComponent<Text>().text = "ら";
            w.GetComponent<Text>().text = "わ";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(true);
            AOR.SetActive(false);
            sub.SetActive(false);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(true);
            aor.SetActive(false);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target7)
        {
            b = 1;
            charaInputFlag1 = false;
            h.GetComponent<Text>().text = "ひ";
            m.GetComponent<Text>().text = "み";
            y.GetComponent<Text>().text = "　";
            r.GetComponent<Text>().text = "り";
            w.GetComponent<Text>().text = "　";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(true);
            AOR.SetActive(false);
            sub.SetActive(false);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(true);
            aor.SetActive(false);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target8)
        {
            b = 2;
            charaInputFlag1 = false;
            h.GetComponent<Text>().text = "ふ";
            m.GetComponent<Text>().text = "む";
            y.GetComponent<Text>().text = "ゆ";
            r.GetComponent<Text>().text = "る";
            w.GetComponent<Text>().text = "　";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(true);
            AOR.SetActive(false);
            sub.SetActive(false);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(true);
            aor.SetActive(false);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target9)
        {
            b = 3;
            charaInputFlag1 = false;
            h.GetComponent<Text>().text = "へ";
            m.GetComponent<Text>().text = "め";
            y.GetComponent<Text>().text = "　";
            r.GetComponent<Text>().text = "れ";
            w.GetComponent<Text>().text = "　";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(true);
            AOR.SetActive(false);
            sub.SetActive(false);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(true);
            aor.SetActive(false);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target10)
        {
            b = 4;
            charaInputFlag1 = false;
            h.GetComponent<Text>().text = "ほ";
            m.GetComponent<Text>().text = "も";
            y.GetComponent<Text>().text = "よ";
            r.GetComponent<Text>().text = "ろ";
            w.GetComponent<Text>().text = "を";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(true);
            AOR.SetActive(false);
            sub.SetActive(false);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(true);
            aor.SetActive(false);
            yyy.SetActive(false);
            www.SetActive(false);
        }
        else if (other.gameObject == target21)
        {
            b = 0;
            charaInputFlag1 = false;
        }
        else if (other.gameObject == target22)
        {
            b = 1;
            charaInputFlag1 = false;
        }
        else if (other.gameObject == target23)
        {
            b = 2;
            charaInputFlag1 = false;
        }

        if(other.gameObject == kettei1)
        {
            charaInputFlag1 = true;
        }
    }

    static string[,] Nihongo()
    {
        string[,] nihongo = new string[10, 15];

        nihongo[0, 0] = "あ";
        nihongo[0, 1] = "い";
        nihongo[0, 2] = "う";
        nihongo[0, 3] = "え";
        nihongo[0, 4] = "お";

        nihongo[1, 0] = "か";
        nihongo[1, 1] = "き";
        nihongo[1, 2] = "く";
        nihongo[1, 3] = "け";
        nihongo[1, 4] = "こ";
        nihongo[1, 5] = "が";
        nihongo[1, 6] = "ぎ";
        nihongo[1, 7] = "ぐ";
        nihongo[1, 8] = "げ";
        nihongo[1, 9] = "ご";

        nihongo[2, 0] = "さ";
        nihongo[2, 1] = "し";
        nihongo[2, 2] = "す";
        nihongo[2, 3] = "せ";
        nihongo[2, 4] = "そ";
        nihongo[2, 5] = "ざ";
        nihongo[2, 6] = "じ";
        nihongo[2, 7] = "ず";
        nihongo[2, 8] = "ぜ";
        nihongo[2, 9] = "ぞ";

        nihongo[3, 0] = "た";
        nihongo[3, 1] = "ち";
        nihongo[3, 2] = "つ";
        nihongo[3, 3] = "て";
        nihongo[3, 4] = "と";
        nihongo[3, 5] = "だ";
        nihongo[3, 6] = "ぢ";
        nihongo[3, 7] = "づ";
        nihongo[3, 8] = "で";
        nihongo[3, 9] = "ど";

        nihongo[4, 0] = "な";
        nihongo[4, 1] = "に";
        nihongo[4, 2] = "ぬ";
        nihongo[4, 3] = "ね";
        nihongo[4, 4] = "の";

        nihongo[5, 0] = "は";
        nihongo[5, 1] = "ひ";
        nihongo[5, 2] = "ふ";
        nihongo[5, 3] = "へ";
        nihongo[5, 4] = "ほ";
        nihongo[5, 5] = "ば";
        nihongo[5, 6] = "び";
        nihongo[5, 7] = "ぶ";
        nihongo[5, 8] = "べ";
        nihongo[5, 9] = "ぼ";
        nihongo[5, 10] = "ぱ";
        nihongo[5, 11] = "ぴ";
        nihongo[5, 12] = "ぷ";
        nihongo[5, 13] = "ぺ";
        nihongo[5, 14] = "ぽ";

        nihongo[6, 0] = "ま";
        nihongo[6, 1] = "み";
        nihongo[6, 2] = "む";
        nihongo[6, 3] = "め";
        nihongo[6, 4] = "も";

        nihongo[7, 0] = "や";
        nihongo[7, 1] = "ゆ";
        nihongo[7, 2] = "よ";

        nihongo[8, 0] = "ら";
        nihongo[8, 1] = "り";
        nihongo[8, 2] = "る";
        nihongo[8, 3] = "れ";
        nihongo[8, 4] = "ろ";

        nihongo[9, 0] = "わ";
        nihongo[9, 1] = "を";
        nihongo[9, 2] = "ん";

        return nihongo;
    }

}