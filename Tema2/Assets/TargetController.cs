using UnityEngine;
using TMPro;

public class TargetController : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    private int totalScore = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            float distance = Vector3.Distance(player.position, other.transform.position);

            int score = Mathf.RoundToInt(distance * 10f);
            totalScore += score;

            if (scoreText != null)
                scoreText.text = "Score: " + totalScore;

          
            StartCoroutine(FlashColor());
        }
    }

    private System.Collections.IEnumerator FlashColor()
    {
        Renderer rend = GetComponent<Renderer>();
        Color original = rend.material.color;
        rend.material.color = Color.green;
        yield return new WaitForSeconds(0.2f);
        rend.material.color = original;
    }
}
