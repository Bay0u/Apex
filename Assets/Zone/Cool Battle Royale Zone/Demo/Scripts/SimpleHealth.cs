using System.Collections;
using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.UI;

namespace CoolBattleRoyaleZone
{
    /// <summary>
    /// Class which controls health of simple characters
    /// </summary>
	public class SimpleHealth : MonoBehaviour
	{
		private bool inRegion = true;
		private bool _wait;
		Health health;
		private void Update ( )
		{
			// Getting zone current safe zone values
			var zonePos    = Zone.Instance.CurrentSafeZone.Position;
			var zoneRadius = Zone.Instance.CurrentSafeZone.Radius;
			// Checking distance between player and circle
			var dstToZone = Vector3.Distance ( new Vector3 ( transform.position.x , zonePos.y , transform.position.z ) ,
											   zonePos );
			health = GetComponent<Health>();
			// Checking if we inner of circle or not by radius and if not, start applying damage to health
			if ( dstToZone > zoneRadius && !_wait ) StartCoroutine ( DoDamageCoroutine ( ) );
			if(dstToZone > zoneRadius)
            {
                if (inRegion)
                {
					inRegion = false;
					GetComponent<handleRegion>().goOutside();
                }
            }
            else
            {
				if (!inRegion)
				{
					inRegion = true;
					GetComponent<handleRegion>().goInside();
				}
			}
		}

		// Method for waiting time between applying damage
		private IEnumerator DoDamageCoroutine ( )
		{
			_wait = true;
			
			yield return new WaitForSeconds ( 10 ); // Waiting between damages.
            if (!inRegion)
            {
				DoDamage();
			}
			_wait = false;
		}

		// Method for applying damage to health
		private void DoDamage ( )
		{
			if (this.gameObject.tag == "Player")
			{
				health.TakeDamage(10, null);
			}
            else
            {
				health.TakeDamage(1000, null);
			}
		}
	}
}
