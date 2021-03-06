﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Framework.Runtime;

namespace Microsoft.AspNet.Http.Interfaces
{
    [AssemblyNeutral]
    public interface ISessionFactory
    {
        bool IsAvailable { get; }

        ISession Create();
    }
}