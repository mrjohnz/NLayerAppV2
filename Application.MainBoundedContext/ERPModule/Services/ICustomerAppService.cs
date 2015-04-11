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

using System;
using System.Collections.Generic;

using Microsoft.Samples.NLayerApp.Application.MainBoundedContext.DTO;

namespace Microsoft.Samples.NLayerApp.Application.MainBoundedContext.ERPModule.Services
{

   /// <summary>
   ///    This is the contract that the customer will interact to perform various operations.
   ///    The responsability of this contract is to orchestrate operations, check security, cache,
   ///    adapt entities to DTO etc
   /// </summary>
   public interface ICustomerAppService : IDisposable
   {

      /// <summary>
      ///    Add new customer
      /// </summary>
      /// <param name="customerDto">The customer information</param>
      /// <returns>Added customer representation</returns>
      CustomerDto AddNewCustomer(CustomerDto customerDto);

      /// <summary>
      ///    Update existing customer
      /// </summary>
      /// <param name="customerDto">The customerdto with changes</param>
      void UpdateCustomer(CustomerDto customerDto);

      /// <summary>
      ///    Remove existing customer
      /// </summary>
      /// <param name="customerId">The customer identifier</param>
      void RemoveCustomer(Guid customerId);

      /// <summary>
      ///    Find paged customers
      /// </summary>
      /// <param name="pageIndex">The index of page</param>
      /// <param name="pageCount">The # of elements in each page</param>
      /// <returns>A collection of customer representation</returns>
      List<CustomerListDto> FindCustomers(int pageIndex, int pageCount);

      /// <summary>
      ///    Find customers with contain specific text in
      ///    firstname or lastname
      /// </summary>
      /// <param name="text">the text to seach</param>
      /// <returns>A collection of customer representation</returns>
      List<CustomerListDto> FindCustomers(string text);

      /// <summary>
      ///    Find customer
      /// </summary>
      /// <param name="customerId">The customer identifier</param>
      /// <returns>Selected customer representation if exist or null if not exist</returns>
      CustomerDto FindCustomer(Guid customerId);

      /// <summary>
      ///    Find paged countries
      /// </summary>
      /// <param name="pageIndex">The index of page</param>
      /// <param name="pageCount">The # of elements in each page</param>
      /// <returns>A collection of countries dto</returns>
      List<CountryDto> FindCountries(int pageIndex, int pageCount);

      /// <summary>
      ///    Find countries with country name or iso code like <paramref name="text" />
      /// </summary>
      /// <param name="text">The text to search in countries</param>
      /// <returns>A collection of country dto</returns>
      List<CountryDto> FindCountries(string text);

   }

}