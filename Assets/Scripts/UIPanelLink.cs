using UnityEngine;

[CreateAssetMenu(menuName = "UI/Panel Link")]
public class UIPanelLink : ScriptableObject {

    private UIPanel panel;

    public void SetPanel(UIPanel uiPanel) {
        panel = uiPanel;
    }
    
    public void OpenPanel() {
        panel.Open();
    }
    
    public void ClosePanel() {
        panel.Close();
    }
}
