using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000049 RID: 73
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	internal enum PrimitiveTypeCode
	{
		// Token: 0x04000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		Empty,
		// Token: 0x04000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		Object,
		// Token: 0x04000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		Char,
		// Token: 0x04000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		CharNullable,
		// Token: 0x04000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		Boolean,
		// Token: 0x04000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		BooleanNullable,
		// Token: 0x04000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		SByte,
		// Token: 0x04000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		SByteNullable,
		// Token: 0x0400017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		Int16,
		// Token: 0x0400017B RID: 379
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		Int16Nullable,
		// Token: 0x0400017C RID: 380
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		UInt16,
		// Token: 0x0400017D RID: 381
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		UInt16Nullable,
		// Token: 0x0400017E RID: 382
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		Int32,
		// Token: 0x0400017F RID: 383
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		Int32Nullable,
		// Token: 0x04000180 RID: 384
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		Byte,
		// Token: 0x04000181 RID: 385
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		ByteNullable,
		// Token: 0x04000182 RID: 386
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		UInt32,
		// Token: 0x04000183 RID: 387
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		UInt32Nullable,
		// Token: 0x04000184 RID: 388
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		Int64,
		// Token: 0x04000185 RID: 389
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		Int64Nullable,
		// Token: 0x04000186 RID: 390
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		UInt64,
		// Token: 0x04000187 RID: 391
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		UInt64Nullable,
		// Token: 0x04000188 RID: 392
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		Single,
		// Token: 0x04000189 RID: 393
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		SingleNullable,
		// Token: 0x0400018A RID: 394
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		Double,
		// Token: 0x0400018B RID: 395
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		DoubleNullable,
		// Token: 0x0400018C RID: 396
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		DateTime,
		// Token: 0x0400018D RID: 397
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		DateTimeNullable,
		// Token: 0x0400018E RID: 398
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		DateTimeOffset,
		// Token: 0x0400018F RID: 399
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		DateTimeOffsetNullable,
		// Token: 0x04000190 RID: 400
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		Decimal,
		// Token: 0x04000191 RID: 401
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		DecimalNullable,
		// Token: 0x04000192 RID: 402
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		Guid,
		// Token: 0x04000193 RID: 403
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		GuidNullable,
		// Token: 0x04000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		TimeSpan,
		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		TimeSpanNullable,
		// Token: 0x04000196 RID: 406
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		BigInteger,
		// Token: 0x04000197 RID: 407
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		BigIntegerNullable,
		// Token: 0x04000198 RID: 408
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		Uri,
		// Token: 0x04000199 RID: 409
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		String,
		// Token: 0x0400019A RID: 410
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		Bytes,
		// Token: 0x0400019B RID: 411
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		DBNull
	}
}
