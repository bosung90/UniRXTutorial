using UnityEngine;
using UniRx;

public class InputManagerObservable : MonoBehaviour {

    // Singleton
    public static InputManagerObservable Instance;

    private ReactiveProperty<int> fireLaser = new ReactiveProperty<int>();
    // Only expose ReadOnlyReactiveProperty or IOservable
    public ReadOnlyReactiveProperty<int> FireLaser {
        get {
            return fireLaser.ToReadOnlyReactiveProperty();
        }
    }

    void Awake() {
        Instance = this;

        Observable
            .EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Mouse0))
            .Subscribe(_ => fireLaser.Value += 1)
            .AddTo(this);
    }
}
