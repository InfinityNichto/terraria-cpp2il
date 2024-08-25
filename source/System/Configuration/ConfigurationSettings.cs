using System;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x2000494")]
	public sealed class ConfigurationSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9CD90", Offset = "0x1E9CD90", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ConfigurationSettings()
		{
			throw null;
		}

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
