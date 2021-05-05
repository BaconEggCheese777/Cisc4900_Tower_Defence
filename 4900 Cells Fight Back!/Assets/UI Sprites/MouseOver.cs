using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject textObject1;
    public GameObject textObject2;
    public GameObject textObject3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {   
        switch (gameObject.name)
        {
            case "Buy Turrets Button":
                textObject1.SetActive(true);
                break;
            case "Sell Turrets Button":
                textObject2.SetActive(true);
                break;
            case "Add Turret Spots Button":
                textObject3.SetActive(true);
                break;
        }
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        textObject1.SetActive(false);
        textObject2.SetActive(false);
        textObject3.SetActive(false);
    }
}
