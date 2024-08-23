using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Content
{
	// Token: 0x02000740 RID: 1856
	[global::Cpp2ILInjected.Token(Token = "0x2000B40")]
	internal static class AssetPathHelper
	{
		// Token: 0x06004727 RID: 18215 RVA: 0x0002EB71 File Offset: 0x0002CD71
		[global::Cpp2ILInjected.Token(Token = "0x60053E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x946044", Offset = "0x946044", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "Request", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		public static string CleanPath(string path)
		{
			throw null;
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0002EB74 File Offset: 0x0002CD74
		[global::Cpp2ILInjected.Token(Token = "0x60053E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x946054", Offset = "0x946054", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int CollapseParentDirectory(ref string path, int position, int removeLength)
		{
			throw null;
		}
	}
}
