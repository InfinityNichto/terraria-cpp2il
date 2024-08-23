using System;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	// Token: 0x0200035D RID: 861
	[global::Cpp2ILInjected.Token(Token = "0x2000494")]
	public sealed class ConfigurationSettings
	{
		// Token: 0x06001C78 RID: 7288 RVA: 0x00007E9E File Offset: 0x0000609E
		[global::Cpp2ILInjected.Token(Token = "0x6001FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9CD90", Offset = "0x1E9CD90", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ConfigurationSettings()
		{
			throw null;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00007EA1 File Offset: 0x000060A1
		[global::Cpp2ILInjected.Token(Token = "0x1700076F")]
		public static NameValueCollection AppSettings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9CDC8", Offset = "0x1E9CDC8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00007EA4 File Offset: 0x000060A4
		[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
		[global::Cpp2ILInjected.Token(Token = "0x6001FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9CE00", Offset = "0x1E9CE00", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static object GetConfig(string sectionName)
		{
			throw null;
		}
	}
}
