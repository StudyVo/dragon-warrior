using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    private void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bool isEnteringRightSide = collision.transform.position.x < transform.position.x;

            if (isEnteringRightSide)
            {
                if (nextRoom != null)
                {
                    cam.MoveToNewRoom(nextRoom);
                    nextRoom.GetComponent<Room>().ActivateRoom(true);
                }
                else
                {
                    Debug.Log("Không có nextRoom — có thể là cửa chuyển cảnh");
                    // Thêm xử lý chuyển scene tại đây nếu cần
                }

                previousRoom.GetComponent<Room>().ActivateRoom(false);
            }
            else
            {
                cam.MoveToNewRoom(previousRoom);
                previousRoom.GetComponent<Room>().ActivateRoom(true);

                if (nextRoom != null)
                {
                    nextRoom.GetComponent<Room>().ActivateRoom(false);
                }
            }
        }
    }
}