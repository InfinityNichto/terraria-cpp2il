using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F8 RID: 248
	[global::Cpp2ILInjected.Token(Token = "0x200011A")]
	public struct BatchVisibility
	{
		// Token: 0x0400046A RID: 1130
		[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int offset;

		// Token: 0x0400046B RID: 1131
		[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly int instancesCount;

		// Token: 0x0400046C RID: 1132
		[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int visibleCount;
	}
}
