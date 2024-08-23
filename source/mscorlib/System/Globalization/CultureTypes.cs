using System;
using Cpp2ILInjected;

namespace System.Globalization
{
	// Token: 0x020004A7 RID: 1191
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000585")]
	public enum CultureTypes
	{
		// Token: 0x04001375 RID: 4981
		[global::Cpp2ILInjected.Token(Token = "0x40016D0")]
		NeutralCultures = 1,
		// Token: 0x04001376 RID: 4982
		[global::Cpp2ILInjected.Token(Token = "0x40016D1")]
		SpecificCultures = 2,
		// Token: 0x04001377 RID: 4983
		[global::Cpp2ILInjected.Token(Token = "0x40016D2")]
		InstalledWin32Cultures = 4,
		// Token: 0x04001378 RID: 4984
		[global::Cpp2ILInjected.Token(Token = "0x40016D3")]
		AllCultures = 7,
		// Token: 0x04001379 RID: 4985
		[global::Cpp2ILInjected.Token(Token = "0x40016D4")]
		UserCustomCulture = 8,
		// Token: 0x0400137A RID: 4986
		[global::Cpp2ILInjected.Token(Token = "0x40016D5")]
		ReplacementCultures = 16,
		// Token: 0x0400137B RID: 4987
		[global::System.Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		[global::Cpp2ILInjected.Token(Token = "0x40016D6")]
		WindowsOnlyCultures = 32,
		// Token: 0x0400137C RID: 4988
		[global::System.Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		[global::Cpp2ILInjected.Token(Token = "0x40016D7")]
		FrameworkCultures = 64
	}
}
