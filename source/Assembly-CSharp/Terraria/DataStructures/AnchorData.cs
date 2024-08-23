using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Enums;
using Terraria.ObjectData;

namespace Terraria.DataStructures
{
	// Token: 0x0200041D RID: 1053
	[global::Cpp2ILInjected.Token(Token = "0x2000618")]
	public struct AnchorData
	{
		// Token: 0x06003096 RID: 12438 RVA: 0x0002AB0C File Offset: 0x00028D0C
		[global::Cpp2ILInjected.Token(Token = "0x60035B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DAC68", Offset = "0x13DAC68", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 136)]
		public AnchorData(AnchorType type, int count, int start)
		{
			throw null;
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0002AB0F File Offset: 0x00028D0F
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

		// Token: 0x06003098 RID: 12440 RVA: 0x0002AB12 File Offset: 0x00028D12
		[global::Cpp2ILInjected.Token(Token = "0x60035B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DACA4", Offset = "0x13DACA4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(AnchorData data1, AnchorData data2)
		{
			throw null;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0002AB15 File Offset: 0x00028D15
		[global::Cpp2ILInjected.Token(Token = "0x60035B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DACD4", Offset = "0x13DACD4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0002AB18 File Offset: 0x00028D18
		[global::Cpp2ILInjected.Token(Token = "0x60035B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DADBC", Offset = "0x13DADBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x0002AB1B File Offset: 0x00028D1B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60035B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DADD4", Offset = "0x13DADD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static AnchorData()
		{
			throw null;
		}

		// Token: 0x040062A4 RID: 25252
		[global::Cpp2ILInjected.Token(Token = "0x400768E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public AnchorType type;

		// Token: 0x040062A5 RID: 25253
		[global::Cpp2ILInjected.Token(Token = "0x400768F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int tileCount;

		// Token: 0x040062A6 RID: 25254
		[global::Cpp2ILInjected.Token(Token = "0x4007690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int checkStart;

		// Token: 0x040062A7 RID: 25255
		[global::Cpp2ILInjected.Token(Token = "0x4007691")]
		public static AnchorData Empty;
	}
}
