﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.Raft
{
    public enum RaftStates
    {
        Init,
        Follower,
        Candidate,
        Leader
    }
}
