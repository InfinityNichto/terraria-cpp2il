using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001DA")]
public class GUIPS4MultiplayerChecks
{
	[Cpp2IlInjected.Token(Token = "0x20007F3")]
	public enum StateCheck
	{
		[Cpp2IlInjected.Token(Token = "0x4007CC2")]
		Availability,
		[Cpp2IlInjected.Token(Token = "0x4007CC3")]
		ParentalCheck,
		[Cpp2IlInjected.Token(Token = "0x4007CC4")]
		CheckPlus
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40014BB")]
	public bool CheckingPS4Permisions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40014BC")]
	public bool parentalFailed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40014BD")]
	private int userId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40014BE")]
	private StateCheck state;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40014BF")]
	private bool stepPassed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40014C0")]
	private bool displayingPS4Error;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x40014C1")]
	private bool displayingGenericError;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17")]
	[Cpp2IlInjected.Token(Token = "0x40014C2")]
	private bool displayedPlusSignup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40014C3")]
	private string genericError;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40014C4")]
	private bool XBOError;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x40014C5")]
	private bool stepFailed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40014C6")]
	private uint stepErrorCode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40014C7")]
	private bool EditorCheckingPermissions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40014C8")]
	private DateTime EditorCheckStart;

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0xFF8CCC", Offset = "0xFF8CCC", VA = "0xFF8CCC")]
	private void DisplayGenericError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0xFF8CDC", Offset = "0xFF8CDC", VA = "0xFF8CDC")]
	private void EditorCheckPermissions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0xFF8D70", Offset = "0xFF8D70", VA = "0xFF8D70")]
	private void EditorCheckPermissionsUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0xFF90B4", Offset = "0xFF90B4", VA = "0xFF90B4")]
	public void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0xFF9034", Offset = "0xFF9034", VA = "0xFF9034")]
	public void Complete(bool passed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0xFF9228", Offset = "0xFF9228", VA = "0xFF9228")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0xFF9610", Offset = "0xFF9610", VA = "0xFF9610")]
	public GUIPS4MultiplayerChecks()
	{
	}
}
