using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Base;

namespace ReLogic.OS.Windows
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B23")]
	internal class PathService : PathService
	{
		[global::Cpp2ILInjected.Token(Token = "0x600534E")]
		[global::Cpp2ILInjected.Address(RVA = "0x942ECC", Offset = "0x942ECC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(Environment.SpecialFolder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string GetStoragePath()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600534F")]
		[global::Cpp2ILInjected.Address(RVA = "0x942F4C", Offset = "0x942F4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PathService()
		{
			throw null;
		}
	}
}
