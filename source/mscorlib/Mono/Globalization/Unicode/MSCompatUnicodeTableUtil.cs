using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	internal class MSCompatUnicodeTableUtil
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAFA2C", Offset = "0x1AAFA2C", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		static MSCompatUnicodeTableUtil()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
		public static readonly CodePointIndexer Ignorable;

		[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
		public static readonly CodePointIndexer Category;

		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		public static readonly CodePointIndexer Level1;

		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		public static readonly CodePointIndexer Level2;

		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		public static readonly CodePointIndexer Level3;

		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		public static readonly CodePointIndexer CjkCHS;

		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		public static readonly CodePointIndexer Cjk;
	}
}
