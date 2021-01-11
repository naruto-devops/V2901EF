﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public interface IFournisseurRepository
    {
        List<Fournisseur> GetAll();
    }
}
