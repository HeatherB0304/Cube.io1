using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInput : MonoBehaviour
{
    [SerializeField] 
    private ShipCamera shipCam;
    private ShipMovement shipMove;
    
    // Start is called before the first frame update
    void Start()
    {
        if (shipCam == null) shipCam = this.gameObject.GetComponent<ShipCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) shipCam.ZoomOut();
        if(Input.GetKeyUp(KeyCode.Mouse1)) shipCam.DefaultZoom();
    }
}