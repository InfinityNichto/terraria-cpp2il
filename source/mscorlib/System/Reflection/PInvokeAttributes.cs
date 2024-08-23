using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x0200043E RID: 1086
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004FD")]
	[global::System.Serializable]
	internal enum PInvokeAttributes
	{
		// Token: 0x04001176 RID: 4470
		[global::Cpp2ILInjected.Token(Token = "0x4001490")]
		NoMangle = 1,
		// Token: 0x04001177 RID: 4471
		[global::Cpp2ILInjected.Token(Token = "0x4001491")]
		CharSetMask = 6,
		// Token: 0x04001178 RID: 4472
		[global::Cpp2ILInjected.Token(Token = "0x4001492")]
		CharSetNotSpec = 0,
		// Token: 0x04001179 RID: 4473
		[global::Cpp2ILInjected.Token(Token = "0x4001493")]
		CharSetAnsi = 2,
		// Token: 0x0400117A RID: 4474
		[global::Cpp2ILInjected.Token(Token = "0x4001494")]
		CharSetUnicode = 4,
		// Token: 0x0400117B RID: 4475
		[global::Cpp2ILInjected.Token(Token = "0x4001495")]
		CharSetAuto = 6,
		// Token: 0x0400117C RID: 4476
		[global::Cpp2ILInjected.Token(Token = "0x4001496")]
		BestFitUseAssem = 0,
		// Token: 0x0400117D RID: 4477
		[global::Cpp2ILInjected.Token(Token = "0x4001497")]
		BestFitEnabled = 16,
		// Token: 0x0400117E RID: 4478
		[global::Cpp2ILInjected.Token(Token = "0x4001498")]
		BestFitDisabled = 32,
		// Token: 0x0400117F RID: 4479
		[global::Cpp2ILInjected.Token(Token = "0x4001499")]
		BestFitMask = 48,
		// Token: 0x04001180 RID: 4480
		[global::Cpp2ILInjected.Token(Token = "0x400149A")]
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x04001181 RID: 4481
		[global::Cpp2ILInjected.Token(Token = "0x400149B")]
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x04001182 RID: 4482
		[global::Cpp2ILInjected.Token(Token = "0x400149C")]
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x04001183 RID: 4483
		[global::Cpp2ILInjected.Token(Token = "0x400149D")]
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x04001184 RID: 4484
		[global::Cpp2ILInjected.Token(Token = "0x400149E")]
		SupportsLastError = 64,
		// Token: 0x04001185 RID: 4485
		[global::Cpp2ILInjected.Token(Token = "0x400149F")]
		CallConvMask = 1792,
		// Token: 0x04001186 RID: 4486
		[global::Cpp2ILInjected.Token(Token = "0x40014A0")]
		CallConvWinapi = 256,
		// Token: 0x04001187 RID: 4487
		[global::Cpp2ILInjected.Token(Token = "0x40014A1")]
		CallConvCdecl = 512,
		// Token: 0x04001188 RID: 4488
		[global::Cpp2ILInjected.Token(Token = "0x40014A2")]
		CallConvStdcall = 768,
		// Token: 0x04001189 RID: 4489
		[global::Cpp2ILInjected.Token(Token = "0x40014A3")]
		CallConvThiscall = 1024,
		// Token: 0x0400118A RID: 4490
		[global::Cpp2ILInjected.Token(Token = "0x40014A4")]
		CallConvFastcall = 1280,
		// Token: 0x0400118B RID: 4491
		[global::Cpp2ILInjected.Token(Token = "0x40014A5")]
		MaxValue = 65535
	}
}
