using UnityEngine;

namespace DansCrazyCodez
{
    public class FaceCamera : MonoBehaviour
    {
        [SerializeField] private Transform targetCam;

        // Update is called once per frame
        void Update()
        {
            MakeObjectFaceCamera();
        }

        private void MakeObjectFaceCamera()
        {
            Vector3 targetPosition = new Vector3(targetCam.position.x,
                                                 this.transform.position.y,
                                                 targetCam.position.z);
            transform.LookAt(targetPosition);
        }
    }
}
