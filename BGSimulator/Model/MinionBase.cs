﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGSimulator.Model
{
    public class MinionBase : IMinion
    {
        public MinionType MinionType { get; set; }
        public int NumberOfCopies { get; set; }
        public string Name { get; set; }
        public MinionTier MinionTier { get; set; } = MinionTier.Ranks[1];
        public Attribute Attributes { get; set; } = Attribute.None;
        public MinionTag Tags { get; set; } = MinionTag.Normal;
        public MinionType ValidTargets { get; set; } = MinionType.Amalgam;
        public int Level { get; set; } = 1;
        public int Health { get; set; }
        public int Attack { get; set; }
        public bool PoolMinion { get; set; } = true;
        public Action<TriggerParams> OnPlayed { get; set; } = delegate { };
        public Action<TriggerParams> OnDeath { get; set; } = delegate { };
        public Action<TriggerParams> OnTurnStart { get; set; } = delegate { };
        public Action<TriggerParams> OnTurnEnd { get; set; } = delegate { };
        public Action<TriggerParams> OnMinionSummon { get; set; } = delegate { };

        public IMinion Clone(bool fullClone = false)
        {
            return this.MemberwiseClone() as IMinion;
        }
    }
}