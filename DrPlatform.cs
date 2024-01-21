using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Terraria.Chat;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DrPlatform
{
	[Cpp2IlInjected.Token(Token = "0x2000767")]
	public class Android
	{
		[Cpp2IlInjected.Token(Token = "0x2000B45")]
		public class User
		{
			[Cpp2IlInjected.Token(Token = "0x2000BCC")]
			public enum LoginState
			{
				[Cpp2IlInjected.Token(Token = "0x400915D")]
				Waiting,
				[Cpp2IlInjected.Token(Token = "0x400915E")]
				LoggingIn,
				[Cpp2IlInjected.Token(Token = "0x400915F")]
				LoggedIn,
				[Cpp2IlInjected.Token(Token = "0x4009160")]
				FromCache,
				[Cpp2IlInjected.Token(Token = "0x4009161")]
				LoggedOut
			}

			[Cpp2IlInjected.Token(Token = "0x1700090F")]
			public static string UserUID
			{
				[Cpp2IlInjected.Token(Token = "0x6005329")]
				[Cpp2IlInjected.Address(RVA = "0x20CE798", Offset = "0x20CE798", VA = "0x20CE798")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000910")]
			public static string GamerTag
			{
				[Cpp2IlInjected.Token(Token = "0x600532A")]
				[Cpp2IlInjected.Address(RVA = "0x20CF2D0", Offset = "0x20CF2D0", VA = "0x20CF2D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000911")]
			public static LoginState CurrentLoginState
			{
				[Cpp2IlInjected.Token(Token = "0x600532B")]
				[Cpp2IlInjected.Address(RVA = "0x20CE5DC", Offset = "0x20CE5DC", VA = "0x20CE5DC")]
				get
				{
					return default(LoginState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000912")]
			public static string AccountProfileURL
			{
				[Cpp2IlInjected.Token(Token = "0x600532C")]
				[Cpp2IlInjected.Address(RVA = "0x20CF39C", Offset = "0x20CF39C", VA = "0x20CF39C")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000913")]
			public static bool SigningIn
			{
				[Cpp2IlInjected.Token(Token = "0x600532D")]
				[Cpp2IlInjected.Address(RVA = "0x20CF468", Offset = "0x20CF468", VA = "0x20CF468")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600532E")]
			[Cpp2IlInjected.Address(RVA = "0x20CF4DC", Offset = "0x20CF4DC", VA = "0x20CF4DC")]
			public static void RequestLogin()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600532F")]
			[Cpp2IlInjected.Address(RVA = "0x20CF550", Offset = "0x20CF550", VA = "0x20CF550")]
			public static void Logout()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005330")]
			[Cpp2IlInjected.Address(RVA = "0x20CF5C4", Offset = "0x20CF5C4", VA = "0x20CF5C4")]
			public User()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083C")]
		public static string InstallSource
		{
			[Cpp2IlInjected.Token(Token = "0x6004842")]
			[Cpp2IlInjected.Address(RVA = "0x20CEF48", Offset = "0x20CEF48", VA = "0x20CEF48")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004840")]
		[Cpp2IlInjected.Address(RVA = "0x20CEC4C", Offset = "0x20CEC4C", VA = "0x20CEC4C")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3970A8", Offset = "0x3970A8")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004841")]
		[Cpp2IlInjected.Address(RVA = "0x20CE9E4", Offset = "0x20CE9E4", VA = "0x20CE9E4")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3970DC", Offset = "0x3970DC")]
		public static void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004843")]
		[Cpp2IlInjected.Address(RVA = "0x20CF2C8", Offset = "0x20CF2C8", VA = "0x20CF2C8")]
		public Android()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000768")]
	public enum DrPlatformType
	{
		[Cpp2IlInjected.Token(Token = "0x40077F4")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40077F5")]
		PC = 1,
		[Cpp2IlInjected.Token(Token = "0x40077F6")]
		Google = 2,
		[Cpp2IlInjected.Token(Token = "0x40077F7")]
		iOS = 4,
		[Cpp2IlInjected.Token(Token = "0x40077F8")]
		Amazon = 8,
		[Cpp2IlInjected.Token(Token = "0x40077F9")]
		Steam = 16,
		[Cpp2IlInjected.Token(Token = "0x40077FA")]
		PS4 = 32,
		[Cpp2IlInjected.Token(Token = "0x40077FB")]
		Yahoo = 64,
		[Cpp2IlInjected.Token(Token = "0x40077FC")]
		XBOXONE = 128,
		[Cpp2IlInjected.Token(Token = "0x40077FD")]
		Stadia = 256,
		[Cpp2IlInjected.Token(Token = "0x40077FE")]
		Switch = 512,
		[Cpp2IlInjected.Token(Token = "0x40077FF")]
		Mobile = 14,
		[Cpp2IlInjected.Token(Token = "0x4007800")]
		Console = 672,
		[Cpp2IlInjected.Token(Token = "0x4007801")]
		All = 65535
	}

	[Cpp2IlInjected.Token(Token = "0x2000769")]
	public enum DrSKUType
	{
		[Cpp2IlInjected.Token(Token = "0x4007803")]
		UNKNOWN,
		[Cpp2IlInjected.Token(Token = "0x4007804")]
		SCEE,
		[Cpp2IlInjected.Token(Token = "0x4007805")]
		SCEA,
		[Cpp2IlInjected.Token(Token = "0x4007806")]
		SCEASIA
	}

	[Cpp2IlInjected.Token(Token = "0x200076A")]
	public static class User
	{
		[Cpp2IlInjected.Token(Token = "0x4007807")]
		private static ConcurrentQueue<ChatHelper.ChatRequest> PendingChatRequests;

		[Cpp2IlInjected.Token(Token = "0x4007808")]
		private static ManualResetEvent chatCheckPending;

		[Cpp2IlInjected.Token(Token = "0x4007809")]
		private static ConcurrentQueue<ChatHelper.ChatRequest> CompletedChatRequests;

		[Cpp2IlInjected.Token(Token = "0x400780A")]
		private static ManagedThread PlatformCheckThread;

		[Cpp2IlInjected.Token(Token = "0x400780B")]
		private static object fiitlerOpLock;

		[Cpp2IlInjected.Token(Token = "0x400780C")]
		private static AutoResetEvent fliterOpCompleteEvent;

		[Cpp2IlInjected.Token(Token = "0x1700083D")]
		public static bool PermissionsFetchFailed
		{
			[Cpp2IlInjected.Token(Token = "0x6004844")]
			[Cpp2IlInjected.Address(RVA = "0x20D097C", Offset = "0x20D097C", VA = "0x20D097C")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083E")]
		public static bool HasUserGeneratedContentPermissions
		{
			[Cpp2IlInjected.Token(Token = "0x6004845")]
			[Cpp2IlInjected.Address(RVA = "0x20D09EC", Offset = "0x20D09EC", VA = "0x20D09EC")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700083F")]
		public static bool HasChatPermissions
		{
			[Cpp2IlInjected.Token(Token = "0x6004846")]
			[Cpp2IlInjected.Address(RVA = "0x20D0C80", Offset = "0x20D0C80", VA = "0x20D0C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000840")]
		public static bool IsAgeRestricted
		{
			[Cpp2IlInjected.Token(Token = "0x600484B")]
			[Cpp2IlInjected.Address(RVA = "0x20D11F8", Offset = "0x20D11F8", VA = "0x20D11F8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000841")]
		public static bool IsPatchRequired
		{
			[Cpp2IlInjected.Token(Token = "0x600484C")]
			[Cpp2IlInjected.Address(RVA = "0x20D1268", Offset = "0x20D1268", VA = "0x20D1268")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000842")]
		public static bool HasMultiplayerPermissions
		{
			[Cpp2IlInjected.Token(Token = "0x600484D")]
			[Cpp2IlInjected.Address(RVA = "0x20D12D8", Offset = "0x20D12D8", VA = "0x20D12D8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000060")]
		public static event Action PlatformUserChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600484F")]
			[Cpp2IlInjected.Address(RVA = "0x20D15F0", Offset = "0x20D15F0", VA = "0x20D15F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6004850")]
			[Cpp2IlInjected.Address(RVA = "0x20D16F8", Offset = "0x20D16F8", VA = "0x20D16F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004847")]
		[Cpp2IlInjected.Address(RVA = "0x20CEA58", Offset = "0x20CEA58", VA = "0x20CEA58")]
		public static void UpdateChatRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004848")]
		[Cpp2IlInjected.Address(RVA = "0x20D0ED8", Offset = "0x20D0ED8", VA = "0x20D0ED8")]
		public static void FilterText(string inputText, Action<string> callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004849")]
		[Cpp2IlInjected.Address(RVA = "0x20D0FE8", Offset = "0x20D0FE8", VA = "0x20D0FE8")]
		private static void PlatformCheckCanChatThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600484A")]
		[Cpp2IlInjected.Address(RVA = "0x20D1130", Offset = "0x20D1130", VA = "0x20D1130")]
		public static void CanChatWith(ChatHelper.ChatRequest request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600484E")]
		[Cpp2IlInjected.Address(RVA = "0x20D1538", Offset = "0x20D1538", VA = "0x20D1538")]
		public static void OnPlatformUserChanged()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200076B")]
	public class PS4
	{
		[Cpp2IlInjected.Token(Token = "0x2000B46")]
		public class User
		{
			[Cpp2IlInjected.Token(Token = "0x4008FB8")]
			public static int PrimaryUserID;

			[Cpp2IlInjected.Token(Token = "0x4008FB9")]
			private static bool UGCRestriction;

			[Cpp2IlInjected.Token(Token = "0x4008FBA")]
			private static bool ChatRestriction;

			[Cpp2IlInjected.Token(Token = "0x4008FBB")]
			private static bool PatchRequired;

			[Cpp2IlInjected.Token(Token = "0x4008FBC")]
			private static bool AgeRestricted;

			[Cpp2IlInjected.Token(Token = "0x4008FBD")]
			private static bool MultiplayerRestricted;

			[Cpp2IlInjected.Token(Token = "0x4008FBE")]
			private static bool SetupUserPermissions;

			[Cpp2IlInjected.Token(Token = "0x17000914")]
			public static bool PermissionsFetchFailed
			{
				[Cpp2IlInjected.Token(Token = "0x6005332")]
				[Cpp2IlInjected.Address(RVA = "0x20CFD08", Offset = "0x20CFD08", VA = "0x20CFD08")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000915")]
			public static bool IsPatchRequired
			{
				[Cpp2IlInjected.Token(Token = "0x6005333")]
				[Cpp2IlInjected.Address(RVA = "0x20CFE4C", Offset = "0x20CFE4C", VA = "0x20CFE4C")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000916")]
			public static bool IsAgeRestricted
			{
				[Cpp2IlInjected.Token(Token = "0x6005334")]
				[Cpp2IlInjected.Address(RVA = "0x20CFF18", Offset = "0x20CFF18", VA = "0x20CFF18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000917")]
			public static bool HasUserGeneratedContentPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x6005335")]
				[Cpp2IlInjected.Address(RVA = "0x20CFFE4", Offset = "0x20CFFE4", VA = "0x20CFFE4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000918")]
			public static bool HasChatPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x6005336")]
				[Cpp2IlInjected.Address(RVA = "0x20D00B8", Offset = "0x20D00B8", VA = "0x20D00B8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000919")]
			public static string UserUID
			{
				[Cpp2IlInjected.Token(Token = "0x6005337")]
				[Cpp2IlInjected.Address(RVA = "0x20D018C", Offset = "0x20D018C", VA = "0x20D018C")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700091A")]
			public static string GamerTag
			{
				[Cpp2IlInjected.Token(Token = "0x6005338")]
				[Cpp2IlInjected.Address(RVA = "0x20D01E4", Offset = "0x20D01E4", VA = "0x20D01E4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005331")]
			[Cpp2IlInjected.Address(RVA = "0x20CFD00", Offset = "0x20CFD00", VA = "0x20CFD00")]
			public static void ShowProfile(string playerId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005339")]
			[Cpp2IlInjected.Address(RVA = "0x20D023C", Offset = "0x20D023C", VA = "0x20D023C")]
			public static bool CanViewPlayerOnline(string playerId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600533A")]
			[Cpp2IlInjected.Address(RVA = "0x20D0244", Offset = "0x20D0244", VA = "0x20D0244")]
			[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x398478", Offset = "0x398478")]
			public static void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600533B")]
			[Cpp2IlInjected.Address(RVA = "0x20D0248", Offset = "0x20D0248", VA = "0x20D0248")]
			public static void ResetPermissions()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600533C")]
			[Cpp2IlInjected.Address(RVA = "0x20CFDDC", Offset = "0x20CFDDC", VA = "0x20CFDDC")]
			private static void SetupPermissions()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600533D")]
			[Cpp2IlInjected.Address(RVA = "0x20D02C4", Offset = "0x20D02C4", VA = "0x20D02C4")]
			public User()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400780E")]
		private const float SOCKET_CLEANUP_TIME = 1f;

		[Cpp2IlInjected.Token(Token = "0x400780F")]
		private static bool _setup;

		[Cpp2IlInjected.Token(Token = "0x4007810")]
		private static bool _hasFocus;

		[Cpp2IlInjected.Token(Token = "0x4007811")]
		private static float _socketsTimer;

		[Cpp2IlInjected.Token(Token = "0x4007812")]
		private static DateTime _lastMPNofityMessage;

		[Cpp2IlInjected.Token(Token = "0x4007813")]
		public static bool DisablePlatformChecks;

		[Cpp2IlInjected.Token(Token = "0x4007814")]
		private static bool wasMouseConnected;

		[Cpp2IlInjected.Token(Token = "0x4007815")]
		public static Vector3 lastUnityMousePosition;

		[Cpp2IlInjected.Token(Token = "0x4007816")]
		public static Vector3 MousePosition;

		[Cpp2IlInjected.Token(Token = "0x4007817")]
		public static bool MouseButton0;

		[Cpp2IlInjected.Token(Token = "0x4007818")]
		public static bool MouseButton1;

		[Cpp2IlInjected.Token(Token = "0x4007819")]
		public static bool MouseButton2;

		[Cpp2IlInjected.Token(Token = "0x400781A")]
		public static bool MouseButtonPrev0;

		[Cpp2IlInjected.Token(Token = "0x400781B")]
		public static bool MouseButtonPrev1;

		[Cpp2IlInjected.Token(Token = "0x400781C")]
		public static bool MouseButtonPrev2;

		[Cpp2IlInjected.Token(Token = "0x6004852")]
		[Cpp2IlInjected.Address(RVA = "0x20CF98C", Offset = "0x20CF98C", VA = "0x20CF98C")]
		public static void UpdateMouse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004853")]
		[Cpp2IlInjected.Address(RVA = "0x20CF9FC", Offset = "0x20CF9FC", VA = "0x20CF9FC")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397130", Offset = "0x397130")]
		public static void Update(bool updateFocus = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004854")]
		[Cpp2IlInjected.Address(RVA = "0x20CFA00", Offset = "0x20CFA00", VA = "0x20CFA00")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397164", Offset = "0x397164")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004855")]
		[Cpp2IlInjected.Address(RVA = "0x20CFAAC", Offset = "0x20CFAAC", VA = "0x20CFAAC")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397198", Offset = "0x397198")]
		public static void StartSession()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004856")]
		[Cpp2IlInjected.Address(RVA = "0x20CFAB0", Offset = "0x20CFAB0", VA = "0x20CFAB0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3971CC", Offset = "0x3971CC")]
		public static void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004857")]
		[Cpp2IlInjected.Address(RVA = "0x20CFAB4", Offset = "0x20CFAB4", VA = "0x20CFAB4")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397200", Offset = "0x397200")]
		public static void NotfityMultiplayerRealTimeUsage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004858")]
		[Cpp2IlInjected.Address(RVA = "0x20CFC20", Offset = "0x20CFC20", VA = "0x20CFC20")]
		public PS4()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200076C")]
	public class Stadia
	{
		[Cpp2IlInjected.Token(Token = "0x2000B47")]
		public class User
		{
			[Cpp2IlInjected.Token(Token = "0x4008FBF")]
			private static string savePath;

			[Cpp2IlInjected.Token(Token = "0x1700091B")]
			public static string UserUID
			{
				[Cpp2IlInjected.Token(Token = "0x600533F")]
				[Cpp2IlInjected.Address(RVA = "0x20D02E4", Offset = "0x20D02E4", VA = "0x20D02E4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700091C")]
			public static bool HasMultiplayerPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x6005340")]
				[Cpp2IlInjected.Address(RVA = "0x20D033C", Offset = "0x20D033C", VA = "0x20D033C")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700091D")]
			public static bool HasChatPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x6005341")]
				[Cpp2IlInjected.Address(RVA = "0x20D0344", Offset = "0x20D0344", VA = "0x20D0344")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005342")]
			[Cpp2IlInjected.Address(RVA = "0x20D034C", Offset = "0x20D034C", VA = "0x20D034C")]
			public static void ShowMultiplayerRestrictionOverlay()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005343")]
			[Cpp2IlInjected.Address(RVA = "0x20D03D0", Offset = "0x20D03D0", VA = "0x20D03D0")]
			public User()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600485A")]
		[Cpp2IlInjected.Address(RVA = "0x20D02D0", Offset = "0x20D02D0", VA = "0x20D02D0")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397234", Offset = "0x397234")]
		public static void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600485B")]
		[Cpp2IlInjected.Address(RVA = "0x20D02D4", Offset = "0x20D02D4", VA = "0x20D02D4")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397268", Offset = "0x397268")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600485C")]
		[Cpp2IlInjected.Address(RVA = "0x20D02D8", Offset = "0x20D02D8", VA = "0x20D02D8")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x39729C", Offset = "0x39729C")]
		public static void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600485D")]
		[Cpp2IlInjected.Address(RVA = "0x20D02DC", Offset = "0x20D02DC", VA = "0x20D02DC")]
		public Stadia()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200076D")]
	public class Steam
	{
		[Cpp2IlInjected.Token(Token = "0x2000B48")]
		public class User
		{
			[Cpp2IlInjected.Token(Token = "0x1700091E")]
			public static string UserUID
			{
				[Cpp2IlInjected.Token(Token = "0x6005345")]
				[Cpp2IlInjected.Address(RVA = "0x20D0458", Offset = "0x20D0458", VA = "0x20D0458")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700091F")]
			public static string GamerTag
			{
				[Cpp2IlInjected.Token(Token = "0x6005346")]
				[Cpp2IlInjected.Address(RVA = "0x20D04B0", Offset = "0x20D04B0", VA = "0x20D04B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005347")]
			[Cpp2IlInjected.Address(RVA = "0x20D0508", Offset = "0x20D0508", VA = "0x20D0508")]
			public static string GetAuthSessionTicket()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6005348")]
			[Cpp2IlInjected.Address(RVA = "0x20D0560", Offset = "0x20D0560", VA = "0x20D0560")]
			public User()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600485E")]
		[Cpp2IlInjected.Address(RVA = "0x20D0448", Offset = "0x20D0448", VA = "0x20D0448")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3972D0", Offset = "0x3972D0")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600485F")]
		[Cpp2IlInjected.Address(RVA = "0x20D044C", Offset = "0x20D044C", VA = "0x20D044C")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397304", Offset = "0x397304")]
		public static void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004860")]
		[Cpp2IlInjected.Address(RVA = "0x20D0450", Offset = "0x20D0450", VA = "0x20D0450")]
		public Steam()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200076E")]
	public class Switch
	{
		[Cpp2IlInjected.Token(Token = "0x400781D")]
		private static bool cpuBoost;

		[Cpp2IlInjected.Token(Token = "0x17000843")]
		public static bool Docked
		{
			[Cpp2IlInjected.Token(Token = "0x6004864")]
			[Cpp2IlInjected.Address(RVA = "0x20D0780", Offset = "0x20D0780", VA = "0x20D0780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000844")]
		public static bool CPUBoostMode
		{
			[Cpp2IlInjected.Token(Token = "0x6004866")]
			[Cpp2IlInjected.Address(RVA = "0x20D08F0", Offset = "0x20D08F0", VA = "0x20D08F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6004867")]
			[Cpp2IlInjected.Address(RVA = "0x20D05EC", Offset = "0x20D05EC", VA = "0x20D05EC")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004861")]
		[Cpp2IlInjected.Address(RVA = "0x20D0568", Offset = "0x20D0568", VA = "0x20D0568")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397338", Offset = "0x397338")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004862")]
		[Cpp2IlInjected.Address(RVA = "0x20D0778", Offset = "0x20D0778", VA = "0x20D0778")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x39736C", Offset = "0x39736C")]
		public static void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004863")]
		[Cpp2IlInjected.Address(RVA = "0x20D077C", Offset = "0x20D077C", VA = "0x20D077C")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3973A0", Offset = "0x3973A0")]
		public static void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004865")]
		[Cpp2IlInjected.Address(RVA = "0x20D07FC", Offset = "0x20D07FC", VA = "0x20D07FC")]
		private static void SetCpuBoostMode(object data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004868")]
		[Cpp2IlInjected.Address(RVA = "0x20D0968", Offset = "0x20D0968", VA = "0x20D0968")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3973D4", Offset = "0x3973D4")]
		public static void ShowProfile(PlatformUser user)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004869")]
		[Cpp2IlInjected.Address(RVA = "0x20D096C", Offset = "0x20D096C", VA = "0x20D096C")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397408", Offset = "0x397408")]
		public static void FilterText(ref string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600486A")]
		[Cpp2IlInjected.Address(RVA = "0x20D0970", Offset = "0x20D0970", VA = "0x20D0970")]
		public Switch()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200076F")]
	public class XBO
	{
		[Cpp2IlInjected.Token(Token = "0x2000B49")]
		public class User
		{
			[Cpp2IlInjected.Token(Token = "0x17000920")]
			public static bool XBOGoldAccount
			{
				[Cpp2IlInjected.Token(Token = "0x6005349")]
				[Cpp2IlInjected.Address(RVA = "0x20D1A70", Offset = "0x20D1A70", VA = "0x20D1A70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000921")]
			public static bool HasMultiplayerPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x600534A")]
				[Cpp2IlInjected.Address(RVA = "0x20D1530", Offset = "0x20D1530", VA = "0x20D1530")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000922")]
			public static bool HasUserGeneratedContentPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x600534B")]
				[Cpp2IlInjected.Address(RVA = "0x20D0C78", Offset = "0x20D0C78", VA = "0x20D0C78")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000923")]
			public static bool HasChatPermissions
			{
				[Cpp2IlInjected.Token(Token = "0x600534C")]
				[Cpp2IlInjected.Address(RVA = "0x20D1A78", Offset = "0x20D1A78", VA = "0x20D1A78")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000924")]
			public static string UserUID
			{
				[Cpp2IlInjected.Token(Token = "0x600534D")]
				[Cpp2IlInjected.Address(RVA = "0x20D1A80", Offset = "0x20D1A80", VA = "0x20D1A80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000925")]
			public static int LocalUserId
			{
				[Cpp2IlInjected.Token(Token = "0x600534E")]
				[Cpp2IlInjected.Address(RVA = "0x20D1AD8", Offset = "0x20D1AD8", VA = "0x20D1AD8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000926")]
			public static string GamerTag
			{
				[Cpp2IlInjected.Token(Token = "0x600534F")]
				[Cpp2IlInjected.Address(RVA = "0x20D1AE0", Offset = "0x20D1AE0", VA = "0x20D1AE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005350")]
			[Cpp2IlInjected.Address(RVA = "0x20D1AE8", Offset = "0x20D1AE8", VA = "0x20D1AE8")]
			[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3984AC", Offset = "0x3984AC")]
			public static void Start()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005351")]
			[Cpp2IlInjected.Address(RVA = "0x20D1AEC", Offset = "0x20D1AEC", VA = "0x20D1AEC")]
			[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3984E0", Offset = "0x3984E0")]
			public static void ShowGamerCard(string xboPlayerId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005352")]
			[Cpp2IlInjected.Address(RVA = "0x20D1AF4", Offset = "0x20D1AF4", VA = "0x20D1AF4")]
			public User()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400781E")]
		private static bool _setup;

		[Cpp2IlInjected.Token(Token = "0x600486C")]
		[Cpp2IlInjected.Address(RVA = "0x20D1930", Offset = "0x20D1930", VA = "0x20D1930")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x39743C", Offset = "0x39743C")]
		public static void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600486D")]
		[Cpp2IlInjected.Address(RVA = "0x20D1934", Offset = "0x20D1934", VA = "0x20D1934")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397470", Offset = "0x397470")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600486E")]
		[Cpp2IlInjected.Address(RVA = "0x20D19E0", Offset = "0x20D19E0", VA = "0x20D19E0")]
		private static void Suspending()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600486F")]
		[Cpp2IlInjected.Address(RVA = "0x20D1A54", Offset = "0x20D1A54", VA = "0x20D1A54")]
		private static void Resuming(double span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004870")]
		[Cpp2IlInjected.Address(RVA = "0x20D1A58", Offset = "0x20D1A58", VA = "0x20D1A58")]
		private static void ResourceAvailabilityChangedEvent(bool amConstrained)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004871")]
		[Cpp2IlInjected.Address(RVA = "0x20D1A5C", Offset = "0x20D1A5C", VA = "0x20D1A5C")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3974A4", Offset = "0x3974A4")]
		public static void StartSession()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004872")]
		[Cpp2IlInjected.Address(RVA = "0x20D1A60", Offset = "0x20D1A60", VA = "0x20D1A60")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x3974D8", Offset = "0x3974D8")]
		public static void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004873")]
		[Cpp2IlInjected.Address(RVA = "0x20D1A64", Offset = "0x20D1A64", VA = "0x20D1A64")]
		public XBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000770")]
	public class IOS
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4A")]
		public class User
		{
			[Cpp2IlInjected.Token(Token = "0x2000BCD")]
			public enum UserState
			{
				[Cpp2IlInjected.Token(Token = "0x4009163")]
				LoadedFromCache,
				[Cpp2IlInjected.Token(Token = "0x4009164")]
				SignedIn,
				[Cpp2IlInjected.Token(Token = "0x4009165")]
				SignedOut
			}

			[Cpp2IlInjected.Token(Token = "0x17000927")]
			public static bool SigningIn
			{
				[Cpp2IlInjected.Token(Token = "0x6005353")]
				[Cpp2IlInjected.Address(RVA = "0x20CF83C", Offset = "0x20CF83C", VA = "0x20CF83C")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000928")]
			public static UserState LoginState
			{
				[Cpp2IlInjected.Token(Token = "0x6005355")]
				[Cpp2IlInjected.Address(RVA = "0x20CE650", Offset = "0x20CE650", VA = "0x20CE650")]
				get
				{
					return default(UserState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000929")]
			public static string UserUID
			{
				[Cpp2IlInjected.Token(Token = "0x6005356")]
				[Cpp2IlInjected.Address(RVA = "0x20CE864", Offset = "0x20CE864", VA = "0x20CE864")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700092A")]
			public static string GamerTag
			{
				[Cpp2IlInjected.Token(Token = "0x6005357")]
				[Cpp2IlInjected.Address(RVA = "0x20CF8B8", Offset = "0x20CF8B8", VA = "0x20CF8B8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005354")]
			[Cpp2IlInjected.Address(RVA = "0x20CF844", Offset = "0x20CF844", VA = "0x20CF844")]
			public static void RequestSignIn()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005358")]
			[Cpp2IlInjected.Address(RVA = "0x20CF984", Offset = "0x20CF984", VA = "0x20CF984")]
			public User()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400781F")]
		private static iOS_Mouse _mouse;

		[Cpp2IlInjected.Token(Token = "0x4007820")]
		private const string c_gamecenterSettingsURL = "App-Prefs:root=GAMECENTER";

		[Cpp2IlInjected.Token(Token = "0x17000845")]
		public static iOS_Mouse Mouse
		{
			[Cpp2IlInjected.Token(Token = "0x6004875")]
			[Cpp2IlInjected.Address(RVA = "0x20CF5CC", Offset = "0x20CF5CC", VA = "0x20CF5CC")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000846")]
		public static string AppID
		{
			[Cpp2IlInjected.Token(Token = "0x6004879")]
			[Cpp2IlInjected.Address(RVA = "0x20CE510", Offset = "0x20CE510", VA = "0x20CE510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004876")]
		[Cpp2IlInjected.Address(RVA = "0x20CF678", Offset = "0x20CF678", VA = "0x20CF678")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x39750C", Offset = "0x39750C")]
		public static void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004877")]
		[Cpp2IlInjected.Address(RVA = "0x20CF6EC", Offset = "0x20CF6EC", VA = "0x20CF6EC")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397540", Offset = "0x397540")]
		public static void Setup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004878")]
		[Cpp2IlInjected.Address(RVA = "0x20CF76C", Offset = "0x20CF76C", VA = "0x20CF76C")]
		[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x397574", Offset = "0x397574")]
		public static void OpenGameCentreSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600487A")]
		[Cpp2IlInjected.Address(RVA = "0x20CF7C4", Offset = "0x20CF7C4", VA = "0x20CF7C4")]
		public static void UpdateMouse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600487B")]
		[Cpp2IlInjected.Address(RVA = "0x20CF834", Offset = "0x20CF834", VA = "0x20CF834")]
		public IOS()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static bool? isChromebook;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static Thread MainThread;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static string DeviceModel;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static bool ConnectionDown;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static Guid SessionId;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool IsChromebook
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x20CDBA8", Offset = "0x20CDBA8", VA = "0x20CDBA8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static DrPlatformType CurrentPlatform
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x20C819C", Offset = "0x20C819C", VA = "0x20C819C")]
		get
		{
			return default(DrPlatformType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static DrSKUType CurrentSKU
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x20CE46C", Offset = "0x20CE46C", VA = "0x20CE46C")]
		get
		{
			return default(DrSKUType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static bool IsMainThread
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x20CEB1C", Offset = "0x20CEB1C", VA = "0x20CEB1C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static bool IsUIHighlightEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x20CEE24", Offset = "0x20CEE24", VA = "0x20CEE24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static string InstallSource
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x20CEEB4", Offset = "0x20CEEB4", VA = "0x20CEEB4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x20CE474", Offset = "0x20CE474", VA = "0x20CE474")]
	public static void OpenStoreURL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x20CB76C", Offset = "0x20CB76C", VA = "0x20CB76C")]
	public static bool IsCurrentPlatform(DrPlatformType platform)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x20CE560", Offset = "0x20CE560", VA = "0x20CE560")]
	public static bool IsCachedSignIn()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20CE71C", Offset = "0x20CE71C", VA = "0x20CE71C")]
	public static bool IsSignedInToCurrentPlatform()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20CE930", Offset = "0x20CE930", VA = "0x20CE930")]
	public static bool PlatformMatches(DrPlatformType platformCompare1, DrPlatformType platformCompare2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x20CE93C", Offset = "0x20CE93C", VA = "0x20CE93C")]
	public static void Update(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x20CEBA8", Offset = "0x20CEBA8", VA = "0x20CEBA8")]
	public static void Setup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x20CEC58", Offset = "0x20CEC58", VA = "0x20CEC58")]
	public static void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x20CECE0", Offset = "0x20CECE0", VA = "0x20CECE0")]
	public static void StartSession()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x20CEDA8", Offset = "0x20CEDA8", VA = "0x20CEDA8")]
	private static void SetConnectionDown(bool connectionDown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x20CECDC", Offset = "0x20CECDC", VA = "0x20CECDC")]
	private static void SetVSyncCount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x20CF2BC", Offset = "0x20CF2BC", VA = "0x20CF2BC")]
	public DrPlatform()
	{
	}
}
