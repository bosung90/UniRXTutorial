using UnityEngine;
using UniRx;

public class Tutorial1 : MonoBehaviour {

	void Start () {
        ReactiveProperty<int> B = new ReactiveProperty<int>(0);
        ReactiveProperty<int> C = new ReactiveProperty<int>(0);
        ReadOnlyReactiveProperty<int> A;

        // A = B + C
        A = Observable.CombineLatest(B, C, (b, c) => b + c).ToReadOnlyReactiveProperty();

        // Prints 0
        Debug.Log(A.Value);

        B.Value = 5;
        C.Value = 7;

        // Pritns 12
        Debug.Log(A.Value);
    }
}
