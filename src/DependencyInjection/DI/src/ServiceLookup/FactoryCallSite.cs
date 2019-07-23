// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    internal class FactoryCallSite : ServiceCallSite
    {
        public Func<IServiceProvider, object> Factory { get; }

        public ServiceDescriptor ServiceDescriptor { get; }

        public FactoryCallSite(ResultCache cache, Type serviceType, Func<IServiceProvider, object> factory, ServiceDescriptor serviceDescriptor) : base(cache)
        {
            Factory = factory;
            ServiceDescriptor = serviceDescriptor;
            ServiceType = serviceType;
        }

        public override Type ServiceType { get; }
        public override Type ImplementationType => null;

        public override CallSiteKind Kind { get; } = CallSiteKind.Factory;
    }
}
