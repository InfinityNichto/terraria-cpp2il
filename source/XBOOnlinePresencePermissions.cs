using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class XBOOnlinePresencePermissions
{
	[Cpp2IlInjected.Token(Token = "0x2000777")]
	public delegate void OnlinePresencePermissionsResult(string playerId, bool result);

	[Cpp2IlInjected.Token(Token = "0x2000778")]
	public class RequestResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007829")]
		public string xboPlayerId;

		[Cpp2IlInjected.Token(Token = "0x14000062")]
		public event OnlinePresencePermissionsResult ResultCallbacks
		{
			[Cpp2IlInjected.Token(Token = "0x6004890")]
			[Cpp2IlInjected.Address(RVA = "0x14FCCD4", Offset = "0x14FCCD4", VA = "0x14FCCD4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6004891")]
			[Cpp2IlInjected.Address(RVA = "0x14FCF9C", Offset = "0x14FCF9C", VA = "0x14FCF9C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600488F")]
		[Cpp2IlInjected.Address(RVA = "0x14FC5C4", Offset = "0x14FC5C4", VA = "0x14FC5C4")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004892")]
		[Cpp2IlInjected.Address(RVA = "0x14FD04C", Offset = "0x14FD04C", VA = "0x14FD04C")]
		public RequestResult()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static Dictionary<string, RequestResult> _inprogress;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static Dictionary<string, bool> _cachedOnlinePresencePermissions;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x14FC41C", Offset = "0x14FC41C", VA = "0x14FC41C")]
	public static void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x14FC5D0", Offset = "0x14FC5D0", VA = "0x14FC5D0")]
	public static void CanSeeOnlinePresence(string xboPlayerId, OnlinePresencePermissionsResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x14FCD84", Offset = "0x14FCD84", VA = "0x14FCD84")]
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
	}
}
