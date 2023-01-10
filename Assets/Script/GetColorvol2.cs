using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorvol2 : MonoBehaviour
{
    public Color[] All1;
    public Color[] All2;

    public Color mouse;

    GameObject foot;
    GameObject foot2;

    Texture2D texture2D = null;
    Texture2D texture2DA = null;
    Texture2D texture2DB = null;

    private int width = 1280;
    private int height = 720;

    private float second;
    private float targetTime;

    private bool playFlag1;
    private bool playFlag2;
    private bool finish;

    private bool whiteFlag1;
    private bool whiteFlag2;

    List<float> numberX = new List<float>();
    List<float> numberY = new List<float>();

    [SerializeField] GameObject cube;
    [SerializeField] GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        foot = GameObject.Find("footPos");
        foot2 = GameObject.Find("footPos2");

        second = 0;
        targetTime = 3.0f;
        playFlag1 = true;
        playFlag2 = true;
        finish = false;
        whiteFlag1 = false;
        whiteFlag2 = false;
    }

    //レンダー後の処理
    private void OnPostRender()
    {
        second += Time.deltaTime;

        if(second > targetTime)
        {
            UI.SetActive(false);

            whiteFlag1 = false;
            whiteFlag2 = false;
            texture2DB = new Texture2D(width, height, TextureFormat.RGB24, false);
            texture2DB.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            texture2DB.Apply();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width/2; j++)
                {
                    if (texture2DB.GetPixel(j, height - i).r > 0.95 && texture2DB.GetPixel(j, height - i).g > 0.95 && texture2DB.GetPixel(j, height - i).b > 0.95)
                    {
                        whiteFlag1 = true;
                        Vector3 pos = new Vector3((float)(-j / 20) - 2.0f, 1.0f, (float)(i / 20));
                        foot.transform.position = pos;
                        break;
                    }
                }

                if (whiteFlag1)
                {
                    break;
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width / 2; j++)
                {
                    if (texture2DB.GetPixel(j + width / 2, height - i).r > 0.95 && texture2DB.GetPixel(j + width / 2, height - i).g > 0.95 && texture2DB.GetPixel(j + width / 2, height - i).b > 0.95)
                    {
                        whiteFlag2 = true;
                        Vector3 pos2 = new Vector3((float)(-(j + width / 2) / 20), 1.0f, (float)(i / 20));
                        foot2.transform.position = pos2;
                        break;
                    }
                }

                if (whiteFlag2)
                {
                    break;
                }
            }

            UI.SetActive(true);
            targetTime += 0.1f;
        }
    }

    private Color[] AllPixels()
    {
        texture2D = new Texture2D(width, height, TextureFormat.RGB24, false);
        texture2D.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        texture2D.Apply();
        var pixel = texture2D.GetPixels(0, 0, width, height);

        return pixel;
    }
}