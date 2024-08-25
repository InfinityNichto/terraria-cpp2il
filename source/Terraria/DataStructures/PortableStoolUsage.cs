using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200064A")]
	public struct PortableStoolUsage
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D31C", Offset = "0x141D31C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ResetEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60036E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D32C", Offset = "0x141D32C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyEquipFunctional", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetStats(int heightBoost, int visualYOffset, int mapYOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40077F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public bool HasAStool;

		[global::Cpp2ILInjected.Token(Token = "0x40077F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public bool IsInUse;

		[global::Cpp2ILInjected.Token(Token = "0x40077F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int HeightBoost;

		[global::Cpp2ILInjected.Token(Token = "0x40077F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int VisualYOffset;

		[global::Cpp2ILInjected.Token(Token = "0x40077F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int MapYOffset;
	}
}
