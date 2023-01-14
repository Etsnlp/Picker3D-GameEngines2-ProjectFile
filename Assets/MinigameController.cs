using Command.Player;
using Controllers.Player;
using Data.UnityObjects;
using Data.ValueObjects;
using Signals;
using Sirenix.OdinInspector;
using UnityEngine;
using Unity.UI;
using TMPro;

public class MinigameController : MonoBehaviour
{
    ParticleSystem particle;
    Rigidbody Rigidbody;
    [SerializeField] TextMeshProUGUI Text;

    void Start()
    {
        //Text = GetComponent<TextMeshProUGUI>();
        Text = GameObject.Find("Gem").GetComponent<TextMeshProUGUI>();
        Rigidbody = GetComponent<Rigidbody>();
        particle = gameObject.GetComponentInChildren<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("MiniGame"))
        {
           particle.Play(); 

        }
        if(other.CompareTag("Point"))
        {
           Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
           particle.Stop(); 
           Text.text = "300";

        }
        
    }
}
