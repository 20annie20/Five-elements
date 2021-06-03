using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    public Player player;
    public AnimatorOverrideController blueAnim;
    public AnimatorOverrideController greenAnim;
    public AnimatorOverrideController redAnim;

    public string[] staticDirections = {"static N", "static NW", "static W", "static SW", "static S", "static SE", "static E", "static NE"};
    public string[] runDirections = {"go N", "go NW", "go W", "go SW", "go S", "go SE", "go E", "go NE"};
    int lastDirection;

    private void Awake() 
    {
        anim = GetComponent<Animator>();
        Statistics stats = Object.FindObjectOfType<Statistics>();
        if (stats.GetSkin() == Statistics.Skin.Red)
        {
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = redAnim as RuntimeAnimatorController;
        }
        else if (stats.GetSkin() == Statistics.Skin.Green)
        {
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = greenAnim as RuntimeAnimatorController;
        }
        else if (stats.GetSkin() == Statistics.Skin.Blue)
        {
            player.GetComponentInChildren<Animator>().runtimeAnimatorController = greenAnim as RuntimeAnimatorController;
        }
        else
        {
            ;
        }      
    }

    public void SetDirection(Vector2 _direction) 
    {
        string[] directionArray = null;
        if(_direction.magnitude < 0.01)//MARKER Character is static, velocity almost zero
        {
            directionArray = staticDirections;
        }
        else 
        {
            directionArray = runDirections;
            lastDirection = DirectionToIndex(_direction);
        }
        anim.Play(directionArray[lastDirection]);
    }

    /*
    Direction   Angle   StepCount
    N           0       0
    NW          45      1
    W           90      2
    SW          135     3
    S           180     4
    SE          -135    5
    E           -90     6
    NE          -45     7
    */

    //converts a Vector2 direction to an index to an animation
    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;

        float step = 360 / 8; //divides circle into 8 slices
        float offset = step / 2; //22.5

        float angle = Vector2.SignedAngle(Vector2.up, norDir);

        angle += offset;
        if(angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
    
}
