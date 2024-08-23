using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SocialPlatforms;

// Token: 0x02000026 RID: 38
[global::Cpp2ILInjected.Token(Token = "0x2000040")]
public class iOS_UserManager
{
	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x00021E33 File Offset: 0x00020033
	[global::Cpp2ILInjected.Token(Token = "0x17000064")]
	public static string UserId
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x704740", Offset = "0x704740", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000EA RID: 234 RVA: 0x00021E36 File Offset: 0x00020036
	[global::Cpp2ILInjected.Token(Token = "0x17000065")]
	public static string UserAlias
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x704798", Offset = "0x704798", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000EB RID: 235 RVA: 0x00021E39 File Offset: 0x00020039
	[global::Cpp2ILInjected.Token(Token = "0x17000066")]
	public static bool AttemptingSignIn
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x7047F0", Offset = "0x7047F0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000EC RID: 236 RVA: 0x00021E3C File Offset: 0x0002003C
	[global::Cpp2ILInjected.Token(Token = "0x17000067")]
	public static DrPlatform.IOS.User.UserState LoginState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x704890", Offset = "0x704890", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00021E3F File Offset: 0x0002003F
	[global::Cpp2ILInjected.Token(Token = "0x6000166")]
	[global::Cpp2ILInjected.Address(RVA = "0x702B30", Offset = "0x702B30", Length = "0x120")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void Setup()
	{
		throw null;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00021E42 File Offset: 0x00020042
	[global::Cpp2ILInjected.Token(Token = "0x6000167")]
	[global::Cpp2ILInjected.Address(RVA = "0x7048E8", Offset = "0x7048E8", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static void ClearCache()
	{
		throw null;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00021E45 File Offset: 0x00020045
	[global::Cpp2ILInjected.Token(Token = "0x6000168")]
	[global::Cpp2ILInjected.Address(RVA = "0x702DE4", Offset = "0x702DE4", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void RequestSignIn()
	{
		throw null;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00021E48 File Offset: 0x00020048
	[global::Cpp2ILInjected.Token(Token = "0x6000169")]
	[global::Cpp2ILInjected.Address(RVA = "0x70292C", Offset = "0x70292C", Length = "0x1AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "AttemptSignIn", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "get_EditorSignInProcessTimeout", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "get_EditorSignedIn", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "PlayerAuthenticated", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "UpdateUser", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public static void Update()
	{
		throw null;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00021E4B File Offset: 0x0002004B
	[global::Cpp2ILInjected.Token(Token = "0x600016A")]
	[global::Cpp2ILInjected.Address(RVA = "0x704D1C", Offset = "0x704D1C", Length = "0x568")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "get_EditorSignedIn", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "get_EditorUserId", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "get_EditorUserAlias", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Social), Member = "get_localUser", ReturnType = typeof(ILocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "OnPlatformUserChanged", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private static void UpdateUser()
	{
		throw null;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00021E4E File Offset: 0x0002004E
	[global::Cpp2ILInjected.Token(Token = "0x600016B")]
	[global::Cpp2ILInjected.Address(RVA = "0x7049D0", Offset = "0x7049D0", Length = "0x258")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(iOS_UserManager), Member = "get_EditorSignedIn", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Social), Member = "get_localUser", ReturnType = typeof(ILocalUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<bool>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private static void AttemptSignIn()
	{
		throw null;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00021E51 File Offset: 0x00020051
	[global::Cpp2ILInjected.Token(Token = "0x600016C")]
	[global::Cpp2ILInjected.Address(RVA = "0x704CC4", Offset = "0x704CC4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private static void PlayerAuthenticated(bool success)
	{
		throw null;
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x00021E54 File Offset: 0x00020054
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x00021E57 File Offset: 0x00020057
	[global::Cpp2ILInjected.Token(Token = "0x17000068")]
	public static bool EditorSignedIn
	{
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x704C70", Offset = "0x704C70", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "UpdateUser", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "AttemptSignIn", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x70534C", Offset = "0x70534C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x00021E5A File Offset: 0x0002005A
	// (set) Token: 0x060000F7 RID: 247 RVA: 0x00021E5D File Offset: 0x0002005D
	[global::Cpp2ILInjected.Token(Token = "0x17000069")]
	public static string EditorUserId
	{
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x705284", Offset = "0x705284", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "UpdateUser", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x7053A0", Offset = "0x7053A0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x00021E60 File Offset: 0x00020060
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x00021E63 File Offset: 0x00020063
	[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
	public static string EditorUserAlias
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x7052E8", Offset = "0x7052E8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "UpdateUser", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x7053F4", Offset = "0x7053F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000FA RID: 250 RVA: 0x00021E66 File Offset: 0x00020066
	// (set) Token: 0x060000FB RID: 251 RVA: 0x00021E69 File Offset: 0x00020069
	[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
	public static float EditorSignInProcessTimeout
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x704C28", Offset = "0x704C28", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x705448", Offset = "0x705448", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00021E6C File Offset: 0x0002006C
	[global::Cpp2ILInjected.Token(Token = "0x6000175")]
	[global::Cpp2ILInjected.Address(RVA = "0x7054A4", Offset = "0x7054A4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public iOS_UserManager()
	{
		throw null;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00021E6F File Offset: 0x0002006F
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000176")]
	[global::Cpp2ILInjected.Address(RVA = "0x7054AC", Offset = "0x7054AC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static iOS_UserManager()
	{
		throw null;
	}

	// Token: 0x040000B1 RID: 177
	[global::Cpp2ILInjected.Token(Token = "0x4000100")]
	public static bool EditorAttemptingSignIn;

	// Token: 0x040000B2 RID: 178
	[global::Cpp2ILInjected.Token(Token = "0x4000101")]
	public static DateTime EditorSignInStart;

	// Token: 0x040000B3 RID: 179
	[global::Cpp2ILInjected.Token(Token = "0x4000102")]
	private static string _userId;

	// Token: 0x040000B4 RID: 180
	[global::Cpp2ILInjected.Token(Token = "0x4000103")]
	private static string _userAlias;

	// Token: 0x040000B5 RID: 181
	[global::Cpp2ILInjected.Token(Token = "0x4000104")]
	private static bool _attemptedPassiveLogin;

	// Token: 0x040000B6 RID: 182
	[global::Cpp2ILInjected.Token(Token = "0x4000105")]
	private static bool _requestedLogin;

	// Token: 0x040000B7 RID: 183
	[global::Cpp2ILInjected.Token(Token = "0x4000106")]
	private static bool _attemptingSignIn;

	// Token: 0x040000B8 RID: 184
	[global::Cpp2ILInjected.Token(Token = "0x4000107")]
	private static DrPlatform.IOS.User.UserState _loginState;

	// Token: 0x040000B9 RID: 185
	[global::Cpp2ILInjected.Token(Token = "0x4000108")]
	private const string c_accountIdLastUserKey = "AccountId_LastUser";

	// Token: 0x040000BA RID: 186
	[global::Cpp2ILInjected.Token(Token = "0x4000109")]
	private const string c_accountIdLastUserGameTag = "AccountGamerTag_LastUser";
}
