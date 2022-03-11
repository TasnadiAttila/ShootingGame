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

    public float spread;

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
        //Spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(0, spread);

        //Calculate Direction with Spread
        Vector3 direction = (Torkolat.up + new Vector3(x, y, 0)).normalized; // normalized a vektor nagysága 1

        GameObject diskObject = Instantiate(disk,Torkolat.position,Quaternion.Euler(90,0,0));//Unity-n belül a transformos,igazodik az object szögéhez
        diskObject.GetComponent<Rigidbody>().AddForce(direction* firePower,ForceMode.Impulse);//Rigidbody ilyen FIZIKA, olyan mintha meglöknénk
                                                                                              //ForceMode csak 1x adja hozzá az erőt nem folyomatosan mint egy ütés
        UImanager.Singleton.incrementTargetsSHOT();
        
        Destroy(diskObject, 5f);
    }
}
