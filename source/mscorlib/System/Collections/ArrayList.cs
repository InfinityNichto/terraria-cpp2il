using System;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x02000502 RID: 1282
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000603")]
	[global::System.Serializable]
	public class ArrayList : IList, ICollection, IEnumerable, global::System.ICloneable
	{
		// Token: 0x06002AE4 RID: 10980 RVA: 0x0001BC71 File Offset: 0x00019E71
		[global::Cpp2ILInjected.Token(Token = "0x6002EA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08B40", Offset = "0x1C08B40", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 125)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ArrayList()
		{
			throw null;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x0001BC74 File Offset: 0x00019E74
		[global::Cpp2ILInjected.Token(Token = "0x6002EA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0DC30", Offset = "0x1C0DC30", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListenerCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "get_ConnectList", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "get_AcceptList", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "GetStandardValues", MemberParameters = new object[] { "System.ComponentModel.ITypeDescriptorContext" }, ReturnType = "System.ComponentModel.TypeConverter.StandardValuesCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { "System.ComponentModel.IExtenderProvider" }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "CreateAssociation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "FilterMembers", MemberParameters = new object[]
		{
			typeof(IList),
			"System.Attribute[]"
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameValueCollection", Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameValueCollection", Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "get_objectsArray", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public ArrayList(int capacity)
		{
			throw null;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0001BC77 File Offset: 0x00019E77
		[global::Cpp2ILInjected.Token(Token = "0x6002EA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0DD70", Offset = "0x1C0DD70", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.DynamicPropertyCollection), Member = "RegisterDynamicProperty", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Contexts.IDynamicProperty) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage), Member = "GetArguments", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodReturnMessage), Member = "GetArguments", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "GetValues", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(bool),
			"System.String[]",
			"System.Net.ICredentials"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = "set_BypassList", MemberParameters = new object[] { "System.String[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			"System.Attribute[]",
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public ArrayList(ICollection c)
		{
			throw null;
		}

		// Token: 0x17000695 RID: 1685
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x0001BC7A File Offset: 0x00019E7A
		[global::Cpp2ILInjected.Token(Token = "0x1700074C")]
		public virtual int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0DF1C", Offset = "0x1C0DF1C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x0001BC7D File Offset: 0x00019E7D
		[global::Cpp2ILInjected.Token(Token = "0x1700074D")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E028", Offset = "0x1C0E028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x0001BC80 File Offset: 0x00019E80
		[global::Cpp2ILInjected.Token(Token = "0x1700074E")]
		public virtual bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E030", Offset = "0x1C0E030", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x0001BC83 File Offset: 0x00019E83
		[global::Cpp2ILInjected.Token(Token = "0x1700074F")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E038", Offset = "0x1C0E038", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x0001BC86 File Offset: 0x00019E86
		[global::Cpp2ILInjected.Token(Token = "0x17000750")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E040", Offset = "0x1C0E040", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x0001BC89 File Offset: 0x00019E89
		[global::Cpp2ILInjected.Token(Token = "0x17000751")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E048", Offset = "0x1C0E048", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700069B RID: 1691
		[global::Cpp2ILInjected.Token(Token = "0x17000752")]
		public virtual object this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002EAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E0B8", Offset = "0x1C0E0B8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002EAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E144", Offset = "0x1C0E144", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x0001BC92 File Offset: 0x00019E92
		[global::Cpp2ILInjected.Token(Token = "0x6002EB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E214", Offset = "0x1C0E214", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "SortDescriptorArray", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ArrayList Adapter(IList list)
		{
			throw null;
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x0001BC95 File Offset: 0x00019E95
		[global::Cpp2ILInjected.Token(Token = "0x6002EB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E2E4", Offset = "0x1C0E2E4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual int Add(object value)
		{
			throw null;
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x0001BC98 File Offset: 0x00019E98
		[global::Cpp2ILInjected.Token(Token = "0x6002EB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E400", Offset = "0x1C0E400", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void AddRange(ICollection c)
		{
			throw null;
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0001BC9B File Offset: 0x00019E9B
		[global::Cpp2ILInjected.Token(Token = "0x6002EB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E41C", Offset = "0x1C0E41C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x0001BC9E File Offset: 0x00019E9E
		[global::Cpp2ILInjected.Token(Token = "0x6002EB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E458", Offset = "0x1C0E458", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x0001BCA1 File Offset: 0x00019EA1
		[global::Cpp2ILInjected.Token(Token = "0x6002EB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E4D8", Offset = "0x1C0E4D8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool Contains(object item)
		{
			throw null;
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		[global::Cpp2ILInjected.Token(Token = "0x6002EB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E570", Offset = "0x1C0E570", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void CopyTo(global::System.Array array)
		{
			throw null;
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0001BCA7 File Offset: 0x00019EA7
		[global::Cpp2ILInjected.Token(Token = "0x6002EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E584", Offset = "0x1C0E584", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void CopyTo(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0001BCAA File Offset: 0x00019EAA
		[global::Cpp2ILInjected.Token(Token = "0x6002EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E630", Offset = "0x1C0E630", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void CopyTo(int index, global::System.Array array, int arrayIndex, int count)
		{
			throw null;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0001BCAD File Offset: 0x00019EAD
		[global::Cpp2ILInjected.Token(Token = "0x6002EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E3B8", Offset = "0x1C0E3B8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void EnsureCapacity(int min)
		{
			throw null;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0001BCB0 File Offset: 0x00019EB0
		[global::Cpp2ILInjected.Token(Token = "0x6002EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E730", Offset = "0x1C0E730", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList.ArrayListEnumeratorSimple), Member = ".ctor", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x0001BCB3 File Offset: 0x00019EB3
		[global::Cpp2ILInjected.Token(Token = "0x6002EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E888", Offset = "0x1C0E888", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public virtual int IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0001BCB6 File Offset: 0x00019EB6
		[global::Cpp2ILInjected.Token(Token = "0x6002EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E8A0", Offset = "0x1C0E8A0", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x0001BCB9 File Offset: 0x00019EB9
		[global::Cpp2ILInjected.Token(Token = "0x6002EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0E9F4", Offset = "0x1C0E9F4", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual void InsertRange(int index, ICollection c)
		{
			throw null;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0001BCBC File Offset: 0x00019EBC
		[global::Cpp2ILInjected.Token(Token = "0x6002EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EC88", Offset = "0x1C0EC88", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_Secrets", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl", Member = "get_Entries", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ArrayList ReadOnly(ArrayList list)
		{
			throw null;
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x0001BCBF File Offset: 0x00019EBF
		[global::Cpp2ILInjected.Token(Token = "0x6002EBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0ED50", Offset = "0x1C0ED50", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Remove(object obj)
		{
			throw null;
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x0001BCC2 File Offset: 0x00019EC2
		[global::Cpp2ILInjected.Token(Token = "0x6002EC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0ED90", Offset = "0x1C0ED90", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0001BCC5 File Offset: 0x00019EC5
		[global::Cpp2ILInjected.Token(Token = "0x6002EC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EE58", Offset = "0x1C0EE58", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual void RemoveRange(int index, int count)
		{
			throw null;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		[global::Cpp2ILInjected.Token(Token = "0x6002EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EF9C", Offset = "0x1C0EF9C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Sort(IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x0001BCCB File Offset: 0x00019ECB
		[global::Cpp2ILInjected.Token(Token = "0x6002EC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0EFE8", Offset = "0x1C0EFE8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual void Sort(int index, int count, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0001BCCE File Offset: 0x00019ECE
		[global::Cpp2ILInjected.Token(Token = "0x6002EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0F0E0", Offset = "0x1C0F0E0", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object[] ToArray()
		{
			throw null;
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0001BCD1 File Offset: 0x00019ED1
		[global::Cpp2ILInjected.Token(Token = "0x6002EC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0F1B0", Offset = "0x1C0F1B0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual global::System.Array ToArray(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x040015D0 RID: 5584
		[global::Cpp2ILInjected.Token(Token = "0x40019E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] _items;

		// Token: 0x040015D1 RID: 5585
		[global::Cpp2ILInjected.Token(Token = "0x40019E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _size;

		// Token: 0x040015D2 RID: 5586
		[global::Cpp2ILInjected.Token(Token = "0x40019E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _version;

		// Token: 0x040015D3 RID: 5587
		[global::Cpp2ILInjected.Token(Token = "0x40019E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x0200064A RID: 1610
		[global::Cpp2ILInjected.Token(Token = "0x2000604")]
		[global::System.Serializable]
		private class IListWrapper : ArrayList
		{
			// Token: 0x06004291 RID: 17041 RVA: 0x00020207 File Offset: 0x0001E407
			[global::Cpp2ILInjected.Token(Token = "0x6002EC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E2BC", Offset = "0x1C0E2BC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			internal IListWrapper(IList list)
			{
				throw null;
			}

			// Token: 0x170007B1 RID: 1969
			// (set) Token: 0x06004292 RID: 17042 RVA: 0x0002020A File Offset: 0x0001E40A
			[global::Cpp2ILInjected.Token(Token = "0x17000753")]
			public override int Capacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EC7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F2A0", Offset = "0x1C0F2A0", Length = "0x90")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06004293 RID: 17043 RVA: 0x0002020D File Offset: 0x0001E40D
			[global::Cpp2ILInjected.Token(Token = "0x17000754")]
			public override int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EC8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F330", Offset = "0x1C0F330", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06004294 RID: 17044 RVA: 0x00020210 File Offset: 0x0001E410
			[global::Cpp2ILInjected.Token(Token = "0x17000755")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EC9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F3CC", Offset = "0x1C0F3CC", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06004295 RID: 17045 RVA: 0x00020213 File Offset: 0x0001E413
			[global::Cpp2ILInjected.Token(Token = "0x17000756")]
			public override bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F468", Offset = "0x1C0F468", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06004296 RID: 17046 RVA: 0x00020216 File Offset: 0x0001E416
			[global::Cpp2ILInjected.Token(Token = "0x17000757")]
			public override bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F504", Offset = "0x1C0F504", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007B6 RID: 1974
			[global::Cpp2ILInjected.Token(Token = "0x17000758")]
			public override object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F5A0", Offset = "0x1C0F5A0", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002ECD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F648", Offset = "0x1C0F648", Length = "0xC4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06004299 RID: 17049 RVA: 0x0002021F File Offset: 0x0001E41F
			[global::Cpp2ILInjected.Token(Token = "0x17000759")]
			public override object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002ECE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0F70C", Offset = "0x1C0F70C", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600429A RID: 17050 RVA: 0x00020222 File Offset: 0x0001E422
			[global::Cpp2ILInjected.Token(Token = "0x6002ECF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0F7A8", Offset = "0x1C0F7A8", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override int Add(object obj)
			{
				throw null;
			}

			// Token: 0x0600429B RID: 17051 RVA: 0x00020225 File Offset: 0x0001E425
			[global::Cpp2ILInjected.Token(Token = "0x6002ED0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0F864", Offset = "0x1C0F864", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void AddRange(ICollection c)
			{
				throw null;
			}

			// Token: 0x0600429C RID: 17052 RVA: 0x00020228 File Offset: 0x0001E428
			[global::Cpp2ILInjected.Token(Token = "0x6002ED1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0F8AC", Offset = "0x1C0F8AC", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override void Clear()
			{
				throw null;
			}

			// Token: 0x0600429D RID: 17053 RVA: 0x0002022B File Offset: 0x0001E42B
			[global::Cpp2ILInjected.Token(Token = "0x6002ED2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FA04", Offset = "0x1C0FA04", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override object Clone()
			{
				throw null;
			}

			// Token: 0x0600429E RID: 17054 RVA: 0x0002022E File Offset: 0x0001E42E
			[global::Cpp2ILInjected.Token(Token = "0x6002ED3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FA64", Offset = "0x1C0FA64", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override bool Contains(object obj)
			{
				throw null;
			}

			// Token: 0x0600429F RID: 17055 RVA: 0x00020231 File Offset: 0x0001E431
			[global::Cpp2ILInjected.Token(Token = "0x6002ED4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FB10", Offset = "0x1C0FB10", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override void CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			// Token: 0x060042A0 RID: 17056 RVA: 0x00020234 File Offset: 0x0001E434
			[global::Cpp2ILInjected.Token(Token = "0x6002ED5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FBC0", Offset = "0x1C0FBC0", Length = "0x328")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
			public override void CopyTo(int index, global::System.Array array, int arrayIndex, int count)
			{
				throw null;
			}

			// Token: 0x060042A1 RID: 17057 RVA: 0x00020237 File Offset: 0x0001E437
			[global::Cpp2ILInjected.Token(Token = "0x6002ED6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FEE8", Offset = "0x1C0FEE8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060042A2 RID: 17058 RVA: 0x0002023A File Offset: 0x0001E43A
			[global::Cpp2ILInjected.Token(Token = "0x6002ED7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0FF80", Offset = "0x1C0FF80", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public override int IndexOf(object value)
			{
				throw null;
			}

			// Token: 0x060042A3 RID: 17059 RVA: 0x0002023D File Offset: 0x0001E43D
			[global::Cpp2ILInjected.Token(Token = "0x6002ED8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1002C", Offset = "0x1C1002C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void Insert(int index, object obj)
			{
				throw null;
			}

			// Token: 0x060042A4 RID: 17060 RVA: 0x00020240 File Offset: 0x0001E440
			[global::Cpp2ILInjected.Token(Token = "0x6002ED9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C100F0", Offset = "0x1C100F0", Length = "0x3BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			public override void InsertRange(int index, ICollection c)
			{
				throw null;
			}

			// Token: 0x060042A5 RID: 17061 RVA: 0x00020243 File Offset: 0x0001E443
			[global::Cpp2ILInjected.Token(Token = "0x6002EDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C104AC", Offset = "0x1C104AC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Remove(object value)
			{
				throw null;
			}

			// Token: 0x060042A6 RID: 17062 RVA: 0x00020246 File Offset: 0x0001E446
			[global::Cpp2ILInjected.Token(Token = "0x6002EDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C104EC", Offset = "0x1C104EC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x060042A7 RID: 17063 RVA: 0x00020249 File Offset: 0x0001E449
			[global::Cpp2ILInjected.Token(Token = "0x6002EDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C105A8", Offset = "0x1C105A8", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public override void RemoveRange(int index, int count)
			{
				throw null;
			}

			// Token: 0x060042A8 RID: 17064 RVA: 0x0002024C File Offset: 0x0001E44C
			[global::Cpp2ILInjected.Token(Token = "0x6002EDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C107B4", Offset = "0x1C107B4", Length = "0x29C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(IComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw null;
			}

			// Token: 0x060042A9 RID: 17065 RVA: 0x0002024F File Offset: 0x0001E44F
			[global::Cpp2ILInjected.Token(Token = "0x6002EDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10A50", Offset = "0x1C10A50", Length = "0x154")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override object[] ToArray()
			{
				throw null;
			}

			// Token: 0x060042AA RID: 17066 RVA: 0x00020252 File Offset: 0x0001E452
			[global::Cpp2ILInjected.Token(Token = "0x6002EDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10BA4", Offset = "0x1C10BA4", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(int)
			}, ReturnType = typeof(global::System.Array))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public override global::System.Array ToArray(global::System.Type type)
			{
				throw null;
			}

			// Token: 0x04001A94 RID: 6804
			[global::Cpp2ILInjected.Token(Token = "0x40019E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IList _list;
		}

		// Token: 0x0200064B RID: 1611
		[global::Cpp2ILInjected.Token(Token = "0x2000605")]
		[global::System.Serializable]
		private class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x060042AB RID: 17067 RVA: 0x00020255 File Offset: 0x0001E455
			[global::Cpp2ILInjected.Token(Token = "0x6002EE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0ED2C", Offset = "0x1C0ED2C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			internal ReadOnlyArrayList(ArrayList l)
			{
				throw null;
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x060042AC RID: 17068 RVA: 0x00020258 File Offset: 0x0001E458
			[global::Cpp2ILInjected.Token(Token = "0x1700075A")]
			public override int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D4C", Offset = "0x1C10D4C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x060042AD RID: 17069 RVA: 0x0002025B File Offset: 0x0001E45B
			[global::Cpp2ILInjected.Token(Token = "0x1700075B")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D60", Offset = "0x1C10D60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x060042AE RID: 17070 RVA: 0x0002025E File Offset: 0x0001E45E
			[global::Cpp2ILInjected.Token(Token = "0x1700075C")]
			public override bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D68", Offset = "0x1C10D68", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x060042AF RID: 17071 RVA: 0x00020261 File Offset: 0x0001E461
			[global::Cpp2ILInjected.Token(Token = "0x1700075D")]
			public override bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D70", Offset = "0x1C10D70", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007BC RID: 1980
			[global::Cpp2ILInjected.Token(Token = "0x1700075E")]
			public override object this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D84", Offset = "0x1C10D84", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002EE6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10D98", Offset = "0x1C10D98", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x060042B2 RID: 17074 RVA: 0x0002026A File Offset: 0x0001E46A
			[global::Cpp2ILInjected.Token(Token = "0x1700075F")]
			public override object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EE7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10DE4", Offset = "0x1C10DE4", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060042B3 RID: 17075 RVA: 0x0002026D File Offset: 0x0001E46D
			[global::Cpp2ILInjected.Token(Token = "0x6002EE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10DF8", Offset = "0x1C10DF8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override int Add(object obj)
			{
				throw null;
			}

			// Token: 0x060042B4 RID: 17076 RVA: 0x00020270 File Offset: 0x0001E470
			[global::Cpp2ILInjected.Token(Token = "0x6002EE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10E44", Offset = "0x1C10E44", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void AddRange(ICollection c)
			{
				throw null;
			}

			// Token: 0x170007BE RID: 1982
			// (set) Token: 0x060042B5 RID: 17077 RVA: 0x00020273 File Offset: 0x0001E473
			[global::Cpp2ILInjected.Token(Token = "0x17000760")]
			public override int Capacity
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EEA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C10E90", Offset = "0x1C10E90", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060042B6 RID: 17078 RVA: 0x00020276 File Offset: 0x0001E476
			[global::Cpp2ILInjected.Token(Token = "0x6002EEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10EDC", Offset = "0x1C10EDC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Clear()
			{
				throw null;
			}

			// Token: 0x060042B7 RID: 17079 RVA: 0x00020279 File Offset: 0x0001E479
			[global::Cpp2ILInjected.Token(Token = "0x6002EEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C10F28", Offset = "0x1C10F28", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override object Clone()
			{
				throw null;
			}

			// Token: 0x060042B8 RID: 17080 RVA: 0x0002027C File Offset: 0x0001E47C
			[global::Cpp2ILInjected.Token(Token = "0x6002EED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11008", Offset = "0x1C11008", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override bool Contains(object obj)
			{
				throw null;
			}

			// Token: 0x060042B9 RID: 17081 RVA: 0x0002027F File Offset: 0x0001E47F
			[global::Cpp2ILInjected.Token(Token = "0x6002EEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1101C", Offset = "0x1C1101C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void CopyTo(global::System.Array array, int index)
			{
				throw null;
			}

			// Token: 0x060042BA RID: 17082 RVA: 0x00020282 File Offset: 0x0001E482
			[global::Cpp2ILInjected.Token(Token = "0x6002EEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11030", Offset = "0x1C11030", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void CopyTo(int index, global::System.Array array, int arrayIndex, int count)
			{
				throw null;
			}

			// Token: 0x060042BB RID: 17083 RVA: 0x00020285 File Offset: 0x0001E485
			[global::Cpp2ILInjected.Token(Token = "0x6002EF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11044", Offset = "0x1C11044", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060042BC RID: 17084 RVA: 0x00020288 File Offset: 0x0001E488
			[global::Cpp2ILInjected.Token(Token = "0x6002EF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11058", Offset = "0x1C11058", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override int IndexOf(object value)
			{
				throw null;
			}

			// Token: 0x060042BD RID: 17085 RVA: 0x0002028B File Offset: 0x0001E48B
			[global::Cpp2ILInjected.Token(Token = "0x6002EF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1106C", Offset = "0x1C1106C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Insert(int index, object obj)
			{
				throw null;
			}

			// Token: 0x060042BE RID: 17086 RVA: 0x0002028E File Offset: 0x0001E48E
			[global::Cpp2ILInjected.Token(Token = "0x6002EF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C110B8", Offset = "0x1C110B8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void InsertRange(int index, ICollection c)
			{
				throw null;
			}

			// Token: 0x060042BF RID: 17087 RVA: 0x00020291 File Offset: 0x0001E491
			[global::Cpp2ILInjected.Token(Token = "0x6002EF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11104", Offset = "0x1C11104", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Remove(object value)
			{
				throw null;
			}

			// Token: 0x060042C0 RID: 17088 RVA: 0x00020294 File Offset: 0x0001E494
			[global::Cpp2ILInjected.Token(Token = "0x6002EF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11150", Offset = "0x1C11150", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void RemoveAt(int index)
			{
				throw null;
			}

			// Token: 0x060042C1 RID: 17089 RVA: 0x00020297 File Offset: 0x0001E497
			[global::Cpp2ILInjected.Token(Token = "0x6002EF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1119C", Offset = "0x1C1119C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void RemoveRange(int index, int count)
			{
				throw null;
			}

			// Token: 0x060042C2 RID: 17090 RVA: 0x0002029A File Offset: 0x0001E49A
			[global::Cpp2ILInjected.Token(Token = "0x6002EF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C111E8", Offset = "0x1C111E8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw null;
			}

			// Token: 0x060042C3 RID: 17091 RVA: 0x0002029D File Offset: 0x0001E49D
			[global::Cpp2ILInjected.Token(Token = "0x6002EF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11234", Offset = "0x1C11234", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override object[] ToArray()
			{
				throw null;
			}

			// Token: 0x060042C4 RID: 17092 RVA: 0x000202A0 File Offset: 0x0001E4A0
			[global::Cpp2ILInjected.Token(Token = "0x6002EF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11248", Offset = "0x1C11248", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override global::System.Array ToArray(global::System.Type type)
			{
				throw null;
			}

			// Token: 0x04001A95 RID: 6805
			[global::Cpp2ILInjected.Token(Token = "0x40019E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ArrayList _list;
		}

		// Token: 0x0200064C RID: 1612
		[global::Cpp2ILInjected.Token(Token = "0x2000606")]
		[global::System.Serializable]
		private sealed class ArrayListEnumeratorSimple : IEnumerator, global::System.ICloneable
		{
			// Token: 0x060042C5 RID: 17093 RVA: 0x000202A3 File Offset: 0x0001E4A3
			[global::Cpp2ILInjected.Token(Token = "0x6002EFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0E788", Offset = "0x1C0E788", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayList), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal ArrayListEnumeratorSimple(ArrayList list)
			{
				throw null;
			}

			// Token: 0x060042C6 RID: 17094 RVA: 0x000202A6 File Offset: 0x0001E4A6
			[global::Cpp2ILInjected.Token(Token = "0x6002EFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1125C", Offset = "0x1C1125C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x060042C7 RID: 17095 RVA: 0x000202A9 File Offset: 0x0001E4A9
			[global::Cpp2ILInjected.Token(Token = "0x6002EFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11264", Offset = "0x1C11264", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x060042C8 RID: 17096 RVA: 0x000202AC File Offset: 0x0001E4AC
			[global::Cpp2ILInjected.Token(Token = "0x17000761")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EFD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C113F4", Offset = "0x1C113F4", Length = "0xCC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060042C9 RID: 17097 RVA: 0x000202AF File Offset: 0x0001E4AF
			[global::Cpp2ILInjected.Token(Token = "0x6002EFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C114C0", Offset = "0x1C114C0", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x060042CA RID: 17098 RVA: 0x000202B2 File Offset: 0x0001E4B2
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6002EFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C11584", Offset = "0x1C11584", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			static ArrayListEnumeratorSimple()
			{
				throw null;
			}

			// Token: 0x04001A96 RID: 6806
			[global::Cpp2ILInjected.Token(Token = "0x40019E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ArrayList _list;

			// Token: 0x04001A97 RID: 6807
			[global::Cpp2ILInjected.Token(Token = "0x40019EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x04001A98 RID: 6808
			[global::Cpp2ILInjected.Token(Token = "0x40019EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x04001A99 RID: 6809
			[global::Cpp2ILInjected.Token(Token = "0x40019EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object _currentElement;

			// Token: 0x04001A9A RID: 6810
			[global::Cpp2ILInjected.Token(Token = "0x40019ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool _isArrayList;

			// Token: 0x04001A9B RID: 6811
			[global::Cpp2ILInjected.Token(Token = "0x40019EE")]
			private static object s_dummyObject;
		}

		// Token: 0x0200064D RID: 1613
		[global::Cpp2ILInjected.Token(Token = "0x2000607")]
		internal class ArrayListDebugView
		{
		}
	}
}
