using System;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B3 RID: 179
	[global::System.Runtime.Versioning.NonVersionable]
	[global::Cpp2ILInjected.Token(Token = "0x20000E3")]
	[global::System.Serializable]
	public struct Nullable<T> where T : struct
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x00015B6F File Offset: 0x00013D6F
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x600084D")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CE96C", Offset = "0x17CE96C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 66)]
		public Nullable(T value)
		{
			throw null;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00015B72 File Offset: 0x00013D72
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public bool HasValue
		{
			[global::System.Runtime.Versioning.NonVersionable]
			[global::Cpp2ILInjected.Token(Token = "0x600084E")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CE980", Offset = "0x17CE980", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00015B75 File Offset: 0x00013D75
		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600084F")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CE988", Offset = "0x17CE988", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_NoValue", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00015B78 File Offset: 0x00013D78
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000850")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CE9AC", Offset = "0x17CE9AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public T GetValueOrDefault()
		{
			throw null;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00015B7B File Offset: 0x00013D7B
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000851")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CE9B4", Offset = "0x17CE9B4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public T GetValueOrDefault(T defaultValue)
		{
			throw null;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00015B7E File Offset: 0x00013D7E
		[global::Cpp2ILInjected.Token(Token = "0x6000852")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CE9D0", Offset = "0x17CE9D0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00015B81 File Offset: 0x00013D81
		[global::Cpp2ILInjected.Token(Token = "0x6000853")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CEA40", Offset = "0x17CEA40", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00015B84 File Offset: 0x00013D84
		[global::Cpp2ILInjected.Token(Token = "0x6000854")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CEA84", Offset = "0x17CEA84", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00015B87 File Offset: 0x00013D87
		[global::Cpp2ILInjected.Token(Token = "0x6000855")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CEB00", Offset = "0x17CEB00", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static object Box(T? o)
		{
			throw null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00015B8A File Offset: 0x00013D8A
		[global::Cpp2ILInjected.Token(Token = "0x6000856")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CEB4C", Offset = "0x17CEB4C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static T? Unbox(object o)
		{
			throw null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00015B8D File Offset: 0x00013D8D
		[global::Cpp2ILInjected.Token(Token = "0x6000857")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CEBE8", Offset = "0x17CEBE8", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static T? UnboxExact(object o)
		{
			throw null;
		}

		// Token: 0x04000220 RID: 544
		[global::Cpp2ILInjected.Token(Token = "0x400036D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool hasValue;

		// Token: 0x04000221 RID: 545
		[global::Cpp2ILInjected.Token(Token = "0x400036E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal T value;
	}
}
