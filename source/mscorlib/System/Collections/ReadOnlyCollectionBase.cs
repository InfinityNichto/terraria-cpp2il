using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004FF RID: 1279
	[global::Cpp2ILInjected.Token(Token = "0x20005F9")]
	[global::System.Serializable]
	public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x0001BBD5 File Offset: 0x00019DD5
		[global::Cpp2ILInjected.Token(Token = "0x17000725")]
		protected ArrayList InnerList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A2C4", Offset = "0x1C0A2C4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_IsSynchronized", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.get_SyncRoot", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadOnlyCollectionBase), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ServiceNameCollection", Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = ".ctor", MemberParameters = new object[] { "System.ComponentModel.IComponent[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.ComponentModel.IComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.ComponentModel.IComponent")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = "CopyTo", MemberParameters = new object[]
			{
				"System.ComponentModel.IComponent[]",
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x0001BBD8 File Offset: 0x00019DD8
		[global::Cpp2ILInjected.Token(Token = "0x17000726")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A324", Offset = "0x1C0A324", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x0001BBDB File Offset: 0x00019DDB
		[global::Cpp2ILInjected.Token(Token = "0x17000727")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A340", Offset = "0x1C0A340", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0001BBDE File Offset: 0x00019DDE
		[global::Cpp2ILInjected.Token(Token = "0x17000728")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0A35C", Offset = "0x1C0A35C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0001BBE1 File Offset: 0x00019DE1
		[global::Cpp2ILInjected.Token(Token = "0x6002E2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A378", Offset = "0x1C0A378", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0001BBE4 File Offset: 0x00019DE4
		[global::Cpp2ILInjected.Token(Token = "0x6002E30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A3AC", Offset = "0x1C0A3AC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollectionBase), Member = "get_InnerList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0001BBE7 File Offset: 0x00019DE7
		[global::Cpp2ILInjected.Token(Token = "0x6002E31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0A3C8", Offset = "0x1C0A3C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ServiceNameCollection", Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentCollection", Member = ".ctor", MemberParameters = new object[] { "System.ComponentModel.IComponent[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ReadOnlyCollectionBase()
		{
			throw null;
		}

		// Token: 0x040015C3 RID: 5571
		[global::Cpp2ILInjected.Token(Token = "0x40019C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
