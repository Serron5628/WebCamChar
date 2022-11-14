using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour
{
    public Color[] All1;
    public Color[] All2;

    public Color mouse;

    Texture2D texture2D = null;
    Texture2D texture2DA = null;
    Texture2D texture2DB = null;

    private int width = 640;
    private int height = 360;


    private float second;

    private bool playFlag1;
    private bool playFlag2;
    private bool finish;

    private bool whiteFlag1;
    private bool whiteFlag2;

    List<float> numberX = new List<float>();
    List<float> numberY = new List<float>();

    [SerializeField] GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        second = 0;
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
        if (second > 5.0f && playFlag1)
        {
            texture2DA = new Texture2D(width, height, TextureFormat.RGB24, false);
            texture2DA.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            texture2DA.Apply();
            All1 = texture2DA.GetPixels(0, 0, width, height);
            playFlag1 = false;
            Debug.Log("1");
        }

        if(second > 10.0f && playFlag2)
        {
            texture2DB = new Texture2D(width, height, TextureFormat.RGB24, false);
            texture2DB.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            texture2DB.Apply();
            All2 = texture2DB.GetPixels(0, 0, width, height);
            playFlag2 = false;
            Debug.Log("2");
        }

        if(!(playFlag1) && !(playFlag2) && !(finish) && second > 15.0f)
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if (texture2DA.GetPixel(j, i).r > 0.9 && texture2DA.GetPixel(j, i).g > 0.9 && texture2DA.GetPixel(j, i).b > 0.9)
                    {
                        whiteFlag1 = true;
                    }
                    if (texture2DB.GetPixel(j, i).r > 0.9 && texture2DB.GetPixel(j, i).g > 0.9 && texture2DB.GetPixel(j, i).b > 0.9)
                    {
                        whiteFlag2 = true;
                    }


                    if (whiteFlag1 ^ whiteFlag2)
                    {
                        if(numberX.Count == 0)
                        {
                            numberX.Add((float)(-(j / 10)));
                            numberY.Add((float)(36 - (i / 10)));
                        }
                        else if (!(numberX[numberX.Count-1] == (float)(-(j / 10)) && numberY[numberY.Count-1] == (float)(36 - (i / 10))))
                        {
                            numberX.Add((float)(-(j / 10)));
                            numberY.Add((float)(36 - (i / 10)));
                        }
                        finish = true;
                    }
                    whiteFlag1 = false;
                    whiteFlag2 = false;
                }
            }
        }


        for(int i = 0; i < numberX.Count; i ++)
        {
            Debug.Log(numberX[i] + ":" + numberY[i]);
            Vector3 pos = new Vector3(numberX[i], 1, numberY[i]);
            Instantiate(cube, pos, Quaternion.identity);
        }



        //Vector3 mousePos = Input.mousePosition;
        //mouse = texture2DA.GetPixel((int)mousePos.x, (int)mousePos.y);
        //Debug.Log(mouse);
        //(int)(mousePos.x)はy系の成分

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