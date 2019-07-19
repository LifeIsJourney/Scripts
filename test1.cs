using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{   public enum SelectThis { Flash, InOutQuad,
        InBack,
        InBounce,
        InCirc,
        InCubic,
        InElastic,
        InExpo,
        InFlash,
        InOutBack,
        InOutBounce,
        InOutCirc,
        InOutCubic,
        InOutElastic,
        InOutExpo,
        InOutFlash,
        InOutQuart,
        InOutQuint,
        InOutSine,
        InQuad,
        InQuart,
        InQuint,
        InSine,
        INTERNAL_Custom,
        INTERNAL_Zero,
        Linear,
        OutBack,
        OutBounce,
        OutCirc,
        OutCubic,
        OutElastic,
        OutExpo,
        OutFlash,
        OutQuad,
        OutQuart,
        OutQuint,
        OutSine,
        Unset,
    }
    public SelectThis selectThis;
    
    public GameObject prefabObj;
    public float duration;
    public GameObject InstantiatedObj;
    int index;
    public TMPro.TextMeshProUGUI TmpText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (Input.GetMouseButtonDown(0))
        {
            switch (index)
            {
                case 0:
                  
                    TmpText.text = SelectThis.Flash.ToString();
                    GameObject obj = TestingEasing();
                    obj.transform.DOScale(Vector2.one, duration).SetEase(Ease.Flash);
                    break;
                case 1:

                    TmpText.text = SelectThis.InBack.ToString();
                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InBack);
                    break;
                case 2:
                    TmpText.text = SelectThis.InBounce.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InBounce);
                    break;
                case 3:
                    TmpText.text = SelectThis.InCirc.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InCirc);
                    break;
                case 4:
                    TmpText.text = SelectThis.InCubic.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InCubic);
                    break;
                case 5:
                    TmpText.text = SelectThis.InElastic.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InElastic);
                    break;
                case 6:
                    TmpText.text = SelectThis.InExpo.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InExpo);
                    break;
                case 7:
                    TmpText.text = SelectThis.InFlash.ToString();
                    
                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InFlash);
                    break;
                case 8:
                    TmpText.text = SelectThis.InOutBack.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutBack);
                    break;
                case 9:
                    TmpText.text = SelectThis.InOutBounce.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutBounce);
                    break;
                case 10:
                    TmpText.text = SelectThis.InOutCirc.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutCirc);
                    break;
                case 11:
                    TmpText.text = SelectThis.InOutCubic.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutCubic);
                    break;
                case 12:
                    TmpText.text = SelectThis.InOutElastic.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutElastic);
                    break;
                case 13:
                    TmpText.text = SelectThis.InOutExpo.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutExpo);
                    break;
                case 14:
                    TmpText.text = SelectThis.InOutFlash.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutFlash);
                    break;
                case 15:
                    TmpText.text = SelectThis.InOutQuad.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutQuad);
                    break;
                case 16:
                    TmpText.text = SelectThis.InOutQuart.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutQuart);
                    break;
                case 17:
                    TmpText.text = SelectThis.InOutQuint.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutQuint);
                    break;
                case 18:
                    TmpText.text = SelectThis.InOutSine.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InOutSine);
                    break;
                case 19:
                    TmpText.text = SelectThis.InQuad.ToString();
                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InQuad);
                    break;
                case 20:
                    TmpText.text = SelectThis.InQuart.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InQuart);
                    break;
                case 21:
                    TmpText.text = SelectThis.InQuint.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InQuint);
                    break;
                case 22:
                    TmpText.text = SelectThis.InSine.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.InSine);
                    break;
                case 23:
                    TmpText.text = SelectThis.INTERNAL_Custom.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.INTERNAL_Custom);
                    break;
                case 24:
                    TmpText.text = SelectThis.INTERNAL_Zero.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.INTERNAL_Zero);
                    break;
                case 25:
                    TmpText.text = SelectThis.Linear.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.Linear);
                    break;
                case 26:
                    TmpText.text = SelectThis.OutBack.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutBack);
                    break;
                case 27:
                    TmpText.text = SelectThis.OutBounce.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutBounce);
                    break;
                case 28:
                    TmpText.text = SelectThis.OutCirc.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutCirc);
                    break;
                case 29:
                    TmpText.text = SelectThis.OutCubic.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutCubic);
                    break;
                case 30:
                    TmpText.text = SelectThis.OutElastic.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutElastic);
                    break;
                case 31:
                    TmpText.text = SelectThis.OutExpo.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutExpo);
                    break;
                case 32:
                    TmpText.text = SelectThis.OutFlash.ToString();
                    
                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutFlash);
                    break;
                case 33:
                    TmpText.text = SelectThis.OutQuad.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutQuad);
                    break;
                case 34:
                    TmpText.text = SelectThis.OutQuart.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutQuart);
                    break;
                case 35:
                    TmpText.text = SelectThis.OutQuint.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutQuint);
                    break;
                case 36:
                    TmpText.text = SelectThis.OutSine.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.OutSine);
                    break;
                case 37:
                    TmpText.text = SelectThis.Unset.ToString();

                    TestingEasing().transform.DOScale(Vector2.one, duration).SetEase(Ease.Unset);
                    break;
                default:
                    break;
            }
            index++;
        }
    }
    GameObject TestingEasing()
   
    {
        GameObject obj = Instantiate(prefabObj, transform.position, Quaternion.identity) as GameObject;
     
        Destroy(obj, 2);
        InstantiatedObj = obj;
        return obj;
    }
}
