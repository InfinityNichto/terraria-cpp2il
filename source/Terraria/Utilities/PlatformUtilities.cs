using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	// Token: 0x02000379 RID: 889
	[global::Cpp2ILInjected.Token(Token = "0x2000507")]
	public static class PlatformUtilities
	{
		// Token: 0x06002CE6 RID: 11494 RVA: 0x0002A0D7 File Offset: 0x000282D7
		[global::Cpp2ILInjected.Token(Token = "0x600311B")]
		[global::Cpp2ILInjected.Address(RVA = "0x130341C", Offset = "0x130341C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SavePng(Stream stream, int width, int height, int imgWidth, int imgHeight, byte[] data)
		{
			throw null;
		}
	}
}
