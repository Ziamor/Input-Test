using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class PlayerController : MonoBehaviour
{
    public InputMaster inputMaster;

    // Start is called before the first frame update
    void Awake()
    {
        inputMaster.Player.Shoot.performed += _ => Shoot();
        inputMaster.Player.Look.performed += ctx => Look(ctx.ReadValue<float>());
        inputMaster.Enable();
    }

    void Shoot() {
        Debug.Log("Shoot");
    }

    void Look(float dir) {
        Debug.Log("Look " + dir);
    }

    private void OnEnable() {
        inputMaster.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
