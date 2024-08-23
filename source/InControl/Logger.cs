using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200002A RID: 42
	[global::Cpp2ILInjected.Token(Token = "0x200002B")]
	public class Logger
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001C7 RID: 455 RVA: 0x000025A3 File Offset: 0x000007A3
		// (remove) Token: 0x060001C8 RID: 456 RVA: 0x000025A6 File Offset: 0x000007A6
		[global::Cpp2ILInjected.Token(Token = "0x14000006")]
		public static event Action<LogMessage> OnLogMessage
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x19855B8", Offset = "0x19855B8", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x19854EC", Offset = "0x19854EC", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000025A9 File Offset: 0x000007A9
		[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987ADC", Offset = "0x1987ADC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "CheckPlatformSupport", MemberParameters = new object[] { typeof(ICollection<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LogInfo(string text)
		{
			throw null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000025AC File Offset: 0x000007AC
		[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987B4C", Offset = "0x1987B4C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LogWarning(string text)
		{
			throw null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000025AF File Offset: 0x000007AF
		[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987BBC", Offset = "0x1987BBC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "AddDeviceManager", MemberParameters = new object[] { typeof(InputDeviceManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AttachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LogError(string text)
		{
			throw null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000025B2 File Offset: 0x000007B2
		[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1987C2C", Offset = "0x1987C2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Logger()
		{
			throw null;
		}

		// Token: 0x040001FB RID: 507
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
		private static Action<LogMessage> OnLogMessage;
	}
}
