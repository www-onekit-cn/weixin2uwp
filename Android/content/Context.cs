﻿using android.content.pm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace android.content
{
   public  class Context
    {
        public String getPackageName()
        {
            return "";
        }

        public PackageManager getPackageManager()
        {
            throw new NotImplementedException();
        }

        public Resources getResources()
        {
            throw new NotImplementedException();
        }
    }
}
