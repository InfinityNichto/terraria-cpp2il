using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

namespace ReLogic.Utilities
{
	// Token: 0x0200070E RID: 1806
	[global::Cpp2ILInjected.Token(Token = "0x2000B02")]
	public static class Crc32
	{
		// Token: 0x060045DD RID: 17885 RVA: 0x0002E80B File Offset: 0x0002CA0B
		[global::Cpp2ILInjected.Token(Token = "0x6005275")]
		[global::Cpp2ILInjected.Address(RVA = "0x93DE6C", Offset = "0x93DE6C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "SetSeed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Calculate(string value)
		{
			throw null;
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x0002E80E File Offset: 0x0002CA0E
		[global::Cpp2ILInjected.Token(Token = "0x6005276")]
		[global::Cpp2ILInjected.Address(RVA = "0x93DF2C", Offset = "0x93DF2C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Calculate(string value, int baseHash)
		{
			throw null;
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x0002E811 File Offset: 0x0002CA11
		[global::Cpp2ILInjected.Token(Token = "0x6005277")]
		[global::Cpp2ILInjected.Address(RVA = "0x93DFE8", Offset = "0x93DFE8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Calculate(byte[] value)
		{
			throw null;
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x0002E814 File Offset: 0x0002CA14
		[global::Cpp2ILInjected.Token(Token = "0x6005278")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E0A0", Offset = "0x93E0A0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static int Calculate(byte* value, long length)
		{
			throw null;
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x0002E817 File Offset: 0x0002CA17
		[global::Cpp2ILInjected.Token(Token = "0x6005279")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E158", Offset = "0x93E158", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Calculate(byte[] value, int baseHash)
		{
			throw null;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x0002E81A File Offset: 0x0002CA1A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600527A")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E20C", Offset = "0x93E20C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Crc32()
		{
			throw null;
		}

		// Token: 0x04007148 RID: 29000
		[global::Cpp2ILInjected.Token(Token = "0x4008AC2")]
		private static readonly uint[] Tabs;
	}
}
