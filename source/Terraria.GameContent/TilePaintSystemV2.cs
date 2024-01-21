using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000559")]
public class TilePaintSystemV2
{
	[Cpp2IlInjected.Token(Token = "0x200097F")]
	public struct TileVariationkey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008C1B")]
		public int TileType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008C1C")]
		public int TileStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C1D")]
		public int PaintColor;

		[Cpp2IlInjected.Token(Token = "0x6004DE2")]
		[Cpp2IlInjected.Address(RVA = "0x39E0A8", Offset = "0x39E0A8", VA = "0x39E0A8")]
		public bool Equals(TileVariationkey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE3")]
		[Cpp2IlInjected.Address(RVA = "0x39E0DC", Offset = "0x39E0DC", VA = "0x39E0DC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE4")]
		[Cpp2IlInjected.Address(RVA = "0x39E0E4", Offset = "0x39E0E4", VA = "0x39E0E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE5")]
		[Cpp2IlInjected.Address(RVA = "0x127AE10", Offset = "0x127AE10", VA = "0x127AE10")]
		public static bool operator ==(TileVariationkey left, TileVariationkey right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE6")]
		[Cpp2IlInjected.Address(RVA = "0x127AE38", Offset = "0x127AE38", VA = "0x127AE38")]
		public static bool operator !=(TileVariationkey left, TileVariationkey right)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000980")]
	public struct WallVariationKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008C1E")]
		public int WallType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008C1F")]
		public int PaintColor;

		[Cpp2IlInjected.Token(Token = "0x6004DE7")]
		[Cpp2IlInjected.Address(RVA = "0x39E168", Offset = "0x39E168", VA = "0x39E168")]
		public bool Equals(WallVariationKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE8")]
		[Cpp2IlInjected.Address(RVA = "0x39E18C", Offset = "0x39E18C", VA = "0x39E18C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DE9")]
		[Cpp2IlInjected.Address(RVA = "0x39E194", Offset = "0x39E194", VA = "0x39E194", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEA")]
		[Cpp2IlInjected.Address(RVA = "0x127B098", Offset = "0x127B098", VA = "0x127B098")]
		public static bool operator ==(WallVariationKey left, WallVariationKey right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEB")]
		[Cpp2IlInjected.Address(RVA = "0x127B0B0", Offset = "0x127B0B0", VA = "0x127B0B0")]
		public static bool operator !=(WallVariationKey left, WallVariationKey right)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000981")]
	public struct TreeFoliageVariantKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008C20")]
		public int TextureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008C21")]
		public int TextureStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C22")]
		public int PaintColor;

		[Cpp2IlInjected.Token(Token = "0x6004DEC")]
		[Cpp2IlInjected.Address(RVA = "0x39E108", Offset = "0x39E108", VA = "0x39E108")]
		public bool Equals(TreeFoliageVariantKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DED")]
		[Cpp2IlInjected.Address(RVA = "0x39E13C", Offset = "0x39E13C", VA = "0x39E13C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEE")]
		[Cpp2IlInjected.Address(RVA = "0x39E144", Offset = "0x39E144", VA = "0x39E144", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DEF")]
		[Cpp2IlInjected.Address(RVA = "0x127AF68", Offset = "0x127AF68", VA = "0x127AF68")]
		public static bool operator ==(TreeFoliageVariantKey left, TreeFoliageVariantKey right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004DF0")]
		[Cpp2IlInjected.Address(RVA = "0x127AF90", Offset = "0x127AF90", VA = "0x127AF90")]
		public static bool operator !=(TreeFoliageVariantKey left, TreeFoliageVariantKey right)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400691F")]
	private Effect TileShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006920")]
	private TreePaintSystemData PaintSystemData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006921")]
	private TileShader[] specialShaders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006922")]
	private EffectPass[] TileShaders;

	[Cpp2IlInjected.Token(Token = "0x6003A21")]
	[Cpp2IlInjected.Address(RVA = "0x127A6CC", Offset = "0x127A6CC", VA = "0x127A6CC")]
	public EffectPass GetTileEffect(int tileType, int tileStyle, int paintColor)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A22")]
	[Cpp2IlInjected.Address(RVA = "0x127A718", Offset = "0x127A718", VA = "0x127A718")]
	public EffectPass GetWallEffect(int wallType, int paintColor)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A23")]
	[Cpp2IlInjected.Address(RVA = "0x127A82C", Offset = "0x127A82C", VA = "0x127A82C")]
	public EffectPass GetTreeBranchEffect(int treeTopIndex, int treeTopStyle, int paintColor)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A24")]
	[Cpp2IlInjected.Address(RVA = "0x127A860", Offset = "0x127A860", VA = "0x127A860")]
	public EffectPass GetTreeTopEffect(int treeTopIndex, int treeTopStyle, int paintColor)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A25")]
	[Cpp2IlInjected.Address(RVA = "0x127A894", Offset = "0x127A894", VA = "0x127A894")]
	private Effect InitShader(TreePaintingSettings settings)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A26")]
	[Cpp2IlInjected.Address(RVA = "0x127AAB8", Offset = "0x127AAB8", VA = "0x127AAB8")]
	public void CreateTileShaders()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A27")]
	[Cpp2IlInjected.Address(RVA = "0x127A728", Offset = "0x127A728", VA = "0x127A728")]
	public EffectPass GetRealShader(int paintColor, TreePaintingSettings settings)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A28")]
	[Cpp2IlInjected.Address(RVA = "0x127A700", Offset = "0x127A700", VA = "0x127A700")]
	public EffectPass GetShader(int paintColor, TreePaintingSettings settings)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A29")]
	[Cpp2IlInjected.Address(RVA = "0x127AC60", Offset = "0x127AC60", VA = "0x127AC60")]
	public TilePaintSystemV2()
	{
	}
}
