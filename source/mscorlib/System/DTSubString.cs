using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000089 RID: 137
	[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
	internal ref struct DTSubString
	{
		// Token: 0x17000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		internal char this[int relativeIndex]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C2DDF0", Offset = "0x1C2DDF0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(ref global::System.TimeSpan)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400019C RID: 412
		[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal global::System.ReadOnlySpan<char> s;

		// Token: 0x0400019D RID: 413
		[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int index;

		// Token: 0x0400019E RID: 414
		[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int length;

		// Token: 0x0400019F RID: 415
		[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.DTSubStringType type;

		// Token: 0x040001A0 RID: 416
		[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int value;
	}
}
