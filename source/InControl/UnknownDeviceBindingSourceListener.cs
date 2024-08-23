using System;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	public class UnknownDeviceBindingSourceListener : BindingSourceListener
	{
		// Token: 0x06000107 RID: 263 RVA: 0x0000237E File Offset: 0x0000057E
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984390", Offset = "0x1984390", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002381 File Offset: 0x00000581
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x19843F8", Offset = "0x19843F8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "TakeSnapshot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void TakeSnapshotOnUnknownDevices()
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002384 File Offset: 0x00000584
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984600", Offset = "0x1984600", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[]
		{
			typeof(UnknownDeviceControl),
			typeof(InputDevice)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(UnknownDeviceControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceBindingSourceListener), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			throw null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002387 File Offset: 0x00000587
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x198475C", Offset = "0x198475C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceControl), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "AbsoluteIsOverThreshold", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsPressed(UnknownDeviceControl control, InputDevice device)
		{
			throw null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000238A File Offset: 0x0000058A
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19847E0", Offset = "0x19847E0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetFirstPressedButton", ReturnType = typeof(UnknownDeviceControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetFirstPressedAnalog", ReturnType = typeof(UnknownDeviceControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			throw null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000238D File Offset: 0x0000058D
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197EE30", Offset = "0x197EE30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UnknownDeviceBindingSourceListener()
		{
			throw null;
		}

		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x4000104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private UnknownDeviceControl detectFound;

		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private UnknownDeviceBindingSourceListener.DetectPhase detectPhase;

		// Token: 0x020001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x2000017")]
		private enum DetectPhase
		{
			// Token: 0x040003D3 RID: 979
			[global::Cpp2ILInjected.Token(Token = "0x4000107")]
			WaitForInitialRelease,
			// Token: 0x040003D4 RID: 980
			[global::Cpp2ILInjected.Token(Token = "0x4000108")]
			WaitForControlPress,
			// Token: 0x040003D5 RID: 981
			[global::Cpp2ILInjected.Token(Token = "0x4000109")]
			WaitForControlRelease
		}
	}
}
