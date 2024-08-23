using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	public enum RuntimePlatform
	{
		// Token: 0x0400004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		OSXEditor,
		// Token: 0x0400004E RID: 78
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		OSXPlayer,
		// Token: 0x0400004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		WindowsPlayer,
		// Token: 0x04000050 RID: 80
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		OSXWebPlayer,
		// Token: 0x04000051 RID: 81
		[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		OSXDashboardPlayer,
		// Token: 0x04000052 RID: 82
		[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000056")]
		WindowsWebPlayer,
		// Token: 0x04000053 RID: 83
		[global::Cpp2ILInjected.Token(Token = "0x4000057")]
		WindowsEditor = 7,
		// Token: 0x04000054 RID: 84
		[global::Cpp2ILInjected.Token(Token = "0x4000058")]
		IPhonePlayer,
		// Token: 0x04000055 RID: 85
		[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000059")]
		XBOX360 = 10,
		// Token: 0x04000056 RID: 86
		[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		PS3 = 9,
		// Token: 0x04000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x400005B")]
		Android = 11,
		// Token: 0x04000058 RID: 88
		[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400005C")]
		NaCl,
		// Token: 0x04000059 RID: 89
		[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400005D")]
		FlashPlayer = 15,
		// Token: 0x0400005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x400005E")]
		LinuxPlayer = 13,
		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		LinuxEditor = 16,
		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		WebGLPlayer,
		// Token: 0x0400005D RID: 93
		[Obsolete("Use WSAPlayerX86 instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		MetroPlayerX86,
		// Token: 0x0400005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		WSAPlayerX86 = 18,
		// Token: 0x0400005F RID: 95
		[Obsolete("Use WSAPlayerX64 instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4000063")]
		MetroPlayerX64,
		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x4000064")]
		WSAPlayerX64 = 19,
		// Token: 0x04000061 RID: 97
		[Obsolete("Use WSAPlayerARM instead")]
		[global::Cpp2ILInjected.Token(Token = "0x4000065")]
		MetroPlayerARM,
		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x4000066")]
		WSAPlayerARM = 20,
		// Token: 0x04000063 RID: 99
		[Obsolete("Windows Phone 8 was removed in 5.3")]
		[global::Cpp2ILInjected.Token(Token = "0x4000067")]
		WP8Player,
		// Token: 0x04000064 RID: 100
		[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000068")]
		BlackBerryPlayer,
		// Token: 0x04000065 RID: 101
		[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000069")]
		TizenPlayer,
		// Token: 0x04000066 RID: 102
		[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
		[global::Cpp2ILInjected.Token(Token = "0x400006A")]
		PSP2,
		// Token: 0x04000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x400006B")]
		PS4,
		// Token: 0x04000068 RID: 104
		[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		PSM,
		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x400006D")]
		XboxOne,
		// Token: 0x0400006A RID: 106
		[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400006E")]
		SamsungTVPlayer,
		// Token: 0x0400006B RID: 107
		[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		WiiU = 30,
		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		tvOS,
		// Token: 0x0400006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		Switch,
		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		Lumin,
		// Token: 0x0400006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		Stadia,
		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		CloudRendering,
		// Token: 0x04000071 RID: 113
		[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", false)]
		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		GameCoreScarlett = -1,
		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		GameCoreXboxSeries = 36,
		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		GameCoreXboxOne,
		// Token: 0x04000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		PS5,
		// Token: 0x04000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		EmbeddedLinuxArm64,
		// Token: 0x04000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		EmbeddedLinuxArm32,
		// Token: 0x04000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		EmbeddedLinuxX64,
		// Token: 0x04000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		EmbeddedLinuxX86,
		// Token: 0x04000079 RID: 121
		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		LinuxServer,
		// Token: 0x0400007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		WindowsServer,
		// Token: 0x0400007B RID: 123
		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		OSXServer
	}
}
