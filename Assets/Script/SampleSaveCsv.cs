using System.IO;
using System.Text;
using UnityEngine;

// csvに保存するためのコード
// SaveCsvへアタッチ
public class SampleSaveCsv : MonoBehaviour
{
    // System.IO
    private StreamWriter sw;

    // Start is called before the first frame update
    void Start()
    {

        // 新しくcsvファイルを作成して、{}の中の要素分csvに追記をする
        sw = new StreamWriter(@"Assets/Date/SaveData.csv", false, Encoding.GetEncoding("Shift_JIS"));

        // CSV1行目のカラムで、StreamWriter オブジェクトへ書き込む
        string[] s1 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        /**
         * s1の文字列配列のすべての要素を「,」で連結する
         * @see https://docs.microsoft.com/ja-jp/dotnet/api/system.string.join?view=net-6.0#System_String_Join_System_String_System_String___
         */
        string s2 = string.Join(",", s1);

        /**
         * s2文字列をcsvファイルへ書き込む
         * @see https://docs.microsoft.com/ja-jp/dotnet/api/system.io.streamwriter.writeline?view=net-6.0#System_IO_StreamWriter_WriteLine_System_String_
         */
        sw.WriteLine(s2);
    }

    // Update is called once per frame
    void Update()
    {
        // Enterキーが押されたらcsvへの書き込みを終了する
        if (Input.GetKeyDown(KeyCode.Return))
        {
            /**
             * @see https://docs.microsoft.com/ja-jp/dotnet/api/system.io.streamwriter.close?view=net-6.0#System_IO_StreamWriter_Close
             */
            sw.Close();
        }
    }

    public void SaveData(string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string txt8, string txt9, string txt10)
    {
        string[] s1 = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10};
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }
}