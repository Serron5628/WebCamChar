using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorvol2 : MonoBehaviour
{
    public Color[] All1;
    public Color[] All2;

    public Color mouse;

    GameObject foot;

    Texture2D texture2D = null;
    Texture2D texture2DA = null;
    Texture2D texture2DB = null;

    private int width = 640;
    private int height = 360;

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
    [SerializeField] GameObject target1;
    [SerializeField] GameObject target2;

    // Start is called before the first frame update
    void Start()
    {
        foot = GameObject.Find("footPos");

        second = 0;
        targetTime = 8.0f;
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

        if(second > targetTime)
        {
            target1.SetActive(false);
            target2.SetActive(false);

            whiteFlag1 = false;
            whiteFlag2 = false;
            texture2DB = new Texture2D(width, height, TextureFormat.RGB24, false);
            texture2DB.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            texture2DB.Apply();
            Debug.Log("2");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (texture2DA.GetPixel(j, height - i).r > 0.9 && texture2DA.GetPixel(j, height - i).g > 0.9 && texture2DA.GetPixel(j, height - i).b > 0.9)
                    {
                        whiteFlag1 = true;
                        //Debug.Log(j + ":" + (height - i) + ":" + "1");
                    }
                    if (texture2DB.GetPixel(j, height - i).r > 0.9 && texture2DB.GetPixel(j, height - i).g > 0.9 && texture2DB.GetPixel(j, height - i).b > 0.9)
                    {
                        whiteFlag2 = true;
                        //Debug.Log(j + ":" + (height - i) + ":" + "2");
                    }

                    if (whiteFlag1 ^ whiteFlag2)
                    {
                        Vector3 pos = new Vector3((float)(-j / 10), 1.0f, (float)(i / 10));
                        foot.transform.position = pos;
                        targetTime += 1.0f;
                        break;
                    }
                    whiteFlag1 = false;
                    whiteFlag2 = false;
                }

                if (whiteFlag1 ^ whiteFlag2)
                {
                    target1.SetActive(true);
                    target2.SetActive(true);
                    break;
                }
            }
        }

        /*if (!playFlag1 && !playFlag2 && !finish)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (texture2DA.GetPixel(j, height - i).r > 0.9 && texture2DA.GetPixel(j, height - i).g > 0.9 && texture2DA.GetPixel(j, height - i).b > 0.9)
                    {
                        whiteFlag1 = true;
                    }
                    if (texture2DB.GetPixel(j, height - i).r > 0.9 && texture2DB.GetPixel(j, height - i).g > 0.9 && texture2DB.GetPixel(j, height - i).b > 0.9)
                    {
                        whiteFlag2 = true;
                    }


                    if (whiteFlag1 ^ whiteFlag2)
                    {
                        Vector3 pos = new Vector3((float)(-j / 10), 1.0f, (float)(i / 10));
                        foot.transform.position = pos;
                        targetTime += 2.0f;
                        break;
                    }
                    whiteFlag1 = false;
                    whiteFlag2 = false;
                }
                if (whiteFlag1 ^ whiteFlag2)
                {
                    break;
                }
            }
        }*/


        /*for(int i = 0; i < numberX.Count; i ++)
        {
            Debug.Log(numberX[i] + ":" + numberY[i]);
            Vector3 pos = new Vector3(numberX[i], 1, numberY[i]);
            Instantiate(cube, pos, Quaternion.identity);
        }*/

        /*if (finish)
        {
            Debug.Log(numberX[numberX.Count - 1] + ":" + numberY[numberY.Count - 1]);
            Vector3 pos = new Vector3(numberX[numberX.Count - 1], 1, numberY[numberY.Count - 1]);
            Instantiate(cube, pos, Quaternion.identity);
            Destroy(this);
        }*/



        /*Vector3 mousePos = Input.mousePosition;
        mouse = texture2DA.GetPixel((int)mousePos.x, (int)mousePos.y);
        Debug.Log((int)mousePos.x + ":" + (int)mousePos.y + ":" + mouse);*/
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