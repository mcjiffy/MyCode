﻿//===================================================================================
// Microsoft Developer & Platform Evangelism
//=================================================================================== 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// Copyright (c) Microsoft Corporation.  All Rights Reserved.
// This code is released under the terms of the MS-LPL license, 
// http://microsoftnlayerapp.codeplex.com/license
//===================================================================================

using Microsoft.Samples.NLayerApp.Domain.MainModule.Entities;
using Microsoft.Samples.NLayerApp.Domain.MainModule.Products;
using Microsoft.Samples.NLayerApp.Infrastructure.CrossCutting.Logging;
using Microsoft.Samples.NLayerApp.Infrastructure.Data.Core;
using Microsoft.Samples.NLayerApp.Infrastructure.Data.MainModule.UnitOfWork;

namespace Microsoft.Samples.NLayerApp.Infrastructure.Data.MainModule.Repositories
{
    /// <summary>
    /// IProductRepository implementation
    /// <see cref="Microsoft.Samples.NLayerApp.Domain.MainModule.Products.IProductRepository"/>
    /// </summary>
    public class ProductRepository
        :Repository<Product>,IProductRepository
    {
        #region Constructor

        /// <summary>
        /// Default constructor for ProductRepository
        /// </summary>
        /// <param name="unitOfWork">IUnitOfWork dependency, intende to be resolved with IoC</param>
        /// <param name="traceManager">ITraceManager dependency, intended to be resolved with IoC</param>
        public ProductRepository(IMainModuleUnitOfWork unitOfWork, ITraceManager traceManager) : base(unitOfWork, traceManager) { }

        #endregion

        
    }
}
