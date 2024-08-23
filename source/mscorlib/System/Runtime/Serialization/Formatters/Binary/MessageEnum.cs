using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000382 RID: 898
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200042C")]
	[global::System.Serializable]
	internal enum MessageEnum
	{
		// Token: 0x04000EE7 RID: 3815
		[global::Cpp2ILInjected.Token(Token = "0x40011DC")]
		NoArgs = 1,
		// Token: 0x04000EE8 RID: 3816
		[global::Cpp2ILInjected.Token(Token = "0x40011DD")]
		ArgsInline = 2,
		// Token: 0x04000EE9 RID: 3817
		[global::Cpp2ILInjected.Token(Token = "0x40011DE")]
		ArgsIsArray = 4,
		// Token: 0x04000EEA RID: 3818
		[global::Cpp2ILInjected.Token(Token = "0x40011DF")]
		ArgsInArray = 8,
		// Token: 0x04000EEB RID: 3819
		[global::Cpp2ILInjected.Token(Token = "0x40011E0")]
		NoContext = 16,
		// Token: 0x04000EEC RID: 3820
		[global::Cpp2ILInjected.Token(Token = "0x40011E1")]
		ContextInline = 32,
		// Token: 0x04000EED RID: 3821
		[global::Cpp2ILInjected.Token(Token = "0x40011E2")]
		ContextInArray = 64,
		// Token: 0x04000EEE RID: 3822
		[global::Cpp2ILInjected.Token(Token = "0x40011E3")]
		MethodSignatureInArray = 128,
		// Token: 0x04000EEF RID: 3823
		[global::Cpp2ILInjected.Token(Token = "0x40011E4")]
		PropertyInArray = 256,
		// Token: 0x04000EF0 RID: 3824
		[global::Cpp2ILInjected.Token(Token = "0x40011E5")]
		NoReturnValue = 512,
		// Token: 0x04000EF1 RID: 3825
		[global::Cpp2ILInjected.Token(Token = "0x40011E6")]
		ReturnValueVoid = 1024,
		// Token: 0x04000EF2 RID: 3826
		[global::Cpp2ILInjected.Token(Token = "0x40011E7")]
		ReturnValueInline = 2048,
		// Token: 0x04000EF3 RID: 3827
		[global::Cpp2ILInjected.Token(Token = "0x40011E8")]
		ReturnValueInArray = 4096,
		// Token: 0x04000EF4 RID: 3828
		[global::Cpp2ILInjected.Token(Token = "0x40011E9")]
		ExceptionInArray = 8192,
		// Token: 0x04000EF5 RID: 3829
		[global::Cpp2ILInjected.Token(Token = "0x40011EA")]
		GenericMethod = 32768
	}
}
