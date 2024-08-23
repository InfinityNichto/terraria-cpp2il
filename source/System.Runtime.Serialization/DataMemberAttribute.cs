using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000003 RID: 3
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public sealed class DataMemberAttribute : Attribute
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C3E8", Offset = "0x1D5C3E8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataMemberAttribute()
		{
			throw null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000004")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5C400", Offset = "0x1D5C400", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public int Order
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000005")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5C408", Offset = "0x1D5C408", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public bool IsRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000006")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5C410", Offset = "0x1D5C410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public bool EmitDefaultValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000007")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5C418", Offset = "0x1D5C418", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000003 RID: 3
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int order;

		// Token: 0x04000004 RID: 4
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool isRequired;

		// Token: 0x04000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
		private bool emitDefaultValue;
	}
}
