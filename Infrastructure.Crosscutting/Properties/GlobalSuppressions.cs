﻿// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly:
   SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.IContainer.#Register`2()")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.IContainer.#Register`2(System.String)")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface", Scope = "type",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.Configuration.RegisterTypesMapConfigurationElementCollection"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1010:CollectionsShouldImplementGenericInterface", Scope = "type",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Configuration.ContainerConfigurationElementCollection"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1012:AbstractTypesShouldNotHaveConstructors", Scope = "type",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.RegisterTypesMap")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1012:AbstractTypesShouldNotHaveConstructors", Scope = "type",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.ContainerConfiguration")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.TypeMapConfigurationBase`2.#GetDescriptor()")
]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Logging")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.TypeMapConfigurationBase`2.#BeforeMap(!0&)")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.TypeMapConfigurationBase`2.#AfterMap(!1&,System.Object[])"
      )]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.CrosscuttingConfigurationSection.#Adapters")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.Configuration.RegisterTypesMapConfigurationElement.#Type"
      )]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Configuration.ContainerConfigurationElement.#Type"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters.TypeMapConfigurationBase`2.#GetDescriptor()")
]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Impl.Unity.UnityApplicationBlockContainer.#Register`2(System.String)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Impl.Unity.UnityApplicationBlockContainer.#Register`2()"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Impl.Unity")]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.CrosscuttingConfigurationSection.#Containers")]
[assembly:
   SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Impl.Unity.UnityApplicationBlockContainer.#CreateContainersHierarchy()"
      )]
[assembly:
   SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.IoCFactory.#.cctor()")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Impl",
      Scope = "namespace", Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.IoC.Impl.Unity")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Crosscutting",
      Scope = "type",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.CrosscuttingConfigurationSection")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
      Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Validator")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Crosscutting",
      Scope = "namespace", Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Validator")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Crosscutting",
      Scope = "namespace", Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Logging")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Crosscutting",
      Scope = "namespace", Target = "Microsoft.Samples.NLayerApp.Infrastructure.Crosscutting.Adapters")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Crosscutting")
]