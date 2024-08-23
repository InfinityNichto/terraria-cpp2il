using System;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Xml;

namespace System.Collections
{
	// Token: 0x02000501 RID: 1281
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(Stack.StackDebugView))]
	[global::Cpp2ILInjected.Token(Token = "0x2000600")]
	[global::System.Serializable]
	public class Stack : ICollection, IEnumerable, global::System.ICloneable
	{
		// Token: 0x06002AD8 RID: 10968 RVA: 0x0001BC4D File Offset: 0x00019E4D
		[global::Cpp2ILInjected.Token(Token = "0x6002E94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D348", Offset = "0x1C0D348", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SecurityParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Xml.SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ReadProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Mono.Xml.SmallXmlParser.IAttrList),
			typeof(bool)
		}, ReturnType = typeof(global::System.Runtime.Remoting.ProviderData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "GetLogicalOperationStack", ReturnType = typeof(Stack))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.ParticleContentValidator", Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngineInternal.GenericStack", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Stack()
		{
			throw null;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0001BC50 File Offset: 0x00019E50
		[global::Cpp2ILInjected.Token(Token = "0x6002E95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D3A4", Offset = "0x1C0D3A4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stack), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Stack(int initialCapacity)
		{
			throw null;
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x0001BC53 File Offset: 0x00019E53
		[global::Cpp2ILInjected.Token(Token = "0x17000748")]
		public virtual int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D46C", Offset = "0x1C0D46C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0001BC56 File Offset: 0x00019E56
		[global::Cpp2ILInjected.Token(Token = "0x17000749")]
		public virtual bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D474", Offset = "0x1C0D474", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x0001BC59 File Offset: 0x00019E59
		[global::Cpp2ILInjected.Token(Token = "0x1700074A")]
		public virtual object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D47C", Offset = "0x1C0D47C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0001BC5C File Offset: 0x00019E5C
		[global::Cpp2ILInjected.Token(Token = "0x6002E99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D4EC", Offset = "0x1C0D4EC", Length = "0x30")]
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

		// Token: 0x06002ADE RID: 10974 RVA: 0x0001BC5F File Offset: 0x00019E5F
		[global::Cpp2ILInjected.Token(Token = "0x6002E9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D51C", Offset = "0x1C0D51C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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

		// Token: 0x06002ADF RID: 10975 RVA: 0x0001BC62 File Offset: 0x00019E62
		[global::Cpp2ILInjected.Token(Token = "0x6002E9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D5A4", Offset = "0x1C0D5A4", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public virtual void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0001BC65 File Offset: 0x00019E65
		[global::Cpp2ILInjected.Token(Token = "0x6002E9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D800", Offset = "0x1C0D800", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x0001BC68 File Offset: 0x00019E68
		[global::Cpp2ILInjected.Token(Token = "0x6002E9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D8A4", Offset = "0x1C0D8A4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object Peek()
		{
			throw null;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0001BC6B File Offset: 0x00019E6B
		[global::Cpp2ILInjected.Token(Token = "0x6002E9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D910", Offset = "0x1C0D910", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual object Pop()
		{
			throw null;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0001BC6E File Offset: 0x00019E6E
		[global::Cpp2ILInjected.Token(Token = "0x6002E9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0D98C", Offset = "0x1C0D98C", Length = "0xD8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void Push(object obj)
		{
			throw null;
		}

		// Token: 0x040015CC RID: 5580
		[global::Cpp2ILInjected.Token(Token = "0x40019DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] _array;

		// Token: 0x040015CD RID: 5581
		[global::Cpp2ILInjected.Token(Token = "0x40019DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _size;

		// Token: 0x040015CE RID: 5582
		[global::Cpp2ILInjected.Token(Token = "0x40019DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _version;

		// Token: 0x040015CF RID: 5583
		[global::Cpp2ILInjected.Token(Token = "0x40019DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private object _syncRoot;

		// Token: 0x02000648 RID: 1608
		[global::Cpp2ILInjected.Token(Token = "0x2000601")]
		[global::System.Serializable]
		private class StackEnumerator : IEnumerator, global::System.ICloneable
		{
			// Token: 0x0600428C RID: 17036 RVA: 0x000201F8 File Offset: 0x0001E3F8
			[global::Cpp2ILInjected.Token(Token = "0x6002EA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0D86C", Offset = "0x1C0D86C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal StackEnumerator(Stack stack)
			{
				throw null;
			}

			// Token: 0x0600428D RID: 17037 RVA: 0x000201FB File Offset: 0x0001E3FB
			[global::Cpp2ILInjected.Token(Token = "0x6002EA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0DA64", Offset = "0x1C0DA64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x0600428E RID: 17038 RVA: 0x000201FE File Offset: 0x0001E3FE
			[global::Cpp2ILInjected.Token(Token = "0x6002EA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0DA6C", Offset = "0x1C0DA6C", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x0600428F RID: 17039 RVA: 0x00020201 File Offset: 0x0001E401
			[global::Cpp2ILInjected.Token(Token = "0x1700074B")]
			public virtual object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002EA3")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C0DB30", Offset = "0x1C0DB30", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004290 RID: 17040 RVA: 0x00020204 File Offset: 0x0001E404
			[global::Cpp2ILInjected.Token(Token = "0x6002EA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0DBBC", Offset = "0x1C0DBBC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public virtual void Reset()
			{
				throw null;
			}

			// Token: 0x04001A90 RID: 6800
			[global::Cpp2ILInjected.Token(Token = "0x40019DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Stack _stack;

			// Token: 0x04001A91 RID: 6801
			[global::Cpp2ILInjected.Token(Token = "0x40019E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x04001A92 RID: 6802
			[global::Cpp2ILInjected.Token(Token = "0x40019E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _version;

			// Token: 0x04001A93 RID: 6803
			[global::Cpp2ILInjected.Token(Token = "0x40019E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object _currentElement;
		}

		// Token: 0x02000649 RID: 1609
		[global::Cpp2ILInjected.Token(Token = "0x2000602")]
		internal class StackDebugView
		{
		}
	}
}
