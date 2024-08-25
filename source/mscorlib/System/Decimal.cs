using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x20001AD")]
	[global::System.Serializable]
	[StructLayout(2)]
	public readonly struct Decimal : global::System.IFormattable, global::System.IComparable, global::System.IConvertible, global::System.IComparable<decimal>, global::System.IEquatable<decimal>, global::System.Runtime.Serialization.IDeserializationCallback, global::System.ISpanFormattable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000173")]
		internal uint High
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001017")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C9B4", Offset = "0x1C8C9B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000174")]
		internal uint Low
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001018")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C9BC", Offset = "0x1C8C9BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000175")]
		internal uint Mid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C9C4", Offset = "0x1C8C9C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000176")]
		internal bool IsNegative
		{
			[global::Cpp2ILInjected.Token(Token = "0x600101A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C9CC", Offset = "0x1C8C9CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "DecimalToNumber", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(ref global::System.Number.NumberBuffer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000177")]
		internal int Scale
		{
			[global::Cpp2ILInjected.Token(Token = "0x600101B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C9D8", Offset = "0x1C8C9D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "DecimalToNumber", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(ref global::System.Number.NumberBuffer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000178")]
		private ulong Low64
		{
			[global::Cpp2ILInjected.Token(Token = "0x600101C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8C9E0", Offset = "0x1C8C9E0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecCmpSub", MemberParameters = new object[]
			{
				typeof(ref decimal),
				typeof(ref decimal)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarR8FromDec", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CA40", Offset = "0x1C8CA40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ref decimal.DecCalc AsMutable(ref decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CA44", Offset = "0x1C8CA44", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "DecimalToNumber", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(ref global::System.Number.NumberBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static uint DecDivMod1E9(ref decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CB80", Offset = "0x1C8CB80", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_int", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_short", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_byte", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedShort", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedByte", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public Decimal(int value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CBA4", Offset = "0x1C8CBA4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedInt", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public Decimal(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CBB0", Offset = "0x1C8CBB0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_long", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public Decimal(long value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CBD8", Offset = "0x1C8CBD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Decimal(ulong value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8CBE8", Offset = "0x1C8CBE8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Decimal(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D014", Offset = "0x1C8D014", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Decimal(double value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D454", Offset = "0x1C8D454", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsValid(int flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D474", Offset = "0x1C8D474", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryReader), Member = "ReadDecimal", ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Decimal(int[] bits)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D588", Offset = "0x1C8D588", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberBufferToDecimal", MemberParameters = new object[]
		{
			typeof(ref global::System.Number.NumberBuffer),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.DecimalConstantAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(uint),
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_decimal", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_nonPositiveInteger", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_negativeInteger", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_nonNegativeInteger", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_positiveInteger", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaComplexType", Member = "CreateAnyType", MemberParameters = new object[] { "System.Xml.Schema.XmlSchemaContentProcessing" }, ReturnType = "System.Xml.Schema.XmlSchemaComplexType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D620", Offset = "0x1C8D620", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D6D4", Offset = "0x1C8D6D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private Decimal(in decimal d, int flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600102A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D6E4", Offset = "0x1C8D6E4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_decimal", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public int CompareTo(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600102B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D8D0", Offset = "0x1C8D8D0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int CompareTo(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600102C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8D960", Offset = "0x1C8D960", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600102D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8DA3C", Offset = "0x1C8DA3C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600102E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8DAD4", Offset = "0x1C8DAD4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600102F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8DDB8", Offset = "0x1C8DDB8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8DE64", Offset = "0x1C8DE64", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteDecimal", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8DF20", Offset = "0x1C8DF20", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8DFF8", Offset = "0x1C8DFF8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E0C4", Offset = "0x1C8E0C4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryParser), Member = "ReadDecimal", ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static decimal Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E198", Offset = "0x1C8E198", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDecimal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInteger", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static decimal Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E27C", Offset = "0x1C8E27C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToDecimal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref decimal)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInteger", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref decimal)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadDecimalString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Nullable`1<Decimal>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseDecimal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out decimal result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E374", Offset = "0x1C8E374", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int[] GetBits(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E3DC", Offset = "0x1C8E3DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static decimal Negate(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E3E4", Offset = "0x1C8E3E4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(int),
			typeof(global::System.MidpointRounding)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static decimal Round(decimal d, int decimals)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E478", Offset = "0x1C8E478", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static decimal Round(ref decimal d, int decimals, global::System.MidpointRounding mode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600103A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8E894", Offset = "0x1C8E894", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static byte ToByte(decimal value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600103B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8EB74", Offset = "0x1C8EB74", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static sbyte ToSByte(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600103C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8EE60", Offset = "0x1C8EE60", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static short ToInt16(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600103D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8EFD8", Offset = "0x1C8EFD8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarR8FromDec", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static double ToDouble(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600103E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8ECEC", Offset = "0x1C8ECEC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToSByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static int ToInt32(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600103F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F108", Offset = "0x1C8F108", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "get_Low64", ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static long ToInt64(decimal d)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F274", Offset = "0x1C8F274", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static ushort ToUInt16(decimal value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8EA0C", Offset = "0x1C8EA0C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToUInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static uint ToUInt32(decimal d)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F3EC", Offset = "0x1C8F3EC", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "get_Low64", ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static ulong ToUInt64(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F54C", Offset = "0x1C8F54C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarR4FromDec", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float ToSingle(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F628", Offset = "0x1C8F628", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static decimal Truncate(decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F728", Offset = "0x1C8F728", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(uint),
			typeof(decimal.DecCalc.RoundingMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		private static void Truncate(ref decimal d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F7C0", Offset = "0x1C8F7C0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static implicit operator decimal(byte value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F7CC", Offset = "0x1C8F7CC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static implicit operator decimal(sbyte value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F7E4", Offset = "0x1C8F7E4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(short),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static implicit operator decimal(short value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F7FC", Offset = "0x1C8F7FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static implicit operator decimal(ushort value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600104A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F808", Offset = "0x1C8F808", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static implicit operator decimal(char value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600104B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F814", Offset = "0x1C8F814", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "GetTrackerValues", ReturnType = "System.Tuple`2<Decimal, Decimal>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(int),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToDecimal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static implicit operator decimal(int value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600104C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F828", Offset = "0x1C8F828", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static implicit operator decimal(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600104D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F834", Offset = "0x1C8F834", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(long),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToDecimal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static implicit operator decimal(long value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600104E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F84C", Offset = "0x1C8F84C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			"System.Xml.XmlNameTable",
			"System.Xml.IXmlNamespaceResolver",
			typeof(ref object)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			"System.Xml.IXmlNamespaceResolver"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeTypeWildcardDestination", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			"System.Xml.IXmlNamespaceResolver"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static implicit operator decimal(ulong value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600104F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F858", Offset = "0x1C8F858", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "GetTrackerValues", ReturnType = "System.Tuple`2<Decimal, Decimal>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static explicit operator decimal(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F89C", Offset = "0x1C8F89C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static explicit operator decimal(double value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F8E0", Offset = "0x1C8F8E0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "DrawSelf", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.SpriteBatch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static explicit operator int(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F944", Offset = "0x1C8F944", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static explicit operator long(decimal value)
		{
			throw null;
		}

		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8F9A8", Offset = "0x1C8F9A8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static explicit operator ulong(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8FA0C", Offset = "0x1C8FA0C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "DrawSelf", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.SpriteBatch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToSingle", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static explicit operator float(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8FA70", Offset = "0x1C8FA70", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToDouble", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static explicit operator double(decimal value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8FAD4", Offset = "0x1C8FAD4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "DecAddSub", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(ref decimal.DecCalc),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static decimal operator -(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C901D4", Offset = "0x1C901D4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecMul", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(ref decimal.DecCalc)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static decimal operator *(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C906D0", Offset = "0x1C906D0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "DrawSelf", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.SpriteBatch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(ref decimal.DecCalc)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static decimal operator /(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C910A4", Offset = "0x1C910A4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIAchievementsMenu", Member = "AchievementDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIAchievementListItem", Member = "DrawSelf", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.SpriteBatch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.SequenceNode", Member = "get_IsNullable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.Collections.ArrayList),
			"System.Xml.Schema.XmlValueConverter"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator ==(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91134", Offset = "0x1C91134", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.ParticleContentValidator", Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new object[] { "System.Xml.Schema.BitSet", "System.Xml.Schema.BitSet[]", "System.Xml.Schema.BitSet&" }, ReturnType = "System.Xml.Schema.BitSet[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator !=(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C911C4", Offset = "0x1C911C4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator <(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91250", Offset = "0x1C91250", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator <=(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C912E0", Offset = "0x1C912E0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator >(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91370", Offset = "0x1C91370", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(decimal),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
		{
			typeof(ref decimal),
			typeof(ref decimal)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator >=(decimal d1, decimal d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91400", Offset = "0x1C91400", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91408", Offset = "0x1C91408", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91468", Offset = "0x1C91468", Length = "0x84")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C914EC", Offset = "0x1C914EC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9154C", Offset = "0x1C9154C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C915AC", Offset = "0x1C915AC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9160C", Offset = "0x1C9160C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9166C", Offset = "0x1C9166C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C916CC", Offset = "0x1C916CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9172C", Offset = "0x1C9172C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9178C", Offset = "0x1C9178C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600106A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C917EC", Offset = "0x1C917EC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600106B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9184C", Offset = "0x1C9184C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600106C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C918AC", Offset = "0x1C918AC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600106D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C918B8", Offset = "0x1C918B8", Length = "0x84")]
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

		[global::Cpp2ILInjected.Token(Token = "0x600106E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9193C", Offset = "0x1C9193C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600106F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C91A10", Offset = "0x1C91A10", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Decimal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40008C7")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public const decimal Zero = 0m;

		[global::Cpp2ILInjected.Token(Token = "0x40008C8")]
		[global::System.Runtime.InteropServices.FieldOffset(16)]
		public const decimal One = 1m;

		[global::Cpp2ILInjected.Token(Token = "0x40008C9")]
		[global::System.Runtime.InteropServices.FieldOffset(32)]
		public const decimal MinusOne = -1m;

		[global::Cpp2ILInjected.Token(Token = "0x40008CA")]
		[global::System.Runtime.InteropServices.FieldOffset(48)]
		public const decimal MaxValue = 79228162514264337593543950335m;

		[global::Cpp2ILInjected.Token(Token = "0x40008CB")]
		[global::System.Runtime.InteropServices.FieldOffset(64)]
		public const decimal MinValue = -79228162514264337593543950335m;

		[global::Cpp2ILInjected.Token(Token = "0x40008CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		private readonly int flags;

		[global::Cpp2ILInjected.Token(Token = "0x40008CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		[global::System.Runtime.InteropServices.FieldOffset(4)]
		private readonly int hi;

		[global::Cpp2ILInjected.Token(Token = "0x40008CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		private readonly int lo;

		[global::Cpp2ILInjected.Token(Token = "0x40008CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		[global::System.Runtime.InteropServices.FieldOffset(12)]
		private readonly int mid;

		[global::Cpp2ILInjected.Token(Token = "0x40008D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[global::System.NonSerialized]
		[global::System.Runtime.InteropServices.FieldOffset(8)]
		private readonly ulong ulomidLE;

		[global::Cpp2ILInjected.Token(Token = "0x20001AE")]
		[StructLayout(2)]
		private struct DecCalc
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000179")]
			private uint High
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001070")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91A9C", Offset = "0x1C91A9C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001071")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91AA4", Offset = "0x1C91AA4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700017A")]
			private uint Low
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001072")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91AAC", Offset = "0x1C91AAC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001073")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91AB4", Offset = "0x1C91AB4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700017B")]
			private uint Mid
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001074")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91ABC", Offset = "0x1C91ABC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001075")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91AC4", Offset = "0x1C91AC4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700017C")]
			private bool IsNegative
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001076")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91ACC", Offset = "0x1C91ACC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700017D")]
			private ulong Low64
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001077")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91AD8", Offset = "0x1C91AD8", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "DecAddSub", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(ref decimal.DecCalc),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(ref decimal.DecCalc)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(uint),
					"System.Decimal.DecCalc.RoundingMode"
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6001078")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C91B38", Offset = "0x1C91B38", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "UInt64x64To128", MemberParameters = new object[]
				{
					typeof(ulong),
					typeof(ulong),
					typeof(ref decimal.DecCalc)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "DecAddSub", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(ref decimal.DecCalc),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecMul", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(ref decimal.DecCalc)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecFromR4", MemberParameters = new object[]
				{
					typeof(float),
					typeof(ref decimal.DecCalc)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecFromR8", MemberParameters = new object[]
				{
					typeof(double),
					typeof(ref decimal.DecCalc)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(ref decimal.DecCalc)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "InternalRound", MemberParameters = new object[]
				{
					typeof(ref decimal.DecCalc),
					typeof(uint),
					"System.Decimal.DecCalc.RoundingMode"
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001079")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91BB4", Offset = "0x1C91BB4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static uint GetExponent(float f)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600107A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91BC0", Offset = "0x1C91BC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static uint GetExponent(double d)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600107B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91BCC", Offset = "0x1C91BCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static ulong UInt32x32To64(uint a, uint b)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600107C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91BD4", Offset = "0x1C91BD4", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecFromR4", MemberParameters = new object[]
			{
				typeof(float),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecFromR8", MemberParameters = new object[]
			{
				typeof(double),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private static void UInt64x64To128(ulong a, ulong b, ref decimal.DecCalc result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600107D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91CE4", Offset = "0x1C91CE4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_High64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "set_High64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			private static uint Div96By32(ref decimal.DecCalc.Buf12 bufNum, uint den)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600107E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91F34", Offset = "0x1C91F34", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600107F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C91F78", Offset = "0x1C91F78", Length = "0x25C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			private static void Unscale(ref uint low, ref ulong high64, ref int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001080")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C921D4", Offset = "0x1C921D4", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_High64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static uint Div96By64(ref decimal.DecCalc.Buf12 bufNum, ulong den)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001081")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C922E0", Offset = "0x1C922E0", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "get_High64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static uint Div128By96(ref decimal.DecCalc.Buf16 bufNum, ref decimal.DecCalc.Buf12 bufDen)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001082")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C92560", Offset = "0x1C92560", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static uint IncreaseScale(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001083")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C925E8", Offset = "0x1C925E8", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "set_High64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static void IncreaseScale64(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001084")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C92664", Offset = "0x1C92664", Length = "0xBD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "DecAddSub", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecMul", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private unsafe static int ScaleResult(decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001085")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9323C", Offset = "0x1C9323C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			private unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001086")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C93290", Offset = "0x1C93290", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			private static int LeadingZeroCount(uint value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001087")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C932F8", Offset = "0x1C932F8", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "Add32To96", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(uint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private static int OverflowUnscale(ref decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001088")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C93468", Offset = "0x1C93468", Length = "0x1CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private static int SearchScale(ref decimal.DecCalc.Buf12 bufQuo, int scale)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C93414", Offset = "0x1C93414", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "OverflowUnscale", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecDiv", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			private static bool Add32To96(ref decimal.DecCalc.Buf12 bufNum, uint value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600108A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8FB88", Offset = "0x1C8FB88", Length = "0x64C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf24", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf24", Member = "set_Mid64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf24", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "ScaleResult", MemberParameters = new object[]
			{
				typeof(decimal.DecCalc.Buf24*),
				typeof(uint),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			internal unsafe static void DecAddSub(ref decimal.DecCalc d1, ref decimal.DecCalc d2, bool sign)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600108B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8D800", Offset = "0x1C8D800", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "CompareTo", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Equals", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_LessThanOrEqual", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_GreaterThan", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarDecCmpSub", MemberParameters = new object[]
			{
				typeof(ref decimal),
				typeof(ref decimal)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static int VarDecCmp(in decimal d1, in decimal d2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600108C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C9378C", Offset = "0x1C9378C", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarDecCmp", MemberParameters = new object[]
			{
				typeof(ref decimal),
				typeof(ref decimal)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static int VarDecCmpSub(in decimal d1, in decimal d2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600108D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C90284", Offset = "0x1C90284", Length = "0x44C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf24", Member = "set_Mid64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf24", Member = "set_High64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "ScaleResult", MemberParameters = new object[]
			{
				typeof(decimal.DecCalc.Buf24*),
				typeof(uint),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf24", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal unsafe static void VarDecMul(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600108E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8CC70", Offset = "0x1C8CC70", Length = "0x3A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "UInt64x64To128", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(ulong),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal static void VarDecFromR4(float input, out decimal.DecCalc result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600108F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8D09C", Offset = "0x1C8D09C", Length = "0x3B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "UInt64x64To128", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(ulong),
				typeof(ref decimal.DecCalc)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			internal static void VarDecFromR8(double input, out decimal.DecCalc result)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001090")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8F5CC", Offset = "0x1C8F5CC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToSingle", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "VarR8FromDec", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static float VarR4FromDec(in decimal value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001091")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8F058", Offset = "0x1C8F058", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal.DecCalc), Member = "VarR4FromDec", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToDouble", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static double VarR8FromDec(in decimal value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001092")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8DB28", Offset = "0x1C8DB28", Length = "0x290")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			internal static int GetHashCode(in decimal d)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001093")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C90780", Offset = "0x1C90780", Length = "0x924")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "op_Division", MemberParameters = new object[]
			{
				typeof(decimal),
				typeof(decimal)
			}, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "set_High64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "Div128By96", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf16),
				typeof(ref decimal.DecCalc.Buf12)
			}, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "SearchScale", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "IncreaseScale", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(uint)
			}, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "Add32To96", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(uint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf16", Member = "get_High64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "Div96By32", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(uint)
			}, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "OverflowUnscale", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "Div96By64", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(ulong)
			}, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "IncreaseScale64", MemberParameters = new object[]
			{
				typeof(ref decimal.DecCalc.Buf12),
				typeof(uint)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Decimal.DecCalc.Buf12", Member = "get_High64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DivideByZeroException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
			internal static void VarDecDiv(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001094")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8E628", Offset = "0x1C8E628", Length = "0x26C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
			{
				typeof(ref decimal),
				typeof(int),
				typeof(global::System.MidpointRounding)
			}, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Truncate", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(decimal))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Truncate", MemberParameters = new object[] { typeof(ref decimal) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "get_Low64", ReturnType = typeof(ulong))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal.DecCalc), Member = "set_Low64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal static void InternalRound(ref decimal.DecCalc d, uint scale, decimal.DecCalc.RoundingMode mode)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001095")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C8CB18", Offset = "0x1C8CB18", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal static uint DecDivMod1E9(ref decimal.DecCalc value)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001096")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C939F8", Offset = "0x1C939F8", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(global::System.RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			static DecCalc()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40008D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			private uint uflags;

			[global::Cpp2ILInjected.Token(Token = "0x40008D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			[global::System.Runtime.InteropServices.FieldOffset(4)]
			private uint uhi;

			[global::Cpp2ILInjected.Token(Token = "0x40008D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			[global::System.Runtime.InteropServices.FieldOffset(8)]
			private uint ulo;

			[global::Cpp2ILInjected.Token(Token = "0x40008D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			[global::System.Runtime.InteropServices.FieldOffset(12)]
			private uint umid;

			[global::Cpp2ILInjected.Token(Token = "0x40008D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			[global::System.Runtime.InteropServices.FieldOffset(8)]
			private ulong ulomidLE;

			[global::Cpp2ILInjected.Token(Token = "0x40008D6")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			private static readonly uint[] s_powers10;

			[global::Cpp2ILInjected.Token(Token = "0x40008D7")]
			[global::System.Runtime.InteropServices.FieldOffset(8)]
			private static readonly ulong[] s_ulongPowers10;

			[global::Cpp2ILInjected.Token(Token = "0x40008D8")]
			[global::System.Runtime.InteropServices.FieldOffset(16)]
			private static readonly double[] s_doublePowers10;

			[global::Cpp2ILInjected.Token(Token = "0x40008D9")]
			[global::System.Runtime.InteropServices.FieldOffset(24)]
			private static readonly decimal.DecCalc.PowerOvfl[] PowerOvflValues;

			[global::Cpp2ILInjected.Token(Token = "0x20001AF")]
			internal enum RoundingMode
			{
				[global::Cpp2ILInjected.Token(Token = "0x40008DB")]
				ToEven,
				[global::Cpp2ILInjected.Token(Token = "0x40008DC")]
				AwayFromZero,
				[global::Cpp2ILInjected.Token(Token = "0x40008DD")]
				Truncate,
				[global::Cpp2ILInjected.Token(Token = "0x40008DE")]
				Floor,
				[global::Cpp2ILInjected.Token(Token = "0x40008DF")]
				Ceiling
			}

			[global::Cpp2ILInjected.Token(Token = "0x20001B0")]
			private struct PowerOvfl
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001097")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C93BB8", Offset = "0x1C93BB8", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public PowerOvfl(uint hi, uint mid, uint lo)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40008E0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public readonly uint Hi;

				[global::Cpp2ILInjected.Token(Token = "0x40008E1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				public readonly ulong MidLo;
			}

			[global::Cpp2ILInjected.Token(Token = "0x20001B1")]
			[StructLayout(2)]
			private struct Buf12
			{
				[global::Cpp2ILInjected.Token(Token = "0x1700017E")]
				public ulong Low64
				{
					[global::Cpp2ILInjected.Token(Token = "0x6001098")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C91E58", Offset = "0x1C91E58", Length = "0x60")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By32", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By64", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(ulong)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div128By96", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf16),
						typeof(ref decimal.DecCalc.Buf12)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "SearchScale", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(int)
					}, ReturnType = typeof(int))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Add32To96", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(bool))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					get
					{
						throw null;
					}
					[global::Cpp2ILInjected.Token(Token = "0x6001099")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C91EB8", Offset = "0x1C91EB8", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By32", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By64", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(ulong)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Add32To96", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(bool))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x1700017F")]
				public ulong High64
				{
					[global::Cpp2ILInjected.Token(Token = "0x600109A")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C91D7C", Offset = "0x1C91D7C", Length = "0x60")]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By32", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By64", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(ulong)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					get
					{
						throw null;
					}
					[global::Cpp2ILInjected.Token(Token = "0x600109B")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C91DDC", Offset = "0x1C91DDC", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div96By32", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "IncreaseScale64", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf12),
						typeof(uint)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x40008E2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				[global::System.Runtime.InteropServices.FieldOffset(0)]
				public uint U0;

				[global::Cpp2ILInjected.Token(Token = "0x40008E3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				[global::System.Runtime.InteropServices.FieldOffset(4)]
				public uint U1;

				[global::Cpp2ILInjected.Token(Token = "0x40008E4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				[global::System.Runtime.InteropServices.FieldOffset(8)]
				public uint U2;

				[global::Cpp2ILInjected.Token(Token = "0x40008E5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				[global::System.Runtime.InteropServices.FieldOffset(0)]
				private ulong ulo64LE;

				[global::Cpp2ILInjected.Token(Token = "0x40008E6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				[global::System.Runtime.InteropServices.FieldOffset(4)]
				private ulong uhigh64LE;
			}

			[global::Cpp2ILInjected.Token(Token = "0x20001B2")]
			[StructLayout(2)]
			private struct Buf16
			{
				[global::Cpp2ILInjected.Token(Token = "0x17000180")]
				public ulong Low64
				{
					[global::Cpp2ILInjected.Token(Token = "0x600109C")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C92484", Offset = "0x1C92484", Length = "0x60")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div128By96", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf16),
						typeof(ref decimal.DecCalc.Buf12)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					get
					{
						throw null;
					}
					[global::Cpp2ILInjected.Token(Token = "0x600109D")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C924E4", Offset = "0x1C924E4", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div128By96", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf16),
						typeof(ref decimal.DecCalc.Buf12)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x17000181")]
				public ulong High64
				{
					[global::Cpp2ILInjected.Token(Token = "0x600109E")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C92424", Offset = "0x1C92424", Length = "0x60")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "Div128By96", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc.Buf16),
						typeof(ref decimal.DecCalc.Buf12)
					}, ReturnType = typeof(uint))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					get
					{
						throw null;
					}
					[global::Cpp2ILInjected.Token(Token = "0x600109F")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C9397C", Offset = "0x1C9397C", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x40008E7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				[global::System.Runtime.InteropServices.FieldOffset(0)]
				public uint U0;

				[global::Cpp2ILInjected.Token(Token = "0x40008E8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				[global::System.Runtime.InteropServices.FieldOffset(4)]
				public uint U1;

				[global::Cpp2ILInjected.Token(Token = "0x40008E9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				[global::System.Runtime.InteropServices.FieldOffset(8)]
				public uint U2;

				[global::Cpp2ILInjected.Token(Token = "0x40008EA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
				[global::System.Runtime.InteropServices.FieldOffset(12)]
				public uint U3;

				[global::Cpp2ILInjected.Token(Token = "0x40008EB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				[global::System.Runtime.InteropServices.FieldOffset(0)]
				private ulong ulo64LE;

				[global::Cpp2ILInjected.Token(Token = "0x40008EC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				[global::System.Runtime.InteropServices.FieldOffset(8)]
				private ulong uhigh64LE;
			}

			[global::Cpp2ILInjected.Token(Token = "0x20001B3")]
			[StructLayout(2)]
			private struct Buf24
			{
				[global::Cpp2ILInjected.Token(Token = "0x17000182")]
				public ulong Low64
				{
					[global::Cpp2ILInjected.Token(Token = "0x60010A0")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C9372C", Offset = "0x1C9372C", Length = "0x60")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "DecAddSub", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc),
						typeof(bool)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecMul", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					get
					{
						throw null;
					}
					[global::Cpp2ILInjected.Token(Token = "0x60010A1")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C93634", Offset = "0x1C93634", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "DecAddSub", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc),
						typeof(bool)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x17000183")]
				public ulong Mid64
				{
					[global::Cpp2ILInjected.Token(Token = "0x60010A2")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C936B0", Offset = "0x1C936B0", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "DecAddSub", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc),
						typeof(bool)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecMul", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x17000184")]
				public ulong High64
				{
					[global::Cpp2ILInjected.Token(Token = "0x60010A3")]
					[global::Cpp2ILInjected.Address(RVA = "0x1C93900", Offset = "0x1C93900", Length = "0x7C")]
					[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecMul", MemberParameters = new object[]
					{
						typeof(ref decimal.DecCalc),
						typeof(ref decimal.DecCalc)
					}, ReturnType = typeof(void))]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					set
					{
						throw null;
					}
				}

				[global::Cpp2ILInjected.Token(Token = "0x40008ED")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				[global::System.Runtime.InteropServices.FieldOffset(0)]
				public uint U0;

				[global::Cpp2ILInjected.Token(Token = "0x40008EE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
				[global::System.Runtime.InteropServices.FieldOffset(4)]
				public uint U1;

				[global::Cpp2ILInjected.Token(Token = "0x40008EF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				[global::System.Runtime.InteropServices.FieldOffset(8)]
				public uint U2;

				[global::Cpp2ILInjected.Token(Token = "0x40008F0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
				[global::System.Runtime.InteropServices.FieldOffset(12)]
				public uint U3;

				[global::Cpp2ILInjected.Token(Token = "0x40008F1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				[global::System.Runtime.InteropServices.FieldOffset(16)]
				public uint U4;

				[global::Cpp2ILInjected.Token(Token = "0x40008F2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				[global::System.Runtime.InteropServices.FieldOffset(20)]
				public uint U5;

				[global::Cpp2ILInjected.Token(Token = "0x40008F3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				[global::System.Runtime.InteropServices.FieldOffset(0)]
				private ulong ulo64LE;

				[global::Cpp2ILInjected.Token(Token = "0x40008F4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				[global::System.Runtime.InteropServices.FieldOffset(8)]
				private ulong umid64LE;

				[global::Cpp2ILInjected.Token(Token = "0x40008F5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				[global::System.Runtime.InteropServices.FieldOffset(16)]
				private ulong uhigh64LE;
			}
		}
	}
}
