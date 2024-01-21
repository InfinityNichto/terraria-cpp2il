using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000399")]
public abstract class UserJoinToServerRequest
{
	[Cpp2IlInjected.Token(Token = "0x170005AF")]
	internal string UserDisplayName
	{
		[Cpp2IlInjected.Token(Token = "0x6002DDD")]
		[Cpp2IlInjected.Address(RVA = "0x14E0AA4", Offset = "0x14E0AA4", VA = "0x14E0AA4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002DDE")]
		[Cpp2IlInjected.Address(RVA = "0x14E0AAC", Offset = "0x14E0AAC", VA = "0x14E0AAC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005B0")]
	internal string UserFullIdentifier
	{
		[Cpp2IlInjected.Token(Token = "0x6002DDF")]
		[Cpp2IlInjected.Address(RVA = "0x14E0AB4", Offset = "0x14E0AB4", VA = "0x14E0AB4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002DE0")]
		[Cpp2IlInjected.Address(RVA = "0x14E0ABC", Offset = "0x14E0ABC", VA = "0x14E0ABC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event Action OnAccepted
	{
		[Cpp2IlInjected.Token(Token = "0x6002DE1")]
		[Cpp2IlInjected.Address(RVA = "0x14E08A8", Offset = "0x14E08A8", VA = "0x14E08A8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002DE2")]
		[Cpp2IlInjected.Address(RVA = "0x14E0AC4", Offset = "0x14E0AC4", VA = "0x14E0AC4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event Action OnRejected
	{
		[Cpp2IlInjected.Token(Token = "0x6002DE3")]
		[Cpp2IlInjected.Address(RVA = "0x14E0958", Offset = "0x14E0958", VA = "0x14E0958")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002DE4")]
		[Cpp2IlInjected.Address(RVA = "0x14E0B74", Offset = "0x14E0B74", VA = "0x14E0B74")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002DE5")]
	[Cpp2IlInjected.Address(RVA = "0x14E0C24", Offset = "0x14E0C24", VA = "0x14E0C24")]
	public UserJoinToServerRequest(string userDisplayName, string fullIdentifier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DE6")]
	[Cpp2IlInjected.Address(RVA = "0x14E0C4C", Offset = "0x14E0C4C", VA = "0x14E0C4C")]
	public void Accept()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DE7")]
	[Cpp2IlInjected.Address(RVA = "0x14E0C60", Offset = "0x14E0C60", VA = "0x14E0C60")]
	public void Reject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DE8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IsValid();

	[Cpp2IlInjected.Token(Token = "0x6002DE9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string GetUserWrapperText();
}
