using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D0")]
[Cpp2IlInjected.Attribute(Name = "DebuggerDisplayAttribute", RVA = "0x385194", Offset = "0x385194")]
public class SnapPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40066AC")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40066AF")]
	private Vector2 _anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40066B0")]
	private Vector2 _offset;

	[Cpp2IlInjected.Token(Token = "0x170006C9")]
	public int Id
	{
		[Cpp2IlInjected.Token(Token = "0x6003622")]
		[Cpp2IlInjected.Address(RVA = "0x1344BC8", Offset = "0x1344BC8", VA = "0x1344BC8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003623")]
		[Cpp2IlInjected.Address(RVA = "0x1344BD0", Offset = "0x1344BD0", VA = "0x1344BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006CA")]
	public Vector2 Position
	{
		[Cpp2IlInjected.Token(Token = "0x6003624")]
		[Cpp2IlInjected.Address(RVA = "0x1344BD8", Offset = "0x1344BD8", VA = "0x1344BD8")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6003625")]
		[Cpp2IlInjected.Address(RVA = "0x1344BEC", Offset = "0x1344BEC", VA = "0x1344BEC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003626")]
	[Cpp2IlInjected.Address(RVA = "0x1344BF8", Offset = "0x1344BF8", VA = "0x1344BF8")]
	public SnapPoint(string name, int id, Vector2 anchor, Vector2 offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003627")]
	[Cpp2IlInjected.Address(RVA = "0x1344C40", Offset = "0x1344C40", VA = "0x1344C40")]
	public void Calculate(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003628")]
	[Cpp2IlInjected.Address(RVA = "0x1344D68", Offset = "0x1344D68", VA = "0x1344D68")]
	public void ThisIsAHackThatChangesTheSnapPointsInfo(Vector2 anchor, Vector2 offset, int id)
	{
	}
}
