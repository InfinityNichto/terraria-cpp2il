using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000398")]
public class ServerJoinRequestsManager
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031D6")]
	private readonly List<UserJoinToServerRequest> _requests;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031D7")]
	public readonly ReadOnlyCollection<UserJoinToServerRequest> CurrentRequests;

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event ServerJoinRequestEvent OnRequestAdded
	{
		[Cpp2IlInjected.Token(Token = "0x6002DD4")]
		[Cpp2IlInjected.Address(RVA = "0x14E0220", Offset = "0x14E0220", VA = "0x14E0220")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002DD5")]
		[Cpp2IlInjected.Address(RVA = "0x14E02D0", Offset = "0x14E02D0", VA = "0x14E02D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ServerJoinRequestEvent OnRequestRemoved
	{
		[Cpp2IlInjected.Token(Token = "0x6002DD6")]
		[Cpp2IlInjected.Address(RVA = "0x14E0380", Offset = "0x14E0380", VA = "0x14E0380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002DD7")]
		[Cpp2IlInjected.Address(RVA = "0x14E0430", Offset = "0x14E0430", VA = "0x14E0430")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002DD8")]
	[Cpp2IlInjected.Address(RVA = "0x14E04E0", Offset = "0x14E04E0", VA = "0x14E04E0")]
	public ServerJoinRequestsManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DD9")]
	[Cpp2IlInjected.Address(RVA = "0x14E059C", Offset = "0x14E059C", VA = "0x14E059C")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DDA")]
	[Cpp2IlInjected.Address(RVA = "0x14E06FC", Offset = "0x14E06FC", VA = "0x14E06FC")]
	public void Add(UserJoinToServerRequest request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DDB")]
	[Cpp2IlInjected.Address(RVA = "0x14E0654", Offset = "0x14E0654", VA = "0x14E0654")]
	private void RemoveRequestAtIndex(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002DDC")]
	[Cpp2IlInjected.Address(RVA = "0x14E0A08", Offset = "0x14E0A08", VA = "0x14E0A08")]
	private void RemoveRequest(UserJoinToServerRequest request)
	{
	}
}
