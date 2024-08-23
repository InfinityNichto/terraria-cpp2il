using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000043 RID: 67
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	internal class SharedUtils
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00005908 File Offset: 0x00003B08
		[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73730", Offset = "0x1A73730", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int URShift(int number, int bits)
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000590B File Offset: 0x00003B0B
		[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74558", Offset = "0x1A74558", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ReadInput(TextReader sourceTextReader, byte[] target, int start, int count)
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000590E File Offset: 0x00003B0E
		[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74624", Offset = "0x1A74624", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static byte[] ToByteArray(string sourceString)
		{
			throw null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00005911 File Offset: 0x00003B11
		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7464C", Offset = "0x1A7464C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static char[] ToCharArray(byte[] byteArray)
		{
			throw null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00005914 File Offset: 0x00003B14
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74674", Offset = "0x1A74674", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SharedUtils()
		{
			throw null;
		}
	}
}
