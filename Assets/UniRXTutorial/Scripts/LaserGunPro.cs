using UnityEngine;
using UniRx;

public class LaserGunPro : MonoBehaviour {

    public Renderer _renderer;

    void Start() {
        InputManagerObservable.Instance.FireLaser.Subscribe(numClicks => {
            Color col = new Color(Random.value, Random.value, Random.value);
            _renderer.material.color = col;
        }).AddTo(this);
    }
}
