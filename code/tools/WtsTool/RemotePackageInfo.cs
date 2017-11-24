﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using WtsTool.CommandOptions;

namespace WtsTool
{
    public class RemotePackageInfo
    {
        public string Name { get; set; }

        public Uri Uri { get; set; }

        public DateTime Date { get; set; }

        public Version Version { get; set; }

        public string MainVersion => Version != null ? $"{Version.Major.ToString()}.{Version.Minor.ToString()}" : "NoVersion";

        public EnvEnum Env { get; set; }
    }
}