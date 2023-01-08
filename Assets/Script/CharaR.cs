using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaR : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject foot1;
    Chara charaScript;

    //アクティブ用
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

    //テキスト
    [SerializeField] GameObject aaa;
    [SerializeField] GameObject k;
    [SerializeField] GameObject s;
    [SerializeField] GameObject t;
    [SerializeField] GameObject n;

    [SerializeField] GameObject aa;
    [SerializeField] GameObject i;
    [SerializeField] GameObject u;
    [SerializeField] GameObject e;
    [SerializeField] GameObject o;

    [SerializeField] GameObject ya;
    [SerializeField] GameObject yu;
    [SerializeField] GameObject yo;

    [SerializeField] GameObject wa;
    [SerializeField] GameObject wo;
    [SerializeField] GameObject nn;

    public GameObject target11;
    public GameObject target12;
    public GameObject target13;
    public GameObject target14;
    public GameObject target15;
    public GameObject target16;
    public GameObject target17;
    public GameObject target18;
    public GameObject target19;
    public GameObject target20;

    public GameObject kettei2;
    void Update()
    {
        if(charaScript.charaInputFlag1 && charaScript.charaInputFlag2)
        {
            Start();
        }
    }

    private void Start()
    {
        aaa.GetComponent<Text>().text = "あ";
        k.GetComponent<Text>().text = "か";
        s.GetComponent<Text>().text = "さ";
        t.GetComponent<Text>().text = "た";
        n.GetComponent<Text>().text = "な";
        aa.GetComponent<Text>().text = "あ";
        i.GetComponent<Text>().text = "い";
        u.GetComponent<Text>().text = "う";
        e.GetComponent<Text>().text = "え";
        o.GetComponent<Text>().text = "お";

        charaScript = foot1.GetComponent<Chara>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target11)
        {
            charaScript.a = 5;
            charaScript.charaInputFlag2 = false;
            aa.GetComponent<Text>().text = "は";
            i.GetComponent<Text>().text = "ひ";
            u.GetComponent<Text>().text = "ふ";
            e.GetComponent<Text>().text = "へ";
            o.GetComponent<Text>().text = "ほ";
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
        else if (other.gameObject == target12)
        {
            charaScript.a = 6;
            charaScript.charaInputFlag2 = false;
            aa.GetComponent<Text>().text = "ま";
            i.GetComponent<Text>().text = "み";
            u.GetComponent<Text>().text = "む";
            e.GetComponent<Text>().text = "め";
            o.GetComponent<Text>().text = "も";
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
        else if (other.gameObject == target13)
        {
            charaScript.a = 7;
            charaScript.charaInputFlag2 = false;
            ya.GetComponent<Text>().text = "や";
            yu.GetComponent<Text>().text = "ゆ";
            yo.GetComponent<Text>().text = "よ";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(false);
            AOR.SetActive(false);
            sub.SetActive(true);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(false);
            aor.SetActive(false);
            yyy.SetActive(true);
            www.SetActive(false);
        }
        else if (other.gameObject == target14)
        {
            charaScript.a = 8;
            charaScript.charaInputFlag2 = false;
            aa.GetComponent<Text>().text = "ら";
            i.GetComponent<Text>().text = "り";
            u.GetComponent<Text>().text = "る";
            e.GetComponent<Text>().text = "れ";
            o.GetComponent<Text>().text = "ろ";
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
        else if (other.gameObject == target15)
        {
            charaScript.a = 9;
            charaScript.charaInputFlag2 = false;
            ya.GetComponent<Text>().text = "わ";
            yu.GetComponent<Text>().text = "を";
            yo.GetComponent<Text>().text = "ん";
            AN.SetActive(false);
            HW.SetActive(true);
            AOL.SetActive(false);
            AOR.SetActive(false);
            sub.SetActive(true);
            an.SetActive(false);
            hw.SetActive(true);
            aol.SetActive(false);
            aor.SetActive(false);
            yyy.SetActive(false);
            www.SetActive(true);
        }
        else if (other.gameObject == target16)
        {
            charaScript.b = 0;
            charaScript.charaInputFlag2 = false;
            aaa.GetComponent<Text>().text = "あ";
            k.GetComponent<Text>().text = "か";
            s.GetComponent<Text>().text = "さ";
            t.GetComponent<Text>().text = "た";
            n.GetComponent<Text>().text = "な";
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
        else if (other.gameObject == target17)
        {
            charaScript.b = 1;
            charaScript.charaInputFlag2 = false;
            aaa.GetComponent<Text>().text = "い";
            k.GetComponent<Text>().text = "き";
            s.GetComponent<Text>().text = "し";
            t.GetComponent<Text>().text = "ち";
            n.GetComponent<Text>().text = "に";
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
        else if (other.gameObject == target18)
        {
            charaScript.b = 2;
            charaScript.charaInputFlag2 = false;
            aaa.GetComponent<Text>().text = "う";
            k.GetComponent<Text>().text = "く";
            s.GetComponent<Text>().text = "す";
            t.GetComponent<Text>().text = "つ";
            n.GetComponent<Text>().text = "ぬ";
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
        else if (other.gameObject == target19)
        {
            charaScript.b = 3;
            charaScript.charaInputFlag2 = false;
            aaa.GetComponent<Text>().text = "え";
            k.GetComponent<Text>().text = "け";
            s.GetComponent<Text>().text = "せ";
            t.GetComponent<Text>().text = "て";
            n.GetComponent<Text>().text = "ね";
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
        else if (other.gameObject == target20)
        {
            charaScript.b = 4;
            charaScript.charaInputFlag2 = false;
            aaa.GetComponent<Text>().text = "お";
            k.GetComponent<Text>().text = "こ";
            s.GetComponent<Text>().text = "そ";
            t.GetComponent<Text>().text = "と";
            n.GetComponent<Text>().text = "の";
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

        if(other.gameObject == kettei2)
        {
            charaScript.charaInputFlag2 = true;
        }
    }
}