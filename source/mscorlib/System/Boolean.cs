using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200006B RID: 107
	[global::Cpp2ILInjected.Token(Token = "0x2000092")]
	[global::System.Serializable]
	public readonly struct Boolean : global::System.IComparable, global::System.IConvertible, global::System.IComparable<bool>, global::System.IEquatable<bool>
	{
		// Token: 0x0600038F RID: 911 RVA: 0x00014FCC File Offset: 0x000131CC
		[global::Cpp2ILInjected.Token(Token = "0x6000429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7520", Offset = "0x1BB7520", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Nullable<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BrowsableAttribute", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DesignOnlyAttribute", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindableAttribute", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DataObjectAttribute", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DataObjectMethodAttribute", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SettingsBindableAttribute", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalFloat", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInputDeviceDriverType", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInputDeviceTransportType", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInt16", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInt32", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt16", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt32", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00014FCF File Offset: 0x000131CF
		[global::Cpp2ILInjected.Token(Token = "0x600042A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7530", Offset = "0x1BB7530", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 55)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00014FD2 File Offset: 0x000131D2
		[global::Cpp2ILInjected.Token(Token = "0x600042B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB759C", Offset = "0x1BB759C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00014FD5 File Offset: 0x000131D5
		[global::Cpp2ILInjected.Token(Token = "0x600042C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB75A0", Offset = "0x1BB75A0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.GroupOptionButton`1", Member = "get_IsSelected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Nullable<>), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetProperty", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00014FD8 File Offset: 0x000131D8
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x600042D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7618", Offset = "0x1BB7618", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(bool obj)
		{
			throw null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00014FDB File Offset: 0x000131DB
		[global::Cpp2ILInjected.Token(Token = "0x600042E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB762C", Offset = "0x1BB762C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_boolean", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00014FDE File Offset: 0x000131DE
		[global::Cpp2ILInjected.Token(Token = "0x600042F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7700", Offset = "0x1BB7700", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_15", Member = "<.cctor>b__69", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.SortingSteps.ByUnlockState", Member = "Compare", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry", "Terraria.GameContent.Bestiary.BestiaryEntry" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.SortingSteps.AStepByFittingFilter", Member = "Compare", MemberParameters = new object[] { "Terraria.Item", "Terraria.Item" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public int CompareTo(bool value)
		{
			throw null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00014FE1 File Offset: 0x000131E1
		[global::Cpp2ILInjected.Token(Token = "0x6000430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7728", Offset = "0x1BB7728", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BooleanConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool Parse(string value)
		{
			throw null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00014FE4 File Offset: 0x000131E4
		[global::Cpp2ILInjected.Token(Token = "0x6000431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7800", Offset = "0x1BB7800", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool Parse(global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00014FE7 File Offset: 0x000131E7
		[global::Cpp2ILInjected.Token(Token = "0x6000432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7BB4", Offset = "0x1BB7BB4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadBooleanString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Nullable`1<Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse(string value, out bool result)
		{
			throw null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00014FEA File Offset: 0x000131EA
		[global::Cpp2ILInjected.Token(Token = "0x6000433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB78C0", Offset = "0x1BB78C0", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "Parse", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "TrimWhiteSpaceAndNull", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static bool TryParse(global::System.ReadOnlySpan<char> value, out bool result)
		{
			throw null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00014FED File Offset: 0x000131ED
		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7C70", Offset = "0x1BB7C70", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static global::System.ReadOnlySpan<char> TrimWhiteSpaceAndNull(global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00014FF0 File Offset: 0x000131F0
		[global::Cpp2ILInjected.Token(Token = "0x6000435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7E78", Offset = "0x1BB7E78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00014FF3 File Offset: 0x000131F3
		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7E80", Offset = "0x1BB7E80", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00014FF6 File Offset: 0x000131F6
		[global::Cpp2ILInjected.Token(Token = "0x6000437")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7E90", Offset = "0x1BB7E90", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00014FF9 File Offset: 0x000131F9
		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7F14", Offset = "0x1BB7F14", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00014FFC File Offset: 0x000131FC
		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7F78", Offset = "0x1BB7F78", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00014FFF File Offset: 0x000131FF
		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7FDC", Offset = "0x1BB7FDC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00015002 File Offset: 0x00013202
		[global::Cpp2ILInjected.Token(Token = "0x600043B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8040", Offset = "0x1BB8040", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00015005 File Offset: 0x00013205
		[global::Cpp2ILInjected.Token(Token = "0x600043C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB80A4", Offset = "0x1BB80A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00015008 File Offset: 0x00013208
		[global::Cpp2ILInjected.Token(Token = "0x600043D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8108", Offset = "0x1BB8108", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001500B File Offset: 0x0001320B
		[global::Cpp2ILInjected.Token(Token = "0x600043E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB816C", Offset = "0x1BB816C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001500E File Offset: 0x0001320E
		[global::Cpp2ILInjected.Token(Token = "0x600043F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB81D0", Offset = "0x1BB81D0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00015011 File Offset: 0x00013211
		[global::Cpp2ILInjected.Token(Token = "0x6000440")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8234", Offset = "0x1BB8234", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00015014 File Offset: 0x00013214
		[global::Cpp2ILInjected.Token(Token = "0x6000441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB82AC", Offset = "0x1BB82AC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00015017 File Offset: 0x00013217
		[global::Cpp2ILInjected.Token(Token = "0x6000442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8324", Offset = "0x1BB8324", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001501A File Offset: 0x0001321A
		[global::Cpp2ILInjected.Token(Token = "0x6000443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB83DC", Offset = "0x1BB83DC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001501D File Offset: 0x0001321D
		[global::Cpp2ILInjected.Token(Token = "0x6000444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8460", Offset = "0x1BB8460", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00015020 File Offset: 0x00013220
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB90D0", Offset = "0x1BB90D0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Boolean()
		{
			throw null;
		}

		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x4000200")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool m_value;

		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		internal const int True = 1;

		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		internal const int False = 0;

		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		internal const string TrueLiteral = "True";

		// Token: 0x0400011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		internal const string FalseLiteral = "False";

		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		public static readonly string TrueString;

		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		public static readonly string FalseString;
	}
}
