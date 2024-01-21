using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class XBOMultiplayerSessionManager
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static DateTime _startTime;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static Guid _sessionGUID;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static bool _userCallbacksRegistered;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static bool _shuttingDown;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static bool _sessionActive;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static bool _inActiveSession;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static bool _startSent;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static bool _joiningSession;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static bool _registeredForEvents;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public static bool InSession
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x14FC414", Offset = "0x14FC414", VA = "0x14FC414")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x14FC23C", Offset = "0x14FC23C", VA = "0x14FC23C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CD74", Offset = "0x38CD74")]
	public static void CreateMultiplayerSession(Guid sessionGUID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x14FC320", Offset = "0x14FC320", VA = "0x14FC320")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CDA8", Offset = "0x38CDA8")]
	public static void JoinMultiplayerSession(Guid sessionGUID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x14FC3B4", Offset = "0x14FC3B4", VA = "0x14FC3B4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CDDC", Offset = "0x38CDDC")]
	public static void SessionEnd()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x14FC410", Offset = "0x14FC410", VA = "0x14FC410")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38CE10", Offset = "0x38CE10")]
	public static void SendSessionStart()
	{
	}
}
