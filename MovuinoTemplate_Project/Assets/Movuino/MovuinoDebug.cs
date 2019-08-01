using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Movuino
{
	public class MovuinoDebug : MonoBehaviour
	{
		// Update is called once per frame
		void Update ()
		{
			var movuinoDataList = MovuinoManager.Instance.GetLog<MovuinoSensorData> ();
            var streamoDataList = MovuinoManager.Instance.GetLog<StreamoSensorData>();
            var sensorRepList = MovuinoManager.Instance.GetLog<MovuinoSensorRep> ();
            var xmmList = MovuinoManager.Instance.GetLog<MovuinoXMM> ();

			foreach (var sensorData in movuinoDataList) {
				Debug.Log ("Movuino accelerometer data = " + sensorData.accelerometer);
				Debug.Log ("Movuino gyroscope data = " + sensorData.gyroscope);
				Debug.Log ("Movuino magnetometer data = " + sensorData.magnetometer);
			}
            foreach (var sensorData in streamoDataList)
            {
                Debug.Log("Streamo accelerometer data = " + sensorData.accelerometer);
                Debug.Log("Streamo gyroscope data = " + sensorData.gyroscope);
                Debug.Log("Streamo magnetometer data = " + sensorData.magnetometer);
            }
            foreach (var sensorRep in sensorRepList)
            {
                Debug.Log("Movuino repetitions = " + sensorRep.repAcc + ", " + sensorRep.repGyr + ", " + sensorRep.repMag);
            }
            foreach (var xmm in xmmList) {
				Debug.Log ("Movuino recognition = " + xmm.gestId + ", " + xmm.gestProg);
			}
		}
	}
}