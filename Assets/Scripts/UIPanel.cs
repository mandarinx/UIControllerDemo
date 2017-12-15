using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class UIPanel : MonoBehaviour {

    public UIPanelLink     panelLink;

    protected UIController ui;
    private Canvas         canvas;

    private void Awake() {
        canvas = GetComponent<Canvas>();
        panelLink.SetPanel(this);
    }

    public void Init(UIController uiController) {
        ui = uiController;
    }

    protected void Hide() {
        canvas.enabled = false;
    }

    protected void Show() {
        canvas.enabled = true;
    }

    public virtual void Open() {
        Show();
    }

    public virtual void Close() {
        Hide();
    }
}
