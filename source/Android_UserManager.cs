using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class Android_UserManager
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static bool EditorAttemptingSignIn;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static DateTime EditorSignInStart;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static bool _delayedStartup;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string s_userId;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static string s_gamerTag;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static string s_avatarImageURL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static bool s_requestedLogin;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static bool s_attemptedPassiveLogin;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static bool s_currentlyLoggingIn;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private const string c_accountIdLastUserKey = "AccountId_LastUser";

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private const string c_accountIdLastUserGameTag = "AccountGamerTag_LastUser";

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static bool s_usingCachedId;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public static DrPlatform.Android.User.LoginState CurrentState
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x11FE01C", Offset = "0x11FE01C", VA = "0x11FE01C")]
		get
		{
			return default(DrPlatform.Android.User.LoginState);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static bool AttemptingSignIn
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x11FE150", Offset = "0x11FE150", VA = "0x11FE150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static string UserId
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x11FE238", Offset = "0x11FE238", VA = "0x11FE238")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static string GamerTag
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x11FE2B0", Offset = "0x11FE2B0", VA = "0x11FE2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static string AccountProfileURL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x11FE328", Offset = "0x11FE328", VA = "0x11FE328")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public static bool EditorSignedIn
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x11FEDD0", Offset = "0x11FEDD0", VA = "0x11FEDD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x11FF340", Offset = "0x11FF340", VA = "0x11FF340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static string EditorUserId
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x11FEE38", Offset = "0x11FEE38", VA = "0x11FEE38")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x11FF3A8", Offset = "0x11FF3A8", VA = "0x11FF3A8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static string EditorUserAlias
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x11FF2D0", Offset = "0x11FF2D0", VA = "0x11FF2D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x11FF410", Offset = "0x11FF410", VA = "0x11FF410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static float EditorSignInProcessTimeout
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x11FED74", Offset = "0x11FED74", VA = "0x11FED74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x11FF478", Offset = "0x11FF478", VA = "0x11FF478")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x11FE3A0", Offset = "0x11FE3A0", VA = "0x11FE3A0")]
	public static void RequestLogin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x11FE41C", Offset = "0x11FE41C", VA = "0x11FE41C")]
	public static void Logout()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x11FE678", Offset = "0x11FE678", VA = "0x11FE678")]
	public static void ClearCache()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x11FE784", Offset = "0x11FE784", VA = "0x11FE784")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x11FEBEC", Offset = "0x11FEBEC", VA = "0x11FEBEC")]
	private static void AttemptSignIn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x11FE49C", Offset = "0x11FE49C", VA = "0x11FE49C")]
	private static void playerLoggedOut()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x11FF060", Offset = "0x11FF060", VA = "0x11FF060")]
	private static void playerAuthenticated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x11FEEA8", Offset = "0x11FEEA8", VA = "0x11FEEA8")]
	private static void _authenticationSucceededEvent(string userID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x11FEF84", Offset = "0x11FEF84", VA = "0x11FEF84")]
	private static void _authenticationFailedEvent(string error)
	{
	}
}
