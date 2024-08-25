using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B3E")]
	public class ContentRejectionFromFailedLoad_ByAssetExtensionType : IRejectionReason
	{
		[global::Cpp2ILInjected.Token(Token = "0x60053DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x945E68", Offset = "0x945E68", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetReason()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60053DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x945EA8", Offset = "0x945EA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContentRejectionFromFailedLoad_ByAssetExtensionType()
		{
			throw null;
		}
	}
}
