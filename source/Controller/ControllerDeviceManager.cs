using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;

namespace Controller
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B60")]
	public class ControllerDeviceManager : Singleton<ControllerDeviceManager>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005496")]
		[global::Cpp2ILInjected.Address(RVA = "0x94CBA8", Offset = "0x94CBA8", Length = "0x71C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = ".ctor", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDeviceManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void UpdateConnectedControllers(float elapsedTime, bool forceUpdate = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005497")]
		[global::Cpp2ILInjected.Address(RVA = "0x94D8E8", Offset = "0x94D8E8", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateConnectedControllers", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchModeLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "FindLocalUserByController", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(LocalUser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "UnloadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void UpdateDevices(float elapsedTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005498")]
		[global::Cpp2ILInjected.Address(RVA = "0x94DE70", Offset = "0x94DE70", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public ControllerDeviceManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008D87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int lastFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4008D88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public List<ControllerDevice> AttachedDevices;

		[global::Cpp2ILInjected.Token(Token = "0x4008D89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<ControllerDevice> _deviceUpdateList;

		[global::Cpp2ILInjected.Token(Token = "0x4008D8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<UnityInputDevice> _joyConUpdateList;

		[global::Cpp2ILInjected.Token(Token = "0x4008D8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public List<ControllerDevice> UnconfiguredList;

		[global::Cpp2ILInjected.Token(Token = "0x4008D8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private List<ControllerDevice> _unconfiguredUpdateList;

		[global::Cpp2ILInjected.Token(Token = "0x4008D8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public List<ControllerDevice> ActiveControllers;
	}
}
