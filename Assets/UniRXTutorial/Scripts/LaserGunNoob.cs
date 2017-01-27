using UnityEngine;

public class LaserGunNoob : MonoBehaviour {

    public Renderer _renderer;

    void Start() {
        InputManagerDelegate.Instance.laserFire += TurnColor;
    }

    void OnDestroy() {
        InputManagerDelegate.Instance.laserFire -= TurnColor;
    }

    void TurnColor(int numClicks) {
        Color col = new Color(Random.value, Random.value, Random.value);
        _renderer.material.color = col;
    }
}
