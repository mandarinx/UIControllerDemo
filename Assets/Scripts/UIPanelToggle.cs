using UnityEngine;

public class UIPanelToggle : StateMachineBehaviour {
	
	[SerializeField]
	private UIPanelLink panelLink;
	
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		panelLink.OpenPanel();
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) {
		panelLink.ClosePanel();
	}
}
