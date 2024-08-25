using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000585")]
	public enum CultureTypes
	{
		[global::Cpp2ILInjected.Token(Token = "0x40016D0")]
		NeutralCultures = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40016D1")]
		SpecificCultures = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40016D2")]
		InstalledWin32Cultures = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40016D3")]
		AllCultures = 7,
		[global::Cpp2ILInjected.Token(Token = "0x40016D4")]
		UserCustomCulture = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40016D5")]
		ReplacementCultures = 16,
		[global::System.Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		[global::Cpp2ILInjected.Token(Token = "0x40016D6")]
		WindowsOnlyCultures = 32,
		[global::System.Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		[global::Cpp2ILInjected.Token(Token = "0x40016D7")]
		FrameworkCultures = 64
	}
}
