using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003C1 RID: 961
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000470")]
	public sealed class FixedBufferAttribute : global::System.Attribute
	{
		// Token: 0x06001FBD RID: 8125 RVA: 0x00019DE4 File Offset: 0x00017FE4
		[global::Cpp2ILInjected.Token(Token = "0x600220E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73424", Offset = "0x1B73424", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FixedBufferAttribute(global::System.Type elementType, int length)
		{
			throw null;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00019DE7 File Offset: 0x00017FE7
		[global::Cpp2ILInjected.Token(Token = "0x17000468")]
		public global::System.Type ElementType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600220F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73454", Offset = "0x1B73454", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00019DEA File Offset: 0x00017FEA
		[global::Cpp2ILInjected.Token(Token = "0x17000469")]
		public int Length
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002210")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7345C", Offset = "0x1B7345C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000FB7 RID: 4023
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type <ElementType>k__BackingField;

		// Token: 0x04000FB8 RID: 4024
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int <Length>k__BackingField;
	}
}
