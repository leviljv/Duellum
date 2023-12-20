using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private void Start() {
        EventManager<UIEvents, CursorType>.Invoke(UIEvents.UpdateCursor, CursorType.Normal);
        Tooltip.HideTooltip_Static();
    }
    private void OnEnable() {
        
    }

    private void OnDisable() {
        
    }
    private void Update() {
        if (UnitStaticManager.PlayerUnitsInPlay.Count < 1)
            StartCoroutine(ShowResults());
        if (UnitStaticManager.EnemyUnitsInPlay.Count < 1)
            StartCoroutine(ShowResults());
    }

    private IEnumerator ShowResults() {
        yield return new WaitForSeconds(3);
        EventManager<UIEvents, bool>.Invoke(UIEvents.PopUpWindow, true);
    }
}