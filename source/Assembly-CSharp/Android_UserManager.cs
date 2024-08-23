using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200001F RID: 31
[global::Cpp2ILInjected.Token(Token = "0x2000025")]
public static class Android_UserManager
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x00021D67 File Offset: 0x0001FF67
	[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
	public static DrPlatform.Android.User.LoginState CurrentState
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FF5A8", Offset = "0x6FF5A8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Android.User), Member = "get_CurrentLoginState", ReturnType = typeof(DrPlatform.Android.User.LoginState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x00021D6A File Offset: 0x0001FF6A
	[global::Cpp2ILInjected.Token(Token = "0x17000030")]
	public static bool AttemptingSignIn
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FF684", Offset = "0x6FF684", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Android.User), Member = "get_SigningIn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x00021D6D File Offset: 0x0001FF6D
	[global::Cpp2ILInjected.Token(Token = "0x17000031")]
	public static string UserId
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FF724", Offset = "0x6FF724", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00021D70 File Offset: 0x0001FF70
	[global::Cpp2ILInjected.Token(Token = "0x17000032")]
	public static string GamerTag
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FF77C", Offset = "0x6FF77C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x00021D73 File Offset: 0x0001FF73
	[global::Cpp2ILInjected.Token(Token = "0x17000033")]
	public static string AccountProfileURL
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FF7D4", Offset = "0x6FF7D4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00021D76 File Offset: 0x0001FF76
	[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF82C", Offset = "0x6FF82C", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Android.User), Member = "RequestLogin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void RequestLogin()
	{
		throw null;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00021D79 File Offset: 0x0001FF79
	[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF888", Offset = "0x6FF888", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Android.User), Member = "Logout", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void Logout()
	{
		throw null;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00021D7C File Offset: 0x0001FF7C
	[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FFA74", Offset = "0x6FFA74", Length = "0xE8")]
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

	// Token: 0x060000AD RID: 173 RVA: 0x00021D7F File Offset: 0x0001FF7F
	[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FFB6C", Offset = "0x6FFB6C", Length = "0x2E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Android), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "AttemptSignIn", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorSignInProcessTimeout", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorSignedIn", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "_authenticationFailedEvent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_CurrentState", ReturnType = typeof(DrPlatform.Android.User.LoginState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "playerLoggedOut", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorUserId", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "_authenticationSucceededEvent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public static void Update()
	{
		throw null;
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00021D82 File Offset: 0x0001FF82
	[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FFE54", Offset = "0x6FFE54", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorSignedIn", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "playerAuthenticated", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private static void AttemptSignIn()
	{
		throw null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00021D85 File Offset: 0x0001FF85
	[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF8E0", Offset = "0x6FF8E0", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "_authenticationFailedEvent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "OnPlatformUserChanged", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private static void playerLoggedOut()
	{
		throw null;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00021D88 File Offset: 0x0001FF88
	[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
	[global::Cpp2ILInjected.Address(RVA = "0x7001E0", Offset = "0x7001E0", Length = "0x1FC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "AttemptSignIn", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "_authenticationSucceededEvent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorSignedIn", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorUserId", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_EditorUserAlias", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "Save", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "OnPlatformUserChanged", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private static void playerAuthenticated()
	{
		throw null;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00021D8B File Offset: 0x0001FF8B
	[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
	[global::Cpp2ILInjected.Address(RVA = "0x700060", Offset = "0x700060", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "playerAuthenticated", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private static void _authenticationSucceededEvent(string userID)
	{
		throw null;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00021D8E File Offset: 0x0001FF8E
	[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
	[global::Cpp2ILInjected.Address(RVA = "0x700120", Offset = "0x700120", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "playerLoggedOut", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private static void _authenticationFailedEvent(string error)
	{
		throw null;
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000B3 RID: 179 RVA: 0x00021D91 File Offset: 0x0001FF91
	// (set) Token: 0x060000B4 RID: 180 RVA: 0x00021D94 File Offset: 0x0001FF94
	[global::Cpp2ILInjected.Token(Token = "0x17000034")]
	public static bool EditorSignedIn
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FFFA8", Offset = "0x6FFFA8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "AttemptSignIn", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "playerAuthenticated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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
		[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7004DC", Offset = "0x7004DC", Length = "0x54")]
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

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x00021D97 File Offset: 0x0001FF97
	// (set) Token: 0x060000B6 RID: 182 RVA: 0x00021D9A File Offset: 0x0001FF9A
	[global::Cpp2ILInjected.Token(Token = "0x17000035")]
	public static string EditorUserId
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FFFFC", Offset = "0x6FFFFC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "playerAuthenticated", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x700538", Offset = "0x700538", Length = "0x54")]
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

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x00021D9D File Offset: 0x0001FF9D
	// (set) Token: 0x060000B8 RID: 184 RVA: 0x00021DA0 File Offset: 0x0001FFA0
	[global::Cpp2ILInjected.Token(Token = "0x17000036")]
	public static string EditorUserAlias
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x700470", Offset = "0x700470", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "playerAuthenticated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x70058C", Offset = "0x70058C", Length = "0x54")]
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

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000B9 RID: 185 RVA: 0x00021DA3 File Offset: 0x0001FFA3
	// (set) Token: 0x060000BA RID: 186 RVA: 0x00021DA6 File Offset: 0x0001FFA6
	[global::Cpp2ILInjected.Token(Token = "0x17000037")]
	public static float EditorSignInProcessTimeout
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FFF60", Offset = "0x6FFF60", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7005E8", Offset = "0x7005E8", Length = "0x5C")]
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

	// Token: 0x060000BB RID: 187 RVA: 0x00021DA9 File Offset: 0x0001FFA9
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
	[global::Cpp2ILInjected.Address(RVA = "0x70064C", Offset = "0x70064C", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	static Android_UserManager()
	{
		throw null;
	}

	// Token: 0x04000070 RID: 112
	[global::Cpp2ILInjected.Token(Token = "0x400007D")]
	public static bool EditorAttemptingSignIn;

	// Token: 0x04000071 RID: 113
	[global::Cpp2ILInjected.Token(Token = "0x400007E")]
	public static DateTime EditorSignInStart;

	// Token: 0x04000072 RID: 114
	[global::Cpp2ILInjected.Token(Token = "0x400007F")]
	private static bool _delayedStartup;

	// Token: 0x04000073 RID: 115
	[global::Cpp2ILInjected.Token(Token = "0x4000080")]
	private static string s_userId;

	// Token: 0x04000074 RID: 116
	[global::Cpp2ILInjected.Token(Token = "0x4000081")]
	private static string s_gamerTag;

	// Token: 0x04000075 RID: 117
	[global::Cpp2ILInjected.Token(Token = "0x4000082")]
	private static string s_avatarImageURL;

	// Token: 0x04000076 RID: 118
	[global::Cpp2ILInjected.Token(Token = "0x4000083")]
	private static bool s_requestedLogin;

	// Token: 0x04000077 RID: 119
	[global::Cpp2ILInjected.Token(Token = "0x4000084")]
	private static bool s_attemptedPassiveLogin;

	// Token: 0x04000078 RID: 120
	[global::Cpp2ILInjected.Token(Token = "0x4000085")]
	private static bool s_currentlyLoggingIn;

	// Token: 0x04000079 RID: 121
	[global::Cpp2ILInjected.Token(Token = "0x4000086")]
	private const string c_accountIdLastUserKey = "AccountId_LastUser";

	// Token: 0x0400007A RID: 122
	[global::Cpp2ILInjected.Token(Token = "0x4000087")]
	private const string c_accountIdLastUserGameTag = "AccountGamerTag_LastUser";

	// Token: 0x0400007B RID: 123
	[global::Cpp2ILInjected.Token(Token = "0x4000088")]
	private static bool s_usingCachedId;
}
