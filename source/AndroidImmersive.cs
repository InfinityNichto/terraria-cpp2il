using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class AndroidImmersive
{
	[Cpp2IlInjected.Token(Token = "0x2000771")]
	private delegate void RunPtr();

	[Cpp2IlInjected.Token(Token = "0x2000772")]
	private class Listener : AndroidJavaProxy
	{
		[Cpp2IlInjected.Token(Token = "0x6004880")]
		[Cpp2IlInjected.Address(RVA = "0x11FDA5C", Offset = "0x11FDA5C", VA = "0x11FDA5C")]
		public Listener()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004881")]
		[Cpp2IlInjected.Address(RVA = "0x11FDCBC", Offset = "0x11FDCBC", VA = "0x11FDCBC")]
		private void onSystemUiVisibilityChange(int visibility)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static AndroidJavaObject _viewInstance;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static AndroidJavaObject _viewInstanceBackup;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static bool _blockReactivation;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private const int SYSTEM_UI_FLAG_HIDE_NAVIGATION = 2;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private const int SYSTEM_UI_FLAG_FULLSCREEN = 4;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const int SYSTEM_UI_FLAG_LAYOUT_STABLE = 256;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION = 512;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const int SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN = 1024;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE = 2048;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE_STICKY = 4096;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x11FCA84", Offset = "0x11FCA84", VA = "0x11FCA84")]
	public static void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x11FD4E8", Offset = "0x11FD4E8", VA = "0x11FD4E8")]
	public static void Deactivate(bool blockReactivation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x11FD7C4", Offset = "0x11FD7C4", VA = "0x11FD7C4")]
	private static void RunActivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x11FDAE8", Offset = "0x11FDAE8", VA = "0x11FDAE8")]
	private static void RunDeactivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x11FD2E0", Offset = "0x11FD2E0", VA = "0x11FD2E0")]
	private static int GetSDKLevel()
	{
		return default(int);
	}
}
