using System;
using Cpp2ILInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000396 RID: 918
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000440")]
	[global::System.Serializable]
	public enum UnmanagedType
	{
		// Token: 0x04000F42 RID: 3906
		[global::Cpp2ILInjected.Token(Token = "0x4001237")]
		Bool = 2,
		// Token: 0x04000F43 RID: 3907
		[global::Cpp2ILInjected.Token(Token = "0x4001238")]
		I1,
		// Token: 0x04000F44 RID: 3908
		[global::Cpp2ILInjected.Token(Token = "0x4001239")]
		U1,
		// Token: 0x04000F45 RID: 3909
		[global::Cpp2ILInjected.Token(Token = "0x400123A")]
		I2,
		// Token: 0x04000F46 RID: 3910
		[global::Cpp2ILInjected.Token(Token = "0x400123B")]
		U2,
		// Token: 0x04000F47 RID: 3911
		[global::Cpp2ILInjected.Token(Token = "0x400123C")]
		I4,
		// Token: 0x04000F48 RID: 3912
		[global::Cpp2ILInjected.Token(Token = "0x400123D")]
		U4,
		// Token: 0x04000F49 RID: 3913
		[global::Cpp2ILInjected.Token(Token = "0x400123E")]
		I8,
		// Token: 0x04000F4A RID: 3914
		[global::Cpp2ILInjected.Token(Token = "0x400123F")]
		U8,
		// Token: 0x04000F4B RID: 3915
		[global::Cpp2ILInjected.Token(Token = "0x4001240")]
		R4,
		// Token: 0x04000F4C RID: 3916
		[global::Cpp2ILInjected.Token(Token = "0x4001241")]
		R8,
		// Token: 0x04000F4D RID: 3917
		[global::Cpp2ILInjected.Token(Token = "0x4001242")]
		Currency = 15,
		// Token: 0x04000F4E RID: 3918
		[global::Cpp2ILInjected.Token(Token = "0x4001243")]
		BStr = 19,
		// Token: 0x04000F4F RID: 3919
		[global::Cpp2ILInjected.Token(Token = "0x4001244")]
		LPStr,
		// Token: 0x04000F50 RID: 3920
		[global::Cpp2ILInjected.Token(Token = "0x4001245")]
		LPWStr,
		// Token: 0x04000F51 RID: 3921
		[global::Cpp2ILInjected.Token(Token = "0x4001246")]
		LPTStr,
		// Token: 0x04000F52 RID: 3922
		[global::Cpp2ILInjected.Token(Token = "0x4001247")]
		ByValTStr,
		// Token: 0x04000F53 RID: 3923
		[global::Cpp2ILInjected.Token(Token = "0x4001248")]
		IUnknown = 25,
		// Token: 0x04000F54 RID: 3924
		[global::Cpp2ILInjected.Token(Token = "0x4001249")]
		IDispatch,
		// Token: 0x04000F55 RID: 3925
		[global::Cpp2ILInjected.Token(Token = "0x400124A")]
		Struct,
		// Token: 0x04000F56 RID: 3926
		[global::Cpp2ILInjected.Token(Token = "0x400124B")]
		Interface,
		// Token: 0x04000F57 RID: 3927
		[global::Cpp2ILInjected.Token(Token = "0x400124C")]
		SafeArray,
		// Token: 0x04000F58 RID: 3928
		[global::Cpp2ILInjected.Token(Token = "0x400124D")]
		ByValArray,
		// Token: 0x04000F59 RID: 3929
		[global::Cpp2ILInjected.Token(Token = "0x400124E")]
		SysInt,
		// Token: 0x04000F5A RID: 3930
		[global::Cpp2ILInjected.Token(Token = "0x400124F")]
		SysUInt,
		// Token: 0x04000F5B RID: 3931
		[global::Cpp2ILInjected.Token(Token = "0x4001250")]
		VBByRefStr = 34,
		// Token: 0x04000F5C RID: 3932
		[global::Cpp2ILInjected.Token(Token = "0x4001251")]
		AnsiBStr,
		// Token: 0x04000F5D RID: 3933
		[global::Cpp2ILInjected.Token(Token = "0x4001252")]
		TBStr,
		// Token: 0x04000F5E RID: 3934
		[global::Cpp2ILInjected.Token(Token = "0x4001253")]
		VariantBool,
		// Token: 0x04000F5F RID: 3935
		[global::Cpp2ILInjected.Token(Token = "0x4001254")]
		FunctionPtr,
		// Token: 0x04000F60 RID: 3936
		[global::Cpp2ILInjected.Token(Token = "0x4001255")]
		AsAny = 40,
		// Token: 0x04000F61 RID: 3937
		[global::Cpp2ILInjected.Token(Token = "0x4001256")]
		LPArray = 42,
		// Token: 0x04000F62 RID: 3938
		[global::Cpp2ILInjected.Token(Token = "0x4001257")]
		LPStruct,
		// Token: 0x04000F63 RID: 3939
		[global::Cpp2ILInjected.Token(Token = "0x4001258")]
		CustomMarshaler,
		// Token: 0x04000F64 RID: 3940
		[global::Cpp2ILInjected.Token(Token = "0x4001259")]
		Error,
		// Token: 0x04000F65 RID: 3941
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x400125A")]
		IInspectable,
		// Token: 0x04000F66 RID: 3942
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x400125B")]
		HString,
		// Token: 0x04000F67 RID: 3943
		[ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x400125C")]
		LPUTF8Str
	}
}
