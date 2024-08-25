using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200021B")]
	internal class FileWebRequestCreator : IWebRequestCreate
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38A18", Offset = "0x1F38A18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal FileWebRequestCreator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38A20", Offset = "0x1F38A20", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebRequest Create(Uri uri)
		{
			throw null;
		}
	}
}
