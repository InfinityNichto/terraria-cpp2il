using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Social.Steam;

[Cpp2IlInjected.Token(Token = "0x2000386")]
public class CoreSocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x40031BB")]
	private static CoreSocialModule _instance;

	[Cpp2IlInjected.Token(Token = "0x40031BC")]
	public const int SteamAppId = 105600;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031BD")]
	private bool IsSteamValid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031BF")]
	private object _steamTickLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40031C0")]
	private object _steamCallbackLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40031C1")]
	private bool _skipPulsing;

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public static event Action OnTick
	{
		[Cpp2IlInjected.Token(Token = "0x6002D5C")]
		[Cpp2IlInjected.Address(RVA = "0x14E53F8", Offset = "0x14E53F8", VA = "0x14E53F8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002D5D")]
		[Cpp2IlInjected.Address(RVA = "0x14E54C0", Offset = "0x14E54C0", VA = "0x14E54C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002D5E")]
	[Cpp2IlInjected.Address(RVA = "0x14E5588", Offset = "0x14E5588", VA = "0x14E5588")]
	public static void SetSkipPulsing(bool shouldSkipPausing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D5F")]
	[Cpp2IlInjected.Address(RVA = "0x14E558C", Offset = "0x14E558C", VA = "0x14E558C", Slot = "4")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D60")]
	[Cpp2IlInjected.Address(RVA = "0x14E5770", Offset = "0x14E5770", VA = "0x14E5770")]
	public void PulseSteamTick()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D61")]
	[Cpp2IlInjected.Address(RVA = "0x14E57AC", Offset = "0x14E57AC", VA = "0x14E57AC")]
	public void PulseSteamCallback()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D62")]
	[Cpp2IlInjected.Address(RVA = "0x14E57E8", Offset = "0x14E57E8", VA = "0x14E57E8")]
	public static void Pulse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D63")]
	[Cpp2IlInjected.Address(RVA = "0x14E5854", Offset = "0x14E5854", VA = "0x14E5854")]
	private void SteamTickLoop(object context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D64")]
	[Cpp2IlInjected.Address(RVA = "0x14E58FC", Offset = "0x14E58FC", VA = "0x14E58FC")]
	private void SteamCallbackLoop(object context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D65")]
	[Cpp2IlInjected.Address(RVA = "0x14E5900", Offset = "0x14E5900", VA = "0x14E5900", Slot = "5")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D66")]
	[Cpp2IlInjected.Address(RVA = "0x14E5904", Offset = "0x14E5904", VA = "0x14E5904")]
	public CoreSocialModule()
	{
	}
}
