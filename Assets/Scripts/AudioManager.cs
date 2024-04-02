using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;

    void Start(){
        //audioMixer.SetFloat("VolumeMusique", -30f);
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertirVersLog(volume));
    }

    public void AjusteVolumeSFX(float volume){
        audioMixer.SetFloat("VolumeSFX", ConvertirVersLog(volume));
    }

    private float ConvertirVersLog(float volume){
        return Mathf.Log10(volume) * 30;
    }

}
