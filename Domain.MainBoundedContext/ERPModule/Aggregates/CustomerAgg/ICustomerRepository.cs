﻿//===================================================================================
// Microsoft Developer and Platform Evangelism
//=================================================================================== 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// Copyright (c) Microsoft Corporation.  All Rights Reserved.
// This code is released under the terms of the MS-LPL license, 
// http://microsoftnlayerapp.codeplex.com/license
//===================================================================================

using System.Collections.Generic;

using Microsoft.Samples.NLayerApp.Domain.Seedwork;

namespace Microsoft.Samples.NLayerApp.Domain.MainBoundedContext.ERPModule.Aggregates.CustomerAgg
{

   /// <summary>
   ///    Customer repository contract
   ///    <see cref="Microsoft.Samples.NLayerApp.Domain.Seedwork.IRepository{Customer}" />
   /// </summary>
   public interface ICustomerRepository : IRepository<Customer>
   {

      IEnumerable<Customer> GetEnabled(int pageIndex, int pageCount);

   }

}