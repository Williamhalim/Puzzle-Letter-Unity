using UnityEngine;

[System.Serializable]
public class AnimationStep
{
    public Animator animator;       // Animator of the component
    public string triggerName;      // Trigger parameter to fire (optional)
    public string clipName;         // Clip name to play directly (optional)
    public float delayAfter = 0f;   // Optional delay after this step
    public bool fadeInWithCanvasGroup = true; // If true, uses CanvasGroup to fade in
}