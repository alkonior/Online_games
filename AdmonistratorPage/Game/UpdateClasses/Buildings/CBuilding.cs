﻿using AdministratorProject.Game.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminictratorProject.Game.UpdateClasses.Buildings
{
    public class CBuilding:CLocation
    {
        public CBuilding(GInt gInt, string name, int? p) : base(gInt, name,p)
        {
            //todo Хз что но можно
        }
    }
}