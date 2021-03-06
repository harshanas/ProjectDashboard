﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDashBoard.Model.Repository
{
    public interface IAppSettingsRepository
    {
        string getThreshold();
        string getSpecLink();
        string getProcessComplianceLink();
        string getEmailUserName();
        string getEmailPassword();
        string getEmailUri();
        string getEmailDomain();
        string getEmailBodyLink();
    }
}
