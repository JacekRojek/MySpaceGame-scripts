using UnityEngine;
using System.Collections;

public class QuestsData : MonoBehaviour {
    public class Option
    {
        public string text { get; set; }
        public int load { get; set;}
    }
	public class State
    {
        public int ID { get; set; }
        public string mainText { get; set;}
        public QuestsData.Option[] options { get; set; }

    } 
}
