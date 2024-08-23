using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x02000436 RID: 1078
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004F5")]
	public enum TypeAttributes
	{
		// Token: 0x04001104 RID: 4356
		[global::Cpp2ILInjected.Token(Token = "0x400141E")]
		VisibilityMask = 7,
		// Token: 0x04001105 RID: 4357
		[global::Cpp2ILInjected.Token(Token = "0x400141F")]
		NotPublic = 0,
		// Token: 0x04001106 RID: 4358
		[global::Cpp2ILInjected.Token(Token = "0x4001420")]
		Public = 1,
		// Token: 0x04001107 RID: 4359
		[global::Cpp2ILInjected.Token(Token = "0x4001421")]
		NestedPublic = 2,
		// Token: 0x04001108 RID: 4360
		[global::Cpp2ILInjected.Token(Token = "0x4001422")]
		NestedPrivate = 3,
		// Token: 0x04001109 RID: 4361
		[global::Cpp2ILInjected.Token(Token = "0x4001423")]
		NestedFamily = 4,
		// Token: 0x0400110A RID: 4362
		[global::Cpp2ILInjected.Token(Token = "0x4001424")]
		NestedAssembly = 5,
		// Token: 0x0400110B RID: 4363
		[global::Cpp2ILInjected.Token(Token = "0x4001425")]
		NestedFamANDAssem = 6,
		// Token: 0x0400110C RID: 4364
		[global::Cpp2ILInjected.Token(Token = "0x4001426")]
		NestedFamORAssem = 7,
		// Token: 0x0400110D RID: 4365
		[global::Cpp2ILInjected.Token(Token = "0x4001427")]
		LayoutMask = 24,
		// Token: 0x0400110E RID: 4366
		[global::Cpp2ILInjected.Token(Token = "0x4001428")]
		AutoLayout = 0,
		// Token: 0x0400110F RID: 4367
		[global::Cpp2ILInjected.Token(Token = "0x4001429")]
		SequentialLayout = 8,
		// Token: 0x04001110 RID: 4368
		[global::Cpp2ILInjected.Token(Token = "0x400142A")]
		ExplicitLayout = 16,
		// Token: 0x04001111 RID: 4369
		[global::Cpp2ILInjected.Token(Token = "0x400142B")]
		ClassSemanticsMask = 32,
		// Token: 0x04001112 RID: 4370
		[global::Cpp2ILInjected.Token(Token = "0x400142C")]
		Class = 0,
		// Token: 0x04001113 RID: 4371
		[global::Cpp2ILInjected.Token(Token = "0x400142D")]
		Interface = 32,
		// Token: 0x04001114 RID: 4372
		[global::Cpp2ILInjected.Token(Token = "0x400142E")]
		Abstract = 128,
		// Token: 0x04001115 RID: 4373
		[global::Cpp2ILInjected.Token(Token = "0x400142F")]
		Sealed = 256,
		// Token: 0x04001116 RID: 4374
		[global::Cpp2ILInjected.Token(Token = "0x4001430")]
		SpecialName = 1024,
		// Token: 0x04001117 RID: 4375
		[global::Cpp2ILInjected.Token(Token = "0x4001431")]
		Import = 4096,
		// Token: 0x04001118 RID: 4376
		[global::Cpp2ILInjected.Token(Token = "0x4001432")]
		Serializable = 8192,
		// Token: 0x04001119 RID: 4377
		[global::Cpp2ILInjected.Token(Token = "0x4001433")]
		WindowsRuntime = 16384,
		// Token: 0x0400111A RID: 4378
		[global::Cpp2ILInjected.Token(Token = "0x4001434")]
		StringFormatMask = 196608,
		// Token: 0x0400111B RID: 4379
		[global::Cpp2ILInjected.Token(Token = "0x4001435")]
		AnsiClass = 0,
		// Token: 0x0400111C RID: 4380
		[global::Cpp2ILInjected.Token(Token = "0x4001436")]
		UnicodeClass = 65536,
		// Token: 0x0400111D RID: 4381
		[global::Cpp2ILInjected.Token(Token = "0x4001437")]
		AutoClass = 131072,
		// Token: 0x0400111E RID: 4382
		[global::Cpp2ILInjected.Token(Token = "0x4001438")]
		CustomFormatClass = 196608,
		// Token: 0x0400111F RID: 4383
		[global::Cpp2ILInjected.Token(Token = "0x4001439")]
		CustomFormatMask = 12582912,
		// Token: 0x04001120 RID: 4384
		[global::Cpp2ILInjected.Token(Token = "0x400143A")]
		BeforeFieldInit = 1048576,
		// Token: 0x04001121 RID: 4385
		[global::Cpp2ILInjected.Token(Token = "0x400143B")]
		RTSpecialName = 2048,
		// Token: 0x04001122 RID: 4386
		[global::Cpp2ILInjected.Token(Token = "0x400143C")]
		HasSecurity = 262144,
		// Token: 0x04001123 RID: 4387
		[global::Cpp2ILInjected.Token(Token = "0x400143D")]
		ReservedMask = 264192
	}
}
