using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.OS.Base;

namespace ReLogic.OS.OSX
{
	// Token: 0x02000729 RID: 1833
	[global::Cpp2ILInjected.Token(Token = "0x2000B28")]
	internal class PathService : PathService
	{
		// Token: 0x060046A9 RID: 18089 RVA: 0x0002EA39 File Offset: 0x0002CC39
		[global::Cpp2ILInjected.Token(Token = "0x600535E")]
		[global::Cpp2ILInjected.Address(RVA = "0x943B1C", Offset = "0x943B1C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string GetStoragePath()
		{
			throw null;
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		[global::Cpp2ILInjected.Token(Token = "0x600535F")]
		[global::Cpp2ILInjected.Address(RVA = "0x943BB8", Offset = "0x943BB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PathService()
		{
			throw null;
		}
	}
}
