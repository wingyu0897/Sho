using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    StageData stageData;
    [SerializeField]
    private KeyCode keyCodeAttack = KeyCode.Space;
    Movement movement;
    Weapon weapon;

    int score;
    public int Score
    {
        set => score = Mathf.Max(0, value);
        get => score;
    }

    private void Start()
    {
        movement = GetComponent<Movement>();
        weapon = GetComponent<Weapon>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement.MoveTo(new Vector3(x, y, 0));

        if (Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if (Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }

    public void Die()
    {
        SceneManager.LoadScene("GameOver");
    }
}
