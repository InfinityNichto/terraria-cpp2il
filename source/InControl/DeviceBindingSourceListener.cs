using System;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public class DeviceBindingSourceListener : BindingSourceListener
	{
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A370", Offset = "0x197A370", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A378", Offset = "0x197A378", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(InputControl) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(InputControlType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A5B0", Offset = "0x197A5B0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[]
		{
			typeof(InputControlType),
			typeof(InputDevice)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSourceListener), Member = "ListenForControl", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(InputControlType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "AbsoluteIsOverThreshold", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsPressed(InputControl control)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A49C", Offset = "0x197A49C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(InputControl) }, ReturnType = typeof(bool))]
		private bool IsPressed(InputControlType control, InputDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A4B4", Offset = "0x197A4B4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceBindingSourceListener), Member = "IsPressed", MemberParameters = new object[] { typeof(InputControl) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControl), Member = "get_IsStandard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000030")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A688", Offset = "0x197A688", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DeviceBindingSourceListener()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InputControlType detectFound;

		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int detectPhase;
	}
}
