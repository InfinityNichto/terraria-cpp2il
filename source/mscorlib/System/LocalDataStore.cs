using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000109 RID: 265
	[global::Cpp2ILInjected.Token(Token = "0x2000141")]
	internal sealed class LocalDataStore
	{
		// Token: 0x06000BE6 RID: 3046 RVA: 0x00016787 File Offset: 0x00014987
		[global::Cpp2ILInjected.Token(Token = "0x6000CB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C428", Offset = "0x1C5C428", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStoreMgr), Member = "CreateLocalDataStore", ReturnType = typeof(global::System.LocalDataStoreHolder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public LocalDataStore(global::System.LocalDataStoreMgr mgr, int InitialCapacity)
		{
			throw null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0001678A File Offset: 0x0001498A
		[global::Cpp2ILInjected.Token(Token = "0x6000CB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C3D4", Offset = "0x1C5C3D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "DeleteLocalDataStore", MemberParameters = new object[] { typeof(global::System.LocalDataStore) }, ReturnType = typeof(void))]
		internal void Dispose()
		{
			throw null;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0001678D File Offset: 0x0001498D
		[global::Cpp2ILInjected.Token(Token = "0x6000CB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C590", Offset = "0x1C5C590", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "GetData", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "ValidateSlot", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public object GetData(global::System.LocalDataStoreSlot slot)
		{
			throw null;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00016790 File Offset: 0x00014990
		[global::Cpp2ILInjected.Token(Token = "0x6000CB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C6B8", Offset = "0x1C5C6B8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.Context), Member = "SetData", MemberParameters = new object[]
		{
			typeof(global::System.LocalDataStoreSlot),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStoreMgr), Member = "ValidateSlot", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.LocalDataStore), Member = "PopulateElement", MemberParameters = new object[] { typeof(global::System.LocalDataStoreSlot) }, ReturnType = typeof(global::System.LocalDataStoreElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetData(global::System.LocalDataStoreSlot slot, object data)
		{
			throw null;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00016793 File Offset: 0x00014993
		[global::Cpp2ILInjected.Token(Token = "0x6000CB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C984", Offset = "0x1C5C984", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void FreeData(int slot, long cookie)
		{
			throw null;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00016796 File Offset: 0x00014996
		[global::Cpp2ILInjected.Token(Token = "0x6000CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C774", Offset = "0x1C5C774", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.LocalDataStore), Member = "SetData", MemberParameters = new object[]
		{
			typeof(global::System.LocalDataStoreSlot),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private global::System.LocalDataStoreElement PopulateElement(global::System.LocalDataStoreSlot slot)
		{
			throw null;
		}

		// Token: 0x04000389 RID: 905
		[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.LocalDataStoreElement[] m_DataTable;

		// Token: 0x0400038A RID: 906
		[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.LocalDataStoreMgr m_Manager;
	}
}
