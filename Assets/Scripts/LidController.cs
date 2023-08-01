using UnityEngine;

public class LidController : MonoBehaviour
{
    public HingeJoint hingeJoint;
    public AudioSource openingSound;

    private bool moving;
    private float previousVelocity;
    private float timer;

    private void Start()
    {
        moving = false;
        previousVelocity = hingeJoint.velocity;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        float currentVelocity = hingeJoint.velocity;

        // If the lid's velocity is not zero, it means the lid is moving
        if (currentVelocity != 0f)
        {
            // If the lid was not moving before, start the audio and set the timer to 0
            if (!moving)
            {
                PlayOpeningSound();
                moving = true;
                timer = 0f;
            }
        }
        else if (moving && timer >= 0.5f)
        {
            // If the lid was moving and the timer has exceeded 0.5 seconds, stop the audio
            StopOpeningSound();
            moving = false;
        }

        previousVelocity = currentVelocity;
    }

    public void PlayOpeningSound()
    {
        openingSound.Play();
    }

    public void StopOpeningSound()
    {
        openingSound.Stop();
    }
}







