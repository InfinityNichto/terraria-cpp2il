using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x0200041D RID: 1053
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004DC")]
	public enum MethodAttributes
	{
		// Token: 0x040010A4 RID: 4260
		[global::Cpp2ILInjected.Token(Token = "0x40013BE")]
		MemberAccessMask = 7,
		// Token: 0x040010A5 RID: 4261
		[global::Cpp2ILInjected.Token(Token = "0x40013BF")]
		PrivateScope = 0,
		// Token: 0x040010A6 RID: 4262
		[global::Cpp2ILInjected.Token(Token = "0x40013C0")]
		Private = 1,
		// Token: 0x040010A7 RID: 4263
		[global::Cpp2ILInjected.Token(Token = "0x40013C1")]
		FamANDAssem = 2,
		// Token: 0x040010A8 RID: 4264
		[global::Cpp2ILInjected.Token(Token = "0x40013C2")]
		Assembly = 3,
		// Token: 0x040010A9 RID: 4265
		[global::Cpp2ILInjected.Token(Token = "0x40013C3")]
		Family = 4,
		// Token: 0x040010AA RID: 4266
		[global::Cpp2ILInjected.Token(Token = "0x40013C4")]
		FamORAssem = 5,
		// Token: 0x040010AB RID: 4267
		[global::Cpp2ILInjected.Token(Token = "0x40013C5")]
		Public = 6,
		// Token: 0x040010AC RID: 4268
		[global::Cpp2ILInjected.Token(Token = "0x40013C6")]
		Static = 16,
		// Token: 0x040010AD RID: 4269
		[global::Cpp2ILInjected.Token(Token = "0x40013C7")]
		Final = 32,
		// Token: 0x040010AE RID: 4270
		[global::Cpp2ILInjected.Token(Token = "0x40013C8")]
		Virtual = 64,
		// Token: 0x040010AF RID: 4271
		[global::Cpp2ILInjected.Token(Token = "0x40013C9")]
		HideBySig = 128,
		// Token: 0x040010B0 RID: 4272
		[global::Cpp2ILInjected.Token(Token = "0x40013CA")]
		CheckAccessOnOverride = 512,
		// Token: 0x040010B1 RID: 4273
		[global::Cpp2ILInjected.Token(Token = "0x40013CB")]
		VtableLayoutMask = 256,
		// Token: 0x040010B2 RID: 4274
		[global::Cpp2ILInjected.Token(Token = "0x40013CC")]
		ReuseSlot = 0,
		// Token: 0x040010B3 RID: 4275
		[global::Cpp2ILInjected.Token(Token = "0x40013CD")]
		NewSlot = 256,
		// Token: 0x040010B4 RID: 4276
		[global::Cpp2ILInjected.Token(Token = "0x40013CE")]
		Abstract = 1024,
		// Token: 0x040010B5 RID: 4277
		[global::Cpp2ILInjected.Token(Token = "0x40013CF")]
		SpecialName = 2048,
		// Token: 0x040010B6 RID: 4278
		[global::Cpp2ILInjected.Token(Token = "0x40013D0")]
		PinvokeImpl = 8192,
		// Token: 0x040010B7 RID: 4279
		[global::Cpp2ILInjected.Token(Token = "0x40013D1")]
		UnmanagedExport = 8,
		// Token: 0x040010B8 RID: 4280
		[global::Cpp2ILInjected.Token(Token = "0x40013D2")]
		RTSpecialName = 4096,
		// Token: 0x040010B9 RID: 4281
		[global::Cpp2ILInjected.Token(Token = "0x40013D3")]
		HasSecurity = 16384,
		// Token: 0x040010BA RID: 4282
		[global::Cpp2ILInjected.Token(Token = "0x40013D4")]
		RequireSecObject = 32768,
		// Token: 0x040010BB RID: 4283
		[global::Cpp2ILInjected.Token(Token = "0x40013D5")]
		ReservedMask = 53248
	}
}
