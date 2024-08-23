using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000AC RID: 172
	[JsonObject(MemberSerialization.OptIn)]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	public class CustomInputDeviceProfile : InputDeviceProfile
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x000031C7 File Offset: 0x000013C7
		[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E0BC0", Offset = "0x19E0BC0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public CustomInputDeviceProfile(string deviceName)
		{
			throw null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000031CA File Offset: 0x000013CA
		[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E0C64", Offset = "0x19E0C64", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomInputDeviceProfile), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CustomInputDeviceProfile()
		{
			throw null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000031CD File Offset: 0x000013CD
		[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E0CC4", Offset = "0x19E0CC4", Length = "0x488")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomInputDeviceProfile), Member = "SaveToFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringEnumConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public string Save()
		{
			throw null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000031D0 File Offset: 0x000013D0
		[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E114C", Offset = "0x19E114C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomInputDeviceProfile), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_TypeNameHandling", MemberParameters = new object[] { typeof(TypeNameHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "set_MetadataPropertyHandling", MemberParameters = new object[] { typeof(MetadataPropertyHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringEnumConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static CustomInputDeviceProfile Load(string data)
		{
			throw null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000031D3 File Offset: 0x000013D3
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E1304", Offset = "0x19E1304", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIControllerHardwareProfile", Member = "UpdateAndSaveCurrentProfile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDeviceManager), Member = "get_CustomProfileFolder", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "WriteToFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SaveToFile()
		{
			throw null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000031D6 File Offset: 0x000013D6
		[global::Cpp2ILInjected.Token(Token = "0x6000600")]
		[global::Cpp2ILInjected.Address(RVA = "0x19E13C0", Offset = "0x19E13C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfileFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "LoadDeviceProfilesFromPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ReadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CustomInputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static CustomInputDeviceProfile LoadFromFile(string filePath)
		{
			throw null;
		}

		// Token: 0x040003BD RID: 957
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public bool Configured;

		// Token: 0x040003BE RID: 958
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public int ForcedScheme;
	}
}
