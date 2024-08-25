using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200013F")]
	internal sealed class LocalDataStoreHolder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C30C", Offset = "0x1C5C30C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LocalDataStoreHolder(global::System.LocalDataStore store)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C334", Offset = "0x1C5C334", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "DeleteLocalDataStore", MemberParameters = new object[] { typeof(global::System.LocalDataStore) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public global::System.LocalDataStore Store
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5C3E0", Offset = "0x1C5C3E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.LocalDataStore m_Store;
	}
}
