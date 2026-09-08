using UnityEngine;

public class HandModeLocker : MonoBehaviour
{
    public GameObject dominantHandInteractor;
    public GameObject nonDominantPenTip;

    public void LockToNonDominantHand(bool isLeftNonDominant, Transform leftController, Transform rightController)
    {
        Transform nonDominant = isLeftNonDominant ? leftController : rightController;
        Transform dominant = isLeftNonDominant ? rightController : leftController;

        nonDominantPenTip.transform.SetParent(nonDominant, false);
        dominantHandInteractor.SetActive(false); // disable dominant hand input during tracing
    }
}