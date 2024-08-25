using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
	internal static class BinaryCompatibility
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001D2")]
		public static bool TargetsAtLeast_Desktop_V4_5_2
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1930", Offset = "0x1DB1930", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}
	}
}
