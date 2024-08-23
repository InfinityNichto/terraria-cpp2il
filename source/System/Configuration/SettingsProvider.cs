using System;
using System.Configuration.Provider;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x02000324 RID: 804
	[global::Cpp2ILInjected.Token(Token = "0x2000458")]
	public abstract class SettingsProvider : ProviderBase
	{
		// Token: 0x06001ADD RID: 6877 RVA: 0x000079E2 File Offset: 0x00005BE2
		[global::Cpp2ILInjected.Token(Token = "0x6001E36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E975CC", Offset = "0x1E975CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SettingsProvider()
		{
			throw null;
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001ADE RID: 6878
		// (set) Token: 0x06001ADF RID: 6879
		[global::Cpp2ILInjected.Token(Token = "0x170006D2")]
		public abstract string ApplicationName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E37")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001E38")]
			set;
		}

		// Token: 0x06001AE0 RID: 6880
		[global::Cpp2ILInjected.Token(Token = "0x6001E39")]
		public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);

		// Token: 0x06001AE1 RID: 6881
		[global::Cpp2ILInjected.Token(Token = "0x6001E3A")]
		public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);
	}
}
