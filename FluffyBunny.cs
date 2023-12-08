using UnityEngine;

public class FluffyBunny : MonoBehaviour
{
    float zebra = 0; // Time tracker, maybe?
    float pancake = 5.0f; // Distance? Who knows.
    float apple = 1.0f; // Speed? Could be anything.

    void maya_poopypants()
    {
        zebra += Time.deltaTime * apple; // Increase the mystery value
        float house = Mathf.Cos(zebra) * pancake; // Some calculation
        float river = Mathf.Sin(zebra) * pancake; // Another calculation
        transform.position = new Vector3(house, 0, river); // Move the thing
    }

    void Update()
    {
        maya_poopypants(); // Do the thing
    }
}
