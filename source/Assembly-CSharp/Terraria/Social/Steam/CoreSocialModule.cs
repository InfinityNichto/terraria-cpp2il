using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Steam
{
	// Token: 0x02000382 RID: 898
	[global::Cpp2ILInjected.Token(Token = "0x2000511")]
	public class CoreSocialModule : ISocialModule
	{
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06002D13 RID: 11539 RVA: 0x0002A158 File Offset: 0x00028358
		// (remove) Token: 0x06002D14 RID: 11540 RVA: 0x0002A15B File Offset: 0x0002835B
		[global::Cpp2ILInjected.Token(Token = "0x1400002E")]
		public static event Action OnTick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600314C")]
			[global::Cpp2ILInjected.Address(RVA = "0x13042CC", Offset = "0x13042CC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600314D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1304388", Offset = "0x1304388", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x0002A15E File Offset: 0x0002835E
		[global::Cpp2ILInjected.Token(Token = "0x600314E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304444", Offset = "0x1304444", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetSkipPulsing(bool shouldSkipPausing)
		{
			throw null;
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x0002A161 File Offset: 0x00028361
		[global::Cpp2ILInjected.Token(Token = "0x600314F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304448", Offset = "0x1304448", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterizedThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ParameterizedThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0002A164 File Offset: 0x00028364
		[global::Cpp2ILInjected.Token(Token = "0x6003150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304658", Offset = "0x1304658", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Pulse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public void PulseSteamTick()
		{
			throw null;
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x0002A167 File Offset: 0x00028367
		[global::Cpp2ILInjected.Token(Token = "0x6003151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304694", Offset = "0x1304694", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Pulse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Pulse", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public void PulseSteamCallback()
		{
			throw null;
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0002A16A File Offset: 0x0002836A
		[global::Cpp2ILInjected.Token(Token = "0x6003152")]
		[global::Cpp2ILInjected.Address(RVA = "0x13046D0", Offset = "0x13046D0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoreSocialModule), Member = "PulseSteamTick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoreSocialModule), Member = "PulseSteamCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Pulse()
		{
			throw null;
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x0002A16D File Offset: 0x0002836D
		[global::Cpp2ILInjected.Token(Token = "0x6003153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304728", Offset = "0x1304728", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SteamTickLoop(object context)
		{
			throw null;
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x0002A170 File Offset: 0x00028370
		[global::Cpp2ILInjected.Token(Token = "0x6003154")]
		[global::Cpp2ILInjected.Address(RVA = "0x13047B8", Offset = "0x13047B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SteamCallbackLoop(object context)
		{
			throw null;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x0002A173 File Offset: 0x00028373
		[global::Cpp2ILInjected.Token(Token = "0x6003155")]
		[global::Cpp2ILInjected.Address(RVA = "0x13047BC", Offset = "0x13047BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Shutdown()
		{
			throw null;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x0002A176 File Offset: 0x00028376
		[global::Cpp2ILInjected.Token(Token = "0x6003156")]
		[global::Cpp2ILInjected.Address(RVA = "0x13047C0", Offset = "0x13047C0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CoreSocialModule()
		{
			throw null;
		}

		// Token: 0x040031B5 RID: 12725
		[global::Cpp2ILInjected.Token(Token = "0x4003B11")]
		private static CoreSocialModule _instance;

		// Token: 0x040031B6 RID: 12726
		[global::Cpp2ILInjected.Token(Token = "0x4003B12")]
		public const int SteamAppId = 105600;

		// Token: 0x040031B7 RID: 12727
		[global::Cpp2ILInjected.Token(Token = "0x4003B13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool IsSteamValid;

		// Token: 0x040031B8 RID: 12728
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B14")]
		private static Action OnTick;

		// Token: 0x040031B9 RID: 12729
		[global::Cpp2ILInjected.Token(Token = "0x4003B15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _steamTickLock;

		// Token: 0x040031BA RID: 12730
		[global::Cpp2ILInjected.Token(Token = "0x4003B16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object _steamCallbackLock;

		// Token: 0x040031BB RID: 12731
		[global::Cpp2ILInjected.Token(Token = "0x4003B17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _skipPulsing;
	}
}
