using UnityEngine;

public class cannon : MonoBehaviour
{
    [SerializeField]//editorba lehet nyomni
    GameObject disk;

    [SerializeField]
    float timeBetweenShots;

    [SerializeField]
    float firePower;

    [SerializeField]
    Transform Torkolat;

    float timeLeft;//0 és 2 között mindig és változik, ennyi időnként nő


    // Start is called before the first frame update
    private void Start()
    {
        timeLeft = timeBetweenShots; 
    }

    // Update is called once per frame
    //
    private void Update()
    {
        //timeleft hány sec múlva fog lőni
        timeLeft -= Time.deltaTime;//deltaTime 2 frame között eltelt idő
        if(timeLeft<=0){
            timeLeft = timeBetweenShots;
            Shoot();
        }
    }


    void Shoot(){
        GameObject diskObject = Instantiate(disk,Torkolat.position,Quaternion.identity);//Unity-n belül a transformos,igazodik az object szögéhez
        diskObject.GetComponent<Rigidbody>().AddForce(Torkolat.up* firePower,ForceMode.Impulse);//Rigidbody ilyen FIZIKA, olyan mintha meglöknénk
                                                                                //ForceMode csak 1x adja hozzá az erőt nem folyomatosan mint egy ütés
        Destroy(diskObject, 5f);
    }
}
