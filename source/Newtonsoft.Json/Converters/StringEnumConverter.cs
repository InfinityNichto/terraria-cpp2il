using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BC RID: 188
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000103")]
	public class StringEnumConverter : JsonConverter
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00003B06 File Offset: 0x00001D06
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00003B09 File Offset: 0x00001D09
		[global::Cpp2ILInjected.Token(Token = "0x170001D2")]
		public bool CamelCaseText
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D28CE4", Offset = "0x1D28CE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A47")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D28CEC", Offset = "0x1D28CEC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00003B0C File Offset: 0x00001D0C
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00003B0F File Offset: 0x00001D0F
		[global::Cpp2ILInjected.Token(Token = "0x170001D3")]
		public bool AllowIntegerValues
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D28CF8", Offset = "0x1D28CF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D28D00", Offset = "0x1D28D00", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00003B12 File Offset: 0x00001D12
		[global::Cpp2ILInjected.Token(Token = "0x6000A4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28D0C", Offset = "0x1D28D0C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "SaveConfiguration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "SaveConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public StringEnumConverter()
		{
			throw null;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00003B15 File Offset: 0x00001D15
		[global::Cpp2ILInjected.Token(Token = "0x6000A4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28D2C", Offset = "0x1D28D2C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public StringEnumConverter(bool camelCaseText)
		{
			throw null;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00003B18 File Offset: 0x00001D18
		[global::Cpp2ILInjected.Token(Token = "0x6000A4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28D60", Offset = "0x1D28D60", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsNumber", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EnumUtils), Member = "ToEnumName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00003B1B File Offset: 0x00001D1B
		[global::Cpp2ILInjected.Token(Token = "0x6000A4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28F14", Offset = "0x1D28F14", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EnumUtils), Member = "ParseEnumName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "ConvertOrCast", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "FormatValueForPrint", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00003B1E File Offset: 0x00001D1E
		[global::Cpp2ILInjected.Token(Token = "0x6000A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D29338", Offset = "0x1D29338", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsEnum", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x040002E7 RID: 743
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <CamelCaseText>k__BackingField;

		// Token: 0x040002E8 RID: 744
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool <AllowIntegerValues>k__BackingField;
	}
}
