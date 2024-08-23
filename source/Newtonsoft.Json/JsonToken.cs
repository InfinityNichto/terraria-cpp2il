using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000038 RID: 56
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	public enum JsonToken
	{
		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		None,
		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		StartObject,
		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		StartArray,
		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		StartConstructor,
		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		PropertyName,
		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		Comment,
		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		Raw,
		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		Integer,
		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		Float,
		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		String,
		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		Boolean,
		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		Null,
		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		Undefined,
		// Token: 0x0400011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		EndObject,
		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		EndArray,
		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		EndConstructor,
		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		Date,
		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		Bytes
	}
}
