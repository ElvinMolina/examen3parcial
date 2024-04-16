using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Panel : MonoBehaviour
{

    public RectTransform panel;
    public GameObject btnPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void abrirPanel()
    {
        
        panel.DOAnchorPos(new Vector2(114.9329f, 40.6064f), 0.5f);

    }

    public void cerrarPanel()
    {

        panel.DOAnchorPos(new Vector2(881.0753f, 40.6064f), 0.5f);

    }
}
