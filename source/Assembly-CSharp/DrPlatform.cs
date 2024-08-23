using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Chat;
using Terraria.IO;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000020 RID: 32
[global::Cpp2ILInjected.Token(Token = "0x2000026")]
public class DrPlatform
{
	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00021DAC File Offset: 0x0001FFAC
	[global::Cpp2ILInjected.Token(Token = "0x17000038")]
	public static bool IsChromebook
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x7006C0", Offset = "0x7006C0", Length = "0x898")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000BD RID: 189 RVA: 0x00021DAF File Offset: 0x0001FFAF
	[global::Cpp2ILInjected.Token(Token = "0x17000039")]
	public static DrPlatform.DrPlatformType CurrentPlatform
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FD800", Offset = "0x6FD800", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 156)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00021DB2 File Offset: 0x0001FFB2
	[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
	public static DrPlatform.DrSKUType CurrentSKU
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x700F58", Offset = "0x700F58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00021DB5 File Offset: 0x0001FFB5
	[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
	[global::Cpp2ILInjected.Address(RVA = "0x700F60", Offset = "0x700F60", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void OpenStoreURL()
	{
		throw null;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00021DB8 File Offset: 0x0001FFB8
	[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE3C4", Offset = "0x6FE3C4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 130)]
	public static bool IsCurrentPlatform(DrPlatform.DrPlatformType platform)
	{
		throw null;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00021DBB File Offset: 0x0001FFBB
	[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
	[global::Cpp2ILInjected.Address(RVA = "0x701028", Offset = "0x701028", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Android.User), Member = "get_CurrentLoginState", ReturnType = typeof(DrPlatform.Android.User.LoginState))]
	public static bool IsCachedSignIn()
	{
		throw null;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00021DBE File Offset: 0x0001FFBE
	[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
	[global::Cpp2ILInjected.Address(RVA = "0x701114", Offset = "0x701114", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Android.User), Member = "get_UserUID", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static bool IsSignedInToCurrentPlatform()
	{
		throw null;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00021DC1 File Offset: 0x0001FFC1
	[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
	[global::Cpp2ILInjected.Address(RVA = "0x701270", Offset = "0x701270", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static bool PlatformMatches(DrPlatform.DrPlatformType platformCompare1, DrPlatform.DrPlatformType platformCompare2)
	{
		throw null;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00021DC4 File Offset: 0x0001FFC4
	[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
	[global::Cpp2ILInjected.Address(RVA = "0x70127C", Offset = "0x70127C", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteSnippets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Android), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "UpdateChatRequests", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void Update(float elapsedTime)
	{
		throw null;
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x00021DC7 File Offset: 0x0001FFC7
	[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
	public static bool IsMainThread
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x701458", Offset = "0x701458", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Switch), Member = "set_CPUBoostMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Singleton<>), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00021DCA File Offset: 0x0001FFCA
	[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
	[global::Cpp2ILInjected.Address(RVA = "0x7014B0", Offset = "0x7014B0", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Awake", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_deviceModel", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_simulateMouseWithTouches", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void Setup()
	{
		throw null;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00021DCD File Offset: 0x0001FFCD
	[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
	[global::Cpp2ILInjected.Address(RVA = "0x701528", Offset = "0x701528", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "get_deviceModel", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void Start()
	{
		throw null;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00021DD0 File Offset: 0x0001FFD0
	[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
	[global::Cpp2ILInjected.Address(RVA = "0x70157C", Offset = "0x70157C", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void StartSession()
	{
		throw null;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00021DD3 File Offset: 0x0001FFD3
	[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
	[global::Cpp2ILInjected.Address(RVA = "0x7015D0", Offset = "0x7015D0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void SetConnectionDown(bool connectionDown)
	{
		throw null;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00021DD6 File Offset: 0x0001FFD6
	[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
	[global::Cpp2ILInjected.Address(RVA = "0x701578", Offset = "0x701578", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static void SetVSyncCount()
	{
		throw null;
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000CB RID: 203 RVA: 0x00021DD9 File Offset: 0x0001FFD9
	[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
	public static bool IsUIHighlightEnabled
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x70161C", Offset = "0x70161C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000CC RID: 204 RVA: 0x00021DDC File Offset: 0x0001FFDC
	[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
	public static string InstallSource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x701624", Offset = "0x701624", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00021DDF File Offset: 0x0001FFDF
	[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
	[global::Cpp2ILInjected.Address(RVA = "0x70197C", Offset = "0x70197C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public DrPlatform()
	{
		throw null;
	}

	// Token: 0x0400007C RID: 124
	[global::Cpp2ILInjected.Token(Token = "0x4000089")]
	private static bool? isChromebook;

	// Token: 0x0400007D RID: 125
	[global::Cpp2ILInjected.Token(Token = "0x400008A")]
	public static Thread MainThread;

	// Token: 0x0400007E RID: 126
	[global::Cpp2ILInjected.Token(Token = "0x400008B")]
	public static string DeviceModel;

	// Token: 0x0400007F RID: 127
	[global::Cpp2ILInjected.Token(Token = "0x400008C")]
	public static bool ConnectionDown;

	// Token: 0x04000080 RID: 128
	[global::Cpp2ILInjected.Token(Token = "0x400008D")]
	public static Guid SessionId;

	// Token: 0x02000770 RID: 1904
	[global::Cpp2ILInjected.Token(Token = "0x2000027")]
	public class Android
	{
		// Token: 0x0600480C RID: 18444 RVA: 0x0002EDA5 File Offset: 0x0002CFA5
		[Conditional("UNITY_ANDROID")]
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x70151C", Offset = "0x70151C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_simulateMouseWithTouches", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0002EDA8 File Offset: 0x0002CFA8
		[Conditional("UNITY_ANDROID")]
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x70136C", Offset = "0x70136C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x0002EDAB File Offset: 0x0002CFAB
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public static string InstallSource
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x70167C", Offset = "0x70167C", Length = "0x300")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = "ReturnType")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x0002EDAE File Offset: 0x0002CFAE
		[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x701984", Offset = "0x701984", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Android()
		{
			throw null;
		}

		// Token: 0x02000B4E RID: 2894
		[global::Cpp2ILInjected.Token(Token = "0x2000028")]
		public class User
		{
			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x060052F2 RID: 21234 RVA: 0x00030A1C File Offset: 0x0002EC1C
			[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
			public static string UserUID
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
				[global::Cpp2ILInjected.Address(RVA = "0x701160", Offset = "0x701160", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform), Member = "IsSignedInToCurrentPlatform", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x060052F3 RID: 21235 RVA: 0x00030A1F File Offset: 0x0002EC1F
			[global::Cpp2ILInjected.Token(Token = "0x17000040")]
			public static string GamerTag
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
				[global::Cpp2ILInjected.Address(RVA = "0x70198C", Offset = "0x70198C", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x060052F4 RID: 21236 RVA: 0x00030A22 File Offset: 0x0002EC22
			[global::Cpp2ILInjected.Token(Token = "0x17000041")]
			public static DrPlatform.Android.User.LoginState CurrentLoginState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
				[global::Cpp2ILInjected.Address(RVA = "0x701040", Offset = "0x701040", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform), Member = "IsCachedSignIn", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_CurrentState", ReturnType = typeof(DrPlatform.Android.User.LoginState))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x060052F5 RID: 21237 RVA: 0x00030A25 File Offset: 0x0002EC25
			[global::Cpp2ILInjected.Token(Token = "0x17000042")]
			public static string AccountProfileURL
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
				[global::Cpp2ILInjected.Address(RVA = "0x701A14", Offset = "0x701A14", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x060052F6 RID: 21238 RVA: 0x00030A28 File Offset: 0x0002EC28
			[global::Cpp2ILInjected.Token(Token = "0x17000043")]
			public static bool SigningIn
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
				[global::Cpp2ILInjected.Address(RVA = "0x701A9C", Offset = "0x701A9C", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "get_AttemptingSignIn", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060052F7 RID: 21239 RVA: 0x00030A2B File Offset: 0x0002EC2B
			[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x701AE8", Offset = "0x701AE8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "RequestLogin", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void RequestLogin()
			{
				throw null;
			}

			// Token: 0x060052F8 RID: 21240 RVA: 0x00030A2E File Offset: 0x0002EC2E
			[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x701B34", Offset = "0x701B34", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Android_UserManager), Member = "Logout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void Logout()
			{
				throw null;
			}

			// Token: 0x060052F9 RID: 21241 RVA: 0x00030A31 File Offset: 0x0002EC31
			[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x701B80", Offset = "0x701B80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public User()
			{
				throw null;
			}

			// Token: 0x02000BD5 RID: 3029
			[global::Cpp2ILInjected.Token(Token = "0x2000029")]
			public enum LoginState
			{
				// Token: 0x04009170 RID: 37232
				[global::Cpp2ILInjected.Token(Token = "0x400008F")]
				Waiting,
				// Token: 0x04009171 RID: 37233
				[global::Cpp2ILInjected.Token(Token = "0x4000090")]
				LoggingIn,
				// Token: 0x04009172 RID: 37234
				[global::Cpp2ILInjected.Token(Token = "0x4000091")]
				LoggedIn,
				// Token: 0x04009173 RID: 37235
				[global::Cpp2ILInjected.Token(Token = "0x4000092")]
				FromCache,
				// Token: 0x04009174 RID: 37236
				[global::Cpp2ILInjected.Token(Token = "0x4000093")]
				LoggedOut
			}
		}
	}

	// Token: 0x02000771 RID: 1905
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public enum DrPlatformType
	{
		// Token: 0x04007805 RID: 30725
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		None,
		// Token: 0x04007806 RID: 30726
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		PC,
		// Token: 0x04007807 RID: 30727
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		Google,
		// Token: 0x04007808 RID: 30728
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		iOS = 4,
		// Token: 0x04007809 RID: 30729
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		Amazon = 8,
		// Token: 0x0400780A RID: 30730
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		Steam = 16,
		// Token: 0x0400780B RID: 30731
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		PS4 = 32,
		// Token: 0x0400780C RID: 30732
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		Yahoo = 64,
		// Token: 0x0400780D RID: 30733
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		XBOXONE = 128,
		// Token: 0x0400780E RID: 30734
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		Stadia = 256,
		// Token: 0x0400780F RID: 30735
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		Switch = 512,
		// Token: 0x04007810 RID: 30736
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		Mobile = 14,
		// Token: 0x04007811 RID: 30737
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		Console = 672,
		// Token: 0x04007812 RID: 30738
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		All = 65535
	}

	// Token: 0x02000772 RID: 1906
	[global::Cpp2ILInjected.Token(Token = "0x200002B")]
	public enum DrSKUType
	{
		// Token: 0x04007814 RID: 30740
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		UNKNOWN,
		// Token: 0x04007815 RID: 30741
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		SCEE,
		// Token: 0x04007816 RID: 30742
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		SCEA,
		// Token: 0x04007817 RID: 30743
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		SCEASIA
	}

	// Token: 0x02000773 RID: 1907
	[global::Cpp2ILInjected.Token(Token = "0x200002C")]
	public static class User
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06004810 RID: 18448 RVA: 0x0002EDB1 File Offset: 0x0002CFB1
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public static bool PermissionsFetchFailed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x701B88", Offset = "0x701B88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public static bool HasUserGeneratedContentPermissions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x701C18", Offset = "0x701C18", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x0002EDB7 File Offset: 0x0002CFB7
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public static bool HasChatPermissions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x701DFC", Offset = "0x701DFC", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.User), Member = "CanChatWith", MemberParameters = new object[] { typeof(ChatHelper.ChatRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "OpenChat", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayMessage", MemberParameters = new object[]
			{
				typeof(NetworkText),
				typeof(Microsoft.Xna.Framework.Graphics.Color),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x0002EDBA File Offset: 0x0002CFBA
		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7013B8", Offset = "0x7013B8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void UpdateChatRequests()
		{
			throw null;
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x0002EDBD File Offset: 0x0002CFBD
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x701F38", Offset = "0x701F38", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void FilterText(string inputText, Action<string> callback)
		{
			throw null;
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x0002EDC0 File Offset: 0x0002CFC0
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x70204C", Offset = "0x70204C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void PlatformCheckCanChatThread()
		{
			throw null;
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x0002EDC3 File Offset: 0x0002CFC3
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x70214C", Offset = "0x70214C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "PlatformCheckedMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "get_HasChatPermissions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CanChatWith(ChatHelper.ChatRequest request)
		{
			throw null;
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x0002EDC6 File Offset: 0x0002CFC6
		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		public static bool IsAgeRestricted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x7022E8", Offset = "0x7022E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x0002EDC9 File Offset: 0x0002CFC9
		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		public static bool IsPatchRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x702364", Offset = "0x702364", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x0002EDCC File Offset: 0x0002CFCC
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		public static bool HasMultiplayerPermissions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x7023E0", Offset = "0x7023E0", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "SelectMultiplayer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x0002EDCF File Offset: 0x0002CFCF
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7003E4", Offset = "0x7003E4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "playerLoggedOut", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Android_UserManager), Member = "playerAuthenticated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(iOS_UserManager), Member = "UpdateUser", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void OnPlatformUserChanged()
		{
			throw null;
		}

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x0600481B RID: 18459 RVA: 0x0002EDD2 File Offset: 0x0002CFD2
		// (remove) Token: 0x0600481C RID: 18460 RVA: 0x0002EDD5 File Offset: 0x0002CFD5
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public static event Action PlatformUserChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x70251C", Offset = "0x70251C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x7025F8", Offset = "0x7025F8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7026D4", Offset = "0x7026D4", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static User()
		{
			throw null;
		}

		// Token: 0x04007818 RID: 30744
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		private static ConcurrentQueue<ChatHelper.ChatRequest> PendingChatRequests;

		// Token: 0x04007819 RID: 30745
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		private static ManualResetEvent chatCheckPending;

		// Token: 0x0400781A RID: 30746
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		private static ConcurrentQueue<ChatHelper.ChatRequest> CompletedChatRequests;

		// Token: 0x0400781B RID: 30747
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		private static ManagedThread PlatformCheckThread;

		// Token: 0x0400781C RID: 30748
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		private static object fiitlerOpLock;

		// Token: 0x0400781D RID: 30749
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		private static AutoResetEvent fliterOpCompleteEvent;

		// Token: 0x0400781E RID: 30750
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		private static Action PlatformUserChanged;
	}

	// Token: 0x02000774 RID: 1908
	[global::Cpp2ILInjected.Token(Token = "0x200002D")]
	public class IOS
	{
		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x0002EDDB File Offset: 0x0002CFDB
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		public static iOS_Mouse Mouse
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x70282C", Offset = "0x70282C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "get_MousePosition", ReturnType = typeof(global::UnityEngine.Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseScrollDelta", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonUp", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "GetMouseButtonDown", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_HasHWCursor", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x0002EDDE File Offset: 0x0002CFDE
		[Conditional("UNITY_IOS")]
		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7028E0", Offset = "0x7028E0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x0002EDE1 File Offset: 0x0002CFE1
		[Conditional("UNITY_IOS")]
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x702AD8", Offset = "0x702AD8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_simulateMouseWithTouches", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		[Conditional("UNITY_IOS")]
		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x702C50", Offset = "0x702C50", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void OpenGameCentreSettings()
		{
			throw null;
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x0002EDE7 File Offset: 0x0002CFE7
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public static string AppID
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x700FE8", Offset = "0x700FE8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x0002EDEA File Offset: 0x0002CFEA
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x702C94", Offset = "0x702C94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void UpdateMouse()
		{
			throw null;
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x0002EDED File Offset: 0x0002CFED
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x702D88", Offset = "0x702D88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IOS()
		{
			throw null;
		}

		// Token: 0x0400781F RID: 30751
		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		private static iOS_Mouse _mouse;

		// Token: 0x04007820 RID: 30752
		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		private const string c_gamecenterSettingsURL = "App-Prefs:root=GAMECENTER";

		// Token: 0x02000B4F RID: 2895
		[global::Cpp2ILInjected.Token(Token = "0x200002E")]
		public class User
		{
			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x060052FA RID: 21242 RVA: 0x00030A34 File Offset: 0x0002EC34
			[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
			public static bool SigningIn
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
				[global::Cpp2ILInjected.Address(RVA = "0x702D90", Offset = "0x702D90", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060052FB RID: 21243 RVA: 0x00030A37 File Offset: 0x0002EC37
			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x702D98", Offset = "0x702D98", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void RequestSignIn()
			{
				throw null;
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x060052FC RID: 21244 RVA: 0x00030A3A File Offset: 0x0002EC3A
			[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
			public static DrPlatform.IOS.User.UserState LoginState
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
				[global::Cpp2ILInjected.Address(RVA = "0x70108C", Offset = "0x70108C", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x060052FD RID: 21245 RVA: 0x00030A3D File Offset: 0x0002EC3D
			[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
			public static string UserUID
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
				[global::Cpp2ILInjected.Address(RVA = "0x7011E8", Offset = "0x7011E8", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x060052FE RID: 21246 RVA: 0x00030A40 File Offset: 0x0002EC40
			[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
			public static string GamerTag
			{
				[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
				[global::Cpp2ILInjected.Address(RVA = "0x702E40", Offset = "0x702E40", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060052FF RID: 21247 RVA: 0x00030A43 File Offset: 0x0002EC43
			[global::Cpp2ILInjected.Token(Token = "0x6000100")]
			[global::Cpp2ILInjected.Address(RVA = "0x702EC8", Offset = "0x702EC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public User()
			{
				throw null;
			}

			// Token: 0x02000BD6 RID: 3030
			[global::Cpp2ILInjected.Token(Token = "0x200002F")]
			public enum UserState
			{
				// Token: 0x04009176 RID: 37238
				[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
				LoadedFromCache,
				// Token: 0x04009177 RID: 37239
				[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
				SignedIn,
				// Token: 0x04009178 RID: 37240
				[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
				SignedOut
			}
		}
	}

	// Token: 0x02000775 RID: 1909
	[global::Cpp2ILInjected.Token(Token = "0x2000030")]
	public class PS4
	{
		// Token: 0x06004825 RID: 18469 RVA: 0x0002EDF0 File Offset: 0x0002CFF0
		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x702ED0", Offset = "0x702ED0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void UpdateMouse()
		{
			throw null;
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x0002EDF3 File Offset: 0x0002CFF3
		[Conditional("UNITY_PS4")]
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x702EFC", Offset = "0x702EFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Update(bool updateFocus = false)
		{
			throw null;
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x0002EDF6 File Offset: 0x0002CFF6
		[Conditional("UNITY_PS4")]
		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x702F00", Offset = "0x702F00", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x0002EDF9 File Offset: 0x0002CFF9
		[Conditional("UNITY_PS4")]
		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x702F78", Offset = "0x702F78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void StartSession()
		{
			throw null;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x0002EDFC File Offset: 0x0002CFFC
		[Conditional("UNITY_PS4")]
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x702F7C", Offset = "0x702F7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Start()
		{
			throw null;
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x0002EDFF File Offset: 0x0002CFFF
		[Conditional("UNITY_PS4")]
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x702F80", Offset = "0x702F80", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void NotfityMultiplayerRealTimeUsage()
		{
			throw null;
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x0002EE02 File Offset: 0x0002D002
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x70307C", Offset = "0x70307C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PS4()
		{
			throw null;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x0002EE05 File Offset: 0x0002D005
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x703084", Offset = "0x703084", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PS4()
		{
			throw null;
		}

		// Token: 0x04007821 RID: 30753
		[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
		private const float SOCKET_CLEANUP_TIME = 1f;

		// Token: 0x04007822 RID: 30754
		[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
		private static bool _setup;

		// Token: 0x04007823 RID: 30755
		[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
		private static bool _hasFocus;

		// Token: 0x04007824 RID: 30756
		[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
		private static float _socketsTimer;

		// Token: 0x04007825 RID: 30757
		[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
		private static DateTime _lastMPNofityMessage;

		// Token: 0x04007826 RID: 30758
		[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
		public static bool DisablePlatformChecks;

		// Token: 0x04007827 RID: 30759
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		private static bool wasMouseConnected;

		// Token: 0x04007828 RID: 30760
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		public static global::UnityEngine.Vector3 lastUnityMousePosition;

		// Token: 0x04007829 RID: 30761
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		public static global::UnityEngine.Vector3 MousePosition;

		// Token: 0x0400782A RID: 30762
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		public static bool MouseButton0;

		// Token: 0x0400782B RID: 30763
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		public static bool MouseButton1;

		// Token: 0x0400782C RID: 30764
		[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
		public static bool MouseButton2;

		// Token: 0x0400782D RID: 30765
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		public static bool MouseButtonPrev0;

		// Token: 0x0400782E RID: 30766
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		public static bool MouseButtonPrev1;

		// Token: 0x0400782F RID: 30767
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		public static bool MouseButtonPrev2;

		// Token: 0x02000B50 RID: 2896
		[global::Cpp2ILInjected.Token(Token = "0x2000031")]
		public class User
		{
			// Token: 0x06005300 RID: 21248 RVA: 0x00030A46 File Offset: 0x0002EC46
			[global::Cpp2ILInjected.Token(Token = "0x6000109")]
			[global::Cpp2ILInjected.Address(RVA = "0x70311C", Offset = "0x70311C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawSelectedPlayerPlatformControls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			public static void ShowProfile(string playerId)
			{
				throw null;
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x06005301 RID: 21249 RVA: 0x00030A49 File Offset: 0x0002EC49
			[global::Cpp2ILInjected.Token(Token = "0x17000050")]
			public static bool PermissionsFetchFailed
			{
				[global::Cpp2ILInjected.Token(Token = "0x600010A")]
				[global::Cpp2ILInjected.Address(RVA = "0x701B90", Offset = "0x701B90", Length = "0x88")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x06005302 RID: 21250 RVA: 0x00030A4C File Offset: 0x0002EC4C
			[global::Cpp2ILInjected.Token(Token = "0x17000051")]
			public static bool IsPatchRequired
			{
				[global::Cpp2ILInjected.Token(Token = "0x600010B")]
				[global::Cpp2ILInjected.Address(RVA = "0x70236C", Offset = "0x70236C", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x06005303 RID: 21251 RVA: 0x00030A4F File Offset: 0x0002EC4F
			[global::Cpp2ILInjected.Token(Token = "0x17000052")]
			public static bool IsAgeRestricted
			{
				[global::Cpp2ILInjected.Token(Token = "0x600010C")]
				[global::Cpp2ILInjected.Address(RVA = "0x7022F0", Offset = "0x7022F0", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x06005304 RID: 21252 RVA: 0x00030A52 File Offset: 0x0002EC52
			[global::Cpp2ILInjected.Token(Token = "0x17000053")]
			public static bool HasUserGeneratedContentPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600010D")]
				[global::Cpp2ILInjected.Address(RVA = "0x701D78", Offset = "0x701D78", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x06005305 RID: 21253 RVA: 0x00030A55 File Offset: 0x0002EC55
			[global::Cpp2ILInjected.Token(Token = "0x17000054")]
			public static bool HasChatPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600010E")]
				[global::Cpp2ILInjected.Address(RVA = "0x703150", Offset = "0x703150", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06005306 RID: 21254 RVA: 0x00030A58 File Offset: 0x0002EC58
			[global::Cpp2ILInjected.Token(Token = "0x17000055")]
			public static string UserUID
			{
				[global::Cpp2ILInjected.Token(Token = "0x600010F")]
				[global::Cpp2ILInjected.Address(RVA = "0x7031CC", Offset = "0x7031CC", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06005307 RID: 21255 RVA: 0x00030A5B File Offset: 0x0002EC5B
			[global::Cpp2ILInjected.Token(Token = "0x17000056")]
			public static string GamerTag
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000110")]
				[global::Cpp2ILInjected.Address(RVA = "0x703214", Offset = "0x703214", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005308 RID: 21256 RVA: 0x00030A5E File Offset: 0x0002EC5E
			[global::Cpp2ILInjected.Token(Token = "0x6000111")]
			[global::Cpp2ILInjected.Address(RVA = "0x70325C", Offset = "0x70325C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool CanViewPlayerOnline(string playerId)
			{
				throw null;
			}

			// Token: 0x06005309 RID: 21257 RVA: 0x00030A61 File Offset: 0x0002EC61
			[Conditional("UNITY_PS4")]
			[global::Cpp2ILInjected.Token(Token = "0x6000112")]
			[global::Cpp2ILInjected.Address(RVA = "0x703264", Offset = "0x703264", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static void Start()
			{
				throw null;
			}

			// Token: 0x0600530A RID: 21258 RVA: 0x00030A64 File Offset: 0x0002EC64
			[global::Cpp2ILInjected.Token(Token = "0x6000113")]
			[global::Cpp2ILInjected.Address(RVA = "0x703268", Offset = "0x703268", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public static void ResetPermissions()
			{
				throw null;
			}

			// Token: 0x0600530B RID: 21259 RVA: 0x00030A67 File Offset: 0x0002EC67
			[global::Cpp2ILInjected.Token(Token = "0x6000114")]
			[global::Cpp2ILInjected.Address(RVA = "0x703124", Offset = "0x703124", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private static void SetupPermissions()
			{
				throw null;
			}

			// Token: 0x0600530C RID: 21260 RVA: 0x00030A6A File Offset: 0x0002EC6A
			[global::Cpp2ILInjected.Token(Token = "0x6000115")]
			[global::Cpp2ILInjected.Address(RVA = "0x7032B0", Offset = "0x7032B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public User()
			{
				throw null;
			}

			// Token: 0x04008FCB RID: 36811
			[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
			public static int PrimaryUserID;

			// Token: 0x04008FCC RID: 36812
			[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
			private static bool UGCRestriction;

			// Token: 0x04008FCD RID: 36813
			[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
			private static bool ChatRestriction;

			// Token: 0x04008FCE RID: 36814
			[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
			private static bool PatchRequired;

			// Token: 0x04008FCF RID: 36815
			[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
			private static bool AgeRestricted;

			// Token: 0x04008FD0 RID: 36816
			[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
			private static bool MultiplayerRestricted;

			// Token: 0x04008FD1 RID: 36817
			[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
			private static bool SetupUserPermissions;
		}
	}

	// Token: 0x02000776 RID: 1910
	[global::Cpp2ILInjected.Token(Token = "0x2000032")]
	public class Stadia
	{
		// Token: 0x0600482D RID: 18477 RVA: 0x0002EE08 File Offset: 0x0002D008
		[Conditional("UNITY_STADIA")]
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x7032B8", Offset = "0x7032B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Start()
		{
			throw null;
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x0002EE0B File Offset: 0x0002D00B
		[Conditional("UNITY_STADIA")]
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x7032BC", Offset = "0x7032BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x0002EE0E File Offset: 0x0002D00E
		[Conditional("UNITY_STADIA")]
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x7032C0", Offset = "0x7032C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x0002EE11 File Offset: 0x0002D011
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x7032C4", Offset = "0x7032C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Stadia()
		{
			throw null;
		}

		// Token: 0x02000B51 RID: 2897
		[global::Cpp2ILInjected.Token(Token = "0x2000033")]
		public class User
		{
			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x0600530D RID: 21261 RVA: 0x00030A6D File Offset: 0x0002EC6D
			[global::Cpp2ILInjected.Token(Token = "0x17000057")]
			public static string UserUID
			{
				[global::Cpp2ILInjected.Token(Token = "0x600011A")]
				[global::Cpp2ILInjected.Address(RVA = "0x7032CC", Offset = "0x7032CC", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x0600530E RID: 21262 RVA: 0x00030A70 File Offset: 0x0002EC70
			[global::Cpp2ILInjected.Token(Token = "0x17000058")]
			public static bool HasMultiplayerPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600011B")]
				[global::Cpp2ILInjected.Address(RVA = "0x702514", Offset = "0x702514", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x0600530F RID: 21263 RVA: 0x00030A73 File Offset: 0x0002EC73
			[global::Cpp2ILInjected.Token(Token = "0x17000059")]
			public static bool HasChatPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600011C")]
				[global::Cpp2ILInjected.Address(RVA = "0x701F30", Offset = "0x701F30", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005310 RID: 21264 RVA: 0x00030A76 File Offset: 0x0002EC76
			[global::Cpp2ILInjected.Token(Token = "0x600011D")]
			[global::Cpp2ILInjected.Address(RVA = "0x703314", Offset = "0x703314", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "SelectMultiplayer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static void ShowMultiplayerRestrictionOverlay()
			{
				throw null;
			}

			// Token: 0x06005311 RID: 21265 RVA: 0x00030A79 File Offset: 0x0002EC79
			[global::Cpp2ILInjected.Token(Token = "0x600011E")]
			[global::Cpp2ILInjected.Address(RVA = "0x70337C", Offset = "0x70337C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public User()
			{
				throw null;
			}

			// Token: 0x06005312 RID: 21266 RVA: 0x00030A7C File Offset: 0x0002EC7C
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600011F")]
			[global::Cpp2ILInjected.Address(RVA = "0x703384", Offset = "0x703384", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static User()
			{
				throw null;
			}

			// Token: 0x04008FD2 RID: 36818
			[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
			private static string savePath;
		}
	}

	// Token: 0x02000777 RID: 1911
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	public class Steam
	{
		// Token: 0x06004831 RID: 18481 RVA: 0x0002EE14 File Offset: 0x0002D014
		[Conditional("UNITY_STEAM")]
		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x7033EC", Offset = "0x7033EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x0002EE17 File Offset: 0x0002D017
		[Conditional("UNITY_STEAM")]
		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x7033F0", Offset = "0x7033F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x0002EE1A File Offset: 0x0002D01A
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x7033F4", Offset = "0x7033F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Steam()
		{
			throw null;
		}

		// Token: 0x02000B52 RID: 2898
		[global::Cpp2ILInjected.Token(Token = "0x2000035")]
		public class User
		{
			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x06005313 RID: 21267 RVA: 0x00030A7F File Offset: 0x0002EC7F
			[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
			public static string UserUID
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000123")]
				[global::Cpp2ILInjected.Address(RVA = "0x7033FC", Offset = "0x7033FC", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06005314 RID: 21268 RVA: 0x00030A82 File Offset: 0x0002EC82
			[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
			public static string GamerTag
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000124")]
				[global::Cpp2ILInjected.Address(RVA = "0x703444", Offset = "0x703444", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005315 RID: 21269 RVA: 0x00030A85 File Offset: 0x0002EC85
			[global::Cpp2ILInjected.Token(Token = "0x6000125")]
			[global::Cpp2ILInjected.Address(RVA = "0x70348C", Offset = "0x70348C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public static string GetAuthSessionTicket()
			{
				throw null;
			}

			// Token: 0x06005316 RID: 21270 RVA: 0x00030A88 File Offset: 0x0002EC88
			[global::Cpp2ILInjected.Token(Token = "0x6000126")]
			[global::Cpp2ILInjected.Address(RVA = "0x7034D4", Offset = "0x7034D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public User()
			{
				throw null;
			}
		}
	}

	// Token: 0x02000778 RID: 1912
	[global::Cpp2ILInjected.Token(Token = "0x2000036")]
	public class Switch
	{
		// Token: 0x06004834 RID: 18484 RVA: 0x0002EE1D File Offset: 0x0002D01D
		[Conditional("UNITY_SWITCH")]
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x7034DC", Offset = "0x7034DC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x0002EE20 File Offset: 0x0002D020
		[Conditional("UNITY_SWITCH")]
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x70360C", Offset = "0x70360C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Start()
		{
			throw null;
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x0002EE23 File Offset: 0x0002D023
		[Conditional("UNITY_SWITCH")]
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x703610", Offset = "0x703610", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x0002EE26 File Offset: 0x0002D026
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public static bool Docked
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012A")]
			[global::Cpp2ILInjected.Address(RVA = "0x703614", Offset = "0x703614", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x0002EE29 File Offset: 0x0002D029
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x703660", Offset = "0x703660", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Switch), Member = "set_CPUBoostMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void SetCpuBoostMode(object data)
		{
			throw null;
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x0002EE2C File Offset: 0x0002D02C
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x0002EE2F File Offset: 0x0002D02F
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public static bool CPUBoostMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600012C")]
			[global::Cpp2ILInjected.Address(RVA = "0x70373C", Offset = "0x70373C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600012D")]
			[global::Cpp2ILInjected.Address(RVA = "0x703528", Offset = "0x703528", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "Quit", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSplash", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "worldGenCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SaveAndQuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinaliseOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorld", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "FinaliseHardModeOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "RenameWorldUsingLoadAndSave", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "renameWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_IsMainThread", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Switch), Member = "SetCpuBoostMode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution.ExecutionSnippet), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
			{
				typeof(MainThreadExecution.ExecutionSnippet),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x0002EE32 File Offset: 0x0002D032
		[Conditional("UNITY_SWITCH")]
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x703A40", Offset = "0x703A40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void ShowProfile(PlatformUser user)
		{
			throw null;
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x0002EE35 File Offset: 0x0002D035
		[Conditional("UNITY_SWITCH")]
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x703A44", Offset = "0x703A44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void FilterText(ref string value)
		{
			throw null;
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x0002EE38 File Offset: 0x0002D038
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x703A48", Offset = "0x703A48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Switch()
		{
			throw null;
		}

		// Token: 0x04007830 RID: 30768
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		private static bool cpuBoost;
	}

	// Token: 0x02000779 RID: 1913
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	public class XBO
	{
		// Token: 0x0600483E RID: 18494 RVA: 0x0002EE3B File Offset: 0x0002D03B
		[Conditional("UNITY_XBOXONE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x703A50", Offset = "0x703A50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x0002EE3E File Offset: 0x0002D03E
		[Conditional("UNITY_XBOXONE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x703A54", Offset = "0x703A54", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Setup()
		{
			throw null;
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x0002EE41 File Offset: 0x0002D041
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x703AA8", Offset = "0x703AA8", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "HandleNetworkLost", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void Suspending()
		{
			throw null;
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x0002EE44 File Offset: 0x0002D044
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x703C34", Offset = "0x703C34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void Resuming(double span)
		{
			throw null;
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x0002EE47 File Offset: 0x0002D047
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x703C38", Offset = "0x703C38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void ResourceAvailabilityChangedEvent(bool amConstrained)
		{
			throw null;
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x0002EE4A File Offset: 0x0002D04A
		[Conditional("UNITY_XBOXONE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x703C3C", Offset = "0x703C3C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void StartSession()
		{
			throw null;
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x0002EE4D File Offset: 0x0002D04D
		[Conditional("UNITY_XBOXONE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x703C40", Offset = "0x703C40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Start()
		{
			throw null;
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x0002EE50 File Offset: 0x0002D050
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x703C44", Offset = "0x703C44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XBO()
		{
			throw null;
		}

		// Token: 0x04007831 RID: 30769
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		public const string SCID = "f4f80100-7f03-4df9-8fbd-f0191738ca2a";

		// Token: 0x04007832 RID: 30770
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		private static bool _setup;

		// Token: 0x04007833 RID: 30771
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		private static NetworkReachability networkReachability;

		// Token: 0x02000B53 RID: 2899
		[global::Cpp2ILInjected.Token(Token = "0x2000038")]
		public class User
		{
			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x06005317 RID: 21271 RVA: 0x00030A8B File Offset: 0x0002EC8B
			[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
			public static bool HasMultiplayerPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000139")]
				[global::Cpp2ILInjected.Address(RVA = "0x703C4C", Offset = "0x703C4C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x06005318 RID: 21272 RVA: 0x00030A8E File Offset: 0x0002EC8E
			[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
			public static bool HasUserGeneratedContentPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600013A")]
				[global::Cpp2ILInjected.Address(RVA = "0x701DF4", Offset = "0x701DF4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06005319 RID: 21273 RVA: 0x00030A91 File Offset: 0x0002EC91
			[global::Cpp2ILInjected.Token(Token = "0x17000060")]
			public static bool HasChatPermissions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600013B")]
				[global::Cpp2ILInjected.Address(RVA = "0x703C54", Offset = "0x703C54", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x0600531A RID: 21274 RVA: 0x00030A94 File Offset: 0x0002EC94
			[global::Cpp2ILInjected.Token(Token = "0x17000061")]
			public static string UserUID
			{
				[global::Cpp2ILInjected.Token(Token = "0x600013C")]
				[global::Cpp2ILInjected.Address(RVA = "0x703C5C", Offset = "0x703C5C", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x0600531B RID: 21275 RVA: 0x00030A97 File Offset: 0x0002EC97
			[global::Cpp2ILInjected.Token(Token = "0x17000062")]
			public static string GamerTag
			{
				[global::Cpp2ILInjected.Token(Token = "0x600013D")]
				[global::Cpp2ILInjected.Address(RVA = "0x703CA4", Offset = "0x703CA4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600531C RID: 21276 RVA: 0x00030A9A File Offset: 0x0002EC9A
			[Conditional("UNITY_XBOXONE")]
			[global::Cpp2ILInjected.Token(Token = "0x600013E")]
			[global::Cpp2ILInjected.Address(RVA = "0x703CAC", Offset = "0x703CAC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static void Start()
			{
				throw null;
			}

			// Token: 0x0600531D RID: 21277 RVA: 0x00030A9D File Offset: 0x0002EC9D
			[Conditional("UNITY_XBOXONE")]
			[global::Cpp2ILInjected.Token(Token = "0x600013F")]
			[global::Cpp2ILInjected.Address(RVA = "0x703CB0", Offset = "0x703CB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			public static void ShowGamerCard(string xboPlayerId)
			{
				throw null;
			}

			// Token: 0x0600531E RID: 21278 RVA: 0x00030AA0 File Offset: 0x0002ECA0
			[global::Cpp2ILInjected.Token(Token = "0x6000140")]
			[global::Cpp2ILInjected.Address(RVA = "0x703CB8", Offset = "0x703CB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public User()
			{
				throw null;
			}
		}
	}
}
