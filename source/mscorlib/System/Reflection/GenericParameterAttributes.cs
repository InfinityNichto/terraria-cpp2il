using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x02000416 RID: 1046
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004D5")]
	public enum GenericParameterAttributes
	{
		// Token: 0x0400108E RID: 4238
		[global::Cpp2ILInjected.Token(Token = "0x40013A8")]
		None = 0,
		// Token: 0x0400108F RID: 4239
		[global::Cpp2ILInjected.Token(Token = "0x40013A9")]
		VarianceMask = 3,
		// Token: 0x04001090 RID: 4240
		[global::Cpp2ILInjected.Token(Token = "0x40013AA")]
		Covariant = 1,
		// Token: 0x04001091 RID: 4241
		[global::Cpp2ILInjected.Token(Token = "0x40013AB")]
		Contravariant = 2,
		// Token: 0x04001092 RID: 4242
		[global::Cpp2ILInjected.Token(Token = "0x40013AC")]
		SpecialConstraintMask = 28,
		// Token: 0x04001093 RID: 4243
		[global::Cpp2ILInjected.Token(Token = "0x40013AD")]
		ReferenceTypeConstraint = 4,
		// Token: 0x04001094 RID: 4244
		[global::Cpp2ILInjected.Token(Token = "0x40013AE")]
		NotNullableValueTypeConstraint = 8,
		// Token: 0x04001095 RID: 4245
		[global::Cpp2ILInjected.Token(Token = "0x40013AF")]
		DefaultConstructorConstraint = 16
	}
}
