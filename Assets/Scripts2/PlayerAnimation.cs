using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    int horizontal, vertical;

    private void Awake()
    {
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    private void Update()
    {
        Debug.Log("Horz: " + horizontal);
        Debug.Log("Vert: " + vertical);    
    }

    public void UpdateAnimatorValues(float horizontalMove, float verticalMove)
    {
        //damp time = blend time || 0.1f
        PlayerManager.Instance.playerAnim.SetFloat(horizontal,horizontalMove, 0.1f, Time.deltaTime);
        PlayerManager.Instance.playerAnim.SetFloat(vertical, verticalMove, 0.1f, Time.deltaTime);
    }
}
