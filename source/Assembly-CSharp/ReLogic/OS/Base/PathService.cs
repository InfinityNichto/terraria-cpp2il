using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.OS.Base
{
	// Token: 0x0200072F RID: 1839
	[global::Cpp2ILInjected.Token(Token = "0x2000B2E")]
	internal abstract class PathService : IPathService
	{
		// Token: 0x060046C4 RID: 18116 RVA: 0x0002EA84 File Offset: 0x0002CC84
		[global::Cpp2ILInjected.Token(Token = "0x6005379")]
		[global::Cpp2ILInjected.Address(RVA = "0x9446C4", Offset = "0x9446C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public string ExpandPathVariables(string path)
		{
			throw null;
		}

		// Token: 0x060046C5 RID: 18117
		[global::Cpp2ILInjected.Token(Token = "0x600537A")]
		public abstract string GetStoragePath();

		// Token: 0x060046C6 RID: 18118 RVA: 0x0002EA87 File Offset: 0x0002CC87
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

		// Token: 0x060046C7 RID: 18119 RVA: 0x0002EA8A File Offset: 0x0002CC8A
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
