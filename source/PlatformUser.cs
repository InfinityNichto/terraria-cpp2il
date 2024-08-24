using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using UnityEngine;

// Token: 0x02000217 RID: 535
[global::Cpp2ILInjected.Token(Token = "0x20002BE")]
public struct PlatformUser
{
	// Token: 0x06000F11 RID: 3857 RVA: 0x00024830 File Offset: 0x00022A30
	[global::Cpp2ILInjected.Token(Token = "0x6001044")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B8B4", Offset = "0xA3B8B4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public PlatformUser(string id, PlatformUser.Platform platform)
	{
		throw null;
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00024833 File Offset: 0x00022A33
	[global::Cpp2ILInjected.Token(Token = "0x17000194")]
	public static PlatformUser CurrentUser
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001045")]
		[global::Cpp2ILInjected.Address(RVA = "0xA3BB68", Offset = "0xA3BB68", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00024836 File Offset: 0x00022A36
	[global::Cpp2ILInjected.Token(Token = "0x6001046")]
	[global::Cpp2ILInjected.Address(RVA = "0xA41F00", Offset = "0xA41F00", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "LookForFriendPlatformGames", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static PlatformUser[] GetFriends()
	{
		throw null;
	}

	// Token: 0x04001A01 RID: 6657
	[global::Cpp2ILInjected.Token(Token = "0x4001F2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public string PlayerId;

	// Token: 0x04001A02 RID: 6658
	[global::Cpp2ILInjected.Token(Token = "0x4001F30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
	public PlatformUser.Platform PlatformId;

	// Token: 0x02000808 RID: 2056
	[global::Cpp2ILInjected.Token(Token = "0x20002BF")]
	public enum Platform
	{
		// Token: 0x04007CF9 RID: 31993
		[global::Cpp2ILInjected.Token(Token = "0x4001F32")]
		None,
		// Token: 0x04007CFA RID: 31994
		[global::Cpp2ILInjected.Token(Token = "0x4001F33")]
		Stadia,
		// Token: 0x04007CFB RID: 31995
		[global::Cpp2ILInjected.Token(Token = "0x4001F34")]
		XBO,
		// Token: 0x04007CFC RID: 31996
		[global::Cpp2ILInjected.Token(Token = "0x4001F35")]
		PSN,
		// Token: 0x04007CFD RID: 31997
		[global::Cpp2ILInjected.Token(Token = "0x4001F36")]
		Editor,
		// Token: 0x04007CFE RID: 31998
		[global::Cpp2ILInjected.Token(Token = "0x4001F37")]
		Nintendo
	}
}
