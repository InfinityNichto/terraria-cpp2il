using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002F")]
public class iOS_UserManager
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public static bool EditorAttemptingSignIn;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public static DateTime EditorSignInStart;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static string _userId;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static string _userAlias;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool _attemptedPassiveLogin;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool _requestedLogin;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static bool _attemptingSignIn;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static DrPlatform.IOS.User.UserState _loginState;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const string c_accountIdLastUserKey = "AccountId_LastUser";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const string c_accountIdLastUserGameTag = "AccountGamerTag_LastUser";

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public static string UserId
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1504DCC", Offset = "0x1504DCC", VA = "0x1504DCC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public static string UserAlias
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1504E44", Offset = "0x1504E44", VA = "0x1504E44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static bool AttemptingSignIn
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1504EBC", Offset = "0x1504EBC", VA = "0x1504EBC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public static DrPlatform.IOS.User.UserState LoginState
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1504FA4", Offset = "0x1504FA4", VA = "0x1504FA4")]
		get
		{
			return default(DrPlatform.IOS.User.UserState);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static bool EditorSignedIn
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x15058C4", Offset = "0x15058C4", VA = "0x15058C4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x15061C0", Offset = "0x15061C0", VA = "0x15061C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static string EditorUserId
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x15060E0", Offset = "0x15060E0", VA = "0x15060E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1506228", Offset = "0x1506228", VA = "0x1506228")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public static string EditorUserAlias
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1506150", Offset = "0x1506150", VA = "0x1506150")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1506290", Offset = "0x1506290", VA = "0x1506290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static float EditorSignInProcessTimeout
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1505868", Offset = "0x1505868", VA = "0x1505868")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x15062F8", Offset = "0x15062F8", VA = "0x15062F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x150501C", Offset = "0x150501C", VA = "0x150501C")]
	public static void Setup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1505148", Offset = "0x1505148", VA = "0x1505148")]
	public static void ClearCache()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1505244", Offset = "0x1505244", VA = "0x1505244")]
	public static void RequestSignIn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x15052C0", Offset = "0x15052C0", VA = "0x15052C0")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x15059AC", Offset = "0x15059AC", VA = "0x15059AC")]
	private static void UpdateUser()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1505554", Offset = "0x1505554", VA = "0x1505554")]
	private static void AttemptSignIn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x150592C", Offset = "0x150592C", VA = "0x150592C")]
	private static void PlayerAuthenticated(bool success)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1506360", Offset = "0x1506360", VA = "0x1506360")]
	public iOS_UserManager()
	{
	}
}
