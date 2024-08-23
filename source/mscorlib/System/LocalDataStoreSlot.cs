using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200010A RID: 266
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000142")]
	public sealed class LocalDataStoreSlot
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x00016799 File Offset: 0x00014999
		[global::Cpp2ILInjected.Token(Token = "0x6000CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C9C0", Offset = "0x1C5C9C0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal LocalDataStoreSlot(global::System.LocalDataStoreMgr mgr, int slot, long cookie)
		{
			throw null;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x0001679C File Offset: 0x0001499C
		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		internal global::System.LocalDataStoreMgr Manager
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5CA00", Offset = "0x1C5CA00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0001679F File Offset: 0x0001499F
		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		internal int Slot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5CA08", Offset = "0x1C5CA08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x000167A2 File Offset: 0x000149A2
		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		internal long Cookie
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5CA10", Offset = "0x1C5CA10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000167A5 File Offset: 0x000149A5
		[global::Cpp2ILInjected.Token(Token = "0x6000CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5CA18", Offset = "0x1C5CA18", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "FreeDataSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0400038B RID: 907
		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.LocalDataStoreMgr m_mgr;

		// Token: 0x0400038C RID: 908
		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_slot;

		// Token: 0x0400038D RID: 909
		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long m_cookie;
	}
}
