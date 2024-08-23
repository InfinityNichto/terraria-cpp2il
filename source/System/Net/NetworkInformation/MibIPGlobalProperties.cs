using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001E3 RID: 483
	[global::Cpp2ILInjected.Token(Token = "0x20002C5")]
	internal class MibIPGlobalProperties : UnixIPGlobalProperties
	{
		// Token: 0x060010CF RID: 4303 RVA: 0x00005E6A File Offset: 0x0000406A
		[global::Cpp2ILInjected.Token(Token = "0x60012C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E207DC", Offset = "0x1E207DC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public MibIPGlobalProperties(string procDir)
		{
			throw null;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00005E6D File Offset: 0x0000406D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60012C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20944", Offset = "0x1E20944", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MibIPGlobalProperties()
		{
			throw null;
		}

		// Token: 0x04000B39 RID: 2873
		[global::Cpp2ILInjected.Token(Token = "0x4000F0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string StatisticsFile;

		// Token: 0x04000B3A RID: 2874
		[global::Cpp2ILInjected.Token(Token = "0x4000F0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string StatisticsFileIPv6;

		// Token: 0x04000B3B RID: 2875
		[global::Cpp2ILInjected.Token(Token = "0x4000F0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly string TcpFile;

		// Token: 0x04000B3C RID: 2876
		[global::Cpp2ILInjected.Token(Token = "0x4000F0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly string Tcp6File;

		// Token: 0x04000B3D RID: 2877
		[global::Cpp2ILInjected.Token(Token = "0x4000F0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly string UdpFile;

		// Token: 0x04000B3E RID: 2878
		[global::Cpp2ILInjected.Token(Token = "0x4000F0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly string Udp6File;

		// Token: 0x04000B3F RID: 2879
		[global::Cpp2ILInjected.Token(Token = "0x4000F10")]
		private static readonly char[] wsChars;
	}
}
