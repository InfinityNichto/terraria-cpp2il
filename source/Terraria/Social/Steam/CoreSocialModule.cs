using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Steam
{
	[global::Cpp2ILInjected.Token(Token = "0x2000511")]
	public class CoreSocialModule : ISocialModule
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600314E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304444", Offset = "0x1304444", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetSkipPulsing(bool shouldSkipPausing)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003154")]
		[global::Cpp2ILInjected.Address(RVA = "0x13047B8", Offset = "0x13047B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SteamCallbackLoop(object context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003155")]
		[global::Cpp2ILInjected.Address(RVA = "0x13047BC", Offset = "0x13047BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003156")]
		[global::Cpp2ILInjected.Address(RVA = "0x13047C0", Offset = "0x13047C0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CoreSocialModule()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B11")]
		private static CoreSocialModule _instance;

		[global::Cpp2ILInjected.Token(Token = "0x4003B12")]
		public const int SteamAppId = 105600;

		[global::Cpp2ILInjected.Token(Token = "0x4003B13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool IsSteamValid;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B14")]
		private static Action OnTick;

		[global::Cpp2ILInjected.Token(Token = "0x4003B15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _steamTickLock;

		[global::Cpp2ILInjected.Token(Token = "0x4003B16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object _steamCallbackLock;

		[global::Cpp2ILInjected.Token(Token = "0x4003B17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _skipPulsing;
	}
}
