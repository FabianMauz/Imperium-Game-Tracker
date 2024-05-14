using UnityEngine;
namespace GameStats{
    public class DifficultyChoiceMenu : MonoBehaviour {
        [SerializeField]
        private float scaleSpeed=1;

        private void Start() {
            this.transform.localScale = new Vector3(.1f, .1f, .1f);

            
        }

        private void Update() {            
            if(isVisibile()) {
                if(this.transform.localScale.x < 1) {
                    Vector3 newScale = this.transform.localScale;
                    newScale += new Vector3(scaleSpeed * Time.deltaTime, scaleSpeed * Time.deltaTime, scaleSpeed * Time.deltaTime);
                    this.transform.localScale = newScale;
                }else {
                    this.transform.localScale = new Vector3(1, 1, 1);
                }
            }else {
                if (this.transform.localScale.x > .1f) {
                    Vector3 newScale = this.transform.localScale;
                    newScale -= new Vector3(scaleSpeed * Time.deltaTime, scaleSpeed * Time.deltaTime, scaleSpeed * Time.deltaTime);
                    this.transform.localScale = newScale;
                } else {
                    this.gameObject.SetActive(false);
                }
            }
        }


        public void UpdateUI() {
            this.gameObject.SetActive(true);
        }

        private bool isVisibile() {
            return StatController.instance.state == State.SELECT_DIFFICULTY;
        }
    }
}
