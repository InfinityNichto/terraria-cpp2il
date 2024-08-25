using System;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000030")]
	public struct InputDeviceInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000249")]
		[global::Cpp2ILInjected.Address(RVA = "0x198AC94", Offset = "0x198AC94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "HasSameVendorID", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "SystemFindDetachedDevice", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(ReadOnlyCollection<NativeInputDevice>)
		}, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool HasSameVendorID(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600024A")]
		[global::Cpp2ILInjected.Address(RVA = "0x198ACA8", Offset = "0x198ACA8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "HasSameProductID", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "SystemFindDetachedDevice", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(ReadOnlyCollection<NativeInputDevice>)
		}, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool HasSameProductID(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600024B")]
		[global::Cpp2ILInjected.Address(RVA = "0x198ACBC", Offset = "0x198ACBC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "HasSameVersionNumber", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "SystemFindDetachedDevice", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(ReadOnlyCollection<NativeInputDevice>)
		}, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool HasSameVersionNumber(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600024C")]
		[global::Cpp2ILInjected.Address(RVA = "0x198ACD0", Offset = "0x198ACD0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "HasSameLocation", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "SystemFindDetachedDevice", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(ReadOnlyCollection<NativeInputDevice>)
		}, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public bool HasSameLocation(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600024D")]
		[global::Cpp2ILInjected.Address(RVA = "0x198AD18", Offset = "0x198AD18", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "HasSameSerialNumber", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "SystemFindDetachedDevice", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(ReadOnlyCollection<NativeInputDevice>)
		}, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public bool HasSameSerialNumber(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string name;

		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string location;

		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string serialNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ushort vendorID;

		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public ushort productID;

		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public uint versionNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public InputDeviceDriverType driverType;

		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		public InputDeviceTransportType transportType;

		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public uint numButtons;

		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public uint numAnalogs;
	}
}
