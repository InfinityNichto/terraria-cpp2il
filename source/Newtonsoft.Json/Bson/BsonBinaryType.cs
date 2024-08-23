using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000D7 RID: 215
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200011E")]
	internal enum BsonBinaryType : byte
	{
		// Token: 0x0400030B RID: 779
		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		Binary,
		// Token: 0x0400030C RID: 780
		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		Function,
		// Token: 0x0400030D RID: 781
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		BinaryOld,
		// Token: 0x0400030E RID: 782
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		UuidOld,
		// Token: 0x0400030F RID: 783
		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		Uuid,
		// Token: 0x04000310 RID: 784
		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		Md5,
		// Token: 0x04000311 RID: 785
		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		UserDefined = 128
	}
}
