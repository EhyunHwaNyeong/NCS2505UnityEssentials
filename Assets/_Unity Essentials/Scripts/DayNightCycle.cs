using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script rotates the attached Directional Light to simulate a day-night cycle.
/// The duration of a full day (360-degree rotation) can be set in the Inspector.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    // The duration of a full day in seconds. This is a public variable,
    // so it can be easily adjusted in the Unity Inspector window.
    // A value of 60 means a full day-night cycle takes 60 seconds (1 minute).
    [Tooltip("The duration of a full day-night cycle in seconds.")]
    public float dayDurationInSeconds = 60f;

    // Update is called once per frame.
    void Update()
    {
        // Calculate the speed of rotation based on the desired day duration.
        // A full circle is 360 degrees. We divide this by the total time for the cycle.
        // This gives us the degrees to rotate per second.
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate the light around the X-axis (a common choice for sun rotation).
        // Time.deltaTime ensures the rotation is frame-rate independent.
        // We use Space.World to ensure the rotation is applied relative to the global axes.
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.World);
    }
}
