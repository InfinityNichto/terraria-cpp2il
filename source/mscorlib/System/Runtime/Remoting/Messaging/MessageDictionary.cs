using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200030E RID: 782
	[global::Cpp2ILInjected.Token(Token = "0x20003B3")]
	[global::System.Serializable]
	internal class MessageDictionary : global::System.Collections.IDictionary, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06001C09 RID: 7177 RVA: 0x0001935B File Offset: 0x0001755B
		[global::Cpp2ILInjected.Token(Token = "0x6001E3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B48EA4", Offset = "0x1B48EA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MessageDictionary(IMethodMessage message)
		{
			throw null;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0001935E File Offset: 0x0001755E
		[global::Cpp2ILInjected.Token(Token = "0x6001E3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B45E60", Offset = "0x1B45E60", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IDictionary),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal bool HasUserData()
		{
			throw null;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x00019361 File Offset: 0x00017561
		[global::Cpp2ILInjected.Token(Token = "0x170003D0")]
		internal global::System.Collections.IDictionary InternalDictionary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B45F5C", Offset = "0x1B45F5C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new object[]
			{
				typeof(global::System.Collections.IDictionary),
				typeof(ref global::System.Collections.ArrayList)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000377 RID: 887
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00019364 File Offset: 0x00017564
		[global::Cpp2ILInjected.Token(Token = "0x170003D1")]
		public string[] MethodKeys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B254", Offset = "0x1B4B254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00019367 File Offset: 0x00017567
		[global::Cpp2ILInjected.Token(Token = "0x6001E3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4B25C", Offset = "0x1B4B25C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual global::System.Collections.IDictionary AllocInternalProperties()
		{
			throw null;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0001936A File Offset: 0x0001756A
		[global::Cpp2ILInjected.Token(Token = "0x6001E40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47FC4", Offset = "0x1B47FC4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Collections.IDictionary GetInternalProperties()
		{
			throw null;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0001936D File Offset: 0x0001756D
		[global::Cpp2ILInjected.Token(Token = "0x6001E41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4B2BC", Offset = "0x1B4B2BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary), Member = "get_Keys", ReturnType = typeof(global::System.Collections.ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary), Member = "get_Values", ReturnType = typeof(global::System.Collections.ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private bool IsOverridenKey(string key)
		{
			throw null;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00019370 File Offset: 0x00017570
		[global::Cpp2ILInjected.Token(Token = "0x170003D2")]
		public bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B330", Offset = "0x1B4B330", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x00019373 File Offset: 0x00017573
		[global::Cpp2ILInjected.Token(Token = "0x170003D3")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B338", Offset = "0x1B4B338", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037A RID: 890
		[global::Cpp2ILInjected.Token(Token = "0x170003D4")]
		public object this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B340", Offset = "0x1B4B340", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B474", Offset = "0x1B4B474", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0001937C File Offset: 0x0001757C
		[global::Cpp2ILInjected.Token(Token = "0x6001E46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B49290", Offset = "0x1B49290", Length = "0x550")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected virtual object GetMethodProperty(string key)
		{
			throw null;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0001937F File Offset: 0x0001757F
		[global::Cpp2ILInjected.Token(Token = "0x6001E47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B49A40", Offset = "0x1B49A40", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected virtual void SetMethodProperty(string key, object value)
		{
			throw null;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00019382 File Offset: 0x00017582
		[global::Cpp2ILInjected.Token(Token = "0x170003D5")]
		public global::System.Collections.ICollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B5D0", Offset = "0x1B4B5D0", Length = "0x414")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary), Member = "IsOverridenKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00019385 File Offset: 0x00017585
		[global::Cpp2ILInjected.Token(Token = "0x170003D6")]
		public global::System.Collections.ICollection Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B9E4", Offset = "0x1B4B9E4", Length = "0x3FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary), Member = "IsOverridenKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00019388 File Offset: 0x00017588
		[global::Cpp2ILInjected.Token(Token = "0x6001E4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4B478", Offset = "0x1B4B478", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0001938B File Offset: 0x0001758B
		[global::Cpp2ILInjected.Token(Token = "0x6001E4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4BDE0", Offset = "0x1B4BDE0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0001938E File Offset: 0x0001758E
		[global::Cpp2ILInjected.Token(Token = "0x6001E4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4BE8C", Offset = "0x1B4BE8C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Contains(object key)
		{
			throw null;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00019391 File Offset: 0x00017591
		[global::Cpp2ILInjected.Token(Token = "0x6001E4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4BFBC", Offset = "0x1B4BFBC", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Remove(object key)
		{
			throw null;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00019394 File Offset: 0x00017594
		[global::Cpp2ILInjected.Token(Token = "0x170003D7")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4C128", Offset = "0x1B4C128", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x00019397 File Offset: 0x00017597
		[global::Cpp2ILInjected.Token(Token = "0x170003D8")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4C1E4", Offset = "0x1B4C1E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x0001939A File Offset: 0x0001759A
		[global::Cpp2ILInjected.Token(Token = "0x170003D9")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4C1EC", Offset = "0x1B4C1EC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0001939D File Offset: 0x0001759D
		[global::Cpp2ILInjected.Token(Token = "0x6001E51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4C1F0", Offset = "0x1B4C1F0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary), Member = "get_Values", ReturnType = typeof(global::System.Collections.ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000193A0 File Offset: 0x000175A0
		[global::Cpp2ILInjected.Token(Token = "0x6001E52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4C2A8", Offset = "0x1B4C2A8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(MessageDictionary) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000193A3 File Offset: 0x000175A3
		[global::Cpp2ILInjected.Token(Token = "0x6001E53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4C3D8", Offset = "0x1B4C3D8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(MessageDictionary) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04000C47 RID: 3143
		[global::Cpp2ILInjected.Token(Token = "0x4000F33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.IDictionary _internalProperties;

		// Token: 0x04000C48 RID: 3144
		[global::Cpp2ILInjected.Token(Token = "0x4000F34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected IMethodMessage _message;

		// Token: 0x04000C49 RID: 3145
		[global::Cpp2ILInjected.Token(Token = "0x4000F35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string[] _methodKeys;

		// Token: 0x04000C4A RID: 3146
		[global::Cpp2ILInjected.Token(Token = "0x4000F36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _ownProperties;

		// Token: 0x020005F0 RID: 1520
		[global::Cpp2ILInjected.Token(Token = "0x20003B4")]
		private class DictionaryEnumerator : global::System.Collections.IDictionaryEnumerator, global::System.Collections.IEnumerator
		{
			// Token: 0x06004109 RID: 16649 RVA: 0x0001FDBD File Offset: 0x0001DFBD
			[global::Cpp2ILInjected.Token(Token = "0x6001E54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4C300", Offset = "0x1B4C300", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary), Member = "GetEnumerator", ReturnType = typeof(global::System.Collections.IDictionaryEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public DictionaryEnumerator(MessageDictionary methodDictionary)
			{
				throw null;
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x0600410A RID: 16650 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
			[global::Cpp2ILInjected.Token(Token = "0x170003DA")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001E55")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B4C430", Offset = "0x1B4C430", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600410B RID: 16651 RVA: 0x0001FDC3 File Offset: 0x0001DFC3
			[global::Cpp2ILInjected.Token(Token = "0x6001E56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4C5E0", Offset = "0x1B4C5E0", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary), Member = "IsOverridenKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x0600410C RID: 16652 RVA: 0x0001FDC6 File Offset: 0x0001DFC6
			[global::Cpp2ILInjected.Token(Token = "0x6001E57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4C78C", Offset = "0x1B4C78C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x0600410D RID: 16653 RVA: 0x0001FDC9 File Offset: 0x0001DFC9
			[global::Cpp2ILInjected.Token(Token = "0x170003DB")]
			public global::System.Collections.DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001E58")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B4C494", Offset = "0x1B4C494", Length = "0x14C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "get_Key", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "get_Value", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x0600410E RID: 16654 RVA: 0x0001FDCC File Offset: 0x0001DFCC
			[global::Cpp2ILInjected.Token(Token = "0x170003DC")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001E59")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B4C830", Offset = "0x1B4C830", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x0600410F RID: 16655 RVA: 0x0001FDCF File Offset: 0x0001DFCF
			[global::Cpp2ILInjected.Token(Token = "0x170003DD")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001E5A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B4C834", Offset = "0x1B4C834", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary.DictionaryEnumerator), Member = "get_Entry", ReturnType = typeof(global::System.Collections.DictionaryEntry))]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001974 RID: 6516
			[global::Cpp2ILInjected.Token(Token = "0x4000F37")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private MessageDictionary _methodDictionary;

			// Token: 0x04001975 RID: 6517
			[global::Cpp2ILInjected.Token(Token = "0x4000F38")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Collections.IDictionaryEnumerator _hashtableEnum;

			// Token: 0x04001976 RID: 6518
			[global::Cpp2ILInjected.Token(Token = "0x4000F39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _posMethod;
		}
	}
}
