using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] Animator _animator;

    public void Walk(float speed) {
        _animator.SetFloat("Speed", Mathf.Abs(speed));
    }

    public void Jump() {
        _animator.SetBool("Grounded", false);
    }

    public void Ground() {
        _animator.SetBool("Grounded", true);
    }
}
