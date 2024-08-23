using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Base;

namespace ReLogic.OS.Linux
{
	// Token: 0x0200072C RID: 1836
	[global::Cpp2ILInjected.Token(Token = "0x2000B2B")]
	internal class PathService : PathService
	{
		// Token: 0x060046B5 RID: 18101 RVA: 0x0002EA5D File Offset: 0x0002CC5D
		[global::Cpp2ILInjected.Token(Token = "0x600536A")]
		[global::Cpp2ILInjected.Address(RVA = "0x944470", Offset = "0x944470", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string GetStoragePath()
		{
			throw null;
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x0002EA60 File Offset: 0x0002CC60
		[global::Cpp2ILInjected.Token(Token = "0x600536B")]
		[global::Cpp2ILInjected.Address(RVA = "0x944540", Offset = "0x944540", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PathService()
		{
			throw null;
		}
	}
}
