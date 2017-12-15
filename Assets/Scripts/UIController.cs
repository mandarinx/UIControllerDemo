using UnityEngine;

public class UIController : MonoBehaviour {

    private Animator fsm;

    private void Start() {
        for (int i = 0; i < transform.childCount; ++i) {
            UIPanel panel = transform.GetChild(i).GetComponent<UIPanel>();
            panel.Init(this);
            panel.Close();
        }

        fsm = GetComponent<Animator>();
        NextState();
    }

    public void NextState() {
        fsm.SetTrigger("Next");
    }
}
