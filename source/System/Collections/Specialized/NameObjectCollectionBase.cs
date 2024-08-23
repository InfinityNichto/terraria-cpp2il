using System;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x0200030B RID: 779
	[global::Cpp2ILInjected.Token(Token = "0x2000424")]
	[Serializable]
	public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		// Token: 0x060019B3 RID: 6579 RVA: 0x00007676 File Offset: 0x00005876
		[global::Cpp2ILInjected.Token(Token = "0x6001CB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DD7C", Offset = "0x1E8DD7C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected NameObjectCollectionBase()
		{
			throw null;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00007679 File Offset: 0x00005879
		[global::Cpp2ILInjected.Token(Token = "0x6001CB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9142C", Offset = "0x1E9142C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected NameObjectCollectionBase(IEqualityComparer equalityComparer)
		{
			throw null;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0000767C File Offset: 0x0000587C
		[global::Cpp2ILInjected.Token(Token = "0x6001CB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DF64", Offset = "0x1E8DF64", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
		{
			throw null;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0000767F File Offset: 0x0000587F
		[global::Cpp2ILInjected.Token(Token = "0x6001CB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DE40", Offset = "0x1E8DE40", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected NameObjectCollectionBase(int capacity)
		{
			throw null;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00007682 File Offset: 0x00005882
		[global::Cpp2ILInjected.Token(Token = "0x6001CB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EFF8", Offset = "0x1E8EFF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal NameObjectCollectionBase(DBNull dummy)
		{
			throw null;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00007685 File Offset: 0x00005885
		[global::Cpp2ILInjected.Token(Token = "0x6001CB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DFFC", Offset = "0x1E8DFFC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00007688 File Offset: 0x00005888
		[global::Cpp2ILInjected.Token(Token = "0x6001CB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E91608", Offset = "0x1E91608", Length = "0x54C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompatibleComparer), Member = "get_DefaultHashCodeProvider", ReturnType = typeof(IHashCodeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompatibleComparer), Member = "get_DefaultComparer", ReturnType = typeof(IComparer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0000768B File Offset: 0x0000588B
		[global::Cpp2ILInjected.Token(Token = "0x6001CB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E91D00", Offset = "0x1E91D00", Length = "0x75C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public virtual void OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0000768E File Offset: 0x0000588E
		[global::Cpp2ILInjected.Token(Token = "0x6001CB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E914A4", Offset = "0x1E914A4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "BaseClear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Reset()
		{
			throw null;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00007691 File Offset: 0x00005891
		[global::Cpp2ILInjected.Token(Token = "0x6001CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E91550", Offset = "0x1E91550", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Reset(int capacity)
		{
			throw null;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00007694 File Offset: 0x00005894
		[global::Cpp2ILInjected.Token(Token = "0x6001CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E92504", Offset = "0x1E92504", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "GetValues", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "BaseSet", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private NameObjectCollectionBase.NameObjectEntry FindEntry(string key)
		{
			throw null;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00007697 File Offset: 0x00005897
		[global::Cpp2ILInjected.Token(Token = "0x1700066E")]
		protected bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E925B4", Offset = "0x1E925B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0000769A File Offset: 0x0000589A
		[global::Cpp2ILInjected.Token(Token = "0x6001CBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E4C0", Offset = "0x1E8E4C0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected bool BaseHasKeys()
		{
			throw null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0000769D File Offset: 0x0000589D
		[global::Cpp2ILInjected.Token(Token = "0x6001CBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E668", Offset = "0x1E8E668", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "BaseSet", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected void BaseAdd(string name, object value)
		{
			throw null;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000076A0 File Offset: 0x000058A0
		[global::Cpp2ILInjected.Token(Token = "0x6001CBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EA58", Offset = "0x1E8EA58", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGetKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void BaseRemove(string name)
		{
			throw null;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000076A3 File Offset: 0x000058A3
		[global::Cpp2ILInjected.Token(Token = "0x6001CBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E414", Offset = "0x1E8E414", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected void BaseClear()
		{
			throw null;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000076A6 File Offset: 0x000058A6
		[global::Cpp2ILInjected.Token(Token = "0x6001CC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E650", Offset = "0x1E8E650", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NameObjectCollectionBase.NameObjectEntry))]
		protected object BaseGet(string name)
		{
			throw null;
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x000076A9 File Offset: 0x000058A9
		[global::Cpp2ILInjected.Token(Token = "0x6001CC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E9A8", Offset = "0x1E8E9A8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NameObjectCollectionBase.NameObjectEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected void BaseSet(string name, object value)
		{
			throw null;
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x000076AC File Offset: 0x000058AC
		[global::Cpp2ILInjected.Token(Token = "0x6001CC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8ECE4", Offset = "0x1E8ECE4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "GetValues", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected object BaseGet(int index)
		{
			throw null;
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000076AF File Offset: 0x000058AF
		[global::Cpp2ILInjected.Token(Token = "0x6001CC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EE00", Offset = "0x1E8EE00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase.NameObjectKeysEnumerator), Member = "get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "BaseRemove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase), Member = "BaseGetAllKeys", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected string BaseGetKey(int index)
		{
			throw null;
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000076B2 File Offset: 0x000058B2
		[global::Cpp2ILInjected.Token(Token = "0x6001CC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E925E8", Offset = "0x1E925E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000076B5 File Offset: 0x000058B5
		[global::Cpp2ILInjected.Token(Token = "0x1700066F")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9268C", Offset = "0x1E9268C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000076B8 File Offset: 0x000058B8
		[global::Cpp2ILInjected.Token(Token = "0x6001CC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E926A0", Offset = "0x1E926A0", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000076BB File Offset: 0x000058BB
		[global::Cpp2ILInjected.Token(Token = "0x17000670")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9298C", Offset = "0x1E9298C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000076BE File Offset: 0x000058BE
		[global::Cpp2ILInjected.Token(Token = "0x17000671")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92A00", Offset = "0x1E92A00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x000076C1 File Offset: 0x000058C1
		[global::Cpp2ILInjected.Token(Token = "0x6001CC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EEC8", Offset = "0x1E8EEC8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "get_AllKeys", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGetKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected string[] BaseGetAllKeys()
		{
			throw null;
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000076C4 File Offset: 0x000058C4
		[global::Cpp2ILInjected.Token(Token = "0x17000672")]
		public virtual NameObjectCollectionBase.KeysCollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CCA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92A08", Offset = "0x1E92A08", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000076C7 File Offset: 0x000058C7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001CCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E92A98", Offset = "0x1E92A98", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static NameObjectCollectionBase()
		{
			throw null;
		}

		// Token: 0x04000F65 RID: 3941
		[global::Cpp2ILInjected.Token(Token = "0x40013B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _readOnly;

		// Token: 0x04000F66 RID: 3942
		[global::Cpp2ILInjected.Token(Token = "0x40013B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ArrayList _entriesArray;

		// Token: 0x04000F67 RID: 3943
		[global::Cpp2ILInjected.Token(Token = "0x40013BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IEqualityComparer _keyComparer;

		// Token: 0x04000F68 RID: 3944
		[global::Cpp2ILInjected.Token(Token = "0x40013BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Hashtable _entriesTable;

		// Token: 0x04000F69 RID: 3945
		[global::Cpp2ILInjected.Token(Token = "0x40013BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;

		// Token: 0x04000F6A RID: 3946
		[global::Cpp2ILInjected.Token(Token = "0x40013BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private NameObjectCollectionBase.KeysCollection _keys;

		// Token: 0x04000F6B RID: 3947
		[global::Cpp2ILInjected.Token(Token = "0x40013BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private SerializationInfo _serializationInfo;

		// Token: 0x04000F6C RID: 3948
		[global::Cpp2ILInjected.Token(Token = "0x40013BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _version;

		// Token: 0x04000F6D RID: 3949
		[global::Cpp2ILInjected.Token(Token = "0x40013C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x04000F6E RID: 3950
		[global::Cpp2ILInjected.Token(Token = "0x40013C1")]
		private static StringComparer defaultComparer;

		// Token: 0x02000476 RID: 1142
		[global::Cpp2ILInjected.Token(Token = "0x2000425")]
		internal class NameObjectEntry
		{
			// Token: 0x06001F66 RID: 8038 RVA: 0x000086B1 File Offset: 0x000068B1
			[global::Cpp2ILInjected.Token(Token = "0x6001CCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E925BC", Offset = "0x1E925BC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal NameObjectEntry(string name, object value)
			{
				throw null;
			}

			// Token: 0x040013CA RID: 5066
			[global::Cpp2ILInjected.Token(Token = "0x40013C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string Key;

			// Token: 0x040013CB RID: 5067
			[global::Cpp2ILInjected.Token(Token = "0x40013C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal object Value;
		}

		// Token: 0x02000477 RID: 1143
		[global::Cpp2ILInjected.Token(Token = "0x2000426")]
		[Serializable]
		internal class NameObjectKeysEnumerator : IEnumerator
		{
			// Token: 0x06001F67 RID: 8039 RVA: 0x000086B4 File Offset: 0x000068B4
			[global::Cpp2ILInjected.Token(Token = "0x6001CCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92654", Offset = "0x1E92654", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal NameObjectKeysEnumerator(NameObjectCollectionBase coll)
			{
				throw null;
			}

			// Token: 0x06001F68 RID: 8040 RVA: 0x000086B7 File Offset: 0x000068B7
			[global::Cpp2ILInjected.Token(Token = "0x6001CCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92B40", Offset = "0x1E92B40", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06001F69 RID: 8041 RVA: 0x000086BA File Offset: 0x000068BA
			[global::Cpp2ILInjected.Token(Token = "0x6001CCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92C0C", Offset = "0x1E92C0C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x06001F6A RID: 8042 RVA: 0x000086BD File Offset: 0x000068BD
			[global::Cpp2ILInjected.Token(Token = "0x17000673")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001CD0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E92C8C", Offset = "0x1E92C8C", Length = "0x94")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGetKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040013CC RID: 5068
			[global::Cpp2ILInjected.Token(Token = "0x40013C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _pos;

			// Token: 0x040013CD RID: 5069
			[global::Cpp2ILInjected.Token(Token = "0x40013C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private NameObjectCollectionBase _coll;

			// Token: 0x040013CE RID: 5070
			[global::Cpp2ILInjected.Token(Token = "0x40013C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _version;
		}

		// Token: 0x02000478 RID: 1144
		[DefaultMember("Item")]
		[global::Cpp2ILInjected.Token(Token = "0x2000427")]
		[Serializable]
		public class KeysCollection : ICollection, IEnumerable
		{
			// Token: 0x06001F6B RID: 8043 RVA: 0x000086C0 File Offset: 0x000068C0
			[global::Cpp2ILInjected.Token(Token = "0x6001CD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92A70", Offset = "0x1E92A70", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal KeysCollection(NameObjectCollectionBase coll)
			{
				throw null;
			}

			// Token: 0x06001F6C RID: 8044 RVA: 0x000086C3 File Offset: 0x000068C3
			[global::Cpp2ILInjected.Token(Token = "0x6001CD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92D20", Offset = "0x1E92D20", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameObjectCollectionBase.KeysCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06001F6D RID: 8045 RVA: 0x000086C6 File Offset: 0x000068C6
			[global::Cpp2ILInjected.Token(Token = "0x17000674")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001CD3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E92D90", Offset = "0x1E92D90", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F6E RID: 8046 RVA: 0x000086C9 File Offset: 0x000068C9
			[global::Cpp2ILInjected.Token(Token = "0x6001CD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E92DA4", Offset = "0x1E92DA4", Length = "0x2E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase.KeysCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			private void System.Collections.ICollection.CopyTo(Array array, int index)
			{
				throw null;
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06001F6F RID: 8047 RVA: 0x000086CC File Offset: 0x000068CC
			[global::Cpp2ILInjected.Token(Token = "0x17000675")]
			private object System.Collections.ICollection.SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001CD5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E93084", Offset = "0x1E93084", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06001F70 RID: 8048 RVA: 0x000086CF File Offset: 0x000068CF
			[global::Cpp2ILInjected.Token(Token = "0x17000676")]
			private bool System.Collections.ICollection.IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001CD6")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E93120", Offset = "0x1E93120", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F71 RID: 8049 RVA: 0x000086D2 File Offset: 0x000068D2
			[global::Cpp2ILInjected.Token(Token = "0x6001CD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93128", Offset = "0x1E93128", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal KeysCollection()
			{
				throw null;
			}

			// Token: 0x040013CF RID: 5071
			[global::Cpp2ILInjected.Token(Token = "0x40013C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private NameObjectCollectionBase _coll;
		}
	}
}
