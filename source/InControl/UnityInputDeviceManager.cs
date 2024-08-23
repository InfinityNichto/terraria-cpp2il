using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl.UnityDeviceProfiles;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000053 RID: 83
	[global::Cpp2ILInjected.Token(Token = "0x200005D")]
	public class UnityInputDeviceManager : InputDeviceManager
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00002CDE File Offset: 0x00000EDE
		[global::Cpp2ILInjected.Token(Token = "0x6000449")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B1E20", Offset = "0x19B1E20", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AddSystemDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "get_CustomProfileFolder", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfilesFromPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "QueryJoystickInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AttachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UnityInputDeviceManager()
		{
			throw null;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002CE1 File Offset: 0x00000EE1
		[global::Cpp2ILInjected.Token(Token = "0x600044A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2210", Offset = "0x19B2210", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "QueryJoystickInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "LogInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "DetachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AttachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[global::Cpp2ILInjected.Token(Token = "0x600044B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B207C", Offset = "0x19B207C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "ReloadDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetJoystickNames", ReturnType = typeof(string[]))]
		private void QueryJoystickInfo()
		{
			throw null;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00002CE7 File Offset: 0x00000EE7
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		private bool JoystickInfoHasChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x600044C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B22C8", Offset = "0x19B22C8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002CEA File Offset: 0x00000EEA
		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B211C", Offset = "0x19B211C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "ReloadDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "LogError", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void AttachDevices()
		{
			throw null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002CED File Offset: 0x00000EED
		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B22F4", Offset = "0x19B22F4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "ReloadDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void DetachDevices()
		{
			throw null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2B58", Offset = "0x19B2B58", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "QueryJoystickInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "DetachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AttachDevices", ReturnType = typeof(void))]
		public void ReloadDevices()
		{
			throw null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002CF3 File Offset: 0x00000EF3
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2B78", Offset = "0x19B2B78", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AttachDevice(UnityInputDevice device)
		{
			throw null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002CF6 File Offset: 0x00000EF6
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2C44", Offset = "0x19B2C44", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
		{
			throw null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002CF9 File Offset: 0x00000EF9
		[global::Cpp2ILInjected.Token(Token = "0x6000452")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2400", Offset = "0x19B2400", Length = "0x758")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AttachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "HasAttachedDeviceWithJoystickId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_UnityVersion", ReturnType = typeof(VersionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "DetectDevice", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(InputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsHidden", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "SaveToFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDevice), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputDeviceProfile),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(UnityInputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "LogWarning", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "LogInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		private void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
		{
			throw null;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002CFC File Offset: 0x00000EFC
		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2D9C", Offset = "0x19B2D9C", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Find", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private InputDeviceProfile DetectDevice(string unityJoystickName)
		{
			throw null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002CFF File Offset: 0x00000EFF
		[global::Cpp2ILInjected.Token(Token = "0x6000454")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2F74", Offset = "0x19B2F74", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AddSystemDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			throw null;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002D02 File Offset: 0x00000F02
		[global::Cpp2ILInjected.Token(Token = "0x6000455")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B1F40", Offset = "0x19B1F40", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "CreateInstanceOfType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(InputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AddSystemDeviceProfile", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddSystemDeviceProfiles()
		{
			throw null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002D05 File Offset: 0x00000F05
		[global::Cpp2ILInjected.Token(Token = "0x6000456")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B3024", Offset = "0x19B3024", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfileFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfilesFromPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddDeviceProfile(CustomInputDeviceProfile deviceProfile)
		{
			throw null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002D08 File Offset: 0x00000F08
		[global::Cpp2ILInjected.Token(Token = "0x6000457")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2060", Offset = "0x19B2060", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "get_CustomProfileFolder", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfilesFromPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void LoadDeviceProfiles()
		{
			throw null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002D0B File Offset: 0x00000F0B
		[global::Cpp2ILInjected.Token(Token = "0x6000458")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B3180", Offset = "0x19B3180", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AddDeviceProfile", MemberParameters = new object[] { typeof(CustomInputDeviceProfile) }, ReturnType = typeof(void))]
		public void LoadDeviceProfile(string data)
		{
			throw null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002D0E File Offset: 0x00000F0E
		[global::Cpp2ILInjected.Token(Token = "0x6000459")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B31A4", Offset = "0x19B31A4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AddDeviceProfile", MemberParameters = new object[] { typeof(CustomInputDeviceProfile) }, ReturnType = typeof(void))]
		public void LoadDeviceProfileFromFile(string filePath)
		{
			throw null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002D11 File Offset: 0x00000F11
		[global::Cpp2ILInjected.Token(Token = "0x600045A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B30D0", Offset = "0x19B30D0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchOption)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "AddDeviceProfile", MemberParameters = new object[] { typeof(CustomInputDeviceProfile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void LoadDeviceProfilesFromPath(string rootPath)
		{
			throw null;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002D14 File Offset: 0x00000F14
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		public static string SavePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045B")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B31C8", Offset = "0x19B31C8", Length = "0x2AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "get_CustomProfileFolder", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_persistentDataPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = "ReturnType")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00002D17 File Offset: 0x00000F17
		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		public static string CustomProfileFolder
		{
			[global::Cpp2ILInjected.Token(Token = "0x600045C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B2018", Offset = "0x19B2018", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfiles", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomInputDeviceProfile), Member = "SaveToFile", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "get_SavePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000388 RID: 904
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		private const float deviceRefreshInterval = 1f;

		// Token: 0x04000389 RID: 905
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float deviceRefreshTimer;

		// Token: 0x0400038A RID: 906
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		// Token: 0x0400038B RID: 907
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly List<InputDeviceProfile> customDeviceProfiles;

		// Token: 0x0400038C RID: 908
		[global::Cpp2ILInjected.Token(Token = "0x40003D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string[] joystickNames;

		// Token: 0x0400038D RID: 909
		[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int lastJoystickCount;

		// Token: 0x0400038E RID: 910
		[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int lastJoystickHash;

		// Token: 0x0400038F RID: 911
		[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int joystickCount;

		// Token: 0x04000390 RID: 912
		[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int joystickHash;

		// Token: 0x04000391 RID: 913
		[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
		public static string _savePath;

		// Token: 0x020001F4 RID: 500
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005E")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x0600085F RID: 2143 RVA: 0x0000394A File Offset: 0x00001B4A
			[global::Cpp2ILInjected.Token(Token = "0x600045D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B2F6C", Offset = "0x19B2F6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass20_0()
			{
				throw null;
			}

			// Token: 0x06000860 RID: 2144 RVA: 0x0000394D File Offset: 0x00001B4D
			[global::Cpp2ILInjected.Token(Token = "0x600045E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B3474", Offset = "0x19B3474", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__0(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x06000861 RID: 2145 RVA: 0x00003950 File Offset: 0x00001B50
			[global::Cpp2ILInjected.Token(Token = "0x600045F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B34B0", Offset = "0x19B34B0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__1(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x00003953 File Offset: 0x00001B53
			[global::Cpp2ILInjected.Token(Token = "0x6000460")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B34EC", Offset = "0x19B34EC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LastResortMatches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__2(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x00003956 File Offset: 0x00001B56
			[global::Cpp2ILInjected.Token(Token = "0x6000461")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B3528", Offset = "0x19B3528", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "LastResortMatches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			internal bool <DetectDevice>b__3(InputDeviceProfile profile)
			{
				throw null;
			}

			// Token: 0x0400041E RID: 1054
			[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public InputDeviceInfo deviceInfo;
		}
	}
}
