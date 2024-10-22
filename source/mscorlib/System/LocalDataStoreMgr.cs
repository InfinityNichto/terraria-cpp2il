﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000143")]
	internal sealed class LocalDataStoreMgr
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5CC4C", Offset = "0x1C5CC4C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "get_MyLocalStore", ReturnType = typeof(global::System.LocalDataStore))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStore), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.LocalDataStoreMgr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public global::System.LocalDataStoreHolder CreateLocalDataStore()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C498", Offset = "0x1C5C498", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStoreHolder), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStore), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void DeleteLocalDataStore(global::System.LocalDataStore store)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5CDE8", Offset = "0x1C5CDE8", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStoreMgr), Member = "AllocateNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "AllocateDataSlot", ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public global::System.LocalDataStoreSlot AllocateDataSlot()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5D018", Offset = "0x1C5D018", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStoreMgr), Member = "GetNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "AllocateNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "AllocateDataSlot", ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public global::System.LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5D12C", Offset = "0x1C5D12C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.CollectionExtensions), Member = "GetValueOrDefault", MemberTypeParameters = new object[] { "TKey", "TValue" }, MemberParameters = new object[] { "System.Collections.Generic.IReadOnlyDictionary`2<TKey, TValue>", "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "AllocateNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.LocalDataStoreSlot))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public global::System.LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5D248", Offset = "0x1C5D248", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "FreeNamedDataSlot", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void FreeNamedDataSlot(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5CAC4", Offset = "0x1C5CAC4", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStoreSlot), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void FreeDataSlot(int slot, long cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C644", Offset = "0x1C5C644", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStore), Member = "GetData", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStore), Member = "SetData", MemberParameters = new object[]
		{
			typeof(global::System.LocalDataStoreSlot),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void ValidateSlot(global::System.LocalDataStoreSlot slot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C9B4", Offset = "0x1C5C9B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int GetSlotTableLength()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5D340", Offset = "0x1C5D340", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public LocalDataStoreMgr()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
		private const int InitialSlotTableSize = 64;

		[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
		private const int SlotTableDoubleThreshold = 512;

		[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
		private const int LargeSlotTableSizeIncrease = 128;

		[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool[] m_SlotInfoTable;

		[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_FirstAvailableSlot;

		[global::Cpp2ILInjected.Token(Token = "0x40004F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.Generic.List<global::System.LocalDataStore> m_ManagedLocalDataStores;

		[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.Generic.Dictionary<string, global::System.LocalDataStoreSlot> m_KeyToSlotMap;

		[global::Cpp2ILInjected.Token(Token = "0x40004F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long m_CookieGenerator;
	}
}
