using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000241 RID: 577
	[global::Cpp2ILInjected.Token(Token = "0x2000332")]
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		// Token: 0x06001324 RID: 4900 RVA: 0x000064FD File Offset: 0x000046FD
		[global::Cpp2ILInjected.Token(Token = "0x6001562")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B3E8", Offset = "0x1E3B3E8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Container), Member = "get_Components", ReturnType = typeof(ComponentCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ComponentCollection(IComponent[] components)
		{
			throw null;
		}

		// Token: 0x170004B6 RID: 1206
		[global::Cpp2ILInjected.Token(Token = "0x170004DF")]
		public virtual IComponent this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001563")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B428", Offset = "0x1E3B428", Length = "0x55C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004B7 RID: 1207
		[global::Cpp2ILInjected.Token(Token = "0x170004E0")]
		public virtual IComponent this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001564")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B984", Offset = "0x1E3B984", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00006506 File Offset: 0x00004706
		[global::Cpp2ILInjected.Token(Token = "0x6001565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BA0C", Offset = "0x1E3BA0C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(IComponent[] array, int index)
		{
			throw null;
		}
	}
}
