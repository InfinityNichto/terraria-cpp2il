using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000324")]
public class Animation
{
	[Cpp2IlInjected.Token(Token = "0x4002C73")]
	private static List<Animation> _animations;

	[Cpp2IlInjected.Token(Token = "0x4002C74")]
	private static Dictionary<Point16, Animation> _temporaryAnimations;

	[Cpp2IlInjected.Token(Token = "0x4002C75")]
	private static List<Point16> _awaitingRemoval;

	[Cpp2IlInjected.Token(Token = "0x4002C76")]
	private static List<Animation> _awaitingAddition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002C77")]
	private bool _temporary;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4002C78")]
	private Point16 _coordinates;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4002C79")]
	private ushort _tileType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002C7A")]
	private int _frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002C7B")]
	private int _frameMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002C7C")]
	private int _frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002C7D")]
	private int _frameCounterMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002C7E")]
	private int[] _frameData;

	[Cpp2IlInjected.Token(Token = "0x6002581")]
	[Cpp2IlInjected.Address(RVA = "0x106D620", Offset = "0x106D620", VA = "0x106D620")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002582")]
	[Cpp2IlInjected.Address(RVA = "0x106D73C", Offset = "0x106D73C", VA = "0x106D73C")]
	private void SetDefaults(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002583")]
	[Cpp2IlInjected.Address(RVA = "0x106D9D4", Offset = "0x106D9D4", VA = "0x106D9D4")]
	public static void NewTemporaryAnimation(int type, ushort tileType, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002584")]
	[Cpp2IlInjected.Address(RVA = "0x106DBB0", Offset = "0x106DBB0", VA = "0x106DBB0")]
	private static void RemoveTemporaryAnimation(short x, short y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002585")]
	[Cpp2IlInjected.Address(RVA = "0x106DC78", Offset = "0x106DC78", VA = "0x106DC78")]
	public static void UpdateAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002586")]
	[Cpp2IlInjected.Address(RVA = "0x106DF08", Offset = "0x106DF08", VA = "0x106DF08")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002587")]
	[Cpp2IlInjected.Address(RVA = "0x106E020", Offset = "0x106E020", VA = "0x106E020")]
	public static bool GetTemporaryFrame(int x, int y, out int frameData)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002588")]
	[Cpp2IlInjected.Address(RVA = "0x106DBA8", Offset = "0x106DBA8", VA = "0x106DBA8")]
	public Animation()
	{
	}
}
