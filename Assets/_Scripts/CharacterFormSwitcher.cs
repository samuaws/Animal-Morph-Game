using UnityEngine;

public class CharacterFormSwitcher : MonoBehaviour
{
    public GameObject oldForm;
    public GameObject newForm;
    public GameObject[] effectsPrefabs; // Array of prefabs containing effects
    public float duration = 1;

    public void SwitchForms()
    {
        // Deactivate the old form
        oldForm.SetActive(false);

        // Activate the new form in the same position as the old form
        newForm.transform.position = oldForm.transform.position;
        newForm.transform.forward = oldForm.transform.forward;

        newForm.SetActive(true);

        // Make effects children of the new form and adjust their position
        foreach (GameObject effectPrefab in effectsPrefabs)
        {
            GameObject effectInstance = Instantiate(effectPrefab, newForm.transform.position, Quaternion.identity);
            effectInstance.transform.parent = newForm.transform;
            Destroy(effectInstance, duration); // Destroy the effect after 1 second (adjust as needed)
        }
    }
}
