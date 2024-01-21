using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000321")]
public class PopupText
{
	[Cpp2IlInjected.Token(Token = "0x4002BE4")]
	public static int activeTime;

	[Cpp2IlInjected.Token(Token = "0x4002BE5")]
	public static int numActive;

	[Cpp2IlInjected.Token(Token = "0x4002BE6")]
	public static int sonarText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002BE7")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002BE8")]
	public Vector2 velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002BE9")]
	public float alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002BEA")]
	public int alphaDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002BEB")]
	public string name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002BEC")]
	public long stack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002BED")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002BEE")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002BEF")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002BF0")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002BF1")]
	public int lifeTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002BF2")]
	public bool NoStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4002BF3")]
	public bool coinText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4002BF4")]
	public long coinValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4002BF5")]
	public bool expert;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4002BF6")]
	public bool master;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4002BF7")]
	public bool sonar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4002BF8")]
	public PopupTextContext context;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4002BF9")]
	public int npcNetID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4002BFA")]
	public bool freeAdvanced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4002BFB")]
	private Vector2 cachedSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4002BFC")]
	private string cachedName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4002BFD")]
	private long cachedStack;

	[Cpp2IlInjected.Token(Token = "0x17000520")]
	public bool notActuallyAnItem
	{
		[Cpp2IlInjected.Token(Token = "0x6002438")]
		[Cpp2IlInjected.Address(RVA = "0x865660", Offset = "0x865660", VA = "0x865660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000521")]
	public static float TargetScale
	{
		[Cpp2IlInjected.Token(Token = "0x6002439")]
		[Cpp2IlInjected.Address(RVA = "0x865684", Offset = "0x865684", VA = "0x865684")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600243A")]
	[Cpp2IlInjected.Address(RVA = "0x865768", Offset = "0x865768", VA = "0x865768")]
	public static void ClearSonarText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600243B")]
	[Cpp2IlInjected.Address(RVA = "0x8658D4", Offset = "0x8658D4", VA = "0x8658D4")]
	public static void ResetText(PopupText text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600243C")]
	[Cpp2IlInjected.Address(RVA = "0x86590C", Offset = "0x86590C", VA = "0x86590C")]
	public static int NewText(AdvancedPopupRequest request, Vector2 position)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600243D")]
	[Cpp2IlInjected.Address(RVA = "0x865D1C", Offset = "0x865D1C", VA = "0x865D1C")]
	public static int NewText(PopupTextContext context, int npcNetID, Vector2 position, bool stay5TimesLonger)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600243E")]
	[Cpp2IlInjected.Address(RVA = "0x8660C4", Offset = "0x8660C4", VA = "0x8660C4")]
	public static int NewText(PopupTextContext context, Item newItem, int stack, bool noStack = false, bool longText = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600243F")]
	[Cpp2IlInjected.Address(RVA = "0x866EF0", Offset = "0x866EF0", VA = "0x866EF0")]
	private void AddToCoinValue(long addedValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002440")]
	[Cpp2IlInjected.Address(RVA = "0x865BAC", Offset = "0x865BAC", VA = "0x865BAC")]
	private static int FindNextItemTextSlot()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002441")]
	[Cpp2IlInjected.Address(RVA = "0x8675D0", Offset = "0x8675D0", VA = "0x8675D0")]
	public static void AssignAsSonarText(int sonarTextIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002442")]
	[Cpp2IlInjected.Address(RVA = "0x866FBC", Offset = "0x866FBC", VA = "0x866FBC")]
	public static string ValueToName(long coinValue)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002443")]
	[Cpp2IlInjected.Address(RVA = "0x8672BC", Offset = "0x8672BC", VA = "0x8672BC")]
	private void ValueToName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002444")]
	[Cpp2IlInjected.Address(RVA = "0x8676D0", Offset = "0x8676D0", VA = "0x8676D0")]
	public void Update(int whoAmI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002445")]
	[Cpp2IlInjected.Address(RVA = "0x868244", Offset = "0x868244", VA = "0x868244")]
	public static void UpdateItemText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002446")]
	[Cpp2IlInjected.Address(RVA = "0x868350", Offset = "0x868350", VA = "0x868350")]
	public static void ClearAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002447")]
	[Cpp2IlInjected.Address(RVA = "0x868470", Offset = "0x868470", VA = "0x868470")]
	public PopupText()
	{
	}
}
