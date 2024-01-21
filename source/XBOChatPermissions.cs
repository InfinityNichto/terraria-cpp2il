using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class XBOChatPermissions
{
	[Cpp2IlInjected.Token(Token = "0x2000775")]
	public delegate void ChatPermissionsResult(string playerId, bool result);

	[Cpp2IlInjected.Token(Token = "0x2000776")]
	public class RequestResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007827")]
		public string xboPlayerId;

		[Cpp2IlInjected.Token(Token = "0x14000061")]
		public event ChatPermissionsResult ResultCallbacks
		{
			[Cpp2IlInjected.Token(Token = "0x6004888")]
			[Cpp2IlInjected.Address(RVA = "0x14FBE4C", Offset = "0x14FBE4C", VA = "0x14FBE4C")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6004889")]
			[Cpp2IlInjected.Address(RVA = "0x14FC114", Offset = "0x14FC114", VA = "0x14FC114")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004887")]
		[Cpp2IlInjected.Address(RVA = "0x14FB73C", Offset = "0x14FB73C", VA = "0x14FB73C")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600488A")]
		[Cpp2IlInjected.Address(RVA = "0x14FC1C4", Offset = "0x14FC1C4", VA = "0x14FC1C4")]
		public RequestResult()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static Dictionary<string, RequestResult> _inprogress;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static Dictionary<string, bool> _cachedChatPermissions;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x14FB594", Offset = "0x14FB594", VA = "0x14FB594")]
	public static void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x14FB748", Offset = "0x14FB748", VA = "0x14FB748")]
	public static void CanChatWith(string xboPlayerId, ChatPermissionsResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x14FBEFC", Offset = "0x14FBEFC", VA = "0x14FBEFC")]
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
	}
}
