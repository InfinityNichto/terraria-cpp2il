using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Graphics.Effects;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200024D")]
public class ScreenPostProcessor : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BBF")]
	private int order;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BC0")]
	private Filter filter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BC1")]
	private bool setActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001BC2")]
	public LocalUser User;

	[Cpp2IlInjected.Token(Token = "0x4001BC3")]
	private static int MainTexId;

	[Cpp2IlInjected.Token(Token = "0x4001BC4")]
	private static int SecTexId;

	[Cpp2IlInjected.Token(Token = "0x4001BC5")]
	private static int ThirdTexId;

	[Cpp2IlInjected.Token(Token = "0x4001BC6")]
	private static int ForthTexId;

	[Cpp2IlInjected.Token(Token = "0x4001BC7")]
	private static int _imageSize1Id;

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public static bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x60010B3")]
		[Cpp2IlInjected.Address(RVA = "0xFA4548", Offset = "0xFA4548", VA = "0xFA4548")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60010B4")]
		[Cpp2IlInjected.Address(RVA = "0xFA45C4", Offset = "0xFA45C4", VA = "0xFA45C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public static List<ScreenPostProcessor> Instances
	{
		[Cpp2IlInjected.Token(Token = "0x60010B5")]
		[Cpp2IlInjected.Address(RVA = "0xFA4644", Offset = "0xFA4644", VA = "0xFA4644")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public static List<ScreenPostProcessor> UIInstances
	{
		[Cpp2IlInjected.Token(Token = "0x60010B6")]
		[Cpp2IlInjected.Address(RVA = "0xFA46C0", Offset = "0xFA46C0", VA = "0xFA46C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public static List<Filter> Filters
	{
		[Cpp2IlInjected.Token(Token = "0x60010B7")]
		[Cpp2IlInjected.Address(RVA = "0xFA473C", Offset = "0xFA473C", VA = "0xFA473C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60010B8")]
		[Cpp2IlInjected.Address(RVA = "0xFA47B8", Offset = "0xFA47B8", VA = "0xFA47B8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	private static int countUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x60010BC")]
		[Cpp2IlInjected.Address(RVA = "0xFA4AF8", Offset = "0xFA4AF8", VA = "0xFA4AF8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60010BD")]
		[Cpp2IlInjected.Address(RVA = "0xFA48C4", Offset = "0xFA48C4", VA = "0xFA48C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	private static int renderCheck
	{
		[Cpp2IlInjected.Token(Token = "0x60010BE")]
		[Cpp2IlInjected.Address(RVA = "0xFA4F4C", Offset = "0xFA4F4C", VA = "0xFA4F4C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60010BF")]
		[Cpp2IlInjected.Address(RVA = "0xFA4ECC", Offset = "0xFA4ECC", VA = "0xFA4ECC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010B9")]
	[Cpp2IlInjected.Address(RVA = "0xFA4838", Offset = "0xFA4838", VA = "0xFA4838")]
	public static void BeginUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010BA")]
	[Cpp2IlInjected.Address(RVA = "0xFA4944", Offset = "0xFA4944", VA = "0xFA4944")]
	public static void AddFilter(Filter filter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010BB")]
	[Cpp2IlInjected.Address(RVA = "0xFA4B74", Offset = "0xFA4B74", VA = "0xFA4B74")]
	public static void EndUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010C0")]
	[Cpp2IlInjected.Address(RVA = "0xFA4FC8", Offset = "0xFA4FC8", VA = "0xFA4FC8")]
	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010C1")]
	[Cpp2IlInjected.Address(RVA = "0xFA54F8", Offset = "0xFA54F8", VA = "0xFA54F8")]
	public ScreenPostProcessor()
	{
	}
}
