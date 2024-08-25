using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000142")]
	public sealed class LocalDataStoreSlot
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C9C0", Offset = "0x1C5C9C0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal LocalDataStoreSlot(global::System.LocalDataStoreMgr mgr, int slot, long cookie)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.LocalDataStoreMgr m_mgr;

		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_slot;

		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long m_cookie;
	}
}
