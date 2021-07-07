using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FountainController : MonoBehaviour
{
    public List<VisualEffect> effects  = new List<VisualEffect>();
    int effectIndex = 0;

    public List<FountainWaterController> waterAnim = new List<FountainWaterController>(); 
    
    void StartFountain() {
        
    }

    private void Awake() {
        DisableAll();
        StartSpray();
    }

    void DisableAll() {
        foreach(VisualEffect fx in effects) {
            fx.Stop();
        }
    }

    void StartNextEffect() {
        effectIndex++;
        effects[effectIndex].Play();
        waterAnim[effectIndex].AnimateWater();
    }

    void StartSpray() {
        effects[0].Play();
        waterAnim[0].AnimateWater(StartNextEffect);
    }

    

    
}
