using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	public class MouseBindingSourceListener : BindingSourceListener
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000021DD File Offset: 0x000003DD
		[global::Cpp2ILInjected.Token(Token = "0x600007C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E564", Offset = "0x197E564", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000021E0 File Offset: 0x000003E0
		[global::Cpp2ILInjected.Token(Token = "0x600007D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E56C", Offset = "0x197E56C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[] { typeof(BindingListenOptions) }, ReturnType = typeof(Mouse))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			throw null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000021E3 File Offset: 0x000003E3
		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E634", Offset = "0x197E634", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "NegativeScrollWheelIsActive", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "PositiveScrollWheelIsActive", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "ButtonIsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool IsPressed(Mouse control)
		{
			throw null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000021E6 File Offset: 0x000003E6
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E73C", Offset = "0x197E73C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MouseBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "ButtonIsPressed", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "NegativeScrollWheelIsActive", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MouseBindingSource), Member = "PositiveScrollWheelIsActive", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private Mouse ListenForControl(BindingListenOptions listenOptions)
		{
			throw null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000021E9 File Offset: 0x000003E9
		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E864", Offset = "0x197E864", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MouseBindingSourceListener()
		{
			throw null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021EC File Offset: 0x000003EC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		[global::Cpp2ILInjected.Address(RVA = "0x197E86C", Offset = "0x197E86C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static MouseBindingSourceListener()
		{
			throw null;
		}

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		public static float ScrollWheelThreshold;

		// Token: 0x040000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Mouse detectFound;

		// Token: 0x040000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int detectPhase;
	}
}
