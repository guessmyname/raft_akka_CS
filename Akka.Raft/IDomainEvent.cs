using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Akka.Raft
{
    interface IDomainEvent
    {
    }

    public class UpdateTermEvent : IDomainEvent
    {
        public Term Term { get; }

        public UpdateTermEvent(Term term)
        {
            Term = term;
        }
    }

    public class VoteForEvent : IDomainEvent
    {
        public IActorRef Votefor { get; }

        public VoteForEvent(IActorRef votefor)
        {
            Votefor = votefor;
        }
    }

    public class VoteForSelfEvent : IDomainEvent
    {

    }

    public class IncrementVoteEvent : IDomainEvent
    {

    }

    public class GoToFollowerEvent : IDomainEvent
    {
        public Term? Term { get;  }

        public GoToFollowerEvent(Term term)
        {
            Term = term;
        }

        public GoToFollowerEvent()
        {
            Term = null;
        }
    }


    public class WithNewClusterSelf : IDomainEvent
    {
        public IActorRef Self { get; set; }

        public WithNewClusterSelf(IActorRef self)
        {
            Self = self;
        }
    }
}
