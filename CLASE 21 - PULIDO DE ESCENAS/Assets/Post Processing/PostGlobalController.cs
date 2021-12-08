using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostGlobalController : MonoBehaviour
{
    private PostProcessVolume globalVolume;

    // Start is called before the first frame update
    private void Awake()
    {
        globalVolume = GetComponent<PostProcessVolume>();
        PlayerCharacterController.onFireChange += statusColorEffect;
    }

    void Start()
    {
        statusColorEffect(false);
    }

    public void statusColorEffect(bool status)
    {
        ColorGrading colorFX;
        globalVolume.profile.TryGetSettings(out colorFX);
        colorFX.active = status;
    }

}
