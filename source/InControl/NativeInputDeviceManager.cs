using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200003A RID: 58
	[global::Cpp2ILInjected.Token(Token = "0x200003E")]
	public class NativeInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06000340 RID: 832 RVA: 0x00002A0B File Offset: 0x00000C0B
		[global::Cpp2ILInjected.Token(Token = "0x6000344")]
		[global::Cpp2ILInjected.Address(RVA = "0x199971C", Offset = "0x199971C", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "AddSystemDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_fixedDeltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public NativeInputDeviceManager()
		{
			throw null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002A0E File Offset: 0x00000C0E
		[global::Cpp2ILInjected.Token(Token = "0x6000345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999B18", Offset = "0x1999B18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Destroy()
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002A11 File Offset: 0x00000C11
		[global::Cpp2ILInjected.Token(Token = "0x6000346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999B1C", Offset = "0x1999B1C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002A14 File Offset: 0x00000C14
		[global::Cpp2ILInjected.Token(Token = "0x6000347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999C58", Offset = "0x1999C58", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Find", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsHidden", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "FindDetachedDevice", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDevice), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDevice), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo),
			typeof(InputDeviceProfile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(NativeInputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void DetectDevice(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002A17 File Offset: 0x00000C17
		[global::Cpp2ILInjected.Token(Token = "0x6000348")]
		[global::Cpp2ILInjected.Address(RVA = "0x199A180", Offset = "0x199A180", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "DetectDevice", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AttachDevice(NativeInputDevice device)
		{
			throw null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002A1A File Offset: 0x00000C1A
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999F8C", Offset = "0x1999F8C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DetachDevice(NativeInputDevice device)
		{
			throw null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002A1D File Offset: 0x00000C1D
		[global::Cpp2ILInjected.Token(Token = "0x600034A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999ED8", Offset = "0x1999ED8", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private NativeInputDevice FindAttachedDevice(uint deviceHandle)
		{
			throw null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002A20 File Offset: 0x00000C20
		[global::Cpp2ILInjected.Token(Token = "0x600034B")]
		[global::Cpp2ILInjected.Address(RVA = "0x199A080", Offset = "0x199A080", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "DetectDevice", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(InputDeviceInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "SystemFindDetachedDevice", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(ReadOnlyCollection<NativeInputDevice>)
		}, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private NativeInputDevice FindDetachedDevice(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002A23 File Offset: 0x00000C23
		[global::Cpp2ILInjected.Token(Token = "0x600034C")]
		[global::Cpp2ILInjected.Address(RVA = "0x199A26C", Offset = "0x199A26C", Length = "0x360")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "FindDetachedDevice", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(NativeInputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameVendorID", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameProductID", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameSerialNumber", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameLocation", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceInfo), Member = "HasSameVersionNumber", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static NativeInputDevice SystemFindDetachedDevice(InputDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices)
		{
			throw null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002A26 File Offset: 0x00000C26
		[global::Cpp2ILInjected.Token(Token = "0x600034D")]
		[global::Cpp2ILInjected.Address(RVA = "0x199A5CC", Offset = "0x199A5CC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "AddSystemDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			throw null;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002A29 File Offset: 0x00000C29
		[global::Cpp2ILInjected.Token(Token = "0x600034E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1999A44", Offset = "0x1999A44", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "CreateInstanceOfType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(InputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "AddSystemDeviceProfile", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddSystemDeviceProfiles()
		{
			throw null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002A2C File Offset: 0x00000C2C
		[global::Cpp2ILInjected.Token(Token = "0x600034F")]
		[global::Cpp2ILInjected.Address(RVA = "0x199A678", Offset = "0x199A678", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "Enable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "LogInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "PluginFileExtension", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			throw null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002A2F File Offset: 0x00000C2F
		[global::Cpp2ILInjected.Token(Token = "0x6000350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996010", Offset = "0x1996010", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "SetupInternal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "CheckPlatformSupport", MemberParameters = new object[] { typeof(ICollection<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "HideDevicesWithProfile", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AddDeviceManager", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal static bool Enable()
		{
			throw null;
		}

		// Token: 0x040002CC RID: 716
		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		public static Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice;

		// Token: 0x040002CD RID: 717
		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<NativeInputDevice> attachedDevices;

		// Token: 0x040002CE RID: 718
		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly List<NativeInputDevice> detachedDevices;

		// Token: 0x040002CF RID: 719
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		// Token: 0x040002D0 RID: 720
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly List<InputDeviceProfile> customDeviceProfiles;

		// Token: 0x040002D1 RID: 721
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] deviceEvents;

		// Token: 0x020001EE RID: 494
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200003F")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000854 RID: 2132 RVA: 0x00003929 File Offset: 0x00001B29
			[global::Cpp2ILInjected.Token(Token = "0x6000351")]
			[global::Cpp2ILInjected.Address(RVA = "0x199A078", Offset = "0x199A078", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			// Token: 0x06000855 RID: 2133 RVA: 0x0000392C File Offset: 0x00001B2C
			[global::Cpp2ILInjected.Token(Token = "0x6000352")]
			[global::Cpp2ILInjected.Address(RVA = "0x199AA44", Offset = "0x199AA44", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
			{
				typeof(InputDeviceInfo),
				typeof(InputDeviceMatcher[])
			}, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__0(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x0000392F File Offset: 0x00001B2F
			[global::Cpp2ILInjected.Token(Token = "0x6000353")]
			[global::Cpp2ILInjected.Address(RVA = "0x199AA78", Offset = "0x199AA78", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
			{
				typeof(InputDeviceInfo),
				typeof(InputDeviceMatcher[])
			}, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__1(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x00003932 File Offset: 0x00001B32
			[global::Cpp2ILInjected.Token(Token = "0x6000354")]
			[global::Cpp2ILInjected.Address(RVA = "0x199AAAC", Offset = "0x199AAAC", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
			{
				typeof(InputDeviceInfo),
				typeof(InputDeviceMatcher[])
			}, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__2(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x06000858 RID: 2136 RVA: 0x00003935 File Offset: 0x00001B35
			[global::Cpp2ILInjected.Token(Token = "0x6000355")]
			[global::Cpp2ILInjected.Address(RVA = "0x199AAE0", Offset = "0x199AAE0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
			{
				typeof(InputDeviceInfo),
				typeof(InputDeviceMatcher[])
			}, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__3(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x040003E0 RID: 992
			[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public InputDeviceInfo deviceInfo;
		}
	}
}
