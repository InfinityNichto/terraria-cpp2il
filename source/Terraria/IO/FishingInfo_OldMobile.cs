using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000569")]
	public class FishingInfo_OldMobile
	{
		[global::Cpp2ILInjected.Token(Token = "0x60033C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x134106C", Offset = "0x134106C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = "loadWorldData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Load(BinaryReader reader, int release)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60033C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13411C8", Offset = "0x13411C8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldMobile), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public FishingInfo_OldMobile()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003C68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private short currentQuest;

		[global::Cpp2ILInjected.Token(Token = "0x4003C69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private bool questCompletedToday;

		[global::Cpp2ILInjected.Token(Token = "0x4003C6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<string> playersCompleted;
	}
}
