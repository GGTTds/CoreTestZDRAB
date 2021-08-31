using System;
using System.Collections.Generic;

#nullable disable

namespace TZERC
{
    public partial class DataUser
    {
        public int Id { get; set; }
        public double? ColdWaterLaterMont { get; set; }
        public double? HotWaterLatermount { get; set; }
        public double? ElectLaterMountDay { get; set; }
        public double? ElectLaterMountNight { get; set; }
        public double? GvspodshLaterMount { get; set; }
        public double? GVSPod { get; set; }
        public double? EltObh { get; set; }
        public int? DataKey { get; set; }

        public virtual User DataKeyNavigation { get; set; }
    }
}
