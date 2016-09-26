using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Akka.Raft
{
    
    public interface IStateMetadata
    {

       // IActorRef Candidate { get; set; }
    }

    [Serializable]
    public class Metadata : IStateMetadata
    {
        private IActorRef _candidate;

       

       

        public IActorRef ClusterSelf { get; set; }

        public IActorRef VotedFor { get; set; }

        public Term CurrentTerm { get; set; }
    }
}
