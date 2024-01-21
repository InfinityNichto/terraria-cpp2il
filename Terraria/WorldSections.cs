using System.Collections;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000356")]
public class WorldSections
{
	[Cpp2IlInjected.Token(Token = "0x2000880")]
	private struct IterationState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008047")]
		public Vector2 centerPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008048")]
		public int X;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008049")]
		public int Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400804A")]
		public int leg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400804B")]
		public int xDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400804C")]
		public int yDir;

		[Cpp2IlInjected.Token(Token = "0x6004B4D")]
		[Cpp2IlInjected.Address(RVA = "0x39C3BC", Offset = "0x39C3BC", VA = "0x39C3BC")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40030B1")]
	public const int BitIndex_SectionLoaded = 0;

	[Cpp2IlInjected.Token(Token = "0x40030B2")]
	public const int BitIndex_SectionFramed = 1;

	[Cpp2IlInjected.Token(Token = "0x40030B3")]
	public const int BitIndex_SectionMapDrawn = 2;

	[Cpp2IlInjected.Token(Token = "0x40030B4")]
	public const int BitIndex_SectionNeedsRefresh = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40030B5")]
	private int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40030B6")]
	private int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40030B7")]
	private BitsByte[] data;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40030B8")]
	public int mapSectionsLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40030B9")]
	public int frameSectionsLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40030BA")]
	private int _sectionsNeedingRefresh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40030BB")]
	public IEnumerator CurrentMapSection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40030BC")]
	private IterationState prevFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40030BD")]
	private IterationState prevMap;

	[Cpp2IlInjected.Token(Token = "0x17000593")]
	public bool AnyUnfinishedSections
	{
		[Cpp2IlInjected.Token(Token = "0x6002C49")]
		[Cpp2IlInjected.Address(RVA = "0x10C8CD8", Offset = "0x10C8CD8", VA = "0x10C8CD8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000594")]
	public bool AnyNeedRefresh
	{
		[Cpp2IlInjected.Token(Token = "0x6002C4A")]
		[Cpp2IlInjected.Address(RVA = "0x10C8CEC", Offset = "0x10C8CEC", VA = "0x10C8CEC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000595")]
	public int TotalMapSections
	{
		[Cpp2IlInjected.Token(Token = "0x6002C4B")]
		[Cpp2IlInjected.Address(RVA = "0x10C8D00", Offset = "0x10C8D00", VA = "0x10C8D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C48")]
	[Cpp2IlInjected.Address(RVA = "0x10C8B64", Offset = "0x10C8B64", VA = "0x10C8B64")]
	public WorldSections(int numSectionsX, int numSectionsY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C4C")]
	[Cpp2IlInjected.Address(RVA = "0x10C8D10", Offset = "0x10C8D10", VA = "0x10C8D10")]
	public void SetSectionAsRefreshed(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C4D")]
	[Cpp2IlInjected.Address(RVA = "0x10C8D80", Offset = "0x10C8D80", VA = "0x10C8D80")]
	public bool SectionNeedsRefresh(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C4E")]
	[Cpp2IlInjected.Address(RVA = "0x10C8DC8", Offset = "0x10C8DC8", VA = "0x10C8DC8")]
	public void SetAllFramedSectionsAsNeedingRefresh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C4F")]
	[Cpp2IlInjected.Address(RVA = "0x10C8E44", Offset = "0x10C8E44", VA = "0x10C8E44")]
	public bool SectionLoaded(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C50")]
	[Cpp2IlInjected.Address(RVA = "0x10C8E8C", Offset = "0x10C8E8C", VA = "0x10C8E8C")]
	public bool SectionFramed(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C51")]
	[Cpp2IlInjected.Address(RVA = "0x10C8ED4", Offset = "0x10C8ED4", VA = "0x10C8ED4")]
	public bool MapSectionDrawn(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C52")]
	[Cpp2IlInjected.Address(RVA = "0x10C8F1C", Offset = "0x10C8F1C", VA = "0x10C8F1C")]
	public void ClearMapDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C53")]
	[Cpp2IlInjected.Address(RVA = "0x10C8FC4", Offset = "0x10C8FC4", VA = "0x10C8FC4")]
	public void SetSectionFramed(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C54")]
	[Cpp2IlInjected.Address(RVA = "0x10C908C", Offset = "0x10C908C", VA = "0x10C908C")]
	public void SetSectionLoaded(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C55")]
	[Cpp2IlInjected.Address(RVA = "0x10C90C8", Offset = "0x10C90C8", VA = "0x10C90C8")]
	private void SetSectionLoaded(ref BitsByte section)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C56")]
	[Cpp2IlInjected.Address(RVA = "0x10C913C", Offset = "0x10C913C", VA = "0x10C913C")]
	public void SetAllSectionsLoaded()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C57")]
	[Cpp2IlInjected.Address(RVA = "0x10C9184", Offset = "0x10C9184", VA = "0x10C9184")]
	public void SetTilesLoaded(int startX, int startY, int endXInclusive, int endYInclusive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C58")]
	[Cpp2IlInjected.Address(RVA = "0x10C9288", Offset = "0x10C9288", VA = "0x10C9288")]
	public bool GetNextMapDraw(Vector2 playerPos, out int x, out int y)
	{
		return default(bool);
	}
}
