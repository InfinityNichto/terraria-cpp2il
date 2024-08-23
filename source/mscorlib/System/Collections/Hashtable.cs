using System;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x02000503 RID: 1283
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
	[global::Cpp2ILInjected.Token(Token = "0x2000608")]
	[global::System.Serializable]
	public class Hashtable : IDictionary, ICollection, IEnumerable, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback, global::System.ICloneable
	{
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		[global::Cpp2ILInjected.Token(Token = "0x17000762")]
		private static global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo> SerializationInfoTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C115F4", Offset = "0x1C115F4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0001BCD7 File Offset: 0x00019ED7
		[global::Cpp2ILInjected.Token(Token = "0x6002F01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11650", Offset = "0x1C11650", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Hashtable(bool trash)
		{
			throw null;
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0001BCDA File Offset: 0x00019EDA
		[global::Cpp2ILInjected.Token(Token = "0x6002F02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11658", Offset = "0x1C11658", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 84)]
		public Hashtable()
		{
			throw null;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0001BCDD File Offset: 0x00019EDD
		[global::Cpp2ILInjected.Token(Token = "0x6002F03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11904", Offset = "0x1C11904", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "get_Attributes", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "AddEditorTable", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(Hashtable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetEditorTable", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Hashtable(int capacity)
		{
			throw null;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		[global::Cpp2ILInjected.Token(Token = "0x6002F04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11664", Offset = "0x1C11664", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(IHashCodeProvider),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public Hashtable(int capacity, float loadFactor)
		{
			throw null;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x0001BCE3 File Offset: 0x00019EE3
		[global::Cpp2ILInjected.Token(Token = "0x6002F05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1190C", Offset = "0x1C1190C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
		{
			throw null;
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x0001BCE6 File Offset: 0x00019EE6
		[global::System.Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x6002F06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11930", Offset = "0x1C11930", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Hashtable(IHashCodeProvider hcp, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x0001BCE9 File Offset: 0x00019EE9
		[global::Cpp2ILInjected.Token(Token = "0x6002F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C119D8", Offset = "0x1C119D8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceSet), Member = "GetCaseInsensitiveObjectInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxyDataBuilder", Member = "ParseProtocolProxies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection", Member = "Find", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.PropertyDescriptor")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Hashtable(IEqualityComparer equalityComparer)
		{
			throw null;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0001BCEC File Offset: 0x00019EEC
		[global::Cpp2ILInjected.Token(Token = "0x6002F08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11A04", Offset = "0x1C11A04", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HeaderInfoTable", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "get_objectsTable", ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Hashtable(int capacity, IEqualityComparer equalityComparer)
		{
			throw null;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0001BCEF File Offset: 0x00019EEF
		[global::System.Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x6002F09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11944", Offset = "0x1C11944", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0001BCF2 File Offset: 0x00019EF2
		[global::Cpp2ILInjected.Token(Token = "0x6002F0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11A2C", Offset = "0x1C11A2C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable.SyncHashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "get_SerializationInfoTable", ReturnType = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "Add", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected Hashtable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x0001BCF5 File Offset: 0x00019EF5
		[global::Cpp2ILInjected.Token(Token = "0x6002F0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11A94", Offset = "0x1C11A94", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
		{
			throw null;
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		[global::Cpp2ILInjected.Token(Token = "0x6002F0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11AE8", Offset = "0x1C11AE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0001BCFB File Offset: 0x00019EFB
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002F0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11E34", Offset = "0x1C11E34", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable", Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0001BCFE File Offset: 0x00019EFE
		[global::Cpp2ILInjected.Token(Token = "0x6002F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11EE8", Offset = "0x1C11EE8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0001BD01 File Offset: 0x00019F01
		[global::Cpp2ILInjected.Token(Token = "0x6002F0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11FD0", Offset = "0x1C11FD0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool Contains(object key)
		{
			throw null;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x0001BD04 File Offset: 0x00019F04
		[global::Cpp2ILInjected.Token(Token = "0x6002F10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11FE0", Offset = "0x1C11FE0", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual bool ContainsKey(object key)
		{
			throw null;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x0001BD07 File Offset: 0x00019F07
		[global::Cpp2ILInjected.Token(Token = "0x6002F11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1212C", Offset = "0x1C1212C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable.KeyCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void CopyKeys(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0001BD0A File Offset: 0x00019F0A
		[global::Cpp2ILInjected.Token(Token = "0x6002F12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C121AC", Offset = "0x1C121AC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CopyEntries(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0001BD0D File Offset: 0x00019F0D
		[global::Cpp2ILInjected.Token(Token = "0x6002F13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1228C", Offset = "0x1C1228C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "CopyEntries", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual void CopyTo(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0001BD10 File Offset: 0x00019F10
		[global::Cpp2ILInjected.Token(Token = "0x6002F14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1242C", Offset = "0x1C1242C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable.ValueCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void CopyValues(global::System.Array array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x1700069D RID: 1693
		[global::Cpp2ILInjected.Token(Token = "0x17000763")]
		public virtual object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C124B8", Offset = "0x1C124B8", Length = "0x1BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002F16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12674", Offset = "0x1C12674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Insert", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0001BD19 File Offset: 0x00019F19
		[global::Cpp2ILInjected.Token(Token = "0x6002F17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1267C", Offset = "0x1C1267C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "Insert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void expand()
		{
			throw null;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0001BD1C File Offset: 0x00019F1C
		[global::Cpp2ILInjected.Token(Token = "0x6002F18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C127F4", Offset = "0x1C127F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "rehash", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void rehash()
		{
			throw null;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x0001BD1F File Offset: 0x00019F1F
		[global::Cpp2ILInjected.Token(Token = "0x6002F19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11EBC", Offset = "0x1C11EBC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UpdateVersion()
		{
			throw null;
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0001BD22 File Offset: 0x00019F22
		[global::Cpp2ILInjected.Token(Token = "0x6002F1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C126E0", Offset = "0x1C126E0", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "rehash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "Insert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "putEntry", MemberParameters = new object[]
		{
			typeof(Hashtable.bucket[]),
			typeof(object),
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void rehash(int newsize)
		{
			throw null;
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0001BD25 File Offset: 0x00019F25
		[global::Cpp2ILInjected.Token(Token = "0x6002F1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C128B0", Offset = "0x1C128B0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0001BD28 File Offset: 0x00019F28
		[global::Cpp2ILInjected.Token(Token = "0x6002F1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1297C", Offset = "0x1C1297C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0001BD2B File Offset: 0x00019F2B
		[global::Cpp2ILInjected.Token(Token = "0x6002F1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C129FC", Offset = "0x1C129FC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual int GetHash(object key)
		{
			throw null;
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0001BD2E File Offset: 0x00019F2E
		[global::Cpp2ILInjected.Token(Token = "0x17000764")]
		public virtual bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12ABC", Offset = "0x1C12ABC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x0001BD31 File Offset: 0x00019F31
		[global::Cpp2ILInjected.Token(Token = "0x17000765")]
		public virtual bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12AC4", Offset = "0x1C12AC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x0001BD34 File Offset: 0x00019F34
		[global::Cpp2ILInjected.Token(Token = "0x17000766")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12ACC", Offset = "0x1C12ACC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x0001BD37 File Offset: 0x00019F37
		[global::Cpp2ILInjected.Token(Token = "0x6002F21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C12AD4", Offset = "0x1C12AD4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual bool KeyEquals(object item, object key)
		{
			throw null;
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x0001BD3A File Offset: 0x00019F3A
		[global::Cpp2ILInjected.Token(Token = "0x17000767")]
		public virtual ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12BDC", Offset = "0x1C12BDC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x0001BD3D File Offset: 0x00019F3D
		[global::Cpp2ILInjected.Token(Token = "0x17000768")]
		public virtual ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12C6C", Offset = "0x1C12C6C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x0001BD40 File Offset: 0x00019F40
		[global::Cpp2ILInjected.Token(Token = "0x6002F24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C11AF0", Offset = "0x1C11AF0", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "rehash", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "expand", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void Insert(object key, object nvalue, bool add)
		{
			throw null;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x0001BD43 File Offset: 0x00019F43
		[global::Cpp2ILInjected.Token(Token = "0x6002F25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C12800", Offset = "0x1C12800", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable), Member = "rehash", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode)
		{
			throw null;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0001BD46 File Offset: 0x00019F46
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6002F26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C12CFC", Offset = "0x1C12CFC", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.WeakHashtable", Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual void Remove(object key)
		{
			throw null;
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x0001BD49 File Offset: 0x00019F49
		[global::Cpp2ILInjected.Token(Token = "0x17000769")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12EB0", Offset = "0x1C12EB0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x0001BD4C File Offset: 0x00019F4C
		[global::Cpp2ILInjected.Token(Token = "0x1700076A")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002F28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12F20", Offset = "0x1C12F20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0001BD4F File Offset: 0x00019F4F
		[global::Cpp2ILInjected.Token(Token = "0x6002F29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C12F28", Offset = "0x1C12F28", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Hashtable.SyncHashtable), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestClient", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Hashtable Synchronized(Hashtable table)
		{
			throw null;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0001BD52 File Offset: 0x00019F52
		[global::Cpp2ILInjected.Token(Token = "0x6002F2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C12FF8", Offset = "0x1C12FF8", Length = "0x528")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "CopyKeys", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "CopyValues", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x0001BD55 File Offset: 0x00019F55
		[global::Cpp2ILInjected.Token(Token = "0x6002F2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C13520", Offset = "0x1C13520", Length = "0x814")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "get_SerializationInfoTable", ReturnType = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Insert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.ConditionalWeakTable<, >), Member = "Remove", MemberParameters = new object[] { "TKey" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		public virtual void OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x040015D4 RID: 5588
		[global::Cpp2ILInjected.Token(Token = "0x40019EF")]
		internal const int HashPrime = 101;

		// Token: 0x040015D5 RID: 5589
		[global::Cpp2ILInjected.Token(Token = "0x40019F0")]
		private const int InitialSize = 3;

		// Token: 0x040015D6 RID: 5590
		[global::Cpp2ILInjected.Token(Token = "0x40019F1")]
		private const string LoadFactorName = "LoadFactor";

		// Token: 0x040015D7 RID: 5591
		[global::Cpp2ILInjected.Token(Token = "0x40019F2")]
		private const string VersionName = "Version";

		// Token: 0x040015D8 RID: 5592
		[global::Cpp2ILInjected.Token(Token = "0x40019F3")]
		private const string ComparerName = "Comparer";

		// Token: 0x040015D9 RID: 5593
		[global::Cpp2ILInjected.Token(Token = "0x40019F4")]
		private const string HashCodeProviderName = "HashCodeProvider";

		// Token: 0x040015DA RID: 5594
		[global::Cpp2ILInjected.Token(Token = "0x40019F5")]
		private const string HashSizeName = "HashSize";

		// Token: 0x040015DB RID: 5595
		[global::Cpp2ILInjected.Token(Token = "0x40019F6")]
		private const string KeysName = "Keys";

		// Token: 0x040015DC RID: 5596
		[global::Cpp2ILInjected.Token(Token = "0x40019F7")]
		private const string ValuesName = "Values";

		// Token: 0x040015DD RID: 5597
		[global::Cpp2ILInjected.Token(Token = "0x40019F8")]
		private const string KeyComparerName = "KeyComparer";

		// Token: 0x040015DE RID: 5598
		[global::Cpp2ILInjected.Token(Token = "0x40019F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Hashtable.bucket[] _buckets;

		// Token: 0x040015DF RID: 5599
		[global::Cpp2ILInjected.Token(Token = "0x40019FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _count;

		// Token: 0x040015E0 RID: 5600
		[global::Cpp2ILInjected.Token(Token = "0x40019FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _occupancy;

		// Token: 0x040015E1 RID: 5601
		[global::Cpp2ILInjected.Token(Token = "0x40019FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _loadsize;

		// Token: 0x040015E2 RID: 5602
		[global::Cpp2ILInjected.Token(Token = "0x40019FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _loadFactor;

		// Token: 0x040015E3 RID: 5603
		[global::Cpp2ILInjected.Token(Token = "0x40019FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _version;

		// Token: 0x040015E4 RID: 5604
		[global::Cpp2ILInjected.Token(Token = "0x40019FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool _isWriterInProgress;

		// Token: 0x040015E5 RID: 5605
		[global::Cpp2ILInjected.Token(Token = "0x4001A00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ICollection _keys;

		// Token: 0x040015E6 RID: 5606
		[global::Cpp2ILInjected.Token(Token = "0x4001A01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ICollection _values;

		// Token: 0x040015E7 RID: 5607
		[global::Cpp2ILInjected.Token(Token = "0x4001A02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private IEqualityComparer _keycomparer;

		// Token: 0x040015E8 RID: 5608
		[global::Cpp2ILInjected.Token(Token = "0x4001A03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private object _syncRoot;

		// Token: 0x040015E9 RID: 5609
		[global::Cpp2ILInjected.Token(Token = "0x4001A04")]
		private static global::System.Runtime.CompilerServices.ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable;

		// Token: 0x0200064E RID: 1614
		[global::Cpp2ILInjected.Token(Token = "0x2000609")]
		private struct bucket
		{
			// Token: 0x04001A9C RID: 6812
			[global::Cpp2ILInjected.Token(Token = "0x4001A05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public object key;

			// Token: 0x04001A9D RID: 6813
			[global::Cpp2ILInjected.Token(Token = "0x4001A06")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public object val;

			// Token: 0x04001A9E RID: 6814
			[global::Cpp2ILInjected.Token(Token = "0x4001A07")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int hash_coll;
		}

		// Token: 0x0200064F RID: 1615
		[global::Cpp2ILInjected.Token(Token = "0x200060A")]
		[global::System.Serializable]
		private class KeyCollection : ICollection, IEnumerable
		{
			// Token: 0x060042CB RID: 17099 RVA: 0x000202B5 File Offset: 0x0001E4B5
			[global::Cpp2ILInjected.Token(Token = "0x6002F2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12C44", Offset = "0x1C12C44", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal KeyCollection(Hashtable hashtable)
			{
				throw null;
			}

			// Token: 0x060042CC RID: 17100 RVA: 0x000202B8 File Offset: 0x0001E4B8
			[global::Cpp2ILInjected.Token(Token = "0x6002F2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C13DB0", Offset = "0x1C13DB0", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "CopyKeys", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			public virtual void CopyTo(global::System.Array array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x060042CD RID: 17101 RVA: 0x000202BB File Offset: 0x0001E4BB
			[global::Cpp2ILInjected.Token(Token = "0x6002F2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C13F24", Offset = "0x1C13F24", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public virtual IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x060042CE RID: 17102 RVA: 0x000202BE File Offset: 0x0001E4BE
			[global::Cpp2ILInjected.Token(Token = "0x1700076B")]
			public virtual bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F2F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C13FA8", Offset = "0x1C13FA8", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x060042CF RID: 17103 RVA: 0x000202C1 File Offset: 0x0001E4C1
			[global::Cpp2ILInjected.Token(Token = "0x1700076C")]
			public virtual object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F30")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C13FBC", Offset = "0x1C13FBC", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x060042D0 RID: 17104 RVA: 0x000202C4 File Offset: 0x0001E4C4
			[global::Cpp2ILInjected.Token(Token = "0x1700076D")]
			public virtual int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F31")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C13FD0", Offset = "0x1C13FD0", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001A9F RID: 6815
			[global::Cpp2ILInjected.Token(Token = "0x4001A08")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Hashtable _hashtable;
		}

		// Token: 0x02000650 RID: 1616
		[global::Cpp2ILInjected.Token(Token = "0x200060B")]
		[global::System.Serializable]
		private class ValueCollection : ICollection, IEnumerable
		{
			// Token: 0x060042D1 RID: 17105 RVA: 0x000202C7 File Offset: 0x0001E4C7
			[global::Cpp2ILInjected.Token(Token = "0x6002F32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12CD4", Offset = "0x1C12CD4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal ValueCollection(Hashtable hashtable)
			{
				throw null;
			}

			// Token: 0x060042D2 RID: 17106 RVA: 0x000202CA File Offset: 0x0001E4CA
			[global::Cpp2ILInjected.Token(Token = "0x6002F33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C13FDC", Offset = "0x1C13FDC", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "CopyValues", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			public virtual void CopyTo(global::System.Array array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x060042D3 RID: 17107 RVA: 0x000202CD File Offset: 0x0001E4CD
			[global::Cpp2ILInjected.Token(Token = "0x6002F34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14150", Offset = "0x1C14150", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public virtual IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x060042D4 RID: 17108 RVA: 0x000202D0 File Offset: 0x0001E4D0
			[global::Cpp2ILInjected.Token(Token = "0x1700076E")]
			public virtual bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F35")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C141D4", Offset = "0x1C141D4", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x060042D5 RID: 17109 RVA: 0x000202D3 File Offset: 0x0001E4D3
			[global::Cpp2ILInjected.Token(Token = "0x1700076F")]
			public virtual object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F36")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C141E8", Offset = "0x1C141E8", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x060042D6 RID: 17110 RVA: 0x000202D6 File Offset: 0x0001E4D6
			[global::Cpp2ILInjected.Token(Token = "0x17000770")]
			public virtual int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F37")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C141FC", Offset = "0x1C141FC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001AA0 RID: 6816
			[global::Cpp2ILInjected.Token(Token = "0x4001A09")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Hashtable _hashtable;
		}

		// Token: 0x02000651 RID: 1617
		[global::Cpp2ILInjected.Token(Token = "0x200060C")]
		[global::System.Serializable]
		private class SyncHashtable : Hashtable, IEnumerable
		{
			// Token: 0x060042D7 RID: 17111 RVA: 0x000202D9 File Offset: 0x0001E4D9
			[global::Cpp2ILInjected.Token(Token = "0x6002F38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12FD0", Offset = "0x1C12FD0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal SyncHashtable(Hashtable table)
			{
				throw null;
			}

			// Token: 0x060042D8 RID: 17112 RVA: 0x000202DC File Offset: 0x0001E4DC
			[global::Cpp2ILInjected.Token(Token = "0x6002F39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14208", Offset = "0x1C14208", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal SyncHashtable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x060042D9 RID: 17113 RVA: 0x000202DF File Offset: 0x0001E4DF
			[global::Cpp2ILInjected.Token(Token = "0x6002F3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14244", Offset = "0x1C14244", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x060042DA RID: 17114 RVA: 0x000202E2 File Offset: 0x0001E4E2
			[global::Cpp2ILInjected.Token(Token = "0x17000771")]
			public override int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F3B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C1427C", Offset = "0x1C1427C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x060042DB RID: 17115 RVA: 0x000202E5 File Offset: 0x0001E4E5
			[global::Cpp2ILInjected.Token(Token = "0x17000772")]
			public override bool IsReadOnly
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F3C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C14290", Offset = "0x1C14290", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x060042DC RID: 17116 RVA: 0x000202E8 File Offset: 0x0001E4E8
			[global::Cpp2ILInjected.Token(Token = "0x17000773")]
			public override bool IsFixedSize
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F3D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C142A4", Offset = "0x1C142A4", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x060042DD RID: 17117 RVA: 0x000202EB File Offset: 0x0001E4EB
			[global::Cpp2ILInjected.Token(Token = "0x17000774")]
			public override bool IsSynchronized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F3E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C142B8", Offset = "0x1C142B8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007CA RID: 1994
			[global::Cpp2ILInjected.Token(Token = "0x17000775")]
			public override object this[object key]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F3F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C142C0", Offset = "0x1C142C0", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6002F40")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C142D4", Offset = "0x1C142D4", Length = "0xF0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x060042E0 RID: 17120 RVA: 0x000202F4 File Offset: 0x0001E4F4
			[global::Cpp2ILInjected.Token(Token = "0x17000776")]
			public override object SyncRoot
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F41")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C143C4", Offset = "0x1C143C4", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060042E1 RID: 17121 RVA: 0x000202F7 File Offset: 0x0001E4F7
			[global::Cpp2ILInjected.Token(Token = "0x6002F42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C143D8", Offset = "0x1C143D8", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Add(object key, object value)
			{
				throw null;
			}

			// Token: 0x060042E2 RID: 17122 RVA: 0x000202FA File Offset: 0x0001E4FA
			[global::Cpp2ILInjected.Token(Token = "0x6002F43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C144C8", Offset = "0x1C144C8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Clear()
			{
				throw null;
			}

			// Token: 0x060042E3 RID: 17123 RVA: 0x000202FD File Offset: 0x0001E4FD
			[global::Cpp2ILInjected.Token(Token = "0x6002F44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C145A4", Offset = "0x1C145A4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override bool Contains(object key)
			{
				throw null;
			}

			// Token: 0x060042E4 RID: 17124 RVA: 0x00020300 File Offset: 0x0001E500
			[global::Cpp2ILInjected.Token(Token = "0x6002F45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C145B8", Offset = "0x1C145B8", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public override bool ContainsKey(object key)
			{
				throw null;
			}

			// Token: 0x060042E5 RID: 17125 RVA: 0x00020303 File Offset: 0x0001E503
			[global::Cpp2ILInjected.Token(Token = "0x6002F46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1463C", Offset = "0x1C1463C", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void CopyTo(global::System.Array array, int arrayIndex)
			{
				throw null;
			}

			// Token: 0x060042E6 RID: 17126 RVA: 0x00020306 File Offset: 0x0001E506
			[global::Cpp2ILInjected.Token(Token = "0x6002F47")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1472C", Offset = "0x1C1472C", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Synchronized", MemberParameters = new object[] { typeof(Hashtable) }, ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override object Clone()
			{
				throw null;
			}

			// Token: 0x060042E7 RID: 17127 RVA: 0x00020309 File Offset: 0x0001E509
			[global::Cpp2ILInjected.Token(Token = "0x6002F48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14878", Offset = "0x1C14878", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060042E8 RID: 17128 RVA: 0x0002030C File Offset: 0x0001E50C
			[global::Cpp2ILInjected.Token(Token = "0x6002F49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C1488C", Offset = "0x1C1488C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override IDictionaryEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x060042E9 RID: 17129 RVA: 0x0002030F File Offset: 0x0001E50F
			[global::Cpp2ILInjected.Token(Token = "0x17000777")]
			public override ICollection Keys
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F4A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C148A0", Offset = "0x1C148A0", Length = "0xE8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x060042EA RID: 17130 RVA: 0x00020312 File Offset: 0x0001E512
			[global::Cpp2ILInjected.Token(Token = "0x17000778")]
			public override ICollection Values
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F4B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C14988", Offset = "0x1C14988", Length = "0xE8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
				{
					typeof(object),
					typeof(ref bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060042EB RID: 17131 RVA: 0x00020315 File Offset: 0x0001E515
			[global::Cpp2ILInjected.Token(Token = "0x6002F4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14A70", Offset = "0x1C14A70", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public override void Remove(object key)
			{
				throw null;
			}

			// Token: 0x060042EC RID: 17132 RVA: 0x00020318 File Offset: 0x0001E518
			[global::Cpp2ILInjected.Token(Token = "0x6002F4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14B58", Offset = "0x1C14B58", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void OnDeserialization(object sender)
			{
				throw null;
			}

			// Token: 0x04001AA1 RID: 6817
			[global::Cpp2ILInjected.Token(Token = "0x4001A0A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			protected Hashtable _table;
		}

		// Token: 0x02000652 RID: 1618
		[global::Cpp2ILInjected.Token(Token = "0x200060D")]
		[global::System.Serializable]
		private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, global::System.ICloneable
		{
			// Token: 0x060042ED RID: 17133 RVA: 0x0002031B File Offset: 0x0001E51B
			[global::Cpp2ILInjected.Token(Token = "0x6002F4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C12930", Offset = "0x1C12930", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
			{
				throw null;
			}

			// Token: 0x060042EE RID: 17134 RVA: 0x0002031E File Offset: 0x0001E51E
			[global::Cpp2ILInjected.Token(Token = "0x6002F4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14B5C", Offset = "0x1C14B5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x060042EF RID: 17135 RVA: 0x00020321 File Offset: 0x0001E521
			[global::Cpp2ILInjected.Token(Token = "0x17000779")]
			public virtual object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F50")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C14B64", Offset = "0x1C14B64", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060042F0 RID: 17136 RVA: 0x00020324 File Offset: 0x0001E524
			[global::Cpp2ILInjected.Token(Token = "0x6002F51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14BC4", Offset = "0x1C14BC4", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public virtual bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x060042F1 RID: 17137 RVA: 0x00020327 File Offset: 0x0001E527
			[global::Cpp2ILInjected.Token(Token = "0x1700077A")]
			public virtual DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F52")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C14CBC", Offset = "0x1C14CBC", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x060042F2 RID: 17138 RVA: 0x0002032A File Offset: 0x0001E52A
			[global::Cpp2ILInjected.Token(Token = "0x1700077B")]
			public virtual object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F53")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C14D20", Offset = "0x1C14D20", Length = "0xD0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x060042F3 RID: 17139 RVA: 0x0002032D File Offset: 0x0001E52D
			[global::Cpp2ILInjected.Token(Token = "0x1700077C")]
			public virtual object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002F54")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C14DF0", Offset = "0x1C14DF0", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060042F4 RID: 17140 RVA: 0x00020330 File Offset: 0x0001E530
			[global::Cpp2ILInjected.Token(Token = "0x6002F55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C14E50", Offset = "0x1C14E50", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x04001AA2 RID: 6818
			[global::Cpp2ILInjected.Token(Token = "0x4001A0B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Hashtable _hashtable;

			// Token: 0x04001AA3 RID: 6819
			[global::Cpp2ILInjected.Token(Token = "0x4001A0C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _bucket;

			// Token: 0x04001AA4 RID: 6820
			[global::Cpp2ILInjected.Token(Token = "0x4001A0D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x04001AA5 RID: 6821
			[global::Cpp2ILInjected.Token(Token = "0x4001A0E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private bool _current;

			// Token: 0x04001AA6 RID: 6822
			[global::Cpp2ILInjected.Token(Token = "0x4001A0F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _getObjectRetType;

			// Token: 0x04001AA7 RID: 6823
			[global::Cpp2ILInjected.Token(Token = "0x4001A10")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private object _currentKey;

			// Token: 0x04001AA8 RID: 6824
			[global::Cpp2ILInjected.Token(Token = "0x4001A11")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private object _currentValue;
		}

		// Token: 0x02000653 RID: 1619
		[global::Cpp2ILInjected.Token(Token = "0x200060E")]
		internal class HashtableDebugView
		{
		}
	}
}
