using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200014E RID: 334
	[global::Cpp2ILInjected.Token(Token = "0x2000197")]
	internal class TypeNames
	{
		// Token: 0x0200059C RID: 1436
		[global::Cpp2ILInjected.Token(Token = "0x2000198")]
		internal abstract class ATypeName : global::System.TypeName, global::System.IEquatable<global::System.TypeName>
		{
			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06003FE2 RID: 16354
			[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
			public abstract string DisplayName
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000FC2")]
				get;
			}

			// Token: 0x06003FE3 RID: 16355 RVA: 0x0001FA60 File Offset: 0x0001DC60
			[global::Cpp2ILInjected.Token(Token = "0x6000FC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89644", Offset = "0x1C89644", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeNames.ATypeName), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool Equals(global::System.TypeName other)
			{
				throw null;
			}

			// Token: 0x06003FE4 RID: 16356 RVA: 0x0001FA63 File Offset: 0x0001DC63
			[global::Cpp2ILInjected.Token(Token = "0x6000FC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89714", Offset = "0x1C89714", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06003FE5 RID: 16357 RVA: 0x0001FA66 File Offset: 0x0001DC66
			[global::Cpp2ILInjected.Token(Token = "0x6000FC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89734", Offset = "0x1C89734", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeNames.ATypeName), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TypeName) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object other)
			{
				throw null;
			}

			// Token: 0x06003FE6 RID: 16358 RVA: 0x0001FA69 File Offset: 0x0001DC69
			[global::Cpp2ILInjected.Token(Token = "0x6000FC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C89794", Offset = "0x1C89794", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected ATypeName()
			{
				throw null;
			}
		}
	}
}
