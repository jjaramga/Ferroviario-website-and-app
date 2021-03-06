﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferroviario.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboTypes();

        IEnumerable<SelectListItem> GetComboDrivers();

        IEnumerable<SelectListItem> GetComboServices();
    }
}
