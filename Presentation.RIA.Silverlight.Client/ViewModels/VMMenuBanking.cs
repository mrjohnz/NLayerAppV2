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
using System.Windows;
using System.Windows.Input;

using Microsoft.Samples.NLayerApp.Presentation.Silverlight.Client.ViewModelBase;

namespace Microsoft.Samples.NLayerApp.Presentation.Silverlight.Client.ViewModels
{

   /// <summary>
   ///    ViewModel menu banking
   /// </summary>
   public class VmMenuBanking : ObservableObject
   {
      #region Members
      private ICommand _addTransferCommand;
      private ICommand _viewTransfersCommand;
      #endregion

      #region Properties
      public string ActualState
      {
         get
         {
            return ((MainPage) App.Current.RootVisual).ActualState;
         }
         set
         {
            ((MainPage) App.Current.RootVisual).ActualState = value;
         }
      }

      public MainPage MainPage
      {
         get
         {
            return ((MainPage) App.Current.RootVisual);
         }
      }
      #endregion

      #region Command Properties
      public ICommand AddCommand
      {
         get
         {
            if (_addTransferCommand == null) {
               _addTransferCommand = new DelegateCommand(AddTransferExecute, CanAddTransferExecute);
            }
            return _addTransferCommand;
         }
      }

      public ICommand ViewCommand
      {
         get
         {
            if (_viewTransfersCommand == null) {
               _viewTransfersCommand = new DelegateCommand(ViewTransfersExecute, CanViewTransfersExecute);
            }
            return _viewTransfersCommand;
         }
      }
      #endregion

      #region Constructors
      #endregion

      #region Command Methods
      private bool CanAddTransferExecute()
      {
         return true;
      }

      private void AddTransferExecute()
      {
         VisualStateManager.GoToState(MainPage, "ToAddTransfer", true);
      }

      private bool CanViewTransfersExecute()
      {
         return true;
      }

      private void ViewTransfersExecute()
      {
         VisualStateManager.GoToState(MainPage, "ToTransfers", true);
      }
      #endregion
   }

}