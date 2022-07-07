using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private int _hp = 100;
    private int _stamina = 100;
    private TMP_Text hpText;
    private GameObject hpBar; 
    private TMP_Text gold;

    void Start()
    {
        
    }


    void Update()
    {
        if(_hp <= 0){
            Death();
        }
        else if(_stamina <= 0){
            Sleeping();
        }

        
    }

    public static void Death(){
        
    }

    public static void Sleeping(){
        
    }
}
