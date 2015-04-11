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
   SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1.#op_True(Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1.#op_False(Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1.#op_LogicalNot(Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1.#op_BitwiseOr(Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>,Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1.#op_BitwiseAnd(Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>,Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "specification", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1.#op_False(Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.Specification`1<!0>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Domain.Seedwork.IRepository`1.#Get(System.Guid)")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix", MessageId = "T", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.IRepository`1.#GetPaged`1(System.Int32,System.Int32,System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>,System.Boolean)"
      )]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rebinder",
      Scope = "type", Target = "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ParameterRebinder")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ExpressionBuilder.#Compose`1(System.Linq.Expressions.Expression`1<!!0>,System.Linq.Expressions.Expression`1<!!0>,System.Func`3<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ExpressionBuilder.#Compose`1(System.Linq.Expressions.Expression`1<!!0>,System.Linq.Expressions.Expression`1<!!0>,System.Func`3<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Domain.Seedwork.IRepository`1.#GetAll()")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ExpressionBuilder.#Compose`1(System.Linq.Expressions.Expression`1<!!0>,System.Linq.Expressions.Expression`1<!!0>,System.Func`3<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.NotSpecification`1.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Boolean>>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target = "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ISpecification`1.#SatisfiedBy()")]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.IRepository`1.#GetPaged`1(System.Int32,System.Int32,System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>,System.Boolean)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.IRepository`1.#GetFiltered(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Boolean>>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ExpressionBuilder.#Or`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>,System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ExpressionBuilder.#And`1(System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>,System.Linq.Expressions.Expression`1<System.Func`2<!!0,System.Boolean>>)"
      )]
[assembly:
   SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member",
      Target =
         "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.DirectSpecification`1.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Boolean>>)"
      )]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Seedwork")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Seedwork",
      Scope = "namespace", Target = "Microsoft.Samples.NLayerApp.Domain.Seedwork")]
[assembly:
   SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Seedwork",
      Scope = "namespace", Target = "Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification")]