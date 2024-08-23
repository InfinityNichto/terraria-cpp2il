using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x02000375 RID: 885
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x20004AC")]
	public sealed class SettingsProviderAttribute : Attribute
	{
		// Token: 0x06001CCA RID: 7370 RVA: 0x00007F76 File Offset: 0x00006176
		[global::Cpp2ILInjected.Token(Token = "0x6002023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DC18", Offset = "0x1E9DC18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsProviderAttribute(string providerTypeName)
		{
			throw null;
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00007F79 File Offset: 0x00006179
		[global::Cpp2ILInjected.Token(Token = "0x6002024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DC1C", Offset = "0x1E9DC1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SettingsProviderAttribute(Type providerType)
		{
			throw null;
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00007F7C File Offset: 0x0000617C
		[global::Cpp2ILInjected.Token(Token = "0x17000787")]
		public string ProviderTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002025")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9DC20", Offset = "0x1E9DC20", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}
	}
}
