using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Enums;
using Terraria.ObjectData;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000618")]
	public struct AnchorData
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DAC68", Offset = "0x13DAC68", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 136)]
		public AnchorData(AnchorType type, int count, int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DAC74", Offset = "0x13DAC74", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorTop", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorBottom", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorLeft", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorRight", MemberParameters = new object[] { typeof(AnchorData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool operator ==(AnchorData data1, AnchorData data2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DACA4", Offset = "0x13DACA4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(AnchorData data1, AnchorData data2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DACD4", Offset = "0x13DACD4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DADBC", Offset = "0x13DADBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60035B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DADD4", Offset = "0x13DADD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static AnchorData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400768E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public AnchorType type;

		[global::Cpp2ILInjected.Token(Token = "0x400768F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int tileCount;

		[global::Cpp2ILInjected.Token(Token = "0x4007690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int checkStart;

		[global::Cpp2ILInjected.Token(Token = "0x4007691")]
		public static AnchorData Empty;
	}
}
