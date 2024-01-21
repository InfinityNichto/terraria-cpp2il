using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.GameContent.Biomes.Desert;

[Cpp2IlInjected.Token(Token = "0x2000604")]
public class DesertDescription
{
	[Cpp2IlInjected.Token(Token = "0x4006C06")]
	public static readonly DesertDescription Invalid;

	[Cpp2IlInjected.Token(Token = "0x4006C07")]
	private static readonly Vector2D DefaultBlockScale;

	[Cpp2IlInjected.Token(Token = "0x4006C08")]
	private const int SCAN_PADDING = 5;

	[Cpp2IlInjected.Token(Token = "0x17000745")]
	public Rectangle CombinedArea
	{
		[Cpp2IlInjected.Token(Token = "0x6003DF7")]
		[Cpp2IlInjected.Address(RVA = "0x1458C6C", Offset = "0x1458C6C", VA = "0x1458C6C")]
		[CompilerGenerated]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6003DF8")]
		[Cpp2IlInjected.Address(RVA = "0x1458C7C", Offset = "0x1458C7C", VA = "0x1458C7C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000746")]
	public Rectangle Desert
	{
		[Cpp2IlInjected.Token(Token = "0x6003DF9")]
		[Cpp2IlInjected.Address(RVA = "0x1458C8C", Offset = "0x1458C8C", VA = "0x1458C8C")]
		[CompilerGenerated]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6003DFA")]
		[Cpp2IlInjected.Address(RVA = "0x1458C9C", Offset = "0x1458C9C", VA = "0x1458C9C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000747")]
	public Rectangle Hive
	{
		[Cpp2IlInjected.Token(Token = "0x6003DFB")]
		[Cpp2IlInjected.Address(RVA = "0x1458CAC", Offset = "0x1458CAC", VA = "0x1458CAC")]
		[CompilerGenerated]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6003DFC")]
		[Cpp2IlInjected.Address(RVA = "0x1458CBC", Offset = "0x1458CBC", VA = "0x1458CBC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000748")]
	public Vector2D BlockScale
	{
		[Cpp2IlInjected.Token(Token = "0x6003DFD")]
		[Cpp2IlInjected.Address(RVA = "0x1458CCC", Offset = "0x1458CCC", VA = "0x1458CCC")]
		[CompilerGenerated]
		get
		{
			return default(Vector2D);
		}
		[Cpp2IlInjected.Token(Token = "0x6003DFE")]
		[Cpp2IlInjected.Address(RVA = "0x1458CDC", Offset = "0x1458CDC", VA = "0x1458CDC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000749")]
	public int BlockColumnCount
	{
		[Cpp2IlInjected.Token(Token = "0x6003DFF")]
		[Cpp2IlInjected.Address(RVA = "0x1458CF4", Offset = "0x1458CF4", VA = "0x1458CF4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E00")]
		[Cpp2IlInjected.Address(RVA = "0x1458CFC", Offset = "0x1458CFC", VA = "0x1458CFC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700074A")]
	public int BlockRowCount
	{
		[Cpp2IlInjected.Token(Token = "0x6003E01")]
		[Cpp2IlInjected.Address(RVA = "0x1458D04", Offset = "0x1458D04", VA = "0x1458D04")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E02")]
		[Cpp2IlInjected.Address(RVA = "0x1458D0C", Offset = "0x1458D0C", VA = "0x1458D0C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700074B")]
	public bool IsValid
	{
		[Cpp2IlInjected.Token(Token = "0x6003E03")]
		[Cpp2IlInjected.Address(RVA = "0x1458D14", Offset = "0x1458D14", VA = "0x1458D14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003E04")]
		[Cpp2IlInjected.Address(RVA = "0x1458D1C", Offset = "0x1458D1C", VA = "0x1458D1C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700074C")]
	public SurfaceMap Surface
	{
		[Cpp2IlInjected.Token(Token = "0x6003E05")]
		[Cpp2IlInjected.Address(RVA = "0x1458D24", Offset = "0x1458D24", VA = "0x1458D24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003E06")]
		[Cpp2IlInjected.Address(RVA = "0x1458D2C", Offset = "0x1458D2C", VA = "0x1458D2C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003E07")]
	[Cpp2IlInjected.Address(RVA = "0x1458D34", Offset = "0x1458D34", VA = "0x1458D34")]
	private DesertDescription()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E08")]
	[Cpp2IlInjected.Address(RVA = "0x1458D3C", Offset = "0x1458D3C", VA = "0x1458D3C")]
	public void UpdateSurfaceMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E09")]
	[Cpp2IlInjected.Address(RVA = "0x1458F50", Offset = "0x1458F50", VA = "0x1458F50")]
	public static DesertDescription CreateFromPlacement(Point origin)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E0A")]
	[Cpp2IlInjected.Address(RVA = "0x14593EC", Offset = "0x14593EC", VA = "0x14593EC")]
	private static bool RowHasInvalidTiles(int startX, int startY, int width)
	{
		return default(bool);
	}
}
