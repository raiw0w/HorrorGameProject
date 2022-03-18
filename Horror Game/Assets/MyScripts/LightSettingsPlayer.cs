using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightSettingsPlayer : MonoBehaviour
{
    [SerializeField] PostProcessVolume MyVolume;
    [SerializeField] PostProcessProfile Standart;
    [SerializeField] PostProcessProfile NightVision;
    [SerializeField] GameObject NightVisionOverlay;


    private bool NightVisionActive = false;


    void Start()
    {
        NightVisionOverlay.gameObject.SetActive(false); //NightVisionOverlay İmagesini oyun baslarken false yaptık.7
     
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (NightVisionActive== false) // N bastığında NightVisionActive False ise
            {
               MyVolume.profile = NightVision; //inspectordeki postproses profili Night visiona eşitliyoruz
                NightVisionActive = true; // NightVisionActive true donuyor 
                NightVisionOverlay.gameObject.SetActive(true); //İmage de true oluyor ekranda gözüküyor 
            }
            else
            {
                MyVolume.profile = Standart; //Tekrar N bastığıımızada Profil standart oluyor.
                NightVisionActive = false; 
                NightVisionOverlay.gameObject.SetActive(false);
            }

        }
    }
}
