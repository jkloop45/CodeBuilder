﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBuilder.DataSource.Exporter
{
    using PhysicalDataModel;

    public class SqlServer2005Exporter : BaseExporter, IExporter
    {
        #region IExporter 成员

        public override Model Export(ExportConfig config)
        {
            return null;
        }

        #endregion
    }
}