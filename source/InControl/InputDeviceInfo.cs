using System;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200002E RID: 46
	[global::Cpp2ILInjected.Token(Token = "0x2000030")]
	public struct InputDeviceInfo
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00002726 File Offset: 0x00000926
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

		// Token: 0x06000249 RID: 585 RVA: 0x00002729 File Offset: 0x00000929
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

		// Token: 0x0600024A RID: 586 RVA: 0x0000272C File Offset: 0x0000092C
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

		// Token: 0x0600024B RID: 587 RVA: 0x0000272F File Offset: 0x0000092F
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

		// Token: 0x0600024C RID: 588 RVA: 0x00002732 File Offset: 0x00000932
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

		// Token: 0x0400023C RID: 572
		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x0400023D RID: 573
		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string location;

		// Token: 0x0400023E RID: 574
		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string serialNumber;

		// Token: 0x0400023F RID: 575
		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ushort vendorID;

		// Token: 0x04000240 RID: 576
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public ushort productID;

		// Token: 0x04000241 RID: 577
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public uint versionNumber;

		// Token: 0x04000242 RID: 578
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public InputDeviceDriverType driverType;

		// Token: 0x04000243 RID: 579
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		public InputDeviceTransportType transportType;

		// Token: 0x04000244 RID: 580
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public uint numButtons;

		// Token: 0x04000245 RID: 581
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public uint numAnalogs;
	}
}
