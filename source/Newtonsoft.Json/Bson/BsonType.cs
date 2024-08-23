using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000E2 RID: 226
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200012B")]
	internal enum BsonType : sbyte
	{
		// Token: 0x04000333 RID: 819
		[global::Cpp2ILInjected.Token(Token = "0x400045A")]
		Number = 1,
		// Token: 0x04000334 RID: 820
		[global::Cpp2ILInjected.Token(Token = "0x400045B")]
		String,
		// Token: 0x04000335 RID: 821
		[global::Cpp2ILInjected.Token(Token = "0x400045C")]
		Object,
		// Token: 0x04000336 RID: 822
		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		Array,
		// Token: 0x04000337 RID: 823
		[global::Cpp2ILInjected.Token(Token = "0x400045E")]
		Binary,
		// Token: 0x04000338 RID: 824
		[global::Cpp2ILInjected.Token(Token = "0x400045F")]
		Undefined,
		// Token: 0x04000339 RID: 825
		[global::Cpp2ILInjected.Token(Token = "0x4000460")]
		Oid,
		// Token: 0x0400033A RID: 826
		[global::Cpp2ILInjected.Token(Token = "0x4000461")]
		Boolean,
		// Token: 0x0400033B RID: 827
		[global::Cpp2ILInjected.Token(Token = "0x4000462")]
		Date,
		// Token: 0x0400033C RID: 828
		[global::Cpp2ILInjected.Token(Token = "0x4000463")]
		Null,
		// Token: 0x0400033D RID: 829
		[global::Cpp2ILInjected.Token(Token = "0x4000464")]
		Regex,
		// Token: 0x0400033E RID: 830
		[global::Cpp2ILInjected.Token(Token = "0x4000465")]
		Reference,
		// Token: 0x0400033F RID: 831
		[global::Cpp2ILInjected.Token(Token = "0x4000466")]
		Code,
		// Token: 0x04000340 RID: 832
		[global::Cpp2ILInjected.Token(Token = "0x4000467")]
		Symbol,
		// Token: 0x04000341 RID: 833
		[global::Cpp2ILInjected.Token(Token = "0x4000468")]
		CodeWScope,
		// Token: 0x04000342 RID: 834
		[global::Cpp2ILInjected.Token(Token = "0x4000469")]
		Integer,
		// Token: 0x04000343 RID: 835
		[global::Cpp2ILInjected.Token(Token = "0x400046A")]
		TimeStamp,
		// Token: 0x04000344 RID: 836
		[global::Cpp2ILInjected.Token(Token = "0x400046B")]
		Long,
		// Token: 0x04000345 RID: 837
		[global::Cpp2ILInjected.Token(Token = "0x400046C")]
		MinKey = -1,
		// Token: 0x04000346 RID: 838
		[global::Cpp2ILInjected.Token(Token = "0x400046D")]
		MaxKey = 127
	}
}
