using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x200021A")]
public class UserManagement
{
	[Cpp2IlInjected.Token(Token = "0x4001A0F")]
	private static List<int> AvailableIndices;

	[Cpp2IlInjected.Token(Token = "0x4001A10")]
	public static bool SplitHorizontalFirst;

	[Cpp2IlInjected.Token(Token = "0x4001A11")]
	public static LocalUser PrimaryPlayer;

	[Cpp2IlInjected.Token(Token = "0x4001A12")]
	public static List<LocalUser> LocalUsers;

	[Cpp2IlInjected.Token(Token = "0x4001A13")]
	public static LocalUser PendingUser;

	[Cpp2IlInjected.Token(Token = "0x6000F2B")]
	[Cpp2IlInjected.Address(RVA = "0xE87F44", Offset = "0xE87F44", VA = "0xE87F44")]
	public static void HandleNetworkLost()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F2C")]
	[Cpp2IlInjected.Address(RVA = "0xE882D4", Offset = "0xE882D4", VA = "0xE882D4")]
	public static void SetupPrimary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F2D")]
	[Cpp2IlInjected.Address(RVA = "0xE8835C", Offset = "0xE8835C", VA = "0xE8835C")]
	public static void SwitchPrimaryUser(PlatformUser platformUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F2E")]
	[Cpp2IlInjected.Address(RVA = "0xE891D8", Offset = "0xE891D8", VA = "0xE891D8")]
	public static void UserSignIn(ControllerDevice localDevice, PlatformUser platformUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F2F")]
	[Cpp2IlInjected.Address(RVA = "0xE89434", Offset = "0xE89434", VA = "0xE89434")]
	public static void AddUser(ControllerDevice localDevice, PlatformUser platformUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F30")]
	[Cpp2IlInjected.Address(RVA = "0xE895D4", Offset = "0xE895D4", VA = "0xE895D4")]
	public static void UserSignedOut(PlatformUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F31")]
	[Cpp2IlInjected.Address(RVA = "0xE898E4", Offset = "0xE898E4", VA = "0xE898E4")]
	public static void LocalUserQuit(LocalUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F32")]
	[Cpp2IlInjected.Address(RVA = "0xE89AEC", Offset = "0xE89AEC", VA = "0xE89AEC")]
	public static void SignInController(ControllerDevice localDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F33")]
	[Cpp2IlInjected.Address(RVA = "0xE89AF0", Offset = "0xE89AF0", VA = "0xE89AF0")]
	public static bool CanControllerBeUserForPrimaryPlayer(ControllerDevice localDevice)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F34")]
	[Cpp2IlInjected.Address(RVA = "0xE89AF8", Offset = "0xE89AF8", VA = "0xE89AF8")]
	public static bool CanControllerBeUsedForPlayer(ControllerDevice localDevice, LocalUser user)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F35")]
	[Cpp2IlInjected.Address(RVA = "0xE89B00", Offset = "0xE89B00", VA = "0xE89B00")]
	public static LocalUser FindLocalUserByUser(PlatformUser user)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000F36")]
	[Cpp2IlInjected.Address(RVA = "0xE89C9C", Offset = "0xE89C9C", VA = "0xE89C9C")]
	public static LocalUser FindLocalUserByPlayer(Player player)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000F37")]
	[Cpp2IlInjected.Address(RVA = "0xE89DDC", Offset = "0xE89DDC", VA = "0xE89DDC")]
	public static LocalUser FindLocalUserByController(ControllerDevice controller)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000F38")]
	[Cpp2IlInjected.Address(RVA = "0xE89F14", Offset = "0xE89F14", VA = "0xE89F14")]
	public static void LookForNewUsers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F39")]
	[Cpp2IlInjected.Address(RVA = "0xE8A78C", Offset = "0xE8A78C", VA = "0xE8A78C")]
	public void SwitchUser(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F3A")]
	[Cpp2IlInjected.Address(RVA = "0xE888A8", Offset = "0xE888A8", VA = "0xE888A8")]
	public static void UpdateViewPorts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F3B")]
	[Cpp2IlInjected.Address(RVA = "0xE8A790", Offset = "0xE8A790", VA = "0xE8A790")]
	public void ApplyCameras()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F3C")]
	[Cpp2IlInjected.Address(RVA = "0xE8A8A8", Offset = "0xE8A8A8", VA = "0xE8A8A8")]
	public UserManagement()
	{
	}
}
