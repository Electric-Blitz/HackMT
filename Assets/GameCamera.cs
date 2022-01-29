using UnityEngine;

public class GameCamera : MonoBehaviour
{

    public KeyCode zoomOut = KeyCode.DownArrow;
    public KeyCode zoomIn = KeyCode.UpArrow;
    public KeyCode zoomSmall = KeyCode.RightArrow;
    public KeyCode zoomBig = KeyCode.LeftArrow;
    private GameObject subject;
    private float zDistance = -10f;
    private float yLevel = 20f;
    private float yChange = 0.075f;
    private float zChange = -0.0375f;
    private float yLevelMax = 53f;
    private float yLevelMin = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, yLevel, zDistance);
        transform.localRotation = Quaternion.Euler(60, 0, 0);
        subject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(subject.transform.position.x, yLevel, subject.transform.position.z + zDistance);
        if (Input.GetKey(zoomOut) && yLevel < yLevelMax)
        {
            yLevel = yLevel + yChange;
            zDistance = zDistance + zChange;
        }
        if (Input.GetKey(zoomIn) && yLevel > yLevelMin)
        {
            yLevel = yLevel - yChange;
            zDistance = zDistance - zChange;
        }
        if (Input.GetKeyDown(zoomSmall))
        {
            yLevel = 5f;
            zDistance = -2.5f;
        }
        if (Input.GetKeyDown(zoomBig))
        {
            yLevel = 53f;
            zDistance = -26.5f;
        }
    }
}