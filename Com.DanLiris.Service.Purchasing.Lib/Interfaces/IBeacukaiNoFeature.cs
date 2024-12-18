﻿using Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentReports;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Purchasing.Lib.Interfaces
{
    public interface IBeacukaiNoFeature
    {
        Task<List<BeacukaiNoFeatureViewModel>> GetBeacukaiNo(string filter, string keyword);
    }
}
