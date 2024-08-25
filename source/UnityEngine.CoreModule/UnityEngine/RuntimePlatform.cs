using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	public enum RuntimePlatform
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		OSXEditor,
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		OSXPlayer,
		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		WindowsPlayer,
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		OSXWebPlayer,
		[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		OSXDashboardPlayer,
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000056")]
		WindowsWebPlayer,
		[global::Cpp2ILInjected.Token(Token = "0x4000057")]
		WindowsEditor = 7,
		[global::Cpp2ILInjected.Token(Token = "0x4000058")]
		IPhonePlayer,
		[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000059")]
		XBOX360 = 10,
		[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		PS3 = 9,
		[global::Cpp2ILInjected.Token(Token = "0x400005B")]
		Android = 11,
		[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400005C")]
		NaCl,
		[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400005D")]
		FlashPlayer = 15,
		[global::Cpp2ILInjected.Token(Token = "0x400005E")]
		LinuxPlayer = 13,
		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		LinuxEditor = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		WebGLPlayer,
		[Obsolete("Use WSAPlayerX86 instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		MetroPlayerX86,
		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		WSAPlayerX86 = 18,
		[Obsolete("Use WSAPlayerX64 instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4000063")]
		MetroPlayerX64,
		[global::Cpp2ILInjected.Token(Token = "0x4000064")]
		WSAPlayerX64 = 19,
		[Obsolete("Use WSAPlayerARM instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4000065")]
		MetroPlayerARM,
		[global::Cpp2ILInjected.Token(Token = "0x4000066")]
		WSAPlayerARM = 20,
		[Obsolete("Windows Phone 8 was removed in 5.3")]
		[global::Cpp2ILInjected.Token(Token = "0x4000067")]
		WP8Player,
		[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000068")]
		BlackBerryPlayer,
		[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000069")]
		TizenPlayer,
		[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
		[global::Cpp2ILInjected.Token(Token = "0x400006A")]
		PSP2,
		[global::Cpp2ILInjected.Token(Token = "0x400006B")]
		PS4,
		[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		PSM,
		[global::Cpp2ILInjected.Token(Token = "0x400006D")]
		XboxOne,
		[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400006E")]
		SamsungTVPlayer,
		[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		WiiU = 30,
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		tvOS,
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		Switch,
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		Lumin,
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		Stadia,
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		CloudRendering,
		[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		GameCoreScarlett = -1,
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		GameCoreXboxSeries = 36,
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		GameCoreXboxOne,
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		PS5,
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		EmbeddedLinuxArm64,
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		EmbeddedLinuxArm32,
		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		EmbeddedLinuxX64,
		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		EmbeddedLinuxX86,
		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		LinuxServer,
		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		WindowsServer,
		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		OSXServer
	}
}
