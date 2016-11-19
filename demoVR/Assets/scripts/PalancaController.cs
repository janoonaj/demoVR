using UnityEngine;
using UnityEngine.UI;

public class PalancaController : MonoBehaviour {

    public Slider slider;
    public bool active = false;

    void Update() {
        if (active) {
            slider.normalizedValue += Time.deltaTime;
            if (slider.normalizedValue >= 1) {
                //GetComponent<Renderer>().material.color = Color.green;
                GetComponent<Animator>().Play("palanca01_rotation01");
            }
        }
    }

    public void onActivate() {
        active = true;
    }

    public void onDeactivate() {
        active = false;
        slider.normalizedValue = 0;
        //GetComponent<Renderer>().material.color = Color.red;
    }
}
