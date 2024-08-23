using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	[global::Cpp2ILInjected.Token(Token = "0x200001F")]
	public sealed class GUILayoutOption
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000230B File Offset: 0x0000050B
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C1EC", Offset = "0x1F9C1EC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal GUILayoutOption(GUILayoutOption.Type type, object value)
		{
			throw null;
		}

		// Token: 0x040000D8 RID: 216
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal GUILayoutOption.Type type;

		// Token: 0x040000D9 RID: 217
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object value;

		// Token: 0x0200002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		internal enum Type
		{
			// Token: 0x040000F4 RID: 244
			[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
			fixedWidth,
			// Token: 0x040000F5 RID: 245
			[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
			fixedHeight,
			// Token: 0x040000F6 RID: 246
			[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
			minWidth,
			// Token: 0x040000F7 RID: 247
			[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
			maxWidth,
			// Token: 0x040000F8 RID: 248
			[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
			minHeight,
			// Token: 0x040000F9 RID: 249
			[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
			maxHeight,
			// Token: 0x040000FA RID: 250
			[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
			stretchWidth,
			// Token: 0x040000FB RID: 251
			[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
			stretchHeight,
			// Token: 0x040000FC RID: 252
			[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
			alignStart,
			// Token: 0x040000FD RID: 253
			[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
			alignMiddle,
			// Token: 0x040000FE RID: 254
			[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
			alignEnd,
			// Token: 0x040000FF RID: 255
			[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
			alignJustify,
			// Token: 0x04000100 RID: 256
			[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
			equalSize,
			// Token: 0x04000101 RID: 257
			[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
			spacing
		}
	}
}
