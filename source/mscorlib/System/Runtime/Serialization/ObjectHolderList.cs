using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000339 RID: 825
	[global::Cpp2ILInjected.Token(Token = "0x20003E1")]
	internal class ObjectHolderList
	{
		// Token: 0x06001D37 RID: 7479 RVA: 0x000196AF File Offset: 0x000178AF
		[global::Cpp2ILInjected.Token(Token = "0x6001F75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54D78", Offset = "0x1B54D78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal ObjectHolderList()
		{
			throw null;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000196B2 File Offset: 0x000178B2
		[global::Cpp2ILInjected.Token(Token = "0x6001F76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5884C", Offset = "0x1B5884C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolderList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectHolderList(int startingSize)
		{
			throw null;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000196B5 File Offset: 0x000178B5
		[global::Cpp2ILInjected.Token(Token = "0x6001F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B588B8", Offset = "0x1B588B8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderList), Member = "EnlargeArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal virtual void Add(ObjectHolder value)
		{
			throw null;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x000196B8 File Offset: 0x000178B8
		[global::Cpp2ILInjected.Token(Token = "0x6001F78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B579A4", Offset = "0x1B579A4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectHolderListEnumerator GetFixupEnumerator()
		{
			throw null;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x000196BB File Offset: 0x000178BB
		[global::Cpp2ILInjected.Token(Token = "0x6001F79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58934", Offset = "0x1B58934", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolderList), Member = "Add", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnlargeArray()
		{
			throw null;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x000196BE File Offset: 0x000178BE
		[global::Cpp2ILInjected.Token(Token = "0x1700042E")]
		internal int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B589F0", Offset = "0x1B589F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x000196C1 File Offset: 0x000178C1
		[global::Cpp2ILInjected.Token(Token = "0x1700042F")]
		internal int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B589F8", Offset = "0x1B589F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000CC7 RID: 3271
		[global::Cpp2ILInjected.Token(Token = "0x4000FB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ObjectHolder[] m_values;

		// Token: 0x04000CC8 RID: 3272
		[global::Cpp2ILInjected.Token(Token = "0x4000FBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int m_count;
	}
}
