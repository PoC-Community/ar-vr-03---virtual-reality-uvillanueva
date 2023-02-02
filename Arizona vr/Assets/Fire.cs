using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;
using UnityEngine.Events;

public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnPoint;
    float BulletSpeed = 20;
    UnityEvent fireEvent = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        Vector3 velocity = new Vector3(BulletSpeed, BulletSpeed, BulletSpeed);
        rb.velocity = velocity;
        //Bullet.velocity = BulletSpeed;
        Destroy(obj, 3);
    }
}
