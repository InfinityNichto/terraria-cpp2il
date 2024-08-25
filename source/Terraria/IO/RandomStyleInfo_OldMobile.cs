using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000572")]
	public class RandomStyleInfo_OldMobile
	{
		[global::Cpp2ILInjected.Token(Token = "0x60033DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13459BC", Offset = "0x13459BC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1345A40", Offset = "0x1345A40", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RandomStyleInfo_OldMobile()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003E34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] style;

		[global::Cpp2ILInjected.Token(Token = "0x4003E35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ushort[] X;
	}
}
