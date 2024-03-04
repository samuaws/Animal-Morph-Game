using Cinemachine;
using StarterAssets;
using UnityEngine;

public enum Forms
{
    Human,
    Horse
}

public class CharacterFormSwitcher : MonoBehaviour
{
    public GameObject[] effectsPrefabs; // Array of prefabs containing effects
    public float duration = 1;
    public GameObject geometry;
    private Forms activeForm;
    private GameObject activeMesh;

    private void Start()
    {
        activeForm = Forms.Human;
        activeMesh = geometry.transform.GetChild(0).gameObject;
        
    }
    public void SwitchForms(FormStats fs)
    {
        Destroy(activeMesh);
        activeMesh = Instantiate(fs.mesh, geometry.transform);
        activeForm = fs.form;
        GameManager.Instance.player.GetComponent<Animator>().runtimeAnimatorController = fs.animatorController;
        GameManager.Instance.player.GetComponent<Animator>().avatar = fs.avatar;
        GameManager.Instance.player.GetComponent<CharacterController>().radius = fs.coliderRadius;
        GameManager.Instance.player.GetComponent<CharacterController>().height = fs.coliderHeight;
        GameManager.Instance.player.GetComponent<ThirdPersonController>().MoveSpeed = fs.walkSpeed;
        GameManager.Instance.player.GetComponent<ThirdPersonController>().SprintSpeed = fs.runSpeed;


        // Make effects children of the new form and adjust their position
        foreach (GameObject effectPrefab in effectsPrefabs)
        {
            GameObject effectInstance = Instantiate(effectPrefab, GameManager.Instance.player.transform.position, Quaternion.identity);
            effectInstance.transform.parent = GameManager.Instance.player.transform;
            Destroy(effectInstance, duration); // Destroy the effect after 1 second (adjust as needed)
        }
    }
}
