using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200033A RID: 826
	[global::Cpp2ILInjected.Token(Token = "0x20003E2")]
	internal class ObjectHolderListEnumerator
	{
		// Token: 0x06001D3E RID: 7486 RVA: 0x000196C4 File Offset: 0x000178C4
		[global::Cpp2ILInjected.Token(Token = "0x6001F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B589B4", Offset = "0x1B589B4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
		{
			throw null;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x000196C7 File Offset: 0x000178C7
		[global::Cpp2ILInjected.Token(Token = "0x6001F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57A48", Offset = "0x1B57A48", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool MoveNext()
		{
			throw null;
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x000196CA File Offset: 0x000178CA
		[global::Cpp2ILInjected.Token(Token = "0x17000430")]
		internal ObjectHolder Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B57A14", Offset = "0x1B57A14", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000CC9 RID: 3273
		[global::Cpp2ILInjected.Token(Token = "0x4000FBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_isFixupEnumerator;

		// Token: 0x04000CCA RID: 3274
		[global::Cpp2ILInjected.Token(Token = "0x4000FBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ObjectHolderList m_list;

		// Token: 0x04000CCB RID: 3275
		[global::Cpp2ILInjected.Token(Token = "0x4000FBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_startingVersion;

		// Token: 0x04000CCC RID: 3276
		[global::Cpp2ILInjected.Token(Token = "0x4000FBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_currPos;
	}
}
