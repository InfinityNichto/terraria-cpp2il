using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.OS.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B2E")]
	internal abstract class PathService : IPathService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005379")]
		[global::Cpp2ILInjected.Address(RVA = "0x9446C4", Offset = "0x9446C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public string ExpandPathVariables(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600537A")]
		public abstract string GetStoragePath();

		[global::Cpp2ILInjected.Token(Token = "0x600537B")]
		[global::Cpp2ILInjected.Address(RVA = "0x9446D0", Offset = "0x9446D0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetStoragePath(string subfolder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600537C")]
		[global::Cpp2ILInjected.Address(RVA = "0x942F54", Offset = "0x942F54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected PathService()
		{
			throw null;
		}
	}
}
