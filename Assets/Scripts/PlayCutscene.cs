using UnityEngine;
using UnityEngine.Playables;

public class PlayCutscene : MonoBehaviour
{
    [SerializeField] private PlayableDirector cutsceneDirector;

    private void OnTriggerEnter()
    {
        // Play the cutscene
        cutsceneDirector.Play();
    }
}
