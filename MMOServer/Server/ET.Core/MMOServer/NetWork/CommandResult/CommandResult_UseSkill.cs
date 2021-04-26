﻿using PF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ETModel
{

    public class CommandResult_UseSkill : ICommandResult
    {
        
        public long unitId;
        public long targetId;
        public int frame;
        public int skillId;  
        public Vector3 direction; 
        public bool success; 
        public int bufferId; 
    }
}
