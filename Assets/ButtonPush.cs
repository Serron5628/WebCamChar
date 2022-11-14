using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPush : MonoBehaviour
{
    private int a = -1;
    private int b = -1;

    private string[,] chara = Nihongo();
    private string all = "";
    // Start is called before the first frame update

    bool charaInputFlag = false;

    bool hitFlag1 = false;
    bool hitFlag2 = false;

    public GameObject chara_object = null;

    void Update()
    {
        Text chara_text = chara_object.GetComponent<Text>();

        if (hitFlag1)
        {
            //母音選択から子音選択に戻った際に文字の入力を確定する
            if (charaInputFlag)
            {
                all += chara[Mathf.Max(a, 0), Mathf.Max(b, 0)];
                a = -1;
                b = -1;
                Debug.Log(all);
                charaInputFlag = false;
            }

            //「あかさたな」の順番で子音を選択する
            a++;

            //「わ」の時に「あ」に戻す
            if(chara[Mathf.Max(a, 0), Mathf.Max(b, 0)] == null)
            {
                a = 0;
            }

            //文字入力の結果を表示
            Debug.Log(all + chara[Mathf.Max(a, 0), Mathf.Max(b, 0)]);
            chara_text.text = all + chara[Mathf.Max(a, 0), Mathf.Max(b, 0)];
        }

        if (hitFlag2)
        {
            //母音選択を始めたフラグ
            charaInputFlag = true;

            //「あいうえお」の順番で母音を選択
            b++;

            //「お」の次とか行って文字がなくなったときに先頭の「あ」に戻ってくる
            if(chara[Mathf.Max(a, 0), Mathf.Max(b, 0)] == null)
            {
                b = 0;
            }

            //文字を表示
            Debug.Log(all + chara[Mathf.Max(a, 0), Mathf.Max(b, 0)]);
            chara_text.text = all + chara[Mathf.Max(a, 0), Mathf.Max(b, 0)];
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