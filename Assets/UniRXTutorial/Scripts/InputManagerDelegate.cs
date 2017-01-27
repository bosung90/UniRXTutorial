using UnityEngine;

public class InputManagerDelegate : MonoBehaviour {

    // Singleton
    public static InputManagerDelegate Instance;

    public delegate void LaserFire(int num);
    public event LaserFire laserFire;

    private int numClicks = 0;

    void Awake() {
        Instance = this;
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            if(laserFire != null) {
                laserFire(++numClicks);
            }
        }
    }

    int GetNumClicks() {
        return numClicks;
    }
}
