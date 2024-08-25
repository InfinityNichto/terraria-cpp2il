using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004D5")]
	public enum GenericParameterAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40013A8")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40013A9")]
		VarianceMask = 3,
		[global::Cpp2ILInjected.Token(Token = "0x40013AA")]
		Covariant = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40013AB")]
		Contravariant = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40013AC")]
		SpecialConstraintMask = 28,
		[global::Cpp2ILInjected.Token(Token = "0x40013AD")]
		ReferenceTypeConstraint = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40013AE")]
		NotNullableValueTypeConstraint = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40013AF")]
		DefaultConstructorConstraint = 16
	}
}
