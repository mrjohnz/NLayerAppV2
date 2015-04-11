﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.NLayerApp.Application.MainBoundedContext.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    var temp = new global::System.Resources.ResourceManager("Microsoft.Samples.NLayerApp.Application.MainBoundedContext.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the transfer, invalid data in accounts specifications.
        /// </summary>
        internal static string error_CannotPerformTransferInvalidAccounts {
            get {
                return ResourceManager.GetString("error_CannotPerformTransferInvalidAccounts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The country id is empty, you cannot add a new customer without country reference.
        /// </summary>
        internal static string exception_InvalidCountryIdentifier {
            get {
                return ResourceManager.GetString("exception_InvalidCountryIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The customer identifier is empty.
        /// </summary>
        internal static string exception_InvalidCustomerIdentifier {
            get {
                return ResourceManager.GetString("exception_InvalidCustomerIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid page index or page count data.
        /// </summary>
        internal static string exception_InvalidPageIndexOrPageCount {
            get {
                return ResourceManager.GetString("exception_InvalidPageIndexOrPageCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The order total is greater customer credit, you cannot perform new order.
        /// </summary>
        internal static string info_OrderTotalIsGreaterCustomerCredit {
            get {
                return ResourceManager.GetString("info_OrderTotalIsGreaterCustomerCredit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add a new book with a null book dto.
        /// </summary>
        internal static string warning_CannotAddBookWithNullInformation {
            get {
                return ResourceManager.GetString("warning_CannotAddBookWithNullInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add customer. The dto is null or the country identifier is empty.
        /// </summary>
        internal static string warning_CannotAddCustomerWithEmptyInformation {
            get {
                return ResourceManager.GetString("warning_CannotAddCustomerWithEmptyInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add not validated bank account.
        /// </summary>
        internal static string warning_CannotAddNotValidatedBankAccount {
            get {
                return ResourceManager.GetString("warning_CannotAddNotValidatedBankAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add null bank account or bank account without customer identifier.
        /// </summary>
        internal static string warning_CannotAddNullBankAccountOrInvalidCustomer {
            get {
                return ResourceManager.GetString("warning_CannotAddNullBankAccountOrInvalidCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add a new order with a null order dto.
        /// </summary>
        internal static string warning_CannotAddOrderWithNullInformation {
            get {
                return ResourceManager.GetString("warning_CannotAddOrderWithNullInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add a new software with a null order dto.
        /// </summary>
        internal static string warning_CannotAddSoftwareWithNullInformation {
            get {
                return ResourceManager.GetString("warning_CannotAddSoftwareWithNullInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create bank account for not existing customer.
        /// </summary>
        internal static string warning_CannotCreateBankAccountForInvalidCustomer {
            get {
                return ResourceManager.GetString("warning_CannotCreateBankAccountForInvalidCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a bank account for non existing customer.
        /// </summary>
        internal static string warning_CannotCreateBankAccountForNonExistingCustomer {
            get {
                return ResourceManager.GetString("warning_CannotCreateBankAccountForNonExistingCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a new order for non existing customer.
        /// </summary>
        internal static string warning_CannotCreateOrderForNonExistingCustomer {
            get {
                return ResourceManager.GetString("warning_CannotCreateOrderForNonExistingCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get bank account activity for invalid or not existing account.
        /// </summary>
        internal static string warning_CannotGetActivitiesForInvalidOrNotExistingBankAccount {
            get {
                return ResourceManager.GetString("warning_CannotGetActivitiesForInvalidOrNotExistingBankAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get orders from empty customer id.
        /// </summary>
        internal static string warning_CannotGetOrdersFromEmptyCustomerId {
            get {
                return ResourceManager.GetString("warning_CannotGetOrdersFromEmptyCustomerId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot lock bank account ,the identifier is empty.
        /// </summary>
        internal static string warning_CannotLockBankAccountWithEmptyIdentifier {
            get {
                return ResourceManager.GetString("warning_CannotLockBankAccountWithEmptyIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot lock non existing bank account, the unknown key is {0}.
        /// </summary>
        internal static string warning_CannotLockNonExistingBankAccount {
            get {
                return ResourceManager.GetString("warning_CannotLockNonExistingBankAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot remove customer with empty id.
        /// </summary>
        internal static string warning_CannotRemoveCustomerWithEmptyId {
            get {
                return ResourceManager.GetString("warning_CannotRemoveCustomerWithEmptyId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot remove a non existing customer.
        /// </summary>
        internal static string warning_CannotRemoveNonExistingCustomer {
            get {
                return ResourceManager.GetString("warning_CannotRemoveNonExistingCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add customer. The dto is null or the identifier is empty.
        /// </summary>
        internal static string warning_CannotUpdateCustomerWithEmptyInformation {
            get {
                return ResourceManager.GetString("warning_CannotUpdateCustomerWithEmptyInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot update a non existing customer.
        /// </summary>
        internal static string warning_CannotUpdateNonExistingCustomer {
            get {
                return ResourceManager.GetString("warning_CannotUpdateNonExistingCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid argument for FindCustomer, the customerid cannot be empty.
        /// </summary>
        internal static string warning_InvalidArgumentForFindCustomer {
            get {
                return ResourceManager.GetString("warning_InvalidArgumentForFindCustomer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments when call to CustomerManagementService FindOrders.
        /// </summary>
        internal static string warning_InvalidArgumentForFindOrders {
            get {
                return ResourceManager.GetString("warning_InvalidArgumentForFindOrders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments when call to CustomerManagementService FindProducts.
        /// </summary>
        internal static string warning_InvalidArgumentForFindProducts {
            get {
                return ResourceManager.GetString("warning_InvalidArgumentForFindProducts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments when call to CustomerManagementService FindCountries.
        /// </summary>
        internal static string warning_InvalidArgumentsForFindCountries {
            get {
                return ResourceManager.GetString("warning_InvalidArgumentsForFindCountries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments when call to CustomerManagementService FindCustomers.
        /// </summary>
        internal static string warning_InvalidArgumentsForFindCustomers {
            get {
                return ResourceManager.GetString("warning_InvalidArgumentsForFindCustomers", resourceCulture);
            }
        }
    }
}
