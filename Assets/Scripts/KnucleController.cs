using System.Collections;
using UnityEngine;

public class KnucleController : MonoBehaviour
{
    public float minTime = 5f; // Minimum s�re
    public float maxTime = 20f; // Maksimum s�re
    private float activatingTime;
    
    private Animator animator;
    public AnimationClip punchAnimationClip;

    void Start()
    {
        animator = GetComponent<Animator>();
  
        StartCoroutine(PlayPunchAnimation());
    }
    IEnumerator PlayPunchAnimation()
    {
        while (true)
        {
            activatingTime = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(activatingTime);
            animator.SetTrigger("Punch");
        }
    }

    private void Update()
    {
        activatingTime = Random.Range(minTime, maxTime);
    }
    
}
