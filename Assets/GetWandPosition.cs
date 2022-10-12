using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetWandPosition : MonoBehaviour
{
    private Vector3 TipPos;
    public TMP_Text posText;

    // Start is called before the first frame update
    void Start()
    {
        TipPos.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        TipPos = GameObject.Find("/Image Marker Dog/Cylinder").transform.position;
        posText.text = TipPos.ToString("F4");
    }
}
