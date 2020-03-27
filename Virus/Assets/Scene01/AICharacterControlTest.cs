using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacterTest))]
    public class AICharacterControlTest : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacterTest character { get; private set; } // the character we are controlling
        public Transform target;                                    // target to aim for
        public Vector3 director;

        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacterTest>();

	        agent.updateRotation = false;
	        agent.updatePosition = true;
        }


        private void Update()
        {
            if (target != null)
                agent.SetDestination(target.position);

            if (agent.remainingDistance > agent.stoppingDistance)
            {
                director = (agent.desiredVelocity == Vector3.zero)? director: agent.desiredVelocity;
                character.Move(director, false, false);
            }
            else
            {
                character.Move(Vector3.zero, false, false);
            }
        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
