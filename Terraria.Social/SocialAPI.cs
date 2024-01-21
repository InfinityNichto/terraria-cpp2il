using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Social.Base;

namespace Terraria.Social;

[Cpp2IlInjected.Token(Token = "0x2000384")]
public static class SocialAPI
{
	[Cpp2IlInjected.Token(Token = "0x40031AD")]
	private static SocialMode _mode;

	[Cpp2IlInjected.Token(Token = "0x40031AE")]
	public static FriendsSocialModule Friends;

	[Cpp2IlInjected.Token(Token = "0x40031AF")]
	public static AchievementsSocialModule Achievements;

	[Cpp2IlInjected.Token(Token = "0x40031B0")]
	public static CloudSocialModule Cloud;

	[Cpp2IlInjected.Token(Token = "0x40031B1")]
	public static NetSocialModule Network;

	[Cpp2IlInjected.Token(Token = "0x40031B2")]
	public static OverlaySocialModule Overlay;

	[Cpp2IlInjected.Token(Token = "0x40031B3")]
	public static ServerJoinRequestsManager JoinRequests;

	[Cpp2IlInjected.Token(Token = "0x40031B4")]
	public static PlatformSocialModule Platform;

	[Cpp2IlInjected.Token(Token = "0x40031B5")]
	private static List<ISocialModule> _modules;

	[Cpp2IlInjected.Token(Token = "0x170005AE")]
	public static SocialMode Mode
	{
		[Cpp2IlInjected.Token(Token = "0x6002D43")]
		[Cpp2IlInjected.Address(RVA = "0x14E4D80", Offset = "0x14E4D80", VA = "0x14E4D80")]
		get
		{
			return default(SocialMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002D44")]
	[Cpp2IlInjected.Address(RVA = "0x14E4DF8", Offset = "0x14E4DF8", VA = "0x14E4DF8")]
	public static void Initialize([Optional] SocialMode? mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D45")]
	[Cpp2IlInjected.Address(RVA = "0x14E51B8", Offset = "0x14E51B8", VA = "0x14E51B8")]
	public static void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D46")]
	[Cpp2IlInjected.Address(RVA = "0x15F1460", Offset = "0x15F1460", VA = "0x15F1460")]
	private static T LoadModule<T>() where T : ISocialModule, new()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D47")]
	[Cpp2IlInjected.Address(RVA = "0x15F150C", Offset = "0x15F150C", VA = "0x15F150C")]
	private static T LoadModule<T>(T module) where T : ISocialModule
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D48")]
	[Cpp2IlInjected.Address(RVA = "0x14E5384", Offset = "0x14E5384", VA = "0x14E5384")]
	private static void LoadDiscord()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D49")]
	[Cpp2IlInjected.Address(RVA = "0x14E51B4", Offset = "0x14E51B4", VA = "0x14E51B4")]
	private static void LoadSteam()
	{
	}
}
